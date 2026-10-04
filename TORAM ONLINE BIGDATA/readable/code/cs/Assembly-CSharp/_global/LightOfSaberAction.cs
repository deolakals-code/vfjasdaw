// Assembly: Assembly-CSharp.dll
// Namespace: 
public class LightOfSaberAction : PlayerAttackBase // TypeDefIndex: 2544
{
	// Fields
	private float skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private Vector3 attackPosition; // 0x128
	private Transform attackTransform; // 0x138
	private float capsuleLength; // 0x140
	private float capsuleWidth; // 0x144

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

	// RVA: 0x21EC49C Offset: 0x21E849C VA: 0x21EC49C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x21EC4A4 Offset: 0x21E84A4 VA: 0x21EC4A4 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x21EC4AC Offset: 0x21E84AC VA: 0x21EC4AC Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x21EC4B4 Offset: 0x21E84B4 VA: 0x21EC4B4 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x21EC4BC Offset: 0x21E84BC VA: 0x21EC4BC Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x21EC4C4 Offset: 0x21E84C4 VA: 0x21EC4C4 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x21EC4CC Offset: 0x21E84CC VA: 0x21EC4CC Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x21EC4D4 Offset: 0x21E84D4 VA: 0x21EC4D4 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x21EC4DC Offset: 0x21E84DC VA: 0x21EC4DC Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x21EC6B8 Offset: 0x21E86B8 VA: 0x21EC6B8 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x21EC78C Offset: 0x21E878C VA: 0x21EC78C Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x21EC880 Offset: 0x21E8880 VA: 0x21EC880 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x21ECA88 Offset: 0x21E8A88 VA: 0x21ECA88 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x21ECC84 Offset: 0x21E8C84 VA: 0x21ECC84
	public void .ctor() { }
}
