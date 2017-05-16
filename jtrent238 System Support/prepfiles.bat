@echo off
cls

echo Preparing files for jtrent238

mkdir "Prepared_Files"
copy sysoutput.log	"Prepared_Files\sysoutput.log"
copy sysoutput.txt	"Prepared_Files\sysoutput.txt"


echo files prepared, please send the "Prepared_Files" folder to jtrent238.
start c:\Windows\System32\msg.exe * Please send EVERYTHING in the "Prepared_Files" folder to jtrent238.
