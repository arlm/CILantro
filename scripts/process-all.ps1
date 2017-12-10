param
(
	[bool]$StopOnError = $false
)

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
		$errorMessage = $test.Name + " - input data could not have been generated"
		$errors += $errorMessage
		
		if($StopOnError)
		{
			$testsAfterGeneratingInputData = @()
			break
		}
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
		Start-Process $exeCommand -RedirectStandardInput $inDataFile.FullName -RedirectStandardOutput $outDataFilePath -NoNewWindow
		
		echo $outDataFilePath
		echo $result
	}
}

# parse tests by cilantro parser

cls

Write-Host "Parsing tests by CILantro parser..." -foreground "yellow"
Write-Host

$testsAfterCilantroParser = @()

foreach($test in $testsAfterGeneratingInputData)
{
	$testNameInfo = $test.Name + " "
	Write-Host -NoNewLine $testNameInfo

	$testSrcPath = $test.FullName + "\src\program.il"
	
	$cilantroParserCommand = "& ./cilantro-engine.ps1 " + '"' + $testSrcPath + '"' + " " + '"null"' + " " + '"null"' + " " + "`$false" + " " + '"parse-only"'
	$cilantroParserResult = Invoke-Expression $cilantroParserCommand
	
	if($cilantroParserResult -match "^SUCCESS.*")
	{
		$testsAfterCilantroParser = $testsAfterCilantroParser += $test
	}
	else
	{
		$errorMessage = $test.Name + " - could not have been parsed by CILantro parser"
		$errors += $errorMessage
		
		if($StopOnError)
		{
			$testsAfterCilantroParser = @()
			break
		}
	}
}

# process tests by cilantro engine

cls

Write-Host "Processing tests by CILantro engine..." -foreground "yellow"
Write-Host

$testsAfterCilantroEngine = @()

foreach($test in $testsAfterCilantroParser)
{
	$inDataPath = $test.FullName + "\in"
	$inDataFiles = Get-ChildItem $inDataPath
	
	$outDataPath = $test.FullName + "\out-cilantro"
	New-Item $outDataPath -type directory | Out-Null
	
	$testSrcPath = $test.FullName + "\src\program.il"
	
	$cilantroEngineSuccess = $true
	
	foreach($inDataFile in $inDataFiles)
	{
		$testNameInfo = $test.Name + " - " + $inDataFile.Name + " "
		Write-Host -NoNewLine $testNameInfo
	
		$outDataFilePath = $outDataPath + "\" + $inDataFile.BaseName + ".out"
		New-Item $outDataFilePath | Out-Null
		
		$cilantroEngineCommand = "& ./cilantro-engine.ps1 " + '"' + $testSrcPath + '"' + " " + '"' + $inDataFile.FullName + '"' + " " + '"' + $outDataFilePath + '"' + " " + "`$false"
		$cilantroEngineResult = Invoke-Expression $cilantroEngineCommand
		
		if($cilantroEngineResult -match "^SUCCESS.*")
		{
		}
		else
		{
			$cilantroEngineSuccess = $false
			
			$errorMessage = $test.Name + " - " + $inDataFile.Name + " - could not have been processed by CILantro engine"
			$errors += $errorMessage
			
			if($StopOnError)
			{
				break
			}
		}
	}
	
	if($cilantroEngineSuccess)
	{
		$testsAfterCilantroEngine = $testsAfterCilantroEngine += $test
	}
	else
	{
		if($StopOnError)
		{
			$testsAfterCilantroEngine = @()
			break
		}
	}
}

# generate output checker

cls

Write-Host "Generating output data checkers..." -foreground "yellow"
Write-Host

$testsAfterGeneratingOutputDataCheckers = @()

foreach($test in $testsAfterCilantroEngine)
{
	$testNameInfo = $test.Name + " "
	Write-Host -NoNewLine $testNameInfo
	
	$generateOutputDataCheckerCommand = "& ./generate-output-data-checker.ps1 " + $test.Name + " `$false"
	$generateOutputDataCheckerResult = Invoke-Expression $generateOutputDataCheckerCommand
	
	if($generateOutputDataCheckerResult -match "^SUCCESS.*")
	{
		$testsAfterGeneratingOutputDataCheckers = $testsAfterGeneratingOutputDataCheckers += $test
	}
	else
	{
		$errorMessage = $test.Name + " - output data checker could not have been generated"
		$errors += $errorMessage
		
		if($StopOnError)
		{
			$testsAfterGeneratingOutputDataCheckers = @()
			break
		}
	}
}

# check outputs

cls

Write-Host "Checking output data..." -foreground "yellow"
Write-Host

$testsAfterCheckingOutput = @()

foreach($test in $testsAfterGeneratingOutputDataCheckers)
{
	$inDataPath = $test.FullName + "\in"
	$inDataFiles = Get-ChildItem $inDataPath
	
	$outExeDataPath = $test.FullName + "\out-exe"
	$outCilantroDataPath = $test.FullName + "\out-cilantro"
	
	$checkOutputSuccess = $true
	
	foreach($inDataFile in $inDataFiles)
	{
		$inDataFilePath = $inDataFile.FullName
		$outExeFilePath = $outExeDataPath + "\" + $inDataFile.BaseName + ".out"
		$outCilantroFilePath = $outCilantroDataPath + "\" + $inDataFile.BaseName + ".out"
		
		$testNameInfo = $test.Name + " - " + $inDataFile.Name + " "
		Write-Host -NoNewLine $testnameInfo
		
		$checkOutputCommand = "& ./check-output.ps1 " + $test.Name + " " + '"' + $inDataFilePath + '"' + " " + '"' + $outExeFilePath + '"' + " " + '"' + $outCilantroFilePath + '"' + " `$false"
		$checkOutputResult = Invoke-Expression $checkOutputCommand
		
		if($checkOutputResult -match "^SUCCESS.*")
		{
		}
		else
		{
			$checkOutputSuccess = $false
			
			$errorMessage = $test.Name + " - " + $inDataFile.Name + " - output has been incorrect"
			$errors += $errorMessage
			
			if($StopOnError)
			{
				break
			}
		}
	}
	
	if($checkOutputSuccess)
	{
		$testsAfterCheckingOutput = $testsAfterCheckingOutput += $test
	}
	else
	{
		if($StopOnError)
		{
			$testsAfterCheckingOutput = @()
			break
		}
	}
}

# check documentation

cls

Write-Host "Checking documentation..." -foreground "yellow"
Write-Host

$testsAfterCheckingDocs = @()

foreach($test in $testsAfterCheckingOutput)
{
	$testNameInfo = $test.Name + " "
	Write-Host -NoNewLine $testNameInfo

	$docsPath = $test.FullName + "\docs"
	
	$checkDocsCommand = "& ./check-docs.ps1 " + $test.Name + " " + '"' + $docsPath + '"' + " `$false"
	$checkDocsResult = Invoke-Expression $checkDocsCommand
	
	if($checkDocsResult -match "^SUCCESS.*")
	{
		$testsAfterCheckingDocs = $testsAfterCheckingDocs += $test
	}
	else
	{
		$errorMessage = $test.Name + " - documentation could not be found"
		$errors += $errorMessage
		
		if($StopOnError)
		{
			$testsAfterCheckingDocs = @()
			break
		}
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
$generateInputDataCountInfo  = $testsAfterGeneratingInputDataCount.ToString() + " / " + $allTestsCount.ToString() + " (" + "{0:N2}" -f $testsAfterGeneratingPercent + " %)" + " tests have had input data generated."
$generateInputDataCountInfoColor = "red"
if($testsAfterGeneratingInputDataCount -eq $allTestsCount)
{
	$generateInputDataCountInfoColor = "green"
}
Write-Host
Write-Host $generateInputDataCountInfo -foreground $generateInputDataCountInfoColor

$testsAfterCilantroParserCount = $testsAfterCilantroParser.Length
$testsAfterCilantroParserPercent = $testsAfterCilantroParserCount / $allTestsCount * 100
$cilantroParserCountInfo = $testsAfterCilantroParserCount.ToString() + " / " + $alltestsCount.ToString() + " (" + "{0:N2}" -f $testsAfterCilantroParserPercent + " %)" + " tests have been parsed by CILantro parser."
$cilantroParserCountInfoColor = "red"
if($testsAfterCilantroParserCount -eq $allTestsCount)
{
	$cilantroParserCountInfoColor = "green"
}
Write-Host $cilantroParserCountInfo -foreground $cilantroParserCountInfoColor

$testsAfterCilantroEngineCount = $testsAfterCilantroEngine.Length
$testsAfterCilantroEnginePercent = $testsAfterCilantroEngineCount / $allTestsCount * 100
$cilantroEngineCountInfo = $testsAfterCilantroEngineCount.ToString() + " / " + $allTestsCount.ToString() + " (" + "{0:N2}" -f $testsAfterCilantroEnginePercent + " %)" + " tests have been processed by CILantro engine."
$cilantroEngineCountInfoColor = "red"
if($testsAfterCilantroEngineCount -eq $allTestsCount)
{
	$cilantroEngineCountInfoColor = "green"
}
Write-Host $cilantroEngineCountInfo -foreground $cilantroEngineCountInfoColor

$testsAfterGeneratingOutputDataCheckersCount = $testsAfterGeneratingOutputDataCheckers.Length
$testsAfterGeneratingOutputDataCheckersPercent = $testsAfterGeneratingOutputDataCheckersCount / $allTestsCount * 100
$generateOutputDataCheckersCountInfo = $testsAfterGeneratingOutputDataCheckersCount.ToString() + " / " + $allTestsCount.ToString() + " (" + "{0:N2}" -f $testsAfterGeneratingOutputDataCheckersPercent + " %)" + " tests have had output data checkers generated."
$generateOutputDataCheckersCountInfoColor = "red"
if($testsAfterGeneratingOutputDataCheckersCount -eq $allTestsCount)
{
	$generateOutputDataCheckersCountInfoColor = "green"
}
Write-Host $generateOutputDataCheckersCountInfo -foreground $generateOutputDataCheckersCountInfoColor

$testsAfterCheckingOutputCount = $testsAfterCheckingOutput.Length
$testsAfterCheckingOutputPercent = $testsAfterCheckingOutputCount / $allTestsCount * 100
$checkOutputCountInfo = $testsAfterCheckingOutputCount.ToString() + " / " + $allTestsCount.ToString() + " (" + "{0:N2}" -f $testsAfterCheckingOutputPercent + " %)" + " tests have had correct output."
$checkOutputCountInfoColor = "red"
if($testsAfterCheckingOutputCount -eq $allTestsCount)
{
	$checkOutputCountInfoColor = "green"
}
Write-Host $checkOutputCountInfo -foreground $checkOutputCountInfoColor

$testsAfterCheckingDocsCount = $testsAfterCheckingDocs.Length
$testsAfterCheckingDocsPercent = $testsAfterCheckingDocsCount / $allTestsCount * 100
$checkDocsCountInfo = $testsAfterCheckingDocsCount.ToString() + " / " + $allTestsCount.ToString() + " (" + "{0:N2}" -f $testsAfterCheckingDocsPercent + " %)" + " tests have had documentation found."
$checkDocsCountInfoColor = "red"
if($testsAfterCheckingDocsCount -eq $allTestsCount)
{
	$checkDocsCountInfoColor = "green"
}
Write-Host $checkDocsCountInfo -foreground $checkDocsCountInfoColor

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
Write-Host "Press ENTER to continue..." -foreground "yellow"

$key = $Host.UI.RawUI.ReadKey('NoEcho,IncludeKeyDown');
while(-not($key.VirtualKeyCode -eq 13))
{
	$key = $Host.UI.RawUI.ReadKey('NoEcho,IncludeKeyDown');
}

cls