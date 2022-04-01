@echo off
call shared.bat
java -cp "./java/lib/jpos113.jar;./java/lib/xerces.jar;./java/bin" ^
	Main > dotnet\jpos\jpos\internal\generated.cs