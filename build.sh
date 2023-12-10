#!/usr/bin/env bash
. shared.sh
javac -d java/bin -cp "./java/lib/jpos113.jar:./java/lib/jpos113-controls.jar" \
	java/src/test.java \
	java/src/main.java \
	java/src/device.java \
	java/src/NativeDataListener.java \
	java/src/NativeOutputCompleteListener.java \
	java/src/NativeErrorListener.java \
	java/src/NativeStatusUpdateListener.java