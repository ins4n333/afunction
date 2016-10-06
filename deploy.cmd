@echo off
echo Building...
"%MSBUILD_PATH%" TestFuncLib\TestFuncLib.csproj /p:OutDir=%DEPLOYMENT_SOURCE%\TestFunc\bin\
echo Deploying files...
set targetDir=%DEPLOYMENT_TARGET%\TestFunc
IF not exist %targetDir% (mkdir %targetDir%)
xcopy %DEPLOYMENT_SOURCE%\TestFunc %targetDir% /e /s /y