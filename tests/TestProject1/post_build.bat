@echo off

SET configuration=%1
SET projDir=%2
SET slnDir=%3

SET testProjFile=%projDir%bin\%configuration%\net6.0\TestProject1.dll
SET projMapinFile=%slnDir%src\Project1\bin\%configuration%\net6.0\Project1.dll.map.xml

babel %testProjFile% @ --mapin %projMapinFile% --output %testProjFile%
