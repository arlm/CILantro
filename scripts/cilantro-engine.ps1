param
(
	[string]$programName,
	[string]$inDataFilePath,
	[string]$outDataFilePath,
	[bool]$showMessages = $true
)

$ErrorActionPreference = 'SilentlyContinue'

$cilantroConsoleExe = "../src/CILantro/UI/CILantro.UI.HiddenUI/bin/Release/CILantro.UI.HiddenUI.exe"
$errorTempFile = ".\temp-error-file.error"

if(Test-Path($errorTempFile))
{
	Remove-Item $errorTempFile -force -recurse
}

Start-Process $cilantroConsoleExe -RedirectStandardError $errorTempFile -RedirectStandardInput $inDataFilePath -RedirectStandardOutput $outDataFilePath -NoNewWindow -Wait 

$result = $true
if(-not ((Get-Content $errorTempFile) -eq $Null))
{
	$result = $false
}

if(Test-Path($errorTempFile))
{
	Remove-Item $errorTempFile -force -recurse
}

if($result)
{
	if($showMessages)
	{
		$successMessage = "Program has been processed successfully."
		Write-Host $successMessage -foreground "green"
	}
	else
	{
		$successMessage = "SUCCESS"
		Write-Host $successMessage -foreground "green"
		return $successMessage
	}
}
else
{
	if($showMessages)
	{
		$errorMessage = "Cannot process program " + $programName + "."
		Write-Host $errorMessage -foreground "red"
	}
	else
	{
		$errorMessage = "ERROR"
		Write-Host $errorMessage -foreground "red"
		return $errorMessage
	}
}