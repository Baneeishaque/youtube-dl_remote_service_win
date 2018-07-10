
sc query Youtube_dl_remote
pause
sc stop Youtube_dl_remote
pause
msbuild
pause
C:\Windows\Microsoft.NET\Framework\v2.0.50727\InstallUtil.exe /u bin\Debug\youtube-dl_service.exe
pause
C:\Windows\Microsoft.NET\Framework\v2.0.50727\InstallUtil.exe bin\Debug\youtube-dl_service.exe
pause
sc start Youtube_dl_remote
pause
sc query Youtube_dl_remote
pause