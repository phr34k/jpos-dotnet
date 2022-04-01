namespace JNISharp.NativeInterface;

public readonly struct JFieldID : IEquatable<JFieldID>
{
    public readonly IntPtr Handle { get; init; }

    internal JFieldID(IntPtr handle)
    {
        this.Handle = handle;
    }

    public static implicit operator IntPtr(JFieldID fieldID) => fieldID.Handle;

    public static implicit operator JFieldID(IntPtr pointer) => new(pointer);

    public bool Equals(JFieldID other)
    {
        return this.Handle == other.Handle;
    }
}

public struct JNINativeMethod 
{
    [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPStr)]
    public string name;
    [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPStr)]
    public string signature;
    public IntPtr fnPtr;
}
