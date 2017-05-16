@echo off
cls


REG EXPORT "HKCU" \HKCU.bak && type \HKCU.bak

pause
