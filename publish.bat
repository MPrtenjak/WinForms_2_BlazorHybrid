MsBuild.exe /t:Build /p:Configuration=Release
cd ExecutableFiles
rd /q /s STEP3
md STEP3
cd STEP3
xcopy "..\..\Simple CRUD\bin\Release" /S /E 
rd /q /s Database 
cd ..\..