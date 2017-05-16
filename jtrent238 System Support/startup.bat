@echo off
cls
set BGInfo_dir=BGInfo
echo jtrent238 System Startup Script

%BGInfo_dir%\BGInfo.bat

cls

sc create SupportConsole type= own start= auto binpath= %SYSTEM%\jtrent238\SystemSupport\SC\SupportConsole.exe
sc start SupportConsole

prepfiles.bat

pause