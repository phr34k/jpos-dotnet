using JNISharp.NativeInterface;
using jpos;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using internals = jpos.internals.jpos;

namespace test.jpos
{    

    internal class JCashDrawer2 : CashDrawer, IJPosObject
    {

        internals.CashDrawer jobj;
        JObject IJPosObject.JObject => jobj;


        public JCashDrawer2(DeviceInfo info) : base(info)
        {
            jobj = new internals.CashDrawer();
        }


        public override PowerState PowerState
        {
            [DebuggerNonUserCode]
            get
            {
                return (PowerState)jobj.getPowerState();
            }
        }

        public override bool CapStatus
        {
            [DebuggerNonUserCode]
            get
            {
                return jobj.getCapStatus();
            }
        }

        public override PowerReporting CapPowerReporting
        {
            [DebuggerNonUserCode]
            get
            {
                return (PowerReporting)jobj.getCapPowerReporting();
            }
        }



        public override bool CapStatusMultiDrawerDetect
        {
            [DebuggerNonUserCode]
            get
            {
                return jobj.getCapStatusMultiDrawerDetect();
            }
        }

        public override bool DrawerOpened
        {
            [DebuggerNonUserCode]
            get
            {
                return jobj.getDrawerOpened();
            }
        }


        public override ControlState State
        {
            [DebuggerNonUserCode]
            get
            {
                return (ControlState)jobj.getState();
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
                jobj.setDeviceEnabled(true);
            }
        }

        public override bool FreezeEvents
        {
            [DebuggerNonUserCode]
            get
            {
                return jobj.getFreezeEvents();
            }
            [DebuggerNonUserCode]
            set
            {
                jobj.setFreezeEvents(value);
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
        public override void OpenDrawer()
        {
            jobj.openDrawer();
        }

        [DebuggerNonUserCode]
        public override void WaitForDrawerClose(int beepTimeout, int beepFrequency, int beepDuration, int beepDelay)
        {
            jobj.waitForDrawerClose(beepTimeout, beepFrequency, beepDuration, beepDelay);
        }


        [DebuggerNonUserCode]
        public override void Open()
        {
            jobj.open(deviceInfo.Name);
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
        public override void CheckHealth(HealthCheckLevel level)
        {
            jobj.checkHealth((int)level);
        }

        public override PowerNotification PowerNotify
        {
            [DebuggerNonUserCode]
            get
            {
                return (PowerNotification)jobj.getPowerNotify();
            }
            [DebuggerNonUserCode]
            set
            {
                jobj.setPowerNotify((int)value);
            }
        }

        public override event DataEventHandler DataEvent
        {
            add
            {
                //TODO:
            }
            remove
            {
                //TODO:
            }
        }

        public override event DeviceErrorEventHandler ErrorEvent
        {
            add
            {
                //TODO:
            }
            remove
            {
                //TODO:
            }

        }

        public override event StatusUpdateEventHandler StatusUpdateEvent
        {
            add
            {
                //TODO:
            }
            remove
            {
                //TODO:
            }

        }
    }

}
