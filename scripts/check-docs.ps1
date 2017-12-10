param
(
	[string]$programName,
	[string]$docsFolderPath,
	[bool]$showMessaages = $true
)

Write-Host $docsFolderPath
Write-Host (Test-Path($docsFolderPath))
if(-not (Test-Path($docsFolderPath)))
{
	New-Item $docsFolderPath -type directory | Out-Null
}

$inDocsFilePath = $docsFolderPath + "\in.txt"
if(-not (Test-Path($inDocsFilePath)))
{
	New-Item $inDocsFilePath | Out-Null
}

$outDocsFilePath = $docsFolderPath + "\out.txt"
if(-not (Test-Path($outDocsFilePath)))
{
	New-Item $outDocsFilePath | Out-Null
}

$descDocsFilePath = $docsFolderPath + "\description.txt"
if(-not (Test-Path($descDocsFilePath)))
{
	New-Item $descDocsFilePath | Out-Null
}

$success = $true
if((Get-Content($inDocsFilePath)) -eq $null)
{
	$success = $false
}
if((Get-Content($outDocsFilePath)) -eq $null)
{
	$success = $false
}
if((Get-Content($descDocsFilePath)) -eq $null)
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