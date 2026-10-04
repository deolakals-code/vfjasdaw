// Assembly: mscorlib.dll
// Namespace: Microsoft.Win32.SafeHandles
internal sealed class SafePasswordHandle : SafeHandle // TypeDefIndex: 9495
{
	// Properties
	public override bool IsInvalid { get; }

	// Methods

	// RVA: 0x2E7F97C Offset: 0x2E7B97C VA: 0x2E7F97C
	private IntPtr CreateHandle(string password) { }

	// RVA: 0x2E7F9D4 Offset: 0x2E7B9D4 VA: 0x2E7F9D4
	private void FreeHandle() { }

	// RVA: 0x2E7FA30 Offset: 0x2E7BA30 VA: 0x2E7FA30
	public void .ctor(string password) { }

	// RVA: 0x2E7FA6C Offset: 0x2E7BA6C VA: 0x2E7FA6C Slot: 7
	protected override bool ReleaseHandle() { }

	// RVA: 0x2E7FAB0 Offset: 0x2E7BAB0 VA: 0x2E7FAB0 Slot: 6
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2E7FB20 Offset: 0x2E7BB20 VA: 0x2E7FB20 Slot: 5
	public override bool get_IsInvalid() { }

	// RVA: 0x2E7FB48 Offset: 0x2E7BB48 VA: 0x2E7FB48
	internal string Mono_DangerousGetString() { }
}
