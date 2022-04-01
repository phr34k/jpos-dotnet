using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.jpos
{

    //
    // Summary:
    //     Enumerates the valid states of a device.
    public enum ControlState
    {
        //
        // Summary:
        //     The device is closed. The service object is not initialized.
        Closed = 1,
        //
        // Summary:
        //     The device is in a good state and is not busy.
        Idle = 2,
        //
        // Summary:
        //     The device is in a good state and is busy performing output.
        Busy = 3,
        //
        // Summary:
        //     An error has been reported, and the application must recover the Control to a
        //     good state before normal I/O can resume.
        Error = 4
    }

    //
    // Summary:
    //     Enumerates the possible printer station modes.
    public enum PrinterStation
    {
        //
        // Summary:
        //     The current printer station is undefined.
        None = 0,
        //
        // Summary:
        //     The current printer station is Journal.
        Journal = 1,
        //
        // Summary:
        //     The current printer station is Receipt.
        Receipt = 2,
        //
        // Summary:
        //     The current printer station is Slip.
        Slip = 4,
        //
        // Summary:
        //     The current printer station combines Receipt and Journal.
        TwoReceiptJournal = 32771,
        //
        // Summary:
        //     The current printer station combines Slip and Journal.
        TwoSlipJournal = 32773,
        //
        // Summary:
        //     The current printer station combines Receipt and Slip.
        TwoSlipReceipt = 32774
    }

    //
    // Summary:
    //     Enumerates the valid bar code symbol types.
    public enum BarCodeSymbology
    {
        //
        // Summary:
        //     The service object cannot determine the barcode symbology
        Unknown = 0,
        //
        // Summary:
        //     UPC-A
        Upca = 101,
        //
        // Summary:
        //     UPC-E
        Upce = 102,
        //
        // Summary:
        //     EAN/JAN-8
        EanJan8 = 103,
        //
        // Summary:
        //     EAN/JAN-13
        EanJan13 = 104,
        //
        // Summary:
        //     Standard (or discrete) 2 of 5
        TF = 105,
        //
        // Summary:
        //     Interleaved 2 of 5
        Itf = 106,
        //
        // Summary:
        //     CodaBar
        Codabar = 107,
        //
        // Summary:
        //     Code 39
        Code39 = 108,
        //
        // Summary:
        //     Code 93
        Code93 = 109,
        //
        // Summary:
        //     Code 128
        Code128 = 110,
        //
        // Summary:
        //     UPC-A with supplemental barcode
        Upcas = 111,
        //
        // Summary:
        //     UPC-E with supplemental barcode
        Upces = 112,
        //
        // Summary:
        //     UPC 1-digit supplement
        Upcd1 = 113,
        //
        // Summary:
        //     UPC 2-digit supplement
        Upcd2 = 114,
        //
        // Summary:
        //     UPC 3-digit supplement
        Upcd3 = 115,
        //
        // Summary:
        //     UPC 4-digit supplement
        Upcd4 = 116,
        //
        // Summary:
        //     UPC 5-digit supplement
        Upcd5 = 117,
        //
        // Summary:
        //     EAN-8
        Ean8S = 118,
        //
        // Summary:
        //     EAN-13
        Ean13S = 119,
        //
        // Summary:
        //     EAN-128
        Ean128 = 120,
        //
        // Summary:
        //     OCRa
        Ocra = 121,
        //
        // Summary:
        //     OCRb
        Ocrb = 122,
        //
        // Summary:
        //     Code 128 with parsing
        Code128Parsed = 123,
        Gs1DataBar = 131,
        //
        // Summary:
        //     Reduced space symbology
        Rss14 = 131,
        Gs1DataBarExpanded = 132,
        //
        // Summary:
        //     Reduced space symbology - expanded
        RssExpanded = 132,
        Gs1DataBarStackedOmnidirectional = 133,
        //
        // Summary:
        //     ItfCK
        ItfCK = 133,
        Gs1DataBarExpandedStacked = 134,
        //
        // Summary:
        //     Gs1DataBar_Type2
        Gs1DataBar_Type2 = 134,
        //
        // Summary:
        //     Ames
        Ames = 135,
        //
        // Summary:
        //     TFMAT
        TFMAT = 136,
        //
        // Summary:
        //     Code39Ck
        Code39Ck = 137,
        //
        // Summary:
        //     Code32
        Code32 = 138,
        //
        // Summary:
        //     CodeCIP
        CodeCIP = 139,
        //
        // Summary:
        //     TriOptic39
        TriOptic39 = 140,
        //
        // Summary:
        //     ISBT128
        ISBT128 = 141,
        //
        // Summary:
        //     Code11
        Code11 = 142,
        //
        // Summary:
        //     MSI
        MSI = 143,
        //
        // Summary:
        //     Plessey
        Plessey = 144,
        //
        // Summary:
        //     Telepen
        Telepen = 145,
        //
        // Summary:
        //     Composite Component A--up to 56 characters of data
        Cca = 151,
        //
        // Summary:
        //     Composite Component B--up to 338 characters of data
        Ccb = 152,
        //
        // Summary:
        //     Composite Conponent C--up to 2361 characters of data
        Ccc = 153,
        //
        // Summary:
        //     Tlc39
        Tlc39 = 154,
        //
        // Summary:
        //     PDF417
        Pdf417 = 201,
        //
        // Summary:
        //     Maxicode
        Maxicode = 202,
        //
        // Summary:
        //     DataMatrix
        DataMatrix = 203,
        //
        // Summary:
        //     QRCode
        QRCode = 204,
        //
        // Summary:
        //     MicroQRCode
        MicroQRCode = 205,
        //
        // Summary:
        //     Aztec
        Aztec = 206,
        //
        // Summary:
        //     MicroPDF417
        MicroPDF417 = 207,
        //
        // Summary:
        //     Gs1DataMatrix
        Gs1DataMatrix = 208,
        //
        // Summary:
        //     Gs1QRCode
        Gs1QRCode = 209,
        //
        // Summary:
        //     Code49
        Code49 = 210,
        //
        // Summary:
        //     Code16k
        Code16k = 211,
        //
        // Summary:
        //     CodablockA
        CodablockA = 212,
        //
        // Summary:
        //     CodablockF
        CodablockF = 213,
        //
        // Summary:
        //     Codablock256
        Codablock256 = 214,
        //
        // Summary:
        //     HANXIN
        HANXIN = 215,
        //
        // Summary:
        //     AusPost
        AusPost = 301,
        //
        // Summary:
        //     CanPost
        CanPost = 302,
        //
        // Summary:
        //     ChinaPost
        ChinaPost = 303,
        //
        // Summary:
        //     DutchKix
        DutchKix = 304,
        InfoMail = 305,
        //
        // Summary:
        //     JapanPost
        JapanPost = 306,
        //
        // Summary:
        //     KoreanPost
        KoreanPost = 307,
        //
        // Summary:
        //     SwedenPost
        SwedenPost = 308,
        //
        // Summary:
        //     UkPost
        UkPost = 309,
        //
        // Summary:
        //     UsIntelligent
        UsIntelligent = 310,
        //
        // Summary:
        //     UsPlanet
        UsPlanet = 311,
        //
        // Summary:
        //     PostNet
        PostNet = 312,
        //
        // Summary:
        //     If greater than or equal to this type, the service object has returned an undefined
        //     symbology
        Other = 501
    }

    //
    // Summary:
    //     Enumerates the valid types of errors for an error event.
    public enum ErrorCode
    {
        //
        // Summary:
        //     No error occurred.
        Success = 0,
        //
        // Summary:
        //     The device must be opened.
        Closed = 101,
        //
        // Summary:
        //     The device is opened but not claimed. Another application has the device claimed,
        //     so it cannot be claimed at this time.
        Claimed = 102,
        //
        // Summary:
        //     The device is opened but not claimed. No other application has the device claimed,
        //     so it can and must be claimed.
        NotClaimed = 103,
        //
        // Summary:
        //     The control cannot communicate with the service object, normally because of a
        //     setup or configuration error.
        NoService = 104,
        //
        // Summary:
        //     The device is opened and claimed (if this is an exclusive use device), but not
        //     enabled.
        Disabled = 105,
        //
        // Summary:
        //     An attempt was made to perform an illegal or unsupported operation with the device,
        //     or an invalid parameter value was used.
        Illegal = 106,
        //
        // Summary:
        //     The physical device is not connected to the system or is not powered on.
        NoHardware = 107,
        //
        // Summary:
        //     The physical device is off-line.
        Offline = 108,
        //
        // Summary:
        //     The file name (or other specified value) does not exist.
        NoExist = 109,
        //
        // Summary:
        //     The file name (or other specified value) already exists.
        Exists = 110,
        //
        // Summary:
        //     The device cannot perform the requested procedure, even though the physical device
        //     is connected to the system, powered on, and on-line.
        Failure = 111,
        //
        // Summary:
        //     The service object timed out waiting for a response from the physical device,
        //     or the control timed out waiting for a response from the service object.
        Timeout = 112,
        //
        // Summary:
        //     The current state does not allow this request. For example: if asynchronous output
        //     is in progress, certain methods may not be allowed.
        Busy = 113,
        //
        // Summary:
        //     A device category-specific error condition occurred. The error condition code
        //     is held in the exception's Microsoft.PointOfService.PosControlException.ErrorCodeExtended
        //     property.
        Extended = 114,
        //
        // Summary:
        //     The method has been deprecated and is no longer available.
        Deprecated = 115
    }

    //
    // Summary:
    //     Enumerates the possible transaction modes for a printer station.
    public enum PrinterTransactionControl
    {
        //
        // Summary:
        //     Starts a transaction.
        Transaction = 11,
        //
        // Summary:
        //     Ends a transaction by printing the buffered data.
        Normal = 12
    }

    //
    // Summary:
    //     Enumerates the possible power reporting capabilities of a device.
    public enum PowerReporting
    {
        //
        // Summary:
        //     The service object cannot determine the state of the device. Therefore, no power
        //     reporting is possible.
        None = 0,
        //
        // Summary:
        //     The service object can determine and report two of the power states, OffOffline
        //     (that is, Off or Offline) and Online.
        Standard = 1,
        //
        // Summary:
        //     The service object can determine and report all three power states, Off, Offline,
        //     and Online.
        Advanced = 2
    }

    //
    // Summary:
    //     Enumerates the possible printer cartridge states.
    [Flags]
    public enum PrinterCartridgeStates
    {
        //
        // Summary:
        //     The cartridge in normal condition.
        OK = 0,
        //
        // Summary:
        //     The cartridge has been removed.
        Removed = 1,
        //
        // Summary:
        //     The cartridge is empty.
        Empty = 2,
        //
        // Summary:
        //     The cartridge is near its end.
        NearEnd = 4,
        //
        // Summary:
        //     The printer head is being cleaned.
        Cleaning = 8,
        //
        // Summary:
        //     Cannot determine the cartridge state.
        Unknown = 268435456
    }

    //
    // Summary:
    //     Enumerates the possible printer-cartridge-monitoring sensors.
    [Flags]
    public enum PrinterCartridgeSensors
    {
        //
        // Summary:
        //     The device does not support cartridge-monitoring sensors.
        None = 0,
        //
        // Summary:
        //     A sensor that indicates the cartridge has been removed.
        Removed = 1,
        //
        // Summary:
        //     A sensor that indicates the cartridge is empty.
        Empty = 2,
        //
        // Summary:
        //     A sensor that determines whether the color cartridge is near its end.
        NearEnd = 4,
        //
        // Summary:
        //     A sensor that indicates the head is being cleaned.
        Cleaning = 8
    }

    //
    // Summary:
    //     Enumerates the possible severity levels for the most recent error condition.
    public enum PrinterErrorLevel
    {
        //
        // Summary:
        //     No errors have occurred.
        None = 1,
        //
        // Summary:
        //     A recoverable error has occurred. (For example, out of paper.)
        Recoverable = 2,
        //
        // Summary:
        //     A nonrecoverable error has occurred. (For example, internal printer failure.)
        Fatal = 3
    }

    //
    // Summary:
    //     Enumerates the possible current power state values for a device.
    public enum PowerState
    {
        //
        // Summary:
        //     Cannot determine the device's power state.
        Unknown = 2000,
        //
        // Summary:
        //     The device is turned on and ready for use.
        Online = 2001,
        //
        // Summary:
        //     The device is turned off or detached from the terminal.
        Off = 2002,
        //
        // Summary:
        //     The device is turned on but is either not ready or unable to respond to requests.
        Offline = 2003,
        //
        // Summary:
        //     The device is either turned off or offline.
        OffOffline = 2004
    }
}
