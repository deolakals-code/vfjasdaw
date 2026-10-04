// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MercenarySkillExecuteState : MercenaryAIStateBase // TypeDefIndex: 641
{
	// Fields
	[CompilerGenerated]
	private SkillActionBase <Skill>k__BackingField; // 0x30
	[CompilerGenerated]
	private GameObject <Target>k__BackingField; // 0x38
	[CompilerGenerated]
	private MercenarySkillDelayManager <skillDelayManager>k__BackingField; // 0x40
	[CompilerGenerated]
	private Func<GameObject, SkillActionBase, bool, bool, bool> <Reserve>k__BackingField; // 0x48

	// Properties
	private SkillActionBase Skill { get; set; }
	private GameObject Target { get; set; }
	private MercenarySkillDelayManager skillDelayManager { get; set; }
	private Func<GameObject, SkillActionBase, bool, bool, bool> Reserve { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x19E54B0 Offset: 0x19E14B0 VA: 0x19E54B0
	private SkillActionBase get_Skill() { }

	[CompilerGenerated]
	// RVA: 0x19E54B8 Offset: 0x19E14B8 VA: 0x19E54B8
	public void set_Skill(SkillActionBase value) { }

	[CompilerGenerated]
	// RVA: 0x19E54C0 Offset: 0x19E14C0 VA: 0x19E54C0
	private GameObject get_Target() { }

	[CompilerGenerated]
	// RVA: 0x19E54C8 Offset: 0x19E14C8 VA: 0x19E54C8
	public void set_Target(GameObject value) { }

	[CompilerGenerated]
	// RVA: 0x19E54D0 Offset: 0x19E14D0 VA: 0x19E54D0
	private MercenarySkillDelayManager get_skillDelayManager() { }

	[CompilerGenerated]
	// RVA: 0x19E54D8 Offset: 0x19E14D8 VA: 0x19E54D8
	public void set_skillDelayManager(MercenarySkillDelayManager value) { }

	[CompilerGenerated]
	// RVA: 0x19E54E0 Offset: 0x19E14E0 VA: 0x19E54E0
	private Func<GameObject, SkillActionBase, bool, bool, bool> get_Reserve() { }

	[CompilerGenerated]
	// RVA: 0x19E54E8 Offset: 0x19E14E8 VA: 0x19E54E8
	public void set_Reserve(Func<GameObject, SkillActionBase, bool, bool, bool> value) { }

	// RVA: 0x19E54F0 Offset: 0x19E14F0 VA: 0x19E54F0 Slot: 13
	public override void ChackTransition(IAICentral central) { }

	// RVA: 0x19E54F4 Offset: 0x19E14F4 VA: 0x19E54F4 Slot: 14
	public override void Dispose() { }

	// RVA: 0x19E54F8 Offset: 0x19E14F8 VA: 0x19E54F8 Slot: 15
	public override void LateUpdate() { }

	// RVA: 0x19E54FC Offset: 0x19E14FC VA: 0x19E54FC Slot: 16
	public override void TurnEnd(IAICentral central) { }

	[IteratorStateMachine(typeof(MercenarySkillExecuteState.<GetState>d__20))]
	// RVA: 0x19E55D4 Offset: 0x19E15D4 VA: 0x19E55D4 Slot: 17
	protected override IEnumerator GetState() { }

	// RVA: 0x19E5668 Offset: 0x19E1668 VA: 0x19E5668
	public void .ctor() { }
}
