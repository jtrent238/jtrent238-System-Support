@Echo Off
color 0a
Setlocal EnableDelayedExpansion
SET /p user=User:
Set _RNDLength=25
Set _Alphanumeric=ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789
Set _Str=%_Alphanumeric%987654321
Set Token=null

:_LenLoop
IF NOT "%_Str:~18%"=="" SET _Str=%_Str:~9%& SET /A _Len+=9& GOTO :_LenLoop
SET _tmp=%_Str:~9,1%
SET /A _Len=_Len+_tmp
Set _count=0
SET _RndAlphaNum=

:_loop
Set /a _count+=1
SET _RND=%Random%
Set /A _RND=_RND%%%_Len%
SET _RndAlphaNum=!_RndAlphaNum!!_Alphanumeric:~%_RND%,1!
If !_count! lss %_RNDLength% goto _loop
::Echo Random string is !_RndAlphaNum!
cls
goto createkeyfile

:createkeyfile
echo { >> %user%.key
echo user:"!user!", >> %user%.key
echo key:"!_RndAlphaNum!", >> %user%.key
echo user_token:"!Token!" >> %user%.key
echo } >> %user%.key
goto end

:end
echo User: !user!
echo Key: !_RndAlphaNum!
echo User: !user!>>keys.txt
echo Key: !_RndAlphaNum!>>keys.txt

pause