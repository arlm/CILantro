param
(
	[string]$programName,
	[bool]$showMessages = $true
)

$outputDataCheckerGeneratorPath = "../utils/OutputChecker/OutputChecker/bin/Release/OutputChecker.exe"

$generateCommand = "& " + $outputDataCheckerGeneratorPath + " " + $programName + " GENERATE-ONLY"

$generateResult = Invoke-Expression $generateCommand

if($generateResult -match "^ERROR")
{
	if($showMessages)
	{
		$errorMessage = "Cannot generate output data checker for " + $programName + "."
		Write-Host $errorMessage -foreground "red"
		Write-Host $generateResult -foreground "red"
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
		$successMessage = "Output data checker has been generated successfully."
		Write-Host $successMessage -foreground "green"
	}
	else
	{
		$successMessage = "SUCCESS"
		Write-Host $successMessage -foreground "green"
		return $successMessage
	}
}