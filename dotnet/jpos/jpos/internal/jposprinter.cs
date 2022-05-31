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

    internal class JPOSPrinter2 : PosPrinter, IJPosObject
    {
        internals.POSPrinter jobj;
        public JObject JObject => jobj;

        public override event OutputCompleteEventHandler OutputCompleteEvent
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

        public JPOSPrinter2(DeviceInfo info) : base(info)
        {
            jobj = new internals.POSPrinter();
        }

        public override PowerState PowerState
        {
            [DebuggerNonUserCode]
            get
            {
                return (PowerState)jobj.getPowerState();
            }
        }



        public override int OutputId
        {
            [DebuggerNonUserCode]
            get
            {
                return jobj.getOutputID();
            }
        }


        public override bool AsyncMode
        {
            [DebuggerNonUserCode]
            get
            {
                return jobj.getAsyncMode();
            }
            [DebuggerNonUserCode]
            set
            {
                jobj.setAsyncMode(value);
            }
        }

        public override bool CapRecBold
        {
            [DebuggerNonUserCode]
            get
            {
                return jobj.getCapRecBold();
            }
        }



        public override bool CapRecEmptySensor
        {
            [DebuggerNonUserCode]
            get
            {
                return jobj.getCapRecEmptySensor();
            }
        }

        public override bool CapCoverSensor
        {
            [DebuggerNonUserCode]
            get
            {
                return jobj.getCapCoverSensor();
            }
        }

        public override bool CoverOpen
        {
            [DebuggerNonUserCode]
            get
            {
                return jobj.getCoverOpen();
            }
        }


        public override bool RecNearEnd
        {
            [DebuggerNonUserCode]
            get
            {
                return jobj.getRecNearEnd();
            }
        }

        public override bool RecEmpty
        {
            [DebuggerNonUserCode]
            get
            {
                return jobj.getRecEmpty();
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
                jobj.setDeviceEnabled(value);
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
        
        
        public override PrinterCartridgeNotify CartridgeNotify
        {
            [DebuggerNonUserCode]
            get
            {
                return (PrinterCartridgeNotify)jobj.getCartridgeNotify();
            }

            [DebuggerNonUserCode]
            set
            {
                jobj.setCartridgeNotify( (int)value );
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

        public override string ErrorString
        {
            [DebuggerNonUserCode]
            get
            {
                return jobj.getErrorString();
            }
        }

        public override PrinterErrorLevel ErrorLevel
        {
            [DebuggerNonUserCode]
            get
            {
                return (PrinterErrorLevel)jobj.getErrorLevel();
            }
        }

        public override PrinterCartridgeSensors CapRecCartridgeSensor
        {
            [DebuggerNonUserCode]
            get
            {
                return (PrinterCartridgeSensors)jobj.getCapRecCartridgeSensor();
            }
        }

        public override PrinterCartridgeStates RecCartridgeState
        {
            [DebuggerNonUserCode]
            get
            {
                return (PrinterCartridgeStates)jobj.getRecCartridgeState();
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

        public override bool CapRecPaperCut
        {
            [DebuggerNonUserCode]
            get
            {
                return jobj.getCapRecPapercut();
            }
        }

        public override bool CapTransaction
        {
            [DebuggerNonUserCode]
            get
            {
                return jobj.getCapTransaction();
            }
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

        [DebuggerNonUserCode]
        public override void CheckHealth(HealthCheckLevel level)
        {
            jobj.checkHealth((int)level);
        }

        [DebuggerNonUserCode]
        public override void PrintNormal(PrinterStation station, string name)
        {
            jobj.printNormal( (int)station, name);
        }

        [DebuggerNonUserCode]
        public override void PrintImmediate(PrinterStation station, string name)
        {
            jobj.printImmediate((int)station, name);
        }


        [DebuggerNonUserCode]
        public override void TransactionPrint(PrinterStation station, PrinterTransactionControl d)
        {
            jobj.transactionPrint((int)station, (int)d);
        }

        [DebuggerNonUserCode]
        public override void ValidateData(PrinterStation station, string data)
        {
            jobj.validateData((int)station, data);
        }

        [DebuggerNonUserCode]
        public override void CutPaper(int percentage)
        {
            jobj.cutPaper(percentage);
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

        public override void ClearOutput()
        {
            jobj.clearOutput();
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
