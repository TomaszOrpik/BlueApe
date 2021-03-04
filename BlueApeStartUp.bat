@ECHO OFF

TaskKill /PID 25772 /F

TaskKill /PID 4536 /F

cd FileCreator
@start cmd /c npm run start
cd ..
cd BlueApeUI
@start cmd /c dotnet watch run


EXIT /b 1