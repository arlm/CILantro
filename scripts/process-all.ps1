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

foreach($test in $allTests)
{	
	$testNameInfo = $test.Name + " "
	Write-Host -NoNewLine $testNameInfo

	$generateInputDataCommand = "& ./generate-input-data.ps1 " + $test.Name + " " + '"' + $test.FullName + "\in" + '"' + " `$false"
	$generateInputDataResult = Invoke-Expression $generateInputDataCommand
}

# summary

cls

$allTestsCountInfo = $allTestsCount.ToString() + " tests have been processed."
Write-Host $allTestsCountInfo -foreground "yellow"

Write-Host
Write-Host "Press any key to continue..." -foreground "yellow"

$null = $Host.UI.RawUI.ReadKey('NoEcho,IncludeKeyDown');

cls