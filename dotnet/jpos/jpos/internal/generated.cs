using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using JNISharp.NativeInterface;
using test.jpos;
#pragma warning disable CS0108 // Member hides inherited member; missing new keyword

namespace jpos.internals   {
namespace jpos.events {
class JposEvent : java.util.EventObject {
	protected static JClass _class = JNI.FindClass("jpos/events/JposEvent");
	protected static string _init0 = "(Ljava/lang/Object;)V";
	protected static string _getSequenceNumber0 = "()J";
	protected static string _getWhen1 = "()J";
	protected static JMethodID _minit0 = _class.GetMethodID("<init>", _init0);
	protected static JMethodID _mgetSequenceNumber0 = _class.GetMethodID("getSequenceNumber", _getSequenceNumber0);
	protected static JMethodID _mgetWhen1 = _class.GetMethodID("getWhen", _getWhen1);

	[DebuggerNonUserCode]
	public static bool IsInstanceOf(JObject except)
	{
	  return JNI.IsInstanceOf(except, _class);
	}
	[DebuggerNonUserCode]
	private static Exception FromThrowable(JThrowable except)
	{
	  if (jpos.JposException.IsInstanceOf(except))
	  {
	    jpos.JposException d = new jpos.JposException(new JClone<JObject>() { Value = except });
	    d.printStackTrace();
	    int errorCode = d.getErrorCode();
	    int errorCodeExtended = d.getErrorCodeExtended();
	    return new PosControlException(except.ToString(), (ErrorCode)errorCode, errorCodeExtended);
	  }
	  else
	  {
	    except.printStackTrace();
	    return new JavaException(except.ToString());
	  }
	}

	[DebuggerNonUserCode]
	public JposEvent(JClone<JObject> obj) : base(obj) {} 

	public JposEvent(JObject p0) : base(initialize(p0)) {}
	[DebuggerNonUserCode]
	protected static JClone<JObject> initialize(JObject p0) 
	{
	    JObject ret = JNI.NewObject<JObject>(_class, _minit0, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (ret.Handle == IntPtr.Zero) throw new PosInvalidStateException();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return new JClone<JObject>() { Value = ret } ;
	}



	[DebuggerNonUserCode]
	public long getSequenceNumber() 
	{
	    long ret = JNI.CallMethod<long>(this, _mgetSequenceNumber0);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public long getWhen() 
	{
	    long ret = JNI.CallMethod<long>(this, _mgetWhen1);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

}
}

namespace jpos.events {
class DataEvent : jpos.events.JposEvent {
	protected static JClass _class = JNI.FindClass("jpos/events/DataEvent");
	protected static string _init0 = "(Ljava/lang/Object;I)V";
	protected static string _getStatus0 = "()I";
	protected static JMethodID _minit0 = _class.GetMethodID("<init>", _init0);
	protected static JMethodID _mgetStatus0 = _class.GetMethodID("getStatus", _getStatus0);

	[DebuggerNonUserCode]
	public static bool IsInstanceOf(JObject except)
	{
	  return JNI.IsInstanceOf(except, _class);
	}
	[DebuggerNonUserCode]
	private static Exception FromThrowable(JThrowable except)
	{
	  if (jpos.JposException.IsInstanceOf(except))
	  {
	    jpos.JposException d = new jpos.JposException(new JClone<JObject>() { Value = except });
	    d.printStackTrace();
	    int errorCode = d.getErrorCode();
	    int errorCodeExtended = d.getErrorCodeExtended();
	    return new PosControlException(except.ToString(), (ErrorCode)errorCode, errorCodeExtended);
	  }
	  else
	  {
	    except.printStackTrace();
	    return new JavaException(except.ToString());
	  }
	}

	[DebuggerNonUserCode]
	public DataEvent(JClone<JObject> obj) : base(obj) {} 

	public DataEvent(JObject p0,int p1) : base(initialize(p0,p1)) {}
	[DebuggerNonUserCode]
	protected static JClone<JObject> initialize(JObject p0,int p1) 
	{
	    JObject ret = JNI.NewObject<JObject>(_class, _minit0, new JValue(p0),new JValue(p1));
	    bool exception = JNI.ExceptionCheck();
	    if (ret.Handle == IntPtr.Zero) throw new PosInvalidStateException();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return new JClone<JObject>() { Value = ret } ;
	}



	[DebuggerNonUserCode]
	public int getStatus() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetStatus0);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

}
}

namespace jpos.events {
class StatusUpdateEvent : jpos.events.JposEvent {
	protected static JClass _class = JNI.FindClass("jpos/events/StatusUpdateEvent");
	protected static string _init0 = "(Ljava/lang/Object;I)V";
	protected static string _getStatus0 = "()I";
	protected static JMethodID _minit0 = _class.GetMethodID("<init>", _init0);
	protected static JMethodID _mgetStatus0 = _class.GetMethodID("getStatus", _getStatus0);

	[DebuggerNonUserCode]
	public static bool IsInstanceOf(JObject except)
	{
	  return JNI.IsInstanceOf(except, _class);
	}
	[DebuggerNonUserCode]
	private static Exception FromThrowable(JThrowable except)
	{
	  if (jpos.JposException.IsInstanceOf(except))
	  {
	    jpos.JposException d = new jpos.JposException(new JClone<JObject>() { Value = except });
	    d.printStackTrace();
	    int errorCode = d.getErrorCode();
	    int errorCodeExtended = d.getErrorCodeExtended();
	    return new PosControlException(except.ToString(), (ErrorCode)errorCode, errorCodeExtended);
	  }
	  else
	  {
	    except.printStackTrace();
	    return new JavaException(except.ToString());
	  }
	}

	[DebuggerNonUserCode]
	public StatusUpdateEvent(JClone<JObject> obj) : base(obj) {} 

	public StatusUpdateEvent(JObject p0,int p1) : base(initialize(p0,p1)) {}
	[DebuggerNonUserCode]
	protected static JClone<JObject> initialize(JObject p0,int p1) 
	{
	    JObject ret = JNI.NewObject<JObject>(_class, _minit0, new JValue(p0),new JValue(p1));
	    bool exception = JNI.ExceptionCheck();
	    if (ret.Handle == IntPtr.Zero) throw new PosInvalidStateException();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return new JClone<JObject>() { Value = ret } ;
	}



	[DebuggerNonUserCode]
	public int getStatus() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetStatus0);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

}
}

namespace jpos.events {
class DirectIOEvent : jpos.events.JposEvent {
	protected static JClass _class = JNI.FindClass("jpos/events/DirectIOEvent");
	protected static string _init0 = "(Ljava/lang/Object;IILjava/lang/Object;)V";
	protected static string _getObject0 = "()Ljava/lang/Object;";
	protected static string _getEventNumber1 = "()I";
	protected static string _getData2 = "()I";
	protected static string _setObject3 = "(Ljava/lang/Object;)V";
	protected static string _setData4 = "(I)V";
	protected static JMethodID _minit0 = _class.GetMethodID("<init>", _init0);
	protected static JMethodID _mgetObject0 = _class.GetMethodID("getObject", _getObject0);
	protected static JMethodID _mgetEventNumber1 = _class.GetMethodID("getEventNumber", _getEventNumber1);
	protected static JMethodID _mgetData2 = _class.GetMethodID("getData", _getData2);
	protected static JMethodID _msetObject3 = _class.GetMethodID("setObject", _setObject3);
	protected static JMethodID _msetData4 = _class.GetMethodID("setData", _setData4);

	[DebuggerNonUserCode]
	public static bool IsInstanceOf(JObject except)
	{
	  return JNI.IsInstanceOf(except, _class);
	}
	[DebuggerNonUserCode]
	private static Exception FromThrowable(JThrowable except)
	{
	  if (jpos.JposException.IsInstanceOf(except))
	  {
	    jpos.JposException d = new jpos.JposException(new JClone<JObject>() { Value = except });
	    d.printStackTrace();
	    int errorCode = d.getErrorCode();
	    int errorCodeExtended = d.getErrorCodeExtended();
	    return new PosControlException(except.ToString(), (ErrorCode)errorCode, errorCodeExtended);
	  }
	  else
	  {
	    except.printStackTrace();
	    return new JavaException(except.ToString());
	  }
	}

	[DebuggerNonUserCode]
	public DirectIOEvent(JClone<JObject> obj) : base(obj) {} 

	public DirectIOEvent(JObject p0,int p1,int p2,JObject p3) : base(initialize(p0,p1,p2,p3)) {}
	[DebuggerNonUserCode]
	protected static JClone<JObject> initialize(JObject p0,int p1,int p2,JObject p3) 
	{
	    JObject ret = JNI.NewObject<JObject>(_class, _minit0, new JValue(p0),new JValue(p1),new JValue(p2),new JValue(p3));
	    bool exception = JNI.ExceptionCheck();
	    if (ret.Handle == IntPtr.Zero) throw new PosInvalidStateException();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return new JClone<JObject>() { Value = ret } ;
	}



	[DebuggerNonUserCode]
	public JObject getObject() 
	{
	    JObject ret = JNI.CallObjectMethod<JObject>(this, _mgetObject0);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public int getEventNumber() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetEventNumber1);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public int getData() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetData2);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void setObject(JObject p0) 
	{
	    JNI.CallVoidMethod(this, _msetObject3, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void setData(int p0) 
	{
	    JNI.CallVoidMethod(this, _msetData4, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

}
}

namespace java.util {
class EventObject : JObject {
	protected static JClass _class = JNI.FindClass("java/util/EventObject");
	protected static string _init0 = "(Ljava/lang/Object;)V";
	protected static string _getSource0 = "()Ljava/lang/Object;";
	protected static JMethodID _minit0 = _class.GetMethodID("<init>", _init0);
	protected static JMethodID _mgetSource0 = _class.GetMethodID("getSource", _getSource0);

	[DebuggerNonUserCode]
	public static bool IsInstanceOf(JObject except)
	{
	  return JNI.IsInstanceOf(except, _class);
	}
	[DebuggerNonUserCode]
	private static Exception FromThrowable(JThrowable except)
	{
	  if (jpos.JposException.IsInstanceOf(except))
	  {
	    jpos.JposException d = new jpos.JposException(new JClone<JObject>() { Value = except });
	    d.printStackTrace();
	    int errorCode = d.getErrorCode();
	    int errorCodeExtended = d.getErrorCodeExtended();
	    return new PosControlException(except.ToString(), (ErrorCode)errorCode, errorCodeExtended);
	  }
	  else
	  {
	    except.printStackTrace();
	    return new JavaException(except.ToString());
	  }
	}

	[DebuggerNonUserCode]
	public EventObject(JClone<JObject> obj) : base(obj) {} 

	public EventObject(JObject p0) : base(initialize(p0)) {}
	[DebuggerNonUserCode]
	protected static JClone<JObject> initialize(JObject p0) 
	{
	    JObject ret = JNI.NewObject<JObject>(_class, _minit0, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (ret.Handle == IntPtr.Zero) throw new PosInvalidStateException();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return new JClone<JObject>() { Value = ret } ;
	}



	[DebuggerNonUserCode]
	public JObject getSource() 
	{
	    JObject ret = JNI.CallObjectMethod<JObject>(this, _mgetSource0);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

}
}

namespace jpos {
class BaseControl : JObject {
	protected static JClass _class;
	protected static string _getState0 = "()I";
	protected static string _close1 = "()V";
	protected static string _open2 = "(Ljava/lang/String;)V";
	protected static string _release3 = "()V";
	protected static string _getCheckHealthText4 = "()Ljava/lang/String;";
	protected static string _setFreezeEvents5 = "(Z)V";
	protected static string _checkHealth6 = "(I)V";
	protected static string _directIO7 = "(I[ILjava/lang/Object;)V";
	protected static string _getFreezeEvents8 = "()Z";
	protected static string _setDeviceEnabled9 = "(Z)V";
	protected static string _claim10 = "(I)V";
	protected static string _getDeviceEnabled11 = "()Z";
	protected static string _getClaimed12 = "()Z";
	protected static string _getPhysicalDeviceDescription13 = "()Ljava/lang/String;";
	protected static string _getDeviceControlDescription14 = "()Ljava/lang/String;";
	protected static string _getDeviceControlVersion15 = "()I";
	protected static string _getDeviceServiceDescription16 = "()Ljava/lang/String;";
	protected static string _getDeviceServiceVersion17 = "()I";
	protected static string _getPhysicalDeviceName18 = "()Ljava/lang/String;";
	protected static JMethodID _mgetState0;
	protected static JMethodID _mclose1;
	protected static JMethodID _mopen2;
	protected static JMethodID _mrelease3;
	protected static JMethodID _mgetCheckHealthText4;
	protected static JMethodID _msetFreezeEvents5;
	protected static JMethodID _mcheckHealth6;
	protected static JMethodID _mdirectIO7;
	protected static JMethodID _mgetFreezeEvents8;
	protected static JMethodID _msetDeviceEnabled9;
	protected static JMethodID _mclaim10;
	protected static JMethodID _mgetDeviceEnabled11;
	protected static JMethodID _mgetClaimed12;
	protected static JMethodID _mgetPhysicalDeviceDescription13;
	protected static JMethodID _mgetDeviceControlDescription14;
	protected static JMethodID _mgetDeviceControlVersion15;
	protected static JMethodID _mgetDeviceServiceDescription16;
	protected static JMethodID _mgetDeviceServiceVersion17;
	protected static JMethodID _mgetPhysicalDeviceName18;

	static BaseControl()
	{
		Trace.TraceInformation("Initializing BaseControl");
		_class = JNI.FindClass("jpos/BaseControl");
		if (_class == null) throw new PosInvalidStateException();
		_mgetState0 = _class.GetMethodID("getState", _getState0);
		if (_mgetState0.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mclose1 = _class.GetMethodID("close", _close1);
		if (_mclose1.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mopen2 = _class.GetMethodID("open", _open2);
		if (_mopen2.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mrelease3 = _class.GetMethodID("release", _release3);
		if (_mrelease3.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mgetCheckHealthText4 = _class.GetMethodID("getCheckHealthText", _getCheckHealthText4);
		if (_mgetCheckHealthText4.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_msetFreezeEvents5 = _class.GetMethodID("setFreezeEvents", _setFreezeEvents5);
		if (_msetFreezeEvents5.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mcheckHealth6 = _class.GetMethodID("checkHealth", _checkHealth6);
		if (_mcheckHealth6.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mdirectIO7 = _class.GetMethodID("directIO", _directIO7);
		if (_mdirectIO7.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mgetFreezeEvents8 = _class.GetMethodID("getFreezeEvents", _getFreezeEvents8);
		if (_mgetFreezeEvents8.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_msetDeviceEnabled9 = _class.GetMethodID("setDeviceEnabled", _setDeviceEnabled9);
		if (_msetDeviceEnabled9.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mclaim10 = _class.GetMethodID("claim", _claim10);
		if (_mclaim10.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mgetDeviceEnabled11 = _class.GetMethodID("getDeviceEnabled", _getDeviceEnabled11);
		if (_mgetDeviceEnabled11.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mgetClaimed12 = _class.GetMethodID("getClaimed", _getClaimed12);
		if (_mgetClaimed12.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mgetPhysicalDeviceDescription13 = _class.GetMethodID("getPhysicalDeviceDescription", _getPhysicalDeviceDescription13);
		if (_mgetPhysicalDeviceDescription13.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mgetDeviceControlDescription14 = _class.GetMethodID("getDeviceControlDescription", _getDeviceControlDescription14);
		if (_mgetDeviceControlDescription14.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mgetDeviceControlVersion15 = _class.GetMethodID("getDeviceControlVersion", _getDeviceControlVersion15);
		if (_mgetDeviceControlVersion15.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mgetDeviceServiceDescription16 = _class.GetMethodID("getDeviceServiceDescription", _getDeviceServiceDescription16);
		if (_mgetDeviceServiceDescription16.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mgetDeviceServiceVersion17 = _class.GetMethodID("getDeviceServiceVersion", _getDeviceServiceVersion17);
		if (_mgetDeviceServiceVersion17.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mgetPhysicalDeviceName18 = _class.GetMethodID("getPhysicalDeviceName", _getPhysicalDeviceName18);
		if (_mgetPhysicalDeviceName18.Handle == IntPtr.Zero) throw new PosInvalidStateException();
	}

	[DebuggerNonUserCode]
	public static bool IsInstanceOf(JObject except)
	{
	  return JNI.IsInstanceOf(except, _class);
	}
	[DebuggerNonUserCode]
	private static Exception FromThrowable(JThrowable except)
	{
	  if (jpos.JposException.IsInstanceOf(except))
	  {
	    jpos.JposException d = new jpos.JposException(new JClone<JObject>() { Value = except });
	    d.printStackTrace();
	    int errorCode = d.getErrorCode();
	    int errorCodeExtended = d.getErrorCodeExtended();
	    return new PosControlException(except.ToString(), (ErrorCode)errorCode, errorCodeExtended);
	  }
	  else
	  {
	    except.printStackTrace();
	    return new JavaException(except.ToString());
	  }
	}

	[DebuggerNonUserCode]
	public BaseControl(JClone<JObject> obj) : base(obj) {} 



	[DebuggerNonUserCode]
	public int getState() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetState0);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void close() 
	{
	    JNI.CallVoidMethod(this, _mclose1);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void open(string p0) 
	{
	    JNI.CallVoidMethod(this, _mopen2, new JValue(JNI.NewString(p0)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void release() 
	{
	    JNI.CallVoidMethod(this, _mrelease3);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public string getCheckHealthText() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetCheckHealthText4);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret.GetString();
	}

	[DebuggerNonUserCode]
	public void setFreezeEvents(bool p0) 
	{
	    JNI.CallVoidMethod(this, _msetFreezeEvents5, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void checkHealth(int p0) 
	{
	    JNI.CallVoidMethod(this, _mcheckHealth6, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void directIO(int p0,JObject p1,JObject p2) 
	{
	    JNI.CallVoidMethod(this, _mdirectIO7, new JValue(p0),new JValue(p1),new JValue(p2));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public bool getFreezeEvents() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetFreezeEvents8);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void setDeviceEnabled(bool p0) 
	{
	    JNI.CallVoidMethod(this, _msetDeviceEnabled9, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void claim(int p0) 
	{
	    JNI.CallVoidMethod(this, _mclaim10, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public bool getDeviceEnabled() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetDeviceEnabled11);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getClaimed() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetClaimed12);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public string getPhysicalDeviceDescription() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetPhysicalDeviceDescription13);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret.GetString();
	}

	[DebuggerNonUserCode]
	public string getDeviceControlDescription() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetDeviceControlDescription14);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret.GetString();
	}

	[DebuggerNonUserCode]
	public int getDeviceControlVersion() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetDeviceControlVersion15);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public string getDeviceServiceDescription() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetDeviceServiceDescription16);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret.GetString();
	}

	[DebuggerNonUserCode]
	public int getDeviceServiceVersion() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetDeviceServiceVersion17);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public string getPhysicalDeviceName() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetPhysicalDeviceName18);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret.GetString();
	}

}
}

namespace jpos {
class BaseJposControl : JObject {
	protected static JClass _class;
	protected static string _init0 = "()V";
	protected static string _getState0 = "()I";
	protected static string _close1 = "()V";
	protected static string _open2 = "(Ljava/lang/String;)V";
	protected static string _release3 = "()V";
	protected static string _getCheckHealthText4 = "()Ljava/lang/String;";
	protected static string _setFreezeEvents5 = "(Z)V";
	protected static string _checkHealth6 = "(I)V";
	protected static string _directIO7 = "(I[ILjava/lang/Object;)V";
	protected static string _getFreezeEvents8 = "()Z";
	protected static string _setDeviceEnabled9 = "(Z)V";
	protected static string _claim10 = "(I)V";
	protected static string _getDeviceEnabled11 = "()Z";
	protected static string _getClaimed12 = "()Z";
	protected static string _getPhysicalDeviceDescription13 = "()Ljava/lang/String;";
	protected static string _getDeviceControlDescription14 = "()Ljava/lang/String;";
	protected static string _getDeviceControlVersion15 = "()I";
	protected static string _getDeviceServiceDescription16 = "()Ljava/lang/String;";
	protected static string _getDeviceServiceVersion17 = "()I";
	protected static string _getPhysicalDeviceName18 = "()Ljava/lang/String;";
	protected static JMethodID _minit0;
	protected static JMethodID _mgetState0;
	protected static JMethodID _mclose1;
	protected static JMethodID _mopen2;
	protected static JMethodID _mrelease3;
	protected static JMethodID _mgetCheckHealthText4;
	protected static JMethodID _msetFreezeEvents5;
	protected static JMethodID _mcheckHealth6;
	protected static JMethodID _mdirectIO7;
	protected static JMethodID _mgetFreezeEvents8;
	protected static JMethodID _msetDeviceEnabled9;
	protected static JMethodID _mclaim10;
	protected static JMethodID _mgetDeviceEnabled11;
	protected static JMethodID _mgetClaimed12;
	protected static JMethodID _mgetPhysicalDeviceDescription13;
	protected static JMethodID _mgetDeviceControlDescription14;
	protected static JMethodID _mgetDeviceControlVersion15;
	protected static JMethodID _mgetDeviceServiceDescription16;
	protected static JMethodID _mgetDeviceServiceVersion17;
	protected static JMethodID _mgetPhysicalDeviceName18;

	static BaseJposControl()
	{
		Trace.TraceInformation("Initializing BaseJposControl");
		_class = JNI.FindClass("jpos/BaseJposControl");
		if (_class == null) throw new PosInvalidStateException();
		_minit0 = _class.GetMethodID("<init>", _init0);
		if (_minit0.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mgetState0 = _class.GetMethodID("getState", _getState0);
		if (_mgetState0.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mclose1 = _class.GetMethodID("close", _close1);
		if (_mclose1.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mopen2 = _class.GetMethodID("open", _open2);
		if (_mopen2.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mrelease3 = _class.GetMethodID("release", _release3);
		if (_mrelease3.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mgetCheckHealthText4 = _class.GetMethodID("getCheckHealthText", _getCheckHealthText4);
		if (_mgetCheckHealthText4.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_msetFreezeEvents5 = _class.GetMethodID("setFreezeEvents", _setFreezeEvents5);
		if (_msetFreezeEvents5.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mcheckHealth6 = _class.GetMethodID("checkHealth", _checkHealth6);
		if (_mcheckHealth6.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mdirectIO7 = _class.GetMethodID("directIO", _directIO7);
		if (_mdirectIO7.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mgetFreezeEvents8 = _class.GetMethodID("getFreezeEvents", _getFreezeEvents8);
		if (_mgetFreezeEvents8.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_msetDeviceEnabled9 = _class.GetMethodID("setDeviceEnabled", _setDeviceEnabled9);
		if (_msetDeviceEnabled9.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mclaim10 = _class.GetMethodID("claim", _claim10);
		if (_mclaim10.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mgetDeviceEnabled11 = _class.GetMethodID("getDeviceEnabled", _getDeviceEnabled11);
		if (_mgetDeviceEnabled11.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mgetClaimed12 = _class.GetMethodID("getClaimed", _getClaimed12);
		if (_mgetClaimed12.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mgetPhysicalDeviceDescription13 = _class.GetMethodID("getPhysicalDeviceDescription", _getPhysicalDeviceDescription13);
		if (_mgetPhysicalDeviceDescription13.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mgetDeviceControlDescription14 = _class.GetMethodID("getDeviceControlDescription", _getDeviceControlDescription14);
		if (_mgetDeviceControlDescription14.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mgetDeviceControlVersion15 = _class.GetMethodID("getDeviceControlVersion", _getDeviceControlVersion15);
		if (_mgetDeviceControlVersion15.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mgetDeviceServiceDescription16 = _class.GetMethodID("getDeviceServiceDescription", _getDeviceServiceDescription16);
		if (_mgetDeviceServiceDescription16.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mgetDeviceServiceVersion17 = _class.GetMethodID("getDeviceServiceVersion", _getDeviceServiceVersion17);
		if (_mgetDeviceServiceVersion17.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mgetPhysicalDeviceName18 = _class.GetMethodID("getPhysicalDeviceName", _getPhysicalDeviceName18);
		if (_mgetPhysicalDeviceName18.Handle == IntPtr.Zero) throw new PosInvalidStateException();		
	}

			[DebuggerNonUserCode]
	public static bool IsInstanceOf(JObject except)
	{
	  return JNI.IsInstanceOf(except, _class);
	}
	[DebuggerNonUserCode]
	private static Exception FromThrowable(JThrowable except)
	{
	  if (jpos.JposException.IsInstanceOf(except))
	  {
	    jpos.JposException d = new jpos.JposException(new JClone<JObject>() { Value = except });
	    d.printStackTrace();
	    int errorCode = d.getErrorCode();
	    int errorCodeExtended = d.getErrorCodeExtended();
	    return new PosControlException(except.ToString(), (ErrorCode)errorCode, errorCodeExtended);
	  }
	  else
	  {
	    except.printStackTrace();
	    return new JavaException(except.ToString());
	  }
	}

	[DebuggerNonUserCode]
	public BaseJposControl(JClone<JObject> obj) : base(obj) {} 

	public BaseJposControl() : base(initialize()) {}
	[DebuggerNonUserCode]
	protected static JClone<JObject> initialize() 
	{
	    JObject ret = JNI.NewObject<JObject>(_class, _minit0);
	    bool exception = JNI.ExceptionCheck();
	    if (ret.Handle == IntPtr.Zero) throw new PosInvalidStateException();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return new JClone<JObject>() { Value = ret } ;
	}



	[DebuggerNonUserCode]
	public int getState() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetState0);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void close() 
	{
	    JNI.CallVoidMethod(this, _mclose1);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void open(string p0) 
	{
	    JNI.CallVoidMethod(this, _mopen2, new JValue(JNI.NewString(p0)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void release() 
	{
	    JNI.CallVoidMethod(this, _mrelease3);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public string getCheckHealthText() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetCheckHealthText4);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret.GetString();
	}

	[DebuggerNonUserCode]
	public void setFreezeEvents(bool p0) 
	{
	    JNI.CallVoidMethod(this, _msetFreezeEvents5, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void checkHealth(int p0) 
	{
	    JNI.CallVoidMethod(this, _mcheckHealth6, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void directIO(int p0,JObject p1,JObject p2) 
	{
	    JNI.CallVoidMethod(this, _mdirectIO7, new JValue(p0),new JValue(p1),new JValue(p2));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public bool getFreezeEvents() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetFreezeEvents8);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void setDeviceEnabled(bool p0) 
	{
	    JNI.CallVoidMethod(this, _msetDeviceEnabled9, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void claim(int p0) 
	{
	    JNI.CallVoidMethod(this, _mclaim10, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public bool getDeviceEnabled() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetDeviceEnabled11);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getClaimed() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetClaimed12);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public string getPhysicalDeviceDescription() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetPhysicalDeviceDescription13);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret.GetString();
	}

	[DebuggerNonUserCode]
	public string getDeviceControlDescription() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetDeviceControlDescription14);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret.GetString();
	}

	[DebuggerNonUserCode]
	public int getDeviceControlVersion() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetDeviceControlVersion15);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public string getDeviceServiceDescription() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetDeviceServiceDescription16);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret.GetString();
	}

	[DebuggerNonUserCode]
	public int getDeviceServiceVersion() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetDeviceServiceVersion17);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public string getPhysicalDeviceName() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetPhysicalDeviceName18);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret.GetString();
	}

}
}

namespace jpos {
class Scanner : jpos.BaseJposControl {
	protected static JClass _class;
	protected static string _init0 = "()V";
	protected static string _addStatusUpdateListener0 = "(Ljpos/events/StatusUpdateListener;)V";
	protected static string _setDataEventEnabled1 = "(Z)V";
	protected static string _getCapPowerReporting2 = "()I";
	protected static string _getCapUpdateStatistics3 = "()Z";
	protected static string _getCapStatisticsReporting4 = "()Z";
	protected static string _getCapCompareFirmwareVersion5 = "()Z";
	protected static string _getCapUpdateFirmware6 = "()Z";
	protected static string _compareFirmwareVersion7 = "(Ljava/lang/String;[I)V";
	protected static string _clearInputProperties8 = "()V";
	protected static string _getDataEventEnabled9 = "()Z";
	protected static string _addDirectIOListener10 = "(Ljpos/events/DirectIOListener;)V";
	protected static string _removeDirectIOListener11 = "(Ljpos/events/DirectIOListener;)V";
	protected static string _addDataListener12 = "(Ljpos/events/DataListener;)V";
	protected static string _addErrorListener13 = "(Ljpos/events/ErrorListener;)V";
	protected static string _removeDataListener14 = "(Ljpos/events/DataListener;)V";
	protected static string _removeStatusUpdateListener15 = "(Ljpos/events/StatusUpdateListener;)V";
	protected static string _removeErrorListener16 = "(Ljpos/events/ErrorListener;)V";
	protected static string _updateFirmware17 = "(Ljava/lang/String;)V";
	protected static string _setPowerNotify18 = "(I)V";
	protected static string _getDecodeData19 = "()Z";
	protected static string _getDataCount20 = "()I";
	protected static string _getScanDataLabel21 = "()[B";
	protected static string _updateStatistics22 = "(Ljava/lang/String;)V";
	protected static string _getPowerNotify23 = "()I";
	protected static string _getPowerState24 = "()I";
	protected static string _clearInput25 = "()V";
	protected static string _getScanDataType26 = "()I";
	protected static string _setAutoDisable27 = "(Z)V";
	protected static string _setDecodeData28 = "(Z)V";
	protected static string _getScanData29 = "()[B";
	protected static string _resetStatistics30 = "(Ljava/lang/String;)V";
	protected static string _getAutoDisable31 = "()Z";
	protected static string _retrieveStatistics32 = "([Ljava/lang/String;)V";
	protected static JMethodID _minit0;
	protected static JMethodID _maddStatusUpdateListener0;
	protected static JMethodID _msetDataEventEnabled1;
	protected static JMethodID _mgetCapPowerReporting2;
	protected static JMethodID _mgetCapUpdateStatistics3;
	protected static JMethodID _mgetCapStatisticsReporting4;
	protected static JMethodID _mgetCapCompareFirmwareVersion5;
	protected static JMethodID _mgetCapUpdateFirmware6;
	protected static JMethodID _mcompareFirmwareVersion7;
	protected static JMethodID _mclearInputProperties8;
	protected static JMethodID _mgetDataEventEnabled9;
	protected static JMethodID _maddDirectIOListener10;
	protected static JMethodID _mremoveDirectIOListener11;
	protected static JMethodID _maddDataListener12;
	protected static JMethodID _maddErrorListener13;
	protected static JMethodID _mremoveDataListener14;
	protected static JMethodID _mremoveStatusUpdateListener15;
	protected static JMethodID _mremoveErrorListener16;
	protected static JMethodID _mupdateFirmware17;
	protected static JMethodID _msetPowerNotify18;
	protected static JMethodID _mgetDecodeData19;
	protected static JMethodID _mgetDataCount20;
	protected static JMethodID _mgetScanDataLabel21;
	protected static JMethodID _mupdateStatistics22;
	protected static JMethodID _mgetPowerNotify23;
	protected static JMethodID _mgetPowerState24;
	protected static JMethodID _mclearInput25;
	protected static JMethodID _mgetScanDataType26;
	protected static JMethodID _msetAutoDisable27;
	protected static JMethodID _msetDecodeData28;
	protected static JMethodID _mgetScanData29;
	protected static JMethodID _mresetStatistics30;
	protected static JMethodID _mgetAutoDisable31;
	protected static JMethodID _mretrieveStatistics32;


	static Scanner()
    {
		Trace.TraceInformation("Initializing scanner");
		_class = JNI.FindClass("jpos/Scanner");
		if(_class == null ) throw new PosInvalidStateException();
		_minit0 = _class.GetMethodID("<init>", _init0);
		if (_minit0.Handle == IntPtr.Zero ) throw new PosInvalidStateException();
		_maddStatusUpdateListener0 = _class.GetMethodID("addStatusUpdateListener", _addStatusUpdateListener0);
		if (_minit0.Handle == IntPtr.Zero ) throw new PosInvalidStateException();
		_msetDataEventEnabled1 = _class.GetMethodID("setDataEventEnabled", _setDataEventEnabled1);
		if (_msetDataEventEnabled1.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mgetCapPowerReporting2 = _class.GetMethodID("getCapPowerReporting", _getCapPowerReporting2);
		if (_mgetCapPowerReporting2.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mgetCapUpdateStatistics3 = _class.GetMethodID("getCapUpdateStatistics", _getCapUpdateStatistics3);
		if (_mgetCapUpdateStatistics3.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mgetCapStatisticsReporting4 = _class.GetMethodID("getCapStatisticsReporting", _getCapStatisticsReporting4);
		if (_mgetCapStatisticsReporting4.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mgetCapCompareFirmwareVersion5 = _class.GetMethodID("getCapCompareFirmwareVersion", _getCapCompareFirmwareVersion5);
		if (_mgetCapCompareFirmwareVersion5.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mgetCapUpdateFirmware6 = _class.GetMethodID("getCapUpdateFirmware", _getCapUpdateFirmware6);
		if (_mgetCapUpdateFirmware6.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mcompareFirmwareVersion7 = _class.GetMethodID("compareFirmwareVersion", _compareFirmwareVersion7);
		if (_mcompareFirmwareVersion7.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mclearInputProperties8 = _class.GetMethodID("clearInputProperties", _clearInputProperties8);
		if (_mclearInputProperties8.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mgetDataEventEnabled9 = _class.GetMethodID("getDataEventEnabled", _getDataEventEnabled9);
		if (_mgetDataEventEnabled9.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_maddDirectIOListener10 = _class.GetMethodID("addDirectIOListener", _addDirectIOListener10);
		if (_maddDirectIOListener10.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mremoveDirectIOListener11 = _class.GetMethodID("removeDirectIOListener", _removeDirectIOListener11);
		if (_mremoveDirectIOListener11.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_maddDataListener12 = _class.GetMethodID("addDataListener", _addDataListener12);
		if (_minit0.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_maddErrorListener13 = _class.GetMethodID("addErrorListener", _addErrorListener13);
		if (_maddErrorListener13.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mremoveDataListener14 = _class.GetMethodID("removeDataListener", _removeDataListener14);
		if (_mremoveDataListener14.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mremoveStatusUpdateListener15 = _class.GetMethodID("removeStatusUpdateListener", _removeStatusUpdateListener15);
		if (_mremoveStatusUpdateListener15.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mremoveErrorListener16 = _class.GetMethodID("removeErrorListener", _removeErrorListener16);
		if (_mremoveErrorListener16.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mupdateFirmware17 = _class.GetMethodID("updateFirmware", _updateFirmware17);
		if (_mupdateFirmware17.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_msetPowerNotify18 = _class.GetMethodID("setPowerNotify", _setPowerNotify18);
		if (_msetPowerNotify18.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mgetDecodeData19 = _class.GetMethodID("getDecodeData", _getDecodeData19);
		if (_mgetDecodeData19.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mgetDataCount20 = _class.GetMethodID("getDataCount", _getDataCount20);
		if (_mgetDataCount20.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mgetScanDataLabel21 = _class.GetMethodID("getScanDataLabel", _getScanDataLabel21);
		if (_mgetScanDataLabel21.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mupdateStatistics22 = _class.GetMethodID("updateStatistics", _updateStatistics22);
		if (_mupdateStatistics22.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mgetPowerNotify23 = _class.GetMethodID("getPowerNotify", _getPowerNotify23);
		if (_mgetPowerNotify23.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mgetPowerState24 = _class.GetMethodID("getPowerState", _getPowerState24);
		if (_mgetPowerState24.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mclearInput25 = _class.GetMethodID("clearInput", _clearInput25);
		if (_mclearInput25.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mgetScanDataType26 = _class.GetMethodID("getScanDataType", _getScanDataType26);
		if (_mgetScanDataType26.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_msetAutoDisable27 = _class.GetMethodID("setAutoDisable", _setAutoDisable27);
		if (_msetAutoDisable27.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_msetDecodeData28 = _class.GetMethodID("setDecodeData", _setDecodeData28);
		if (_msetDecodeData28.Handle == IntPtr.Zero) throw new PosInvalidStateException();				
		_mgetScanData29 = _class.GetMethodID("getScanData", _getScanData29);
		if (_mgetScanData29.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mresetStatistics30 = _class.GetMethodID("resetStatistics", _resetStatistics30);
		if (_mresetStatistics30.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mgetAutoDisable31 = _class.GetMethodID("getAutoDisable", _getAutoDisable31);
		if (_mgetAutoDisable31.Handle == IntPtr.Zero) throw new PosInvalidStateException();
		_mretrieveStatistics32 = _class.GetMethodID("retrieveStatistics", _retrieveStatistics32);
		if (_mretrieveStatistics32.Handle == IntPtr.Zero) throw new PosInvalidStateException();
	}

	[DebuggerNonUserCode]
	public static bool IsInstanceOf(JObject except)
	{
	  return JNI.IsInstanceOf(except, _class);
	}
	[DebuggerNonUserCode]
	private static Exception FromThrowable(JThrowable except)
	{
	  if (jpos.JposException.IsInstanceOf(except))
	  {
	    jpos.JposException d = new jpos.JposException(new JClone<JObject>() { Value = except });
	    d.printStackTrace();
	    int errorCode = d.getErrorCode();
	    int errorCodeExtended = d.getErrorCodeExtended();
	    return new PosControlException(except.ToString(), (ErrorCode)errorCode, errorCodeExtended);
	  }
	  else
	  {
	    except.printStackTrace();
	    return new JavaException(except.ToString());
	  }
	}

	[DebuggerNonUserCode]
	public Scanner(JClone<JObject> obj) : base(obj) {} 

	public Scanner() : base(initialize()) {}
	[DebuggerNonUserCode]
	protected static JClone<JObject> initialize() 
	{
		Trace.WriteLine(string.Format("initialize class", "initializing"));
		JObject ret = JNI.NewObject<JObject>(_class, _minit0);
	    bool exception = JNI.ExceptionCheck();

		Trace.WriteLine(string.Format("initialize class", "initializing"));
		if (ret.Handle == IntPtr.Zero) throw new PosInvalidStateException();
	    if (exception)
	    {
					Trace.WriteLine(string.Format("initialize class", "initializing"));
					JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

				Trace.WriteLine(string.Format("initialize class", "initializing"));
				return new JClone<JObject>() { Value = ret } ;
	}



	[DebuggerNonUserCode]
	public void addStatusUpdateListener(jpos.events.StatusUpdateListener p0) 
	{
	    JNI.CallVoidMethod(this, _maddStatusUpdateListener0, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void setDataEventEnabled(bool p0) 
	{
	    JNI.CallVoidMethod(this, _msetDataEventEnabled1, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getCapPowerReporting() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetCapPowerReporting2);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapUpdateStatistics() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapUpdateStatistics3);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapStatisticsReporting() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapStatisticsReporting4);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapCompareFirmwareVersion() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapCompareFirmwareVersion5);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapUpdateFirmware() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapUpdateFirmware6);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void compareFirmwareVersion(string p0,JObject p1) 
	{
	    JNI.CallVoidMethod(this, _mcompareFirmwareVersion7, new JValue(JNI.NewString(p0)),new JValue(p1));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void clearInputProperties() 
	{
	    JNI.CallVoidMethod(this, _mclearInputProperties8);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public bool getDataEventEnabled() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetDataEventEnabled9);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void addDirectIOListener(jpos.events.DirectIOListener p0) 
	{
	    JNI.CallVoidMethod(this, _maddDirectIOListener10, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void removeDirectIOListener(jpos.events.DirectIOListener p0) 
	{
	    JNI.CallVoidMethod(this, _mremoveDirectIOListener11, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void addDataListener(jpos.events.DataListener p0) 
	{
	    JNI.CallVoidMethod(this, _maddDataListener12, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void addErrorListener(JObject p0) 
	{
	    JNI.CallVoidMethod(this, _maddErrorListener13, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void removeDataListener(jpos.events.DataListener p0) 
	{
	    JNI.CallVoidMethod(this, _mremoveDataListener14, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void removeStatusUpdateListener(jpos.events.StatusUpdateListener p0) 
	{
	    JNI.CallVoidMethod(this, _mremoveStatusUpdateListener15, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void removeErrorListener(JObject p0) 
	{
	    JNI.CallVoidMethod(this, _mremoveErrorListener16, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void updateFirmware(string p0) 
	{
	    JNI.CallVoidMethod(this, _mupdateFirmware17, new JValue(JNI.NewString(p0)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void setPowerNotify(int p0) 
	{
	    JNI.CallVoidMethod(this, _msetPowerNotify18, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public bool getDecodeData() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetDecodeData19);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public int getDataCount() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetDataCount20);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public byte[] getScanDataLabel() 
	{
	    JArray<sbyte> ret = JNI.CallObjectMethod<JArray<sbyte>>(this, _mgetScanDataLabel21);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return Array.ConvertAll(ret.GetElements(), (a) => (byte)a);
	}

	[DebuggerNonUserCode]
	public void updateStatistics(string p0) 
	{
	    JNI.CallVoidMethod(this, _mupdateStatistics22, new JValue(JNI.NewString(p0)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getPowerNotify() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetPowerNotify23);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public int getPowerState() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetPowerState24);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void clearInput() 
	{
	    JNI.CallVoidMethod(this, _mclearInput25);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getScanDataType() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetScanDataType26);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void setAutoDisable(bool p0) 
	{
	    JNI.CallVoidMethod(this, _msetAutoDisable27, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void setDecodeData(bool p0) 
	{
	    JNI.CallVoidMethod(this, _msetDecodeData28, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public byte[] getScanData() 
	{
	    JArray<sbyte> ret = JNI.CallObjectMethod<JArray<sbyte>>(this, _mgetScanData29);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return Array.ConvertAll(ret.GetElements(), (a) => (byte)a);
	}

	[DebuggerNonUserCode]
	public void resetStatistics(string p0) 
	{
	    JNI.CallVoidMethod(this, _mresetStatistics30, new JValue(JNI.NewString(p0)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public bool getAutoDisable() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetAutoDisable31);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void retrieveStatistics(JObject p0) 
	{
	    JNI.CallVoidMethod(this, _mretrieveStatistics32, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

}
}

namespace jpos {
class CashDrawer : jpos.BaseJposControl {
	protected static JClass _class = JNI.FindClass("jpos/CashDrawer");
	protected static string _init0 = "()V";
	protected static string _addStatusUpdateListener0 = "(Ljpos/events/StatusUpdateListener;)V";
	protected static string _getCapPowerReporting1 = "()I";
	protected static string _getCapUpdateStatistics2 = "()Z";
	protected static string _getCapStatisticsReporting3 = "()Z";
	protected static string _getCapCompareFirmwareVersion4 = "()Z";
	protected static string _getCapUpdateFirmware5 = "()Z";
	protected static string _compareFirmwareVersion6 = "(Ljava/lang/String;[I)V";
	protected static string _addDirectIOListener7 = "(Ljpos/events/DirectIOListener;)V";
	protected static string _removeDirectIOListener8 = "(Ljpos/events/DirectIOListener;)V";
	protected static string _removeStatusUpdateListener9 = "(Ljpos/events/StatusUpdateListener;)V";
	protected static string _updateFirmware10 = "(Ljava/lang/String;)V";
	protected static string _setPowerNotify11 = "(I)V";
	protected static string _updateStatistics12 = "(Ljava/lang/String;)V";
	protected static string _getPowerNotify13 = "()I";
	protected static string _getPowerState14 = "()I";
	protected static string _resetStatistics15 = "(Ljava/lang/String;)V";
	protected static string _retrieveStatistics16 = "([Ljava/lang/String;)V";
	protected static string _getCapStatusMultiDrawerDetect17 = "()Z";
	protected static string _openDrawer18 = "()V";
	protected static string _getDrawerOpened19 = "()Z";
	protected static string _waitForDrawerClose20 = "(IIII)V";
	protected static string _getCapStatus21 = "()Z";
	protected static JMethodID _minit0 = _class.GetMethodID("<init>", _init0);
	protected static JMethodID _maddStatusUpdateListener0 = _class.GetMethodID("addStatusUpdateListener", _addStatusUpdateListener0);
	protected static JMethodID _mgetCapPowerReporting1 = _class.GetMethodID("getCapPowerReporting", _getCapPowerReporting1);
	protected static JMethodID _mgetCapUpdateStatistics2 = _class.GetMethodID("getCapUpdateStatistics", _getCapUpdateStatistics2);
	protected static JMethodID _mgetCapStatisticsReporting3 = _class.GetMethodID("getCapStatisticsReporting", _getCapStatisticsReporting3);
	protected static JMethodID _mgetCapCompareFirmwareVersion4 = _class.GetMethodID("getCapCompareFirmwareVersion", _getCapCompareFirmwareVersion4);
	protected static JMethodID _mgetCapUpdateFirmware5 = _class.GetMethodID("getCapUpdateFirmware", _getCapUpdateFirmware5);
	protected static JMethodID _mcompareFirmwareVersion6 = _class.GetMethodID("compareFirmwareVersion", _compareFirmwareVersion6);
	protected static JMethodID _maddDirectIOListener7 = _class.GetMethodID("addDirectIOListener", _addDirectIOListener7);
	protected static JMethodID _mremoveDirectIOListener8 = _class.GetMethodID("removeDirectIOListener", _removeDirectIOListener8);
	protected static JMethodID _mremoveStatusUpdateListener9 = _class.GetMethodID("removeStatusUpdateListener", _removeStatusUpdateListener9);
	protected static JMethodID _mupdateFirmware10 = _class.GetMethodID("updateFirmware", _updateFirmware10);
	protected static JMethodID _msetPowerNotify11 = _class.GetMethodID("setPowerNotify", _setPowerNotify11);
	protected static JMethodID _mupdateStatistics12 = _class.GetMethodID("updateStatistics", _updateStatistics12);
	protected static JMethodID _mgetPowerNotify13 = _class.GetMethodID("getPowerNotify", _getPowerNotify13);
	protected static JMethodID _mgetPowerState14 = _class.GetMethodID("getPowerState", _getPowerState14);
	protected static JMethodID _mresetStatistics15 = _class.GetMethodID("resetStatistics", _resetStatistics15);
	protected static JMethodID _mretrieveStatistics16 = _class.GetMethodID("retrieveStatistics", _retrieveStatistics16);
	protected static JMethodID _mgetCapStatusMultiDrawerDetect17 = _class.GetMethodID("getCapStatusMultiDrawerDetect", _getCapStatusMultiDrawerDetect17);
	protected static JMethodID _mopenDrawer18 = _class.GetMethodID("openDrawer", _openDrawer18);
	protected static JMethodID _mgetDrawerOpened19 = _class.GetMethodID("getDrawerOpened", _getDrawerOpened19);
	protected static JMethodID _mwaitForDrawerClose20 = _class.GetMethodID("waitForDrawerClose", _waitForDrawerClose20);
	protected static JMethodID _mgetCapStatus21 = _class.GetMethodID("getCapStatus", _getCapStatus21);

	[DebuggerNonUserCode]
	public static bool IsInstanceOf(JObject except)
	{
	  return JNI.IsInstanceOf(except, _class);
	}
	[DebuggerNonUserCode]
	private static Exception FromThrowable(JThrowable except)
	{
	  if (jpos.JposException.IsInstanceOf(except))
	  {
	    jpos.JposException d = new jpos.JposException(new JClone<JObject>() { Value = except });
	    d.printStackTrace();
	    int errorCode = d.getErrorCode();
	    int errorCodeExtended = d.getErrorCodeExtended();
	    return new PosControlException(except.ToString(), (ErrorCode)errorCode, errorCodeExtended);
	  }
	  else
	  {
	    except.printStackTrace();
	    return new JavaException(except.ToString());
	  }
	}

	[DebuggerNonUserCode]
	public CashDrawer(JClone<JObject> obj) : base(obj) {} 

	public CashDrawer() : base(initialize()) {}
	[DebuggerNonUserCode]
	protected static JClone<JObject> initialize() 
	{
	    JObject ret = JNI.NewObject<JObject>(_class, _minit0);
	    bool exception = JNI.ExceptionCheck();
	    if (ret.Handle == IntPtr.Zero) throw new PosInvalidStateException();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return new JClone<JObject>() { Value = ret } ;
	}



	[DebuggerNonUserCode]
	public void addStatusUpdateListener(jpos.events.StatusUpdateListener p0) 
	{
	    JNI.CallVoidMethod(this, _maddStatusUpdateListener0, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getCapPowerReporting() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetCapPowerReporting1);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapUpdateStatistics() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapUpdateStatistics2);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapStatisticsReporting() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapStatisticsReporting3);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapCompareFirmwareVersion() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapCompareFirmwareVersion4);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapUpdateFirmware() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapUpdateFirmware5);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void compareFirmwareVersion(string p0,JObject p1) 
	{
	    JNI.CallVoidMethod(this, _mcompareFirmwareVersion6, new JValue(JNI.NewString(p0)),new JValue(p1));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void addDirectIOListener(jpos.events.DirectIOListener p0) 
	{
	    JNI.CallVoidMethod(this, _maddDirectIOListener7, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void removeDirectIOListener(jpos.events.DirectIOListener p0) 
	{
	    JNI.CallVoidMethod(this, _mremoveDirectIOListener8, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void removeStatusUpdateListener(jpos.events.StatusUpdateListener p0) 
	{
	    JNI.CallVoidMethod(this, _mremoveStatusUpdateListener9, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void updateFirmware(string p0) 
	{
	    JNI.CallVoidMethod(this, _mupdateFirmware10, new JValue(JNI.NewString(p0)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void setPowerNotify(int p0) 
	{
	    JNI.CallVoidMethod(this, _msetPowerNotify11, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void updateStatistics(string p0) 
	{
	    JNI.CallVoidMethod(this, _mupdateStatistics12, new JValue(JNI.NewString(p0)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getPowerNotify() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetPowerNotify13);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public int getPowerState() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetPowerState14);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void resetStatistics(string p0) 
	{
	    JNI.CallVoidMethod(this, _mresetStatistics15, new JValue(JNI.NewString(p0)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void retrieveStatistics(JObject p0) 
	{
	    JNI.CallVoidMethod(this, _mretrieveStatistics16, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public bool getCapStatusMultiDrawerDetect() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapStatusMultiDrawerDetect17);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void openDrawer() 
	{
	    JNI.CallVoidMethod(this, _mopenDrawer18);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public bool getDrawerOpened() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetDrawerOpened19);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void waitForDrawerClose(int p0,int p1,int p2,int p3) 
	{
	    JNI.CallVoidMethod(this, _mwaitForDrawerClose20, new JValue(p0),new JValue(p1),new JValue(p2),new JValue(p3));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public bool getCapStatus() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapStatus21);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

}
}

namespace jpos {
class CoinDispenser : jpos.BaseJposControl {
	protected static JClass _class = JNI.FindClass("jpos/CoinDispenser");
	protected static string _init0 = "()V";
	protected static string _addStatusUpdateListener0 = "(Ljpos/events/StatusUpdateListener;)V";
	protected static string _getCapPowerReporting1 = "()I";
	protected static string _getCapUpdateStatistics2 = "()Z";
	protected static string _getCapStatisticsReporting3 = "()Z";
	protected static string _getCapCompareFirmwareVersion4 = "()Z";
	protected static string _getCapUpdateFirmware5 = "()Z";
	protected static string _compareFirmwareVersion6 = "(Ljava/lang/String;[I)V";
	protected static string _addDirectIOListener7 = "(Ljpos/events/DirectIOListener;)V";
	protected static string _removeDirectIOListener8 = "(Ljpos/events/DirectIOListener;)V";
	protected static string _readCashCounts9 = "([Ljava/lang/String;[Z)V";
	protected static string _dispenseChange10 = "(I)V";
	protected static string _getCapEmptySensor11 = "()Z";
	protected static string _getDispenserStatus12 = "()I";
	protected static string _getCapJamSensor13 = "()Z";
	protected static string _adjustCashCounts14 = "(Ljava/lang/String;)V";
	protected static string _removeStatusUpdateListener15 = "(Ljpos/events/StatusUpdateListener;)V";
	protected static string _updateFirmware16 = "(Ljava/lang/String;)V";
	protected static string _setPowerNotify17 = "(I)V";
	protected static string _updateStatistics18 = "(Ljava/lang/String;)V";
	protected static string _getPowerNotify19 = "()I";
	protected static string _getPowerState20 = "()I";
	protected static string _resetStatistics21 = "(Ljava/lang/String;)V";
	protected static string _retrieveStatistics22 = "([Ljava/lang/String;)V";
	protected static string _getCapNearEmptySensor23 = "()Z";
	protected static JMethodID _minit0 = _class.GetMethodID("<init>", _init0);
	protected static JMethodID _maddStatusUpdateListener0 = _class.GetMethodID("addStatusUpdateListener", _addStatusUpdateListener0);
	protected static JMethodID _mgetCapPowerReporting1 = _class.GetMethodID("getCapPowerReporting", _getCapPowerReporting1);
	protected static JMethodID _mgetCapUpdateStatistics2 = _class.GetMethodID("getCapUpdateStatistics", _getCapUpdateStatistics2);
	protected static JMethodID _mgetCapStatisticsReporting3 = _class.GetMethodID("getCapStatisticsReporting", _getCapStatisticsReporting3);
	protected static JMethodID _mgetCapCompareFirmwareVersion4 = _class.GetMethodID("getCapCompareFirmwareVersion", _getCapCompareFirmwareVersion4);
	protected static JMethodID _mgetCapUpdateFirmware5 = _class.GetMethodID("getCapUpdateFirmware", _getCapUpdateFirmware5);
	protected static JMethodID _mcompareFirmwareVersion6 = _class.GetMethodID("compareFirmwareVersion", _compareFirmwareVersion6);
	protected static JMethodID _maddDirectIOListener7 = _class.GetMethodID("addDirectIOListener", _addDirectIOListener7);
	protected static JMethodID _mremoveDirectIOListener8 = _class.GetMethodID("removeDirectIOListener", _removeDirectIOListener8);
	protected static JMethodID _mreadCashCounts9 = _class.GetMethodID("readCashCounts", _readCashCounts9);
	protected static JMethodID _mdispenseChange10 = _class.GetMethodID("dispenseChange", _dispenseChange10);
	protected static JMethodID _mgetCapEmptySensor11 = _class.GetMethodID("getCapEmptySensor", _getCapEmptySensor11);
	protected static JMethodID _mgetDispenserStatus12 = _class.GetMethodID("getDispenserStatus", _getDispenserStatus12);
	protected static JMethodID _mgetCapJamSensor13 = _class.GetMethodID("getCapJamSensor", _getCapJamSensor13);
	protected static JMethodID _madjustCashCounts14 = _class.GetMethodID("adjustCashCounts", _adjustCashCounts14);
	protected static JMethodID _mremoveStatusUpdateListener15 = _class.GetMethodID("removeStatusUpdateListener", _removeStatusUpdateListener15);
	protected static JMethodID _mupdateFirmware16 = _class.GetMethodID("updateFirmware", _updateFirmware16);
	protected static JMethodID _msetPowerNotify17 = _class.GetMethodID("setPowerNotify", _setPowerNotify17);
	protected static JMethodID _mupdateStatistics18 = _class.GetMethodID("updateStatistics", _updateStatistics18);
	protected static JMethodID _mgetPowerNotify19 = _class.GetMethodID("getPowerNotify", _getPowerNotify19);
	protected static JMethodID _mgetPowerState20 = _class.GetMethodID("getPowerState", _getPowerState20);
	protected static JMethodID _mresetStatistics21 = _class.GetMethodID("resetStatistics", _resetStatistics21);
	protected static JMethodID _mretrieveStatistics22 = _class.GetMethodID("retrieveStatistics", _retrieveStatistics22);
	protected static JMethodID _mgetCapNearEmptySensor23 = _class.GetMethodID("getCapNearEmptySensor", _getCapNearEmptySensor23);

	[DebuggerNonUserCode]
	public static bool IsInstanceOf(JObject except)
	{
	  return JNI.IsInstanceOf(except, _class);
	}
	[DebuggerNonUserCode]
	private static Exception FromThrowable(JThrowable except)
	{
	  if (jpos.JposException.IsInstanceOf(except))
	  {
	    jpos.JposException d = new jpos.JposException(new JClone<JObject>() { Value = except });
	    d.printStackTrace();
	    int errorCode = d.getErrorCode();
	    int errorCodeExtended = d.getErrorCodeExtended();
	    return new PosControlException(except.ToString(), (ErrorCode)errorCode, errorCodeExtended);
	  }
	  else
	  {
	    except.printStackTrace();
	    return new JavaException(except.ToString());
	  }
	}

	[DebuggerNonUserCode]
	public CoinDispenser(JClone<JObject> obj) : base(obj) {} 

	public CoinDispenser() : base(initialize()) {}
	[DebuggerNonUserCode]
	protected static JClone<JObject> initialize() 
	{
	    JObject ret = JNI.NewObject<JObject>(_class, _minit0);
	    bool exception = JNI.ExceptionCheck();
	    if (ret.Handle == IntPtr.Zero) throw new PosInvalidStateException();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return new JClone<JObject>() { Value = ret } ;
	}



	[DebuggerNonUserCode]
	public void addStatusUpdateListener(jpos.events.StatusUpdateListener p0) 
	{
	    JNI.CallVoidMethod(this, _maddStatusUpdateListener0, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getCapPowerReporting() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetCapPowerReporting1);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapUpdateStatistics() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapUpdateStatistics2);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapStatisticsReporting() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapStatisticsReporting3);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapCompareFirmwareVersion() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapCompareFirmwareVersion4);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapUpdateFirmware() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapUpdateFirmware5);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void compareFirmwareVersion(string p0,JObject p1) 
	{
	    JNI.CallVoidMethod(this, _mcompareFirmwareVersion6, new JValue(JNI.NewString(p0)),new JValue(p1));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void addDirectIOListener(jpos.events.DirectIOListener p0) 
	{
	    JNI.CallVoidMethod(this, _maddDirectIOListener7, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void removeDirectIOListener(jpos.events.DirectIOListener p0) 
	{
	    JNI.CallVoidMethod(this, _mremoveDirectIOListener8, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void readCashCounts(JObject p0,JObject p1) 
	{
	    JNI.CallVoidMethod(this, _mreadCashCounts9, new JValue(p0),new JValue(p1));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void dispenseChange(int p0) 
	{
	    JNI.CallVoidMethod(this, _mdispenseChange10, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public bool getCapEmptySensor() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapEmptySensor11);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public int getDispenserStatus() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetDispenserStatus12);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapJamSensor() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapJamSensor13);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void adjustCashCounts(string p0) 
	{
	    JNI.CallVoidMethod(this, _madjustCashCounts14, new JValue(JNI.NewString(p0)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void removeStatusUpdateListener(jpos.events.StatusUpdateListener p0) 
	{
	    JNI.CallVoidMethod(this, _mremoveStatusUpdateListener15, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void updateFirmware(string p0) 
	{
	    JNI.CallVoidMethod(this, _mupdateFirmware16, new JValue(JNI.NewString(p0)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void setPowerNotify(int p0) 
	{
	    JNI.CallVoidMethod(this, _msetPowerNotify17, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void updateStatistics(string p0) 
	{
	    JNI.CallVoidMethod(this, _mupdateStatistics18, new JValue(JNI.NewString(p0)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getPowerNotify() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetPowerNotify19);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public int getPowerState() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetPowerState20);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void resetStatistics(string p0) 
	{
	    JNI.CallVoidMethod(this, _mresetStatistics21, new JValue(JNI.NewString(p0)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void retrieveStatistics(JObject p0) 
	{
	    JNI.CallVoidMethod(this, _mretrieveStatistics22, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public bool getCapNearEmptySensor() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapNearEmptySensor23);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

}
}

namespace jpos {
class PINPad : jpos.BaseJposControl {
	protected static JClass _class = JNI.FindClass("jpos/PINPad");
	protected static string _init0 = "()V";
	protected static string _setMerchantID0 = "(Ljava/lang/String;)V";
	protected static string _setAccountNumber1 = "(Ljava/lang/String;)V";
	protected static string _getPINEntryEnabled2 = "()Z";
	protected static string _getAmount3 = "()J";
	protected static string _setAmount4 = "(J)V";
	protected static string _getCapLanguage5 = "()I";
	protected static string _getCapKeyboard6 = "()Z";
	protected static string _getAccountNumber7 = "()Ljava/lang/String;";
	protected static string _getCapTone8 = "()Z";
	protected static string _getCapDisplay9 = "()I";
	protected static string _getEncryptedPIN10 = "()Ljava/lang/String;";
	protected static string _getMerchantID11 = "()Ljava/lang/String;";
	protected static string _getTransactionType12 = "()I";
	protected static string _enablePINEntry13 = "()V";
	protected static string _getTrack4Data14 = "()[B";
	protected static string _getTrack3Data15 = "()[B";
	protected static string _setTerminalID16 = "(Ljava/lang/String;)V";
	protected static string _getTrack1Data17 = "()[B";
	protected static string _setTrack1Data18 = "([B)V";
	protected static string _setTrack2Data19 = "([B)V";
	protected static string _setPrompt20 = "(I)V";
	protected static string _getPrompt21 = "()I";
	protected static string _setTrack4Data22 = "([B)V";
	protected static string _getTrack2Data23 = "()[B";
	protected static string _getPromptLanguage24 = "()Ljava/lang/String;";
	protected static string _computeMAC25 = "(Ljava/lang/String;[Ljava/lang/String;)V";
	protected static string _updateKey26 = "(ILjava/lang/String;)V";
	protected static string _endEFTTransaction27 = "(I)V";
	protected static string _setTrack3Data28 = "([B)V";
	protected static string _setTransactionType29 = "(I)V";
	protected static string _verifyMAC30 = "(Ljava/lang/String;)V";
	protected static string _setPromptLanguage31 = "(Ljava/lang/String;)V";
	protected static string _getTerminalID32 = "()Ljava/lang/String;";
	protected static string _addStatusUpdateListener33 = "(Ljpos/events/StatusUpdateListener;)V";
	protected static string _setDataEventEnabled34 = "(Z)V";
	protected static string _getCapPowerReporting35 = "()I";
	protected static string _getCapUpdateStatistics36 = "()Z";
	protected static string _getCapStatisticsReporting37 = "()Z";
	protected static string _getCapCompareFirmwareVersion38 = "()Z";
	protected static string _getCapUpdateFirmware39 = "()Z";
	protected static string _compareFirmwareVersion40 = "(Ljava/lang/String;[I)V";
	protected static string _clearInputProperties41 = "()V";
	protected static string _getDataEventEnabled42 = "()Z";
	protected static string _addDirectIOListener43 = "(Ljpos/events/DirectIOListener;)V";
	protected static string _removeDirectIOListener44 = "(Ljpos/events/DirectIOListener;)V";
	protected static string _addDataListener45 = "(Ljpos/events/DataListener;)V";
	protected static string _addErrorListener46 = "(Ljpos/events/ErrorListener;)V";
	protected static string _removeDataListener47 = "(Ljpos/events/DataListener;)V";
	protected static string _removeStatusUpdateListener48 = "(Ljpos/events/StatusUpdateListener;)V";
	protected static string _removeErrorListener49 = "(Ljpos/events/ErrorListener;)V";
	protected static string _updateFirmware50 = "(Ljava/lang/String;)V";
	protected static string _setPowerNotify51 = "(I)V";
	protected static string _getDataCount52 = "()I";
	protected static string _updateStatistics53 = "(Ljava/lang/String;)V";
	protected static string _getPowerNotify54 = "()I";
	protected static string _getPowerState55 = "()I";
	protected static string _clearInput56 = "()V";
	protected static string _resetStatistics57 = "(Ljava/lang/String;)V";
	protected static string _retrieveStatistics58 = "([Ljava/lang/String;)V";
	protected static string _beginEFTTransaction59 = "(Ljava/lang/String;I)V";
	protected static string _getMaximumPINLength60 = "()I";
	protected static string _getAvailableLanguagesList61 = "()Ljava/lang/String;";
	protected static string _getMinimumPINLength62 = "()I";
	protected static string _setMinimumPINLength63 = "(I)V";
	protected static string _getAvailablePromptsList64 = "()Ljava/lang/String;";
	protected static string _getCapMACCalculation65 = "()Z";
	protected static string _getAdditionalSecurityInformation66 = "()Ljava/lang/String;";
	protected static string _setMaximumPINLength67 = "(I)V";
	protected static JMethodID _minit0 = _class.GetMethodID("<init>", _init0);
	protected static JMethodID _msetMerchantID0 = _class.GetMethodID("setMerchantID", _setMerchantID0);
	protected static JMethodID _msetAccountNumber1 = _class.GetMethodID("setAccountNumber", _setAccountNumber1);
	protected static JMethodID _mgetPINEntryEnabled2 = _class.GetMethodID("getPINEntryEnabled", _getPINEntryEnabled2);
	protected static JMethodID _mgetAmount3 = _class.GetMethodID("getAmount", _getAmount3);
	protected static JMethodID _msetAmount4 = _class.GetMethodID("setAmount", _setAmount4);
	protected static JMethodID _mgetCapLanguage5 = _class.GetMethodID("getCapLanguage", _getCapLanguage5);
	protected static JMethodID _mgetCapKeyboard6 = _class.GetMethodID("getCapKeyboard", _getCapKeyboard6);
	protected static JMethodID _mgetAccountNumber7 = _class.GetMethodID("getAccountNumber", _getAccountNumber7);
	protected static JMethodID _mgetCapTone8 = _class.GetMethodID("getCapTone", _getCapTone8);
	protected static JMethodID _mgetCapDisplay9 = _class.GetMethodID("getCapDisplay", _getCapDisplay9);
	protected static JMethodID _mgetEncryptedPIN10 = _class.GetMethodID("getEncryptedPIN", _getEncryptedPIN10);
	protected static JMethodID _mgetMerchantID11 = _class.GetMethodID("getMerchantID", _getMerchantID11);
	protected static JMethodID _mgetTransactionType12 = _class.GetMethodID("getTransactionType", _getTransactionType12);
	protected static JMethodID _menablePINEntry13 = _class.GetMethodID("enablePINEntry", _enablePINEntry13);
	protected static JMethodID _mgetTrack4Data14 = _class.GetMethodID("getTrack4Data", _getTrack4Data14);
	protected static JMethodID _mgetTrack3Data15 = _class.GetMethodID("getTrack3Data", _getTrack3Data15);
	protected static JMethodID _msetTerminalID16 = _class.GetMethodID("setTerminalID", _setTerminalID16);
	protected static JMethodID _mgetTrack1Data17 = _class.GetMethodID("getTrack1Data", _getTrack1Data17);
	protected static JMethodID _msetTrack1Data18 = _class.GetMethodID("setTrack1Data", _setTrack1Data18);
	protected static JMethodID _msetTrack2Data19 = _class.GetMethodID("setTrack2Data", _setTrack2Data19);
	protected static JMethodID _msetPrompt20 = _class.GetMethodID("setPrompt", _setPrompt20);
	protected static JMethodID _mgetPrompt21 = _class.GetMethodID("getPrompt", _getPrompt21);
	protected static JMethodID _msetTrack4Data22 = _class.GetMethodID("setTrack4Data", _setTrack4Data22);
	protected static JMethodID _mgetTrack2Data23 = _class.GetMethodID("getTrack2Data", _getTrack2Data23);
	protected static JMethodID _mgetPromptLanguage24 = _class.GetMethodID("getPromptLanguage", _getPromptLanguage24);
	protected static JMethodID _mcomputeMAC25 = _class.GetMethodID("computeMAC", _computeMAC25);
	protected static JMethodID _mupdateKey26 = _class.GetMethodID("updateKey", _updateKey26);
	protected static JMethodID _mendEFTTransaction27 = _class.GetMethodID("endEFTTransaction", _endEFTTransaction27);
	protected static JMethodID _msetTrack3Data28 = _class.GetMethodID("setTrack3Data", _setTrack3Data28);
	protected static JMethodID _msetTransactionType29 = _class.GetMethodID("setTransactionType", _setTransactionType29);
	protected static JMethodID _mverifyMAC30 = _class.GetMethodID("verifyMAC", _verifyMAC30);
	protected static JMethodID _msetPromptLanguage31 = _class.GetMethodID("setPromptLanguage", _setPromptLanguage31);
	protected static JMethodID _mgetTerminalID32 = _class.GetMethodID("getTerminalID", _getTerminalID32);
	protected static JMethodID _maddStatusUpdateListener33 = _class.GetMethodID("addStatusUpdateListener", _addStatusUpdateListener33);
	protected static JMethodID _msetDataEventEnabled34 = _class.GetMethodID("setDataEventEnabled", _setDataEventEnabled34);
	protected static JMethodID _mgetCapPowerReporting35 = _class.GetMethodID("getCapPowerReporting", _getCapPowerReporting35);
	protected static JMethodID _mgetCapUpdateStatistics36 = _class.GetMethodID("getCapUpdateStatistics", _getCapUpdateStatistics36);
	protected static JMethodID _mgetCapStatisticsReporting37 = _class.GetMethodID("getCapStatisticsReporting", _getCapStatisticsReporting37);
	protected static JMethodID _mgetCapCompareFirmwareVersion38 = _class.GetMethodID("getCapCompareFirmwareVersion", _getCapCompareFirmwareVersion38);
	protected static JMethodID _mgetCapUpdateFirmware39 = _class.GetMethodID("getCapUpdateFirmware", _getCapUpdateFirmware39);
	protected static JMethodID _mcompareFirmwareVersion40 = _class.GetMethodID("compareFirmwareVersion", _compareFirmwareVersion40);
	protected static JMethodID _mclearInputProperties41 = _class.GetMethodID("clearInputProperties", _clearInputProperties41);
	protected static JMethodID _mgetDataEventEnabled42 = _class.GetMethodID("getDataEventEnabled", _getDataEventEnabled42);
	protected static JMethodID _maddDirectIOListener43 = _class.GetMethodID("addDirectIOListener", _addDirectIOListener43);
	protected static JMethodID _mremoveDirectIOListener44 = _class.GetMethodID("removeDirectIOListener", _removeDirectIOListener44);
	protected static JMethodID _maddDataListener45 = _class.GetMethodID("addDataListener", _addDataListener45);
	protected static JMethodID _maddErrorListener46 = _class.GetMethodID("addErrorListener", _addErrorListener46);
	protected static JMethodID _mremoveDataListener47 = _class.GetMethodID("removeDataListener", _removeDataListener47);
	protected static JMethodID _mremoveStatusUpdateListener48 = _class.GetMethodID("removeStatusUpdateListener", _removeStatusUpdateListener48);
	protected static JMethodID _mremoveErrorListener49 = _class.GetMethodID("removeErrorListener", _removeErrorListener49);
	protected static JMethodID _mupdateFirmware50 = _class.GetMethodID("updateFirmware", _updateFirmware50);
	protected static JMethodID _msetPowerNotify51 = _class.GetMethodID("setPowerNotify", _setPowerNotify51);
	protected static JMethodID _mgetDataCount52 = _class.GetMethodID("getDataCount", _getDataCount52);
	protected static JMethodID _mupdateStatistics53 = _class.GetMethodID("updateStatistics", _updateStatistics53);
	protected static JMethodID _mgetPowerNotify54 = _class.GetMethodID("getPowerNotify", _getPowerNotify54);
	protected static JMethodID _mgetPowerState55 = _class.GetMethodID("getPowerState", _getPowerState55);
	protected static JMethodID _mclearInput56 = _class.GetMethodID("clearInput", _clearInput56);
	protected static JMethodID _mresetStatistics57 = _class.GetMethodID("resetStatistics", _resetStatistics57);
	protected static JMethodID _mretrieveStatistics58 = _class.GetMethodID("retrieveStatistics", _retrieveStatistics58);
	protected static JMethodID _mbeginEFTTransaction59 = _class.GetMethodID("beginEFTTransaction", _beginEFTTransaction59);
	protected static JMethodID _mgetMaximumPINLength60 = _class.GetMethodID("getMaximumPINLength", _getMaximumPINLength60);
	protected static JMethodID _mgetAvailableLanguagesList61 = _class.GetMethodID("getAvailableLanguagesList", _getAvailableLanguagesList61);
	protected static JMethodID _mgetMinimumPINLength62 = _class.GetMethodID("getMinimumPINLength", _getMinimumPINLength62);
	protected static JMethodID _msetMinimumPINLength63 = _class.GetMethodID("setMinimumPINLength", _setMinimumPINLength63);
	protected static JMethodID _mgetAvailablePromptsList64 = _class.GetMethodID("getAvailablePromptsList", _getAvailablePromptsList64);
	protected static JMethodID _mgetCapMACCalculation65 = _class.GetMethodID("getCapMACCalculation", _getCapMACCalculation65);
	protected static JMethodID _mgetAdditionalSecurityInformation66 = _class.GetMethodID("getAdditionalSecurityInformation", _getAdditionalSecurityInformation66);
	protected static JMethodID _msetMaximumPINLength67 = _class.GetMethodID("setMaximumPINLength", _setMaximumPINLength67);

	[DebuggerNonUserCode]
	public static bool IsInstanceOf(JObject except)
	{
	  return JNI.IsInstanceOf(except, _class);
	}
	[DebuggerNonUserCode]
	private static Exception FromThrowable(JThrowable except)
	{
	  if (jpos.JposException.IsInstanceOf(except))
	  {
	    jpos.JposException d = new jpos.JposException(new JClone<JObject>() { Value = except });
	    d.printStackTrace();
	    int errorCode = d.getErrorCode();
	    int errorCodeExtended = d.getErrorCodeExtended();
	    return new PosControlException(except.ToString(), (ErrorCode)errorCode, errorCodeExtended);
	  }
	  else
	  {
	    except.printStackTrace();
	    return new JavaException(except.ToString());
	  }
	}

	[DebuggerNonUserCode]
	public PINPad(JClone<JObject> obj) : base(obj) {} 

	public PINPad() : base(initialize()) {}
	[DebuggerNonUserCode]
	protected static JClone<JObject> initialize() 
	{
	    JObject ret = JNI.NewObject<JObject>(_class, _minit0);
	    bool exception = JNI.ExceptionCheck();
	    if (ret.Handle == IntPtr.Zero) throw new PosInvalidStateException();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return new JClone<JObject>() { Value = ret } ;
	}



	[DebuggerNonUserCode]
	public void setMerchantID(string p0) 
	{
	    JNI.CallVoidMethod(this, _msetMerchantID0, new JValue(JNI.NewString(p0)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void setAccountNumber(string p0) 
	{
	    JNI.CallVoidMethod(this, _msetAccountNumber1, new JValue(JNI.NewString(p0)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public bool getPINEntryEnabled() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetPINEntryEnabled2);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public long getAmount() 
	{
	    long ret = JNI.CallMethod<long>(this, _mgetAmount3);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void setAmount(long p0) 
	{
	    JNI.CallVoidMethod(this, _msetAmount4, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getCapLanguage() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetCapLanguage5);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapKeyboard() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapKeyboard6);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public string getAccountNumber() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetAccountNumber7);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret.GetString();
	}

	[DebuggerNonUserCode]
	public bool getCapTone() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapTone8);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public int getCapDisplay() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetCapDisplay9);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public string getEncryptedPIN() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetEncryptedPIN10);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret.GetString();
	}

	[DebuggerNonUserCode]
	public string getMerchantID() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetMerchantID11);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret.GetString();
	}

	[DebuggerNonUserCode]
	public int getTransactionType() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetTransactionType12);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void enablePINEntry() 
	{
	    JNI.CallVoidMethod(this, _menablePINEntry13);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public byte[] getTrack4Data() 
	{
	    JArray<sbyte> ret = JNI.CallObjectMethod<JArray<sbyte>>(this, _mgetTrack4Data14);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return Array.ConvertAll(ret.GetElements(), (a) => (byte)a);
	}

	[DebuggerNonUserCode]
	public byte[] getTrack3Data() 
	{
	    JArray<sbyte> ret = JNI.CallObjectMethod<JArray<sbyte>>(this, _mgetTrack3Data15);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return Array.ConvertAll(ret.GetElements(), (a) => (byte)a);
	}

	[DebuggerNonUserCode]
	public void setTerminalID(string p0) 
	{
	    JNI.CallVoidMethod(this, _msetTerminalID16, new JValue(JNI.NewString(p0)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public byte[] getTrack1Data() 
	{
	    JArray<sbyte> ret = JNI.CallObjectMethod<JArray<sbyte>>(this, _mgetTrack1Data17);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return Array.ConvertAll(ret.GetElements(), (a) => (byte)a);
	}

	[DebuggerNonUserCode]
	public void setTrack1Data(byte[] p0) 
	{
	    JNI.CallVoidMethod(this, _msetTrack1Data18, new JValue(JNI.NewArray<sbyte>(p0.Length)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void setTrack2Data(byte[] p0) 
	{
	    JNI.CallVoidMethod(this, _msetTrack2Data19, new JValue(JNI.NewArray<sbyte>(p0.Length)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void setPrompt(int p0) 
	{
	    JNI.CallVoidMethod(this, _msetPrompt20, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getPrompt() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetPrompt21);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void setTrack4Data(byte[] p0) 
	{
	    JNI.CallVoidMethod(this, _msetTrack4Data22, new JValue(JNI.NewArray<sbyte>(p0.Length)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public byte[] getTrack2Data() 
	{
	    JArray<sbyte> ret = JNI.CallObjectMethod<JArray<sbyte>>(this, _mgetTrack2Data23);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return Array.ConvertAll(ret.GetElements(), (a) => (byte)a);
	}

	[DebuggerNonUserCode]
	public string getPromptLanguage() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetPromptLanguage24);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret.GetString();
	}

	[DebuggerNonUserCode]
	public void computeMAC(string p0,JObject p1) 
	{
	    JNI.CallVoidMethod(this, _mcomputeMAC25, new JValue(JNI.NewString(p0)),new JValue(p1));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void updateKey(int p0,string p1) 
	{
	    JNI.CallVoidMethod(this, _mupdateKey26, new JValue(p0),new JValue(JNI.NewString(p1)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void endEFTTransaction(int p0) 
	{
	    JNI.CallVoidMethod(this, _mendEFTTransaction27, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void setTrack3Data(byte[] p0) 
	{
	    JNI.CallVoidMethod(this, _msetTrack3Data28, new JValue(JNI.NewArray<sbyte>(p0.Length)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void setTransactionType(int p0) 
	{
	    JNI.CallVoidMethod(this, _msetTransactionType29, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void verifyMAC(string p0) 
	{
	    JNI.CallVoidMethod(this, _mverifyMAC30, new JValue(JNI.NewString(p0)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void setPromptLanguage(string p0) 
	{
	    JNI.CallVoidMethod(this, _msetPromptLanguage31, new JValue(JNI.NewString(p0)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public string getTerminalID() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetTerminalID32);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret.GetString();
	}

	[DebuggerNonUserCode]
	public void addStatusUpdateListener(jpos.events.StatusUpdateListener p0) 
	{
	    JNI.CallVoidMethod(this, _maddStatusUpdateListener33, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void setDataEventEnabled(bool p0) 
	{
	    JNI.CallVoidMethod(this, _msetDataEventEnabled34, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getCapPowerReporting() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetCapPowerReporting35);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapUpdateStatistics() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapUpdateStatistics36);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapStatisticsReporting() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapStatisticsReporting37);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapCompareFirmwareVersion() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapCompareFirmwareVersion38);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapUpdateFirmware() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapUpdateFirmware39);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void compareFirmwareVersion(string p0,JObject p1) 
	{
	    JNI.CallVoidMethod(this, _mcompareFirmwareVersion40, new JValue(JNI.NewString(p0)),new JValue(p1));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void clearInputProperties() 
	{
	    JNI.CallVoidMethod(this, _mclearInputProperties41);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public bool getDataEventEnabled() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetDataEventEnabled42);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void addDirectIOListener(jpos.events.DirectIOListener p0) 
	{
	    JNI.CallVoidMethod(this, _maddDirectIOListener43, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void removeDirectIOListener(jpos.events.DirectIOListener p0) 
	{
	    JNI.CallVoidMethod(this, _mremoveDirectIOListener44, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void addDataListener(jpos.events.DataListener p0) 
	{
	    JNI.CallVoidMethod(this, _maddDataListener45, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void addErrorListener(JObject p0) 
	{
	    JNI.CallVoidMethod(this, _maddErrorListener46, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void removeDataListener(jpos.events.DataListener p0) 
	{
	    JNI.CallVoidMethod(this, _mremoveDataListener47, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void removeStatusUpdateListener(jpos.events.StatusUpdateListener p0) 
	{
	    JNI.CallVoidMethod(this, _mremoveStatusUpdateListener48, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void removeErrorListener(JObject p0) 
	{
	    JNI.CallVoidMethod(this, _mremoveErrorListener49, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void updateFirmware(string p0) 
	{
	    JNI.CallVoidMethod(this, _mupdateFirmware50, new JValue(JNI.NewString(p0)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void setPowerNotify(int p0) 
	{
	    JNI.CallVoidMethod(this, _msetPowerNotify51, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getDataCount() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetDataCount52);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void updateStatistics(string p0) 
	{
	    JNI.CallVoidMethod(this, _mupdateStatistics53, new JValue(JNI.NewString(p0)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getPowerNotify() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetPowerNotify54);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public int getPowerState() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetPowerState55);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void clearInput() 
	{
	    JNI.CallVoidMethod(this, _mclearInput56);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void resetStatistics(string p0) 
	{
	    JNI.CallVoidMethod(this, _mresetStatistics57, new JValue(JNI.NewString(p0)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void retrieveStatistics(JObject p0) 
	{
	    JNI.CallVoidMethod(this, _mretrieveStatistics58, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void beginEFTTransaction(string p0,int p1) 
	{
	    JNI.CallVoidMethod(this, _mbeginEFTTransaction59, new JValue(JNI.NewString(p0)),new JValue(p1));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getMaximumPINLength() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetMaximumPINLength60);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public string getAvailableLanguagesList() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetAvailableLanguagesList61);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret.GetString();
	}

	[DebuggerNonUserCode]
	public int getMinimumPINLength() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetMinimumPINLength62);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void setMinimumPINLength(int p0) 
	{
	    JNI.CallVoidMethod(this, _msetMinimumPINLength63, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public string getAvailablePromptsList() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetAvailablePromptsList64);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret.GetString();
	}

	[DebuggerNonUserCode]
	public bool getCapMACCalculation() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapMACCalculation65);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public string getAdditionalSecurityInformation() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetAdditionalSecurityInformation66);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret.GetString();
	}

	[DebuggerNonUserCode]
	public void setMaximumPINLength(int p0) 
	{
	    JNI.CallVoidMethod(this, _msetMaximumPINLength67, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

}
}

namespace jpos {
class POSPrinter : jpos.BaseJposControl {
	protected static JClass _class = JNI.FindClass("jpos/POSPrinter");
	protected static string _init0 = "()V";
	protected static string _getAsyncMode0 = "()Z";
	protected static string _getCapJrn2Color1 = "()Z";
	protected static string _getCapJrnBold2 = "()Z";
	protected static string _getCapJrnDhigh3 = "()Z";
	protected static string _getCapJrnDwide4 = "()Z";
	protected static string _getCapCharacterSet5 = "()I";
	protected static string _getCapCoverSensor6 = "()Z";
	protected static string _addStatusUpdateListener7 = "(Ljpos/events/StatusUpdateListener;)V";
	protected static string _getCapPowerReporting8 = "()I";
	protected static string _getCapUpdateStatistics9 = "()Z";
	protected static string _getCapStatisticsReporting10 = "()Z";
	protected static string _getCapCompareFirmwareVersion11 = "()Z";
	protected static string _getCapUpdateFirmware12 = "()Z";
	protected static string _compareFirmwareVersion13 = "(Ljava/lang/String;[I)V";
	protected static string _addDirectIOListener14 = "(Ljpos/events/DirectIOListener;)V";
	protected static string _removeDirectIOListener15 = "(Ljpos/events/DirectIOListener;)V";
	protected static string _getOutputID16 = "()I";
	protected static string _addErrorListener17 = "(Ljpos/events/ErrorListener;)V";
	protected static string _removeStatusUpdateListener18 = "(Ljpos/events/StatusUpdateListener;)V";
	protected static string _removeErrorListener19 = "(Ljpos/events/ErrorListener;)V";
	protected static string _updateFirmware20 = "(Ljava/lang/String;)V";
	protected static string _setPowerNotify21 = "(I)V";
	protected static string _updateStatistics22 = "(Ljava/lang/String;)V";
	protected static string _getPowerNotify23 = "()I";
	protected static string _getPowerState24 = "()I";
	protected static string _resetStatistics25 = "(Ljava/lang/String;)V";
	protected static string _retrieveStatistics26 = "([Ljava/lang/String;)V";
	protected static string _getCapSlp2Color27 = "()Z";
	protected static string _getCapRecRight9028 = "()Z";
	protected static string _getCapJrnUnderline29 = "()Z";
	protected static string _getCapSlpBitmap30 = "()Z";
	protected static string _getCapRecStamp31 = "()Z";
	protected static string _getCapRecPapercut32 = "()Z";
	protected static string _getCapJrnItalic33 = "()Z";
	protected static string _getCapSlpPresent34 = "()Z";
	protected static string _getCapSlpRight9035 = "()Z";
	protected static string _getCapSlpRotate18036 = "()Z";
	protected static string _getCapRecItalic37 = "()Z";
	protected static string _getCapRecUnderline38 = "()Z";
	protected static string _getCapRecBarCode39 = "()Z";
	protected static string _getCapRecBitmap40 = "()Z";
	protected static string _getCapRecLeft9041 = "()Z";
	protected static string _getCapRecBold42 = "()Z";
	protected static string _getCapRec2Color43 = "()Z";
	protected static string _getCapSlpBarCode44 = "()Z";
	protected static string _getCapSlpDhigh45 = "()Z";
	protected static string _getCapSlpBold46 = "()Z";
	protected static string _getCapSlpFullslip47 = "()Z";
	protected static string _getCapSlpItalic48 = "()Z";
	protected static string _getCapRecPresent49 = "()Z";
	protected static string _getCapRecRotate18050 = "()Z";
	protected static string _getCapJrnPresent51 = "()Z";
	protected static string _getCapSlpLeft9052 = "()Z";
	protected static string _getCapSlpDwide53 = "()Z";
	protected static string _getCapRecDhigh54 = "()Z";
	protected static string _getCapRecDwide55 = "()Z";
	protected static string _getCapTransaction56 = "()Z";
	protected static string _getCapRecColor57 = "()I";
	protected static string _setAsyncMode58 = "(Z)V";
	protected static string _getErrorString59 = "()Ljava/lang/String;";
	protected static string _getCapSlpUnderline60 = "()Z";
	protected static string _getCapRecPageMode61 = "()Z";
	protected static string _setFlagWhenIdle62 = "(Z)V";
	protected static string _getErrorLevel63 = "()I";
	protected static string _setJrnLineHeight64 = "(I)V";
	protected static string _getJrnLineChars65 = "()I";
	protected static string _getCapSlpColor66 = "()I";
	protected static string _getCapSlpPageMode67 = "()Z";
	protected static string _setCharacterSet68 = "(I)V";
	protected static string _getJrnLineSpacing69 = "()I";
	protected static string _setJrnLineSpacing70 = "(I)V";
	protected static string _getFlagWhenIdle71 = "()Z";
	protected static string _getCapRecMarkFeed72 = "()I";
	protected static string _getCoverOpen73 = "()Z";
	protected static string _getCapSlpRuledLine74 = "()I";
	protected static string _getCapJrnColor75 = "()I";
	protected static string _getErrorStation76 = "()I";
	protected static string _getJrnLineHeight77 = "()I";
	protected static string _getJrnEmpty78 = "()Z";
	protected static string _setJrnLineChars79 = "(I)V";
	protected static string _getCapRecRuledLine80 = "()I";
	protected static string _getCharacterSet81 = "()I";
	protected static string _setSlpLineHeight82 = "(I)V";
	protected static string _getSlpLineSpacing83 = "()I";
	protected static string _setSlpLineSpacing84 = "(I)V";
	protected static string _getSlpLineWidth85 = "()I";
	protected static string _getSlpMaxLines86 = "()I";
	protected static string _getSlpEmpty87 = "()Z";
	protected static string _getRecNearEnd88 = "()Z";
	protected static string _setRecLineHeight89 = "(I)V";
	protected static string _getSlpNearEnd90 = "()Z";
	protected static string _getSlpLineChars91 = "()I";
	protected static string _getMapMode92 = "()I";
	protected static string _setRotateSpecial93 = "(I)V";
	protected static string _setMapMode94 = "(I)V";
	protected static string _getJrnNearEnd95 = "()Z";
	protected static string _getRecLineHeight96 = "()I";
	protected static string _setRecLineChars97 = "(I)V";
	protected static string _setRecLineSpacing98 = "(I)V";
	protected static string _getJrnLineWidth99 = "()I";
	protected static string _getRecLineWidth100 = "()I";
	protected static string _getRotateSpecial101 = "()I";
	protected static string _getRecEmpty102 = "()Z";
	protected static string _getRecLineChars103 = "()I";
	protected static string _getRecLineSpacing104 = "()I";
	protected static string _setSlpLineChars105 = "(I)V";
	protected static string _getSlpLineHeight106 = "()I";
	protected static string _rotatePrint107 = "(II)V";
	protected static string _getCartridgeNotify108 = "()I";
	protected static string _setCartridgeNotify109 = "(I)V";
	protected static string _beginRemoval110 = "(I)V";
	protected static string _endRemoval111 = "()V";
	protected static string _setBitmap112 = "(IILjava/lang/String;II)V";
	protected static string _getPageModeArea113 = "()Ljava/lang/String;";
	protected static string _getPageModeStation114 = "()I";
	protected static string _endInsertion115 = "()V";
	protected static string _getSlpPrintSide116 = "()I";
	protected static string _getMapCharacterSet117 = "()Z";
	protected static string _setPageModeStation118 = "(I)V";
	protected static string _clearOutput119 = "()V";
	protected static string _printBarCode120 = "(ILjava/lang/String;IIIII)V";
	protected static string _printBitmap121 = "(ILjava/lang/String;II)V";
	protected static string _printImmediate122 = "(ILjava/lang/String;)V";
	protected static string _printNormal123 = "(ILjava/lang/String;)V";
	protected static string _setMapCharacterSet124 = "(Z)V";
	protected static string _beginInsertion125 = "(I)V";
	protected static string _cutPaper126 = "(I)V";
	protected static string _printTwoNormal127 = "(ILjava/lang/String;Ljava/lang/String;)V";
	protected static string _setLogo128 = "(ILjava/lang/String;)V";
	protected static string _printMemoryBitmap129 = "(I[BIII)V";
	protected static string _transactionPrint130 = "(II)V";
	protected static string _drawRuledLine131 = "(ILjava/lang/String;IIII)V";
	protected static string _pageModePrint132 = "(I)V";
	protected static string _markFeed133 = "(I)V";
	protected static string _validateData134 = "(ILjava/lang/String;)V";
	protected static string _clearPrintArea135 = "()V";
	protected static string _changePrintSide136 = "(I)V";
	protected static string _setPageModeHorizontalPosition137 = "(I)V";
	protected static string _getPageModeHorizontalPosition138 = "()I";
	protected static string _getRecBitmapRotationList139 = "()Ljava/lang/String;";
	protected static string _setPageModePrintDirection140 = "(I)V";
	protected static string _setPageModeVerticalPosition141 = "(I)V";
	protected static string _setPageModePrintArea142 = "(Ljava/lang/String;)V";
	protected static string _getPageModePrintArea143 = "()Ljava/lang/String;";
	protected static string _getPageModeVerticalPosition144 = "()I";
	protected static string _getSlpBitmapRotationList145 = "()Ljava/lang/String;";
	protected static string _setSlpCurrentCartridge146 = "(I)V";
	protected static string _getPageModeDescriptor147 = "()I";
	protected static string _addOutputCompleteListener148 = "(Ljpos/events/OutputCompleteListener;)V";
	protected static string _removeOutputCompleteListener149 = "(Ljpos/events/OutputCompleteListener;)V";
	protected static string _getPageModePrintDirection150 = "()I";
	protected static string _getCapConcurrentJrnRec151 = "()Z";
	protected static string _getCapConcurrentJrnSlp152 = "()Z";
	protected static string _getCapConcurrentRecSlp153 = "()Z";
	protected static string _getCapJrnDwideDhigh154 = "()Z";
	protected static string _getCapJrnEmptySensor155 = "()Z";
	protected static string _getCapRecCartridgeSensor156 = "()I";
	protected static string _getJrnLineCharsList157 = "()Ljava/lang/String;";
	protected static string _getRecCurrentCartridge158 = "()I";
	protected static string _setJrnLetterQuality159 = "(Z)V";
	protected static string _getRecCartridgeState160 = "()I";
	protected static string _getCapSlpNearEndSensor161 = "()Z";
	protected static string _getRecLinesToPaperCut162 = "()I";
	protected static string _setRecCurrentCartridge163 = "(I)V";
	protected static string _getSlpCartridgeState164 = "()I";
	protected static string _getSlpLetterQuality165 = "()Z";
	protected static string _getJrnCurrentCartridge166 = "()I";
	protected static string _getCapRecDwideDhigh167 = "()Z";
	protected static string _getSlpCurrentCartridge168 = "()I";
	protected static string _getJrnCartridgeState169 = "()I";
	protected static string _getCapRecEmptySensor170 = "()Z";
	protected static string _getCapRecNearEndSensor171 = "()Z";
	protected static string _getCapSlpCartridgeSensor172 = "()I";
	protected static string _getCapConcurrentPageMode173 = "()Z";
	protected static string _getRecLineCharsList174 = "()Ljava/lang/String;";
	protected static string _setJrnCurrentCartridge175 = "(I)V";
	protected static string _getRecSidewaysMaxChars176 = "()I";
	protected static string _getCapJrnNearEndSensor177 = "()Z";
	protected static string _getCapSlpDwideDhigh178 = "()Z";
	protected static string _getCapSlpEmptySensor179 = "()Z";
	protected static string _getCapMapCharacterSet180 = "()Z";
	protected static string _getFontTypefaceList181 = "()Ljava/lang/String;";
	protected static string _getJrnLetterQuality182 = "()Z";
	protected static string _getCapJrnCartridgeSensor183 = "()I";
	protected static string _getCharacterSetList184 = "()Ljava/lang/String;";
	protected static string _getRecBarCodeRotationList185 = "()Ljava/lang/String;";
	protected static string _getRecLetterQuality186 = "()Z";
	protected static string _setSlpLetterQuality187 = "(Z)V";
	protected static string _getSlpLineCharsList188 = "()Ljava/lang/String;";
	protected static string _getCapSlpBothSidesPrint189 = "()Z";
	protected static string _getSlpLinesNearEndToEnd190 = "()I";
	protected static string _getSlpSidewaysMaxChars191 = "()I";
	protected static string _setRecLetterQuality192 = "(Z)V";
	protected static string _getRecSidewaysMaxLines193 = "()I";
	protected static string _getSlpBarCodeRotationList194 = "()Ljava/lang/String;";
	protected static string _getSlpSidewaysMaxLines195 = "()I";
	protected static JMethodID _minit0 = _class.GetMethodID("<init>", _init0);
	protected static JMethodID _mgetAsyncMode0 = _class.GetMethodID("getAsyncMode", _getAsyncMode0);
	protected static JMethodID _mgetCapJrn2Color1 = _class.GetMethodID("getCapJrn2Color", _getCapJrn2Color1);
	protected static JMethodID _mgetCapJrnBold2 = _class.GetMethodID("getCapJrnBold", _getCapJrnBold2);
	protected static JMethodID _mgetCapJrnDhigh3 = _class.GetMethodID("getCapJrnDhigh", _getCapJrnDhigh3);
	protected static JMethodID _mgetCapJrnDwide4 = _class.GetMethodID("getCapJrnDwide", _getCapJrnDwide4);
	protected static JMethodID _mgetCapCharacterSet5 = _class.GetMethodID("getCapCharacterSet", _getCapCharacterSet5);
	protected static JMethodID _mgetCapCoverSensor6 = _class.GetMethodID("getCapCoverSensor", _getCapCoverSensor6);
	protected static JMethodID _maddStatusUpdateListener7 = _class.GetMethodID("addStatusUpdateListener", _addStatusUpdateListener7);
	protected static JMethodID _mgetCapPowerReporting8 = _class.GetMethodID("getCapPowerReporting", _getCapPowerReporting8);
	protected static JMethodID _mgetCapUpdateStatistics9 = _class.GetMethodID("getCapUpdateStatistics", _getCapUpdateStatistics9);
	protected static JMethodID _mgetCapStatisticsReporting10 = _class.GetMethodID("getCapStatisticsReporting", _getCapStatisticsReporting10);
	protected static JMethodID _mgetCapCompareFirmwareVersion11 = _class.GetMethodID("getCapCompareFirmwareVersion", _getCapCompareFirmwareVersion11);
	protected static JMethodID _mgetCapUpdateFirmware12 = _class.GetMethodID("getCapUpdateFirmware", _getCapUpdateFirmware12);
	protected static JMethodID _mcompareFirmwareVersion13 = _class.GetMethodID("compareFirmwareVersion", _compareFirmwareVersion13);
	protected static JMethodID _maddDirectIOListener14 = _class.GetMethodID("addDirectIOListener", _addDirectIOListener14);
	protected static JMethodID _mremoveDirectIOListener15 = _class.GetMethodID("removeDirectIOListener", _removeDirectIOListener15);
	protected static JMethodID _mgetOutputID16 = _class.GetMethodID("getOutputID", _getOutputID16);
	protected static JMethodID _maddErrorListener17 = _class.GetMethodID("addErrorListener", _addErrorListener17);
	protected static JMethodID _mremoveStatusUpdateListener18 = _class.GetMethodID("removeStatusUpdateListener", _removeStatusUpdateListener18);
	protected static JMethodID _mremoveErrorListener19 = _class.GetMethodID("removeErrorListener", _removeErrorListener19);
	protected static JMethodID _mupdateFirmware20 = _class.GetMethodID("updateFirmware", _updateFirmware20);
	protected static JMethodID _msetPowerNotify21 = _class.GetMethodID("setPowerNotify", _setPowerNotify21);
	protected static JMethodID _mupdateStatistics22 = _class.GetMethodID("updateStatistics", _updateStatistics22);
	protected static JMethodID _mgetPowerNotify23 = _class.GetMethodID("getPowerNotify", _getPowerNotify23);
	protected static JMethodID _mgetPowerState24 = _class.GetMethodID("getPowerState", _getPowerState24);
	protected static JMethodID _mresetStatistics25 = _class.GetMethodID("resetStatistics", _resetStatistics25);
	protected static JMethodID _mretrieveStatistics26 = _class.GetMethodID("retrieveStatistics", _retrieveStatistics26);
	protected static JMethodID _mgetCapSlp2Color27 = _class.GetMethodID("getCapSlp2Color", _getCapSlp2Color27);
	protected static JMethodID _mgetCapRecRight9028 = _class.GetMethodID("getCapRecRight90", _getCapRecRight9028);
	protected static JMethodID _mgetCapJrnUnderline29 = _class.GetMethodID("getCapJrnUnderline", _getCapJrnUnderline29);
	protected static JMethodID _mgetCapSlpBitmap30 = _class.GetMethodID("getCapSlpBitmap", _getCapSlpBitmap30);
	protected static JMethodID _mgetCapRecStamp31 = _class.GetMethodID("getCapRecStamp", _getCapRecStamp31);
	protected static JMethodID _mgetCapRecPapercut32 = _class.GetMethodID("getCapRecPapercut", _getCapRecPapercut32);
	protected static JMethodID _mgetCapJrnItalic33 = _class.GetMethodID("getCapJrnItalic", _getCapJrnItalic33);
	protected static JMethodID _mgetCapSlpPresent34 = _class.GetMethodID("getCapSlpPresent", _getCapSlpPresent34);
	protected static JMethodID _mgetCapSlpRight9035 = _class.GetMethodID("getCapSlpRight90", _getCapSlpRight9035);
	protected static JMethodID _mgetCapSlpRotate18036 = _class.GetMethodID("getCapSlpRotate180", _getCapSlpRotate18036);
	protected static JMethodID _mgetCapRecItalic37 = _class.GetMethodID("getCapRecItalic", _getCapRecItalic37);
	protected static JMethodID _mgetCapRecUnderline38 = _class.GetMethodID("getCapRecUnderline", _getCapRecUnderline38);
	protected static JMethodID _mgetCapRecBarCode39 = _class.GetMethodID("getCapRecBarCode", _getCapRecBarCode39);
	protected static JMethodID _mgetCapRecBitmap40 = _class.GetMethodID("getCapRecBitmap", _getCapRecBitmap40);
	protected static JMethodID _mgetCapRecLeft9041 = _class.GetMethodID("getCapRecLeft90", _getCapRecLeft9041);
	protected static JMethodID _mgetCapRecBold42 = _class.GetMethodID("getCapRecBold", _getCapRecBold42);
	protected static JMethodID _mgetCapRec2Color43 = _class.GetMethodID("getCapRec2Color", _getCapRec2Color43);
	protected static JMethodID _mgetCapSlpBarCode44 = _class.GetMethodID("getCapSlpBarCode", _getCapSlpBarCode44);
	protected static JMethodID _mgetCapSlpDhigh45 = _class.GetMethodID("getCapSlpDhigh", _getCapSlpDhigh45);
	protected static JMethodID _mgetCapSlpBold46 = _class.GetMethodID("getCapSlpBold", _getCapSlpBold46);
	protected static JMethodID _mgetCapSlpFullslip47 = _class.GetMethodID("getCapSlpFullslip", _getCapSlpFullslip47);
	protected static JMethodID _mgetCapSlpItalic48 = _class.GetMethodID("getCapSlpItalic", _getCapSlpItalic48);
	protected static JMethodID _mgetCapRecPresent49 = _class.GetMethodID("getCapRecPresent", _getCapRecPresent49);
	protected static JMethodID _mgetCapRecRotate18050 = _class.GetMethodID("getCapRecRotate180", _getCapRecRotate18050);
	protected static JMethodID _mgetCapJrnPresent51 = _class.GetMethodID("getCapJrnPresent", _getCapJrnPresent51);
	protected static JMethodID _mgetCapSlpLeft9052 = _class.GetMethodID("getCapSlpLeft90", _getCapSlpLeft9052);
	protected static JMethodID _mgetCapSlpDwide53 = _class.GetMethodID("getCapSlpDwide", _getCapSlpDwide53);
	protected static JMethodID _mgetCapRecDhigh54 = _class.GetMethodID("getCapRecDhigh", _getCapRecDhigh54);
	protected static JMethodID _mgetCapRecDwide55 = _class.GetMethodID("getCapRecDwide", _getCapRecDwide55);
	protected static JMethodID _mgetCapTransaction56 = _class.GetMethodID("getCapTransaction", _getCapTransaction56);
	protected static JMethodID _mgetCapRecColor57 = _class.GetMethodID("getCapRecColor", _getCapRecColor57);
	protected static JMethodID _msetAsyncMode58 = _class.GetMethodID("setAsyncMode", _setAsyncMode58);
	protected static JMethodID _mgetErrorString59 = _class.GetMethodID("getErrorString", _getErrorString59);
	protected static JMethodID _mgetCapSlpUnderline60 = _class.GetMethodID("getCapSlpUnderline", _getCapSlpUnderline60);
	protected static JMethodID _mgetCapRecPageMode61 = _class.GetMethodID("getCapRecPageMode", _getCapRecPageMode61);
	protected static JMethodID _msetFlagWhenIdle62 = _class.GetMethodID("setFlagWhenIdle", _setFlagWhenIdle62);
	protected static JMethodID _mgetErrorLevel63 = _class.GetMethodID("getErrorLevel", _getErrorLevel63);
	protected static JMethodID _msetJrnLineHeight64 = _class.GetMethodID("setJrnLineHeight", _setJrnLineHeight64);
	protected static JMethodID _mgetJrnLineChars65 = _class.GetMethodID("getJrnLineChars", _getJrnLineChars65);
	protected static JMethodID _mgetCapSlpColor66 = _class.GetMethodID("getCapSlpColor", _getCapSlpColor66);
	protected static JMethodID _mgetCapSlpPageMode67 = _class.GetMethodID("getCapSlpPageMode", _getCapSlpPageMode67);
	protected static JMethodID _msetCharacterSet68 = _class.GetMethodID("setCharacterSet", _setCharacterSet68);
	protected static JMethodID _mgetJrnLineSpacing69 = _class.GetMethodID("getJrnLineSpacing", _getJrnLineSpacing69);
	protected static JMethodID _msetJrnLineSpacing70 = _class.GetMethodID("setJrnLineSpacing", _setJrnLineSpacing70);
	protected static JMethodID _mgetFlagWhenIdle71 = _class.GetMethodID("getFlagWhenIdle", _getFlagWhenIdle71);
	protected static JMethodID _mgetCapRecMarkFeed72 = _class.GetMethodID("getCapRecMarkFeed", _getCapRecMarkFeed72);
	protected static JMethodID _mgetCoverOpen73 = _class.GetMethodID("getCoverOpen", _getCoverOpen73);
	protected static JMethodID _mgetCapSlpRuledLine74 = _class.GetMethodID("getCapSlpRuledLine", _getCapSlpRuledLine74);
	protected static JMethodID _mgetCapJrnColor75 = _class.GetMethodID("getCapJrnColor", _getCapJrnColor75);
	protected static JMethodID _mgetErrorStation76 = _class.GetMethodID("getErrorStation", _getErrorStation76);
	protected static JMethodID _mgetJrnLineHeight77 = _class.GetMethodID("getJrnLineHeight", _getJrnLineHeight77);
	protected static JMethodID _mgetJrnEmpty78 = _class.GetMethodID("getJrnEmpty", _getJrnEmpty78);
	protected static JMethodID _msetJrnLineChars79 = _class.GetMethodID("setJrnLineChars", _setJrnLineChars79);
	protected static JMethodID _mgetCapRecRuledLine80 = _class.GetMethodID("getCapRecRuledLine", _getCapRecRuledLine80);
	protected static JMethodID _mgetCharacterSet81 = _class.GetMethodID("getCharacterSet", _getCharacterSet81);
	protected static JMethodID _msetSlpLineHeight82 = _class.GetMethodID("setSlpLineHeight", _setSlpLineHeight82);
	protected static JMethodID _mgetSlpLineSpacing83 = _class.GetMethodID("getSlpLineSpacing", _getSlpLineSpacing83);
	protected static JMethodID _msetSlpLineSpacing84 = _class.GetMethodID("setSlpLineSpacing", _setSlpLineSpacing84);
	protected static JMethodID _mgetSlpLineWidth85 = _class.GetMethodID("getSlpLineWidth", _getSlpLineWidth85);
	protected static JMethodID _mgetSlpMaxLines86 = _class.GetMethodID("getSlpMaxLines", _getSlpMaxLines86);
	protected static JMethodID _mgetSlpEmpty87 = _class.GetMethodID("getSlpEmpty", _getSlpEmpty87);
	protected static JMethodID _mgetRecNearEnd88 = _class.GetMethodID("getRecNearEnd", _getRecNearEnd88);
	protected static JMethodID _msetRecLineHeight89 = _class.GetMethodID("setRecLineHeight", _setRecLineHeight89);
	protected static JMethodID _mgetSlpNearEnd90 = _class.GetMethodID("getSlpNearEnd", _getSlpNearEnd90);
	protected static JMethodID _mgetSlpLineChars91 = _class.GetMethodID("getSlpLineChars", _getSlpLineChars91);
	protected static JMethodID _mgetMapMode92 = _class.GetMethodID("getMapMode", _getMapMode92);
	protected static JMethodID _msetRotateSpecial93 = _class.GetMethodID("setRotateSpecial", _setRotateSpecial93);
	protected static JMethodID _msetMapMode94 = _class.GetMethodID("setMapMode", _setMapMode94);
	protected static JMethodID _mgetJrnNearEnd95 = _class.GetMethodID("getJrnNearEnd", _getJrnNearEnd95);
	protected static JMethodID _mgetRecLineHeight96 = _class.GetMethodID("getRecLineHeight", _getRecLineHeight96);
	protected static JMethodID _msetRecLineChars97 = _class.GetMethodID("setRecLineChars", _setRecLineChars97);
	protected static JMethodID _msetRecLineSpacing98 = _class.GetMethodID("setRecLineSpacing", _setRecLineSpacing98);
	protected static JMethodID _mgetJrnLineWidth99 = _class.GetMethodID("getJrnLineWidth", _getJrnLineWidth99);
	protected static JMethodID _mgetRecLineWidth100 = _class.GetMethodID("getRecLineWidth", _getRecLineWidth100);
	protected static JMethodID _mgetRotateSpecial101 = _class.GetMethodID("getRotateSpecial", _getRotateSpecial101);
	protected static JMethodID _mgetRecEmpty102 = _class.GetMethodID("getRecEmpty", _getRecEmpty102);
	protected static JMethodID _mgetRecLineChars103 = _class.GetMethodID("getRecLineChars", _getRecLineChars103);
	protected static JMethodID _mgetRecLineSpacing104 = _class.GetMethodID("getRecLineSpacing", _getRecLineSpacing104);
	protected static JMethodID _msetSlpLineChars105 = _class.GetMethodID("setSlpLineChars", _setSlpLineChars105);
	protected static JMethodID _mgetSlpLineHeight106 = _class.GetMethodID("getSlpLineHeight", _getSlpLineHeight106);
	protected static JMethodID _mrotatePrint107 = _class.GetMethodID("rotatePrint", _rotatePrint107);
	protected static JMethodID _mgetCartridgeNotify108 = _class.GetMethodID("getCartridgeNotify", _getCartridgeNotify108);
	protected static JMethodID _msetCartridgeNotify109 = _class.GetMethodID("setCartridgeNotify", _setCartridgeNotify109);
	protected static JMethodID _mbeginRemoval110 = _class.GetMethodID("beginRemoval", _beginRemoval110);
	protected static JMethodID _mendRemoval111 = _class.GetMethodID("endRemoval", _endRemoval111);
	protected static JMethodID _msetBitmap112 = _class.GetMethodID("setBitmap", _setBitmap112);
	protected static JMethodID _mgetPageModeArea113 = _class.GetMethodID("getPageModeArea", _getPageModeArea113);
	protected static JMethodID _mgetPageModeStation114 = _class.GetMethodID("getPageModeStation", _getPageModeStation114);
	protected static JMethodID _mendInsertion115 = _class.GetMethodID("endInsertion", _endInsertion115);
	protected static JMethodID _mgetSlpPrintSide116 = _class.GetMethodID("getSlpPrintSide", _getSlpPrintSide116);
	protected static JMethodID _mgetMapCharacterSet117 = _class.GetMethodID("getMapCharacterSet", _getMapCharacterSet117);
	protected static JMethodID _msetPageModeStation118 = _class.GetMethodID("setPageModeStation", _setPageModeStation118);
	protected static JMethodID _mclearOutput119 = _class.GetMethodID("clearOutput", _clearOutput119);
	protected static JMethodID _mprintBarCode120 = _class.GetMethodID("printBarCode", _printBarCode120);
	protected static JMethodID _mprintBitmap121 = _class.GetMethodID("printBitmap", _printBitmap121);
	protected static JMethodID _mprintImmediate122 = _class.GetMethodID("printImmediate", _printImmediate122);
	protected static JMethodID _mprintNormal123 = _class.GetMethodID("printNormal", _printNormal123);
	protected static JMethodID _msetMapCharacterSet124 = _class.GetMethodID("setMapCharacterSet", _setMapCharacterSet124);
	protected static JMethodID _mbeginInsertion125 = _class.GetMethodID("beginInsertion", _beginInsertion125);
	protected static JMethodID _mcutPaper126 = _class.GetMethodID("cutPaper", _cutPaper126);
	protected static JMethodID _mprintTwoNormal127 = _class.GetMethodID("printTwoNormal", _printTwoNormal127);
	protected static JMethodID _msetLogo128 = _class.GetMethodID("setLogo", _setLogo128);
	protected static JMethodID _mprintMemoryBitmap129 = _class.GetMethodID("printMemoryBitmap", _printMemoryBitmap129);
	protected static JMethodID _mtransactionPrint130 = _class.GetMethodID("transactionPrint", _transactionPrint130);
	protected static JMethodID _mdrawRuledLine131 = _class.GetMethodID("drawRuledLine", _drawRuledLine131);
	protected static JMethodID _mpageModePrint132 = _class.GetMethodID("pageModePrint", _pageModePrint132);
	protected static JMethodID _mmarkFeed133 = _class.GetMethodID("markFeed", _markFeed133);
	protected static JMethodID _mvalidateData134 = _class.GetMethodID("validateData", _validateData134);
	protected static JMethodID _mclearPrintArea135 = _class.GetMethodID("clearPrintArea", _clearPrintArea135);
	protected static JMethodID _mchangePrintSide136 = _class.GetMethodID("changePrintSide", _changePrintSide136);
	protected static JMethodID _msetPageModeHorizontalPosition137 = _class.GetMethodID("setPageModeHorizontalPosition", _setPageModeHorizontalPosition137);
	protected static JMethodID _mgetPageModeHorizontalPosition138 = _class.GetMethodID("getPageModeHorizontalPosition", _getPageModeHorizontalPosition138);
	protected static JMethodID _mgetRecBitmapRotationList139 = _class.GetMethodID("getRecBitmapRotationList", _getRecBitmapRotationList139);
	protected static JMethodID _msetPageModePrintDirection140 = _class.GetMethodID("setPageModePrintDirection", _setPageModePrintDirection140);
	protected static JMethodID _msetPageModeVerticalPosition141 = _class.GetMethodID("setPageModeVerticalPosition", _setPageModeVerticalPosition141);
	protected static JMethodID _msetPageModePrintArea142 = _class.GetMethodID("setPageModePrintArea", _setPageModePrintArea142);
	protected static JMethodID _mgetPageModePrintArea143 = _class.GetMethodID("getPageModePrintArea", _getPageModePrintArea143);
	protected static JMethodID _mgetPageModeVerticalPosition144 = _class.GetMethodID("getPageModeVerticalPosition", _getPageModeVerticalPosition144);
	protected static JMethodID _mgetSlpBitmapRotationList145 = _class.GetMethodID("getSlpBitmapRotationList", _getSlpBitmapRotationList145);
	protected static JMethodID _msetSlpCurrentCartridge146 = _class.GetMethodID("setSlpCurrentCartridge", _setSlpCurrentCartridge146);
	protected static JMethodID _mgetPageModeDescriptor147 = _class.GetMethodID("getPageModeDescriptor", _getPageModeDescriptor147);
	protected static JMethodID _maddOutputCompleteListener148 = _class.GetMethodID("addOutputCompleteListener", _addOutputCompleteListener148);
	protected static JMethodID _mremoveOutputCompleteListener149 = _class.GetMethodID("removeOutputCompleteListener", _removeOutputCompleteListener149);
	protected static JMethodID _mgetPageModePrintDirection150 = _class.GetMethodID("getPageModePrintDirection", _getPageModePrintDirection150);
	protected static JMethodID _mgetCapConcurrentJrnRec151 = _class.GetMethodID("getCapConcurrentJrnRec", _getCapConcurrentJrnRec151);
	protected static JMethodID _mgetCapConcurrentJrnSlp152 = _class.GetMethodID("getCapConcurrentJrnSlp", _getCapConcurrentJrnSlp152);
	protected static JMethodID _mgetCapConcurrentRecSlp153 = _class.GetMethodID("getCapConcurrentRecSlp", _getCapConcurrentRecSlp153);
	protected static JMethodID _mgetCapJrnDwideDhigh154 = _class.GetMethodID("getCapJrnDwideDhigh", _getCapJrnDwideDhigh154);
	protected static JMethodID _mgetCapJrnEmptySensor155 = _class.GetMethodID("getCapJrnEmptySensor", _getCapJrnEmptySensor155);
	protected static JMethodID _mgetCapRecCartridgeSensor156 = _class.GetMethodID("getCapRecCartridgeSensor", _getCapRecCartridgeSensor156);
	protected static JMethodID _mgetJrnLineCharsList157 = _class.GetMethodID("getJrnLineCharsList", _getJrnLineCharsList157);
	protected static JMethodID _mgetRecCurrentCartridge158 = _class.GetMethodID("getRecCurrentCartridge", _getRecCurrentCartridge158);
	protected static JMethodID _msetJrnLetterQuality159 = _class.GetMethodID("setJrnLetterQuality", _setJrnLetterQuality159);
	protected static JMethodID _mgetRecCartridgeState160 = _class.GetMethodID("getRecCartridgeState", _getRecCartridgeState160);
	protected static JMethodID _mgetCapSlpNearEndSensor161 = _class.GetMethodID("getCapSlpNearEndSensor", _getCapSlpNearEndSensor161);
	protected static JMethodID _mgetRecLinesToPaperCut162 = _class.GetMethodID("getRecLinesToPaperCut", _getRecLinesToPaperCut162);
	protected static JMethodID _msetRecCurrentCartridge163 = _class.GetMethodID("setRecCurrentCartridge", _setRecCurrentCartridge163);
	protected static JMethodID _mgetSlpCartridgeState164 = _class.GetMethodID("getSlpCartridgeState", _getSlpCartridgeState164);
	protected static JMethodID _mgetSlpLetterQuality165 = _class.GetMethodID("getSlpLetterQuality", _getSlpLetterQuality165);
	protected static JMethodID _mgetJrnCurrentCartridge166 = _class.GetMethodID("getJrnCurrentCartridge", _getJrnCurrentCartridge166);
	protected static JMethodID _mgetCapRecDwideDhigh167 = _class.GetMethodID("getCapRecDwideDhigh", _getCapRecDwideDhigh167);
	protected static JMethodID _mgetSlpCurrentCartridge168 = _class.GetMethodID("getSlpCurrentCartridge", _getSlpCurrentCartridge168);
	protected static JMethodID _mgetJrnCartridgeState169 = _class.GetMethodID("getJrnCartridgeState", _getJrnCartridgeState169);
	protected static JMethodID _mgetCapRecEmptySensor170 = _class.GetMethodID("getCapRecEmptySensor", _getCapRecEmptySensor170);
	protected static JMethodID _mgetCapRecNearEndSensor171 = _class.GetMethodID("getCapRecNearEndSensor", _getCapRecNearEndSensor171);
	protected static JMethodID _mgetCapSlpCartridgeSensor172 = _class.GetMethodID("getCapSlpCartridgeSensor", _getCapSlpCartridgeSensor172);
	protected static JMethodID _mgetCapConcurrentPageMode173 = _class.GetMethodID("getCapConcurrentPageMode", _getCapConcurrentPageMode173);
	protected static JMethodID _mgetRecLineCharsList174 = _class.GetMethodID("getRecLineCharsList", _getRecLineCharsList174);
	protected static JMethodID _msetJrnCurrentCartridge175 = _class.GetMethodID("setJrnCurrentCartridge", _setJrnCurrentCartridge175);
	protected static JMethodID _mgetRecSidewaysMaxChars176 = _class.GetMethodID("getRecSidewaysMaxChars", _getRecSidewaysMaxChars176);
	protected static JMethodID _mgetCapJrnNearEndSensor177 = _class.GetMethodID("getCapJrnNearEndSensor", _getCapJrnNearEndSensor177);
	protected static JMethodID _mgetCapSlpDwideDhigh178 = _class.GetMethodID("getCapSlpDwideDhigh", _getCapSlpDwideDhigh178);
	protected static JMethodID _mgetCapSlpEmptySensor179 = _class.GetMethodID("getCapSlpEmptySensor", _getCapSlpEmptySensor179);
	protected static JMethodID _mgetCapMapCharacterSet180 = _class.GetMethodID("getCapMapCharacterSet", _getCapMapCharacterSet180);
	protected static JMethodID _mgetFontTypefaceList181 = _class.GetMethodID("getFontTypefaceList", _getFontTypefaceList181);
	protected static JMethodID _mgetJrnLetterQuality182 = _class.GetMethodID("getJrnLetterQuality", _getJrnLetterQuality182);
	protected static JMethodID _mgetCapJrnCartridgeSensor183 = _class.GetMethodID("getCapJrnCartridgeSensor", _getCapJrnCartridgeSensor183);
	protected static JMethodID _mgetCharacterSetList184 = _class.GetMethodID("getCharacterSetList", _getCharacterSetList184);
	protected static JMethodID _mgetRecBarCodeRotationList185 = _class.GetMethodID("getRecBarCodeRotationList", _getRecBarCodeRotationList185);
	protected static JMethodID _mgetRecLetterQuality186 = _class.GetMethodID("getRecLetterQuality", _getRecLetterQuality186);
	protected static JMethodID _msetSlpLetterQuality187 = _class.GetMethodID("setSlpLetterQuality", _setSlpLetterQuality187);
	protected static JMethodID _mgetSlpLineCharsList188 = _class.GetMethodID("getSlpLineCharsList", _getSlpLineCharsList188);
	protected static JMethodID _mgetCapSlpBothSidesPrint189 = _class.GetMethodID("getCapSlpBothSidesPrint", _getCapSlpBothSidesPrint189);
	protected static JMethodID _mgetSlpLinesNearEndToEnd190 = _class.GetMethodID("getSlpLinesNearEndToEnd", _getSlpLinesNearEndToEnd190);
	protected static JMethodID _mgetSlpSidewaysMaxChars191 = _class.GetMethodID("getSlpSidewaysMaxChars", _getSlpSidewaysMaxChars191);
	protected static JMethodID _msetRecLetterQuality192 = _class.GetMethodID("setRecLetterQuality", _setRecLetterQuality192);
	protected static JMethodID _mgetRecSidewaysMaxLines193 = _class.GetMethodID("getRecSidewaysMaxLines", _getRecSidewaysMaxLines193);
	protected static JMethodID _mgetSlpBarCodeRotationList194 = _class.GetMethodID("getSlpBarCodeRotationList", _getSlpBarCodeRotationList194);
	protected static JMethodID _mgetSlpSidewaysMaxLines195 = _class.GetMethodID("getSlpSidewaysMaxLines", _getSlpSidewaysMaxLines195);

	[DebuggerNonUserCode]
	public static bool IsInstanceOf(JObject except)
	{
	  return JNI.IsInstanceOf(except, _class);
	}
	[DebuggerNonUserCode]
	private static Exception FromThrowable(JThrowable except)
	{
	  if (jpos.JposException.IsInstanceOf(except))
	  {
	    jpos.JposException d = new jpos.JposException(new JClone<JObject>() { Value = except });
	    d.printStackTrace();
	    int errorCode = d.getErrorCode();
	    int errorCodeExtended = d.getErrorCodeExtended();
	    return new PosControlException(except.ToString(), (ErrorCode)errorCode, errorCodeExtended);
	  }
	  else
	  {
	    except.printStackTrace();
	    return new JavaException(except.ToString());
	  }
	}

	[DebuggerNonUserCode]
	public POSPrinter(JClone<JObject> obj) : base(obj) {} 

	public POSPrinter() : base(initialize()) {}
	[DebuggerNonUserCode]
	protected static JClone<JObject> initialize() 
	{
	    JObject ret = JNI.NewObject<JObject>(_class, _minit0);
	    bool exception = JNI.ExceptionCheck();
	    if (ret.Handle == IntPtr.Zero) throw new PosInvalidStateException();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return new JClone<JObject>() { Value = ret } ;
	}



	[DebuggerNonUserCode]
	public bool getAsyncMode() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetAsyncMode0);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapJrn2Color() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapJrn2Color1);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapJrnBold() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapJrnBold2);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapJrnDhigh() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapJrnDhigh3);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapJrnDwide() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapJrnDwide4);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public int getCapCharacterSet() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetCapCharacterSet5);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapCoverSensor() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapCoverSensor6);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void addStatusUpdateListener(jpos.events.StatusUpdateListener p0) 
	{
	    JNI.CallVoidMethod(this, _maddStatusUpdateListener7, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getCapPowerReporting() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetCapPowerReporting8);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapUpdateStatistics() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapUpdateStatistics9);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapStatisticsReporting() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapStatisticsReporting10);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapCompareFirmwareVersion() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapCompareFirmwareVersion11);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapUpdateFirmware() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapUpdateFirmware12);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void compareFirmwareVersion(string p0,JObject p1) 
	{
	    JNI.CallVoidMethod(this, _mcompareFirmwareVersion13, new JValue(JNI.NewString(p0)),new JValue(p1));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void addDirectIOListener(jpos.events.DirectIOListener p0) 
	{
	    JNI.CallVoidMethod(this, _maddDirectIOListener14, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void removeDirectIOListener(jpos.events.DirectIOListener p0) 
	{
	    JNI.CallVoidMethod(this, _mremoveDirectIOListener15, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getOutputID() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetOutputID16);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void addErrorListener(JObject p0) 
	{
	    JNI.CallVoidMethod(this, _maddErrorListener17, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void removeStatusUpdateListener(jpos.events.StatusUpdateListener p0) 
	{
	    JNI.CallVoidMethod(this, _mremoveStatusUpdateListener18, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void removeErrorListener(JObject p0) 
	{
	    JNI.CallVoidMethod(this, _mremoveErrorListener19, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void updateFirmware(string p0) 
	{
	    JNI.CallVoidMethod(this, _mupdateFirmware20, new JValue(JNI.NewString(p0)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void setPowerNotify(int p0) 
	{
	    JNI.CallVoidMethod(this, _msetPowerNotify21, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void updateStatistics(string p0) 
	{
	    JNI.CallVoidMethod(this, _mupdateStatistics22, new JValue(JNI.NewString(p0)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getPowerNotify() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetPowerNotify23);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public int getPowerState() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetPowerState24);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void resetStatistics(string p0) 
	{
	    JNI.CallVoidMethod(this, _mresetStatistics25, new JValue(JNI.NewString(p0)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void retrieveStatistics(JObject p0) 
	{
	    JNI.CallVoidMethod(this, _mretrieveStatistics26, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public bool getCapSlp2Color() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapSlp2Color27);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapRecRight90() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapRecRight9028);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapJrnUnderline() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapJrnUnderline29);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapSlpBitmap() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapSlpBitmap30);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapRecStamp() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapRecStamp31);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapRecPapercut() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapRecPapercut32);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapJrnItalic() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapJrnItalic33);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapSlpPresent() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapSlpPresent34);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapSlpRight90() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapSlpRight9035);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapSlpRotate180() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapSlpRotate18036);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapRecItalic() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapRecItalic37);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapRecUnderline() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapRecUnderline38);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapRecBarCode() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapRecBarCode39);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapRecBitmap() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapRecBitmap40);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapRecLeft90() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapRecLeft9041);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapRecBold() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapRecBold42);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapRec2Color() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapRec2Color43);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapSlpBarCode() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapSlpBarCode44);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapSlpDhigh() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapSlpDhigh45);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapSlpBold() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapSlpBold46);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapSlpFullslip() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapSlpFullslip47);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapSlpItalic() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapSlpItalic48);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapRecPresent() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapRecPresent49);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapRecRotate180() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapRecRotate18050);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapJrnPresent() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapJrnPresent51);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapSlpLeft90() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapSlpLeft9052);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapSlpDwide() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapSlpDwide53);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapRecDhigh() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapRecDhigh54);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapRecDwide() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapRecDwide55);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapTransaction() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapTransaction56);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public int getCapRecColor() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetCapRecColor57);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void setAsyncMode(bool p0) 
	{
	    JNI.CallVoidMethod(this, _msetAsyncMode58, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public string getErrorString() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetErrorString59);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret.GetString();
	}

	[DebuggerNonUserCode]
	public bool getCapSlpUnderline() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapSlpUnderline60);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapRecPageMode() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapRecPageMode61);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void setFlagWhenIdle(bool p0) 
	{
	    JNI.CallVoidMethod(this, _msetFlagWhenIdle62, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getErrorLevel() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetErrorLevel63);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void setJrnLineHeight(int p0) 
	{
	    JNI.CallVoidMethod(this, _msetJrnLineHeight64, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getJrnLineChars() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetJrnLineChars65);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public int getCapSlpColor() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetCapSlpColor66);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapSlpPageMode() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapSlpPageMode67);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void setCharacterSet(int p0) 
	{
	    JNI.CallVoidMethod(this, _msetCharacterSet68, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getJrnLineSpacing() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetJrnLineSpacing69);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void setJrnLineSpacing(int p0) 
	{
	    JNI.CallVoidMethod(this, _msetJrnLineSpacing70, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public bool getFlagWhenIdle() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetFlagWhenIdle71);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public int getCapRecMarkFeed() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetCapRecMarkFeed72);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCoverOpen() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCoverOpen73);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public int getCapSlpRuledLine() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetCapSlpRuledLine74);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public int getCapJrnColor() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetCapJrnColor75);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public int getErrorStation() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetErrorStation76);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public int getJrnLineHeight() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetJrnLineHeight77);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getJrnEmpty() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetJrnEmpty78);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void setJrnLineChars(int p0) 
	{
	    JNI.CallVoidMethod(this, _msetJrnLineChars79, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getCapRecRuledLine() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetCapRecRuledLine80);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public int getCharacterSet() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetCharacterSet81);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void setSlpLineHeight(int p0) 
	{
	    JNI.CallVoidMethod(this, _msetSlpLineHeight82, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getSlpLineSpacing() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetSlpLineSpacing83);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void setSlpLineSpacing(int p0) 
	{
	    JNI.CallVoidMethod(this, _msetSlpLineSpacing84, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getSlpLineWidth() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetSlpLineWidth85);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public int getSlpMaxLines() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetSlpMaxLines86);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getSlpEmpty() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetSlpEmpty87);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getRecNearEnd() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetRecNearEnd88);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void setRecLineHeight(int p0) 
	{
	    JNI.CallVoidMethod(this, _msetRecLineHeight89, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public bool getSlpNearEnd() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetSlpNearEnd90);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public int getSlpLineChars() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetSlpLineChars91);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public int getMapMode() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetMapMode92);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void setRotateSpecial(int p0) 
	{
	    JNI.CallVoidMethod(this, _msetRotateSpecial93, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void setMapMode(int p0) 
	{
	    JNI.CallVoidMethod(this, _msetMapMode94, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public bool getJrnNearEnd() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetJrnNearEnd95);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public int getRecLineHeight() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetRecLineHeight96);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void setRecLineChars(int p0) 
	{
	    JNI.CallVoidMethod(this, _msetRecLineChars97, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void setRecLineSpacing(int p0) 
	{
	    JNI.CallVoidMethod(this, _msetRecLineSpacing98, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getJrnLineWidth() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetJrnLineWidth99);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public int getRecLineWidth() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetRecLineWidth100);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public int getRotateSpecial() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetRotateSpecial101);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getRecEmpty() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetRecEmpty102);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public int getRecLineChars() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetRecLineChars103);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public int getRecLineSpacing() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetRecLineSpacing104);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void setSlpLineChars(int p0) 
	{
	    JNI.CallVoidMethod(this, _msetSlpLineChars105, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getSlpLineHeight() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetSlpLineHeight106);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void rotatePrint(int p0,int p1) 
	{
	    JNI.CallVoidMethod(this, _mrotatePrint107, new JValue(p0),new JValue(p1));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getCartridgeNotify() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetCartridgeNotify108);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void setCartridgeNotify(int p0) 
	{
	    JNI.CallVoidMethod(this, _msetCartridgeNotify109, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void beginRemoval(int p0) 
	{
	    JNI.CallVoidMethod(this, _mbeginRemoval110, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void endRemoval() 
	{
	    JNI.CallVoidMethod(this, _mendRemoval111);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void setBitmap(int p0,int p1,string p2,int p3,int p4) 
	{
	    JNI.CallVoidMethod(this, _msetBitmap112, new JValue(p0),new JValue(p1),new JValue(JNI.NewString(p2)),new JValue(p3),new JValue(p4));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public string getPageModeArea() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetPageModeArea113);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret.GetString();
	}

	[DebuggerNonUserCode]
	public int getPageModeStation() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetPageModeStation114);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void endInsertion() 
	{
	    JNI.CallVoidMethod(this, _mendInsertion115);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getSlpPrintSide() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetSlpPrintSide116);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getMapCharacterSet() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetMapCharacterSet117);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void setPageModeStation(int p0) 
	{
	    JNI.CallVoidMethod(this, _msetPageModeStation118, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void clearOutput() 
	{
	    JNI.CallVoidMethod(this, _mclearOutput119);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void printBarCode(int p0,string p1,int p2,int p3,int p4,int p5,int p6) 
	{
	    JNI.CallVoidMethod(this, _mprintBarCode120, new JValue(p0),new JValue(JNI.NewString(p1)),new JValue(p2),new JValue(p3),new JValue(p4),new JValue(p5),new JValue(p6));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void printBitmap(int p0,string p1,int p2,int p3) 
	{
	    JNI.CallVoidMethod(this, _mprintBitmap121, new JValue(p0),new JValue(JNI.NewString(p1)),new JValue(p2),new JValue(p3));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void printImmediate(int p0,string p1) 
	{
	    JNI.CallVoidMethod(this, _mprintImmediate122, new JValue(p0),new JValue(JNI.NewString(p1)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void printNormal(int p0,string p1) 
	{
	    JNI.CallVoidMethod(this, _mprintNormal123, new JValue(p0),new JValue(JNI.NewString(p1)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void setMapCharacterSet(bool p0) 
	{
	    JNI.CallVoidMethod(this, _msetMapCharacterSet124, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void beginInsertion(int p0) 
	{
	    JNI.CallVoidMethod(this, _mbeginInsertion125, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void cutPaper(int p0) 
	{
	    JNI.CallVoidMethod(this, _mcutPaper126, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void printTwoNormal(int p0,string p1,string p2) 
	{
	    JNI.CallVoidMethod(this, _mprintTwoNormal127, new JValue(p0),new JValue(JNI.NewString(p1)),new JValue(JNI.NewString(p2)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void setLogo(int p0,string p1) 
	{
	    JNI.CallVoidMethod(this, _msetLogo128, new JValue(p0),new JValue(JNI.NewString(p1)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void printMemoryBitmap(int p0,byte[] p1,int p2,int p3,int p4) 
	{
	    JNI.CallVoidMethod(this, _mprintMemoryBitmap129, new JValue(p0),new JValue(JNI.NewArray<sbyte>(p1.Length)),new JValue(p2),new JValue(p3),new JValue(p4));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void transactionPrint(int p0,int p1) 
	{
	    JNI.CallVoidMethod(this, _mtransactionPrint130, new JValue(p0),new JValue(p1));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void drawRuledLine(int p0,string p1,int p2,int p3,int p4,int p5) 
	{
	    JNI.CallVoidMethod(this, _mdrawRuledLine131, new JValue(p0),new JValue(JNI.NewString(p1)),new JValue(p2),new JValue(p3),new JValue(p4),new JValue(p5));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void pageModePrint(int p0) 
	{
	    JNI.CallVoidMethod(this, _mpageModePrint132, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void markFeed(int p0) 
	{
	    JNI.CallVoidMethod(this, _mmarkFeed133, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void validateData(int p0,string p1) 
	{
	    JNI.CallVoidMethod(this, _mvalidateData134, new JValue(p0),new JValue(JNI.NewString(p1)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void clearPrintArea() 
	{
	    JNI.CallVoidMethod(this, _mclearPrintArea135);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void changePrintSide(int p0) 
	{
	    JNI.CallVoidMethod(this, _mchangePrintSide136, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void setPageModeHorizontalPosition(int p0) 
	{
	    JNI.CallVoidMethod(this, _msetPageModeHorizontalPosition137, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getPageModeHorizontalPosition() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetPageModeHorizontalPosition138);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public string getRecBitmapRotationList() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetRecBitmapRotationList139);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret.GetString();
	}

	[DebuggerNonUserCode]
	public void setPageModePrintDirection(int p0) 
	{
	    JNI.CallVoidMethod(this, _msetPageModePrintDirection140, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void setPageModeVerticalPosition(int p0) 
	{
	    JNI.CallVoidMethod(this, _msetPageModeVerticalPosition141, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void setPageModePrintArea(string p0) 
	{
	    JNI.CallVoidMethod(this, _msetPageModePrintArea142, new JValue(JNI.NewString(p0)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public string getPageModePrintArea() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetPageModePrintArea143);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret.GetString();
	}

	[DebuggerNonUserCode]
	public int getPageModeVerticalPosition() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetPageModeVerticalPosition144);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public string getSlpBitmapRotationList() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetSlpBitmapRotationList145);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret.GetString();
	}

	[DebuggerNonUserCode]
	public void setSlpCurrentCartridge(int p0) 
	{
	    JNI.CallVoidMethod(this, _msetSlpCurrentCartridge146, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getPageModeDescriptor() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetPageModeDescriptor147);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void addOutputCompleteListener(JObject p0) 
	{
	    JNI.CallVoidMethod(this, _maddOutputCompleteListener148, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void removeOutputCompleteListener(JObject p0) 
	{
	    JNI.CallVoidMethod(this, _mremoveOutputCompleteListener149, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getPageModePrintDirection() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetPageModePrintDirection150);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapConcurrentJrnRec() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapConcurrentJrnRec151);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapConcurrentJrnSlp() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapConcurrentJrnSlp152);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapConcurrentRecSlp() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapConcurrentRecSlp153);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapJrnDwideDhigh() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapJrnDwideDhigh154);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapJrnEmptySensor() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapJrnEmptySensor155);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public int getCapRecCartridgeSensor() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetCapRecCartridgeSensor156);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public string getJrnLineCharsList() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetJrnLineCharsList157);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret.GetString();
	}

	[DebuggerNonUserCode]
	public int getRecCurrentCartridge() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetRecCurrentCartridge158);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void setJrnLetterQuality(bool p0) 
	{
	    JNI.CallVoidMethod(this, _msetJrnLetterQuality159, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getRecCartridgeState() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetRecCartridgeState160);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapSlpNearEndSensor() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapSlpNearEndSensor161);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public int getRecLinesToPaperCut() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetRecLinesToPaperCut162);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void setRecCurrentCartridge(int p0) 
	{
	    JNI.CallVoidMethod(this, _msetRecCurrentCartridge163, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getSlpCartridgeState() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetSlpCartridgeState164);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getSlpLetterQuality() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetSlpLetterQuality165);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public int getJrnCurrentCartridge() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetJrnCurrentCartridge166);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapRecDwideDhigh() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapRecDwideDhigh167);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public int getSlpCurrentCartridge() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetSlpCurrentCartridge168);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public int getJrnCartridgeState() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetJrnCartridgeState169);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapRecEmptySensor() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapRecEmptySensor170);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapRecNearEndSensor() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapRecNearEndSensor171);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public int getCapSlpCartridgeSensor() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetCapSlpCartridgeSensor172);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapConcurrentPageMode() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapConcurrentPageMode173);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public string getRecLineCharsList() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetRecLineCharsList174);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret.GetString();
	}

	[DebuggerNonUserCode]
	public void setJrnCurrentCartridge(int p0) 
	{
	    JNI.CallVoidMethod(this, _msetJrnCurrentCartridge175, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getRecSidewaysMaxChars() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetRecSidewaysMaxChars176);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapJrnNearEndSensor() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapJrnNearEndSensor177);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapSlpDwideDhigh() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapSlpDwideDhigh178);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapSlpEmptySensor() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapSlpEmptySensor179);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapMapCharacterSet() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapMapCharacterSet180);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public string getFontTypefaceList() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetFontTypefaceList181);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret.GetString();
	}

	[DebuggerNonUserCode]
	public bool getJrnLetterQuality() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetJrnLetterQuality182);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public int getCapJrnCartridgeSensor() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetCapJrnCartridgeSensor183);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public string getCharacterSetList() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetCharacterSetList184);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret.GetString();
	}

	[DebuggerNonUserCode]
	public string getRecBarCodeRotationList() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetRecBarCodeRotationList185);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret.GetString();
	}

	[DebuggerNonUserCode]
	public bool getRecLetterQuality() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetRecLetterQuality186);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void setSlpLetterQuality(bool p0) 
	{
	    JNI.CallVoidMethod(this, _msetSlpLetterQuality187, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public string getSlpLineCharsList() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetSlpLineCharsList188);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret.GetString();
	}

	[DebuggerNonUserCode]
	public bool getCapSlpBothSidesPrint() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapSlpBothSidesPrint189);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public int getSlpLinesNearEndToEnd() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetSlpLinesNearEndToEnd190);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public int getSlpSidewaysMaxChars() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetSlpSidewaysMaxChars191);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void setRecLetterQuality(bool p0) 
	{
	    JNI.CallVoidMethod(this, _msetRecLetterQuality192, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getRecSidewaysMaxLines() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetRecSidewaysMaxLines193);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public string getSlpBarCodeRotationList() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetSlpBarCodeRotationList194);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret.GetString();
	}

	[DebuggerNonUserCode]
	public int getSlpSidewaysMaxLines() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetSlpSidewaysMaxLines195);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

}
}

namespace jpos.events {
class StatusUpdateListener : JObject {
	protected static JClass _class = JNI.FindClass("jpos/events/StatusUpdateListener");
	protected static string _statusUpdateOccurred0 = "(Ljpos/events/StatusUpdateEvent;)V";
	protected static JMethodID _mstatusUpdateOccurred0 = _class.GetMethodID("statusUpdateOccurred", _statusUpdateOccurred0);

	[DebuggerNonUserCode]
	public static bool IsInstanceOf(JObject except)
	{
	  return JNI.IsInstanceOf(except, _class);
	}
	[DebuggerNonUserCode]
	private static Exception FromThrowable(JThrowable except)
	{
	  if (jpos.JposException.IsInstanceOf(except))
	  {
	    jpos.JposException d = new jpos.JposException(new JClone<JObject>() { Value = except });
	    d.printStackTrace();
	    int errorCode = d.getErrorCode();
	    int errorCodeExtended = d.getErrorCodeExtended();
	    return new PosControlException(except.ToString(), (ErrorCode)errorCode, errorCodeExtended);
	  }
	  else
	  {
	    except.printStackTrace();
	    return new JavaException(except.ToString());
	  }
	}

	[DebuggerNonUserCode]
	public StatusUpdateListener(JClone<JObject> obj) : base(obj) {} 



	[DebuggerNonUserCode]
	public void statusUpdateOccurred(jpos.events.StatusUpdateEvent p0) 
	{
	    JNI.CallVoidMethod(this, _mstatusUpdateOccurred0, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

}
}

namespace jpos.events {
class DirectIOListener : JObject {
	protected static JClass _class = JNI.FindClass("jpos/events/DirectIOListener");
	protected static string _directIOOccurred0 = "(Ljpos/events/DirectIOEvent;)V";
	protected static JMethodID _mdirectIOOccurred0 = _class.GetMethodID("directIOOccurred", _directIOOccurred0);

	[DebuggerNonUserCode]
	public static bool IsInstanceOf(JObject except)
	{
	  return JNI.IsInstanceOf(except, _class);
	}
	[DebuggerNonUserCode]
	private static Exception FromThrowable(JThrowable except)
	{
	  if (jpos.JposException.IsInstanceOf(except))
	  {
	    jpos.JposException d = new jpos.JposException(new JClone<JObject>() { Value = except });
	    d.printStackTrace();
	    int errorCode = d.getErrorCode();
	    int errorCodeExtended = d.getErrorCodeExtended();
	    return new PosControlException(except.ToString(), (ErrorCode)errorCode, errorCodeExtended);
	  }
	  else
	  {
	    except.printStackTrace();
	    return new JavaException(except.ToString());
	  }
	}

	[DebuggerNonUserCode]
	public DirectIOListener(JClone<JObject> obj) : base(obj) {} 



	[DebuggerNonUserCode]
	public void directIOOccurred(jpos.events.DirectIOEvent p0) 
	{
	    JNI.CallVoidMethod(this, _mdirectIOOccurred0, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

}
}

namespace jpos.events {
class DataListener : JObject {
	protected static JClass _class = JNI.FindClass("jpos/events/DataListener");
	protected static string _dataOccurred0 = "(Ljpos/events/DataEvent;)V";
	protected static JMethodID _mdataOccurred0 = _class.GetMethodID("dataOccurred", _dataOccurred0);

	[DebuggerNonUserCode]
	public static bool IsInstanceOf(JObject except)
	{
	  return JNI.IsInstanceOf(except, _class);
	}
	[DebuggerNonUserCode]
	private static Exception FromThrowable(JThrowable except)
	{
	  if (jpos.JposException.IsInstanceOf(except))
	  {
	    jpos.JposException d = new jpos.JposException(new JClone<JObject>() { Value = except });
	    d.printStackTrace();
	    int errorCode = d.getErrorCode();
	    int errorCodeExtended = d.getErrorCodeExtended();
	    return new PosControlException(except.ToString(), (ErrorCode)errorCode, errorCodeExtended);
	  }
	  else
	  {
	    except.printStackTrace();
	    return new JavaException(except.ToString());
	  }
	}

	[DebuggerNonUserCode]
	public DataListener(JClone<JObject> obj) : base(obj) {} 



	[DebuggerNonUserCode]
	public void dataOccurred(jpos.events.DataEvent p0) 
	{
	    JNI.CallVoidMethod(this, _mdataOccurred0, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

}
}

namespace jpos {
class JposException : JThrowable {
	protected static JClass _class = JNI.FindClass("jpos/JposException");
	protected static string _init0 = "(IILjava/lang/String;Ljava/lang/Exception;)V";
	protected static string _init1 = "(ILjava/lang/String;Ljava/lang/Exception;)V";
	protected static string _init2 = "(IILjava/lang/String;)V";
	protected static string _init3 = "(I)V";
	protected static string _init4 = "(II)V";
	protected static string _init5 = "(ILjava/lang/String;)V";
	protected static string _getErrorCode0 = "()I";
	protected static string _getOrigException1 = "()Ljava/lang/Exception;";
	protected static string _getErrorCodeExtended2 = "()I";
	protected static JMethodID _minit0 = _class.GetMethodID("<init>", _init0);
	protected static JMethodID _minit1 = _class.GetMethodID("<init>", _init1);
	protected static JMethodID _minit2 = _class.GetMethodID("<init>", _init2);
	protected static JMethodID _minit3 = _class.GetMethodID("<init>", _init3);
	protected static JMethodID _minit4 = _class.GetMethodID("<init>", _init4);
	protected static JMethodID _minit5 = _class.GetMethodID("<init>", _init5);
	protected static JMethodID _mgetErrorCode0 = _class.GetMethodID("getErrorCode", _getErrorCode0);
	protected static JMethodID _mgetOrigException1 = _class.GetMethodID("getOrigException", _getOrigException1);
	protected static JMethodID _mgetErrorCodeExtended2 = _class.GetMethodID("getErrorCodeExtended", _getErrorCodeExtended2);

	[DebuggerNonUserCode]
	public static bool IsInstanceOf(JObject except)
	{
	  return JNI.IsInstanceOf(except, _class);
	}
	[DebuggerNonUserCode]
	private static Exception FromThrowable(JThrowable except)
	{
	  if (jpos.JposException.IsInstanceOf(except))
	  {
	    jpos.JposException d = new jpos.JposException(new JClone<JObject>() { Value = except });
	    d.printStackTrace();
	    int errorCode = d.getErrorCode();
	    int errorCodeExtended = d.getErrorCodeExtended();
	    return new PosControlException(except.ToString(), (ErrorCode)errorCode, errorCodeExtended);
	  }
	  else
	  {
	    except.printStackTrace();
	    return new JavaException(except.ToString());
	  }
	}

	[DebuggerNonUserCode]
	public JposException(JClone<JObject> obj) : base(obj) {} 

	public JposException(int p0,int p1,string p2,JObject p3) : base(initialize(p0,p1,p2,p3)) {}
	[DebuggerNonUserCode]
	protected static JClone<JObject> initialize(int p0,int p1,string p2,JObject p3) 
	{
	    JObject ret = JNI.NewObject<JObject>(_class, _minit0, new JValue(p0),new JValue(p1),new JValue(JNI.NewString(p2)),new JValue(p3));
	    bool exception = JNI.ExceptionCheck();
	    if (ret.Handle == IntPtr.Zero) throw new PosInvalidStateException();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return new JClone<JObject>() { Value = ret } ;
	}

	public JposException(int p0,string p1,JObject p2) : base(initialize(p0,p1,p2)) {}
	[DebuggerNonUserCode]
	protected static JClone<JObject> initialize(int p0,string p1,JObject p2) 
	{
	    JObject ret = JNI.NewObject<JObject>(_class, _minit1, new JValue(p0),new JValue(JNI.NewString(p1)),new JValue(p2));
	    bool exception = JNI.ExceptionCheck();
	    if (ret.Handle == IntPtr.Zero) throw new PosInvalidStateException();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return new JClone<JObject>() { Value = ret } ;
	}

	public JposException(int p0,int p1,string p2) : base(initialize(p0,p1,p2)) {}
	[DebuggerNonUserCode]
	protected static JClone<JObject> initialize(int p0,int p1,string p2) 
	{
	    JObject ret = JNI.NewObject<JObject>(_class, _minit2, new JValue(p0),new JValue(p1),new JValue(JNI.NewString(p2)));
	    bool exception = JNI.ExceptionCheck();
	    if (ret.Handle == IntPtr.Zero) throw new PosInvalidStateException();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return new JClone<JObject>() { Value = ret } ;
	}

	public JposException(int p0) : base(initialize(p0)) {}
	[DebuggerNonUserCode]
	protected static JClone<JObject> initialize(int p0) 
	{
	    JObject ret = JNI.NewObject<JObject>(_class, _minit3, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (ret.Handle == IntPtr.Zero) throw new PosInvalidStateException();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return new JClone<JObject>() { Value = ret } ;
	}

	public JposException(int p0,int p1) : base(initialize(p0,p1)) {}
	[DebuggerNonUserCode]
	protected static JClone<JObject> initialize(int p0,int p1) 
	{
	    JObject ret = JNI.NewObject<JObject>(_class, _minit4, new JValue(p0),new JValue(p1));
	    bool exception = JNI.ExceptionCheck();
	    if (ret.Handle == IntPtr.Zero) throw new PosInvalidStateException();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return new JClone<JObject>() { Value = ret } ;
	}

	public JposException(int p0,string p1) : base(initialize(p0,p1)) {}
	[DebuggerNonUserCode]
	protected static JClone<JObject> initialize(int p0,string p1) 
	{
	    JObject ret = JNI.NewObject<JObject>(_class, _minit5, new JValue(p0),new JValue(JNI.NewString(p1)));
	    bool exception = JNI.ExceptionCheck();
	    if (ret.Handle == IntPtr.Zero) throw new PosInvalidStateException();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return new JClone<JObject>() { Value = ret } ;
	}



	[DebuggerNonUserCode]
	public int getErrorCode() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetErrorCode0);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public JObject getOrigException() 
	{
	    JObject ret = JNI.CallObjectMethod<JObject>(this, _mgetOrigException1);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public int getErrorCodeExtended() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetErrorCodeExtended2);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

}
}

class NativeDataListener : JObject {
public interface Native {

		public void Scanner_DataEvent(NativeDataListener self,jpos.events.DataEvent p0);

	}
	internal static Native? nativeEvents { get; set; }
	protected static JClass _class = JNI.FindClass("NativeDataListener");
	protected static string _init0 = "()V";
	protected static string _dataOccurred0 = "(Ljpos/events/DataEvent;)V";
	protected static string _Scanner_DataEvent0 = "(Ljpos/events/DataEvent;)V";
	protected static JMethodID _minit0 = _class.GetMethodID("<init>", _init0);
	protected static JMethodID _mdataOccurred0 = _class.GetMethodID("dataOccurred", _dataOccurred0);

	[DebuggerNonUserCode]
	public static bool IsInstanceOf(JObject except)
	{
	  return JNI.IsInstanceOf(except, _class);
	}
	[DebuggerNonUserCode]
	private static Exception FromThrowable(JThrowable except)
	{
	  if (jpos.JposException.IsInstanceOf(except))
	  {
	    jpos.JposException d = new jpos.JposException(new JClone<JObject>() { Value = except });
	    d.printStackTrace();
	    int errorCode = d.getErrorCode();
	    int errorCodeExtended = d.getErrorCodeExtended();
	    return new PosControlException(except.ToString(), (ErrorCode)errorCode, errorCodeExtended);
	  }
	  else
	  {
	    except.printStackTrace();
	    return new JavaException(except.ToString());
	  }
	}

	[DebuggerNonUserCode]
	public NativeDataListener(JClone<JObject> obj) : base(obj) {} 

	public NativeDataListener() : base(initialize()) {}
	[DebuggerNonUserCode]
	protected static JClone<JObject> initialize() 
	{
	    JObject ret = JNI.NewObject<JObject>(_class, _minit0);
	    bool exception = JNI.ExceptionCheck();
	    if (ret.Handle == IntPtr.Zero) throw new PosInvalidStateException();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return new JClone<JObject>() { Value = ret } ;
	}

	delegate void Scanner_DataEventInternal(IntPtr JNIEnv,IntPtr objectOrClasss,IntPtr p0);
	public static List<WeakReference<NativeDataListener>> mapping = new List<WeakReference<NativeDataListener>>();
	public static bool TryGet(IntPtr refz, out NativeDataListener l)
	{
	    NativeDataListener output = null;
	    var s = new JObject(refz, JNI.ReferenceType.Local);
	    for (int i = 0; i < mapping.Count; i++)
	    {
	        if (mapping[0].TryGetTarget(out output) && JNI.IsSameObject(output, s) == true)
	        {
	            l = output;
	            return true;
	        }
	    }
	
	    l = null;
	    return false;
	}
	public static void Register(NativeDataListener c)
	{
	    mapping.Add(new WeakReference<NativeDataListener>(c));
	}
	public static void Unregister(NativeDataListener c)
	{
	    NativeDataListener output = null;
	    mapping.RemoveAll((m) => m.TryGetTarget(out output) && object.ReferenceEquals(output, c));
	}
	static NativeDataListener()
	{
	    
	        Scanner_DataEventInternal evt = Scanner_DataEvent;
	    JNI.RegisterNatives(_class, new JNINativeMethod[] {
	        new JNINativeMethod() { name = "Scanner_DataEvent", signature = _Scanner_DataEvent0, fnPtr = Marshal.GetFunctionPointerForDelegate(evt) },
	    });
	}

	protected static void Scanner_DataEvent(IntPtr JNIEnv,IntPtr objectOrClasss,IntPtr p0) 
	{
	    NativeDataListener pobject = new NativeDataListener(new JClone<JObject>() { Value = JNI.NewGlobalRef<JObject>(new JObject(objectOrClasss, JNI.ReferenceType.Local)) });
	    jpos.events.DataEvent pp0 = new jpos.events.DataEvent(new JClone<JObject>() { Value = JNI.NewGlobalRef<JObject>(new JObject(p0, JNI.ReferenceType.Local)) });
	    nativeEvents?.Scanner_DataEvent(pobject,pp0);
	}

	public void Scanner_DataEvent(jpos.events.DataEvent p0) 
	{
	    throw new NotImplementedException();
	}


	[DebuggerNonUserCode]
	public void dataOccurred(jpos.events.DataEvent p0) 
	{
	    JNI.CallVoidMethod(this, _mdataOccurred0, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

}

class NativeStatusUpdateListener : JObject {
public interface Native {

		public void Scanner_DataEvent(NativeStatusUpdateListener self,jpos.events.StatusUpdateEvent p0);

	}
	internal static Native? nativeEvents { get; set; }
	protected static JClass _class = JNI.FindClass("NativeStatusUpdateListener");
	protected static string _init0 = "()V";
	protected static string _statusUpdateOccurred0 = "(Ljpos/events/StatusUpdateEvent;)V";
	protected static string _Scanner_DataEvent0 = "(Ljpos/events/StatusUpdateEvent;)V";
	protected static JMethodID _minit0 = _class.GetMethodID("<init>", _init0);
	protected static JMethodID _mstatusUpdateOccurred0 = _class.GetMethodID("statusUpdateOccurred", _statusUpdateOccurred0);

	[DebuggerNonUserCode]
	public static bool IsInstanceOf(JObject except)
	{
	  return JNI.IsInstanceOf(except, _class);
	}
	[DebuggerNonUserCode]
	private static Exception FromThrowable(JThrowable except)
	{
	  if (jpos.JposException.IsInstanceOf(except))
	  {
	    jpos.JposException d = new jpos.JposException(new JClone<JObject>() { Value = except });
	    d.printStackTrace();
	    int errorCode = d.getErrorCode();
	    int errorCodeExtended = d.getErrorCodeExtended();
	    return new PosControlException(except.ToString(), (ErrorCode)errorCode, errorCodeExtended);
	  }
	  else
	  {
	    except.printStackTrace();
	    return new JavaException(except.ToString());
	  }
	}

	[DebuggerNonUserCode]
	public NativeStatusUpdateListener(JClone<JObject> obj) : base(obj) {} 

	public NativeStatusUpdateListener() : base(initialize()) {}
	[DebuggerNonUserCode]
	protected static JClone<JObject> initialize() 
	{
	    JObject ret = JNI.NewObject<JObject>(_class, _minit0);
	    bool exception = JNI.ExceptionCheck();
	    if (ret.Handle == IntPtr.Zero) throw new PosInvalidStateException();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return new JClone<JObject>() { Value = ret } ;
	}

	delegate void Scanner_DataEventInternal(IntPtr JNIEnv,IntPtr objectOrClasss,IntPtr p0);
	public static List<WeakReference<NativeStatusUpdateListener>> mapping = new List<WeakReference<NativeStatusUpdateListener>>();
	public static bool TryGet(IntPtr refz, out NativeStatusUpdateListener l)
	{
	    NativeStatusUpdateListener output = null;
	    var s = new JObject(refz, JNI.ReferenceType.Local);
	    for (int i = 0; i < mapping.Count; i++)
	    {
	        if (mapping[0].TryGetTarget(out output) && JNI.IsSameObject(output, s) == true)
	        {
	            l = output;
	            return true;
	        }
	    }
	
	    l = null;
	    return false;
	}
	public static void Register(NativeStatusUpdateListener c)
	{
	    mapping.Add(new WeakReference<NativeStatusUpdateListener>(c));
	}
	public static void Unregister(NativeStatusUpdateListener c)
	{
	    NativeStatusUpdateListener? output = null;
	    mapping.RemoveAll((m) => m.TryGetTarget(out output) && object.ReferenceEquals(output, c));
	}
	static NativeStatusUpdateListener()
	{
	    
	        Scanner_DataEventInternal evt = Scanner_DataEvent;
	    JNI.RegisterNatives(_class, new JNINativeMethod[] {
	        new JNINativeMethod() { name = "Scanner_DataEvent", signature = _Scanner_DataEvent0, fnPtr = Marshal.GetFunctionPointerForDelegate(evt) },
	    });
	}

	protected static void Scanner_DataEvent(IntPtr JNIEnv,IntPtr objectOrClasss,IntPtr p0) 
	{
	    NativeStatusUpdateListener pobject = new NativeStatusUpdateListener(new JClone<JObject>() { Value = JNI.NewGlobalRef<JObject>(new JObject(objectOrClasss, JNI.ReferenceType.Local)) });
	    jpos.events.StatusUpdateEvent pp0 = new jpos.events.StatusUpdateEvent(new JClone<JObject>() { Value = JNI.NewGlobalRef<JObject>(new JObject(p0, JNI.ReferenceType.Local)) });
	    nativeEvents?.Scanner_DataEvent(pobject,pp0);
	}

	public void Scanner_DataEvent(jpos.events.StatusUpdateEvent p0) 
	{
	    throw new NotImplementedException();
	}


	[DebuggerNonUserCode]
	public void statusUpdateOccurred(jpos.events.StatusUpdateEvent p0) 
	{
	    JNI.CallVoidMethod(this, _mstatusUpdateOccurred0, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

}

}
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword
