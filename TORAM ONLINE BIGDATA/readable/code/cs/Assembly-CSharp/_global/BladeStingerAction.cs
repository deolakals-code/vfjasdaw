// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BladeStingerAction : PlayerAttackBase // TypeDefIndex: 2624
{
	// Fields
	private int skillRateBase; // 0x120
	private int secondSkillRateBase; // 0x124
	private int addSkillRate; // 0x128
	private int fixAddDamage; // 0x12C
	private int physicsResistBreaker; // 0x130
	private bool isAvoidPossible; // 0x134

	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public bool IsAvoidPossible { get; }

	// Methods

	// RVA: 0x22160C8 Offset: 0x22120C8 VA: 0x22160C8 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22160D0 Offset: 0x22120D0 VA: 0x22160D0 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22160D8 Offset: 0x22120D8 VA: 0x22160D8 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22160E0 Offset: 0x22120E0 VA: 0x22160E0 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22160E8 Offset: 0x22120E8 VA: 0x22160E8 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22160F0 Offset: 0x22120F0 VA: 0x22160F0 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22160F8 Offset: 0x22120F8 VA: 0x22160F8 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2216100 Offset: 0x2212100 VA: 0x2216100 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2216108 Offset: 0x2212108 VA: 0x2216108
	public bool get_IsAvoidPossible() { }

	// RVA: 0x2216110 Offset: 0x2212110 VA: 0x2216110 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22164A8 Offset: 0x22124A8 VA: 0x22164A8 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22166A4 Offset: 0x22126A4 VA: 0x22166A4 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x221681C Offset: 0x221281C VA: 0x221681C Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x2216858 Offset: 0x2212858 VA: 0x2216858 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2216F30 Offset: 0x2212F30 VA: 0x2216F30
	public void .ctor() { }
}
