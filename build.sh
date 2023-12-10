#!/usr/bin/env bash
. shared.sh
javac -d java/bin -cp "./java/lib/jpos113.jar:./java/lib/jpos113-controls.jar" \
	java/src/Test.java \
	java/src/Main.java \
	java/src/Device.java \
	java/src/NativeDataListener.java \
	java/src/NativeOutputCompleteListener.java \
	java/src/NativeErrorListener.java \
	java/src/NativeStatusUpdateListener.java



javac -d java/POSdeviceSimulator/bin/ -cp "./java/lib/jpos113.jar:./java/lib/jpos113-controls.jar:./java/POSdeviceSimulator/lib/commons-lang-2.6.jar:./java/POSdeviceSimulator/lib/commons-logging-1.1.1.jar:./java/POSdeviceSimulator/lib/jdom-2.0.1.jar:./java/POSdeviceSimulator/lib/junit-4.10.jar:./java/POSdeviceSimulator/lib/xercesImpl.jar" \
	java/POSdeviceSimulator/src/org/jumpmind/pos/javapos/sim/AbstractSimulatedService.java \
	java/POSdeviceSimulator/src/org/jumpmind/pos/javapos/sim/SimulatedCashDrawerService.java \
	java/POSdeviceSimulator/src/org/jumpmind/pos/javapos/sim/SimulatedFiscalPrinterService.java \
	java/POSdeviceSimulator/src/org/jumpmind/pos/javapos/sim/SimulatedLineDisplayService.java \
	java/POSdeviceSimulator/src/org/jumpmind/pos/javapos/sim/SimulatedMICRService.java \
	java/POSdeviceSimulator/src/org/jumpmind/pos/javapos/sim/SimulatedMSRService.java \
	java/POSdeviceSimulator/src/org/jumpmind/pos/javapos/sim/SimulatedPINPadService.java \
	java/POSdeviceSimulator/src/org/jumpmind/pos/javapos/sim/SimulatedPOSPrinterService.java \
	java/POSdeviceSimulator/src/org/jumpmind/pos/javapos/sim/SimulatedScannerService.java \
	java/POSdeviceSimulator/src/org/jumpmind/pos/javapos/sim/SimulatedServiceInstanceFactory.java \
	java/POSdeviceSimulator/src/org/jumpmind/pos/javapos/sim/SimulatedSignatureCaptureService.java \
	java/POSdeviceSimulator/src/org/jumpmind/pos/javapos/sim/SimulatedMSRService.java \
	java/POSdeviceSimulator/src/org/jumpmind/pos/javapos/sim/beans/MICRBean.java \
	java/POSdeviceSimulator/src/org/jumpmind/pos/javapos/sim/beans/MSRCardBean.java \
	java/POSdeviceSimulator/src/org/jumpmind/pos/javapos/sim/beans/SignatureCaptureBean.java \
	java/POSdeviceSimulator/src/org/jumpmind/pos/javapos/sim/ui/BaseSimulatedPanel.java \
	java/POSdeviceSimulator/src/org/jumpmind/pos/javapos/sim/ui/ScribbleDragAndDrop.java \
	java/POSdeviceSimulator/src/org/jumpmind/pos/javapos/sim/ui/SimulatedCashDrawerPanel.java \
	java/POSdeviceSimulator/src/org/jumpmind/pos/javapos/sim/ui/SimulatedDeviceWindow.java \
	java/POSdeviceSimulator/src/org/jumpmind/pos/javapos/sim/ui/SimulatedFiscalPrinterPanel.java \
	java/POSdeviceSimulator/src/org/jumpmind/pos/javapos/sim/ui/SimulatedLineDisplayPanel.java \
	java/POSdeviceSimulator/src/org/jumpmind/pos/javapos/sim/ui/SimulatedMICRPanel.java \
	java/POSdeviceSimulator/src/org/jumpmind/pos/javapos/sim/ui/SimulatedMSRPanel.java \
	java/POSdeviceSimulator/src/org/jumpmind/pos/javapos/sim/ui/SimulatedPINPadPanel.java \
	java/POSdeviceSimulator/src/org/jumpmind/pos/javapos/sim/ui/SimulatedPOSPrinterPanel.java \
	java/POSdeviceSimulator/src/org/jumpmind/pos/javapos/sim/ui/SimulatedScannerPanel.java \
	java/POSdeviceSimulator/src/org/jumpmind/pos/javapos/sim/ui/SimulatedSignatureCapturePanel.java \
	java/POSdeviceSimulator/src/org/jumpmind/pos/javapos/sim/util/AbstractEscapeSequence.java \
	java/POSdeviceSimulator/src/org/jumpmind/pos/javapos/sim/util/DecimalFormatter.java \
	java/POSdeviceSimulator/src/org/jumpmind/pos/javapos/sim/util/IEscapeSequence.java \
	java/POSdeviceSimulator/src/org/jumpmind/pos/javapos/sim/util/InMemoryBitmap.java \
	java/POSdeviceSimulator/src/org/jumpmind/pos/javapos/sim/util/PrintBitmapEscapeSequence.java \
	java/POSdeviceSimulator/src/org/jumpmind/pos/javapos/sim/util/PrintLineFeedEscapeSequence.java