// Assembly: Assembly-CSharp.dll
// Namespace: 
public class OtherPlayerPlayActionSupportSkill : OtherPlayerPlayActionDataBase, IOtherPlayerSkillAction // TypeDefIndex: 1210
{
	// Fields
	[CompilerGenerated]
	private float <MoveTime>k__BackingField; // 0x4C
	[CompilerGenerated]
	private SkillActionBase <SkillAction>k__BackingField; // 0x50
	private BattleManagerBase battleManager; // 0x58

	// Properties
	public float MoveTime { get; set; }
	public SkillActionBase SkillAction { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1F8845C Offset: 0x1F8445C VA: 0x1F8845C
	public float get_MoveTime() { }

	[CompilerGenerated]
	// RVA: 0x1F88464 Offset: 0x1F84464 VA: 0x1F88464
	private void set_MoveTime(float value) { }

	[CompilerGenerated]
	// RVA: 0x1F8846C Offset: 0x1F8446C VA: 0x1F8846C Slot: 8
	public SkillActionBase get_SkillAction() { }

	[CompilerGenerated]
	// RVA: 0x1F88474 Offset: 0x1F84474 VA: 0x1F88474
	private void set_SkillAction(SkillActionBase value) { }

	// RVA: 0x1F8847C Offset: 0x1F8447C VA: 0x1F8847C
	public void .ctor(CharacterActionManagerBase actor, GameObject target, Vector3 targetPos, BattleManagerBase battleManager, SkillActionBase action) { }

	// RVA: 0x1F8856C Offset: 0x1F8456C VA: 0x1F8856C Slot: 4
	protected override void OnStart() { }

	// RVA: 0x1F886D4 Offset: 0x1F846D4 VA: 0x1F886D4 Slot: 5
	protected override void OnUpdate() { }

	// RVA: 0x1F88774 Offset: 0x1F84774 VA: 0x1F88774 Slot: 6
	protected override void OnCancel() { }

	// RVA: 0x1F88778 Offset: 0x1F84778 VA: 0x1F88778 Slot: 7
	protected override void OnEnd() { }

	// RVA: 0x1F8877C Offset: 0x1F8477C VA: 0x1F8877C Slot: 3
	public override string ToString() { }
}
