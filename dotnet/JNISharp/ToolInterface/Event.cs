﻿namespace JNISharp.ToolInterface;

public static partial class JVMTI
{
    public enum Event
    {
        VmInit = 50,
        VmDeath = 51,
        ThreadStart = 52,
        ThreadEnd = 53,
        ClassFileLoadHook = 54,
        ClassLoad = 55,
        ClassPrepare = 56,
        VmStart = 57,
        Exception = 58,
        ExceptionCatch = 59,
        SingleStep = 60,
        FramePop = 61,
        Breakpoint = 62,
        FieldAccess = 63,
        FieldModification = 64,
        MethodEntry = 65,
        MethodExit = 66,
        NativeMethodBind = 67,
        CompiledMethodLoad = 68,
        CompiledMethodUnload = 69,
        DynamicCodeGenerated = 70,
        DataDumpRequest = 71,
        MonitorWait = 73,
        MonitorWaited = 74,
        MonitorContendedEnter = 75,
        MonitorContendedEntered = 76,
        ResourceExhausted = 80,
        GarbageCollectionStart = 81,
        GarbageCollectionFinish = 82,
        ObjectFree = 83,
        VmObjectAlloc = 84
    }
}
