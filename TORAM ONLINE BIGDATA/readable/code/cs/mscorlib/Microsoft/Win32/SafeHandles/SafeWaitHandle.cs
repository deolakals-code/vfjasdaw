// Assembly: mscorlib.dll
// Namespace: Microsoft.Win32.SafeHandles
public sealed class SafeWaitHandle : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 9497
{
	// Methods

	// RVA: 0x2E7FC60 Offset: 0x2E7BC60 VA: 0x2E7FC60
	private void .ctor() { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x2E7FC70 Offset: 0x2E7BC70 VA: 0x2E7FC70
	public void .ctor(IntPtr existingHandle, bool ownsHandle) { }

	// RVA: 0x2E7FCA0 Offset: 0x2E7BCA0 VA: 0x2E7FCA0 Slot: 7
	protected override bool ReleaseHandle() { }
}
