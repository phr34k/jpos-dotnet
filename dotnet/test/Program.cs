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
            if( scanner != null ) printer.TransactionPrint(jpos.PrinterStation.Receipt, 0);
            if( scanner != null ) printer.PrintNormal(jpos.PrinterStation.Receipt, string.Format("{0} {1}\n", System.Text.Encoding.ASCII.GetString((source as jpos.Scanner).ScanData), (source as jpos.Scanner).ScanDataType));
            if( scanner != null ) printer.TransactionPrint(jpos.PrinterStation.Receipt, 0);
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
            scanner = explorer.CreateInstance(explorer.GetDevices(jpos.DeviceType.Scanner)[0]) as jpos.Scanner;
            //printer = explorer.CreateInstance(explorer.GetDevices(jpos.DeviceType.PosPrinter)[0]) as jpos.PosPrinter;
            //coins = explorer.CreateInstance(explorer.GetDevices(jpos.DeviceType.PinPad)[0]) as jpos.PosCommon;

            
            if( scanner != null ) scanner.addStatusListener(listener2);
            if( scanner != null ) scanner.addDataListener(listener);
            if( scanner != null ) scanner.Open();
            if( printer != null ) printer.Open();
            if( coins != null ) coins.Open();
            if( scanner != null ) scanner.Claim(0);
            if( printer != null ) printer.Claim(0);
            if( coins != null ) coins.Claim(0);
            if( scanner != null ) scanner.DeviceEnabled = true;
            if( printer != null ) printer.DeviceEnabled = true;
            //coins.DeviceEnabled = true;
            Console.ReadLine();
            if( scanner != null ) scanner.Release();
            if( printer != null ) printer.Release();
            if( coins != null ) coins.Release();            
            if( scanner != null ) scanner.Close();
            if( printer != null ) printer.Close();
            if( coins != null ) coins.Close();


            d.Teardown();
        }

        private static void Listener2_OnStatusUpdate(object source, jpos.StatusListener listener, jpos.DataEventArgs evt)
        {
            
        }
    }



}
