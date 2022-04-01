@echo off
call shared.bat
javap -cp "./java/lib/jpos113.jar;./java/lib/xerces.jar;./java/bin" -s -p %*