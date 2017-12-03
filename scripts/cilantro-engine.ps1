param
(
	[string]$programSrcPath,
	[string]$inDataFilePath,
	[string]$outDataFilePath,
	[bool]$showMessages = $true,
	[string]$mode = "normal"
)

$cilantroConsoleExe = "../src/CILantro/UI/CILantro.UI.HiddenUI/bin/Release/CILantro.UI.HiddenUI.exe"
$errorTempFile = ".\temp-error-file.error"

if(Test-Path($errorTempFile))
{
	Remove-Item $errorTempFile -force -recurse
}

if($mode -eq "normal")
{
	$cilantroConsoleArgs = '"' + $programSrcPath + '"'
	Start-Process $cilantroConsoleExe -RedirectStandardError $errorTempFile -RedirectStandardInput $inDataFilePath -RedirectStandardOutput $outDataFilePath -NoNewWindow -Wait -ArgumentList $cilantroConsoleArgs
}
else
{
	$cilantroConsoleArgs = '"' + $programSrcPath + '"' + " " + '"parse-only"'
	Start-Process $cilantroConsoleExe -RedirectStandardError $errorTempFile -NoNewWindow -Wait -ArgumentList $cilantroConsoleArgs
}

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