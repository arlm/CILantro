param
(
	[string]$programName,
	[string]$docsFolderPath,
	[bool]$showMessages = $true
)

$docsFileName = $programName + ".docx"
$docsNormalizedPath = [System.IO.Path]::GetFullPath((Join-Path (Join-Path (pwd) $docsFolderPath) $docsFileName))
Write-Host $docsNormalizedPath

$success = $true
if(![System.IO.File]::Exists($docsNormalizedPath))
{
	$success = $false
}

if($success)
{
	if($showMessaages)
	{
		$successMessage = "Documentation found."
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
		$errorMessage = "Cannot find documentation for " + $programName + "."
		Write-Host $errorMessage -foreground "red"
	}
	else
	{
		$errorMessage = "ERROR"
		Write-Host $errorMessage -foreground "red"
		return $errorMessage
	}
}