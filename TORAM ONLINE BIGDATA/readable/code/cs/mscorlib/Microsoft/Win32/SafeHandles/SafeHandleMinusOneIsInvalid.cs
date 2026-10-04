// Assembly: mscorlib.dll
// Namespace: Microsoft.Win32.SafeHandles
public abstract class SafeHandleMinusOneIsInvalid : SafeHandle // TypeDefIndex: 9499
{
	// Properties
	public override bool IsInvalid { get; }

	// Methods

	[ReliabilityContract(3, 1)]
	// RVA: 0x2E7FD18 Offset: 0x2E7BD18 VA: 0x2E7FD18
	protected void .ctor(bool ownsHandle) { }

	// RVA: 0x2E7FD5C Offset: 0x2E7BD5C VA: 0x2E7FD5C Slot: 5
	public override bool get_IsInvalid() { }
}
