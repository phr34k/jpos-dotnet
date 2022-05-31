using JNISharp.NativeInterface;
using jpos.internals;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using internals = jpos.internals;

namespace test.jpos
{

    public delegate void ScannerDataEvent(object source, DataListener listener, DataEventArgs evt);
    public delegate void StatusUpdateEvent(object source, StatusListener listener, DataEventArgs evt);

    public class DataListener
    {
        internal static List<KeyValuePair<WeakReference<internals.NativeDataListener>, WeakReference<DataListener>>> dataListeners = 
            new List<KeyValuePair<WeakReference<internals.NativeDataListener>, WeakReference<DataListener>>>();
        public List<WeakReference<IJPosObject>> scanners = new List<WeakReference<IJPosObject>>();
        public event ScannerDataEvent? OnDataReceived;

        class INativeDataListener : internals.NativeDataListener.Native
        {            
            void NativeDataListener.Native.Scanner_DataEvent(NativeDataListener self, internals.jpos.events.DataEvent p0)
            {
                //get the origional NativeDataListener object
                NativeDataListener? registered;
                if( NativeDataListener.TryGet(self.Handle, out registered) == false )
                {
                    return;
                }

                //[registered.Handle]

                NativeDataListener? output;
                WeakReference<DataListener> weakRef = DataListener.dataListeners.Where((m) => m.Key.TryGetTarget(out output) && object.ReferenceEquals(output, registered)).FirstOrDefault().Value;
                DataListener? listnerObject = null;
                if(weakRef.TryGetTarget(out listnerObject) == false )
                {
                    return;
                }

                listnerObject?.OnScan(p0);
            }
        }

        static DataListener()
        {
            internals.NativeDataListener.nativeEvents = new INativeDataListener();
        }
        
        internal void OnScan(internals.jpos.events.DataEvent evt)
        {
            jpos.IJPosObject? scanner = null;

            JObject source = evt.getSource();
            if (TryGetScanner<jpos.IJPosObject>(source, out scanner) == false)
            {
                return;
            }

            int status = evt.getStatus();
            long seq = evt.getSequenceNumber();
            long when = evt.getWhen();
            jpos.DataEventArgs args = new jpos.DataEventArgs(status, new DateTime(when), Convert.ToInt32(seq));
            if (scanner == null) return;
            OnDataReceived?.Invoke(scanner, this, args);
        }

        public bool TryGetScanner<T>(JObject s, out T? l) where T : class, IJPosObject
        {
            IJPosObject? output = null;
            for (int i = 0; i < scanners.Count; i++)
            {
                if (scanners[0].TryGetTarget(out output) && JNI.IsSameObject(output.JObject, s) == true)
                {
                    l = output as T;
                    return l != null;
                }
            }

            if (scanners.Count == 1)
            {
                if (scanners[0].TryGetTarget(out output))
                {
                    l = output as T;
                    return l != null;
                }
            }


            l = null;
            return false;
        }

        internal internals.NativeDataListener jobj;
        public DataListener(PosExplorer explorer)
        {
            jobj = new internals.NativeDataListener();
            if (jobj.Handle == IntPtr.Zero) throw new PosInvalidStateException();


            dataListeners.Add( new KeyValuePair<WeakReference<internals.NativeDataListener>, WeakReference<DataListener>>( new WeakReference<internals.NativeDataListener>(jobj), new WeakReference<DataListener>(this)));
            internals.NativeDataListener.Register(jobj);
        }

        ~DataListener()
        {
            internals.NativeDataListener? output = null;
            dataListeners.RemoveAll((m) => m.Key.TryGetTarget(out output) && object.ReferenceEquals(output, jobj));
            internals.NativeDataListener.Unregister(jobj);
        }

        public void Register(IJPosObject c)
        {
            scanners.Add(new WeakReference<IJPosObject>(c));
        }

        public void Unregister(IJPosObject c)
        {
            IJPosObject? output = null;
            scanners.RemoveAll((m) => m.TryGetTarget(out output) && object.ReferenceEquals(output, c));
        }
    }


    public class StatusListener
    {
        internal static List<KeyValuePair<WeakReference<internals.NativeStatusUpdateListener>, WeakReference<StatusListener>>> dataListeners =
            new List<KeyValuePair<WeakReference<internals.NativeStatusUpdateListener>, WeakReference<StatusListener>>>();
        public List<WeakReference<IJPosObject>> scanners = new List<WeakReference<IJPosObject>>();
        public event StatusUpdateEvent? OnStatusUpdate;

        class INativeStatusListener : internals.NativeStatusUpdateListener.Native
        {
            void NativeStatusUpdateListener.Native.Scanner_DataEvent(NativeStatusUpdateListener self, internals.jpos.events.StatusUpdateEvent p0)
            {
                //get the origional NativeDataListener object
                NativeStatusUpdateListener? registered;
                if (NativeStatusUpdateListener.TryGet(self.Handle, out registered) == false)
                {
                    return;
                }

                //[registered.Handle]

                NativeStatusUpdateListener? output;
                WeakReference<StatusListener> weakRef = StatusListener.dataListeners.Where((m) => m.Key.TryGetTarget(out output) && object.ReferenceEquals(output, registered)).FirstOrDefault().Value;
                StatusListener? listnerObject = null;
                if (weakRef.TryGetTarget(out listnerObject) == false)
                {
                    return;
                }

                listnerObject?.OnScan(p0);
            }
        }

        static StatusListener()
        {
            internals.NativeStatusUpdateListener.nativeEvents = new INativeStatusListener();
        }

        internal void OnScan(internals.jpos.events.StatusUpdateEvent evt)
        {
            jpos.IJPosObject? scanner = null;

            JObject source = evt.getSource();
            if (TryGetScanner<jpos.IJPosObject>(source, out scanner) == false)
            {
                return;
            }

            int status = evt.getStatus();
            long seq = evt.getSequenceNumber();
            long when = evt.getWhen();
            jpos.DataEventArgs args = new jpos.DataEventArgs(status, new DateTime(when), Convert.ToInt32(seq));
            if (scanner == null) return;
            OnStatusUpdate?.Invoke(scanner, this, args);
        }

        public bool TryGetScanner<T>(JObject s, out T? l) where T : class, IJPosObject
        {
            IJPosObject? output = null;
            for (int i = 0; i < scanners.Count; i++)
            {
                if (scanners[0].TryGetTarget(out output) && JNI.IsSameObject(output.JObject, s) == true)
                {
                    l = output as T;
                    return l != null;
                }
            }

            if (scanners.Count == 1)
            {
                if (scanners[0].TryGetTarget(out output))
                {
                    l = output as T;
                    return l != null;
                }
            }


            l = null;
            return false;
        }

        internal internals.NativeStatusUpdateListener jobj;
        public StatusListener(PosExplorer explorer)
        {
            jobj = new internals.NativeStatusUpdateListener();
            if (jobj.Handle == IntPtr.Zero) throw new PosInvalidStateException();


            dataListeners.Add(new KeyValuePair<WeakReference<internals.NativeStatusUpdateListener>, WeakReference<StatusListener>>(new WeakReference<internals.NativeStatusUpdateListener>(jobj), new WeakReference<StatusListener>(this)));
            internals.NativeStatusUpdateListener.Register(jobj);
        }

        ~StatusListener()
        {
            internals.NativeStatusUpdateListener? output = null;
            dataListeners.RemoveAll((m) => m.Key.TryGetTarget(out output) && object.ReferenceEquals(output, jobj));
            internals.NativeStatusUpdateListener.Unregister(jobj);
        }

        public void Register(IJPosObject c)
        {
            scanners.Add(new WeakReference<IJPosObject>(c));
        }

        public void Unregister(IJPosObject c)
        {
            IJPosObject? output = null;
            scanners.RemoveAll((m) => m.TryGetTarget(out output) && object.ReferenceEquals(output, c));
        }
    }


    public interface IJPosObject
    {
        JObject JObject { get; }
    }



}
