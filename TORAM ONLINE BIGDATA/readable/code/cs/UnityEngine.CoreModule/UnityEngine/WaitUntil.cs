// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public sealed class WaitUntil : CustomYieldInstruction // TypeDefIndex: 16383
{
	// Fields
	private Func<bool> m_Predicate; // 0x10

	// Properties
	public override bool keepWaiting { get; }

	// Methods

	// RVA: 0x37F14D4 Offset: 0x37ED4D4 VA: 0x37F14D4 Slot: 7
	public override bool get_keepWaiting() { }

	// RVA: 0x37F1504 Offset: 0x37ED504 VA: 0x37F1504
	public void .ctor(Func<bool> predicate) { }
}
