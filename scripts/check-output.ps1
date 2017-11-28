param
(
	[string]$programName,
	[string]$inDataFilePath,
	[string]$outExeFilePath,
	[string]$outCilantroFilePath,
	[bool]$showMessages = $true
)

$outputDataCheckerGeneratorPath = "../utils/OutputChecker/OutputChecker/bin/Release/OutputChecker.exe"

$checkOutputCommand = "& " + $outputDataCheckerGeneratorPath + " " + $programName + " CHECK-ONLY " + '"' + $inDataFilePath + '"' + " " + '"' + $outExeFilePath + '"' + " " + '"' + $outCilantroFilePath + '"'

$checkOutputResult = Invoke-Expression $checkOutputCommand

if($checkOutputResult -match "^ERROR")
{
	if($showMessages)
	{
		$errorMessage = "Incorrect output for " + $programName + "."
		Write-Host $errorMessage -foreground "red"
		Write-Host $checkOutputResult -foreground "red"
	}
	else
	{
		$errorMessage = "ERROR"
		Write-Host $errorMessage -foreground "red"
		return $errorMessage
	}
}
else
{
	if($showMessages)
	{
		$successMessage = "Correct output."
		Write-Host $successMessage -foreground "green"
	}
	else
	{
		$successMessage = "SUCCESS"
		Write-Host $successMessage -foreground "green"
		return $successMessage
	}
}