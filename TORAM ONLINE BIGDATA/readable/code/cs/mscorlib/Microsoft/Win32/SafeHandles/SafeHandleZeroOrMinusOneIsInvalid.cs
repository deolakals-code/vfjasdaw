// Assembly: mscorlib.dll
// Namespace: Microsoft.Win32.SafeHandles
public abstract class SafeHandleZeroOrMinusOneIsInvalid : SafeHandle // TypeDefIndex: 9498
{
	// Properties
	public override bool IsInvalid { get; }

	// Methods

	[ReliabilityContract(3, 1)]
	// RVA: 0x2E7FBD4 Offset: 0x2E7BBD4 VA: 0x2E7FBD4
	protected void .ctor(bool ownsHandle) { }

	// RVA: 0x2E7FCBC Offset: 0x2E7BCBC VA: 0x2E7FCBC Slot: 5
	public override bool get_IsInvalid() { }
}
