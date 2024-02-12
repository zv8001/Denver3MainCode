@ECHO OFF
::𝑑𝑒𝑠𝑡𝑟𝑜𝑦 𝑟𝑢𝑛 𝑡𝑖𝑚𝑒
::kills the program and then remove the file that runs it invisibly

::this code might become outdated as more checks are added
::to prevent it from being disabled.
::this program will auto updates when you run Denver3.exe

REM --add the following to the top of your bat file--


@echo off

:: BatchGotAdmin
:-------------------------------------
REM  --> Check for permissions
>nul 2>&1 "%SYSTEMROOT%\system32\cacls.exe" "%SYSTEMROOT%\system32\config\system"

REM --> If error flag set, we do not have admin.
if '%errorlevel%' NEQ '0' (
    echo Requesting administrative privileges...
    goto UACPrompt
) else ( goto gotAdmin )

:UACPrompt
    echo Set UAC = CreateObject^("Shell.Application"^) > "%temp%\getadmin.vbs"
    set params = %*:"=""
    echo UAC.ShellExecute "cmd.exe", "/c %~s0 %params%", "", "runas", 1 >> "%temp%\getadmin.vbs"

    "%temp%\getadmin.vbs"
    del "%temp%\getadmin.vbs"
    exit /B

:gotAdmin
    pushd "%CD%"
    CD /D "%~dp0"
:--------------------------------------
del "C:\Users\%USERNAME%\Denver3.runtime"
taskkill /im denver3.exe /t /f
PAUSE

::D E N V E R 3 . E X E  V I R U S