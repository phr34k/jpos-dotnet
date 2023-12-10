using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using JNISharp.NativeInterface;
using test.jpos;
#pragma warning disable CS0108 // Member hides inherited member; missing new keyword

namespace jpos.internals   {
namespace jpos.events {
class JposEvent : java.util.EventObject {
	protected static JClass _class;
	protected static string _init0 = "(Ljava/lang/Object;)V";
	protected static string _getSequenceNumber0 = "()J";
	protected static string _getWhen1 = "()J";
	protected static JMethodID _minit0;
	protected static JMethodID _mgetSequenceNumber0;
	protected static JMethodID _mgetWhen1;

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

	[DebuggerNonUserCode]
	static JposEvent()
	{
  	_class = JNI.FindClass("jpos/events/JposEvent");
  	if( _class == null ) throw new InvalidOperationException();
  	_minit0 = _class.GetMethodID("<init>", _init0);
  	if( _minit0.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetSequenceNumber0 = _class.GetMethodID("getSequenceNumber", _getSequenceNumber0);
  	if( _mgetSequenceNumber0.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetWhen1 = _class.GetMethodID("getWhen", _getWhen1);
  	if( _mgetWhen1.Handle == IntPtr.Zero ) throw new InvalidOperationException();
	}
}
}

namespace jpos.events {
class ErrorEvent : jpos.events.JposEvent {
	protected static JClass _class;
	protected static string _init0 = "(Ljava/lang/Object;IIII)V";
	protected static string _getErrorLocus0 = "()I";
	protected static string _getErrorResponse1 = "()I";
	protected static string _setErrorResponse2 = "(I)V";
	protected static string _getErrorCode3 = "()I";
	protected static string _getErrorCodeExtended4 = "()I";
	protected static JMethodID _minit0;
	protected static JMethodID _mgetErrorLocus0;
	protected static JMethodID _mgetErrorResponse1;
	protected static JMethodID _msetErrorResponse2;
	protected static JMethodID _mgetErrorCode3;
	protected static JMethodID _mgetErrorCodeExtended4;

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
	public ErrorEvent(JClone<JObject> obj) : base(obj) {} 

	public ErrorEvent(JObject p0,int p1,int p2,int p3,int p4) : base(initialize(p0,p1,p2,p3,p4)) {}
	[DebuggerNonUserCode]
	protected static JClone<JObject> initialize(JObject p0,int p1,int p2,int p3,int p4) 
	{
	    JObject ret = JNI.NewObject<JObject>(_class, _minit0, new JValue(p0),new JValue(p1),new JValue(p2),new JValue(p3),new JValue(p4));
	    bool exception = JNI.ExceptionCheck();
	    if (ret.Handle == IntPtr.Zero) throw new PosInvalidStateException();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return new JClone<JObject>() { Value = ret } ;
	}



	[DebuggerNonUserCode]
	public int getErrorLocus() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetErrorLocus0);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public int getErrorResponse() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetErrorResponse1);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void setErrorResponse(int p0) 
	{
	    JNI.CallVoidMethod(this, _msetErrorResponse2, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getErrorCode() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetErrorCode3);
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
	    int ret = JNI.CallMethod<int>(this, _mgetErrorCodeExtended4);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	static ErrorEvent()
	{
  	_class = JNI.FindClass("jpos/events/ErrorEvent");
  	if( _class == null ) throw new InvalidOperationException();
  	_minit0 = _class.GetMethodID("<init>", _init0);
  	if( _minit0.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetErrorLocus0 = _class.GetMethodID("getErrorLocus", _getErrorLocus0);
  	if( _mgetErrorLocus0.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetErrorResponse1 = _class.GetMethodID("getErrorResponse", _getErrorResponse1);
  	if( _mgetErrorResponse1.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetErrorResponse2 = _class.GetMethodID("setErrorResponse", _setErrorResponse2);
  	if( _msetErrorResponse2.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetErrorCode3 = _class.GetMethodID("getErrorCode", _getErrorCode3);
  	if( _mgetErrorCode3.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetErrorCodeExtended4 = _class.GetMethodID("getErrorCodeExtended", _getErrorCodeExtended4);
  	if( _mgetErrorCodeExtended4.Handle == IntPtr.Zero ) throw new InvalidOperationException();
	}
}
}

namespace jpos.events {
class DataEvent : jpos.events.JposEvent {
	protected static JClass _class;
	protected static string _init0 = "(Ljava/lang/Object;I)V";
	protected static string _getStatus0 = "()I";
	protected static JMethodID _minit0;
	protected static JMethodID _mgetStatus0;

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

	[DebuggerNonUserCode]
	static DataEvent()
	{
  	_class = JNI.FindClass("jpos/events/DataEvent");
  	if( _class == null ) throw new InvalidOperationException();
  	_minit0 = _class.GetMethodID("<init>", _init0);
  	if( _minit0.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetStatus0 = _class.GetMethodID("getStatus", _getStatus0);
  	if( _mgetStatus0.Handle == IntPtr.Zero ) throw new InvalidOperationException();
	}
}
}

namespace jpos.events {
class StatusUpdateEvent : jpos.events.JposEvent {
	protected static JClass _class;
	protected static string _init0 = "(Ljava/lang/Object;I)V";
	protected static string _getStatus0 = "()I";
	protected static JMethodID _minit0;
	protected static JMethodID _mgetStatus0;

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

	[DebuggerNonUserCode]
	static StatusUpdateEvent()
	{
  	_class = JNI.FindClass("jpos/events/StatusUpdateEvent");
  	if( _class == null ) throw new InvalidOperationException();
  	_minit0 = _class.GetMethodID("<init>", _init0);
  	if( _minit0.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetStatus0 = _class.GetMethodID("getStatus", _getStatus0);
  	if( _mgetStatus0.Handle == IntPtr.Zero ) throw new InvalidOperationException();
	}
}
}

namespace jpos.events {
class DirectIOEvent : jpos.events.JposEvent {
	protected static JClass _class;
	protected static string _init0 = "(Ljava/lang/Object;IILjava/lang/Object;)V";
	protected static string _getObject0 = "()Ljava/lang/Object;";
	protected static string _setData1 = "(I)V";
	protected static string _setObject2 = "(Ljava/lang/Object;)V";
	protected static string _getEventNumber3 = "()I";
	protected static string _getData4 = "()I";
	protected static JMethodID _minit0;
	protected static JMethodID _mgetObject0;
	protected static JMethodID _msetData1;
	protected static JMethodID _msetObject2;
	protected static JMethodID _mgetEventNumber3;
	protected static JMethodID _mgetData4;

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
	public void setData(int p0) 
	{
	    JNI.CallVoidMethod(this, _msetData1, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void setObject(JObject p0) 
	{
	    JNI.CallVoidMethod(this, _msetObject2, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getEventNumber() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetEventNumber3);
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
	    int ret = JNI.CallMethod<int>(this, _mgetData4);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	static DirectIOEvent()
	{
  	_class = JNI.FindClass("jpos/events/DirectIOEvent");
  	if( _class == null ) throw new InvalidOperationException();
  	_minit0 = _class.GetMethodID("<init>", _init0);
  	if( _minit0.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetObject0 = _class.GetMethodID("getObject", _getObject0);
  	if( _mgetObject0.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetData1 = _class.GetMethodID("setData", _setData1);
  	if( _msetData1.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetObject2 = _class.GetMethodID("setObject", _setObject2);
  	if( _msetObject2.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetEventNumber3 = _class.GetMethodID("getEventNumber", _getEventNumber3);
  	if( _mgetEventNumber3.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetData4 = _class.GetMethodID("getData", _getData4);
  	if( _mgetData4.Handle == IntPtr.Zero ) throw new InvalidOperationException();
	}
}
}

namespace jpos.events {
class OutputCompleteEvent : jpos.events.JposEvent {
	protected static JClass _class;
	protected static string _init0 = "(Ljava/lang/Object;I)V";
	protected static string _getOutputID0 = "()I";
	protected static JMethodID _minit0;
	protected static JMethodID _mgetOutputID0;

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
	public OutputCompleteEvent(JClone<JObject> obj) : base(obj) {} 

	public OutputCompleteEvent(JObject p0,int p1) : base(initialize(p0,p1)) {}
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
	public int getOutputID() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetOutputID0);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	static OutputCompleteEvent()
	{
  	_class = JNI.FindClass("jpos/events/OutputCompleteEvent");
  	if( _class == null ) throw new InvalidOperationException();
  	_minit0 = _class.GetMethodID("<init>", _init0);
  	if( _minit0.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetOutputID0 = _class.GetMethodID("getOutputID", _getOutputID0);
  	if( _mgetOutputID0.Handle == IntPtr.Zero ) throw new InvalidOperationException();
	}
}
}

namespace java.util {
class EventObject : JObject {
	protected static JClass _class;
	protected static string _init0 = "(Ljava/lang/Object;)V";
	protected static string _getSource0 = "()Ljava/lang/Object;";
	protected static JMethodID _minit0;
	protected static JMethodID _mgetSource0;

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

	[DebuggerNonUserCode]
	static EventObject()
	{
  	_class = JNI.FindClass("java/util/EventObject");
  	if( _class == null ) throw new InvalidOperationException();
  	_minit0 = _class.GetMethodID("<init>", _init0);
  	if( _minit0.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetSource0 = _class.GetMethodID("getSource", _getSource0);
  	if( _mgetSource0.Handle == IntPtr.Zero ) throw new InvalidOperationException();
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
	protected static string _setFreezeEvents4 = "(Z)V";
	protected static string _getPhysicalDeviceDescription5 = "()Ljava/lang/String;";
	protected static string _getPhysicalDeviceName6 = "()Ljava/lang/String;";
	protected static string _checkHealth7 = "(I)V";
	protected static string _directIO8 = "(I[ILjava/lang/Object;)V";
	protected static string _getCheckHealthText9 = "()Ljava/lang/String;";
	protected static string _getDeviceControlDescription10 = "()Ljava/lang/String;";
	protected static string _getDeviceControlVersion11 = "()I";
	protected static string _getDeviceServiceDescription12 = "()Ljava/lang/String;";
	protected static string _getDeviceServiceVersion13 = "()I";
	protected static string _getFreezeEvents14 = "()Z";
	protected static string _claim15 = "(I)V";
	protected static string _setDeviceEnabled16 = "(Z)V";
	protected static string _getDeviceEnabled17 = "()Z";
	protected static string _getClaimed18 = "()Z";
	protected static JMethodID _mgetState0;
	protected static JMethodID _mclose1;
	protected static JMethodID _mopen2;
	protected static JMethodID _mrelease3;
	protected static JMethodID _msetFreezeEvents4;
	protected static JMethodID _mgetPhysicalDeviceDescription5;
	protected static JMethodID _mgetPhysicalDeviceName6;
	protected static JMethodID _mcheckHealth7;
	protected static JMethodID _mdirectIO8;
	protected static JMethodID _mgetCheckHealthText9;
	protected static JMethodID _mgetDeviceControlDescription10;
	protected static JMethodID _mgetDeviceControlVersion11;
	protected static JMethodID _mgetDeviceServiceDescription12;
	protected static JMethodID _mgetDeviceServiceVersion13;
	protected static JMethodID _mgetFreezeEvents14;
	protected static JMethodID _mclaim15;
	protected static JMethodID _msetDeviceEnabled16;
	protected static JMethodID _mgetDeviceEnabled17;
	protected static JMethodID _mgetClaimed18;

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
	public void setFreezeEvents(bool p0) 
	{
	    JNI.CallVoidMethod(this, _msetFreezeEvents4, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public string getPhysicalDeviceDescription() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetPhysicalDeviceDescription5);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret.GetString();
	}

	[DebuggerNonUserCode]
	public string getPhysicalDeviceName() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetPhysicalDeviceName6);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret.GetString();
	}

	[DebuggerNonUserCode]
	public void checkHealth(int p0) 
	{
	    JNI.CallVoidMethod(this, _mcheckHealth7, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void directIO(int p0,JObject p1,JObject p2) 
	{
	    JNI.CallVoidMethod(this, _mdirectIO8, new JValue(p0),new JValue(p1),new JValue(p2));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public string getCheckHealthText() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetCheckHealthText9);
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
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetDeviceControlDescription10);
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
	    int ret = JNI.CallMethod<int>(this, _mgetDeviceControlVersion11);
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
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetDeviceServiceDescription12);
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
	    int ret = JNI.CallMethod<int>(this, _mgetDeviceServiceVersion13);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getFreezeEvents() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetFreezeEvents14);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void claim(int p0) 
	{
	    JNI.CallVoidMethod(this, _mclaim15, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void setDeviceEnabled(bool p0) 
	{
	    JNI.CallVoidMethod(this, _msetDeviceEnabled16, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public bool getDeviceEnabled() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetDeviceEnabled17);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetClaimed18);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	static BaseControl()
	{
  	_class = JNI.FindClass("jpos/BaseControl");
  	if( _class == null ) throw new InvalidOperationException();
  	_mgetState0 = _class.GetMethodID("getState", _getState0);
  	if( _mgetState0.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mclose1 = _class.GetMethodID("close", _close1);
  	if( _mclose1.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mopen2 = _class.GetMethodID("open", _open2);
  	if( _mopen2.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mrelease3 = _class.GetMethodID("release", _release3);
  	if( _mrelease3.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetFreezeEvents4 = _class.GetMethodID("setFreezeEvents", _setFreezeEvents4);
  	if( _msetFreezeEvents4.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetPhysicalDeviceDescription5 = _class.GetMethodID("getPhysicalDeviceDescription", _getPhysicalDeviceDescription5);
  	if( _mgetPhysicalDeviceDescription5.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetPhysicalDeviceName6 = _class.GetMethodID("getPhysicalDeviceName", _getPhysicalDeviceName6);
  	if( _mgetPhysicalDeviceName6.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mcheckHealth7 = _class.GetMethodID("checkHealth", _checkHealth7);
  	if( _mcheckHealth7.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mdirectIO8 = _class.GetMethodID("directIO", _directIO8);
  	if( _mdirectIO8.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCheckHealthText9 = _class.GetMethodID("getCheckHealthText", _getCheckHealthText9);
  	if( _mgetCheckHealthText9.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetDeviceControlDescription10 = _class.GetMethodID("getDeviceControlDescription", _getDeviceControlDescription10);
  	if( _mgetDeviceControlDescription10.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetDeviceControlVersion11 = _class.GetMethodID("getDeviceControlVersion", _getDeviceControlVersion11);
  	if( _mgetDeviceControlVersion11.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetDeviceServiceDescription12 = _class.GetMethodID("getDeviceServiceDescription", _getDeviceServiceDescription12);
  	if( _mgetDeviceServiceDescription12.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetDeviceServiceVersion13 = _class.GetMethodID("getDeviceServiceVersion", _getDeviceServiceVersion13);
  	if( _mgetDeviceServiceVersion13.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetFreezeEvents14 = _class.GetMethodID("getFreezeEvents", _getFreezeEvents14);
  	if( _mgetFreezeEvents14.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mclaim15 = _class.GetMethodID("claim", _claim15);
  	if( _mclaim15.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetDeviceEnabled16 = _class.GetMethodID("setDeviceEnabled", _setDeviceEnabled16);
  	if( _msetDeviceEnabled16.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetDeviceEnabled17 = _class.GetMethodID("getDeviceEnabled", _getDeviceEnabled17);
  	if( _mgetDeviceEnabled17.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetClaimed18 = _class.GetMethodID("getClaimed", _getClaimed18);
  	if( _mgetClaimed18.Handle == IntPtr.Zero ) throw new InvalidOperationException();
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
	protected static string _setFreezeEvents4 = "(Z)V";
	protected static string _getPhysicalDeviceDescription5 = "()Ljava/lang/String;";
	protected static string _getPhysicalDeviceName6 = "()Ljava/lang/String;";
	protected static string _checkHealth7 = "(I)V";
	protected static string _directIO8 = "(I[ILjava/lang/Object;)V";
	protected static string _getCheckHealthText9 = "()Ljava/lang/String;";
	protected static string _getDeviceControlDescription10 = "()Ljava/lang/String;";
	protected static string _getDeviceControlVersion11 = "()I";
	protected static string _getDeviceServiceDescription12 = "()Ljava/lang/String;";
	protected static string _getDeviceServiceVersion13 = "()I";
	protected static string _getFreezeEvents14 = "()Z";
	protected static string _claim15 = "(I)V";
	protected static string _setDeviceEnabled16 = "(Z)V";
	protected static string _getDeviceEnabled17 = "()Z";
	protected static string _getClaimed18 = "()Z";
	protected static JMethodID _minit0;
	protected static JMethodID _mgetState0;
	protected static JMethodID _mclose1;
	protected static JMethodID _mopen2;
	protected static JMethodID _mrelease3;
	protected static JMethodID _msetFreezeEvents4;
	protected static JMethodID _mgetPhysicalDeviceDescription5;
	protected static JMethodID _mgetPhysicalDeviceName6;
	protected static JMethodID _mcheckHealth7;
	protected static JMethodID _mdirectIO8;
	protected static JMethodID _mgetCheckHealthText9;
	protected static JMethodID _mgetDeviceControlDescription10;
	protected static JMethodID _mgetDeviceControlVersion11;
	protected static JMethodID _mgetDeviceServiceDescription12;
	protected static JMethodID _mgetDeviceServiceVersion13;
	protected static JMethodID _mgetFreezeEvents14;
	protected static JMethodID _mclaim15;
	protected static JMethodID _msetDeviceEnabled16;
	protected static JMethodID _mgetDeviceEnabled17;
	protected static JMethodID _mgetClaimed18;

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
	public void setFreezeEvents(bool p0) 
	{
	    JNI.CallVoidMethod(this, _msetFreezeEvents4, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public string getPhysicalDeviceDescription() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetPhysicalDeviceDescription5);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret.GetString();
	}

	[DebuggerNonUserCode]
	public string getPhysicalDeviceName() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetPhysicalDeviceName6);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret.GetString();
	}

	[DebuggerNonUserCode]
	public void checkHealth(int p0) 
	{
	    JNI.CallVoidMethod(this, _mcheckHealth7, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void directIO(int p0,JObject p1,JObject p2) 
	{
	    JNI.CallVoidMethod(this, _mdirectIO8, new JValue(p0),new JValue(p1),new JValue(p2));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public string getCheckHealthText() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetCheckHealthText9);
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
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetDeviceControlDescription10);
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
	    int ret = JNI.CallMethod<int>(this, _mgetDeviceControlVersion11);
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
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetDeviceServiceDescription12);
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
	    int ret = JNI.CallMethod<int>(this, _mgetDeviceServiceVersion13);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getFreezeEvents() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetFreezeEvents14);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void claim(int p0) 
	{
	    JNI.CallVoidMethod(this, _mclaim15, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void setDeviceEnabled(bool p0) 
	{
	    JNI.CallVoidMethod(this, _msetDeviceEnabled16, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public bool getDeviceEnabled() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetDeviceEnabled17);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetClaimed18);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	static BaseJposControl()
	{
  	_class = JNI.FindClass("jpos/BaseJposControl");
  	if( _class == null ) throw new InvalidOperationException();
  	_minit0 = _class.GetMethodID("<init>", _init0);
  	if( _minit0.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetState0 = _class.GetMethodID("getState", _getState0);
  	if( _mgetState0.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mclose1 = _class.GetMethodID("close", _close1);
  	if( _mclose1.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mopen2 = _class.GetMethodID("open", _open2);
  	if( _mopen2.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mrelease3 = _class.GetMethodID("release", _release3);
  	if( _mrelease3.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetFreezeEvents4 = _class.GetMethodID("setFreezeEvents", _setFreezeEvents4);
  	if( _msetFreezeEvents4.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetPhysicalDeviceDescription5 = _class.GetMethodID("getPhysicalDeviceDescription", _getPhysicalDeviceDescription5);
  	if( _mgetPhysicalDeviceDescription5.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetPhysicalDeviceName6 = _class.GetMethodID("getPhysicalDeviceName", _getPhysicalDeviceName6);
  	if( _mgetPhysicalDeviceName6.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mcheckHealth7 = _class.GetMethodID("checkHealth", _checkHealth7);
  	if( _mcheckHealth7.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mdirectIO8 = _class.GetMethodID("directIO", _directIO8);
  	if( _mdirectIO8.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCheckHealthText9 = _class.GetMethodID("getCheckHealthText", _getCheckHealthText9);
  	if( _mgetCheckHealthText9.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetDeviceControlDescription10 = _class.GetMethodID("getDeviceControlDescription", _getDeviceControlDescription10);
  	if( _mgetDeviceControlDescription10.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetDeviceControlVersion11 = _class.GetMethodID("getDeviceControlVersion", _getDeviceControlVersion11);
  	if( _mgetDeviceControlVersion11.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetDeviceServiceDescription12 = _class.GetMethodID("getDeviceServiceDescription", _getDeviceServiceDescription12);
  	if( _mgetDeviceServiceDescription12.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetDeviceServiceVersion13 = _class.GetMethodID("getDeviceServiceVersion", _getDeviceServiceVersion13);
  	if( _mgetDeviceServiceVersion13.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetFreezeEvents14 = _class.GetMethodID("getFreezeEvents", _getFreezeEvents14);
  	if( _mgetFreezeEvents14.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mclaim15 = _class.GetMethodID("claim", _claim15);
  	if( _mclaim15.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetDeviceEnabled16 = _class.GetMethodID("setDeviceEnabled", _setDeviceEnabled16);
  	if( _msetDeviceEnabled16.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetDeviceEnabled17 = _class.GetMethodID("getDeviceEnabled", _getDeviceEnabled17);
  	if( _mgetDeviceEnabled17.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetClaimed18 = _class.GetMethodID("getClaimed", _getClaimed18);
  	if( _mgetClaimed18.Handle == IntPtr.Zero ) throw new InvalidOperationException();
	}
}
}

namespace jpos {
class Scanner : jpos.BaseJposControl {
	protected static JClass _class;
	protected static string _init0 = "()V";
	protected static string _getCapStatisticsReporting0 = "()Z";
	protected static string _getCapUpdateStatistics1 = "()Z";
	protected static string _getCapCompareFirmwareVersion2 = "()Z";
	protected static string _getCapUpdateFirmware3 = "()Z";
	protected static string _getAutoDisable4 = "()Z";
	protected static string _setAutoDisable5 = "(Z)V";
	protected static string _getDataCount6 = "()I";
	protected static string _getDataEventEnabled7 = "()Z";
	protected static string _getDecodeData8 = "()Z";
	protected static string _setDecodeData9 = "(Z)V";
	protected static string _getScanData10 = "()[B";
	protected static string _getScanDataLabel11 = "()[B";
	protected static string _getScanDataType12 = "()I";
	protected static string _getPowerNotify13 = "()I";
	protected static string _setPowerNotify14 = "(I)V";
	protected static string _getPowerState15 = "()I";
	protected static string _clearInput16 = "()V";
	protected static string _resetStatistics17 = "(Ljava/lang/String;)V";
	protected static string _retrieveStatistics18 = "([Ljava/lang/String;)V";
	protected static string _updateStatistics19 = "(Ljava/lang/String;)V";
	protected static string _compareFirmwareVersion20 = "(Ljava/lang/String;[I)V";
	protected static string _updateFirmware21 = "(Ljava/lang/String;)V";
	protected static string _clearInputProperties22 = "()V";
	protected static string _addDirectIOListener23 = "(Ljpos/events/DirectIOListener;)V";
	protected static string _removeDirectIOListener24 = "(Ljpos/events/DirectIOListener;)V";
	protected static string _getCapPowerReporting25 = "()I";
	protected static string _setDataEventEnabled26 = "(Z)V";
	protected static string _addDataListener27 = "(Ljpos/events/DataListener;)V";
	protected static string _addErrorListener28 = "(Ljpos/events/ErrorListener;)V";
	protected static string _addStatusUpdateListener29 = "(Ljpos/events/StatusUpdateListener;)V";
	protected static string _removeDataListener30 = "(Ljpos/events/DataListener;)V";
	protected static string _removeErrorListener31 = "(Ljpos/events/ErrorListener;)V";
	protected static string _removeStatusUpdateListener32 = "(Ljpos/events/StatusUpdateListener;)V";
	protected static JMethodID _minit0;
	protected static JMethodID _mgetCapStatisticsReporting0;
	protected static JMethodID _mgetCapUpdateStatistics1;
	protected static JMethodID _mgetCapCompareFirmwareVersion2;
	protected static JMethodID _mgetCapUpdateFirmware3;
	protected static JMethodID _mgetAutoDisable4;
	protected static JMethodID _msetAutoDisable5;
	protected static JMethodID _mgetDataCount6;
	protected static JMethodID _mgetDataEventEnabled7;
	protected static JMethodID _mgetDecodeData8;
	protected static JMethodID _msetDecodeData9;
	protected static JMethodID _mgetScanData10;
	protected static JMethodID _mgetScanDataLabel11;
	protected static JMethodID _mgetScanDataType12;
	protected static JMethodID _mgetPowerNotify13;
	protected static JMethodID _msetPowerNotify14;
	protected static JMethodID _mgetPowerState15;
	protected static JMethodID _mclearInput16;
	protected static JMethodID _mresetStatistics17;
	protected static JMethodID _mretrieveStatistics18;
	protected static JMethodID _mupdateStatistics19;
	protected static JMethodID _mcompareFirmwareVersion20;
	protected static JMethodID _mupdateFirmware21;
	protected static JMethodID _mclearInputProperties22;
	protected static JMethodID _maddDirectIOListener23;
	protected static JMethodID _mremoveDirectIOListener24;
	protected static JMethodID _mgetCapPowerReporting25;
	protected static JMethodID _msetDataEventEnabled26;
	protected static JMethodID _maddDataListener27;
	protected static JMethodID _maddErrorListener28;
	protected static JMethodID _maddStatusUpdateListener29;
	protected static JMethodID _mremoveDataListener30;
	protected static JMethodID _mremoveErrorListener31;
	protected static JMethodID _mremoveStatusUpdateListener32;

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
	public bool getCapStatisticsReporting() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapStatisticsReporting0);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapUpdateStatistics1);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapCompareFirmwareVersion2);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapUpdateFirmware3);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getAutoDisable() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetAutoDisable4);
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
	    JNI.CallVoidMethod(this, _msetAutoDisable5, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getDataCount() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetDataCount6);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getDataEventEnabled() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetDataEventEnabled7);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getDecodeData() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetDecodeData8);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void setDecodeData(bool p0) 
	{
	    JNI.CallVoidMethod(this, _msetDecodeData9, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public byte[] getScanData() 
	{
	    JArray<sbyte> ret = JNI.CallObjectMethod<JArray<sbyte>>(this, _mgetScanData10);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return Array.ConvertAll(ret.GetElements(), (a) => (byte)a);
	}

	[DebuggerNonUserCode]
	public byte[] getScanDataLabel() 
	{
	    JArray<sbyte> ret = JNI.CallObjectMethod<JArray<sbyte>>(this, _mgetScanDataLabel11);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return Array.ConvertAll(ret.GetElements(), (a) => (byte)a);
	}

	[DebuggerNonUserCode]
	public int getScanDataType() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetScanDataType12);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
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
	public void setPowerNotify(int p0) 
	{
	    JNI.CallVoidMethod(this, _msetPowerNotify14, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getPowerState() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetPowerState15);
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
	    JNI.CallVoidMethod(this, _mclearInput16);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void resetStatistics(string p0) 
	{
	    JNI.CallVoidMethod(this, _mresetStatistics17, new JValue(JNI.NewString(p0)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void retrieveStatistics(JObject p0) 
	{
	    JNI.CallVoidMethod(this, _mretrieveStatistics18, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void updateStatistics(string p0) 
	{
	    JNI.CallVoidMethod(this, _mupdateStatistics19, new JValue(JNI.NewString(p0)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void compareFirmwareVersion(string p0,JObject p1) 
	{
	    JNI.CallVoidMethod(this, _mcompareFirmwareVersion20, new JValue(JNI.NewString(p0)),new JValue(p1));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void updateFirmware(string p0) 
	{
	    JNI.CallVoidMethod(this, _mupdateFirmware21, new JValue(JNI.NewString(p0)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void clearInputProperties() 
	{
	    JNI.CallVoidMethod(this, _mclearInputProperties22);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void addDirectIOListener(jpos.events.DirectIOListener p0) 
	{
	    JNI.CallVoidMethod(this, _maddDirectIOListener23, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void removeDirectIOListener(jpos.events.DirectIOListener p0) 
	{
	    JNI.CallVoidMethod(this, _mremoveDirectIOListener24, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getCapPowerReporting() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetCapPowerReporting25);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void setDataEventEnabled(bool p0) 
	{
	    JNI.CallVoidMethod(this, _msetDataEventEnabled26, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void addDataListener(jpos.events.DataListener p0) 
	{
	    JNI.CallVoidMethod(this, _maddDataListener27, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void addErrorListener(jpos.events.ErrorListener p0) 
	{
	    JNI.CallVoidMethod(this, _maddErrorListener28, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void addStatusUpdateListener(jpos.events.StatusUpdateListener p0) 
	{
	    JNI.CallVoidMethod(this, _maddStatusUpdateListener29, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void removeDataListener(jpos.events.DataListener p0) 
	{
	    JNI.CallVoidMethod(this, _mremoveDataListener30, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void removeErrorListener(jpos.events.ErrorListener p0) 
	{
	    JNI.CallVoidMethod(this, _mremoveErrorListener31, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void removeStatusUpdateListener(jpos.events.StatusUpdateListener p0) 
	{
	    JNI.CallVoidMethod(this, _mremoveStatusUpdateListener32, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	static Scanner()
	{
  	_class = JNI.FindClass("jpos/Scanner");
  	if( _class == null ) throw new InvalidOperationException();
  	_minit0 = _class.GetMethodID("<init>", _init0);
  	if( _minit0.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapStatisticsReporting0 = _class.GetMethodID("getCapStatisticsReporting", _getCapStatisticsReporting0);
  	if( _mgetCapStatisticsReporting0.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapUpdateStatistics1 = _class.GetMethodID("getCapUpdateStatistics", _getCapUpdateStatistics1);
  	if( _mgetCapUpdateStatistics1.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapCompareFirmwareVersion2 = _class.GetMethodID("getCapCompareFirmwareVersion", _getCapCompareFirmwareVersion2);
  	if( _mgetCapCompareFirmwareVersion2.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapUpdateFirmware3 = _class.GetMethodID("getCapUpdateFirmware", _getCapUpdateFirmware3);
  	if( _mgetCapUpdateFirmware3.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetAutoDisable4 = _class.GetMethodID("getAutoDisable", _getAutoDisable4);
  	if( _mgetAutoDisable4.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetAutoDisable5 = _class.GetMethodID("setAutoDisable", _setAutoDisable5);
  	if( _msetAutoDisable5.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetDataCount6 = _class.GetMethodID("getDataCount", _getDataCount6);
  	if( _mgetDataCount6.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetDataEventEnabled7 = _class.GetMethodID("getDataEventEnabled", _getDataEventEnabled7);
  	if( _mgetDataEventEnabled7.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetDecodeData8 = _class.GetMethodID("getDecodeData", _getDecodeData8);
  	if( _mgetDecodeData8.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetDecodeData9 = _class.GetMethodID("setDecodeData", _setDecodeData9);
  	if( _msetDecodeData9.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetScanData10 = _class.GetMethodID("getScanData", _getScanData10);
  	if( _mgetScanData10.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetScanDataLabel11 = _class.GetMethodID("getScanDataLabel", _getScanDataLabel11);
  	if( _mgetScanDataLabel11.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetScanDataType12 = _class.GetMethodID("getScanDataType", _getScanDataType12);
  	if( _mgetScanDataType12.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetPowerNotify13 = _class.GetMethodID("getPowerNotify", _getPowerNotify13);
  	if( _mgetPowerNotify13.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetPowerNotify14 = _class.GetMethodID("setPowerNotify", _setPowerNotify14);
  	if( _msetPowerNotify14.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetPowerState15 = _class.GetMethodID("getPowerState", _getPowerState15);
  	if( _mgetPowerState15.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mclearInput16 = _class.GetMethodID("clearInput", _clearInput16);
  	if( _mclearInput16.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mresetStatistics17 = _class.GetMethodID("resetStatistics", _resetStatistics17);
  	if( _mresetStatistics17.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mretrieveStatistics18 = _class.GetMethodID("retrieveStatistics", _retrieveStatistics18);
  	if( _mretrieveStatistics18.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mupdateStatistics19 = _class.GetMethodID("updateStatistics", _updateStatistics19);
  	if( _mupdateStatistics19.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mcompareFirmwareVersion20 = _class.GetMethodID("compareFirmwareVersion", _compareFirmwareVersion20);
  	if( _mcompareFirmwareVersion20.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mupdateFirmware21 = _class.GetMethodID("updateFirmware", _updateFirmware21);
  	if( _mupdateFirmware21.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mclearInputProperties22 = _class.GetMethodID("clearInputProperties", _clearInputProperties22);
  	if( _mclearInputProperties22.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_maddDirectIOListener23 = _class.GetMethodID("addDirectIOListener", _addDirectIOListener23);
  	if( _maddDirectIOListener23.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mremoveDirectIOListener24 = _class.GetMethodID("removeDirectIOListener", _removeDirectIOListener24);
  	if( _mremoveDirectIOListener24.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapPowerReporting25 = _class.GetMethodID("getCapPowerReporting", _getCapPowerReporting25);
  	if( _mgetCapPowerReporting25.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetDataEventEnabled26 = _class.GetMethodID("setDataEventEnabled", _setDataEventEnabled26);
  	if( _msetDataEventEnabled26.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_maddDataListener27 = _class.GetMethodID("addDataListener", _addDataListener27);
  	if( _maddDataListener27.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_maddErrorListener28 = _class.GetMethodID("addErrorListener", _addErrorListener28);
  	if( _maddErrorListener28.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_maddStatusUpdateListener29 = _class.GetMethodID("addStatusUpdateListener", _addStatusUpdateListener29);
  	if( _maddStatusUpdateListener29.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mremoveDataListener30 = _class.GetMethodID("removeDataListener", _removeDataListener30);
  	if( _mremoveDataListener30.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mremoveErrorListener31 = _class.GetMethodID("removeErrorListener", _removeErrorListener31);
  	if( _mremoveErrorListener31.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mremoveStatusUpdateListener32 = _class.GetMethodID("removeStatusUpdateListener", _removeStatusUpdateListener32);
  	if( _mremoveStatusUpdateListener32.Handle == IntPtr.Zero ) throw new InvalidOperationException();
	}
}
}

namespace jpos {
class CashDrawer : jpos.BaseJposControl {
	protected static JClass _class;
	protected static string _init0 = "()V";
	protected static string _getCapStatisticsReporting0 = "()Z";
	protected static string _getCapUpdateStatistics1 = "()Z";
	protected static string _getCapCompareFirmwareVersion2 = "()Z";
	protected static string _getCapUpdateFirmware3 = "()Z";
	protected static string _getPowerNotify4 = "()I";
	protected static string _setPowerNotify5 = "(I)V";
	protected static string _getPowerState6 = "()I";
	protected static string _resetStatistics7 = "(Ljava/lang/String;)V";
	protected static string _retrieveStatistics8 = "([Ljava/lang/String;)V";
	protected static string _updateStatistics9 = "(Ljava/lang/String;)V";
	protected static string _compareFirmwareVersion10 = "(Ljava/lang/String;[I)V";
	protected static string _updateFirmware11 = "(Ljava/lang/String;)V";
	protected static string _addDirectIOListener12 = "(Ljpos/events/DirectIOListener;)V";
	protected static string _removeDirectIOListener13 = "(Ljpos/events/DirectIOListener;)V";
	protected static string _getCapPowerReporting14 = "()I";
	protected static string _addStatusUpdateListener15 = "(Ljpos/events/StatusUpdateListener;)V";
	protected static string _removeStatusUpdateListener16 = "(Ljpos/events/StatusUpdateListener;)V";
	protected static string _getCapStatus17 = "()Z";
	protected static string _getDrawerOpened18 = "()Z";
	protected static string _openDrawer19 = "()V";
	protected static string _waitForDrawerClose20 = "(IIII)V";
	protected static string _getCapStatusMultiDrawerDetect21 = "()Z";
	protected static JMethodID _minit0;
	protected static JMethodID _mgetCapStatisticsReporting0;
	protected static JMethodID _mgetCapUpdateStatistics1;
	protected static JMethodID _mgetCapCompareFirmwareVersion2;
	protected static JMethodID _mgetCapUpdateFirmware3;
	protected static JMethodID _mgetPowerNotify4;
	protected static JMethodID _msetPowerNotify5;
	protected static JMethodID _mgetPowerState6;
	protected static JMethodID _mresetStatistics7;
	protected static JMethodID _mretrieveStatistics8;
	protected static JMethodID _mupdateStatistics9;
	protected static JMethodID _mcompareFirmwareVersion10;
	protected static JMethodID _mupdateFirmware11;
	protected static JMethodID _maddDirectIOListener12;
	protected static JMethodID _mremoveDirectIOListener13;
	protected static JMethodID _mgetCapPowerReporting14;
	protected static JMethodID _maddStatusUpdateListener15;
	protected static JMethodID _mremoveStatusUpdateListener16;
	protected static JMethodID _mgetCapStatus17;
	protected static JMethodID _mgetDrawerOpened18;
	protected static JMethodID _mopenDrawer19;
	protected static JMethodID _mwaitForDrawerClose20;
	protected static JMethodID _mgetCapStatusMultiDrawerDetect21;

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
	public bool getCapStatisticsReporting() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapStatisticsReporting0);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapUpdateStatistics1);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapCompareFirmwareVersion2);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapUpdateFirmware3);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public int getPowerNotify() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetPowerNotify4);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void setPowerNotify(int p0) 
	{
	    JNI.CallVoidMethod(this, _msetPowerNotify5, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getPowerState() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetPowerState6);
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
	    JNI.CallVoidMethod(this, _mresetStatistics7, new JValue(JNI.NewString(p0)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void retrieveStatistics(JObject p0) 
	{
	    JNI.CallVoidMethod(this, _mretrieveStatistics8, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void updateStatistics(string p0) 
	{
	    JNI.CallVoidMethod(this, _mupdateStatistics9, new JValue(JNI.NewString(p0)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void compareFirmwareVersion(string p0,JObject p1) 
	{
	    JNI.CallVoidMethod(this, _mcompareFirmwareVersion10, new JValue(JNI.NewString(p0)),new JValue(p1));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void updateFirmware(string p0) 
	{
	    JNI.CallVoidMethod(this, _mupdateFirmware11, new JValue(JNI.NewString(p0)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void addDirectIOListener(jpos.events.DirectIOListener p0) 
	{
	    JNI.CallVoidMethod(this, _maddDirectIOListener12, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void removeDirectIOListener(jpos.events.DirectIOListener p0) 
	{
	    JNI.CallVoidMethod(this, _mremoveDirectIOListener13, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getCapPowerReporting() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetCapPowerReporting14);
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
	    JNI.CallVoidMethod(this, _maddStatusUpdateListener15, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void removeStatusUpdateListener(jpos.events.StatusUpdateListener p0) 
	{
	    JNI.CallVoidMethod(this, _mremoveStatusUpdateListener16, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public bool getCapStatus() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapStatus17);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getDrawerOpened() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetDrawerOpened18);
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
	    JNI.CallVoidMethod(this, _mopenDrawer19);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
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
	public bool getCapStatusMultiDrawerDetect() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapStatusMultiDrawerDetect21);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	static CashDrawer()
	{
  	_class = JNI.FindClass("jpos/CashDrawer");
  	if( _class == null ) throw new InvalidOperationException();
  	_minit0 = _class.GetMethodID("<init>", _init0);
  	if( _minit0.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapStatisticsReporting0 = _class.GetMethodID("getCapStatisticsReporting", _getCapStatisticsReporting0);
  	if( _mgetCapStatisticsReporting0.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapUpdateStatistics1 = _class.GetMethodID("getCapUpdateStatistics", _getCapUpdateStatistics1);
  	if( _mgetCapUpdateStatistics1.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapCompareFirmwareVersion2 = _class.GetMethodID("getCapCompareFirmwareVersion", _getCapCompareFirmwareVersion2);
  	if( _mgetCapCompareFirmwareVersion2.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapUpdateFirmware3 = _class.GetMethodID("getCapUpdateFirmware", _getCapUpdateFirmware3);
  	if( _mgetCapUpdateFirmware3.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetPowerNotify4 = _class.GetMethodID("getPowerNotify", _getPowerNotify4);
  	if( _mgetPowerNotify4.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetPowerNotify5 = _class.GetMethodID("setPowerNotify", _setPowerNotify5);
  	if( _msetPowerNotify5.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetPowerState6 = _class.GetMethodID("getPowerState", _getPowerState6);
  	if( _mgetPowerState6.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mresetStatistics7 = _class.GetMethodID("resetStatistics", _resetStatistics7);
  	if( _mresetStatistics7.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mretrieveStatistics8 = _class.GetMethodID("retrieveStatistics", _retrieveStatistics8);
  	if( _mretrieveStatistics8.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mupdateStatistics9 = _class.GetMethodID("updateStatistics", _updateStatistics9);
  	if( _mupdateStatistics9.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mcompareFirmwareVersion10 = _class.GetMethodID("compareFirmwareVersion", _compareFirmwareVersion10);
  	if( _mcompareFirmwareVersion10.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mupdateFirmware11 = _class.GetMethodID("updateFirmware", _updateFirmware11);
  	if( _mupdateFirmware11.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_maddDirectIOListener12 = _class.GetMethodID("addDirectIOListener", _addDirectIOListener12);
  	if( _maddDirectIOListener12.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mremoveDirectIOListener13 = _class.GetMethodID("removeDirectIOListener", _removeDirectIOListener13);
  	if( _mremoveDirectIOListener13.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapPowerReporting14 = _class.GetMethodID("getCapPowerReporting", _getCapPowerReporting14);
  	if( _mgetCapPowerReporting14.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_maddStatusUpdateListener15 = _class.GetMethodID("addStatusUpdateListener", _addStatusUpdateListener15);
  	if( _maddStatusUpdateListener15.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mremoveStatusUpdateListener16 = _class.GetMethodID("removeStatusUpdateListener", _removeStatusUpdateListener16);
  	if( _mremoveStatusUpdateListener16.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapStatus17 = _class.GetMethodID("getCapStatus", _getCapStatus17);
  	if( _mgetCapStatus17.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetDrawerOpened18 = _class.GetMethodID("getDrawerOpened", _getDrawerOpened18);
  	if( _mgetDrawerOpened18.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mopenDrawer19 = _class.GetMethodID("openDrawer", _openDrawer19);
  	if( _mopenDrawer19.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mwaitForDrawerClose20 = _class.GetMethodID("waitForDrawerClose", _waitForDrawerClose20);
  	if( _mwaitForDrawerClose20.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapStatusMultiDrawerDetect21 = _class.GetMethodID("getCapStatusMultiDrawerDetect", _getCapStatusMultiDrawerDetect21);
  	if( _mgetCapStatusMultiDrawerDetect21.Handle == IntPtr.Zero ) throw new InvalidOperationException();
	}
}
}

namespace jpos {
class CoinDispenser : jpos.BaseJposControl {
	protected static JClass _class;
	protected static string _init0 = "()V";
	protected static string _getCapStatisticsReporting0 = "()Z";
	protected static string _getCapUpdateStatistics1 = "()Z";
	protected static string _getCapCompareFirmwareVersion2 = "()Z";
	protected static string _getCapUpdateFirmware3 = "()Z";
	protected static string _getPowerNotify4 = "()I";
	protected static string _setPowerNotify5 = "(I)V";
	protected static string _getPowerState6 = "()I";
	protected static string _resetStatistics7 = "(Ljava/lang/String;)V";
	protected static string _retrieveStatistics8 = "([Ljava/lang/String;)V";
	protected static string _updateStatistics9 = "(Ljava/lang/String;)V";
	protected static string _compareFirmwareVersion10 = "(Ljava/lang/String;[I)V";
	protected static string _updateFirmware11 = "(Ljava/lang/String;)V";
	protected static string _addDirectIOListener12 = "(Ljpos/events/DirectIOListener;)V";
	protected static string _removeDirectIOListener13 = "(Ljpos/events/DirectIOListener;)V";
	protected static string _getCapPowerReporting14 = "()I";
	protected static string _addStatusUpdateListener15 = "(Ljpos/events/StatusUpdateListener;)V";
	protected static string _removeStatusUpdateListener16 = "(Ljpos/events/StatusUpdateListener;)V";
	protected static string _getCapEmptySensor17 = "()Z";
	protected static string _getCapJamSensor18 = "()Z";
	protected static string _getCapNearEmptySensor19 = "()Z";
	protected static string _getDispenserStatus20 = "()I";
	protected static string _dispenseChange21 = "(I)V";
	protected static string _adjustCashCounts22 = "(Ljava/lang/String;)V";
	protected static string _readCashCounts23 = "([Ljava/lang/String;[Z)V";
	protected static JMethodID _minit0;
	protected static JMethodID _mgetCapStatisticsReporting0;
	protected static JMethodID _mgetCapUpdateStatistics1;
	protected static JMethodID _mgetCapCompareFirmwareVersion2;
	protected static JMethodID _mgetCapUpdateFirmware3;
	protected static JMethodID _mgetPowerNotify4;
	protected static JMethodID _msetPowerNotify5;
	protected static JMethodID _mgetPowerState6;
	protected static JMethodID _mresetStatistics7;
	protected static JMethodID _mretrieveStatistics8;
	protected static JMethodID _mupdateStatistics9;
	protected static JMethodID _mcompareFirmwareVersion10;
	protected static JMethodID _mupdateFirmware11;
	protected static JMethodID _maddDirectIOListener12;
	protected static JMethodID _mremoveDirectIOListener13;
	protected static JMethodID _mgetCapPowerReporting14;
	protected static JMethodID _maddStatusUpdateListener15;
	protected static JMethodID _mremoveStatusUpdateListener16;
	protected static JMethodID _mgetCapEmptySensor17;
	protected static JMethodID _mgetCapJamSensor18;
	protected static JMethodID _mgetCapNearEmptySensor19;
	protected static JMethodID _mgetDispenserStatus20;
	protected static JMethodID _mdispenseChange21;
	protected static JMethodID _madjustCashCounts22;
	protected static JMethodID _mreadCashCounts23;

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
	public bool getCapStatisticsReporting() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapStatisticsReporting0);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapUpdateStatistics1);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapCompareFirmwareVersion2);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapUpdateFirmware3);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public int getPowerNotify() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetPowerNotify4);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void setPowerNotify(int p0) 
	{
	    JNI.CallVoidMethod(this, _msetPowerNotify5, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getPowerState() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetPowerState6);
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
	    JNI.CallVoidMethod(this, _mresetStatistics7, new JValue(JNI.NewString(p0)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void retrieveStatistics(JObject p0) 
	{
	    JNI.CallVoidMethod(this, _mretrieveStatistics8, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void updateStatistics(string p0) 
	{
	    JNI.CallVoidMethod(this, _mupdateStatistics9, new JValue(JNI.NewString(p0)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void compareFirmwareVersion(string p0,JObject p1) 
	{
	    JNI.CallVoidMethod(this, _mcompareFirmwareVersion10, new JValue(JNI.NewString(p0)),new JValue(p1));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void updateFirmware(string p0) 
	{
	    JNI.CallVoidMethod(this, _mupdateFirmware11, new JValue(JNI.NewString(p0)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void addDirectIOListener(jpos.events.DirectIOListener p0) 
	{
	    JNI.CallVoidMethod(this, _maddDirectIOListener12, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void removeDirectIOListener(jpos.events.DirectIOListener p0) 
	{
	    JNI.CallVoidMethod(this, _mremoveDirectIOListener13, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getCapPowerReporting() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetCapPowerReporting14);
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
	    JNI.CallVoidMethod(this, _maddStatusUpdateListener15, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void removeStatusUpdateListener(jpos.events.StatusUpdateListener p0) 
	{
	    JNI.CallVoidMethod(this, _mremoveStatusUpdateListener16, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public bool getCapEmptySensor() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapEmptySensor17);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapJamSensor18);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapNearEmptySensor() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapNearEmptySensor19);
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
	    int ret = JNI.CallMethod<int>(this, _mgetDispenserStatus20);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void dispenseChange(int p0) 
	{
	    JNI.CallVoidMethod(this, _mdispenseChange21, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void adjustCashCounts(string p0) 
	{
	    JNI.CallVoidMethod(this, _madjustCashCounts22, new JValue(JNI.NewString(p0)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void readCashCounts(JObject p0,JObject p1) 
	{
	    JNI.CallVoidMethod(this, _mreadCashCounts23, new JValue(p0),new JValue(p1));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	static CoinDispenser()
	{
  	_class = JNI.FindClass("jpos/CoinDispenser");
  	if( _class == null ) throw new InvalidOperationException();
  	_minit0 = _class.GetMethodID("<init>", _init0);
  	if( _minit0.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapStatisticsReporting0 = _class.GetMethodID("getCapStatisticsReporting", _getCapStatisticsReporting0);
  	if( _mgetCapStatisticsReporting0.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapUpdateStatistics1 = _class.GetMethodID("getCapUpdateStatistics", _getCapUpdateStatistics1);
  	if( _mgetCapUpdateStatistics1.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapCompareFirmwareVersion2 = _class.GetMethodID("getCapCompareFirmwareVersion", _getCapCompareFirmwareVersion2);
  	if( _mgetCapCompareFirmwareVersion2.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapUpdateFirmware3 = _class.GetMethodID("getCapUpdateFirmware", _getCapUpdateFirmware3);
  	if( _mgetCapUpdateFirmware3.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetPowerNotify4 = _class.GetMethodID("getPowerNotify", _getPowerNotify4);
  	if( _mgetPowerNotify4.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetPowerNotify5 = _class.GetMethodID("setPowerNotify", _setPowerNotify5);
  	if( _msetPowerNotify5.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetPowerState6 = _class.GetMethodID("getPowerState", _getPowerState6);
  	if( _mgetPowerState6.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mresetStatistics7 = _class.GetMethodID("resetStatistics", _resetStatistics7);
  	if( _mresetStatistics7.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mretrieveStatistics8 = _class.GetMethodID("retrieveStatistics", _retrieveStatistics8);
  	if( _mretrieveStatistics8.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mupdateStatistics9 = _class.GetMethodID("updateStatistics", _updateStatistics9);
  	if( _mupdateStatistics9.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mcompareFirmwareVersion10 = _class.GetMethodID("compareFirmwareVersion", _compareFirmwareVersion10);
  	if( _mcompareFirmwareVersion10.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mupdateFirmware11 = _class.GetMethodID("updateFirmware", _updateFirmware11);
  	if( _mupdateFirmware11.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_maddDirectIOListener12 = _class.GetMethodID("addDirectIOListener", _addDirectIOListener12);
  	if( _maddDirectIOListener12.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mremoveDirectIOListener13 = _class.GetMethodID("removeDirectIOListener", _removeDirectIOListener13);
  	if( _mremoveDirectIOListener13.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapPowerReporting14 = _class.GetMethodID("getCapPowerReporting", _getCapPowerReporting14);
  	if( _mgetCapPowerReporting14.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_maddStatusUpdateListener15 = _class.GetMethodID("addStatusUpdateListener", _addStatusUpdateListener15);
  	if( _maddStatusUpdateListener15.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mremoveStatusUpdateListener16 = _class.GetMethodID("removeStatusUpdateListener", _removeStatusUpdateListener16);
  	if( _mremoveStatusUpdateListener16.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapEmptySensor17 = _class.GetMethodID("getCapEmptySensor", _getCapEmptySensor17);
  	if( _mgetCapEmptySensor17.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapJamSensor18 = _class.GetMethodID("getCapJamSensor", _getCapJamSensor18);
  	if( _mgetCapJamSensor18.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapNearEmptySensor19 = _class.GetMethodID("getCapNearEmptySensor", _getCapNearEmptySensor19);
  	if( _mgetCapNearEmptySensor19.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetDispenserStatus20 = _class.GetMethodID("getDispenserStatus", _getDispenserStatus20);
  	if( _mgetDispenserStatus20.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mdispenseChange21 = _class.GetMethodID("dispenseChange", _dispenseChange21);
  	if( _mdispenseChange21.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_madjustCashCounts22 = _class.GetMethodID("adjustCashCounts", _adjustCashCounts22);
  	if( _madjustCashCounts22.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mreadCashCounts23 = _class.GetMethodID("readCashCounts", _readCashCounts23);
  	if( _mreadCashCounts23.Handle == IntPtr.Zero ) throw new InvalidOperationException();
	}
}
}

namespace jpos {
class PINPad : jpos.BaseJposControl {
	protected static JClass _class;
	protected static string _init0 = "()V";
	protected static string _getCapStatisticsReporting0 = "()Z";
	protected static string _getCapUpdateStatistics1 = "()Z";
	protected static string _getCapCompareFirmwareVersion2 = "()Z";
	protected static string _getCapUpdateFirmware3 = "()Z";
	protected static string _getDataCount4 = "()I";
	protected static string _getDataEventEnabled5 = "()Z";
	protected static string _getPowerNotify6 = "()I";
	protected static string _setPowerNotify7 = "(I)V";
	protected static string _getPowerState8 = "()I";
	protected static string _clearInput9 = "()V";
	protected static string _resetStatistics10 = "(Ljava/lang/String;)V";
	protected static string _retrieveStatistics11 = "([Ljava/lang/String;)V";
	protected static string _updateStatistics12 = "(Ljava/lang/String;)V";
	protected static string _compareFirmwareVersion13 = "(Ljava/lang/String;[I)V";
	protected static string _updateFirmware14 = "(Ljava/lang/String;)V";
	protected static string _clearInputProperties15 = "()V";
	protected static string _addDirectIOListener16 = "(Ljpos/events/DirectIOListener;)V";
	protected static string _removeDirectIOListener17 = "(Ljpos/events/DirectIOListener;)V";
	protected static string _getCapPowerReporting18 = "()I";
	protected static string _setDataEventEnabled19 = "(Z)V";
	protected static string _addDataListener20 = "(Ljpos/events/DataListener;)V";
	protected static string _addErrorListener21 = "(Ljpos/events/ErrorListener;)V";
	protected static string _addStatusUpdateListener22 = "(Ljpos/events/StatusUpdateListener;)V";
	protected static string _removeDataListener23 = "(Ljpos/events/DataListener;)V";
	protected static string _removeErrorListener24 = "(Ljpos/events/ErrorListener;)V";
	protected static string _removeStatusUpdateListener25 = "(Ljpos/events/StatusUpdateListener;)V";
	protected static string _getCapDisplay26 = "()I";
	protected static string _getCapLanguage27 = "()I";
	protected static string _getCapKeyboard28 = "()Z";
	protected static string _getCapMACCalculation29 = "()Z";
	protected static string _getCapTone30 = "()Z";
	protected static string _getAccountNumber31 = "()Ljava/lang/String;";
	protected static string _setAccountNumber32 = "(Ljava/lang/String;)V";
	protected static string _getAdditionalSecurityInformation33 = "()Ljava/lang/String;";
	protected static string _getAmount34 = "()J";
	protected static string _setAmount35 = "(J)V";
	protected static string _getAvailableLanguagesList36 = "()Ljava/lang/String;";
	protected static string _getAvailablePromptsList37 = "()Ljava/lang/String;";
	protected static string _getEncryptedPIN38 = "()Ljava/lang/String;";
	protected static string _getMaximumPINLength39 = "()I";
	protected static string _setMaximumPINLength40 = "(I)V";
	protected static string _getMerchantID41 = "()Ljava/lang/String;";
	protected static string _setMerchantID42 = "(Ljava/lang/String;)V";
	protected static string _getMinimumPINLength43 = "()I";
	protected static string _setMinimumPINLength44 = "(I)V";
	protected static string _getPINEntryEnabled45 = "()Z";
	protected static string _getPrompt46 = "()I";
	protected static string _setPrompt47 = "(I)V";
	protected static string _getPromptLanguage48 = "()Ljava/lang/String;";
	protected static string _setPromptLanguage49 = "(Ljava/lang/String;)V";
	protected static string _getTerminalID50 = "()Ljava/lang/String;";
	protected static string _setTerminalID51 = "(Ljava/lang/String;)V";
	protected static string _getTrack1Data52 = "()[B";
	protected static string _setTrack1Data53 = "([B)V";
	protected static string _getTrack2Data54 = "()[B";
	protected static string _setTrack2Data55 = "([B)V";
	protected static string _getTrack3Data56 = "()[B";
	protected static string _setTrack3Data57 = "([B)V";
	protected static string _getTransactionType58 = "()I";
	protected static string _setTransactionType59 = "(I)V";
	protected static string _getTrack4Data60 = "()[B";
	protected static string _setTrack4Data61 = "([B)V";
	protected static string _beginEFTTransaction62 = "(Ljava/lang/String;I)V";
	protected static string _computeMAC63 = "(Ljava/lang/String;[Ljava/lang/String;)V";
	protected static string _enablePINEntry64 = "()V";
	protected static string _endEFTTransaction65 = "(I)V";
	protected static string _updateKey66 = "(ILjava/lang/String;)V";
	protected static string _verifyMAC67 = "(Ljava/lang/String;)V";
	protected static JMethodID _minit0;
	protected static JMethodID _mgetCapStatisticsReporting0;
	protected static JMethodID _mgetCapUpdateStatistics1;
	protected static JMethodID _mgetCapCompareFirmwareVersion2;
	protected static JMethodID _mgetCapUpdateFirmware3;
	protected static JMethodID _mgetDataCount4;
	protected static JMethodID _mgetDataEventEnabled5;
	protected static JMethodID _mgetPowerNotify6;
	protected static JMethodID _msetPowerNotify7;
	protected static JMethodID _mgetPowerState8;
	protected static JMethodID _mclearInput9;
	protected static JMethodID _mresetStatistics10;
	protected static JMethodID _mretrieveStatistics11;
	protected static JMethodID _mupdateStatistics12;
	protected static JMethodID _mcompareFirmwareVersion13;
	protected static JMethodID _mupdateFirmware14;
	protected static JMethodID _mclearInputProperties15;
	protected static JMethodID _maddDirectIOListener16;
	protected static JMethodID _mremoveDirectIOListener17;
	protected static JMethodID _mgetCapPowerReporting18;
	protected static JMethodID _msetDataEventEnabled19;
	protected static JMethodID _maddDataListener20;
	protected static JMethodID _maddErrorListener21;
	protected static JMethodID _maddStatusUpdateListener22;
	protected static JMethodID _mremoveDataListener23;
	protected static JMethodID _mremoveErrorListener24;
	protected static JMethodID _mremoveStatusUpdateListener25;
	protected static JMethodID _mgetCapDisplay26;
	protected static JMethodID _mgetCapLanguage27;
	protected static JMethodID _mgetCapKeyboard28;
	protected static JMethodID _mgetCapMACCalculation29;
	protected static JMethodID _mgetCapTone30;
	protected static JMethodID _mgetAccountNumber31;
	protected static JMethodID _msetAccountNumber32;
	protected static JMethodID _mgetAdditionalSecurityInformation33;
	protected static JMethodID _mgetAmount34;
	protected static JMethodID _msetAmount35;
	protected static JMethodID _mgetAvailableLanguagesList36;
	protected static JMethodID _mgetAvailablePromptsList37;
	protected static JMethodID _mgetEncryptedPIN38;
	protected static JMethodID _mgetMaximumPINLength39;
	protected static JMethodID _msetMaximumPINLength40;
	protected static JMethodID _mgetMerchantID41;
	protected static JMethodID _msetMerchantID42;
	protected static JMethodID _mgetMinimumPINLength43;
	protected static JMethodID _msetMinimumPINLength44;
	protected static JMethodID _mgetPINEntryEnabled45;
	protected static JMethodID _mgetPrompt46;
	protected static JMethodID _msetPrompt47;
	protected static JMethodID _mgetPromptLanguage48;
	protected static JMethodID _msetPromptLanguage49;
	protected static JMethodID _mgetTerminalID50;
	protected static JMethodID _msetTerminalID51;
	protected static JMethodID _mgetTrack1Data52;
	protected static JMethodID _msetTrack1Data53;
	protected static JMethodID _mgetTrack2Data54;
	protected static JMethodID _msetTrack2Data55;
	protected static JMethodID _mgetTrack3Data56;
	protected static JMethodID _msetTrack3Data57;
	protected static JMethodID _mgetTransactionType58;
	protected static JMethodID _msetTransactionType59;
	protected static JMethodID _mgetTrack4Data60;
	protected static JMethodID _msetTrack4Data61;
	protected static JMethodID _mbeginEFTTransaction62;
	protected static JMethodID _mcomputeMAC63;
	protected static JMethodID _menablePINEntry64;
	protected static JMethodID _mendEFTTransaction65;
	protected static JMethodID _mupdateKey66;
	protected static JMethodID _mverifyMAC67;

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
	public bool getCapStatisticsReporting() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapStatisticsReporting0);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapUpdateStatistics1);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapCompareFirmwareVersion2);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapUpdateFirmware3);
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
	    int ret = JNI.CallMethod<int>(this, _mgetDataCount4);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getDataEventEnabled() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetDataEventEnabled5);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public int getPowerNotify() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetPowerNotify6);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void setPowerNotify(int p0) 
	{
	    JNI.CallVoidMethod(this, _msetPowerNotify7, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getPowerState() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetPowerState8);
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
	    JNI.CallVoidMethod(this, _mclearInput9);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void resetStatistics(string p0) 
	{
	    JNI.CallVoidMethod(this, _mresetStatistics10, new JValue(JNI.NewString(p0)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void retrieveStatistics(JObject p0) 
	{
	    JNI.CallVoidMethod(this, _mretrieveStatistics11, new JValue(p0));
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
	public void updateFirmware(string p0) 
	{
	    JNI.CallVoidMethod(this, _mupdateFirmware14, new JValue(JNI.NewString(p0)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void clearInputProperties() 
	{
	    JNI.CallVoidMethod(this, _mclearInputProperties15);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void addDirectIOListener(jpos.events.DirectIOListener p0) 
	{
	    JNI.CallVoidMethod(this, _maddDirectIOListener16, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void removeDirectIOListener(jpos.events.DirectIOListener p0) 
	{
	    JNI.CallVoidMethod(this, _mremoveDirectIOListener17, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getCapPowerReporting() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetCapPowerReporting18);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void setDataEventEnabled(bool p0) 
	{
	    JNI.CallVoidMethod(this, _msetDataEventEnabled19, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void addDataListener(jpos.events.DataListener p0) 
	{
	    JNI.CallVoidMethod(this, _maddDataListener20, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void addErrorListener(jpos.events.ErrorListener p0) 
	{
	    JNI.CallVoidMethod(this, _maddErrorListener21, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void addStatusUpdateListener(jpos.events.StatusUpdateListener p0) 
	{
	    JNI.CallVoidMethod(this, _maddStatusUpdateListener22, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void removeDataListener(jpos.events.DataListener p0) 
	{
	    JNI.CallVoidMethod(this, _mremoveDataListener23, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void removeErrorListener(jpos.events.ErrorListener p0) 
	{
	    JNI.CallVoidMethod(this, _mremoveErrorListener24, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void removeStatusUpdateListener(jpos.events.StatusUpdateListener p0) 
	{
	    JNI.CallVoidMethod(this, _mremoveStatusUpdateListener25, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getCapDisplay() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetCapDisplay26);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public int getCapLanguage() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetCapLanguage27);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapKeyboard28);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapMACCalculation() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapMACCalculation29);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapTone() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapTone30);
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
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetAccountNumber31);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret.GetString();
	}

	[DebuggerNonUserCode]
	public void setAccountNumber(string p0) 
	{
	    JNI.CallVoidMethod(this, _msetAccountNumber32, new JValue(JNI.NewString(p0)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public string getAdditionalSecurityInformation() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetAdditionalSecurityInformation33);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret.GetString();
	}

	[DebuggerNonUserCode]
	public long getAmount() 
	{
	    long ret = JNI.CallMethod<long>(this, _mgetAmount34);
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
	    JNI.CallVoidMethod(this, _msetAmount35, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public string getAvailableLanguagesList() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetAvailableLanguagesList36);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret.GetString();
	}

	[DebuggerNonUserCode]
	public string getAvailablePromptsList() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetAvailablePromptsList37);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret.GetString();
	}

	[DebuggerNonUserCode]
	public string getEncryptedPIN() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetEncryptedPIN38);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret.GetString();
	}

	[DebuggerNonUserCode]
	public int getMaximumPINLength() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetMaximumPINLength39);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void setMaximumPINLength(int p0) 
	{
	    JNI.CallVoidMethod(this, _msetMaximumPINLength40, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public string getMerchantID() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetMerchantID41);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret.GetString();
	}

	[DebuggerNonUserCode]
	public void setMerchantID(string p0) 
	{
	    JNI.CallVoidMethod(this, _msetMerchantID42, new JValue(JNI.NewString(p0)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getMinimumPINLength() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetMinimumPINLength43);
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
	    JNI.CallVoidMethod(this, _msetMinimumPINLength44, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public bool getPINEntryEnabled() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetPINEntryEnabled45);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public int getPrompt() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetPrompt46);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void setPrompt(int p0) 
	{
	    JNI.CallVoidMethod(this, _msetPrompt47, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public string getPromptLanguage() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetPromptLanguage48);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret.GetString();
	}

	[DebuggerNonUserCode]
	public void setPromptLanguage(string p0) 
	{
	    JNI.CallVoidMethod(this, _msetPromptLanguage49, new JValue(JNI.NewString(p0)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public string getTerminalID() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetTerminalID50);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret.GetString();
	}

	[DebuggerNonUserCode]
	public void setTerminalID(string p0) 
	{
	    JNI.CallVoidMethod(this, _msetTerminalID51, new JValue(JNI.NewString(p0)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public byte[] getTrack1Data() 
	{
	    JArray<sbyte> ret = JNI.CallObjectMethod<JArray<sbyte>>(this, _mgetTrack1Data52);
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
	    JNI.CallVoidMethod(this, _msetTrack1Data53, new JValue(JNI.NewArray<sbyte>(p0.Length)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public byte[] getTrack2Data() 
	{
	    JArray<sbyte> ret = JNI.CallObjectMethod<JArray<sbyte>>(this, _mgetTrack2Data54);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return Array.ConvertAll(ret.GetElements(), (a) => (byte)a);
	}

	[DebuggerNonUserCode]
	public void setTrack2Data(byte[] p0) 
	{
	    JNI.CallVoidMethod(this, _msetTrack2Data55, new JValue(JNI.NewArray<sbyte>(p0.Length)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public byte[] getTrack3Data() 
	{
	    JArray<sbyte> ret = JNI.CallObjectMethod<JArray<sbyte>>(this, _mgetTrack3Data56);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return Array.ConvertAll(ret.GetElements(), (a) => (byte)a);
	}

	[DebuggerNonUserCode]
	public void setTrack3Data(byte[] p0) 
	{
	    JNI.CallVoidMethod(this, _msetTrack3Data57, new JValue(JNI.NewArray<sbyte>(p0.Length)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getTransactionType() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetTransactionType58);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void setTransactionType(int p0) 
	{
	    JNI.CallVoidMethod(this, _msetTransactionType59, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public byte[] getTrack4Data() 
	{
	    JArray<sbyte> ret = JNI.CallObjectMethod<JArray<sbyte>>(this, _mgetTrack4Data60);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return Array.ConvertAll(ret.GetElements(), (a) => (byte)a);
	}

	[DebuggerNonUserCode]
	public void setTrack4Data(byte[] p0) 
	{
	    JNI.CallVoidMethod(this, _msetTrack4Data61, new JValue(JNI.NewArray<sbyte>(p0.Length)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void beginEFTTransaction(string p0,int p1) 
	{
	    JNI.CallVoidMethod(this, _mbeginEFTTransaction62, new JValue(JNI.NewString(p0)),new JValue(p1));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void computeMAC(string p0,JObject p1) 
	{
	    JNI.CallVoidMethod(this, _mcomputeMAC63, new JValue(JNI.NewString(p0)),new JValue(p1));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void enablePINEntry() 
	{
	    JNI.CallVoidMethod(this, _menablePINEntry64);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void endEFTTransaction(int p0) 
	{
	    JNI.CallVoidMethod(this, _mendEFTTransaction65, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void updateKey(int p0,string p1) 
	{
	    JNI.CallVoidMethod(this, _mupdateKey66, new JValue(p0),new JValue(JNI.NewString(p1)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void verifyMAC(string p0) 
	{
	    JNI.CallVoidMethod(this, _mverifyMAC67, new JValue(JNI.NewString(p0)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	static PINPad()
	{
  	_class = JNI.FindClass("jpos/PINPad");
  	if( _class == null ) throw new InvalidOperationException();
  	_minit0 = _class.GetMethodID("<init>", _init0);
  	if( _minit0.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapStatisticsReporting0 = _class.GetMethodID("getCapStatisticsReporting", _getCapStatisticsReporting0);
  	if( _mgetCapStatisticsReporting0.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapUpdateStatistics1 = _class.GetMethodID("getCapUpdateStatistics", _getCapUpdateStatistics1);
  	if( _mgetCapUpdateStatistics1.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapCompareFirmwareVersion2 = _class.GetMethodID("getCapCompareFirmwareVersion", _getCapCompareFirmwareVersion2);
  	if( _mgetCapCompareFirmwareVersion2.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapUpdateFirmware3 = _class.GetMethodID("getCapUpdateFirmware", _getCapUpdateFirmware3);
  	if( _mgetCapUpdateFirmware3.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetDataCount4 = _class.GetMethodID("getDataCount", _getDataCount4);
  	if( _mgetDataCount4.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetDataEventEnabled5 = _class.GetMethodID("getDataEventEnabled", _getDataEventEnabled5);
  	if( _mgetDataEventEnabled5.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetPowerNotify6 = _class.GetMethodID("getPowerNotify", _getPowerNotify6);
  	if( _mgetPowerNotify6.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetPowerNotify7 = _class.GetMethodID("setPowerNotify", _setPowerNotify7);
  	if( _msetPowerNotify7.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetPowerState8 = _class.GetMethodID("getPowerState", _getPowerState8);
  	if( _mgetPowerState8.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mclearInput9 = _class.GetMethodID("clearInput", _clearInput9);
  	if( _mclearInput9.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mresetStatistics10 = _class.GetMethodID("resetStatistics", _resetStatistics10);
  	if( _mresetStatistics10.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mretrieveStatistics11 = _class.GetMethodID("retrieveStatistics", _retrieveStatistics11);
  	if( _mretrieveStatistics11.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mupdateStatistics12 = _class.GetMethodID("updateStatistics", _updateStatistics12);
  	if( _mupdateStatistics12.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mcompareFirmwareVersion13 = _class.GetMethodID("compareFirmwareVersion", _compareFirmwareVersion13);
  	if( _mcompareFirmwareVersion13.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mupdateFirmware14 = _class.GetMethodID("updateFirmware", _updateFirmware14);
  	if( _mupdateFirmware14.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mclearInputProperties15 = _class.GetMethodID("clearInputProperties", _clearInputProperties15);
  	if( _mclearInputProperties15.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_maddDirectIOListener16 = _class.GetMethodID("addDirectIOListener", _addDirectIOListener16);
  	if( _maddDirectIOListener16.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mremoveDirectIOListener17 = _class.GetMethodID("removeDirectIOListener", _removeDirectIOListener17);
  	if( _mremoveDirectIOListener17.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapPowerReporting18 = _class.GetMethodID("getCapPowerReporting", _getCapPowerReporting18);
  	if( _mgetCapPowerReporting18.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetDataEventEnabled19 = _class.GetMethodID("setDataEventEnabled", _setDataEventEnabled19);
  	if( _msetDataEventEnabled19.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_maddDataListener20 = _class.GetMethodID("addDataListener", _addDataListener20);
  	if( _maddDataListener20.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_maddErrorListener21 = _class.GetMethodID("addErrorListener", _addErrorListener21);
  	if( _maddErrorListener21.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_maddStatusUpdateListener22 = _class.GetMethodID("addStatusUpdateListener", _addStatusUpdateListener22);
  	if( _maddStatusUpdateListener22.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mremoveDataListener23 = _class.GetMethodID("removeDataListener", _removeDataListener23);
  	if( _mremoveDataListener23.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mremoveErrorListener24 = _class.GetMethodID("removeErrorListener", _removeErrorListener24);
  	if( _mremoveErrorListener24.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mremoveStatusUpdateListener25 = _class.GetMethodID("removeStatusUpdateListener", _removeStatusUpdateListener25);
  	if( _mremoveStatusUpdateListener25.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapDisplay26 = _class.GetMethodID("getCapDisplay", _getCapDisplay26);
  	if( _mgetCapDisplay26.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapLanguage27 = _class.GetMethodID("getCapLanguage", _getCapLanguage27);
  	if( _mgetCapLanguage27.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapKeyboard28 = _class.GetMethodID("getCapKeyboard", _getCapKeyboard28);
  	if( _mgetCapKeyboard28.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapMACCalculation29 = _class.GetMethodID("getCapMACCalculation", _getCapMACCalculation29);
  	if( _mgetCapMACCalculation29.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapTone30 = _class.GetMethodID("getCapTone", _getCapTone30);
  	if( _mgetCapTone30.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetAccountNumber31 = _class.GetMethodID("getAccountNumber", _getAccountNumber31);
  	if( _mgetAccountNumber31.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetAccountNumber32 = _class.GetMethodID("setAccountNumber", _setAccountNumber32);
  	if( _msetAccountNumber32.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetAdditionalSecurityInformation33 = _class.GetMethodID("getAdditionalSecurityInformation", _getAdditionalSecurityInformation33);
  	if( _mgetAdditionalSecurityInformation33.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetAmount34 = _class.GetMethodID("getAmount", _getAmount34);
  	if( _mgetAmount34.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetAmount35 = _class.GetMethodID("setAmount", _setAmount35);
  	if( _msetAmount35.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetAvailableLanguagesList36 = _class.GetMethodID("getAvailableLanguagesList", _getAvailableLanguagesList36);
  	if( _mgetAvailableLanguagesList36.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetAvailablePromptsList37 = _class.GetMethodID("getAvailablePromptsList", _getAvailablePromptsList37);
  	if( _mgetAvailablePromptsList37.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetEncryptedPIN38 = _class.GetMethodID("getEncryptedPIN", _getEncryptedPIN38);
  	if( _mgetEncryptedPIN38.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetMaximumPINLength39 = _class.GetMethodID("getMaximumPINLength", _getMaximumPINLength39);
  	if( _mgetMaximumPINLength39.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetMaximumPINLength40 = _class.GetMethodID("setMaximumPINLength", _setMaximumPINLength40);
  	if( _msetMaximumPINLength40.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetMerchantID41 = _class.GetMethodID("getMerchantID", _getMerchantID41);
  	if( _mgetMerchantID41.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetMerchantID42 = _class.GetMethodID("setMerchantID", _setMerchantID42);
  	if( _msetMerchantID42.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetMinimumPINLength43 = _class.GetMethodID("getMinimumPINLength", _getMinimumPINLength43);
  	if( _mgetMinimumPINLength43.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetMinimumPINLength44 = _class.GetMethodID("setMinimumPINLength", _setMinimumPINLength44);
  	if( _msetMinimumPINLength44.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetPINEntryEnabled45 = _class.GetMethodID("getPINEntryEnabled", _getPINEntryEnabled45);
  	if( _mgetPINEntryEnabled45.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetPrompt46 = _class.GetMethodID("getPrompt", _getPrompt46);
  	if( _mgetPrompt46.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetPrompt47 = _class.GetMethodID("setPrompt", _setPrompt47);
  	if( _msetPrompt47.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetPromptLanguage48 = _class.GetMethodID("getPromptLanguage", _getPromptLanguage48);
  	if( _mgetPromptLanguage48.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetPromptLanguage49 = _class.GetMethodID("setPromptLanguage", _setPromptLanguage49);
  	if( _msetPromptLanguage49.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetTerminalID50 = _class.GetMethodID("getTerminalID", _getTerminalID50);
  	if( _mgetTerminalID50.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetTerminalID51 = _class.GetMethodID("setTerminalID", _setTerminalID51);
  	if( _msetTerminalID51.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetTrack1Data52 = _class.GetMethodID("getTrack1Data", _getTrack1Data52);
  	if( _mgetTrack1Data52.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetTrack1Data53 = _class.GetMethodID("setTrack1Data", _setTrack1Data53);
  	if( _msetTrack1Data53.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetTrack2Data54 = _class.GetMethodID("getTrack2Data", _getTrack2Data54);
  	if( _mgetTrack2Data54.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetTrack2Data55 = _class.GetMethodID("setTrack2Data", _setTrack2Data55);
  	if( _msetTrack2Data55.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetTrack3Data56 = _class.GetMethodID("getTrack3Data", _getTrack3Data56);
  	if( _mgetTrack3Data56.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetTrack3Data57 = _class.GetMethodID("setTrack3Data", _setTrack3Data57);
  	if( _msetTrack3Data57.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetTransactionType58 = _class.GetMethodID("getTransactionType", _getTransactionType58);
  	if( _mgetTransactionType58.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetTransactionType59 = _class.GetMethodID("setTransactionType", _setTransactionType59);
  	if( _msetTransactionType59.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetTrack4Data60 = _class.GetMethodID("getTrack4Data", _getTrack4Data60);
  	if( _mgetTrack4Data60.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetTrack4Data61 = _class.GetMethodID("setTrack4Data", _setTrack4Data61);
  	if( _msetTrack4Data61.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mbeginEFTTransaction62 = _class.GetMethodID("beginEFTTransaction", _beginEFTTransaction62);
  	if( _mbeginEFTTransaction62.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mcomputeMAC63 = _class.GetMethodID("computeMAC", _computeMAC63);
  	if( _mcomputeMAC63.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_menablePINEntry64 = _class.GetMethodID("enablePINEntry", _enablePINEntry64);
  	if( _menablePINEntry64.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mendEFTTransaction65 = _class.GetMethodID("endEFTTransaction", _endEFTTransaction65);
  	if( _mendEFTTransaction65.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mupdateKey66 = _class.GetMethodID("updateKey", _updateKey66);
  	if( _mupdateKey66.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mverifyMAC67 = _class.GetMethodID("verifyMAC", _verifyMAC67);
  	if( _mverifyMAC67.Handle == IntPtr.Zero ) throw new InvalidOperationException();
	}
}
}

namespace jpos {
class POSPrinter : jpos.BaseJposControl {
	protected static JClass _class;
	protected static string _init0 = "()V";
	protected static string _getAsyncMode0 = "()Z";
	protected static string _getOutputID1 = "()I";
	protected static string _getCapStatisticsReporting2 = "()Z";
	protected static string _getCapUpdateStatistics3 = "()Z";
	protected static string _getCapCompareFirmwareVersion4 = "()Z";
	protected static string _getCapUpdateFirmware5 = "()Z";
	protected static string _getPowerNotify6 = "()I";
	protected static string _setPowerNotify7 = "(I)V";
	protected static string _getPowerState8 = "()I";
	protected static string _resetStatistics9 = "(Ljava/lang/String;)V";
	protected static string _retrieveStatistics10 = "([Ljava/lang/String;)V";
	protected static string _updateStatistics11 = "(Ljava/lang/String;)V";
	protected static string _compareFirmwareVersion12 = "(Ljava/lang/String;[I)V";
	protected static string _updateFirmware13 = "(Ljava/lang/String;)V";
	protected static string _addDirectIOListener14 = "(Ljpos/events/DirectIOListener;)V";
	protected static string _removeDirectIOListener15 = "(Ljpos/events/DirectIOListener;)V";
	protected static string _getCapPowerReporting16 = "()I";
	protected static string _addErrorListener17 = "(Ljpos/events/ErrorListener;)V";
	protected static string _addStatusUpdateListener18 = "(Ljpos/events/StatusUpdateListener;)V";
	protected static string _removeErrorListener19 = "(Ljpos/events/ErrorListener;)V";
	protected static string _removeStatusUpdateListener20 = "(Ljpos/events/StatusUpdateListener;)V";
	protected static string _getCapCharacterSet21 = "()I";
	protected static string _getCapConcurrentJrnRec22 = "()Z";
	protected static string _getCapConcurrentJrnSlp23 = "()Z";
	protected static string _getCapConcurrentRecSlp24 = "()Z";
	protected static string _getCapCoverSensor25 = "()Z";
	protected static string _getCapJrn2Color26 = "()Z";
	protected static string _getCapJrnBold27 = "()Z";
	protected static string _getCapJrnDhigh28 = "()Z";
	protected static string _getCapJrnDwide29 = "()Z";
	protected static string _getCapJrnDwideDhigh30 = "()Z";
	protected static string _getCapJrnEmptySensor31 = "()Z";
	protected static string _getCapJrnItalic32 = "()Z";
	protected static string _getCapJrnNearEndSensor33 = "()Z";
	protected static string _getCapJrnPresent34 = "()Z";
	protected static string _getCapJrnUnderline35 = "()Z";
	protected static string _getCapRec2Color36 = "()Z";
	protected static string _getCapRecBarCode37 = "()Z";
	protected static string _getCapRecBitmap38 = "()Z";
	protected static string _getCapRecBold39 = "()Z";
	protected static string _getCapRecDhigh40 = "()Z";
	protected static string _getCapRecDwide41 = "()Z";
	protected static string _getCapRecDwideDhigh42 = "()Z";
	protected static string _getCapRecEmptySensor43 = "()Z";
	protected static string _getCapRecItalic44 = "()Z";
	protected static string _getCapRecLeft9045 = "()Z";
	protected static string _getCapRecNearEndSensor46 = "()Z";
	protected static string _getCapRecPapercut47 = "()Z";
	protected static string _getCapRecPresent48 = "()Z";
	protected static string _getCapRecRight9049 = "()Z";
	protected static string _getCapRecRotate18050 = "()Z";
	protected static string _getCapRecStamp51 = "()Z";
	protected static string _getCapRecUnderline52 = "()Z";
	protected static string _getCapSlp2Color53 = "()Z";
	protected static string _getCapSlpBarCode54 = "()Z";
	protected static string _getCapSlpBitmap55 = "()Z";
	protected static string _getCapSlpBold56 = "()Z";
	protected static string _getCapSlpDhigh57 = "()Z";
	protected static string _getCapSlpDwide58 = "()Z";
	protected static string _getCapSlpDwideDhigh59 = "()Z";
	protected static string _getCapSlpEmptySensor60 = "()Z";
	protected static string _getCapSlpFullslip61 = "()Z";
	protected static string _getCapSlpItalic62 = "()Z";
	protected static string _getCapSlpLeft9063 = "()Z";
	protected static string _getCapSlpNearEndSensor64 = "()Z";
	protected static string _getCapSlpPresent65 = "()Z";
	protected static string _getCapSlpRight9066 = "()Z";
	protected static string _getCapSlpRotate18067 = "()Z";
	protected static string _getCapSlpUnderline68 = "()Z";
	protected static string _getCapTransaction69 = "()Z";
	protected static string _getCapJrnCartridgeSensor70 = "()I";
	protected static string _getCapJrnColor71 = "()I";
	protected static string _getCapRecCartridgeSensor72 = "()I";
	protected static string _getCapRecColor73 = "()I";
	protected static string _getCapRecMarkFeed74 = "()I";
	protected static string _getCapSlpBothSidesPrint75 = "()Z";
	protected static string _getCapSlpCartridgeSensor76 = "()I";
	protected static string _getCapSlpColor77 = "()I";
	protected static string _getCapMapCharacterSet78 = "()Z";
	protected static string _getCapConcurrentPageMode79 = "()Z";
	protected static string _getCapRecPageMode80 = "()Z";
	protected static string _getCapSlpPageMode81 = "()Z";
	protected static string _getCapRecRuledLine82 = "()I";
	protected static string _getCapSlpRuledLine83 = "()I";
	protected static string _setAsyncMode84 = "(Z)V";
	protected static string _getCharacterSet85 = "()I";
	protected static string _setCharacterSet86 = "(I)V";
	protected static string _getCharacterSetList87 = "()Ljava/lang/String;";
	protected static string _getCoverOpen88 = "()Z";
	protected static string _getErrorLevel89 = "()I";
	protected static string _getErrorStation90 = "()I";
	protected static string _getErrorString91 = "()Ljava/lang/String;";
	protected static string _getFlagWhenIdle92 = "()Z";
	protected static string _setFlagWhenIdle93 = "(Z)V";
	protected static string _getFontTypefaceList94 = "()Ljava/lang/String;";
	protected static string _getJrnEmpty95 = "()Z";
	protected static string _getJrnLetterQuality96 = "()Z";
	protected static string _setJrnLetterQuality97 = "(Z)V";
	protected static string _getJrnLineChars98 = "()I";
	protected static string _setJrnLineChars99 = "(I)V";
	protected static string _getJrnLineCharsList100 = "()Ljava/lang/String;";
	protected static string _getJrnLineHeight101 = "()I";
	protected static string _setJrnLineHeight102 = "(I)V";
	protected static string _getJrnLineSpacing103 = "()I";
	protected static string _setJrnLineSpacing104 = "(I)V";
	protected static string _getJrnLineWidth105 = "()I";
	protected static string _getJrnNearEnd106 = "()Z";
	protected static string _getMapMode107 = "()I";
	protected static string _setMapMode108 = "(I)V";
	protected static string _getRecBarCodeRotationList109 = "()Ljava/lang/String;";
	protected static string _getRecEmpty110 = "()Z";
	protected static string _getRecLetterQuality111 = "()Z";
	protected static string _setRecLetterQuality112 = "(Z)V";
	protected static string _getRecLineChars113 = "()I";
	protected static string _setRecLineChars114 = "(I)V";
	protected static string _getRecLineCharsList115 = "()Ljava/lang/String;";
	protected static string _getRecLineHeight116 = "()I";
	protected static string _setRecLineHeight117 = "(I)V";
	protected static string _getRecLineSpacing118 = "()I";
	protected static string _setRecLineSpacing119 = "(I)V";
	protected static string _getRecLinesToPaperCut120 = "()I";
	protected static string _getRecLineWidth121 = "()I";
	protected static string _getRecNearEnd122 = "()Z";
	protected static string _getRecSidewaysMaxChars123 = "()I";
	protected static string _getRecSidewaysMaxLines124 = "()I";
	protected static string _getRotateSpecial125 = "()I";
	protected static string _setRotateSpecial126 = "(I)V";
	protected static string _getSlpBarCodeRotationList127 = "()Ljava/lang/String;";
	protected static string _getSlpEmpty128 = "()Z";
	protected static string _getSlpLetterQuality129 = "()Z";
	protected static string _setSlpLetterQuality130 = "(Z)V";
	protected static string _getSlpLineChars131 = "()I";
	protected static string _setSlpLineChars132 = "(I)V";
	protected static string _getSlpLineCharsList133 = "()Ljava/lang/String;";
	protected static string _getSlpLineHeight134 = "()I";
	protected static string _setSlpLineHeight135 = "(I)V";
	protected static string _getSlpLinesNearEndToEnd136 = "()I";
	protected static string _getSlpLineSpacing137 = "()I";
	protected static string _setSlpLineSpacing138 = "(I)V";
	protected static string _getSlpLineWidth139 = "()I";
	protected static string _getSlpMaxLines140 = "()I";
	protected static string _getSlpNearEnd141 = "()Z";
	protected static string _getSlpSidewaysMaxChars142 = "()I";
	protected static string _getSlpSidewaysMaxLines143 = "()I";
	protected static string _getCartridgeNotify144 = "()I";
	protected static string _setCartridgeNotify145 = "(I)V";
	protected static string _getJrnCartridgeState146 = "()I";
	protected static string _getJrnCurrentCartridge147 = "()I";
	protected static string _setJrnCurrentCartridge148 = "(I)V";
	protected static string _getRecCartridgeState149 = "()I";
	protected static string _getRecCurrentCartridge150 = "()I";
	protected static string _setRecCurrentCartridge151 = "(I)V";
	protected static string _getSlpCartridgeState152 = "()I";
	protected static string _getSlpCurrentCartridge153 = "()I";
	protected static string _setSlpCurrentCartridge154 = "(I)V";
	protected static string _getSlpPrintSide155 = "()I";
	protected static string _getMapCharacterSet156 = "()Z";
	protected static string _setMapCharacterSet157 = "(Z)V";
	protected static string _getRecBitmapRotationList158 = "()Ljava/lang/String;";
	protected static string _getSlpBitmapRotationList159 = "()Ljava/lang/String;";
	protected static string _getPageModeArea160 = "()Ljava/lang/String;";
	protected static string _getPageModeDescriptor161 = "()I";
	protected static string _getPageModeHorizontalPosition162 = "()I";
	protected static string _setPageModeHorizontalPosition163 = "(I)V";
	protected static string _getPageModePrintArea164 = "()Ljava/lang/String;";
	protected static string _setPageModePrintArea165 = "(Ljava/lang/String;)V";
	protected static string _getPageModePrintDirection166 = "()I";
	protected static string _setPageModePrintDirection167 = "(I)V";
	protected static string _getPageModeStation168 = "()I";
	protected static string _setPageModeStation169 = "(I)V";
	protected static string _getPageModeVerticalPosition170 = "()I";
	protected static string _setPageModeVerticalPosition171 = "(I)V";
	protected static string _beginInsertion172 = "(I)V";
	protected static string _beginRemoval173 = "(I)V";
	protected static string _clearOutput174 = "()V";
	protected static string _cutPaper175 = "(I)V";
	protected static string _endInsertion176 = "()V";
	protected static string _endRemoval177 = "()V";
	protected static string _printBarCode178 = "(ILjava/lang/String;IIIII)V";
	protected static string _printBitmap179 = "(ILjava/lang/String;II)V";
	protected static string _printImmediate180 = "(ILjava/lang/String;)V";
	protected static string _printNormal181 = "(ILjava/lang/String;)V";
	protected static string _printTwoNormal182 = "(ILjava/lang/String;Ljava/lang/String;)V";
	protected static string _rotatePrint183 = "(II)V";
	protected static string _setBitmap184 = "(IILjava/lang/String;II)V";
	protected static string _setLogo185 = "(ILjava/lang/String;)V";
	protected static string _transactionPrint186 = "(II)V";
	protected static string _validateData187 = "(ILjava/lang/String;)V";
	protected static string _changePrintSide188 = "(I)V";
	protected static string _markFeed189 = "(I)V";
	protected static string _clearPrintArea190 = "()V";
	protected static string _pageModePrint191 = "(I)V";
	protected static string _printMemoryBitmap192 = "(I[BIII)V";
	protected static string _drawRuledLine193 = "(ILjava/lang/String;IIII)V";
	protected static string _addOutputCompleteListener194 = "(Ljpos/events/OutputCompleteListener;)V";
	protected static string _removeOutputCompleteListener195 = "(Ljpos/events/OutputCompleteListener;)V";
	protected static JMethodID _minit0;
	protected static JMethodID _mgetAsyncMode0;
	protected static JMethodID _mgetOutputID1;
	protected static JMethodID _mgetCapStatisticsReporting2;
	protected static JMethodID _mgetCapUpdateStatistics3;
	protected static JMethodID _mgetCapCompareFirmwareVersion4;
	protected static JMethodID _mgetCapUpdateFirmware5;
	protected static JMethodID _mgetPowerNotify6;
	protected static JMethodID _msetPowerNotify7;
	protected static JMethodID _mgetPowerState8;
	protected static JMethodID _mresetStatistics9;
	protected static JMethodID _mretrieveStatistics10;
	protected static JMethodID _mupdateStatistics11;
	protected static JMethodID _mcompareFirmwareVersion12;
	protected static JMethodID _mupdateFirmware13;
	protected static JMethodID _maddDirectIOListener14;
	protected static JMethodID _mremoveDirectIOListener15;
	protected static JMethodID _mgetCapPowerReporting16;
	protected static JMethodID _maddErrorListener17;
	protected static JMethodID _maddStatusUpdateListener18;
	protected static JMethodID _mremoveErrorListener19;
	protected static JMethodID _mremoveStatusUpdateListener20;
	protected static JMethodID _mgetCapCharacterSet21;
	protected static JMethodID _mgetCapConcurrentJrnRec22;
	protected static JMethodID _mgetCapConcurrentJrnSlp23;
	protected static JMethodID _mgetCapConcurrentRecSlp24;
	protected static JMethodID _mgetCapCoverSensor25;
	protected static JMethodID _mgetCapJrn2Color26;
	protected static JMethodID _mgetCapJrnBold27;
	protected static JMethodID _mgetCapJrnDhigh28;
	protected static JMethodID _mgetCapJrnDwide29;
	protected static JMethodID _mgetCapJrnDwideDhigh30;
	protected static JMethodID _mgetCapJrnEmptySensor31;
	protected static JMethodID _mgetCapJrnItalic32;
	protected static JMethodID _mgetCapJrnNearEndSensor33;
	protected static JMethodID _mgetCapJrnPresent34;
	protected static JMethodID _mgetCapJrnUnderline35;
	protected static JMethodID _mgetCapRec2Color36;
	protected static JMethodID _mgetCapRecBarCode37;
	protected static JMethodID _mgetCapRecBitmap38;
	protected static JMethodID _mgetCapRecBold39;
	protected static JMethodID _mgetCapRecDhigh40;
	protected static JMethodID _mgetCapRecDwide41;
	protected static JMethodID _mgetCapRecDwideDhigh42;
	protected static JMethodID _mgetCapRecEmptySensor43;
	protected static JMethodID _mgetCapRecItalic44;
	protected static JMethodID _mgetCapRecLeft9045;
	protected static JMethodID _mgetCapRecNearEndSensor46;
	protected static JMethodID _mgetCapRecPapercut47;
	protected static JMethodID _mgetCapRecPresent48;
	protected static JMethodID _mgetCapRecRight9049;
	protected static JMethodID _mgetCapRecRotate18050;
	protected static JMethodID _mgetCapRecStamp51;
	protected static JMethodID _mgetCapRecUnderline52;
	protected static JMethodID _mgetCapSlp2Color53;
	protected static JMethodID _mgetCapSlpBarCode54;
	protected static JMethodID _mgetCapSlpBitmap55;
	protected static JMethodID _mgetCapSlpBold56;
	protected static JMethodID _mgetCapSlpDhigh57;
	protected static JMethodID _mgetCapSlpDwide58;
	protected static JMethodID _mgetCapSlpDwideDhigh59;
	protected static JMethodID _mgetCapSlpEmptySensor60;
	protected static JMethodID _mgetCapSlpFullslip61;
	protected static JMethodID _mgetCapSlpItalic62;
	protected static JMethodID _mgetCapSlpLeft9063;
	protected static JMethodID _mgetCapSlpNearEndSensor64;
	protected static JMethodID _mgetCapSlpPresent65;
	protected static JMethodID _mgetCapSlpRight9066;
	protected static JMethodID _mgetCapSlpRotate18067;
	protected static JMethodID _mgetCapSlpUnderline68;
	protected static JMethodID _mgetCapTransaction69;
	protected static JMethodID _mgetCapJrnCartridgeSensor70;
	protected static JMethodID _mgetCapJrnColor71;
	protected static JMethodID _mgetCapRecCartridgeSensor72;
	protected static JMethodID _mgetCapRecColor73;
	protected static JMethodID _mgetCapRecMarkFeed74;
	protected static JMethodID _mgetCapSlpBothSidesPrint75;
	protected static JMethodID _mgetCapSlpCartridgeSensor76;
	protected static JMethodID _mgetCapSlpColor77;
	protected static JMethodID _mgetCapMapCharacterSet78;
	protected static JMethodID _mgetCapConcurrentPageMode79;
	protected static JMethodID _mgetCapRecPageMode80;
	protected static JMethodID _mgetCapSlpPageMode81;
	protected static JMethodID _mgetCapRecRuledLine82;
	protected static JMethodID _mgetCapSlpRuledLine83;
	protected static JMethodID _msetAsyncMode84;
	protected static JMethodID _mgetCharacterSet85;
	protected static JMethodID _msetCharacterSet86;
	protected static JMethodID _mgetCharacterSetList87;
	protected static JMethodID _mgetCoverOpen88;
	protected static JMethodID _mgetErrorLevel89;
	protected static JMethodID _mgetErrorStation90;
	protected static JMethodID _mgetErrorString91;
	protected static JMethodID _mgetFlagWhenIdle92;
	protected static JMethodID _msetFlagWhenIdle93;
	protected static JMethodID _mgetFontTypefaceList94;
	protected static JMethodID _mgetJrnEmpty95;
	protected static JMethodID _mgetJrnLetterQuality96;
	protected static JMethodID _msetJrnLetterQuality97;
	protected static JMethodID _mgetJrnLineChars98;
	protected static JMethodID _msetJrnLineChars99;
	protected static JMethodID _mgetJrnLineCharsList100;
	protected static JMethodID _mgetJrnLineHeight101;
	protected static JMethodID _msetJrnLineHeight102;
	protected static JMethodID _mgetJrnLineSpacing103;
	protected static JMethodID _msetJrnLineSpacing104;
	protected static JMethodID _mgetJrnLineWidth105;
	protected static JMethodID _mgetJrnNearEnd106;
	protected static JMethodID _mgetMapMode107;
	protected static JMethodID _msetMapMode108;
	protected static JMethodID _mgetRecBarCodeRotationList109;
	protected static JMethodID _mgetRecEmpty110;
	protected static JMethodID _mgetRecLetterQuality111;
	protected static JMethodID _msetRecLetterQuality112;
	protected static JMethodID _mgetRecLineChars113;
	protected static JMethodID _msetRecLineChars114;
	protected static JMethodID _mgetRecLineCharsList115;
	protected static JMethodID _mgetRecLineHeight116;
	protected static JMethodID _msetRecLineHeight117;
	protected static JMethodID _mgetRecLineSpacing118;
	protected static JMethodID _msetRecLineSpacing119;
	protected static JMethodID _mgetRecLinesToPaperCut120;
	protected static JMethodID _mgetRecLineWidth121;
	protected static JMethodID _mgetRecNearEnd122;
	protected static JMethodID _mgetRecSidewaysMaxChars123;
	protected static JMethodID _mgetRecSidewaysMaxLines124;
	protected static JMethodID _mgetRotateSpecial125;
	protected static JMethodID _msetRotateSpecial126;
	protected static JMethodID _mgetSlpBarCodeRotationList127;
	protected static JMethodID _mgetSlpEmpty128;
	protected static JMethodID _mgetSlpLetterQuality129;
	protected static JMethodID _msetSlpLetterQuality130;
	protected static JMethodID _mgetSlpLineChars131;
	protected static JMethodID _msetSlpLineChars132;
	protected static JMethodID _mgetSlpLineCharsList133;
	protected static JMethodID _mgetSlpLineHeight134;
	protected static JMethodID _msetSlpLineHeight135;
	protected static JMethodID _mgetSlpLinesNearEndToEnd136;
	protected static JMethodID _mgetSlpLineSpacing137;
	protected static JMethodID _msetSlpLineSpacing138;
	protected static JMethodID _mgetSlpLineWidth139;
	protected static JMethodID _mgetSlpMaxLines140;
	protected static JMethodID _mgetSlpNearEnd141;
	protected static JMethodID _mgetSlpSidewaysMaxChars142;
	protected static JMethodID _mgetSlpSidewaysMaxLines143;
	protected static JMethodID _mgetCartridgeNotify144;
	protected static JMethodID _msetCartridgeNotify145;
	protected static JMethodID _mgetJrnCartridgeState146;
	protected static JMethodID _mgetJrnCurrentCartridge147;
	protected static JMethodID _msetJrnCurrentCartridge148;
	protected static JMethodID _mgetRecCartridgeState149;
	protected static JMethodID _mgetRecCurrentCartridge150;
	protected static JMethodID _msetRecCurrentCartridge151;
	protected static JMethodID _mgetSlpCartridgeState152;
	protected static JMethodID _mgetSlpCurrentCartridge153;
	protected static JMethodID _msetSlpCurrentCartridge154;
	protected static JMethodID _mgetSlpPrintSide155;
	protected static JMethodID _mgetMapCharacterSet156;
	protected static JMethodID _msetMapCharacterSet157;
	protected static JMethodID _mgetRecBitmapRotationList158;
	protected static JMethodID _mgetSlpBitmapRotationList159;
	protected static JMethodID _mgetPageModeArea160;
	protected static JMethodID _mgetPageModeDescriptor161;
	protected static JMethodID _mgetPageModeHorizontalPosition162;
	protected static JMethodID _msetPageModeHorizontalPosition163;
	protected static JMethodID _mgetPageModePrintArea164;
	protected static JMethodID _msetPageModePrintArea165;
	protected static JMethodID _mgetPageModePrintDirection166;
	protected static JMethodID _msetPageModePrintDirection167;
	protected static JMethodID _mgetPageModeStation168;
	protected static JMethodID _msetPageModeStation169;
	protected static JMethodID _mgetPageModeVerticalPosition170;
	protected static JMethodID _msetPageModeVerticalPosition171;
	protected static JMethodID _mbeginInsertion172;
	protected static JMethodID _mbeginRemoval173;
	protected static JMethodID _mclearOutput174;
	protected static JMethodID _mcutPaper175;
	protected static JMethodID _mendInsertion176;
	protected static JMethodID _mendRemoval177;
	protected static JMethodID _mprintBarCode178;
	protected static JMethodID _mprintBitmap179;
	protected static JMethodID _mprintImmediate180;
	protected static JMethodID _mprintNormal181;
	protected static JMethodID _mprintTwoNormal182;
	protected static JMethodID _mrotatePrint183;
	protected static JMethodID _msetBitmap184;
	protected static JMethodID _msetLogo185;
	protected static JMethodID _mtransactionPrint186;
	protected static JMethodID _mvalidateData187;
	protected static JMethodID _mchangePrintSide188;
	protected static JMethodID _mmarkFeed189;
	protected static JMethodID _mclearPrintArea190;
	protected static JMethodID _mpageModePrint191;
	protected static JMethodID _mprintMemoryBitmap192;
	protected static JMethodID _mdrawRuledLine193;
	protected static JMethodID _maddOutputCompleteListener194;
	protected static JMethodID _mremoveOutputCompleteListener195;

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
	public int getOutputID() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetOutputID1);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapStatisticsReporting2);
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
	public int getPowerNotify() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetPowerNotify6);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void setPowerNotify(int p0) 
	{
	    JNI.CallVoidMethod(this, _msetPowerNotify7, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getPowerState() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetPowerState8);
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
	    JNI.CallVoidMethod(this, _mresetStatistics9, new JValue(JNI.NewString(p0)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void retrieveStatistics(JObject p0) 
	{
	    JNI.CallVoidMethod(this, _mretrieveStatistics10, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void updateStatistics(string p0) 
	{
	    JNI.CallVoidMethod(this, _mupdateStatistics11, new JValue(JNI.NewString(p0)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void compareFirmwareVersion(string p0,JObject p1) 
	{
	    JNI.CallVoidMethod(this, _mcompareFirmwareVersion12, new JValue(JNI.NewString(p0)),new JValue(p1));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void updateFirmware(string p0) 
	{
	    JNI.CallVoidMethod(this, _mupdateFirmware13, new JValue(JNI.NewString(p0)));
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
	public int getCapPowerReporting() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetCapPowerReporting16);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void addErrorListener(jpos.events.ErrorListener p0) 
	{
	    JNI.CallVoidMethod(this, _maddErrorListener17, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void addStatusUpdateListener(jpos.events.StatusUpdateListener p0) 
	{
	    JNI.CallVoidMethod(this, _maddStatusUpdateListener18, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void removeErrorListener(jpos.events.ErrorListener p0) 
	{
	    JNI.CallVoidMethod(this, _mremoveErrorListener19, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void removeStatusUpdateListener(jpos.events.StatusUpdateListener p0) 
	{
	    JNI.CallVoidMethod(this, _mremoveStatusUpdateListener20, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getCapCharacterSet() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetCapCharacterSet21);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapConcurrentJrnRec22);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapConcurrentJrnSlp23);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapConcurrentRecSlp24);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapCoverSensor25);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapJrn2Color26);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapJrnBold27);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapJrnDhigh28);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapJrnDwide29);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapJrnDwideDhigh30);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapJrnEmptySensor31);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapJrnItalic32);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapJrnNearEndSensor33);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapJrnPresent34);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapJrnUnderline35);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapRec2Color36);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapRecBarCode37);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapRecBitmap38);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapRecBold39);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapRecDhigh40);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapRecDwide41);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapRecDwideDhigh42);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapRecEmptySensor43);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapRecItalic44);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapRecLeft9045);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapRecNearEndSensor46);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapRecPapercut47);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapRecPresent48);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapRecRight9049);
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
	public bool getCapRecStamp() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapRecStamp51);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapRecUnderline52);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapSlp2Color() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapSlp2Color53);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapSlpBarCode54);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapSlpBitmap55);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapSlpBold56);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapSlpDhigh57);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapSlpDwide58);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapSlpDwideDhigh59);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapSlpEmptySensor60);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapSlpFullslip61);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapSlpItalic62);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapSlpLeft9063);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapSlpNearEndSensor64);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapSlpPresent65);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapSlpRight9066);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapSlpRotate18067);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapSlpUnderline() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapSlpUnderline68);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapTransaction69);
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
	    int ret = JNI.CallMethod<int>(this, _mgetCapJrnCartridgeSensor70);
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
	    int ret = JNI.CallMethod<int>(this, _mgetCapJrnColor71);
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
	    int ret = JNI.CallMethod<int>(this, _mgetCapRecCartridgeSensor72);
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
	    int ret = JNI.CallMethod<int>(this, _mgetCapRecColor73);
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
	    int ret = JNI.CallMethod<int>(this, _mgetCapRecMarkFeed74);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getCapSlpBothSidesPrint() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapSlpBothSidesPrint75);
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
	    int ret = JNI.CallMethod<int>(this, _mgetCapSlpCartridgeSensor76);
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
	    int ret = JNI.CallMethod<int>(this, _mgetCapSlpColor77);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapMapCharacterSet78);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapConcurrentPageMode79);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapRecPageMode80);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetCapSlpPageMode81);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public int getCapRecRuledLine() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetCapRecRuledLine82);
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
	    int ret = JNI.CallMethod<int>(this, _mgetCapSlpRuledLine83);
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
	    JNI.CallVoidMethod(this, _msetAsyncMode84, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getCharacterSet() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetCharacterSet85);
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
	    JNI.CallVoidMethod(this, _msetCharacterSet86, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public string getCharacterSetList() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetCharacterSetList87);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret.GetString();
	}

	[DebuggerNonUserCode]
	public bool getCoverOpen() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetCoverOpen88);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public int getErrorLevel() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetErrorLevel89);
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
	    int ret = JNI.CallMethod<int>(this, _mgetErrorStation90);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public string getErrorString() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetErrorString91);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret.GetString();
	}

	[DebuggerNonUserCode]
	public bool getFlagWhenIdle() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetFlagWhenIdle92);
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
	    JNI.CallVoidMethod(this, _msetFlagWhenIdle93, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public string getFontTypefaceList() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetFontTypefaceList94);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret.GetString();
	}

	[DebuggerNonUserCode]
	public bool getJrnEmpty() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetJrnEmpty95);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getJrnLetterQuality() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetJrnLetterQuality96);
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
	    JNI.CallVoidMethod(this, _msetJrnLetterQuality97, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getJrnLineChars() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetJrnLineChars98);
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
	    JNI.CallVoidMethod(this, _msetJrnLineChars99, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public string getJrnLineCharsList() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetJrnLineCharsList100);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret.GetString();
	}

	[DebuggerNonUserCode]
	public int getJrnLineHeight() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetJrnLineHeight101);
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
	    JNI.CallVoidMethod(this, _msetJrnLineHeight102, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getJrnLineSpacing() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetJrnLineSpacing103);
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
	    JNI.CallVoidMethod(this, _msetJrnLineSpacing104, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getJrnLineWidth() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetJrnLineWidth105);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getJrnNearEnd() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetJrnNearEnd106);
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
	    int ret = JNI.CallMethod<int>(this, _mgetMapMode107);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void setMapMode(int p0) 
	{
	    JNI.CallVoidMethod(this, _msetMapMode108, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public string getRecBarCodeRotationList() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetRecBarCodeRotationList109);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret.GetString();
	}

	[DebuggerNonUserCode]
	public bool getRecEmpty() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetRecEmpty110);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getRecLetterQuality() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetRecLetterQuality111);
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
	    JNI.CallVoidMethod(this, _msetRecLetterQuality112, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getRecLineChars() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetRecLineChars113);
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
	    JNI.CallVoidMethod(this, _msetRecLineChars114, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public string getRecLineCharsList() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetRecLineCharsList115);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret.GetString();
	}

	[DebuggerNonUserCode]
	public int getRecLineHeight() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetRecLineHeight116);
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
	    JNI.CallVoidMethod(this, _msetRecLineHeight117, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getRecLineSpacing() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetRecLineSpacing118);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void setRecLineSpacing(int p0) 
	{
	    JNI.CallVoidMethod(this, _msetRecLineSpacing119, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getRecLinesToPaperCut() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetRecLinesToPaperCut120);
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
	    int ret = JNI.CallMethod<int>(this, _mgetRecLineWidth121);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetRecNearEnd122);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public int getRecSidewaysMaxChars() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetRecSidewaysMaxChars123);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public int getRecSidewaysMaxLines() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetRecSidewaysMaxLines124);
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
	    int ret = JNI.CallMethod<int>(this, _mgetRotateSpecial125);
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
	    JNI.CallVoidMethod(this, _msetRotateSpecial126, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public string getSlpBarCodeRotationList() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetSlpBarCodeRotationList127);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret.GetString();
	}

	[DebuggerNonUserCode]
	public bool getSlpEmpty() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetSlpEmpty128);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetSlpLetterQuality129);
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
	    JNI.CallVoidMethod(this, _msetSlpLetterQuality130, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getSlpLineChars() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetSlpLineChars131);
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
	    JNI.CallVoidMethod(this, _msetSlpLineChars132, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public string getSlpLineCharsList() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetSlpLineCharsList133);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret.GetString();
	}

	[DebuggerNonUserCode]
	public int getSlpLineHeight() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetSlpLineHeight134);
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
	    JNI.CallVoidMethod(this, _msetSlpLineHeight135, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getSlpLinesNearEndToEnd() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetSlpLinesNearEndToEnd136);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public int getSlpLineSpacing() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetSlpLineSpacing137);
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
	    JNI.CallVoidMethod(this, _msetSlpLineSpacing138, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getSlpLineWidth() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetSlpLineWidth139);
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
	    int ret = JNI.CallMethod<int>(this, _mgetSlpMaxLines140);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public bool getSlpNearEnd() 
	{
	    bool ret = JNI.CallMethod<bool>(this, _mgetSlpNearEnd141);
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
	    int ret = JNI.CallMethod<int>(this, _mgetSlpSidewaysMaxChars142);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public int getSlpSidewaysMaxLines() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetSlpSidewaysMaxLines143);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public int getCartridgeNotify() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetCartridgeNotify144);
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
	    JNI.CallVoidMethod(this, _msetCartridgeNotify145, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getJrnCartridgeState() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetJrnCartridgeState146);
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
	    int ret = JNI.CallMethod<int>(this, _mgetJrnCurrentCartridge147);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void setJrnCurrentCartridge(int p0) 
	{
	    JNI.CallVoidMethod(this, _msetJrnCurrentCartridge148, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getRecCartridgeState() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetRecCartridgeState149);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public int getRecCurrentCartridge() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetRecCurrentCartridge150);
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
	    JNI.CallVoidMethod(this, _msetRecCurrentCartridge151, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getSlpCartridgeState() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetSlpCartridgeState152);
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
	    int ret = JNI.CallMethod<int>(this, _mgetSlpCurrentCartridge153);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void setSlpCurrentCartridge(int p0) 
	{
	    JNI.CallVoidMethod(this, _msetSlpCurrentCartridge154, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getSlpPrintSide() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetSlpPrintSide155);
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
	    bool ret = JNI.CallMethod<bool>(this, _mgetMapCharacterSet156);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void setMapCharacterSet(bool p0) 
	{
	    JNI.CallVoidMethod(this, _msetMapCharacterSet157, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public string getRecBitmapRotationList() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetRecBitmapRotationList158);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret.GetString();
	}

	[DebuggerNonUserCode]
	public string getSlpBitmapRotationList() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetSlpBitmapRotationList159);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret.GetString();
	}

	[DebuggerNonUserCode]
	public string getPageModeArea() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetPageModeArea160);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret.GetString();
	}

	[DebuggerNonUserCode]
	public int getPageModeDescriptor() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetPageModeDescriptor161);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public int getPageModeHorizontalPosition() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetPageModeHorizontalPosition162);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void setPageModeHorizontalPosition(int p0) 
	{
	    JNI.CallVoidMethod(this, _msetPageModeHorizontalPosition163, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public string getPageModePrintArea() 
	{
	    JString ret = JNI.CallObjectMethod<JString>(this, _mgetPageModePrintArea164);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret.GetString();
	}

	[DebuggerNonUserCode]
	public void setPageModePrintArea(string p0) 
	{
	    JNI.CallVoidMethod(this, _msetPageModePrintArea165, new JValue(JNI.NewString(p0)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getPageModePrintDirection() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetPageModePrintDirection166);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void setPageModePrintDirection(int p0) 
	{
	    JNI.CallVoidMethod(this, _msetPageModePrintDirection167, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getPageModeStation() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetPageModeStation168);
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
	    JNI.CallVoidMethod(this, _msetPageModeStation169, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public int getPageModeVerticalPosition() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetPageModeVerticalPosition170);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	public void setPageModeVerticalPosition(int p0) 
	{
	    JNI.CallVoidMethod(this, _msetPageModeVerticalPosition171, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void beginInsertion(int p0) 
	{
	    JNI.CallVoidMethod(this, _mbeginInsertion172, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void beginRemoval(int p0) 
	{
	    JNI.CallVoidMethod(this, _mbeginRemoval173, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void clearOutput() 
	{
	    JNI.CallVoidMethod(this, _mclearOutput174);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void cutPaper(int p0) 
	{
	    JNI.CallVoidMethod(this, _mcutPaper175, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void endInsertion() 
	{
	    JNI.CallVoidMethod(this, _mendInsertion176);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void endRemoval() 
	{
	    JNI.CallVoidMethod(this, _mendRemoval177);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void printBarCode(int p0,string p1,int p2,int p3,int p4,int p5,int p6) 
	{
	    JNI.CallVoidMethod(this, _mprintBarCode178, new JValue(p0),new JValue(JNI.NewString(p1)),new JValue(p2),new JValue(p3),new JValue(p4),new JValue(p5),new JValue(p6));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void printBitmap(int p0,string p1,int p2,int p3) 
	{
	    JNI.CallVoidMethod(this, _mprintBitmap179, new JValue(p0),new JValue(JNI.NewString(p1)),new JValue(p2),new JValue(p3));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void printImmediate(int p0,string p1) 
	{
	    JNI.CallVoidMethod(this, _mprintImmediate180, new JValue(p0),new JValue(JNI.NewString(p1)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void printNormal(int p0,string p1) 
	{
	    JNI.CallVoidMethod(this, _mprintNormal181, new JValue(p0),new JValue(JNI.NewString(p1)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void printTwoNormal(int p0,string p1,string p2) 
	{
	    JNI.CallVoidMethod(this, _mprintTwoNormal182, new JValue(p0),new JValue(JNI.NewString(p1)),new JValue(JNI.NewString(p2)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void rotatePrint(int p0,int p1) 
	{
	    JNI.CallVoidMethod(this, _mrotatePrint183, new JValue(p0),new JValue(p1));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void setBitmap(int p0,int p1,string p2,int p3,int p4) 
	{
	    JNI.CallVoidMethod(this, _msetBitmap184, new JValue(p0),new JValue(p1),new JValue(JNI.NewString(p2)),new JValue(p3),new JValue(p4));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void setLogo(int p0,string p1) 
	{
	    JNI.CallVoidMethod(this, _msetLogo185, new JValue(p0),new JValue(JNI.NewString(p1)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void transactionPrint(int p0,int p1) 
	{
	    JNI.CallVoidMethod(this, _mtransactionPrint186, new JValue(p0),new JValue(p1));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void validateData(int p0,string p1) 
	{
	    JNI.CallVoidMethod(this, _mvalidateData187, new JValue(p0),new JValue(JNI.NewString(p1)));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void changePrintSide(int p0) 
	{
	    JNI.CallVoidMethod(this, _mchangePrintSide188, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void markFeed(int p0) 
	{
	    JNI.CallVoidMethod(this, _mmarkFeed189, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void clearPrintArea() 
	{
	    JNI.CallVoidMethod(this, _mclearPrintArea190);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void pageModePrint(int p0) 
	{
	    JNI.CallVoidMethod(this, _mpageModePrint191, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void printMemoryBitmap(int p0,byte[] p1,int p2,int p3,int p4) 
	{
	    JNI.CallVoidMethod(this, _mprintMemoryBitmap192, new JValue(p0),new JValue(JNI.NewArray<sbyte>(p1.Length)),new JValue(p2),new JValue(p3),new JValue(p4));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void drawRuledLine(int p0,string p1,int p2,int p3,int p4,int p5) 
	{
	    JNI.CallVoidMethod(this, _mdrawRuledLine193, new JValue(p0),new JValue(JNI.NewString(p1)),new JValue(p2),new JValue(p3),new JValue(p4),new JValue(p5));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void addOutputCompleteListener(jpos.events.OutputCompleteListener p0) 
	{
	    JNI.CallVoidMethod(this, _maddOutputCompleteListener194, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	public void removeOutputCompleteListener(jpos.events.OutputCompleteListener p0) 
	{
	    JNI.CallVoidMethod(this, _mremoveOutputCompleteListener195, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	static POSPrinter()
	{
  	_class = JNI.FindClass("jpos/POSPrinter");
  	if( _class == null ) throw new InvalidOperationException();
  	_minit0 = _class.GetMethodID("<init>", _init0);
  	if( _minit0.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetAsyncMode0 = _class.GetMethodID("getAsyncMode", _getAsyncMode0);
  	if( _mgetAsyncMode0.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetOutputID1 = _class.GetMethodID("getOutputID", _getOutputID1);
  	if( _mgetOutputID1.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapStatisticsReporting2 = _class.GetMethodID("getCapStatisticsReporting", _getCapStatisticsReporting2);
  	if( _mgetCapStatisticsReporting2.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapUpdateStatistics3 = _class.GetMethodID("getCapUpdateStatistics", _getCapUpdateStatistics3);
  	if( _mgetCapUpdateStatistics3.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapCompareFirmwareVersion4 = _class.GetMethodID("getCapCompareFirmwareVersion", _getCapCompareFirmwareVersion4);
  	if( _mgetCapCompareFirmwareVersion4.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapUpdateFirmware5 = _class.GetMethodID("getCapUpdateFirmware", _getCapUpdateFirmware5);
  	if( _mgetCapUpdateFirmware5.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetPowerNotify6 = _class.GetMethodID("getPowerNotify", _getPowerNotify6);
  	if( _mgetPowerNotify6.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetPowerNotify7 = _class.GetMethodID("setPowerNotify", _setPowerNotify7);
  	if( _msetPowerNotify7.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetPowerState8 = _class.GetMethodID("getPowerState", _getPowerState8);
  	if( _mgetPowerState8.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mresetStatistics9 = _class.GetMethodID("resetStatistics", _resetStatistics9);
  	if( _mresetStatistics9.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mretrieveStatistics10 = _class.GetMethodID("retrieveStatistics", _retrieveStatistics10);
  	if( _mretrieveStatistics10.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mupdateStatistics11 = _class.GetMethodID("updateStatistics", _updateStatistics11);
  	if( _mupdateStatistics11.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mcompareFirmwareVersion12 = _class.GetMethodID("compareFirmwareVersion", _compareFirmwareVersion12);
  	if( _mcompareFirmwareVersion12.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mupdateFirmware13 = _class.GetMethodID("updateFirmware", _updateFirmware13);
  	if( _mupdateFirmware13.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_maddDirectIOListener14 = _class.GetMethodID("addDirectIOListener", _addDirectIOListener14);
  	if( _maddDirectIOListener14.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mremoveDirectIOListener15 = _class.GetMethodID("removeDirectIOListener", _removeDirectIOListener15);
  	if( _mremoveDirectIOListener15.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapPowerReporting16 = _class.GetMethodID("getCapPowerReporting", _getCapPowerReporting16);
  	if( _mgetCapPowerReporting16.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_maddErrorListener17 = _class.GetMethodID("addErrorListener", _addErrorListener17);
  	if( _maddErrorListener17.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_maddStatusUpdateListener18 = _class.GetMethodID("addStatusUpdateListener", _addStatusUpdateListener18);
  	if( _maddStatusUpdateListener18.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mremoveErrorListener19 = _class.GetMethodID("removeErrorListener", _removeErrorListener19);
  	if( _mremoveErrorListener19.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mremoveStatusUpdateListener20 = _class.GetMethodID("removeStatusUpdateListener", _removeStatusUpdateListener20);
  	if( _mremoveStatusUpdateListener20.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapCharacterSet21 = _class.GetMethodID("getCapCharacterSet", _getCapCharacterSet21);
  	if( _mgetCapCharacterSet21.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapConcurrentJrnRec22 = _class.GetMethodID("getCapConcurrentJrnRec", _getCapConcurrentJrnRec22);
  	if( _mgetCapConcurrentJrnRec22.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapConcurrentJrnSlp23 = _class.GetMethodID("getCapConcurrentJrnSlp", _getCapConcurrentJrnSlp23);
  	if( _mgetCapConcurrentJrnSlp23.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapConcurrentRecSlp24 = _class.GetMethodID("getCapConcurrentRecSlp", _getCapConcurrentRecSlp24);
  	if( _mgetCapConcurrentRecSlp24.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapCoverSensor25 = _class.GetMethodID("getCapCoverSensor", _getCapCoverSensor25);
  	if( _mgetCapCoverSensor25.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapJrn2Color26 = _class.GetMethodID("getCapJrn2Color", _getCapJrn2Color26);
  	if( _mgetCapJrn2Color26.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapJrnBold27 = _class.GetMethodID("getCapJrnBold", _getCapJrnBold27);
  	if( _mgetCapJrnBold27.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapJrnDhigh28 = _class.GetMethodID("getCapJrnDhigh", _getCapJrnDhigh28);
  	if( _mgetCapJrnDhigh28.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapJrnDwide29 = _class.GetMethodID("getCapJrnDwide", _getCapJrnDwide29);
  	if( _mgetCapJrnDwide29.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapJrnDwideDhigh30 = _class.GetMethodID("getCapJrnDwideDhigh", _getCapJrnDwideDhigh30);
  	if( _mgetCapJrnDwideDhigh30.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapJrnEmptySensor31 = _class.GetMethodID("getCapJrnEmptySensor", _getCapJrnEmptySensor31);
  	if( _mgetCapJrnEmptySensor31.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapJrnItalic32 = _class.GetMethodID("getCapJrnItalic", _getCapJrnItalic32);
  	if( _mgetCapJrnItalic32.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapJrnNearEndSensor33 = _class.GetMethodID("getCapJrnNearEndSensor", _getCapJrnNearEndSensor33);
  	if( _mgetCapJrnNearEndSensor33.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapJrnPresent34 = _class.GetMethodID("getCapJrnPresent", _getCapJrnPresent34);
  	if( _mgetCapJrnPresent34.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapJrnUnderline35 = _class.GetMethodID("getCapJrnUnderline", _getCapJrnUnderline35);
  	if( _mgetCapJrnUnderline35.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapRec2Color36 = _class.GetMethodID("getCapRec2Color", _getCapRec2Color36);
  	if( _mgetCapRec2Color36.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapRecBarCode37 = _class.GetMethodID("getCapRecBarCode", _getCapRecBarCode37);
  	if( _mgetCapRecBarCode37.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapRecBitmap38 = _class.GetMethodID("getCapRecBitmap", _getCapRecBitmap38);
  	if( _mgetCapRecBitmap38.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapRecBold39 = _class.GetMethodID("getCapRecBold", _getCapRecBold39);
  	if( _mgetCapRecBold39.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapRecDhigh40 = _class.GetMethodID("getCapRecDhigh", _getCapRecDhigh40);
  	if( _mgetCapRecDhigh40.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapRecDwide41 = _class.GetMethodID("getCapRecDwide", _getCapRecDwide41);
  	if( _mgetCapRecDwide41.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapRecDwideDhigh42 = _class.GetMethodID("getCapRecDwideDhigh", _getCapRecDwideDhigh42);
  	if( _mgetCapRecDwideDhigh42.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapRecEmptySensor43 = _class.GetMethodID("getCapRecEmptySensor", _getCapRecEmptySensor43);
  	if( _mgetCapRecEmptySensor43.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapRecItalic44 = _class.GetMethodID("getCapRecItalic", _getCapRecItalic44);
  	if( _mgetCapRecItalic44.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapRecLeft9045 = _class.GetMethodID("getCapRecLeft90", _getCapRecLeft9045);
  	if( _mgetCapRecLeft9045.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapRecNearEndSensor46 = _class.GetMethodID("getCapRecNearEndSensor", _getCapRecNearEndSensor46);
  	if( _mgetCapRecNearEndSensor46.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapRecPapercut47 = _class.GetMethodID("getCapRecPapercut", _getCapRecPapercut47);
  	if( _mgetCapRecPapercut47.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapRecPresent48 = _class.GetMethodID("getCapRecPresent", _getCapRecPresent48);
  	if( _mgetCapRecPresent48.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapRecRight9049 = _class.GetMethodID("getCapRecRight90", _getCapRecRight9049);
  	if( _mgetCapRecRight9049.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapRecRotate18050 = _class.GetMethodID("getCapRecRotate180", _getCapRecRotate18050);
  	if( _mgetCapRecRotate18050.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapRecStamp51 = _class.GetMethodID("getCapRecStamp", _getCapRecStamp51);
  	if( _mgetCapRecStamp51.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapRecUnderline52 = _class.GetMethodID("getCapRecUnderline", _getCapRecUnderline52);
  	if( _mgetCapRecUnderline52.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapSlp2Color53 = _class.GetMethodID("getCapSlp2Color", _getCapSlp2Color53);
  	if( _mgetCapSlp2Color53.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapSlpBarCode54 = _class.GetMethodID("getCapSlpBarCode", _getCapSlpBarCode54);
  	if( _mgetCapSlpBarCode54.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapSlpBitmap55 = _class.GetMethodID("getCapSlpBitmap", _getCapSlpBitmap55);
  	if( _mgetCapSlpBitmap55.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapSlpBold56 = _class.GetMethodID("getCapSlpBold", _getCapSlpBold56);
  	if( _mgetCapSlpBold56.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapSlpDhigh57 = _class.GetMethodID("getCapSlpDhigh", _getCapSlpDhigh57);
  	if( _mgetCapSlpDhigh57.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapSlpDwide58 = _class.GetMethodID("getCapSlpDwide", _getCapSlpDwide58);
  	if( _mgetCapSlpDwide58.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapSlpDwideDhigh59 = _class.GetMethodID("getCapSlpDwideDhigh", _getCapSlpDwideDhigh59);
  	if( _mgetCapSlpDwideDhigh59.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapSlpEmptySensor60 = _class.GetMethodID("getCapSlpEmptySensor", _getCapSlpEmptySensor60);
  	if( _mgetCapSlpEmptySensor60.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapSlpFullslip61 = _class.GetMethodID("getCapSlpFullslip", _getCapSlpFullslip61);
  	if( _mgetCapSlpFullslip61.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapSlpItalic62 = _class.GetMethodID("getCapSlpItalic", _getCapSlpItalic62);
  	if( _mgetCapSlpItalic62.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapSlpLeft9063 = _class.GetMethodID("getCapSlpLeft90", _getCapSlpLeft9063);
  	if( _mgetCapSlpLeft9063.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapSlpNearEndSensor64 = _class.GetMethodID("getCapSlpNearEndSensor", _getCapSlpNearEndSensor64);
  	if( _mgetCapSlpNearEndSensor64.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapSlpPresent65 = _class.GetMethodID("getCapSlpPresent", _getCapSlpPresent65);
  	if( _mgetCapSlpPresent65.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapSlpRight9066 = _class.GetMethodID("getCapSlpRight90", _getCapSlpRight9066);
  	if( _mgetCapSlpRight9066.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapSlpRotate18067 = _class.GetMethodID("getCapSlpRotate180", _getCapSlpRotate18067);
  	if( _mgetCapSlpRotate18067.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapSlpUnderline68 = _class.GetMethodID("getCapSlpUnderline", _getCapSlpUnderline68);
  	if( _mgetCapSlpUnderline68.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapTransaction69 = _class.GetMethodID("getCapTransaction", _getCapTransaction69);
  	if( _mgetCapTransaction69.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapJrnCartridgeSensor70 = _class.GetMethodID("getCapJrnCartridgeSensor", _getCapJrnCartridgeSensor70);
  	if( _mgetCapJrnCartridgeSensor70.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapJrnColor71 = _class.GetMethodID("getCapJrnColor", _getCapJrnColor71);
  	if( _mgetCapJrnColor71.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapRecCartridgeSensor72 = _class.GetMethodID("getCapRecCartridgeSensor", _getCapRecCartridgeSensor72);
  	if( _mgetCapRecCartridgeSensor72.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapRecColor73 = _class.GetMethodID("getCapRecColor", _getCapRecColor73);
  	if( _mgetCapRecColor73.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapRecMarkFeed74 = _class.GetMethodID("getCapRecMarkFeed", _getCapRecMarkFeed74);
  	if( _mgetCapRecMarkFeed74.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapSlpBothSidesPrint75 = _class.GetMethodID("getCapSlpBothSidesPrint", _getCapSlpBothSidesPrint75);
  	if( _mgetCapSlpBothSidesPrint75.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapSlpCartridgeSensor76 = _class.GetMethodID("getCapSlpCartridgeSensor", _getCapSlpCartridgeSensor76);
  	if( _mgetCapSlpCartridgeSensor76.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapSlpColor77 = _class.GetMethodID("getCapSlpColor", _getCapSlpColor77);
  	if( _mgetCapSlpColor77.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapMapCharacterSet78 = _class.GetMethodID("getCapMapCharacterSet", _getCapMapCharacterSet78);
  	if( _mgetCapMapCharacterSet78.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapConcurrentPageMode79 = _class.GetMethodID("getCapConcurrentPageMode", _getCapConcurrentPageMode79);
  	if( _mgetCapConcurrentPageMode79.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapRecPageMode80 = _class.GetMethodID("getCapRecPageMode", _getCapRecPageMode80);
  	if( _mgetCapRecPageMode80.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapSlpPageMode81 = _class.GetMethodID("getCapSlpPageMode", _getCapSlpPageMode81);
  	if( _mgetCapSlpPageMode81.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapRecRuledLine82 = _class.GetMethodID("getCapRecRuledLine", _getCapRecRuledLine82);
  	if( _mgetCapRecRuledLine82.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCapSlpRuledLine83 = _class.GetMethodID("getCapSlpRuledLine", _getCapSlpRuledLine83);
  	if( _mgetCapSlpRuledLine83.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetAsyncMode84 = _class.GetMethodID("setAsyncMode", _setAsyncMode84);
  	if( _msetAsyncMode84.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCharacterSet85 = _class.GetMethodID("getCharacterSet", _getCharacterSet85);
  	if( _mgetCharacterSet85.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetCharacterSet86 = _class.GetMethodID("setCharacterSet", _setCharacterSet86);
  	if( _msetCharacterSet86.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCharacterSetList87 = _class.GetMethodID("getCharacterSetList", _getCharacterSetList87);
  	if( _mgetCharacterSetList87.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCoverOpen88 = _class.GetMethodID("getCoverOpen", _getCoverOpen88);
  	if( _mgetCoverOpen88.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetErrorLevel89 = _class.GetMethodID("getErrorLevel", _getErrorLevel89);
  	if( _mgetErrorLevel89.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetErrorStation90 = _class.GetMethodID("getErrorStation", _getErrorStation90);
  	if( _mgetErrorStation90.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetErrorString91 = _class.GetMethodID("getErrorString", _getErrorString91);
  	if( _mgetErrorString91.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetFlagWhenIdle92 = _class.GetMethodID("getFlagWhenIdle", _getFlagWhenIdle92);
  	if( _mgetFlagWhenIdle92.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetFlagWhenIdle93 = _class.GetMethodID("setFlagWhenIdle", _setFlagWhenIdle93);
  	if( _msetFlagWhenIdle93.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetFontTypefaceList94 = _class.GetMethodID("getFontTypefaceList", _getFontTypefaceList94);
  	if( _mgetFontTypefaceList94.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetJrnEmpty95 = _class.GetMethodID("getJrnEmpty", _getJrnEmpty95);
  	if( _mgetJrnEmpty95.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetJrnLetterQuality96 = _class.GetMethodID("getJrnLetterQuality", _getJrnLetterQuality96);
  	if( _mgetJrnLetterQuality96.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetJrnLetterQuality97 = _class.GetMethodID("setJrnLetterQuality", _setJrnLetterQuality97);
  	if( _msetJrnLetterQuality97.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetJrnLineChars98 = _class.GetMethodID("getJrnLineChars", _getJrnLineChars98);
  	if( _mgetJrnLineChars98.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetJrnLineChars99 = _class.GetMethodID("setJrnLineChars", _setJrnLineChars99);
  	if( _msetJrnLineChars99.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetJrnLineCharsList100 = _class.GetMethodID("getJrnLineCharsList", _getJrnLineCharsList100);
  	if( _mgetJrnLineCharsList100.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetJrnLineHeight101 = _class.GetMethodID("getJrnLineHeight", _getJrnLineHeight101);
  	if( _mgetJrnLineHeight101.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetJrnLineHeight102 = _class.GetMethodID("setJrnLineHeight", _setJrnLineHeight102);
  	if( _msetJrnLineHeight102.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetJrnLineSpacing103 = _class.GetMethodID("getJrnLineSpacing", _getJrnLineSpacing103);
  	if( _mgetJrnLineSpacing103.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetJrnLineSpacing104 = _class.GetMethodID("setJrnLineSpacing", _setJrnLineSpacing104);
  	if( _msetJrnLineSpacing104.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetJrnLineWidth105 = _class.GetMethodID("getJrnLineWidth", _getJrnLineWidth105);
  	if( _mgetJrnLineWidth105.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetJrnNearEnd106 = _class.GetMethodID("getJrnNearEnd", _getJrnNearEnd106);
  	if( _mgetJrnNearEnd106.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetMapMode107 = _class.GetMethodID("getMapMode", _getMapMode107);
  	if( _mgetMapMode107.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetMapMode108 = _class.GetMethodID("setMapMode", _setMapMode108);
  	if( _msetMapMode108.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetRecBarCodeRotationList109 = _class.GetMethodID("getRecBarCodeRotationList", _getRecBarCodeRotationList109);
  	if( _mgetRecBarCodeRotationList109.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetRecEmpty110 = _class.GetMethodID("getRecEmpty", _getRecEmpty110);
  	if( _mgetRecEmpty110.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetRecLetterQuality111 = _class.GetMethodID("getRecLetterQuality", _getRecLetterQuality111);
  	if( _mgetRecLetterQuality111.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetRecLetterQuality112 = _class.GetMethodID("setRecLetterQuality", _setRecLetterQuality112);
  	if( _msetRecLetterQuality112.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetRecLineChars113 = _class.GetMethodID("getRecLineChars", _getRecLineChars113);
  	if( _mgetRecLineChars113.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetRecLineChars114 = _class.GetMethodID("setRecLineChars", _setRecLineChars114);
  	if( _msetRecLineChars114.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetRecLineCharsList115 = _class.GetMethodID("getRecLineCharsList", _getRecLineCharsList115);
  	if( _mgetRecLineCharsList115.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetRecLineHeight116 = _class.GetMethodID("getRecLineHeight", _getRecLineHeight116);
  	if( _mgetRecLineHeight116.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetRecLineHeight117 = _class.GetMethodID("setRecLineHeight", _setRecLineHeight117);
  	if( _msetRecLineHeight117.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetRecLineSpacing118 = _class.GetMethodID("getRecLineSpacing", _getRecLineSpacing118);
  	if( _mgetRecLineSpacing118.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetRecLineSpacing119 = _class.GetMethodID("setRecLineSpacing", _setRecLineSpacing119);
  	if( _msetRecLineSpacing119.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetRecLinesToPaperCut120 = _class.GetMethodID("getRecLinesToPaperCut", _getRecLinesToPaperCut120);
  	if( _mgetRecLinesToPaperCut120.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetRecLineWidth121 = _class.GetMethodID("getRecLineWidth", _getRecLineWidth121);
  	if( _mgetRecLineWidth121.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetRecNearEnd122 = _class.GetMethodID("getRecNearEnd", _getRecNearEnd122);
  	if( _mgetRecNearEnd122.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetRecSidewaysMaxChars123 = _class.GetMethodID("getRecSidewaysMaxChars", _getRecSidewaysMaxChars123);
  	if( _mgetRecSidewaysMaxChars123.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetRecSidewaysMaxLines124 = _class.GetMethodID("getRecSidewaysMaxLines", _getRecSidewaysMaxLines124);
  	if( _mgetRecSidewaysMaxLines124.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetRotateSpecial125 = _class.GetMethodID("getRotateSpecial", _getRotateSpecial125);
  	if( _mgetRotateSpecial125.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetRotateSpecial126 = _class.GetMethodID("setRotateSpecial", _setRotateSpecial126);
  	if( _msetRotateSpecial126.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetSlpBarCodeRotationList127 = _class.GetMethodID("getSlpBarCodeRotationList", _getSlpBarCodeRotationList127);
  	if( _mgetSlpBarCodeRotationList127.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetSlpEmpty128 = _class.GetMethodID("getSlpEmpty", _getSlpEmpty128);
  	if( _mgetSlpEmpty128.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetSlpLetterQuality129 = _class.GetMethodID("getSlpLetterQuality", _getSlpLetterQuality129);
  	if( _mgetSlpLetterQuality129.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetSlpLetterQuality130 = _class.GetMethodID("setSlpLetterQuality", _setSlpLetterQuality130);
  	if( _msetSlpLetterQuality130.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetSlpLineChars131 = _class.GetMethodID("getSlpLineChars", _getSlpLineChars131);
  	if( _mgetSlpLineChars131.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetSlpLineChars132 = _class.GetMethodID("setSlpLineChars", _setSlpLineChars132);
  	if( _msetSlpLineChars132.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetSlpLineCharsList133 = _class.GetMethodID("getSlpLineCharsList", _getSlpLineCharsList133);
  	if( _mgetSlpLineCharsList133.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetSlpLineHeight134 = _class.GetMethodID("getSlpLineHeight", _getSlpLineHeight134);
  	if( _mgetSlpLineHeight134.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetSlpLineHeight135 = _class.GetMethodID("setSlpLineHeight", _setSlpLineHeight135);
  	if( _msetSlpLineHeight135.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetSlpLinesNearEndToEnd136 = _class.GetMethodID("getSlpLinesNearEndToEnd", _getSlpLinesNearEndToEnd136);
  	if( _mgetSlpLinesNearEndToEnd136.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetSlpLineSpacing137 = _class.GetMethodID("getSlpLineSpacing", _getSlpLineSpacing137);
  	if( _mgetSlpLineSpacing137.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetSlpLineSpacing138 = _class.GetMethodID("setSlpLineSpacing", _setSlpLineSpacing138);
  	if( _msetSlpLineSpacing138.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetSlpLineWidth139 = _class.GetMethodID("getSlpLineWidth", _getSlpLineWidth139);
  	if( _mgetSlpLineWidth139.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetSlpMaxLines140 = _class.GetMethodID("getSlpMaxLines", _getSlpMaxLines140);
  	if( _mgetSlpMaxLines140.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetSlpNearEnd141 = _class.GetMethodID("getSlpNearEnd", _getSlpNearEnd141);
  	if( _mgetSlpNearEnd141.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetSlpSidewaysMaxChars142 = _class.GetMethodID("getSlpSidewaysMaxChars", _getSlpSidewaysMaxChars142);
  	if( _mgetSlpSidewaysMaxChars142.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetSlpSidewaysMaxLines143 = _class.GetMethodID("getSlpSidewaysMaxLines", _getSlpSidewaysMaxLines143);
  	if( _mgetSlpSidewaysMaxLines143.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetCartridgeNotify144 = _class.GetMethodID("getCartridgeNotify", _getCartridgeNotify144);
  	if( _mgetCartridgeNotify144.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetCartridgeNotify145 = _class.GetMethodID("setCartridgeNotify", _setCartridgeNotify145);
  	if( _msetCartridgeNotify145.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetJrnCartridgeState146 = _class.GetMethodID("getJrnCartridgeState", _getJrnCartridgeState146);
  	if( _mgetJrnCartridgeState146.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetJrnCurrentCartridge147 = _class.GetMethodID("getJrnCurrentCartridge", _getJrnCurrentCartridge147);
  	if( _mgetJrnCurrentCartridge147.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetJrnCurrentCartridge148 = _class.GetMethodID("setJrnCurrentCartridge", _setJrnCurrentCartridge148);
  	if( _msetJrnCurrentCartridge148.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetRecCartridgeState149 = _class.GetMethodID("getRecCartridgeState", _getRecCartridgeState149);
  	if( _mgetRecCartridgeState149.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetRecCurrentCartridge150 = _class.GetMethodID("getRecCurrentCartridge", _getRecCurrentCartridge150);
  	if( _mgetRecCurrentCartridge150.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetRecCurrentCartridge151 = _class.GetMethodID("setRecCurrentCartridge", _setRecCurrentCartridge151);
  	if( _msetRecCurrentCartridge151.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetSlpCartridgeState152 = _class.GetMethodID("getSlpCartridgeState", _getSlpCartridgeState152);
  	if( _mgetSlpCartridgeState152.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetSlpCurrentCartridge153 = _class.GetMethodID("getSlpCurrentCartridge", _getSlpCurrentCartridge153);
  	if( _mgetSlpCurrentCartridge153.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetSlpCurrentCartridge154 = _class.GetMethodID("setSlpCurrentCartridge", _setSlpCurrentCartridge154);
  	if( _msetSlpCurrentCartridge154.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetSlpPrintSide155 = _class.GetMethodID("getSlpPrintSide", _getSlpPrintSide155);
  	if( _mgetSlpPrintSide155.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetMapCharacterSet156 = _class.GetMethodID("getMapCharacterSet", _getMapCharacterSet156);
  	if( _mgetMapCharacterSet156.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetMapCharacterSet157 = _class.GetMethodID("setMapCharacterSet", _setMapCharacterSet157);
  	if( _msetMapCharacterSet157.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetRecBitmapRotationList158 = _class.GetMethodID("getRecBitmapRotationList", _getRecBitmapRotationList158);
  	if( _mgetRecBitmapRotationList158.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetSlpBitmapRotationList159 = _class.GetMethodID("getSlpBitmapRotationList", _getSlpBitmapRotationList159);
  	if( _mgetSlpBitmapRotationList159.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetPageModeArea160 = _class.GetMethodID("getPageModeArea", _getPageModeArea160);
  	if( _mgetPageModeArea160.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetPageModeDescriptor161 = _class.GetMethodID("getPageModeDescriptor", _getPageModeDescriptor161);
  	if( _mgetPageModeDescriptor161.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetPageModeHorizontalPosition162 = _class.GetMethodID("getPageModeHorizontalPosition", _getPageModeHorizontalPosition162);
  	if( _mgetPageModeHorizontalPosition162.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetPageModeHorizontalPosition163 = _class.GetMethodID("setPageModeHorizontalPosition", _setPageModeHorizontalPosition163);
  	if( _msetPageModeHorizontalPosition163.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetPageModePrintArea164 = _class.GetMethodID("getPageModePrintArea", _getPageModePrintArea164);
  	if( _mgetPageModePrintArea164.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetPageModePrintArea165 = _class.GetMethodID("setPageModePrintArea", _setPageModePrintArea165);
  	if( _msetPageModePrintArea165.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetPageModePrintDirection166 = _class.GetMethodID("getPageModePrintDirection", _getPageModePrintDirection166);
  	if( _mgetPageModePrintDirection166.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetPageModePrintDirection167 = _class.GetMethodID("setPageModePrintDirection", _setPageModePrintDirection167);
  	if( _msetPageModePrintDirection167.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetPageModeStation168 = _class.GetMethodID("getPageModeStation", _getPageModeStation168);
  	if( _mgetPageModeStation168.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetPageModeStation169 = _class.GetMethodID("setPageModeStation", _setPageModeStation169);
  	if( _msetPageModeStation169.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetPageModeVerticalPosition170 = _class.GetMethodID("getPageModeVerticalPosition", _getPageModeVerticalPosition170);
  	if( _mgetPageModeVerticalPosition170.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetPageModeVerticalPosition171 = _class.GetMethodID("setPageModeVerticalPosition", _setPageModeVerticalPosition171);
  	if( _msetPageModeVerticalPosition171.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mbeginInsertion172 = _class.GetMethodID("beginInsertion", _beginInsertion172);
  	if( _mbeginInsertion172.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mbeginRemoval173 = _class.GetMethodID("beginRemoval", _beginRemoval173);
  	if( _mbeginRemoval173.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mclearOutput174 = _class.GetMethodID("clearOutput", _clearOutput174);
  	if( _mclearOutput174.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mcutPaper175 = _class.GetMethodID("cutPaper", _cutPaper175);
  	if( _mcutPaper175.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mendInsertion176 = _class.GetMethodID("endInsertion", _endInsertion176);
  	if( _mendInsertion176.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mendRemoval177 = _class.GetMethodID("endRemoval", _endRemoval177);
  	if( _mendRemoval177.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mprintBarCode178 = _class.GetMethodID("printBarCode", _printBarCode178);
  	if( _mprintBarCode178.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mprintBitmap179 = _class.GetMethodID("printBitmap", _printBitmap179);
  	if( _mprintBitmap179.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mprintImmediate180 = _class.GetMethodID("printImmediate", _printImmediate180);
  	if( _mprintImmediate180.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mprintNormal181 = _class.GetMethodID("printNormal", _printNormal181);
  	if( _mprintNormal181.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mprintTwoNormal182 = _class.GetMethodID("printTwoNormal", _printTwoNormal182);
  	if( _mprintTwoNormal182.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mrotatePrint183 = _class.GetMethodID("rotatePrint", _rotatePrint183);
  	if( _mrotatePrint183.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetBitmap184 = _class.GetMethodID("setBitmap", _setBitmap184);
  	if( _msetBitmap184.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_msetLogo185 = _class.GetMethodID("setLogo", _setLogo185);
  	if( _msetLogo185.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mtransactionPrint186 = _class.GetMethodID("transactionPrint", _transactionPrint186);
  	if( _mtransactionPrint186.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mvalidateData187 = _class.GetMethodID("validateData", _validateData187);
  	if( _mvalidateData187.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mchangePrintSide188 = _class.GetMethodID("changePrintSide", _changePrintSide188);
  	if( _mchangePrintSide188.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mmarkFeed189 = _class.GetMethodID("markFeed", _markFeed189);
  	if( _mmarkFeed189.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mclearPrintArea190 = _class.GetMethodID("clearPrintArea", _clearPrintArea190);
  	if( _mclearPrintArea190.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mpageModePrint191 = _class.GetMethodID("pageModePrint", _pageModePrint191);
  	if( _mpageModePrint191.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mprintMemoryBitmap192 = _class.GetMethodID("printMemoryBitmap", _printMemoryBitmap192);
  	if( _mprintMemoryBitmap192.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mdrawRuledLine193 = _class.GetMethodID("drawRuledLine", _drawRuledLine193);
  	if( _mdrawRuledLine193.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_maddOutputCompleteListener194 = _class.GetMethodID("addOutputCompleteListener", _addOutputCompleteListener194);
  	if( _maddOutputCompleteListener194.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mremoveOutputCompleteListener195 = _class.GetMethodID("removeOutputCompleteListener", _removeOutputCompleteListener195);
  	if( _mremoveOutputCompleteListener195.Handle == IntPtr.Zero ) throw new InvalidOperationException();
	}
}
}

namespace jpos.events {
class ErrorListener : JObject {
	protected static JClass _class;
	protected static string _errorOccurred0 = "(Ljpos/events/ErrorEvent;)V";
	protected static JMethodID _merrorOccurred0;

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
	public ErrorListener(JClone<JObject> obj) : base(obj) {} 



	[DebuggerNonUserCode]
	public void errorOccurred(jpos.events.ErrorEvent p0) 
	{
	    JNI.CallVoidMethod(this, _merrorOccurred0, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	static ErrorListener()
	{
  	_class = JNI.FindClass("jpos/events/ErrorListener");
  	if( _class == null ) throw new InvalidOperationException();
  	_merrorOccurred0 = _class.GetMethodID("errorOccurred", _errorOccurred0);
  	if( _merrorOccurred0.Handle == IntPtr.Zero ) throw new InvalidOperationException();
	}
}
}

namespace jpos.events {
class OutputCompleteListener : JObject {
	protected static JClass _class;
	protected static string _outputCompleteOccurred0 = "(Ljpos/events/OutputCompleteEvent;)V";
	protected static JMethodID _moutputCompleteOccurred0;

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
	public OutputCompleteListener(JClone<JObject> obj) : base(obj) {} 



	[DebuggerNonUserCode]
	public void outputCompleteOccurred(jpos.events.OutputCompleteEvent p0) 
	{
	    JNI.CallVoidMethod(this, _moutputCompleteOccurred0, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	static OutputCompleteListener()
	{
  	_class = JNI.FindClass("jpos/events/OutputCompleteListener");
  	if( _class == null ) throw new InvalidOperationException();
  	_moutputCompleteOccurred0 = _class.GetMethodID("outputCompleteOccurred", _outputCompleteOccurred0);
  	if( _moutputCompleteOccurred0.Handle == IntPtr.Zero ) throw new InvalidOperationException();
	}
}
}

namespace jpos.events {
class StatusUpdateListener : JObject {
	protected static JClass _class;
	protected static string _statusUpdateOccurred0 = "(Ljpos/events/StatusUpdateEvent;)V";
	protected static JMethodID _mstatusUpdateOccurred0;

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

	[DebuggerNonUserCode]
	static StatusUpdateListener()
	{
  	_class = JNI.FindClass("jpos/events/StatusUpdateListener");
  	if( _class == null ) throw new InvalidOperationException();
  	_mstatusUpdateOccurred0 = _class.GetMethodID("statusUpdateOccurred", _statusUpdateOccurred0);
  	if( _mstatusUpdateOccurred0.Handle == IntPtr.Zero ) throw new InvalidOperationException();
	}
}
}

namespace jpos.events {
class DirectIOListener : JObject {
	protected static JClass _class;
	protected static string _directIOOccurred0 = "(Ljpos/events/DirectIOEvent;)V";
	protected static JMethodID _mdirectIOOccurred0;

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

	[DebuggerNonUserCode]
	static DirectIOListener()
	{
  	_class = JNI.FindClass("jpos/events/DirectIOListener");
  	if( _class == null ) throw new InvalidOperationException();
  	_mdirectIOOccurred0 = _class.GetMethodID("directIOOccurred", _directIOOccurred0);
  	if( _mdirectIOOccurred0.Handle == IntPtr.Zero ) throw new InvalidOperationException();
	}
}
}

namespace jpos.events {
class DataListener : JObject {
	protected static JClass _class;
	protected static string _dataOccurred0 = "(Ljpos/events/DataEvent;)V";
	protected static JMethodID _mdataOccurred0;

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

	[DebuggerNonUserCode]
	static DataListener()
	{
  	_class = JNI.FindClass("jpos/events/DataListener");
  	if( _class == null ) throw new InvalidOperationException();
  	_mdataOccurred0 = _class.GetMethodID("dataOccurred", _dataOccurred0);
  	if( _mdataOccurred0.Handle == IntPtr.Zero ) throw new InvalidOperationException();
	}
}
}

namespace jpos {
class JposException : JThrowable {
	protected static JClass _class;
	protected static string _init0 = "(IILjava/lang/String;Ljava/lang/Exception;)V";
	protected static string _init1 = "(ILjava/lang/String;Ljava/lang/Exception;)V";
	protected static string _init2 = "(IILjava/lang/String;)V";
	protected static string _init3 = "(I)V";
	protected static string _init4 = "(II)V";
	protected static string _init5 = "(ILjava/lang/String;)V";
	protected static string _getErrorCode0 = "()I";
	protected static string _getErrorCodeExtended1 = "()I";
	protected static string _getOrigException2 = "()Ljava/lang/Exception;";
	protected static JMethodID _minit0;
	protected static JMethodID _minit1;
	protected static JMethodID _minit2;
	protected static JMethodID _minit3;
	protected static JMethodID _minit4;
	protected static JMethodID _minit5;
	protected static JMethodID _mgetErrorCode0;
	protected static JMethodID _mgetErrorCodeExtended1;
	protected static JMethodID _mgetOrigException2;

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
	public int getErrorCodeExtended() 
	{
	    int ret = JNI.CallMethod<int>(this, _mgetErrorCodeExtended1);
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
	    JObject ret = JNI.CallObjectMethod<JObject>(this, _mgetOrigException2);
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }

	    return ret;
	}

	[DebuggerNonUserCode]
	static JposException()
	{
  	_class = JNI.FindClass("jpos/JposException");
  	if( _class == null ) throw new InvalidOperationException();
  	_minit0 = _class.GetMethodID("<init>", _init0);
  	if( _minit0.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_minit1 = _class.GetMethodID("<init>", _init1);
  	if( _minit1.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_minit2 = _class.GetMethodID("<init>", _init2);
  	if( _minit2.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_minit3 = _class.GetMethodID("<init>", _init3);
  	if( _minit3.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_minit4 = _class.GetMethodID("<init>", _init4);
  	if( _minit4.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_minit5 = _class.GetMethodID("<init>", _init5);
  	if( _minit5.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetErrorCode0 = _class.GetMethodID("getErrorCode", _getErrorCode0);
  	if( _mgetErrorCode0.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetErrorCodeExtended1 = _class.GetMethodID("getErrorCodeExtended", _getErrorCodeExtended1);
  	if( _mgetErrorCodeExtended1.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mgetOrigException2 = _class.GetMethodID("getOrigException", _getOrigException2);
  	if( _mgetOrigException2.Handle == IntPtr.Zero ) throw new InvalidOperationException();
	}
}
}

class NativeDataListener : JObject {
public interface Native {

		public void Scanner_DataEvent(NativeDataListener self,jpos.events.DataEvent p0);

	}
	internal static Native? nativeEvents { get; set; }
	protected static JClass _class;
	protected static string _init0 = "()V";
	protected static string _dataOccurred0 = "(Ljpos/events/DataEvent;)V";
	protected static string _Scanner_DataEvent0 = "(Ljpos/events/DataEvent;)V";
	protected static JMethodID _minit0;
	protected static JMethodID _mdataOccurred0;

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
	public static bool TryGet(IntPtr refz, out NativeDataListener? l)
	{
	    NativeDataListener? output = null;
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
	    NativeDataListener? output = null;
	    mapping.RemoveAll((m) => m.TryGetTarget(out output) && object.ReferenceEquals(output, c));
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

	[DebuggerNonUserCode]
	static NativeDataListener()
	{
  	_class = JNI.FindClass("NativeDataListener");
  	if( _class == null ) throw new InvalidOperationException();
  	_minit0 = _class.GetMethodID("<init>", _init0);
  	if( _minit0.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mdataOccurred0 = _class.GetMethodID("dataOccurred", _dataOccurred0);
  	if( _mdataOccurred0.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	        Scanner_DataEventInternal evt = Scanner_DataEvent;
  	    JNI.RegisterNatives(_class, new JNINativeMethod[] {
  	        new JNINativeMethod() { name = "Scanner_DataEvent", signature = _Scanner_DataEvent0, fnPtr = Marshal.GetFunctionPointerForDelegate(evt) },
  	    });
	}
}

class NativeStatusUpdateListener : JObject {
public interface Native {

		public void Scanner_DataEvent(NativeStatusUpdateListener self,jpos.events.StatusUpdateEvent p0);

	}
	internal static Native? nativeEvents { get; set; }
	protected static JClass _class;
	protected static string _init0 = "()V";
	protected static string _statusUpdateOccurred0 = "(Ljpos/events/StatusUpdateEvent;)V";
	protected static string _Scanner_DataEvent0 = "(Ljpos/events/StatusUpdateEvent;)V";
	protected static JMethodID _minit0;
	protected static JMethodID _mstatusUpdateOccurred0;

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
	public static bool TryGet(IntPtr refz, out NativeStatusUpdateListener? l)
	{
	    NativeStatusUpdateListener? output = null;
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

	[DebuggerNonUserCode]
	static NativeStatusUpdateListener()
	{
  	_class = JNI.FindClass("NativeStatusUpdateListener");
  	if( _class == null ) throw new InvalidOperationException();
  	_minit0 = _class.GetMethodID("<init>", _init0);
  	if( _minit0.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_mstatusUpdateOccurred0 = _class.GetMethodID("statusUpdateOccurred", _statusUpdateOccurred0);
  	if( _mstatusUpdateOccurred0.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	        Scanner_DataEventInternal evt = Scanner_DataEvent;
  	    JNI.RegisterNatives(_class, new JNINativeMethod[] {
  	        new JNINativeMethod() { name = "Scanner_DataEvent", signature = _Scanner_DataEvent0, fnPtr = Marshal.GetFunctionPointerForDelegate(evt) },
  	    });
	}
}

class NativeErrorListener : JObject {
public interface Native {

		public void Scanner_DataEvent(NativeErrorListener self,jpos.events.ErrorEvent p0);

	}
	internal static Native? nativeEvents { get; set; }
	protected static JClass _class;
	protected static string _init0 = "()V";
	protected static string _errorOccurred0 = "(Ljpos/events/ErrorEvent;)V";
	protected static string _Scanner_DataEvent0 = "(Ljpos/events/ErrorEvent;)V";
	protected static JMethodID _minit0;
	protected static JMethodID _merrorOccurred0;

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
	public NativeErrorListener(JClone<JObject> obj) : base(obj) {} 

	public NativeErrorListener() : base(initialize()) {}
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
	public static List<WeakReference<NativeErrorListener>> mapping = new List<WeakReference<NativeErrorListener>>();
	public static bool TryGet(IntPtr refz, out NativeErrorListener? l)
	{
	    NativeErrorListener? output = null;
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
	public static void Register(NativeErrorListener c)
	{
	    mapping.Add(new WeakReference<NativeErrorListener>(c));
	}
	public static void Unregister(NativeErrorListener c)
	{
	    NativeErrorListener? output = null;
	    mapping.RemoveAll((m) => m.TryGetTarget(out output) && object.ReferenceEquals(output, c));
	}

	protected static void Scanner_DataEvent(IntPtr JNIEnv,IntPtr objectOrClasss,IntPtr p0) 
	{
	    NativeErrorListener pobject = new NativeErrorListener(new JClone<JObject>() { Value = JNI.NewGlobalRef<JObject>(new JObject(objectOrClasss, JNI.ReferenceType.Local)) });
	    jpos.events.ErrorEvent pp0 = new jpos.events.ErrorEvent(new JClone<JObject>() { Value = JNI.NewGlobalRef<JObject>(new JObject(p0, JNI.ReferenceType.Local)) });
	    nativeEvents?.Scanner_DataEvent(pobject,pp0);
	}

	public void Scanner_DataEvent(jpos.events.ErrorEvent p0) 
	{
	    throw new NotImplementedException();
	}


	[DebuggerNonUserCode]
	public void errorOccurred(jpos.events.ErrorEvent p0) 
	{
	    JNI.CallVoidMethod(this, _merrorOccurred0, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	static NativeErrorListener()
	{
  	_class = JNI.FindClass("NativeErrorListener");
  	if( _class == null ) throw new InvalidOperationException();
  	_minit0 = _class.GetMethodID("<init>", _init0);
  	if( _minit0.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_merrorOccurred0 = _class.GetMethodID("errorOccurred", _errorOccurred0);
  	if( _merrorOccurred0.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	        Scanner_DataEventInternal evt = Scanner_DataEvent;
  	    JNI.RegisterNatives(_class, new JNINativeMethod[] {
  	        new JNINativeMethod() { name = "Scanner_DataEvent", signature = _Scanner_DataEvent0, fnPtr = Marshal.GetFunctionPointerForDelegate(evt) },
  	    });
	}
}

class NativeOutputCompleteListener : JObject {
public interface Native {

		public void Scanner_DataEvent(NativeOutputCompleteListener self,jpos.events.OutputCompleteEvent p0);

	}
	internal static Native? nativeEvents { get; set; }
	protected static JClass _class;
	protected static string _init0 = "()V";
	protected static string _outputCompleteOccurred0 = "(Ljpos/events/OutputCompleteEvent;)V";
	protected static string _Scanner_DataEvent0 = "(Ljpos/events/OutputCompleteEvent;)V";
	protected static JMethodID _minit0;
	protected static JMethodID _moutputCompleteOccurred0;

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
	public NativeOutputCompleteListener(JClone<JObject> obj) : base(obj) {} 

	public NativeOutputCompleteListener() : base(initialize()) {}
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
	public static List<WeakReference<NativeOutputCompleteListener>> mapping = new List<WeakReference<NativeOutputCompleteListener>>();
	public static bool TryGet(IntPtr refz, out NativeOutputCompleteListener? l)
	{
	    NativeOutputCompleteListener? output = null;
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
	public static void Register(NativeOutputCompleteListener c)
	{
	    mapping.Add(new WeakReference<NativeOutputCompleteListener>(c));
	}
	public static void Unregister(NativeOutputCompleteListener c)
	{
	    NativeOutputCompleteListener? output = null;
	    mapping.RemoveAll((m) => m.TryGetTarget(out output) && object.ReferenceEquals(output, c));
	}

	protected static void Scanner_DataEvent(IntPtr JNIEnv,IntPtr objectOrClasss,IntPtr p0) 
	{
	    NativeOutputCompleteListener pobject = new NativeOutputCompleteListener(new JClone<JObject>() { Value = JNI.NewGlobalRef<JObject>(new JObject(objectOrClasss, JNI.ReferenceType.Local)) });
	    jpos.events.OutputCompleteEvent pp0 = new jpos.events.OutputCompleteEvent(new JClone<JObject>() { Value = JNI.NewGlobalRef<JObject>(new JObject(p0, JNI.ReferenceType.Local)) });
	    nativeEvents?.Scanner_DataEvent(pobject,pp0);
	}

	public void Scanner_DataEvent(jpos.events.OutputCompleteEvent p0) 
	{
	    throw new NotImplementedException();
	}


	[DebuggerNonUserCode]
	public void outputCompleteOccurred(jpos.events.OutputCompleteEvent p0) 
	{
	    JNI.CallVoidMethod(this, _moutputCompleteOccurred0, new JValue(p0));
	    bool exception = JNI.ExceptionCheck();
	    if (exception)
	    {
	        JThrowable except = JNI.ExceptionOccurred(); JNI.ExceptionClear(); throw FromThrowable(except);
	    }
	}

	[DebuggerNonUserCode]
	static NativeOutputCompleteListener()
	{
  	_class = JNI.FindClass("NativeOutputCompleteListener");
  	if( _class == null ) throw new InvalidOperationException();
  	_minit0 = _class.GetMethodID("<init>", _init0);
  	if( _minit0.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	_moutputCompleteOccurred0 = _class.GetMethodID("outputCompleteOccurred", _outputCompleteOccurred0);
  	if( _moutputCompleteOccurred0.Handle == IntPtr.Zero ) throw new InvalidOperationException();
  	        Scanner_DataEventInternal evt = Scanner_DataEvent;
  	    JNI.RegisterNatives(_class, new JNINativeMethod[] {
  	        new JNINativeMethod() { name = "Scanner_DataEvent", signature = _Scanner_DataEvent0, fnPtr = Marshal.GetFunctionPointerForDelegate(evt) },
  	    });
	}
}

}
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword
