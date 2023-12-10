using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.jpos
{

    public abstract class PosCommon
    {
        internal DeviceInfo deviceInfo;
        public PosCommon(DeviceInfo info) { deviceInfo = info; }
        public abstract bool FreezeEvents
        {
            get;
            set;
        }

        public abstract string DeviceName { get; }
        public abstract string DeviceDescription { get; }
        public abstract bool Claimed { get; }
        public abstract bool DeviceEnabled { get; set; }
        public abstract ControlState State { get; }
        public abstract PowerState PowerState { get; }
        public abstract void Open();
        public abstract void Claim(int timeout);
        public abstract void Close();
        public abstract void Release();
        public abstract void CheckHealth(HealthCheckLevel level);

        public abstract PowerNotification PowerNotify { get; set; }

        //jpos compatabillity
        public abstract void addStatusListener(StatusListener listener);
        public abstract void removeStatusListener(StatusListener listener);
        //pos4net compatabillity
        public abstract event StatusUpdateEventHandler StatusUpdateEvent;



        //
        // Summary:
        //     Used as the value for a timeout parameter in common and device-specific methods
        //     to indicate the method should wait until it receives a response, instead of timing
        //     out.
        public const int WaitForever = -1;

        //
        // Summary:
        //     Indicates a specified statistic could not be reset or updated.
        public const int ExtendedErrorStatistics = 280;
        //
        // Summary:
        //     Indicates that either the device’s power is off or it is offline.
        public const int StatusPowerOffOffline = 2004;
        //
        // Summary:
        //     Indicates that the device is powered on but is either not ready or unable to
        //     respond to requests.
        public const int StatusPowerOffline = 2003;
        //
        // Summary:
        //     Indicates that the device’s power is turned off or it is detached from the terminal.
        public const int StatusPowerOff = 2002;
        //
        // Summary:
        //     Indicates that the device’s power is turned on and it is ready for use.
        public const int StatusPowerOnline = 2001;
    }


    public abstract class Scanner : PosCommon
    {
        public Scanner(DeviceInfo info) : base(info) { }

        public abstract bool DataEventEnabled { get; set; }

        public abstract bool DecodeData
        {
            get;
            set;
        }

        public abstract PowerReporting CapPowerReporting { get; }

        public abstract int DataCount { get; }
        public abstract byte[] ScanData { get; }
        public abstract byte[] ScanDataLabel { get; }
        public abstract BarCodeSymbology ScanDataType { get; }

        public abstract void addDataListener(DataListener listener);
        public abstract void removeDataListener(DataListener listener);
        public abstract event DataEventHandler DataEvent;
        public abstract event DeviceErrorEventHandler ErrorEvent;
    }

    public abstract class PosPrinter : PosCommon
    {
        public PosPrinter(DeviceInfo info) : base(info) { }
        //
        // Summary:
        //     Indicates the bitmap should be printed with one bitmap pixel per printer dot.
        public const int PrinterBitmapAsIs = -11;
        //
        // Summary:
        //     Incremented when a bar code is successfully printed.
        public const string StatisticBarcodePrintedCount = "BarcodePrintedCount";
        //
        // Summary:
        //     Indicates all asynchronous output is finished, either successfully or because
        //     the output has been cleared. The printer State property is now set to ControlState.Idle.
        public const int StatusIdle = 1001;
        //
        // Summary:
        //     Indicates the slip cover is closed.
        public const int StatusSlipCoverOK = 65;
        //
        // Summary:
        //     Indicates the slip cover is open.
        public const int StatusSlipCoverOpen = 64;
        //
        // Summary:
        //     Indicates the receipt cover is closed.
        public const int StatusReceiptCoverOK = 63;
        //
        // Summary:
        //     Indicates the receipt cover is open.
        public const int StatusReceiptCoverOpen = 62;
        //
        // Summary:
        //     Indicates the journal cover is closed.
        public const int StatusJournalCoverOK = 61;
        //
        // Summary:
        //     Incremented when a form is successfully inserted into the document/slip station.
        public const string StatisticFormInsertionCount = "FormInsertionCount";
        //
        // Summary:
        //     Indicates the journal cover is open.
        public const int StatusJournalCoverOpen = 60;
        //
        // Summary:
        //     Indicates the receipt cartridge has begun head cleaning.
        public const int StatusSlipHeadCleaning = 51;
        //
        // Summary:
        //     Indicates the slip cartridge is nearing empty.
        public const int StatusSlipCartridgeNearEmpty = 50;
        //
        // Summary:
        //     Indicates the slip cartridge has to be replaced.
        public const int StatusSlipCartridgeEmpty = 49;
        //
        // Summary:
        //     Indicates all receipt cartridges are ready.
        public const int StatusReceiptCartridgeOK = 48;
        //
        // Summary:
        //     Indicates the receipt cartridge has begun head cleaning.
        public const int StatusReceiptHeadCleaning = 47;
        //
        // Summary:
        //     Indicates the receipt cartridge is nearing empty.
        public const int StatusReceiptCartridgeNearEmpty = 46;
        //
        // Summary:
        //     Indicates the receipt cartridge has to be replaced.
        public const int StatusReceiptCartridgeEmpty = 45;
        //
        // Summary:
        //     Indicates all slip cartridges are ready.
        public const int StatusSlipCartridgeOK = 52;
        //
        // Summary:
        //     Indicates all journal cartridges are ready.
        public const int StatusJournalCartridgeOK = 44;
        //
        // Summary:
        //     Incremented when a home error occurs.
        public const string StatisticHomeErrorCount = "HomeErrorCount";
        //
        // Summary:
        //     Incremented every time that the document/slip station cover opened.
        public const string StatisticJournalCoverOpenCount = "JournalCoverOpenCount";
        //
        // Summary:
        //     Incremented for each Stamp raised.
        public const string StatisticStampFiredCount = "StampFiredCount";
        //
        // Summary:
        //     Incremented every time that a slip line is printed.
        public const string StatisticSlipLinePrintedCount = "SlipLinePrintedCount";
        //
        // Summary:
        //     Incremented every time that the slip cover opened.
        public const string StatisticSlipCoverOpenCount = "SlipCoverOpenCount";
        //
        // Summary:
        //     Incremented every time that a slip character is printed.
        public const string StatisticSlipCharacterPrintedCount = "SlipCharacterPrintedCount";
        //
        // Summary:
        //     Incremented every time that a receipt line is printed.
        public const string StatisticReceiptLinePrintedCount = "ReceiptLinePrintedCount";
        //
        // Summary:
        //     Incremented every time that a receipt line feed is performed.
        public const string StatisticReceiptLineFeedCount = "ReceiptLineFeedCount";
        //
        // Summary:
        //     Incremented every time that the receipt cover opened.
        public const string StatisticReceiptCoverOpenCount = "ReceiptCoverOpenCount";
        //
        // Summary:
        //     Incremented for every journal character printed.
        public const string StatisticJournalCharacterPrintedCount = "JournalCharacterPrintedCount";
        //
        // Summary:
        //     Incremented every time that a receipt character is printed.
        public const string StatisticReceiptCharacterPrintedCount = "ReceiptCharacterPrintedCount";
        //
        // Summary:
        //     Incremented when the print side changes or a check flips.
        public const string StatisticPrintSideChangeCount = "PrintSideChangeCount";
        //
        // Summary:
        //     Incremented when a printer fault occurs.
        public const string StatisticPrinterFaultCount = "PrinterFaultCount";
        //
        // Summary:
        //     Incremented for each failed paper cut.
        public const string StatisticFailedPaperCutCount = "FailedPaperCutCount";
        //
        // Summary:
        //     Incremented every time that paper is cut successfully.
        public const string StatisticPaperCutCount = "PaperCutCount";
        //
        // Summary:
        //     Incremented every time that NVRAM is written to.
        public const string StatisticNVRAMWriteCount = "NVRAMWriteCount";
        //
        // Summary:
        //     Incremented every time that maximum temperature is reached.
        public const string StatisticMaximumTempReachedCount = "MaximumTempReachedCount";
        //
        // Summary:
        //     Incremented for each journal line printed.
        public const string StatisticJournalLinePrintedCount = "JournalLinePrintedCount";
        //
        // Summary:
        //     Incremented for each failed print side change or failed check flip.
        public const string StatisticFailedPrintSideChangeCount = "FailedPrintSideChangeCount";
        //
        // Summary:
        //     Indicates the journal cartridge has begun head cleaning.
        public const int StatusJournalHeadCleaning = 43;
        //
        // Summary:
        //     Incremented every time that a slip line feed is performed.
        public const string StatisticSlipLineFeedCount = "SlipLineFeedCount";
        //
        // Summary:
        //     Indicates the journal cartridge has to be replaced.
        public const int StatusJournalCartridgeEmpty = 41;
        //
        // Summary:
        //     Indicates the bitmap is either too wide to print without transformation, or too
        //     big to tranform.
        public const int ExtendedErrorTooBig = 206;
        //
        // Summary:
        //     Indicates a form is present while the printer is being taken out of from removal
        //     mode.
        public const int ExtendedErrorSlipForm = 205;
        //
        // Summary:
        //     Indicates a form has not been inserted into the slip station.
        public const int ExtendedErrorSlipEmpty = 204;
        //
        // Summary:
        //     Indicates the receipt station is out of paper.
        public const int ExtendedErrorReceiptEmpty = 203;
        //
        // Summary:
        //     Indicates the journal station is out of paper.
        public const int ExtendedErrorJournalEmpty = 202;
        //
        // Summary:
        //     Indicates that the printer cover is open.
        public const int ExtendedErrorCoverOpen = 201;
        //
        // Summary:
        //     Indicates the default character set supports the ANSI character set.
        public const int CharacterSetAnsi = 999;
        //
        // Summary:
        //     Indicates an unsupported format.
        public const int ExtendedErrorBadFormat = 207;
        //
        // Summary:
        //     Indicates the default character set supports the ASCII character set.
        public const int CharacterSetAscii = 998;
        //
        // Summary:
        //     Indicates the bar code should be printed aligned with the rightmost print column.
        public const int PrinterBarCodeRight = -3;
        //
        // Summary:
        //     Indicates the bar code should be printed aligned with the center of the station.
        public const int PrinterBarCodeCenter = -2;
        //
        // Summary:
        //     Indicates the bar code should be printed aligned with the leftmost print column.
        public const int PrinterBarCodeLeft = -1;
        //
        // Summary:
        //     Indicates the bitmap should be printed aligned with the rightmost print column.
        public const int PrinterBitmapRight = -3;
        //
        // Summary:
        //     Indicates the bitmap should be printed aligned with the center of the station.
        public const int PrinterBitmapCenter = -2;
        //
        // Summary:
        //     Indicates a full paper cut.
        public const int PrinterCutPaperFullCut = 100;
        //
        // Summary:
        //     Indicates the journal cartridge is near its end.
        public const int StatusJournalCartridgeNearEmpty = 42;
        //
        // Summary:
        //     Indicates the default character set supports the Unicode character set.
        public const int CharacterSetUnicode = 997;
        //
        // Summary:
        //     Indicates the journal cartridge has been removed.
        public const int ExtendedErrorJournalCartridgeRemoved = 208;
        //
        // Summary:
        //     Indicates the bitmap should be printed aligned with the leftmost print column.
        public const int PrinterBitmapLeft = -1;
        //
        // Summary:
        //     Indicates the journal cartridge head is being cleaned.
        public const int ExtendedErrorJournalHeadCleaning = 210;
        //
        // Summary:
        //     Indicates the journal cartridge is empty.
        public const int ExtendedErrorJournalCartridgeEmpty = 209;
        //
        // Summary:
        //     Indicates the slip form is close to the bottom.
        public const int StatusSlipNearEmpty = 28;
        //
        // Summary:
        //     Indicates that no slip form is inserted and no slip form has been detected at
        //     the entrance to the slip station.
        public const int StatusSlipEmpty = 27;
        //
        // Summary:
        //     Indicates the receipt paper is ready.
        public const int StatusReceiptPaperOK = 26;
        //
        // Summary:
        //     Indicates the receipt paper is low.
        public const int StatusReceiptNearEmpty = 25;
        //
        // Summary:
        //     Indicates there is no receipt paper.
        public const int StatusReceiptEmpty = 24;
        //
        // Summary:
        //     Indicates the journal paper is ready.
        public const int StatusJournalPaperOK = 23;
        //
        // Summary:
        //     Indicates the journal paper is low.
        public const int StatusJournalNearEmpty = 22;
        //
        // Summary:
        //     Indicates the slip form is inserted.
        public const int StatusSlipPaperOK = 29;
        //
        // Summary:
        //     Indicates the printer cover is closed.
        public const int StatusCoverOK = 12;
        //
        // Summary:
        //     Indicates the printer cover is open.
        public const int StatusCoverOpen = 11;
        //
        // Summary:
        //     Indicates the slip cartridge head is being cleaned.
        public const int ExtendedErrorSlipHeadCleaning = 216;
        //
        // Summary:
        //     Indicates the slip cartridge is empty.
        public const int ExtendedErrorSlipCartridgeEmpty = 215;
        //
        // Summary:
        //     Indicates the slip cartridge has been removed.
        public const int ExtendedErrorSlipCartridgeRemoved = 214;
        //
        // Summary:
        //     Indicates the receipt cartridge head is being cleaned.
        public const int ExtendedErrorReceiptHeadCleaning = 213;
        //
        // Summary:
        //     Indicates the receipt cartridge is empty.
        public const int ExtendedErrorReceiptCartridgeEmpty = 212;
        //
        // Summary:
        //     Indicates there is no journal paper.
        public const int StatusJournalEmpty = 21;
        //
        // Summary:
        //     Indicates the receipt cartridge has been removed.
        public const int ExtendedErrorReceiptCartridgeRemoved = 211;

        public abstract string ErrorString { get; }
        public abstract PrinterErrorLevel ErrorLevel { get; }
        public abstract PrinterCartridgeSensors CapRecCartridgeSensor { get; }
        public abstract PrinterCartridgeStates RecCartridgeState { get; }
        public abstract PowerReporting CapPowerReporting { get; }

        public abstract PrinterCartridgeNotify CartridgeNotify { get; set; }
        public abstract bool FlagWhenIdle { get; set; }

        public abstract bool CapRecPaperCut { get; }
        public abstract bool CapTransaction { get; }
        public abstract bool CapRecEmptySensor { get; }
        public abstract bool CapCoverSensor { get; }
        public abstract bool CapRecBold { get; }
        public abstract bool AsyncMode { get; set; }
        public abstract int OutputId { get; }
        public abstract bool CoverOpen { get; }
        public abstract bool RecNearEnd { get; }
        public abstract bool RecEmpty { get; }
        public abstract void PrintNormal(PrinterStation station, string name);
        public abstract void PrintImmediate(PrinterStation station, string name);
        public abstract void TransactionPrint(PrinterStation station, PrinterTransactionControl d);
        public abstract void ValidateData(PrinterStation station, string data);
        public abstract void CutPaper(int percentage);

        public abstract void ClearOutput();

        public abstract void DirectIO(int command, int data, object p2);


        public abstract void addErrorListener(ErrorListener listener);
        public abstract void removeErrorListener(ErrorListener listener);
        public abstract void addOutputCompleteListener(OutputCompleteListener listener);
        public abstract void removeOutputCompleteListener(OutputCompleteListener listener);

        //public abstract event DataEventHandler DataEvent;
        public abstract event DeviceErrorEventHandler ErrorEvent;
        public abstract event OutputCompleteEventHandler OutputCompleteEvent;
    }


    public abstract class CashDrawer : PosCommon
    {
        public CashDrawer(DeviceInfo info) : base(info) { }
        //
        // Summary:
        //     Incremented during the OpenDrawer method if the cash drawer successfully opens.
        public const string StatisticDrawerGoodOpenCount = "DrawerGoodOpenCount";
        //
        // Summary:
        //     Incremented during the OpenDrawer method if the cash drawer does not open.
        public const string StatisticDrawerFailedOpenCount = "DrawerFailedOpenCount";
        //
        // Summary:
        //     Indicates that the cash drawer is closed.
        public const int StatusClosed = 0;
        //
        // Summary:
        //     Indicates that the cash drawer is open.
        public const int StatusOpen = 1;


        public abstract PowerReporting CapPowerReporting { get; }
        public abstract bool CapStatus { get; }

        public abstract bool CapStatusMultiDrawerDetect { get; }

        public abstract bool DrawerOpened { get; }

        public abstract void OpenDrawer();
        public abstract void WaitForDrawerClose(int beepTimeout, int beepFrequency, int beepDuration, int beepDelay);

        public abstract event DeviceErrorEventHandler ErrorEvent;
    }


    public abstract class CoinDispenser : PosCommon
    {
        public CoinDispenser(DeviceInfo info) : base(info) { }
    }

    public abstract class RemoteOrderDisplay : PosCommon
    {
        public RemoteOrderDisplay(DeviceInfo info) : base(info) { }

        public abstract event DeviceErrorEventHandler ErrorEvent;

    }
}
