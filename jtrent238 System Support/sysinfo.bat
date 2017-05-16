@echo Off
cls

del sysoutput.log
del sysoutput.txt

echo Getting System Information Please Wait...

echo ********************************************>>sysoutput.log
echo Computer Name= %COMPUTERNAME%
echo Computer Name= %COMPUTERNAME%>>outputdata\sysoutput.log

echo Username= %USERNAME%
echo Username= %USERNAME%>>sysoutput.log
::echo Password= %password%
::echo Password= %password%>>sysoutput.log
echo Password= [Censored]
echo Password= [Censored]>>sysoutput.log
echo User Profile= %userprofile%
echo User Profile= %userprofile%>>sysoutput.log

::echo ********************************************

::echo Generating System Info Table....
::systeminfo.exe /FO TABLE>>sysoutput.txt
::echo System Info Table Generated

echo ********************************************

echo Generating System Info LIST...
systeminfo.exe /FO LIST>>sysoutput.txt
echo System Info LIST Generated

echo ********************************************

::echo Generating System Info CSV...
::systeminfo.exe /FO CSV>>sysoutput.txt
::echo Generated System Info CSV

::echo ********************************************

echo Report Generated On %DATE% %TIME%
echo Report Generated On %DATE% %TIME%>>sysoutput.log
echo ********************************************>>sysoutput.log
pause