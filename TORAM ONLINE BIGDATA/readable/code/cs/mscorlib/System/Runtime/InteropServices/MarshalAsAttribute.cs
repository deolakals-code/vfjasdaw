// Assembly: mscorlib.dll
// Namespace: System.Runtime.InteropServices
[Usage(10496, Inherited = False)]
[ComVisible(True)]
public sealed class MarshalAsAttribute : Attribute // TypeDefIndex: 10471
{
	// Fields
	public string MarshalCookie; // 0x10
	[ComVisible(True)]
	public string MarshalType; // 0x18
	[ComVisible(True)]
	public Type MarshalTypeRef; // 0x20
	public Type SafeArrayUserDefinedSubType; // 0x28
	private UnmanagedType utype; // 0x30
	public UnmanagedType ArraySubType; // 0x34
	public VarEnum SafeArraySubType; // 0x38
	public int SizeConst; // 0x3C
	public int IidParameterIndex; // 0x40
	public short SizeParamIndex; // 0x44

	// Properties
	public UnmanagedType Value { get; }

	// Methods

	// RVA: 0x2F1FAAC Offset: 0x2F1BAAC VA: 0x2F1FAAC
	public void .ctor(UnmanagedType unmanagedType) { }

	// RVA: 0x2F1FAD4 Offset: 0x2F1BAD4 VA: 0x2F1FAD4
	public UnmanagedType get_Value() { }

	// RVA: 0x2F1FADC Offset: 0x2F1BADC VA: 0x2F1FADC
	internal MarshalAsAttribute Copy() { }
}
