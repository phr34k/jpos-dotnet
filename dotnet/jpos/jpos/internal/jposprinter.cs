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

        public override bool FlagWhenIdle
        {
            [DebuggerNonUserCode]
            get
            {
                return jobj.getFlagWhenIdle();
            }
            [DebuggerNonUserCode]
            set
            {
                jobj.setFlagWhenIdle(value);
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



        [DebuggerNonUserCode]
        public override void addErrorListener(ErrorListener listener)
        {
            jobj.addErrorListener(new internals.events.ErrorListener(new JClone<JObject>() { Value = listener.jobj }));
            listener.Register(this);
        }

        [DebuggerNonUserCode]
        public override void removeErrorListener(ErrorListener listener)
        {
            jobj.removeErrorListener(new internals.events.ErrorListener(new JClone<JObject>() { Value = listener.jobj }));
            listener.Unregister(this);
        }

        private test.jpos.ErrorListener? _ErrorListener;
        private event DeviceErrorEventHandler? _ErrorEvent;
        private void Listener_OnErrorReceived(object source, test.jpos.ErrorListener listener, test.jpos.DeviceErrorEventArgs evt)
        {
            _ErrorEvent?.Invoke(this, evt);
        }
        public override event DeviceErrorEventHandler ErrorEvent
        {
            add
            {
                lock (jobj)
                {
                    if (_ErrorListener == null)
                    {
                        _ErrorListener = new test.jpos.ErrorListener(null);
                        _ErrorListener.OnError += Listener_OnErrorReceived;
                    }

                    if (_ErrorEvent == null)
                    {
                        if (_ErrorListener != null)
                        {
                            addErrorListener(_ErrorListener);
                        }
                        else
                        {
                            throw new PosException("Couldn't attach DataEvent handler");
                        }
                    }

                    _ErrorEvent += value;
                }
            }
            remove
            {
                lock (jobj)
                {
                    _ErrorEvent -= value;

                    if (_ErrorEvent == null)
                    {
                        if (_ErrorListener != null)
                        {
                            removeErrorListener(_ErrorListener);
                        }
                        else
                        {
                            throw new PosException("Couldn't deattach DataEvent handler");
                        }
                    }
                }
            }
        }





        [DebuggerNonUserCode]
        public override void addOutputCompleteListener(OutputCompleteListener listener)
        {
            jobj.addOutputCompleteListener(new internals.events.OutputCompleteListener(new JClone<JObject>() { Value = listener.jobj }));
            listener.Register(this);
        }

        [DebuggerNonUserCode]
        public override void removeOutputCompleteListener(OutputCompleteListener listener)
        {
            jobj.removeOutputCompleteListener(new internals.events.OutputCompleteListener(new JClone<JObject>() { Value = listener.jobj }));
            listener.Unregister(this);
        }

        private test.jpos.OutputCompleteListener? _OutputCompleteListener;
        private event OutputCompleteEventHandler? _OutputCompleteEvent;
        private void Listener_OnOutputCompleteReceived(object source, test.jpos.OutputCompleteListener listener, test.jpos.OutputCompleteEventArgs evt)
        {
            _OutputCompleteEvent?.Invoke(this, evt);
        }
        public override event OutputCompleteEventHandler OutputCompleteEvent
        {
            add
            {
                lock (jobj)
                {
                    if (_OutputCompleteListener == null)
                    {
                        _OutputCompleteListener = new test.jpos.OutputCompleteListener(null);
                        _OutputCompleteListener.OnOutputComplete += Listener_OnOutputCompleteReceived;
                    }

                    if (_OutputCompleteEvent == null)
                    {
                        if (_OutputCompleteListener != null)
                        {
                            addOutputCompleteListener(_OutputCompleteListener);
                        }
                        else
                        {
                            throw new PosException("Couldn't attach OutputCompleteEvent handler");
                        }
                    }

                    _OutputCompleteEvent += value;
                }
            }
            remove
            {
                lock (jobj)
                {
                    _OutputCompleteEvent -= value;

                    if (_OutputCompleteEvent == null)
                    {
                        if (_OutputCompleteListener != null)
                        {
                            removeOutputCompleteListener(_OutputCompleteListener);
                        }
                        else
                        {
                            throw new PosException("Couldn't deattach OutputCompleteEvent handler");
                        }
                    }
                }
            }
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

        private test.jpos.StatusListener? _StatusListener;
        private event StatusUpdateEventHandler? _StatusUpdateEvent;
        private void StatusListener_OnDataReceived(object source, test.jpos.StatusListener listener, test.jpos.StatusUpdateEventArgs evt)
        {
            _StatusUpdateEvent?.Invoke(this, evt);
        }
        public override event StatusUpdateEventHandler StatusUpdateEvent
        {
            add
            {
                lock (jobj)
                {
                    if (_StatusListener == null)
                    {
                        _StatusListener = new test.jpos.StatusListener(null);
                        _StatusListener.OnStatusUpdate += StatusListener_OnDataReceived;
                    }

                    if (_StatusUpdateEvent == null)
                    {
                        if (_StatusListener != null)
                        {
                            addStatusListener(_StatusListener);
                        }
                        else
                        {
                            throw new PosException("Couldn't attach StatusUpdateEvent handler");
                        }
                    }

                    _StatusUpdateEvent += value;
                }
            }
            remove
            {
                lock (jobj)
                {
                    _StatusUpdateEvent -= value;

                    if (_StatusUpdateEvent == null)
                    {
                        if (_StatusListener != null)
                        {
                            removeStatusListener(_StatusListener);
                        }
                        else
                        {
                            throw new PosException("Couldn't deattach StatusUpdateEvent handler");
                        }
                    }
                }
            }
        }



    }


}
