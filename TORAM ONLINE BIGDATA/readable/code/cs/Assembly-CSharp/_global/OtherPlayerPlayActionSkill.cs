// Assembly: Assembly-CSharp.dll
// Namespace: 
public class OtherPlayerPlayActionSkill : OtherPlayerPlayActionDataBase, IOtherPlayerSkillAction // TypeDefIndex: 1209
{
	// Fields
	[CompilerGenerated]
	private SkillActionBase <SkillAction>k__BackingField; // 0x50
	private BattleManagerBase battleManager; // 0x58

	// Properties
	public SkillActionBase SkillAction { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1F87C3C Offset: 0x1F83C3C VA: 0x1F87C3C Slot: 8
	public SkillActionBase get_SkillAction() { }

	[CompilerGenerated]
	// RVA: 0x1F87C44 Offset: 0x1F83C44 VA: 0x1F87C44
	private void set_SkillAction(SkillActionBase value) { }

	// RVA: 0x1F87C4C Offset: 0x1F83C4C VA: 0x1F87C4C
	public void .ctor(CharacterActionManagerBase actor, GameObject target, Vector3 targetPos, BattleManagerBase battleManager, SkillActionBase action, SkillHitType hitType) { }

	// RVA: 0x1F87EA4 Offset: 0x1F83EA4 VA: 0x1F87EA4 Slot: 4
	protected override void OnStart() { }

	// RVA: 0x1F88310 Offset: 0x1F84310 VA: 0x1F88310 Slot: 5
	protected override void OnUpdate() { }

	// RVA: 0x1F88348 Offset: 0x1F84348 VA: 0x1F88348 Slot: 6
	protected override void OnCancel() { }

	// RVA: 0x1F88374 Offset: 0x1F84374 VA: 0x1F88374 Slot: 7
	protected override void OnEnd() { }

	// RVA: 0x1F88378 Offset: 0x1F84378 VA: 0x1F88378 Slot: 3
	public override string ToString() { }
}
