@echo off

SET configuration=%1
SET projDir=%2
SET slnDir=%3

SET testProjFile=%projDir%bin\%configuration%\net6.0\TestProject2.dll
SET projMapinFile=%slnDir%src\Project2\bin\%configuration%\net6.0\Project2.dll.map.xml

babel %testProjFile% @ --mapin %projMapinFile% --output %testProjFile%
