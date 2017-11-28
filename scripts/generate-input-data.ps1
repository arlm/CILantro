param
(
	[string]$programName,
	[string]$inDataFolderPath,
	[bool]$showMessages = $true
)

$inputDataGeneratorPath = "../utils/InputDataGenerator/InputDataGenerator/bin/Release/InputDataGenerator.exe"

if(Test-Path($inDataFolderPath))
{
	Remove-Item $inDataFolderPath -force -recurse | Out-Null
}
New-Item $inDataFolderPath -type directory | Out-Null

$generateCommand = "& " + $inputDataGeneratorPath + " " + $programName + " " + '"' + $inDataFolderPath + '"'

$generateResult = Invoke-Expression $generateCommand

if($generateResult -match "^ERROR")
{
	if($showMessages)
	{
		$errorMessage = "Cannot generate input data for " + $programName + "."
		Write-Host $errorMessage -foreground "red"
		Write-Host $generateResult -foreground "red"
	}
	else
	{
		$errorMessage = "ERROR"
		Write-Host $errorMessage -foreground "red"
	}
}
else
{
	if($showMessages)
	{
		$successMessage = "Input data has been generated successfully."
		Write-Host $successMessage -foreground "green"
	}
	else
	{
		$successMessage = "SUCCESS"
		Write-Host $successMessage -foreground "green"
	}
}