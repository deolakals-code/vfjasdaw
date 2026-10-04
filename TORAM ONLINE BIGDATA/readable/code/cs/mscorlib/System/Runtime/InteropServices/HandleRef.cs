// Assembly: mscorlib.dll
// Namespace: System.Runtime.InteropServices
[IsReadOnly]
public struct HandleRef // TypeDefIndex: 10436
{
	// Fields
	private readonly object _wrapper; // 0x0
	private readonly IntPtr _handle; // 0x8

	// Properties
	public IntPtr Handle { get; }

	// Methods

	// RVA: 0x2F1CF8C Offset: 0x2F18F8C VA: 0x2F1CF8C
	public void .ctor(object wrapper, IntPtr handle) { }

	// RVA: 0x2F1CFB4 Offset: 0x2F18FB4 VA: 0x2F1CFB4
	public IntPtr get_Handle() { }
}
