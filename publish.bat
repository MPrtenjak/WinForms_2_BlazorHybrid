MsBuild.exe /t:Build /p:Configuration=Release
cd ExecutableFiles
rd /q /s STEP4
md STEP4
cd STEP4
xcopy "..\..\Simple CRUD\bin\Release" /S /E 
rd /q /s Database 
cd ..\..