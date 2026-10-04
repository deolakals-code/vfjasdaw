// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ShieldUpperAction : PlayerAttackBase // TypeDefIndex: 2967
{
	// Fields
	private float skillRate; // 0x120
	private int constantDamage; // 0x124
	private int percent; // 0x128
	private int shieldRefine; // 0x12C

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

	// RVA: 0x22EABF4 Offset: 0x22E6BF4 VA: 0x22EABF4 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22EABFC Offset: 0x22E6BFC VA: 0x22EABFC Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22EAC04 Offset: 0x22E6C04 VA: 0x22EAC04 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22EAC0C Offset: 0x22E6C0C VA: 0x22EAC0C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22EAC14 Offset: 0x22E6C14 VA: 0x22EAC14 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22EAC1C Offset: 0x22E6C1C VA: 0x22EAC1C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22EAC24 Offset: 0x22E6C24 VA: 0x22EAC24 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22EAC2C Offset: 0x22E6C2C VA: 0x22EAC2C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22EAC34 Offset: 0x22E6C34 VA: 0x22EAC34 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22EADAC Offset: 0x22E6DAC VA: 0x22EADAC Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22EAE70 Offset: 0x22E6E70 VA: 0x22EAE70 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22EB200 Offset: 0x22E7200 VA: 0x22EB200 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22EB5DC Offset: 0x22E75DC VA: 0x22EB5DC Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x22EB640 Offset: 0x22E7640 VA: 0x22EB640
	public void .ctor() { }
}
