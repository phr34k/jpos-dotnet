#!/usr/bin/env bash

# base path of the java sdk 64-bit
export JAVASDK=/usr/lib/jvm/java-1.16.0-openjdk-amd64/
# set honeywell jpos sdk installation
export HONEYWELLJPOS=/usr/lib/jvm/java-1.16.0-openjdk-amd64/
# add bin && bin/server to path for resolving jvm.dll and their dependencies like mscvrt runtime
export PATH=$JAVASDK/bin:$JAVASDK/bin/server:$PATH
