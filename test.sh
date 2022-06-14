#!/usr/bin/env bash
. shared.sh
export LD_LIBRARY_PATH=/usr/lib/jvm/java-1.16.0-openjdk-amd64/lib/server:/usr/lib/jvm/java-1.16.0-openjdk-amd64/lib/:$LD_LIBRARY_PATH
dotnet run --project dotnet/test/ ./ ./jpos.xml 