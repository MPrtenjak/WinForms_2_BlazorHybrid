rd /q /s publish
dotnet publish -c Release /p:PublishProfile=FolderProfile
cd ExecutableFiles
rd /q /s STEP5
md STEP5
cd STEP5
xcopy "..\..\publish" /S /E 
rd /q /s Database 
cd ..\..