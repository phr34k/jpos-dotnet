# Windows

## Installation

```
winget install Microsoft.OpenJDK.17
winget install Microsoft.dotnet
```
## Usage

```
./build.bat
./run.bat

PATH=C:\Program Files\Microsoft\jdk-17.0.2.8-hotspot\bin;C:\Program Files\Microsoft\jdk-17.0.2.8-hotspot\bin\server;%PATH%
dotnet run --project ./dotnet/test/example.csproj jpos.xml
```

# Linux

## Installation

```
wget https://dot.net/v1/dotnet-install.sh
./dotnet-install.sh -c 6.0
sudo apt install openjdk-16-jdk-headless
```

## Usage

```
./build.sh
./run.sh

export LD_LIBRARY_PATH=/usr/lib/jvm/java-1.16.0-openjdk-amd64/lib/server:/usr/lib/jvm/java-1.16.0-openjdk-amd64/lib/:$LD_LIBRARY_PATH
~/.dotnet/dotnet run --project ./dotnet/test/example.csproj jpos.xml
```


# Extra

https://honeywellsps.my.salesforce.com/sfc/p/00000000SK3U/a/A00000005FEe/LkG.IJruh8wnE32NqEWlxovo3CU2g4EgiUVcW3db2js
