// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DarkStingerAction : PlayerAttackBase // TypeDefIndex: 2602
{
	// Fields
	private float skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private int consumptionHpRate; // 0x128
	private float rad; // 0x12C
	private Vector3 attackPos; // 0x130
	private Vector3 attackDir; // 0x13C

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPayHp { get; }

	// Methods

	// RVA: 0x220B0B8 Offset: 0x22070B8 VA: 0x220B0B8 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x220B0C0 Offset: 0x22070C0 VA: 0x220B0C0 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x220B0C8 Offset: 0x22070C8 VA: 0x220B0C8 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x220B0D0 Offset: 0x22070D0 VA: 0x220B0D0 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x220B0D8 Offset: 0x22070D8 VA: 0x220B0D8 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x220B0E0 Offset: 0x22070E0 VA: 0x220B0E0 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x220B0E8 Offset: 0x22070E8 VA: 0x220B0E8 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x220B0F0 Offset: 0x22070F0 VA: 0x220B0F0 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x220B0F8 Offset: 0x22070F8 VA: 0x220B0F8 Slot: 26
	public override bool get_IsPayHp() { }

	// RVA: 0x220B100 Offset: 0x2207100 VA: 0x220B100 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x220B354 Offset: 0x2207354 VA: 0x220B354 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x220B908 Offset: 0x2207908 VA: 0x220B908 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x220BA28 Offset: 0x2207A28 VA: 0x220BA28 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x220BC54 Offset: 0x2207C54 VA: 0x220BC54 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x220BECC Offset: 0x2207ECC VA: 0x220BECC
	public void .ctor() { }
}
