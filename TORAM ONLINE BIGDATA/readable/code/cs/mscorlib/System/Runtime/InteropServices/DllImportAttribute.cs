// Assembly: mscorlib.dll
// Namespace: System.Runtime.InteropServices
[Usage(64, Inherited = False)]
[ComVisible(True)]
public sealed class DllImportAttribute : Attribute // TypeDefIndex: 10461
{
	// Fields
	internal string _val; // 0x10
	public string EntryPoint; // 0x18
	public CharSet CharSet; // 0x20
	public bool SetLastError; // 0x24
	public bool ExactSpelling; // 0x25
	public bool PreserveSig; // 0x26
	public CallingConvention CallingConvention; // 0x28
	public bool BestFitMapping; // 0x2C
	public bool ThrowOnUnmappableChar; // 0x2D

	// Properties
	public string Value { get; }

	// Methods

	// RVA: 0x2F1D69C Offset: 0x2F1969C VA: 0x2F1D69C
	internal static Attribute GetCustomAttribute(RuntimeMethodInfo method) { }

	// RVA: 0x2F1D8F0 Offset: 0x2F198F0 VA: 0x2F1D8F0
	internal static bool IsDefined(RuntimeMethodInfo method) { }

	// RVA: 0x2F1D848 Offset: 0x2F19848 VA: 0x2F1D848
	internal void .ctor(string dllName, string entryPoint, CharSet charSet, bool exactSpelling, bool setLastError, bool preserveSig, CallingConvention callingConvention, bool bestFitMapping, bool throwOnUnmappableChar) { }

	// RVA: 0x2F1D918 Offset: 0x2F19918 VA: 0x2F1D918
	public void .ctor(string dllName) { }

	// RVA: 0x2F1D948 Offset: 0x2F19948 VA: 0x2F1D948
	public string get_Value() { }
}
