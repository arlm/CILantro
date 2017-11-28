# collect tests

cls

Write-Host "Collecting tests..." -foreground "yellow"
Write-Host

Invoke-Expression ./collect-tests.ps1

# get all tests

$allTests = Get-ChildItem "..\tests"
$allTestsCount = $allTests.Length

# generate input for tests

cls

Write-Host "Generating input data..." -foreground "yellow"
Write-Host

$testsAfterGeneratingInputData = @()
$errors = @()

foreach($test in $allTests)
{	
	$testNameInfo = $test.Name + " "
	Write-Host -NoNewLine $testNameInfo

	$generateInputDataCommand = "& ./generate-input-data.ps1 " + $test.Name + " " + '"' + $test.FullName + "\in" + '"' + " `$false"
	$generateInputDataResult = Invoke-Expression $generateInputDataCommand
	
	if($generateInputDataResult -match "^SUCCESS.*")
	{
		$testsAfterGeneratingInputData = $testsAfterGeneratingInputData += $test
	}
	else
	{
		$errorMessage = $test.Name + " - cannot generate input data"
		$errors += $errorMessage
	}
}

# generate execs

cls

Write-Host "Generating execs..." -foreground "yellow"
Write-Host

foreach($test in $testsAfterGeneratingInputData)
{
	$ilasmCommand = "& ilasm " + '"' + $test.FullName + "\src\program.il" + '"'
	Invoke-Expression $ilasmCommand | Out-Null
}

# generate out from execs

cls

Write-Host "Generating output data from execs..." -foreground "yellow"
Write-Host

$allInDataFilesCount = 0

foreach($test in $testsAfterGeneratingInputData)
{
	$inDataPath = $test.FullName + "\in"
	$inDataFiles = Get-ChildItem $inDataPath
	
	$outDataPath = $test.FullName + "\out-exe"
	New-Item $outDataPath -type directory | Out-Null
	
	$allInDataFilesCount += $inDataFiles.Count
	
	foreach($inDataFile in $inDataFiles)
	{
		$outDataFilePath = $outDataPath + "\" + $inDataFile.BaseName + ".out"
		New-Item $outDataFilePath | Out-Null
	
		$exeCommand = '"' + $test.FullName + "\src\program.exe" + '"'
		Start-Process $exeCommand -RedirectStandardInput $inDataFile.FullName -RedirectStandardOutput $outDataFilePath
		
		echo $outDataFilePath
		echo $result
	}
}

# summary

cls

$allTestsCountInfo = $allTestsCount.ToString() + " tests have been processed."
Write-Host $allTestsCountInfo -foreground "yellow"

$allInDataFilesCountInfo = $allInDataFilesCount.ToString() + " input data files have been processed."
Write-Host $allInDataFilesCountInfo -foreground "yellow"

$testsAfterGeneratingInputDataCount = $testsAfterGeneratingInputData.Length
$testsAfterGeneratingPercent = $testsAfterGeneratingInputDataCount / $allTestsCount * 100
$generateInputDataCountInfo  = $testsAfterGeneratingInputDataCount.ToString() + " / " + $allTestsCount.ToString() + " (" + "{0:N2}" -f $testsAfterGeneratingPercent + " %)" + " tests have passed input data generation phase."
$generateInputDataCountInfoColor = "red"
if($testsAfterGeneratingInputDataCount -eq $allTestsCount)
{
	$generateInputDataCountInfoColor = "green"
}
Write-Host
Write-Host $generateInputDataCountInfo -foreground $generateInputDataCountInfoColor

if($errors.length -gt 0)
{
	Write-Host
	Write-Host "List of errors:" -foreground "red"
	foreach($error in $errors)
	{
		Write-Host $error -foreground "red"
	}
}

Write-Host
Write-Host "Press any key to continue..." -foreground "yellow"

$null = $Host.UI.RawUI.ReadKey('NoEcho,IncludeKeyDown');

cls