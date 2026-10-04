// Assembly: Assembly-CSharp.dll
// Namespace: 
public class JudgmentOfTheDarkGodAction : PlayerAttackBase // TypeDefIndex: 2933
{
	// Fields
	private float skillRate; // 0x120
	private float attackRange; // 0x124
	private Dictionary<int, Transform> targetDamageDataList; // 0x128

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }

	// Methods

	// RVA: 0x22D8194 Offset: 0x22D4194 VA: 0x22D8194 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22D819C Offset: 0x22D419C VA: 0x22D819C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22D81A4 Offset: 0x22D41A4 VA: 0x22D81A4 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22D81AC Offset: 0x22D41AC VA: 0x22D81AC Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22D81B4 Offset: 0x22D41B4 VA: 0x22D81B4 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22D81BC Offset: 0x22D41BC VA: 0x22D81BC Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22D81C4 Offset: 0x22D41C4 VA: 0x22D81C4 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22D81CC Offset: 0x22D41CC VA: 0x22D81CC Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22D81D4 Offset: 0x22D41D4 VA: 0x22D81D4 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22D83FC Offset: 0x22D43FC VA: 0x22D83FC Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22D8584 Offset: 0x22D4584 VA: 0x22D8584 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x22D8684 Offset: 0x22D4684 VA: 0x22D8684 Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x22D87E8 Offset: 0x22D47E8 VA: 0x22D87E8 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22D8C30 Offset: 0x22D4C30 VA: 0x22D8C30
	public void .ctor() { }
}
