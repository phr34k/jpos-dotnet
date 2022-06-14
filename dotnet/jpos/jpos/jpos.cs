using JNISharp.NativeInterface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.jpos
{
    public delegate void DeviceChangedEventHandler(object sender, DeviceChangedEventArgs e);
    public delegate void DataEventHandler(object sender, DataEventArgs e);
    public delegate void DeviceErrorEventHandler(object sender, DeviceErrorEventArgs e);
    public delegate void StatusUpdateEventHandler(object sender, StatusUpdateEventArgs e);
    public delegate void OutputCompleteEventHandler(object sender, OutputCompleteEventArgs e);

    public class DeviceInfo
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public string Type { get; init; }
        public string Name { get; init; }
        public string Description { get; init; }

        public string ServiceObjectName { get; init; }
        public string ManufacturerName { get; init; }
        public string HardwarePath { get; init; }
        public string[] LogicalNames { get; init; }


        public string HardwareId { get; init; }
        public DeviceCompatibilities? Compatibility { get; init; }

        public string UposVersion { get; init; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        //
        // Summary:
        //     Gets the Boolean value that indicates whether a DeviceInfo instance applies to
        //     the specified service object.
        //
        // Parameters:
        //   serviceObject:
        //     The service object to compare.
        public bool IsDeviceInfoOf(PosCommon serviceObject)
        {
            if (serviceObject == null)
            {
                return false;
            }

            if (serviceObject.deviceInfo == null)
            {
                return false;
            }

            if (string.Compare(Type, serviceObject.deviceInfo.Type, StringComparison.OrdinalIgnoreCase) == 0 && string.Compare(HardwarePath, serviceObject.deviceInfo.HardwarePath, StringComparison.OrdinalIgnoreCase) == 0 && string.Compare(ServiceObjectName, serviceObject.deviceInfo.ServiceObjectName, StringComparison.OrdinalIgnoreCase) == 0)
            {
                return string.Compare(ManufacturerName, serviceObject.deviceInfo.ManufacturerName, StringComparison.OrdinalIgnoreCase) == 0;
            }

            return false;
        }
    }


    public class DeviceChangedEventArgs : EventArgs
    {
        private DeviceInfo device;
        public DeviceInfo Device => device;

        public DeviceChangedEventArgs(DeviceInfo device)
        {
            this.device = device;
        }
    }


    public class DeviceCollection : System.Collections.ReadOnlyCollectionBase, System.Collections.IEnumerable
    {
        public DeviceInfo this[int index]
        {
            get
            {
                DeviceInfo? deviceInfo = base.InnerList[index] as DeviceInfo;
                if (deviceInfo == null) throw new PosInvalidStateException();
                return deviceInfo;
            }
        }

        public DeviceInfo? this[string name]
        {
            get
            {
                DeviceInfo? deviceInfo = null;
                for (int i = 0; i < Count; i++)
                {
                    string[] logicalNames = this[i].LogicalNames;
                    foreach (string strA in logicalNames)
                    {
                        if (string.Compare(strA, name, StringComparison.OrdinalIgnoreCase) == 0)
                        {
                            if (!(deviceInfo == null))
                            {

                                /*
                                TODO:
                                ResourceManager resourceManager = new PosResourceManager(Assembly.GetExecutingAssembly());
                                throw new PosLibraryException(string.Format(CultureInfo.InvariantCulture, resourceManager.GetString("IDS_ERR_MORE_THAN_ONE_DEVICE_OF_THE_TYPE"), new object[1]
                                {
                                    name
                                }));
                                */
                            }

                            deviceInfo = (DeviceInfo?)base.InnerList[i];
                        }
                    }
                }

                return deviceInfo;
            }
        }

        internal int Add(DeviceInfo value)
        {
            foreach (DeviceInfo inner in base.InnerList)
            {
                if (value.Equals(inner))
                {
                    return -1;
                }
            }

            return base.InnerList.Add(value);
        }


        public int IndexOf(DeviceInfo value)
        {
            return base.InnerList.IndexOf(value);
        }

        public bool Contains(DeviceInfo value)
        {
            return base.InnerList.Contains(value);
        }

        public void CopyTo(DeviceInfo[] array, int index)
        {
            base.InnerList.CopyTo(array, index);
        }

        public DeviceCollection()
        {
        }
    }




    public abstract class PosExplorer
    {
        internal static jpos.JPos? d = null;

        public static PosExplorer Instance(string dir, List<String> classPaths) 
        {
            if (d == null)
            {
                d = new JPos();
                d.Setup(dir, classPaths);
            }
             
            return new JExplorer(System.IO.Path.GetFullPath(System.IO.Path.Join(dir, "./jpos.xml"))); 
        }

        public abstract event DeviceChangedEventHandler DeviceAddedEvent;
        public abstract event DeviceChangedEventHandler DeviceRemovedEvent;

        public abstract DeviceCollection GetDevices();
        public abstract DeviceCollection GetDevices(string type);

        public abstract DeviceInfo GetDevice(string type);
        public abstract DeviceInfo GetDevice(string type, string logicalName);
        public abstract PosCommon CreateInstance(DeviceInfo info);
        public abstract void Refresh();
    }

    public class JPos
    {


        public void Setup(string directory, List<String> classPaths)
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

                Console.WriteLine(directory);



                if( classPaths.Count > 0)
                {
	                classPaths.Add(System.IO.Path.Combine(directory, @"java/lib/jpos113.jar"));
	                classPaths.Add(System.IO.Path.Combine(directory, @"java/lib/jpos113-controls.jar"));
	                classPaths.Add(System.IO.Path.Combine(directory, @"java/lib/xerces.jar"));

	                classPaths.Add(System.IO.Path.Combine(directory, @"java/POSdeviceSimulator/bin/"));
	                classPaths.Add(System.IO.Path.Combine(directory, @"java/POSdeviceSimulator/lib/commons-lang-2.6.jar"));
	                classPaths.Add(System.IO.Path.Combine(directory, @"java/POSdeviceSimulator/lib/commons-logging-1.1.1.jar"));
	                classPaths.Add(System.IO.Path.Combine(directory, @"java/POSdeviceSimulator/lib/jdom-2.0.1.jar"));
	                classPaths.Add(System.IO.Path.Combine(directory, @"java/bin/"));
                }

                Console.WriteLine(string.Join(System.IO.Path.PathSeparator, classPaths));



                JNI.Initialize(new JavaVMInitArgs(JNI.Version.V1_8,
                    new JavaVMOption[] {
                    new JavaVMOption(@"-Djava.class.path=" + String.Join(System.IO.Path.PathSeparator, classPaths)),
                    new JavaVMOption(@"-Dawt.useSystemAAFontSettings=on"),
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
