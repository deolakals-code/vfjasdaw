// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EnchantingEvilEyeAction : PlayerAttackBase, IAbnormalStateSkill // TypeDefIndex: 2606
{
	// Fields
	private float skillRate; // 0x120
	private int constantDamage; // 0x124
	private int percent; // 0x128

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

	// RVA: 0x220D100 Offset: 0x2209100 VA: 0x220D100 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x220D108 Offset: 0x2209108 VA: 0x220D108 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x220D110 Offset: 0x2209110 VA: 0x220D110 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x220D118 Offset: 0x2209118 VA: 0x220D118 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x220D120 Offset: 0x2209120 VA: 0x220D120 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x220D128 Offset: 0x2209128 VA: 0x220D128 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x220D130 Offset: 0x2209130 VA: 0x220D130 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x220D138 Offset: 0x2209138 VA: 0x220D138 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x220D140 Offset: 0x2209140 VA: 0x220D140 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x220D298 Offset: 0x2209298 VA: 0x220D298 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x220D7A8 Offset: 0x22097A8 VA: 0x220D7A8 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x220D80C Offset: 0x220980C VA: 0x220D80C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x220D8D0 Offset: 0x22098D0 VA: 0x220D8D0
	public void .ctor() { }
}
