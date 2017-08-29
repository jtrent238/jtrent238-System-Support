@echo off
cls

echo Cleaning files...

:0
if exist "Prepared_Files" (
    del "Prepared_Files" /Q
) else (
    goto 1
)

:1
if exist installedapps.txt (
    del installedapps.txt /Q
) else (
    goto 2
)

:2
if exist sysoutput.txt (
    del sysoutput.txt /Q
) else (
    goto 3
)

:3
if exist sysoutput.log (
    del sysoutput.log /Q
) else (
    goto 4
)
:4
goto cleaned

:cleaned
echo files cleaned.
pause