using JNISharp.NativeInterface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;

using internals = jpos.internals.jpos;

namespace test
{
    
    class Program
    {

        private static void Listener_OnDataReceived(object source, jpos.DataListener listener, jpos.DataEventArgs evt)
        {
            Console.WriteLine("Scanner_DataEvent {0}", evt.ToString());
            printer.TransactionPrint(jpos.PrinterStation.Receipt, 0);
            printer.PrintNormal(jpos.PrinterStation.Receipt, string.Format("{0} {1}\n", System.Text.Encoding.ASCII.GetString((source as jpos.Scanner).ScanData), (source as jpos.Scanner).ScanDataType));
            printer.TransactionPrint(jpos.PrinterStation.Receipt, 0);
        }


        static jpos.PosExplorer explorer = null;
        static jpos.DataListener listener = null;
        static jpos.StatusListener listener2 = null;        
        static jpos.Scanner scanner = null;
        static jpos.PosPrinter printer = null;

        static jpos.PosCommon coins = null;


        static void Main(string[] args)
        {

            var d = new jpos.JPos();
            d.Setup();

            explorer = new jpos.JExplorer(args[0]);
            listener = new jpos.DataListener(explorer);
            listener2 = new jpos.StatusListener(explorer);

            listener2.OnStatusUpdate += Listener2_OnStatusUpdate;            
            listener.OnDataReceived += Listener_OnDataReceived;
            scanner = explorer.CreateDevice(new jpos.DeviceInfo() { Name = "defaultScanner", Type = jpos.DeviceType.Scanner }) as jpos.Scanner;
            printer = explorer.CreateDevice(new jpos.DeviceInfo() { Name = "defaultPOSPrinter", Type = jpos.DeviceType.PosPrinter }) as jpos.PosPrinter;
            coins = explorer.CreateDevice(new jpos.DeviceInfo() { Name = "defaultPINPad", Type = jpos.DeviceType.PinPad }) as jpos.PosCommon;

            scanner.addStatusListener(listener2);
            scanner.addDataListener(listener);
            scanner.Open();
            printer.Open();
            coins.Open();
            scanner.Claim(0);
            printer.Claim(0);
            coins.Claim(0);
            scanner.DeviceEnabled = true;
            printer.DeviceEnabled = true;
            //coins.DeviceEnabled = true;
            Console.ReadLine();
            scanner.Release();
            printer.Release();
            coins.Release();            
            scanner.Close();
            printer.Close();
            coins.Close();


            d.Teardown();
        }

        private static void Listener2_OnStatusUpdate(object source, jpos.StatusListener listener, jpos.DataEventArgs evt)
        {
            
        }
    }



}
