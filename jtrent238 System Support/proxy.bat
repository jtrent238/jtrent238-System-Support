@echo off
cls

set proxy-url=
set port=

REG EXPORT "HKCU\Software\Microsoft\Windows\CurrentVersion\Internet Settings" \proxy.bak && type \proxy.bak | findstr /i "ProxyServer"
REG ADD "HKCU\Software\Microsoft\Windows\CurrentVersion\Internet Settings" /v ProxyServer  /d "http=%proxy-url%:%port%;https=%proxy-url%:%port%;ftp=%proxy-url%:%port%;socks=%proxy-url%:%port%;" /t REG_SZ /f

pause
