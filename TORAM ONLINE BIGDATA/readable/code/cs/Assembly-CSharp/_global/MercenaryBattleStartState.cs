// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MercenaryBattleStartState : MercenaryAIStateBase // TypeDefIndex: 617
{
	// Fields
	[CompilerGenerated]
	private AutoMemberBattleManager <AutoBattleManager>k__BackingField; // 0x30
	[CompilerGenerated]
	private GameObject <Target>k__BackingField; // 0x38

	// Properties
	protected AutoMemberBattleManager AutoBattleManager { get; set; }
	protected GameObject Target { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x19E03C8 Offset: 0x19DC3C8 VA: 0x19E03C8
	protected AutoMemberBattleManager get_AutoBattleManager() { }

	[CompilerGenerated]
	// RVA: 0x19E03D0 Offset: 0x19DC3D0 VA: 0x19E03D0
	public void set_AutoBattleManager(AutoMemberBattleManager value) { }

	[CompilerGenerated]
	// RVA: 0x19E03D8 Offset: 0x19DC3D8 VA: 0x19E03D8
	protected GameObject get_Target() { }

	[CompilerGenerated]
	// RVA: 0x19E03E0 Offset: 0x19DC3E0 VA: 0x19E03E0
	public void set_Target(GameObject value) { }

	// RVA: 0x19E03E8 Offset: 0x19DC3E8 VA: 0x19E03E8 Slot: 13
	public override void ChackTransition(IAICentral central) { }

	// RVA: 0x19E03EC Offset: 0x19DC3EC VA: 0x19E03EC Slot: 14
	public override void Dispose() { }

	// RVA: 0x19E03F0 Offset: 0x19DC3F0 VA: 0x19E03F0 Slot: 15
	public override void LateUpdate() { }

	// RVA: 0x19E03F4 Offset: 0x19DC3F4 VA: 0x19E03F4 Slot: 16
	public override void TurnEnd(IAICentral central) { }

	[IteratorStateMachine(typeof(MercenaryBattleStartState.<GetState>d__12))]
	// RVA: 0x19E03F8 Offset: 0x19DC3F8 VA: 0x19E03F8 Slot: 17
	protected override IEnumerator GetState() { }

	// RVA: 0x19E048C Offset: 0x19DC48C VA: 0x19E048C
	public void .ctor() { }
}
