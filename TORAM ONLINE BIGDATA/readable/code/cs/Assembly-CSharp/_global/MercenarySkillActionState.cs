// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MercenarySkillActionState : MercenaryAIStateBase // TypeDefIndex: 639
{
	// Fields
	[CompilerGenerated]
	private AutoMemberAIRetreat <Retreat>k__BackingField; // 0x30
	[CompilerGenerated]
	private AutoMemberAIAction <AiAction>k__BackingField; // 0x38
	[CompilerGenerated]
	private MercenarySkillDelayManager <SkillDelayManager>k__BackingField; // 0x40
	[CompilerGenerated]
	private AutoMemberBattleManager <BattleManager>k__BackingField; // 0x48
	[CompilerGenerated]
	private SkillBufferManager <SkillBufferManager>k__BackingField; // 0x50
	protected List<Action> transition; // 0x58
	protected GameObject target; // 0x60

	// Properties
	protected AutoMemberAIRetreat Retreat { get; set; }
	protected AutoMemberAIAction AiAction { get; set; }
	protected MercenarySkillDelayManager SkillDelayManager { get; set; }
	protected AutoMemberBattleManager BattleManager { get; set; }
	protected SkillBufferManager SkillBufferManager { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x19E4400 Offset: 0x19E0400 VA: 0x19E4400
	protected AutoMemberAIRetreat get_Retreat() { }

	[CompilerGenerated]
	// RVA: 0x19E4408 Offset: 0x19E0408 VA: 0x19E4408
	public void set_Retreat(AutoMemberAIRetreat value) { }

	[CompilerGenerated]
	// RVA: 0x19E4410 Offset: 0x19E0410 VA: 0x19E4410
	protected AutoMemberAIAction get_AiAction() { }

	[CompilerGenerated]
	// RVA: 0x19E4418 Offset: 0x19E0418 VA: 0x19E4418
	public void set_AiAction(AutoMemberAIAction value) { }

	[CompilerGenerated]
	// RVA: 0x19E4420 Offset: 0x19E0420 VA: 0x19E4420
	protected MercenarySkillDelayManager get_SkillDelayManager() { }

	[CompilerGenerated]
	// RVA: 0x19E4428 Offset: 0x19E0428 VA: 0x19E4428
	public void set_SkillDelayManager(MercenarySkillDelayManager value) { }

	[CompilerGenerated]
	// RVA: 0x19E4430 Offset: 0x19E0430 VA: 0x19E4430
	protected AutoMemberBattleManager get_BattleManager() { }

	[CompilerGenerated]
	// RVA: 0x19E4438 Offset: 0x19E0438 VA: 0x19E4438
	public void set_BattleManager(AutoMemberBattleManager value) { }

	[CompilerGenerated]
	// RVA: 0x19E4440 Offset: 0x19E0440 VA: 0x19E4440
	protected SkillBufferManager get_SkillBufferManager() { }

	[CompilerGenerated]
	// RVA: 0x19E4448 Offset: 0x19E0448 VA: 0x19E4448
	public void set_SkillBufferManager(SkillBufferManager value) { }

	// RVA: 0x19E4450 Offset: 0x19E0450 VA: 0x19E4450 Slot: 13
	public override void ChackTransition(IAICentral central) { }

	// RVA: 0x19E45D4 Offset: 0x19E05D4 VA: 0x19E45D4 Slot: 14
	public override void Dispose() { }

	// RVA: 0x19E45D8 Offset: 0x19E05D8 VA: 0x19E45D8 Slot: 15
	public override void LateUpdate() { }

	// RVA: 0x19E45DC Offset: 0x19E05DC VA: 0x19E45DC Slot: 16
	public override void TurnEnd(IAICentral central) { }

	[IteratorStateMachine(typeof(MercenarySkillActionState.<GetState>d__26))]
	// RVA: 0x19E47F0 Offset: 0x19E07F0 VA: 0x19E47F0 Slot: 17
	protected override IEnumerator GetState() { }

	// RVA: 0x19E4884 Offset: 0x19E0884 VA: 0x19E4884
	protected void TargetMove(SkillActionBase skillBase, Transform target) { }

	// RVA: 0x19E4B54 Offset: 0x19E0B54 VA: 0x19E4B54
	private bool CheckTargetMyself(SkillId checkSkill) { }

	// RVA: 0x19E4BD0 Offset: 0x19E0BD0 VA: 0x19E4BD0
	private bool CheckSpeficSelfSkill(SkillId skillId) { }

	// RVA: 0x19E4BDC Offset: 0x19E0BDC VA: 0x19E4BDC
	public void .ctor() { }
}
