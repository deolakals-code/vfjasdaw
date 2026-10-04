// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PetMemberSkillActionManager : PlayerSkillActionManager // TypeDefIndex: 1367
{
	// Fields
	private PetAttackPatternData attackPatternData; // 0xD0
	private PetMemberActionManager petAction; // 0xD8
	[CompilerGenerated]
	private PetAttackPatternData <AttackPattern>k__BackingField; // 0xE0

	// Properties
	private PetAttackPatternData AttackPattern { get; set; }

	// Methods

	// RVA: 0x1FE05F4 Offset: 0x1FDC5F4 VA: 0x1FE05F4
	private void Awake() { }

	[CompilerGenerated]
	// RVA: 0x1FE06BC Offset: 0x1FDC6BC VA: 0x1FE06BC
	private PetAttackPatternData get_AttackPattern() { }

	[CompilerGenerated]
	// RVA: 0x1FE06C4 Offset: 0x1FDC6C4 VA: 0x1FE06C4
	public void set_AttackPattern(PetAttackPatternData value) { }

	// RVA: 0x1FE06CC Offset: 0x1FDC6CC VA: 0x1FE06CC
	public SkillActionBase SetMotionData(GameObject target, SkillActionBase action) { }

	// RVA: 0x1FE0A30 Offset: 0x1FDCA30 VA: 0x1FE0A30 Slot: 9
	public override void SetCurrentSkill(GameObject target, SkillActionBase action) { }

	// RVA: 0x1FE0AC0 Offset: 0x1FDCAC0 VA: 0x1FE0AC0
	protected void startSkill(GameObject target, PetSkillActionBase action) { }

	// RVA: 0x1FE0838 Offset: 0x1FDC838 VA: 0x1FE0838
	public PetSkillActionBase SkillConversion(SkillActionBase skillBase) { }

	// RVA: 0x1FE0FB4 Offset: 0x1FDCFB4 VA: 0x1FE0FB4
	public void .ctor() { }
}
