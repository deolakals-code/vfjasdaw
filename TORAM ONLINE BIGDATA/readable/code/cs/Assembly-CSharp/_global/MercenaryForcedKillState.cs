// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MercenaryForcedKillState : MercenaryAIStateBase // TypeDefIndex: 629
{
	// Fields
	private bool isWarp; // 0x30
	[CompilerGenerated]
	private Action EndCallback; // 0x38

	// Methods

	[CompilerGenerated]
	// RVA: 0x19E2ECC Offset: 0x19DEECC VA: 0x19E2ECC
	public void add_EndCallback(Action value) { }

	[CompilerGenerated]
	// RVA: 0x19E2F68 Offset: 0x19DEF68 VA: 0x19E2F68
	public void remove_EndCallback(Action value) { }

	// RVA: 0x19E3004 Offset: 0x19DF004 VA: 0x19E3004 Slot: 13
	public override void ChackTransition(IAICentral central) { }

	// RVA: 0x19E312C Offset: 0x19DF12C VA: 0x19E312C Slot: 14
	public override void Dispose() { }

	// RVA: 0x19E3148 Offset: 0x19DF148 VA: 0x19E3148 Slot: 15
	public override void LateUpdate() { }

	// RVA: 0x19E314C Offset: 0x19DF14C VA: 0x19E314C Slot: 16
	public override void TurnEnd(IAICentral central) { }

	[IteratorStateMachine(typeof(MercenaryForcedKillState.<GetState>d__8))]
	// RVA: 0x19E3168 Offset: 0x19DF168 VA: 0x19E3168 Slot: 17
	protected override IEnumerator GetState() { }

	// RVA: 0x19E31FC Offset: 0x19DF1FC VA: 0x19E31FC
	public void .ctor() { }
}
