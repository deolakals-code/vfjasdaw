// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SpiralAirAction : PlayerAttackBase // TypeDefIndex: 2571
{
	// Fields
	private float skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private int hitCount; // 0x128

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

	// RVA: 0x21FAA3C Offset: 0x21F6A3C VA: 0x21FAA3C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x21FAA44 Offset: 0x21F6A44 VA: 0x21FAA44 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x21FAA4C Offset: 0x21F6A4C VA: 0x21FAA4C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x21FAA54 Offset: 0x21F6A54 VA: 0x21FAA54 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x21FAA5C Offset: 0x21F6A5C VA: 0x21FAA5C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x21FAA64 Offset: 0x21F6A64 VA: 0x21FAA64 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x21FAA6C Offset: 0x21F6A6C VA: 0x21FAA6C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x21FAA74 Offset: 0x21F6A74 VA: 0x21FAA74 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x21FAA7C Offset: 0x21F6A7C VA: 0x21FAA7C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x21FAC0C Offset: 0x21F6C0C VA: 0x21FAC0C Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x21FAF34 Offset: 0x21F6F34 VA: 0x21FAF34 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x21FB1B8 Offset: 0x21F71B8 VA: 0x21FB1B8 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x21FB3E8 Offset: 0x21F73E8 VA: 0x21FB3E8 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x21FBA84 Offset: 0x21F7A84 VA: 0x21FBA84
	public static void ReceiveMobaAttack(AttackResponseData attackResponseData, MobaPlayerActionManager actionManager) { }

	// RVA: 0x21FBD14 Offset: 0x21F7D14 VA: 0x21FBD14
	public void .ctor() { }
}
