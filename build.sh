#!/usr/bin/env bash
. shared.sh
javac -d java/bin -cp "./java/lib/jpos113.jar:./java/lib/jpos113-controls.jar" \
	java/src/Test.java \
	java/src/Main.java \
	java/src/Device.java \
	java/src/NativeDataListener.java \
	java/src/NativeStatusUpdateListener.java