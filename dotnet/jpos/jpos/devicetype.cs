using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.jpos
{
    public static class DeviceType
    {
        public const string Belt = "Belt";
        //
        // Summary:
        //     Indicates a magnetic ink character reader (MICR) device.
        public const string Micr = "Micr";
        //
        // Summary:
        //     Indicates a motion sensor device.
        public const string MotionSensor = "MotionSensor";
        //
        // Summary:
        //     Indicates a magnetic stripe reader (MSR) device.
        public const string Msr = "Msr";
        //
        // Summary:
        //     Indicates a PIN pad device.
        public const string PinPad = "PinPad";
        //
        // Summary:
        //     Indicates a point card reader/writer device.
        public const string PointCardRW = "PointCardRW";
        //
        // Summary:
        //     Indicates a keyboard device.
        public const string PosKeyboard = "PosKeyboard";
        //
        // Summary:
        //     Indicates a power device.
        public const string PosPower = "PosPower";
        //
        // Summary:
        //     Indicates a printer.
        public const string PosPrinter = "PosPrinter";
        //
        // Summary:
        //     Indicates a remote order display device.
        public const string RemoteOrderDisplay = "RemoteOrderDisplay";
        public const string RFIDScanner = "RFIDScanner";
        //
        // Summary:
        //     Indicates a weight scale.
        public const string Scale = "Scale";
        //
        // Summary:
        //     Indicates a scanner (bar code reader) device.
        public const string Scanner = "Scanner";
        //
        // Summary:
        //     Indicates a signature capture device.
        public const string SignatureCapture = "SignatureCapture";
        //
        // Summary:
        //     Indicates a smart card reader / writer device.
        public const string SmartCardRW = "SmartCardRW";
        //
        // Summary:
        //     Indicates a tone indicator device.
        public const string ToneIndicator = "ToneIndicator";
        //
        // Summary:
        //     Indicates a line display device.
        public const string LineDisplay = "LineDisplay";
        public const string Lights = "Lights";
        //
        // Summary:
        //     Indicates a keylock device.
        public const string Keylock = "Keylock";
        public const string ItemDispenser = "ItemDispenser";
        //
        // Summary:
        //     Indicates a bill acceptor device.
        public const string BillAcceptor = "BillAcceptor";
        //
        // Summary:
        //     Indicates a bill dispenser device.
        public const string BillDispenser = "BillDispenser";
        //
        // Summary:
        //     Indicates that the device is a biometrics scanner.
        public const string Biometrics = "Biometrics";
        //
        // Summary:
        //     Indicates a bump bar device.
        public const string BumpBar = "BumpBar";
        //
        // Summary:
        //     Indicates a cash changer device.
        public const string CashChanger = "CashChanger";
        //
        // Summary:
        //     Indicates a cash drawer device.
        public const string CashDrawer = "CashDrawer";
        //
        // Summary:
        //     Indicates a credit authorization terminal (CAT) device.
        public const string Cat = "Cat";
        //
        // Summary:
        //     Indicates a check scanner device.
        public const string CheckScanner = "CheckScanner";
        //
        // Summary:
        //     Indicates a coin dispenser device.
        public const string CoinDispenser = "CoinDispenser";
        //
        // Summary:
        //     Indicates that the device is an electronic journal.
        public const string ElectronicJournal = "ElectronicJournal";
        public const string ElectronicValueRW = "ElectronicValueRW";
        //
        // Summary:
        //     Indicates a fiscal printer device.
        public const string FiscalPrinter = "FiscalPrinter";
        public const string Gate = "Gate";
        //
        // Summary:
        //     Indicates a hard totals device.
        public const string HardTotals = "HardTotals";
        //
        // Summary:
        //     Indicates an image scanner device.
        public const string ImageScanner = "ImageScanner";
        //
        // Summary:
        //     Indicates a coin acceptor device.
        public const string CoinAcceptor = "CoinAcceptor";

        public static DeviceTypeValue GetValue(string deviceType)
        {
            switch (deviceType)
            {
                case DeviceType.Scanner:  return DeviceTypeValue.Scanner;
                case DeviceType.RFIDScanner: return DeviceTypeValue.RFIDScanner;
                case DeviceType.CoinAcceptor: return DeviceTypeValue.CoinAcceptor;
            }

            return DeviceTypeValue.Unknown;
        }

        public enum DeviceTypeValue
        {
            Unknown = 0,
            Belt = 1,
            BillAcceptor = 2,
            BillDispenser = 3,
            Biometrics = 4,
            BumpBar = 5,
            CashChanger = 6,
            CashDrawer = 7,
            Cat = 8,
            CheckScanner = 9,
            CoinAcceptor = 10,
            CoinDispenser = 11,
            ElectronicJournal = 12,
            ElectronicValueRW = 13,
            FiscalPrinter = 14,
            Gate = 15,
            HardTotals = 16,
            ImageScanner = 17,
            ItemDispenser = 18,
            Keylock = 19,
            Lights = 20,
            LineDisplay = 21,
            Micr = 22,
            MotionSensor = 23,
            Msr = 24,
            PinPad = 25,
            PointCardRW = 26,
            PosKeyboard = 27,
            PosPower = 28,
            PosPrinter = 29,
            RemoteOrderDisplay = 30,
            RFIDScanner = 31,
            Scale = 32,
            Scanner = 33,
            SignatureCapture = 34,
            SmartCardRW = 35,
            ToneIndicator = 36
        }
    }
}
