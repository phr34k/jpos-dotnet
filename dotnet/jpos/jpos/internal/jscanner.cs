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


    internal class JScanner2 : Scanner, IJPosObject
    {
        internals.Scanner jobj;
        string name = null;
        public JObject JObject => jobj;


        public JScanner2(string Name)
        {
            jobj = new internals.Scanner();
            name = Name;
        }

        public override ControlState State
        {
            [DebuggerNonUserCode]
            get
            {
                return (ControlState)jobj.getState();
            }
        }

        public override PowerState PowerState
        {
            [DebuggerNonUserCode]
            get
            {
                return (PowerState)jobj.getPowerState();
            }
        }

        public override bool DeviceEnabled
        {
            [DebuggerNonUserCode]
            get
            {
                return jobj.getDeviceEnabled();
            }
            [DebuggerNonUserCode]
            set
            {
                jobj.setDeviceEnabled(value);
            }
        }

        public override bool DecodeData
        {
            [DebuggerNonUserCode]
            get
            {
                return jobj.getDecodeData();
            }
            [DebuggerNonUserCode]
            set
            {
                jobj.setDecodeData(value);
            }
        }

        public override int DataCount
        {
            [DebuggerNonUserCode]
            get
            {
                return jobj.getDataCount();
            }
        }

        public override byte[] ScanData
        {
            [DebuggerNonUserCode]
            get
            {
                return jobj.getScanData();
            }
        }

        public override byte[] ScanDataLabel
        {
            [DebuggerNonUserCode]
            get
            {
                return jobj.getScanDataLabel();
            }
        }

        public override BarCodeSymbology ScanDataType
        {
            [DebuggerNonUserCode]
            get
            {
                return (BarCodeSymbology)jobj.getScanDataType();
            }
        }

        public override bool Claimed
        {
            [DebuggerNonUserCode]
            get
            {
                return jobj.getClaimed();
            }
        }

        public override string DeviceName
        {
            [DebuggerNonUserCode]
            get
            {
                return jobj.getPhysicalDeviceName();
            }
        }

        public override string DeviceDescription
        {
            [DebuggerNonUserCode]
            get
            {
                return jobj.getPhysicalDeviceDescription();
            }
        }

        [DebuggerNonUserCode]
        public override void Open()
        {
            jobj.open(name);
        }

        [DebuggerNonUserCode]
        public override void Claim(int timeout)
        {
            jobj.claim(timeout);
        }

        [DebuggerNonUserCode]
        public override void Close()
        {
            jobj.close();
        }

        [DebuggerNonUserCode]
        public override void Release()
        {
            jobj.release();
        }

        [DebuggerNonUserCode]
        public override void addDataListener(DataListener listener)
        {
            jobj.addDataListener(new internals.events.DataListener(new JClone<JObject>() { Value = listener.jobj }));
            listener.Register(this);
        }

        [DebuggerNonUserCode]
        public override void removeDataListener(DataListener listener)
        {
            jobj.removeDataListener(new internals.events.DataListener(new JClone<JObject>() { Value = listener.jobj  }  ));
            listener.Unregister(this);
        }


        [DebuggerNonUserCode]
        public override void addStatusListener(StatusListener listener)
        {
            jobj.addStatusUpdateListener(new internals.events.StatusUpdateListener(new JClone<JObject>() { Value = listener.jobj }));
            listener.Register(this);
        }

        [DebuggerNonUserCode]
        public override void removeStatusListener(StatusListener listener)
        {
            jobj.removeStatusUpdateListener(new internals.events.StatusUpdateListener(new JClone<JObject>() { Value = listener.jobj }));
            listener.Unregister(this);
        }


    }



}
