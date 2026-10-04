// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PetDefaultSkillActionState : MercenaryAIStateBase // TypeDefIndex: 1276
{
	// Fields
	[CompilerGenerated]
	private AutoMemberAIRetreat <Retreat>k__BackingField; // 0x30
	[CompilerGenerated]
	private AutoMemberAIAction <AiAction>k__BackingField; // 0x38
	[CompilerGenerated]
	private SkillDelayManager <SkillDelayManager>k__BackingField; // 0x40
	[CompilerGenerated]
	private AutoMemberBattleManager <BattleManager>k__BackingField; // 0x48
	protected List<Action> transition; // 0x50
	protected GameObject target; // 0x58

	// Properties
	protected AutoMemberAIRetreat Retreat { get; set; }
	protected AutoMemberAIAction AiAction { get; set; }
	protected SkillDelayManager SkillDelayManager { get; set; }
	protected AutoMemberBattleManager BattleManager { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1FB06BC Offset: 0x1FAC6BC VA: 0x1FB06BC
	protected AutoMemberAIRetreat get_Retreat() { }

	[CompilerGenerated]
	// RVA: 0x1FB06C4 Offset: 0x1FAC6C4 VA: 0x1FB06C4
	public void set_Retreat(AutoMemberAIRetreat value) { }

	[CompilerGenerated]
	// RVA: 0x1FB06CC Offset: 0x1FAC6CC VA: 0x1FB06CC
	protected AutoMemberAIAction get_AiAction() { }

	[CompilerGenerated]
	// RVA: 0x1FB06D4 Offset: 0x1FAC6D4 VA: 0x1FB06D4
	public void set_AiAction(AutoMemberAIAction value) { }

	[CompilerGenerated]
	// RVA: 0x1FB06DC Offset: 0x1FAC6DC VA: 0x1FB06DC
	protected SkillDelayManager get_SkillDelayManager() { }

	[CompilerGenerated]
	// RVA: 0x1FB06E4 Offset: 0x1FAC6E4 VA: 0x1FB06E4
	public void set_SkillDelayManager(SkillDelayManager value) { }

	[CompilerGenerated]
	// RVA: 0x1FB06EC Offset: 0x1FAC6EC VA: 0x1FB06EC
	protected AutoMemberBattleManager get_BattleManager() { }

	[CompilerGenerated]
	// RVA: 0x1FB06F4 Offset: 0x1FAC6F4 VA: 0x1FB06F4
	public void set_BattleManager(AutoMemberBattleManager value) { }

	// RVA: 0x1FAF67C Offset: 0x1FAB67C VA: 0x1FAF67C
	public void .ctor() { }

	// RVA: 0x1FB06FC Offset: 0x1FAC6FC VA: 0x1FB06FC Slot: 13
	public override void ChackTransition(IAICentral central) { }

	// RVA: 0x1FB0984 Offset: 0x1FAC984 VA: 0x1FB0984 Slot: 14
	public override void Dispose() { }

	// RVA: 0x1FB0988 Offset: 0x1FAC988 VA: 0x1FB0988 Slot: 15
	public override void LateUpdate() { }

	// RVA: 0x1FB098C Offset: 0x1FAC98C VA: 0x1FB098C Slot: 16
	public override void TurnEnd(IAICentral central) { }

	[IteratorStateMachine(typeof(PetDefaultSkillActionState.<GetState>d__23))]
	// RVA: 0x1FB0BA0 Offset: 0x1FACBA0 VA: 0x1FB0BA0 Slot: 17
	protected override IEnumerator GetState() { }

	// RVA: 0x1FB0C14 Offset: 0x1FACC14 VA: 0x1FB0C14
	protected void TargetMove(SkillActionBase skillBase, Transform target) { }
}
