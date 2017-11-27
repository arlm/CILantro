If(Test-Path("../tests"))
{
	Remove-Item "../tests" -force -recurse | Out-Null
}
New-Item "../tests" -type directory | Out-Null

$testGroups = Invoke-Expression -Command ./get-test-groups.ps1

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
	}
}