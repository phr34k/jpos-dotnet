namespace JNISharp.NativeInterface;

public class JThrowable : JObject
{
    public JThrowable() { }
    public JThrowable(IJClone<JObject> obj) : base(obj) { }

    public string GetMessage() => JNI.FindClass("java/lang/Throwable").CallObjectMethod<JString>(this, "getMessage", "()Ljava/lang/String;").GetString();

    public void printStackTrace() => JNI.FindClass("java/lang/Throwable").CallVoidMethod(this, "printStackTrace", "()V");

    public override string ToString() => JNI.FindClass("java/lang/Throwable").CallObjectMethod<JString>(this, "toString", "()Ljava/lang/String;").GetString();
}
