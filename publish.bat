set currentStep="STEP7"
rd /q /s publish
dotnet publish -c Release /p:PublishProfile=FolderProfile
cd ExecutableFiles
rd /q /s %currentStep%
md %currentStep%
cd %currentStep%
xcopy "..\..\publish" /S /E 
rd /q /s Database 
cd ..\..