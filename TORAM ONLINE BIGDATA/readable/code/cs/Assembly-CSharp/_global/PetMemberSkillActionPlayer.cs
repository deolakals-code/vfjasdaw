// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PetMemberSkillActionPlayer : OtherPlayerSkillActionPlayer // TypeDefIndex: 1327
{
	// Fields
	private PetAttackPatternData attackPatternData; // 0xD0
	private List<NpcSkillData> npcSkillDataList; // 0xD8
	[CompilerGenerated]
	private List<PetSkillData> <NpcSkillDataList>k__BackingField; // 0xE0
	[CompilerGenerated]
	private PetAttackPatternData <AttackPattern>k__BackingField; // 0xE8

	// Properties
	private List<PetSkillData> NpcSkillDataList { get; set; }
	private PetAttackPatternData AttackPattern { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1FD90D0 Offset: 0x1FD50D0 VA: 0x1FD90D0
	private List<PetSkillData> get_NpcSkillDataList() { }

	[CompilerGenerated]
	// RVA: 0x1FD90D8 Offset: 0x1FD50D8 VA: 0x1FD90D8
	public void set_NpcSkillDataList(List<PetSkillData> value) { }

	[CompilerGenerated]
	// RVA: 0x1FD90E0 Offset: 0x1FD50E0 VA: 0x1FD90E0
	private PetAttackPatternData get_AttackPattern() { }

	[CompilerGenerated]
	// RVA: 0x1FD90E8 Offset: 0x1FD50E8 VA: 0x1FD90E8
	public void set_AttackPattern(PetAttackPatternData value) { }

	// RVA: 0x1FD90F0 Offset: 0x1FD50F0 VA: 0x1FD90F0
	public void Awake() { }

	// RVA: 0x1FD90F8 Offset: 0x1FD50F8 VA: 0x1FD90F8 Slot: 9
	public override void SetCurrentSkill(GameObject target, SkillActionBase action) { }

	// RVA: 0x1FD9278 Offset: 0x1FD5278 VA: 0x1FD9278
	public PetSkillActionBase SkillConversion(SkillActionBase skillBase) { }

	// RVA: 0x1FD9458 Offset: 0x1FD5458 VA: 0x1FD9458
	protected void startSkill(GameObject target, PetSkillActionBase action) { }

	// RVA: 0x1FD994C Offset: 0x1FD594C VA: 0x1FD994C
	public void .ctor() { }
}
