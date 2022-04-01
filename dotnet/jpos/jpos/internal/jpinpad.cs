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
    

    internal class JPINPad : PosCommon, IJPosObject
    {
        internals.PINPad jobj;
        string name;
        public JObject JObject => jobj;



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

        public JPINPad(string Name)
        {
            jobj = new internals.PINPad();
            name = Name;
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



    }

}
