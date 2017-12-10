If(Test-Path("../tests"))
{
	Copy-Item "../tests" "../tests-temp" -force -recurse | Out-Null
	Remove-Item "../tests" -force -recurse | Out-Null
}
New-Item "../tests" -type directory | Out-Null

$testGroups = Invoke-Expression -Command ./get-test-groups.ps1

$testsCollected = 0

foreach($testGroup in $testGroups)
{
	$exeFileRegExp = "^TP_" + $testGroup + "_.*\.exe$"
	$execs = Get-ChildItem "..\other" -recurse | Where-Object { $_.Directory -match "bin\\Release" } | Where-Object { $_.Name -match $exeFileRegExp } | Where-Object { $_.Name -notmatch ".*\.vshost\.exe" }
	
	foreach($exe in $execs)
	{
		$testName = $exe.BaseName
		$testPath = "../tests/" + $testName
		New-Item $testPath -type directory | Out-Null
		
		$srcFolderPath = $testPath + "/src"
		New-Item $srcFolderPath -type directory | Out-Null
		
		$srcPath = $srcFolderPath + "/program.il"
		$exeFullName = $exe.FullName
		
		Invoke-Expression  "& ildasm `"$exeFullName`" /output=`"$srcPath`""
		$additionalFiles = Get-ChildItem | Where-Object { $_.Name -notmatch "\.ps1$" }
		
		foreach($additionalFile in $additionalFiles)
		{
			$newAdditionalFileName = $srcFolderPath + "/" + $additionalFile.Name
			Copy-Item $additionalFile.FullName $newAdditionalFileName
			
			Remove-Item $additionalFile.FullName
		}
		
		$tempDocsFolderPath = "../tests-temp/" + $testName + "/docs"
		$docsFolderPath = $testPath + "/docs"
	
		if(-not (Test-Path($docsFolderPath)))
		{
			New-Item $docsFolderPath -type directory | Out-Null
		}
		
		$tempInDocsFilePath = $tempDocsFolderPath + "/in.txt"
		if(Test-Path($tempInDocsFilePath))
		{
			Copy-Item $tempInDocsFilePath $docsFolderPath | Out-Null
		}
		
		$tempOutDocsFilePath = $tempDocsFolderPath + "/out.txt"
		if(Test-Path($tempOutDocsFilePath))
		{
			Copy-Item $tempOutDocsFilePath $docsFolderPath | Out-Null
		}
		
		$tempDescDocsFilePath = $tempDocsFolderPath + "/description.txt"
		if(Test-Path($tempDescDocsFilePath))
		{
			Copy-Item $tempDescDocsFilePath $docsFolderPath | Out-Null
		}
		
		$testsCollected++
	}
}

if(Test-Path("../tests-temp"))
{
	Remove-Item "../tests-temp" -force -recurse | Out-Null
}

$testsCollectedMessage = $testsCollected.ToString() + " tests have been collected."
Write-Host $testsCollectedMessage -foreground "green"