using JNISharp.NativeInterface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using internals = jpos.internals.jpos;

namespace test.jpos
{


    public class JExplorer : PosExplorer
    {
        //DeviceChangedEventHandler devicedAdded;
        //DeviceChangedEventHandler devicedAdded;
        //public static JClass _nativeDataListener;
        //public static JMethodID _dataListenerConstructor;


        public override event DeviceChangedEventHandler DeviceAddedEvent
        {
            add { }
            remove { }
        }

        public override event DeviceChangedEventHandler DeviceRemovedEvent
        {
            add { }
            remove { }
        }

        void Run(params string[] args)
        {
            JClass main = JNI.FindClass("Main");
            if (main.Handle == IntPtr.Zero)
            {
                Console.WriteLine("Couldn't find class");
                return;
            }

            JClass stringArray = JNI.FindClass("java/lang/String");
            if (stringArray.Handle == IntPtr.Zero)
            {
                Console.WriteLine("Couldn't find class");
                return;
            }

            if (main.Handle != IntPtr.Zero)
            {
                //example of how to pass arguments (passes c# string arguments to java)
                List<JString> list = new List<JString>();
                JObjectArray<JString> jStrings = JNI.NewObjectArray<JString>(args.Length, stringArray, null);
                for (int i = 0; i < args.Length; ++i)
                {
                    jStrings.SetElement(JNI.NewString(args[i]), i);
                }


                try
                {
                    //ExecuteMainFunction(main, "main", "([Ljava/lang/String;)V", new JValue(jStrings));
                    ExecuteMainFunction(main, "print", "([Ljava/lang/String;)V", new JValue(jStrings));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

                /*
                JNI.RegisterNatives(main, new JNINativeMethod[] {
                     new JNINativeMethod() { name = "Scanner_ErrorEvent", signature = "()V", fnPtr = Marshal.GetFunctionPointerForDelegate(Scanner_ErrorEvent) },
                     new JNINativeMethod() { name = "Scanner_StatusUpdateEvent", signature = "()V", fnPtr = Marshal.GetFunctionPointerForDelegate(Scanner_StatusUpdateEvent) },
                     new JNINativeMethod() { name = "Printer_ErrorEvent", signature = "()V", fnPtr = Marshal.GetFunctionPointerForDelegate(Printer_ErrorEvent) },
                     new JNINativeMethod() { name = "Printer_StatusUpdateEvent", signature = "()V", fnPtr = Marshal.GetFunctionPointerForDelegate(Printer_StatusUpdateEvent) },
                     new JNINativeMethod() { name = "Printer_OutputCompleteEvent", signature = "()V", fnPtr = Marshal.GetFunctionPointerForDelegate(Printer_OutputCompleteEvent) },
                     new JNINativeMethod() { name = "Cashdrawer_ErrorEvent", signature = "()V", fnPtr = Marshal.GetFunctionPointerForDelegate(Cashdrawer_ErrorEvent) },
                     new JNINativeMethod() { name = "Cashdrawer_StatusUpdateEvent", signature = "()V", fnPtr = Marshal.GetFunctionPointerForDelegate(Cashdrawer_StatusUpdateEvent) },
                 });
                */


            }
        }


        private void ExecuteMainFunction(JClass main, string name, string symbol, params JValue[] args)
        {

            //example of how to invoke a method in java (use javap -s -p Main to discover the methodids)
            JMethodID method = main.GetStaticMethodID(name, symbol);
            if (method.Handle != IntPtr.Zero)
            {
                JNI.CallStaticVoidMethod(main, method, args);
                bool exception = JNI.ExceptionCheck();
                if (exception)
                {
                    JThrowable except = JNI.ExceptionOccurred();
                    JNI.ExceptionClear();
                    throw new jpos.JavaException(except.GetMessage());
                }
            }
            else
            {
                throw new Exception("Couldn't find method");
            }
        }

        public JExplorer(string args)
        {

            /*
            _nativeDataListener = JNI.FindClass("NativeDataListener");
            if (_nativeDataListener.Handle == IntPtr.Zero) throw new PosInvalidStateException();

            _dataListenerConstructor = _nativeDataListener.GetMethodID("<init>", "()V");
            if (_dataListenerConstructor.Handle == IntPtr.Zero) throw new PosInvalidStateException();


            */
            Run(args);
        }

        public override DeviceCollection GetDevices()
        {
            DeviceCollection collection = new DeviceCollection();
            collection.Add(new jpos.DeviceInfo() { Name = "defaultScanner", Description = "defaultScanner", Type = jpos.DeviceType.Scanner,  UposVersion = "", LogicalNames = new string[] { "defaultScanner" }, ServiceObjectName = "javapos", Compatibility = DeviceCompatibilities.CompatibilityLevel1 });
            collection.Add(new jpos.DeviceInfo() { Name = "defaultPOSPrinter", Description = "defaultPOSPrinter", Type = jpos.DeviceType.PosPrinter, UposVersion = "", LogicalNames = new string[] { "defaultPOSPrinter" }, ServiceObjectName = "javapos", Compatibility = DeviceCompatibilities.CompatibilityLevel1 });
            collection.Add(new jpos.DeviceInfo() { Name = "defaultPINPad", Description = "defaultPINPad", Type = jpos.DeviceType.PinPad, UposVersion = "", LogicalNames = new string[] { "defaultPINPad" }, ServiceObjectName = "javapos", Compatibility = DeviceCompatibilities.CompatibilityLevel1 });
            collection.Add(new jpos.DeviceInfo() { Name = "defaultCashDrawer", Description = "defaultCashDrawer", Type = jpos.DeviceType.CashDrawer, UposVersion = "", LogicalNames = new string[] { "defaultCashDrawer" }, ServiceObjectName = "javapos", Compatibility = DeviceCompatibilities.CompatibilityLevel1 });                            
            return collection;
        }

        public override DeviceCollection GetDevices(string type)
        {           
            DeviceCollection collection = new DeviceCollection();
            if (type == jpos.DeviceType.Scanner)
                collection.Add(new jpos.DeviceInfo() { Name = "defaultScanner", Description = "defaultScanner", Type = jpos.DeviceType.Scanner, UposVersion = "", LogicalNames = new string[] { "defaultScanner" }, ServiceObjectName = "javapos", Compatibility = DeviceCompatibilities.CompatibilityLevel1 });
            if (type == jpos.DeviceType.PosPrinter)
                collection.Add(new jpos.DeviceInfo() { Name = "defaultPOSPrinter", Description = "defaultPOSPrinter", Type = jpos.DeviceType.PosPrinter, UposVersion = "", LogicalNames = new string[] { "defaultPOSPrinter" }, ServiceObjectName = "javapos", Compatibility = DeviceCompatibilities.CompatibilityLevel1 });
            if (type == jpos.DeviceType.PinPad)
                collection.Add(new jpos.DeviceInfo() { Name = "defaultPINPad", Description = "defaultPINPad", Type = jpos.DeviceType.PinPad, UposVersion = "", LogicalNames = new string[] { "defaultPINPad" }, ServiceObjectName = "javapos", Compatibility = DeviceCompatibilities.CompatibilityLevel1 });
            if (type == jpos.DeviceType.CashDrawer)
                collection.Add(new jpos.DeviceInfo() { Name = "defaultCashDrawer", Description = "defaultCashDrawer", Type = jpos.DeviceType.CashDrawer, UposVersion = "", LogicalNames = new string[] { "defaultCashDrawer" }, ServiceObjectName = "javapos", Compatibility = DeviceCompatibilities.CompatibilityLevel1 });                
            return collection;
        }

        public override PosCommon CreateInstance(DeviceInfo info)
        {
            if (info.Name == null) throw new PosInvalidStateException();

            if (info.Type == DeviceType.Scanner)
            {
                return new JScanner2(info);
            }
            else if (info.Type == DeviceType.PosPrinter)
            {
                return new JPOSPrinter2(info);
            }
            else if (info.Type == DeviceType.CashDrawer)
            {
                return new JCashDrawer2(info);
            }
            else if (info.Type == DeviceType.CoinDispenser)
            {
                return new JCoinDispenser(info);
            }
            else if (info.Type == DeviceType.PinPad)
            {
                return new JPINPad(info); 
            }
            else
            {
                throw new jpos.PosControlException("Not supported");
            }
        }

        public override DeviceInfo GetDevice(string type)
        {
            //TODO: Implement returning any device of type x
            throw new NotImplementedException();
        }

        public override DeviceInfo GetDevice(string type, string logicalName)
        {
           return new DeviceInfo() { Type = type, Name = logicalName };
        }

        public override void Refresh()
        {
            throw new NotImplementedException();
        }
    }
}
