@echo off
cls

echo Preparing files for jtrent238

del "Prepared_Files"
mkdir "Prepared_Files"
copy sysoutput.log	"Prepared_Files\sysoutput.log"
copy sysoutput.txt	"Prepared_Files\sysoutput.txt"


echo files prepared, please send the "Prepared_Files" folder to jtrent238.
msg * Please send EVERYTHING in the "Prepared_Files" folder to jtrent238.
