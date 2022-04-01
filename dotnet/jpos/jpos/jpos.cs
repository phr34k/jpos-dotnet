using JNISharp.NativeInterface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.jpos
{


        
    public class DeviceInfo
    {
        public string Type { get; set; }
        public string Name { get; set; }
    }

    public abstract class PosExplorer
    {
        public abstract DeviceInfo GetDevice(string type);
        public abstract DeviceInfo GetDevice(string type, string logicalName);
        public abstract PosCommon CreateDevice(DeviceInfo info);
        public abstract void Refresh();
    }

    public class JPos
    {


        public void Setup()
        {
            try
            {
                /*
                if (Environment.CurrentDirectory.EndsWith("net6.0") == true)
                {
                    //run from within visual studio which runs project from bin/net6.0 folders as 
                    Environment.CurrentDirectory = @"..\..\..\..\..\";
                }
                else
                {
                    Environment.CurrentDirectory = @"../../";
                }
                */

                Console.WriteLine(Environment.CurrentDirectory);



                List<String> classPaths = new List<string>();
                //classPaths.Add(@"C:\Program Files\Honeywell\UPOS Suite\JavaPOS Suite\jpos113.jar");
                //classPaths.Add(@"C:\Program Files\Honeywell\UPOS Suite\JavaPOS Suite\jpos113-controls.jar");
                //classPaths.Add(@"C:\Program Files\Honeywell\UPOS Suite\JavaPOS Suite\xerces.jar");

                classPaths.Add(System.IO.Path.Combine(Environment.CurrentDirectory, @"java/lib/jpos113.jar"));
                classPaths.Add(System.IO.Path.Combine(Environment.CurrentDirectory, @"java/lib/jpos113-controls.jar"));
                classPaths.Add(System.IO.Path.Combine(Environment.CurrentDirectory, @"java/lib/xerces.jar"));

                classPaths.Add(System.IO.Path.Combine(Environment.CurrentDirectory, @"java/POSdeviceSimulator/bin/"));
                classPaths.Add(System.IO.Path.Combine(Environment.CurrentDirectory, @"java/POSdeviceSimulator/lib/commons-lang-2.6.jar"));
                classPaths.Add(System.IO.Path.Combine(Environment.CurrentDirectory, @"java/POSdeviceSimulator/lib/commons-logging-1.1.1.jar"));
                classPaths.Add(System.IO.Path.Combine(Environment.CurrentDirectory, @"java/POSdeviceSimulator/lib/jdom-2.0.1.jar"));
                classPaths.Add(System.IO.Path.Combine(Environment.CurrentDirectory, @"java/bin/"));

                Console.WriteLine(string.Join(System.IO.Path.PathSeparator, classPaths));



                JNI.Initialize(new JavaVMInitArgs(JNI.Version.V1_8,
                    new JavaVMOption[] {
                    new JavaVMOption(@"-Djava.class.path=" + String.Join(System.IO.Path.PathSeparator, classPaths)),
                    new JavaVMOption(@"-Djava.library.path="),
                        //new JavaVMOption(@"-verbose:jni")
                    },
                    true));
                int version = JNI.GetVersion();
                Console.WriteLine("Java VM Initialized with version: {0}", version);
   
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void Teardown()
        {
            
        }


    }



        
    }
