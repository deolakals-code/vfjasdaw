// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ShieldCannonAction : PlayerAttackBase, IAbnormalStateSkill // TypeDefIndex: 2965
{
	// Fields
	private float skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private int stunPercent; // 0x128

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }

	// Methods

	// RVA: 0x22EA3A0 Offset: 0x22E63A0 VA: 0x22EA3A0 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22EA3A8 Offset: 0x22E63A8 VA: 0x22EA3A8 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22EA3B0 Offset: 0x22E63B0 VA: 0x22EA3B0 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22EA3B8 Offset: 0x22E63B8 VA: 0x22EA3B8 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22EA3C0 Offset: 0x22E63C0 VA: 0x22EA3C0 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22EA3C8 Offset: 0x22E63C8 VA: 0x22EA3C8 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22EA3D0 Offset: 0x22E63D0 VA: 0x22EA3D0 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22EA3D8 Offset: 0x22E63D8 VA: 0x22EA3D8 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22EA3E0 Offset: 0x22E63E0 VA: 0x22EA3E0 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22EA598 Offset: 0x22E6598 VA: 0x22EA598 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22EA660 Offset: 0x22E6660 VA: 0x22EA660 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22EAB78 Offset: 0x22E6B78 VA: 0x22EAB78 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x22EABDC Offset: 0x22E6BDC VA: 0x22EABDC
	public void .ctor() { }
}
