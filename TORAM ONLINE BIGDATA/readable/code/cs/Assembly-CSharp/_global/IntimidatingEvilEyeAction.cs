// Assembly: Assembly-CSharp.dll
// Namespace: 
public class IntimidatingEvilEyeAction : PlayerAttackBase, IAbnormalStateSkill // TypeDefIndex: 2607
{
	// Fields
	private float skillRate; // 0x120
	private int constantDamage; // 0x124
	private int flinchPercent; // 0x128
	private int slowPercent; // 0x12C

	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }

	// Methods

	// RVA: 0x220D8D8 Offset: 0x22098D8 VA: 0x220D8D8 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x220D8E0 Offset: 0x22098E0 VA: 0x220D8E0 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x220D8E8 Offset: 0x22098E8 VA: 0x220D8E8 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x220D8F0 Offset: 0x22098F0 VA: 0x220D8F0 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x220D8F8 Offset: 0x22098F8 VA: 0x220D8F8 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x220D900 Offset: 0x2209900 VA: 0x220D900 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x220D908 Offset: 0x2209908 VA: 0x220D908 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x220D910 Offset: 0x2209910 VA: 0x220D910 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x220D918 Offset: 0x2209918 VA: 0x220D918 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x220DA78 Offset: 0x2209A78 VA: 0x220DA78 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x220DE14 Offset: 0x2209E14 VA: 0x220DE14 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x220E124 Offset: 0x220A124 VA: 0x220E124 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x220E198 Offset: 0x220A198 VA: 0x220E198 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x220E25C Offset: 0x220A25C VA: 0x220E25C
	public void .ctor() { }
}
