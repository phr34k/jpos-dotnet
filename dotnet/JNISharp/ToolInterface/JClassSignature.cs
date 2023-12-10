namespace JNISharp.ToolInterface;

using System.Collections.Generic;

public class JClassSignature
{
    public string Signature { get; init; }

    public string Generic { get; init; }

    public IEnumerable<JFieldSignature> FieldSignatures { get; init; }

    public IEnumerable<JMethodSignature> MethodSignatures { get; init; }

    public JClassSignature(string signature, string generic, IEnumerable<JFieldSignature> fieldSignatures, IEnumerable<JMethodSignature> methodSignatures)
    {
        this.Signature = signature;
        this.Generic = generic;
        this.FieldSignatures = fieldSignatures;
        this.MethodSignatures = methodSignatures;
    }
}
