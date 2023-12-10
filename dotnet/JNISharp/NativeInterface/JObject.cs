using System;

namespace JNISharp.NativeInterface;

public class JObject : IDisposable
{
    private bool Disposed { get; set; }

    public IntPtr Handle { get; init; }

    internal JNI.ReferenceType ReferenceType { get; init; }

    public JObject() { }

    public JObject(IntPtr handle, JNI.ReferenceType referenceType)
    {
        this.Handle = handle;
        this.ReferenceType = referenceType;
    }

    public JObject(IJClone<JObject> obj) : this(obj.Value.Handle, obj.Value.ReferenceType) 
    {
        this.Disposed = obj.Value.Disposed;
        obj.Value.Disposed = true;
    }

    protected virtual void Dispose(bool disposing)
    {
        if (Disposed || this.Handle == IntPtr.Zero)
            return;

        switch (this.ReferenceType)
        {
            case JNI.ReferenceType.Local:
                JNI.DeleteLocalRef(this);
                break;

            case JNI.ReferenceType.Global:
                JNI.DeleteGlobalRef(this);
                break;

            case JNI.ReferenceType.WeakGlobal:
                JNI.DeleteWeakGlobalRef(this);
                break;
        }

        Disposed = true;
    }

    public bool Valid()
    {
        return this.Handle != IntPtr.Zero;
    }

    ~JObject()
    {
        Dispose(disposing: false);
    }

    public void Dispose()
    {
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}



public interface IJClone<T>
{
    T Value { get; }
}

public struct JClone<T> : IJClone<JObject> where T : JObject
{
   public T Value { get; init; }
   JObject IJClone<JObject>.Value => Value;
}
