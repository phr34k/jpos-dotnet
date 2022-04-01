rem base path of the java sdk 64-bit
SET JAVASDK=C:\Program Files\Microsoft\jdk-17.0.2.8-hotspot
rem set honeywell jpos sdk installation
SET HONEYWELLJPOS=C:\Program Files\Honeywell\UPOS Suite\JavaPOS Suite\
rem add bin && bin/server to path for resolving jvm.dll and their dependencies like mscvrt runtime
SET PATH=%JAVASDK%\bin;%JAVASDK%\bin\server;%PATH%
