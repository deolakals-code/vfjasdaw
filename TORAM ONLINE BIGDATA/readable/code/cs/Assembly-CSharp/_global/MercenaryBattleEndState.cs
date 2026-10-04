// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MercenaryBattleEndState : MercenaryAIStateBase // TypeDefIndex: 615
{
	// Fields
	[CompilerGenerated]
	private AutoMemberBattleManager <AutoBattleManager>k__BackingField; // 0x30

	// Properties
	protected AutoMemberBattleManager AutoBattleManager { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x19E00C0 Offset: 0x19DC0C0 VA: 0x19E00C0
	protected AutoMemberBattleManager get_AutoBattleManager() { }

	[CompilerGenerated]
	// RVA: 0x19E00C8 Offset: 0x19DC0C8 VA: 0x19E00C8
	public void set_AutoBattleManager(AutoMemberBattleManager value) { }

	// RVA: 0x19E00D0 Offset: 0x19DC0D0 VA: 0x19E00D0
	public void .ctor() { }

	// RVA: 0x19E00D4 Offset: 0x19DC0D4 VA: 0x19E00D4 Slot: 13
	public override void ChackTransition(IAICentral central) { }

	// RVA: 0x19E00D8 Offset: 0x19DC0D8 VA: 0x19E00D8 Slot: 14
	public override void Dispose() { }

	// RVA: 0x19E00DC Offset: 0x19DC0DC VA: 0x19E00DC Slot: 15
	public override void LateUpdate() { }

	// RVA: 0x19E00E0 Offset: 0x19DC0E0 VA: 0x19E00E0 Slot: 16
	public override void TurnEnd(IAICentral central) { }

	[IteratorStateMachine(typeof(MercenaryBattleEndState.<GetState>d__9))]
	// RVA: 0x19E02AC Offset: 0x19DC2AC VA: 0x19E02AC Slot: 17
	protected override IEnumerator GetState() { }
}
