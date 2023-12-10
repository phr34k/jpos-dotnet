namespace JNISharp.ToolInterface;


public class JFieldSignature
{
    public string? Name { get; init; }

    public string Signature { get; init; }

    public string Generic { get; init; }

    public JFieldAccessFlags AccessFlags { get; init; }

    public JFieldSignature(string? name, string sig, string generic, JFieldAccessFlags flags)
    {
        this.Name = name;
        this.Signature = sig;
        this.Generic = generic;
        this.AccessFlags = flags;
    }
}
