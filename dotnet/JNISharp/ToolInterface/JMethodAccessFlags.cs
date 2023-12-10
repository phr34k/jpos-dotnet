﻿using System;

namespace JNISharp.ToolInterface;

[Flags]
public enum JMethodAccessFlags
{
    Public = 0x0001,
    Private = 0x0002,
    Protected = 0x0004,
    Static = 0x0008,
    Final = 0x0010,
    Synchronized = 0x0020,
    Bridge = 0x0040,
    VarArgs = 0x0080,
    Native = 0x0100,
    Abstract = 0x400,
    Strict = 0x0800,
    Synthetic = 0x1000
}
