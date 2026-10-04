// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SonicThrustAction : PlayerAttackBase // TypeDefIndex: 2752
{
	// Fields
	private float skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private int percent; // 0x128
	private ItemDBData.ItemType subWeaponType; // 0x12C

	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	protected override bool IsMotionSpeedVariable { get; }

	// Methods

	// RVA: 0x2256E78 Offset: 0x2252E78 VA: 0x2256E78 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2256E80 Offset: 0x2252E80 VA: 0x2256E80 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2256E88 Offset: 0x2252E88 VA: 0x2256E88 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2256E90 Offset: 0x2252E90 VA: 0x2256E90 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2256E98 Offset: 0x2252E98 VA: 0x2256E98 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2256EA0 Offset: 0x2252EA0 VA: 0x2256EA0 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2256EA8 Offset: 0x2252EA8 VA: 0x2256EA8 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2256EB0 Offset: 0x2252EB0 VA: 0x2256EB0 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2256EB8 Offset: 0x2252EB8 VA: 0x2256EB8 Slot: 74
	protected override bool get_IsMotionSpeedVariable() { }

	// RVA: 0x2256EC0 Offset: 0x2252EC0 VA: 0x2256EC0 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2257168 Offset: 0x2253168 VA: 0x2257168 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2257264 Offset: 0x2253264 VA: 0x2257264 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2257384 Offset: 0x2253384 VA: 0x2257384 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22577B0 Offset: 0x22537B0 VA: 0x22577B0 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x2257814 Offset: 0x2253814 VA: 0x2257814
	public bool CheckMpHeal(EnemyMobActionManagerBase mobAction) { }

	// RVA: 0x2257894 Offset: 0x2253894 VA: 0x2257894
	public void .ctor() { }
}
