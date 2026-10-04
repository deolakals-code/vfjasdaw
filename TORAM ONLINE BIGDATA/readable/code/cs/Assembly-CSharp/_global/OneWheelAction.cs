// Assembly: Assembly-CSharp.dll
// Namespace: 
public class OneWheelAction : PlayerAttackBase // TypeDefIndex: 2996
{
	// Fields
	private float skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private int[] difBreakPercent; // 0x128

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

	// RVA: 0x22F80C8 Offset: 0x22F40C8 VA: 0x22F80C8 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22F80D0 Offset: 0x22F40D0 VA: 0x22F80D0 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22F80D8 Offset: 0x22F40D8 VA: 0x22F80D8 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22F80E0 Offset: 0x22F40E0 VA: 0x22F80E0 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22F80E8 Offset: 0x22F40E8 VA: 0x22F80E8 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22F80F0 Offset: 0x22F40F0 VA: 0x22F80F0 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22F80F8 Offset: 0x22F40F8 VA: 0x22F80F8 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22F8100 Offset: 0x22F4100 VA: 0x22F8100 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22F8108 Offset: 0x22F4108 VA: 0x22F8108 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22F8364 Offset: 0x22F4364 VA: 0x22F8364 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22F8520 Offset: 0x22F4520 VA: 0x22F8520 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22F85A4 Offset: 0x22F45A4 VA: 0x22F85A4 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22F89A4 Offset: 0x22F49A4 VA: 0x22F89A4
	public void .ctor() { }
}
