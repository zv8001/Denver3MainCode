:LOOP
TIMEOUT 10
tasklist /fi "ImageName eq notepad.exe" /fo csv 2>NUL | find /I "myapp.exe">NUL
if "%ERRORLEVEL%"=="0" echo Program is running
GOTO LOOP