// Assembly: mscorlib.dll
// Namespace: System
internal sealed class Gen2GcCallback : CriticalFinalizerObject // TypeDefIndex: 9583
{
	// Fields
	private Func<object, bool> _callback; // 0x10
	private GCHandle _weakTargetObj; // 0x18

	// Methods

	// RVA: 0x2FCEFE8 Offset: 0x2FCAFE8 VA: 0x2FCEFE8
	private void .ctor() { }

	// RVA: 0x2FCEFF0 Offset: 0x2FCAFF0 VA: 0x2FCEFF0
	public static void Register(Func<object, bool> callback, object targetObj) { }

	// RVA: 0x2FCF07C Offset: 0x2FCB07C VA: 0x2FCF07C
	private void Setup(Func<object, bool> callback, object targetObj) { }

	// RVA: 0x2FCF0B8 Offset: 0x2FCB0B8 VA: 0x2FCF0B8 Slot: 1
	protected override void Finalize() { }
}
