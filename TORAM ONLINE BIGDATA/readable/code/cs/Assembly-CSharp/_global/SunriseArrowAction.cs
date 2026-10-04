// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SunriseArrowAction : PlayerAttackBase // TypeDefIndex: 2715
{
	// Fields
	private float skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private float rad; // 0x128
	private Vector3 forward; // 0x12C
	private Vector3 attackPos; // 0x138

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

	// RVA: 0x2246F18 Offset: 0x2242F18 VA: 0x2246F18 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2246F20 Offset: 0x2242F20 VA: 0x2246F20 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2246F28 Offset: 0x2242F28 VA: 0x2246F28 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2246F30 Offset: 0x2242F30 VA: 0x2246F30 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2246F38 Offset: 0x2242F38 VA: 0x2246F38 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2246F40 Offset: 0x2242F40 VA: 0x2246F40 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2246F48 Offset: 0x2242F48 VA: 0x2246F48 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2246F50 Offset: 0x2242F50 VA: 0x2246F50 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2246F58 Offset: 0x2242F58 VA: 0x2246F58 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22472E4 Offset: 0x22432E4 VA: 0x22472E4 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2247480 Offset: 0x2243480 VA: 0x2247480 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2247604 Offset: 0x2243604 VA: 0x2247604 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22478FC Offset: 0x22438FC VA: 0x22478FC Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x2247990 Offset: 0x2243990 VA: 0x2247990
	public void .ctor() { }
}
