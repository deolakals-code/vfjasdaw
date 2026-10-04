// Assembly: mscorlib.dll
// Namespace: System.Runtime.InteropServices
public abstract class SafeBuffer : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 10440
{
	// Fields
	private static readonly UIntPtr Uninitialized; // 0x0
	private UIntPtr _numBytes; // 0x20

	// Methods

	[CLSCompliant(False)]
	// RVA: 0x2F1D044 Offset: 0x2F19044 VA: 0x2F1D044
	public void AcquirePointer(ref byte* pointer) { }

	// RVA: 0x2F1D244 Offset: 0x2F19244 VA: 0x2F1D244
	public void ReleasePointer() { }

	// RVA: 0x2F1D114 Offset: 0x2F19114 VA: 0x2F1D114
	private static InvalidOperationException NotInitialized() { }

	// RVA: 0x2F1D2F4 Offset: 0x2F192F4 VA: 0x2F1D2F4
	private static void .cctor() { }
}
