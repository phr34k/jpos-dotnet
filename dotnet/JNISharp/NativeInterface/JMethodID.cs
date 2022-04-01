﻿namespace JNISharp.NativeInterface;

public readonly struct JMethodID : IEquatable<JMethodID>
{
    public readonly IntPtr Handle { get; init; }

    internal JMethodID(IntPtr handle)
    {
        this.Handle = handle;
    }

    public static implicit operator IntPtr(JMethodID methodID) => methodID.Handle;

    public static implicit operator JMethodID(IntPtr pointer) => new(pointer);

    public bool Equals(JMethodID other)
    {
        return this.Handle == other.Handle;
    }
}
