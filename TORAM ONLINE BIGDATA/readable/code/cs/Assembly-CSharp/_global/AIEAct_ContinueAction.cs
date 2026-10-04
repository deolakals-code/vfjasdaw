// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AIEAct_ContinueAction : AIEventActionState // TypeDefIndex: 1603
{
	// Fields
	private bool continue_flg; // 0x29
	private AIEventActionState[] cheak_ranges; // 0x30

	// Properties
	public override bool ContinueAction { get; }

	// Methods

	// RVA: 0x2091FC0 Offset: 0x208DFC0 VA: 0x2091FC0 Slot: 6
	public override bool get_ContinueAction() { }

	// RVA: 0x2091FC8 Offset: 0x208DFC8 VA: 0x2091FC8
	public void .ctor(IScriptAICentral _manager, AIEventActionState[] _cheak_ranges) { }

	// RVA: 0x2092068 Offset: 0x208E068 VA: 0x2092068 Slot: 11
	public override AIEventActionState Clone() { }

	// RVA: 0x2092120 Offset: 0x208E120 VA: 0x2092120 Slot: 8
	public override void Init() { }

	// RVA: 0x209212C Offset: 0x208E12C VA: 0x209212C Slot: 9
	public override bool Action() { }
}
