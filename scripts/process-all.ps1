param
(
	[bool]$StopOnError = $false,
	[bool]$CheckAllInputs = $true
)

$totalStopWatch = [System.Diagnostics.StopWatch]::StartNew()

$allSteps = 8

# collect tests

$step1StopWatch = [System.Diagnostics.StopWatch]::StartNew()

cls

Write-Host ("STEP 1 / " + $allSteps.ToString()) -foreground "yellow"
Write-Host "Collecting tests..." -foreground "yellow"
Write-Host

Invoke-Expression ./collect-tests.ps1

$step1StopWatch.Stop()

# get all tests

$allTests = Get-ChildItem "..\tests"
$allTestsCount = $allTests.Length

# generate input for tests

$step2StopWatch = [System.Diagnostics.StopWatch]::StartNew()

$testsAfterGeneratingInputData = @()
$errors = @()

foreach($test in $allTests)
{
	cls

	Write-Host ("STEP 2 / " + $allSteps.ToString()) -foreground "yellow"
	Write-Host "Generating input data..." -foreground "yellow"
	Write-Host
	
	$testIndex = $allTests.IndexOf($test) + 1
	Write-Host -NoNewLine "Test: " -foreground "yellow"
	Write-Host -NoNewLine $testIndex -foreground "yellow"
	Write-Host -NoNewLine " / " -foreground "yellow"
	Write-Host -NoNewLine $allTests.Length -foreground "yellow"
	$testIndexPercent = $testIndex / $allTests.Length * 100.0
	Write-Host (" (" + "{0:N2}" -f $testIndexPercent + "%)") -foreground "yellow"
	Write-Host

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
		$errorMessage = $test.Name + " - input data could not be generated"
		$errors += $errorMessage
		
		if($StopOnError)
		{
			$testsAfterGeneratingInputData = @()
			break
		}
	}
}

$step2StopWatch.Stop()

# generate execs

$step3StopWatch = [System.Diagnostics.StopWatch]::StartNew()

foreach($test in $testsAfterGeneratingInputData)
{
	cls

	Write-Host ("STEP 3 / " + $allSteps.ToString()) -foreground "yellow"
	Write-Host "Generating execs..." -foreground "yellow"
	Write-Host
	
	$testIndex = $testsAfterGeneratingInputData.IndexOf($test) + 1
	Write-Host -NoNewLine "Test: " -foreground "yellow"
	Write-Host -NoNewLine $testIndex -foreground "yellow"
	Write-Host -NoNewLine " / " -foreground "yellow"
	Write-Host -NoNewLine $testsAfterGeneratingInputData.Length -foreground "yellow"
	$testIndexPercent = $testIndex / $testsAfterGeneratingInputData.Length * 100.0
	Write-Host (" (" + "{0:N2}" -f $testIndexPercent + "%)") -foreground "yellow"
	Write-Host

	$ilasmCommand = "& ilasm " + '"' + $test.FullName + "\src\program.il" + '"'
	Invoke-Expression $ilasmCommand | Out-Null
}

$step3StopWatch.Stop()

# generate out from execs

$step4StopWatch = [System.Diagnostics.StopWatch]::StartNew()

$allInDataFilesCount = 0

foreach($test in $testsAfterGeneratingInputData)
{
	$inDataPath = $test.FullName + "\in"
	$inDataFiles = @(Get-ChildItem $inDataPath)
	if(-not ($CheckAllInputs))
	{
		$inDataFiles = @($inDataFiles[0])
	}
	
	$outDataPath = $test.FullName + "\out-exe"
	New-Item $outDataPath -type directory | Out-Null
	
	$allInDataFilesCount += $inDataFiles.Count
	
	foreach($inDataFile in $inDataFiles)
	{
		cls

		Write-Host ("STEP 4 / " + $allSteps.ToString()) -foreground "yellow"
		Write-Host "Generating output data from execs..." -foreground "yellow"
		Write-Host
		
		$testIndex = $testsAfterGeneratingInputData.IndexOf($test) + 1
		Write-Host -NoNewLine "Test: " -foreground "yellow"
		Write-Host -NoNewLine $testIndex -foreground "yellow"
		Write-Host -NoNewLine " / " -foreground "yellow"
		Write-Host -NoNewLine $testsAfterGeneratingInputData.Length -foreground "yellow"
		$testIndexPercent = $testIndex / $testsAfterGeneratingInputData.Length * 100.0
		Write-Host (" (" + "{0:N2}" -f $testIndexPercent + "%)") -foreground "yellow"
		
		$inDataFileIndex = $inDataFiles.IndexOf($inDataFile) + 1
		Write-Host -NoNewLine "Data: " -foreground "yellow"
		Write-Host -NoNewLine $inDataFileIndex -foreground "yellow"
		Write-Host -NoNewLine " / " -foreground "yellow"
		Write-Host -NoNewLine $inDataFiles.Count -foreground "yellow"
		$inDataFileIndexPercent = $inDataFileIndex / $inDataFiles.Count * 100.0
		Write-Host (" (" + "{0:N2}" -f $inDataFileIndexPercent + "%)") -foreground "yellow"
		Write-Host
	
		$outDataFilePath = $outDataPath + "\" + $inDataFile.BaseName + ".out"
		New-Item $outDataFilePath | Out-Null
	
		$exeCommand = '"' + $test.FullName + "\src\program.exe" + '"'
		Start-Process $exeCommand -RedirectStandardInput $inDataFile.FullName -RedirectStandardOutput $outDataFilePath -NoNewWindow
		
		echo $outDataFilePath
		echo $result
		
		if(-not ($CheckAllInputs))
		{
			break;
		}
	}
}

$step4StopWatch.Stop()

# parse tests by cilantro parser

$step5StopWatch = [System.Diagnostics.StopWatch]::StartNew()

$testsAfterCilantroParser = @()

foreach($test in $testsAfterGeneratingInputData)
{
	cls

	Write-Host ("STEP 5 / " + $allSteps.ToString()) -foreground "yellow"
	Write-Host "Parsing tests by CILantro parser..." -foreground "yellow"
	Write-Host
	
	$testIndex = $testsAfterGeneratingInputData.IndexOf($test) + 1
	Write-Host -NoNewLine "Test: " -foreground "yellow"
	Write-Host -NoNewLine $testIndex -foreground "yellow"
	Write-Host -NoNewLine " / " -foreground "yellow"
	Write-Host -NoNewLine $testsAfterGeneratingInputData.Length -foreground "yellow"
	$testIndexPercent = $testIndex / $testsAfterGeneratingInputData.Length * 100.0
	Write-Host (" (" + "{0:N2}" -f $testIndexPercent + "%)") -foreground "yellow"
	Write-Host

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
		$errorMessage = $test.Name + " - could not be parsed by CILantro parser"
		$errors += $errorMessage
		
		if($StopOnError)
		{
			$testsAfterCilantroParser = @()
			break
		}
	}
}

$step5StopWatch.Stop()

# process tests by cilantro engine

$step6StopWatch = [System.Diagnostics.StopWatch]::StartNew()

$testsAfterCilantroEngine = @()
$processedInputDataFiles = 0

foreach($test in $testsAfterCilantroParser)
{
	$inDataPath = $test.FullName + "\in"
	$inDataFiles = @(Get-ChildItem $inDataPath)
	if(-not ($CheckAllInputs))
	{
		$inDataFiles = @($inDataFiles[0])
	}
	
	$outDataPath = $test.FullName + "\out-cilantro"
	New-Item $outDataPath -type directory | Out-Null
	
	$testSrcPath = $test.FullName + "\src\program.il"
	
	$cilantroEngineSuccess = $true
	
	foreach($inDataFile in $inDataFiles)
	{
		cls

		Write-Host ("STEP 6 / " + $allSteps.ToString()) -foreground "yellow"
		Write-Host "Processing tests by CILantro engine..." -foreground "yellow"
		Write-Host
		
		$testIndex = $testsAfterCilantroParser.IndexOf($test) + 1
		Write-Host -NoNewLine "Test: " -foreground "yellow"
		Write-Host -NoNewLine $testIndex -foreground "yellow"
		Write-Host -NoNewLine " / " -foreground "yellow"
		Write-Host -NoNewLine $testsAfterCilantroParser.Length -foreground "yellow"
		$testIndexPercent = $testIndex / $testsAfterCilantroParser.Length * 100.0
		Write-Host (" (" + "{0:N2}" -f $testIndexPercent + "%)") -foreground "yellow"
		
		$inDataFileIndex = $inDataFiles.IndexOf($inDataFile) + 1
		Write-Host -NoNewLine "Data: " -foreground "yellow"
		Write-Host -NoNewLine $inDataFileIndex -foreground "yellow"
		Write-Host -NoNewLine " / " -foreground "yellow"
		Write-Host -NoNewLine $inDataFiles.Count -foreground "yellow"
		$inDataFileIndexPercent = $inDataFileIndex / $inDataFiles.Count * 100.0
		Write-Host (" (" + "{0:N2}" -f $inDataFileIndexPercent + "%)") -foreground "yellow"
		Write-Host
	
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
			
			$errorMessage = $test.Name + " - " + $inDataFile.Name + " - could not be processed by CILantro engine"
			$errors += $errorMessage
			
			if($StopOnError)
			{
				break
			}
		}
		
		$processedInputDataFiles = $processedInputDataFiles + 1
		
		if(-not ($CheckAllInputs))
		{
			break;
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

$step6StopWatch.Stop()

# generate output checker

$step7StopWatch = [System.Diagnostics.StopWatch]::StartNew()

$testsAfterGeneratingOutputDataCheckers = @()

foreach($test in $testsAfterCilantroEngine)
{
	cls

	Write-Host ("STEP 7 / " + $allSteps.ToString()) -foreground "yellow"
	Write-Host "Generating output data checkers..." -foreground "yellow"
	Write-Host
	
	$testIndex = $testsAfterCilantroEngine.IndexOf($test) + 1
	Write-Host -NoNewLine "Test: " -foreground "yellow"
	Write-Host -NoNewLine $testIndex -foreground "yellow"
	Write-Host -NoNewLine " / " -foreground "yellow"
	Write-Host -NoNewLine $testsAfterCilantroEngine.Length -foreground "yellow"
	$testIndexPercent = $testIndex / $testsAfterCilantroEngine.Length * 100.0
	Write-Host (" (" + "{0:N2}" -f $testIndexPercent + "%)") -foreground "yellow"
	Write-Host

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
		$errorMessage = $test.Name + " - output data checker could not be generated"
		$errors += $errorMessage
		
		if($StopOnError)
		{
			$testsAfterGeneratingOutputDataCheckers = @()
			break
		}
	}
}

$step7StopWatch.Stop()

# check outputs

$step8StopWatch = [System.Diagnostics.StopWatch]::StartNew()

$testsAfterCheckingOutput = @()

foreach($test in $testsAfterGeneratingOutputDataCheckers)
{
	$inDataPath = $test.FullName + "\in"
	$inDataFiles = Get-ChildItem $inDataPath
	if(-not ($CheckAllInputs))
	{
		$inDataFiles = @($inDataFiles[0])
	}
	
	$outExeDataPath = $test.FullName + "\out-exe"
	$outCilantroDataPath = $test.FullName + "\out-cilantro"
	
	$checkOutputSuccess = $true
	
	foreach($inDataFile in $inDataFiles)
	{
		cls

		Write-Host ("STEP 8 / " + $allSteps.ToString()) -foreground "yellow"
		Write-Host "Checking output data..." -foreground "yellow"
		Write-Host
		
		$testIndex = $testsAfterGeneratingOutputDataCheckers.IndexOf($test) + 1
		Write-Host -NoNewLine "Test: " -foreground "yellow"
		Write-Host -NoNewLine $testIndex -foreground "yellow"
		Write-Host -NoNewLine " / " -foreground "yellow"
		Write-Host -NoNewLine $testsAfterGeneratingOutputDataCheckers.Length -foreground "yellow"
		$testIndexPercent = $testIndex / $testsAfterGeneratingOutputDataCheckers.Length * 100.0
		Write-Host (" (" + "{0:N2}" -f $testIndexPercent + "%)") -foreground "yellow"
		
		$inDataFileIndex = $inDataFiles.IndexOf($inDataFile) + 1
		Write-Host -NoNewLine "Data: " -foreground "yellow"
		Write-Host -NoNewLine $inDataFileIndex -foreground "yellow"
		Write-Host -NoNewLine " / " -foreground "yellow"
		Write-Host -NoNewLine $inDataFiles.Count -foreground "yellow"
		$inDataFileIndexPercent = $inDataFileIndex / $inDataFiles.Count * 100.0
		Write-Host (" (" + "{0:N2}" -f $inDataFileIndexPercent + "%)") -foreground "yellow"
		Write-Host
	
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
		
		if(-not ($CheckAllInputs))
		{
			break
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

$step8StopWatch.Stop()
$totalStopWatch.Stop()

# summary

cls

$allTestsCountInfo = $allTestsCount.ToString() + " tests have been processed."
Write-Host $allTestsCountInfo -foreground "yellow"

$processedInputDataFilesCountInfo = $processedInputDataFiles.ToString() + " input data files have been processed."
Write-Host $processedInputDataFilesCountInfo -foreground "yellow"

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

if($errors.length -gt 0)
{
	Write-Host
	Write-Host "List of errors:" -foreground "red"
	foreach($error in $errors)
	{
		Write-Host $error -foreground "red"
	}
}
else
{	
	$totalMinutes = $totalStopWatch.Elapsed.TotalMinutes
	$totalSeconds = $totalStopWatch.Elapsed.TotalSeconds
	$totalSecondsPerTest = $totalSeconds / $allTestsCount
	$totalSecondsPerData = $totalSeconds / $processedInputDataFiles
	Write-Host
	Write-Host "STATISTICS" -foreground "magenta"
	Write-Host -foreground "magenta" $totalStopWatch.Elapsed.ToString('dd\:hh\:mm\:ss') -NoNewLine
	Write-Host -foreground "magenta" (" | {0:N2}" -f $totalMinutes + "min") -NoNewLine
	Write-Host -foreground "magenta" (" | {0:N2}" -f $totalSeconds + "s") -NoNewLine
	Write-Host -foreground "magenta" (" | {0:N2}" -f $totalSecondsPerTest + "s / test") -NoNewLine
	Write-Host -foreground "magenta" (" | {0:N2}" -f $totalSecondsPerData + "s / data")

	$step1Minutes = $step1StopWatch.Elapsed.TotalMinutes
	$step1Seconds = $step1StopWatch.Elapsed.TotalSeconds
	$step1SecondsPerTest = $step1Seconds / $allTestsCount
	$step1SecondsPerData = $step1Seconds / $processedInputDataFiles
	Write-Host
	Write-Host "STEP 1 - collecting tests" -foreground "magenta"
	Write-Host -foreground "magenta" $step1StopWatch.Elapsed.ToString('dd\:hh\:mm\:ss') -NoNewLine
	Write-Host -foreground "magenta" (" | {0:N2}" -f $step1Minutes + "min") -NoNewLine
	Write-Host -foreground "magenta" (" | {0:N2}" -f $step1Seconds + "s") -NoNewLine
	Write-Host -foreground "magenta" (" | {0:N2}" -f $step1SecondsPerTest + "s / test") -NoNewLine
	Write-Host -foreground "magenta" (" | {0:N2}" -f $step1SecondsPerData + "s / data")
	
	$step2Minutes = $step2StopWatch.Elapsed.TotalMinutes
	$step2Seconds = $step2StopWatch.Elapsed.TotalSeconds
	$step2SecondsPerTest = $step2Seconds / $allTestsCount
	$step2SecondsPerData = $step2Seconds / $processedInputDataFiles
	Write-Host
	Write-Host "STEP 2 - generating input data" -foreground "magenta"
	Write-Host -foreground "magenta" $step2StopWatch.Elapsed.ToString('dd\:hh\:mm\:ss') -NoNewLine
	Write-Host -foreground "magenta" (" | {0:N2}" -f $step2Minutes + "min") -NoNewLine
	Write-Host -foreground "magenta" (" | {0:N2}" -f $step2Seconds + "s") -NoNewLine
	Write-Host -foreground "magenta" (" | {0:N2}" -f $step2SecondsPerTest + "s / test") -NoNewLine
	Write-Host -foreground "magenta" (" | {0:N2}" -f $step2SecondsPerData + "s / data")
	
	$step3Minutes = $step3StopWatch.Elapsed.TotalMinutes
	$step3Seconds = $step3StopWatch.Elapsed.TotalSeconds
	$step3SecondsPerTest = $step3Seconds / $allTestsCount
	$step3SecondsPerData = $step3Seconds / $processedInputDataFiles
	Write-Host
	Write-Host "STEP 3 - generating execs" -foreground "magenta"
	Write-Host -foreground "magenta" $step3StopWatch.Elapsed.ToString('dd\:hh\:mm\:ss') -NoNewLine
	Write-Host -foreground "magenta" (" | {0:N2}" -f $step3Minutes + "min") -NoNewLine
	Write-Host -foreground "magenta" (" | {0:N2}" -f $step3Seconds + "s") -NoNewLine
	Write-Host -foreground "magenta" (" | {0:N2}" -f $step3SecondsPerTest + "s / test") -NoNewLine
	Write-Host -foreground "magenta" (" | {0:N2}" -f $step3SecondsPerData + "s / data")
	
	$step4Minutes = $step4StopWatch.Elapsed.TotalMinutes
	$step4Seconds = $step4StopWatch.Elapsed.TotalSeconds
	$step4SecondsPerTest = $step4Seconds / $allTestsCount
	$step4SecondsPerData = $step4Seconds / $processedInputDataFiles
	Write-Host
	Write-Host "STEP 4 - generating output data from execs" -foreground "magenta"
	Write-Host -foreground "magenta" $step4StopWatch.Elapsed.ToString('dd\:hh\:mm\:ss') -NoNewLine
	Write-Host -foreground "magenta" (" | {0:N2}" -f $step4Minutes + "min") -NoNewLine
	Write-Host -foreground "magenta" (" | {0:N2}" -f $step4Seconds + "s") -NoNewLine
	Write-Host -foreground "magenta" (" | {0:N2}" -f $step4SecondsPerTest + "s / test") -NoNewLine
	Write-Host -foreground "magenta" (" | {0:N2}" -f $step4SecondsPerData + "s / data")
	
	$step5Minutes = $step5StopWatch.Elapsed.TotalMinutes
	$step5Seconds = $step5StopWatch.Elapsed.TotalSeconds
	$step5SecondsPerTest = $step5Seconds / $allTestsCount
	$step5SecondsPerData = $step5Seconds / $processedInputDataFiles
	Write-Host
	Write-Host "STEP 5 - parsing tests by CILantro parser" -foreground "magenta"
	Write-Host -foreground "magenta" $step5StopWatch.Elapsed.ToString('dd\:hh\:mm\:ss') -NoNewLine
	Write-Host -foreground "magenta" (" | {0:N2}" -f $step5Minutes + "min") -NoNewLine
	Write-Host -foreground "magenta" (" | {0:N2}" -f $step5Seconds + "s") -NoNewLine
	Write-Host -foreground "magenta" (" | {0:N2}" -f $step5SecondsPerTest + "s / test") -NoNewLine
	Write-Host -foreground "magenta" (" | {0:N2}" -f $step5SecondsPerData + "s / data")
	
	$step6Minutes = $step6StopWatch.Elapsed.TotalMinutes
	$step6Seconds = $step6StopWatch.Elapsed.TotalSeconds
	$step6SecondsPerTest = $step6Seconds / $allTestsCount
	$step6SecondsPerData = $step6Seconds / $processedInputDataFiles
	Write-Host
	Write-Host "STEP 6 - processing tests by CILantro engine" -foreground "magenta"
	Write-Host -foreground "magenta" $step6StopWatch.Elapsed.ToString('dd\:hh\:mm\:ss') -NoNewLine
	Write-Host -foreground "magenta" (" | {0:N2}" -f $step6Minutes + "min") -NoNewLine
	Write-Host -foreground "magenta" (" | {0:N2}" -f $step6Seconds + "s") -NoNewLine
	Write-Host -foreground "magenta" (" | {0:N2}" -f $step6SecondsPerTest + "s / test") -NoNewLine
	Write-Host -foreground "magenta" (" | {0:N2}" -f $step6SecondsPerData + "s / data")
	
	$step7Minutes = $step7StopWatch.Elapsed.TotalMinutes
	$step7Seconds = $step7StopWatch.Elapsed.TotalSeconds
	$step7SecondsPerTest = $step7Seconds / $allTestsCount
	$step7SecondsPerData = $step7Seconds / $processedInputDataFiles
	Write-Host
	Write-Host "STEP 7 - generating output data checkers" -foreground "magenta"
	Write-Host -foreground "magenta" $step7StopWatch.Elapsed.ToString('dd\:hh\:mm\:ss') -NoNewLine
	Write-Host -foreground "magenta" (" | {0:N2}" -f $step7Minutes + "min") -NoNewLine
	Write-Host -foreground "magenta" (" | {0:N2}" -f $step7Seconds + "s") -NoNewLine
	Write-Host -foreground "magenta" (" | {0:N2}" -f $step7SecondsPerTest + "s / test") -NoNewLine
	Write-Host -foreground "magenta" (" | {0:N2}" -f $step7SecondsPerData + "s / data")
	
	$step8Minutes = $step8StopWatch.Elapsed.TotalMinutes
	$step8Seconds = $step8StopWatch.Elapsed.TotalSeconds
	$step8SecondsPerTest = $step8Seconds / $allTestsCount
	$step8SecondsPerData = $step8Seconds / $processedInputDataFiles
	Write-Host
	Write-Host "STEP 8 - checking output data" -foreground "magenta"
	Write-Host -foreground "magenta" $step8StopWatch.Elapsed.ToString('dd\:hh\:mm\:ss') -NoNewLine
	Write-Host -foreground "magenta" (" | {0:N2}" -f $step8Minutes + "min") -NoNewLine
	Write-Host -foreground "magenta" (" | {0:N2}" -f $step8Seconds + "s") -NoNewLine
	Write-Host -foreground "magenta" (" | {0:N2}" -f $step8SecondsPerTest + "s / test") -NoNewLine
	Write-Host -foreground "magenta" (" | {0:N2}" -f $step8SecondsPerData + "s / data")
}

Write-Host
Write-Host "Press ENTER to continue..." -foreground "yellow"

$key = $Host.UI.RawUI.ReadKey('NoEcho,IncludeKeyDown');
while(-not($key.VirtualKeyCode -eq 13))
{
	$key = $Host.UI.RawUI.ReadKey('NoEcho,IncludeKeyDown');
}

cls