// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CleaveAttackAction : PlayerAttackBase // TypeDefIndex: 2557
{
	// Fields
	private float skillRate; // 0x120
	private float bonusSkillRate; // 0x124
	private int constantDamage; // 0x128
	private Transform mainTarget; // 0x130
	private Vector3 attackPos; // 0x138
	private int targetNum; // 0x144

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

	// RVA: 0x21F2008 Offset: 0x21EE008 VA: 0x21F2008 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x21F2010 Offset: 0x21EE010 VA: 0x21F2010 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x21F2018 Offset: 0x21EE018 VA: 0x21F2018 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x21F2020 Offset: 0x21EE020 VA: 0x21F2020 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x21F2028 Offset: 0x21EE028 VA: 0x21F2028 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x21F2030 Offset: 0x21EE030 VA: 0x21F2030 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x21F2038 Offset: 0x21EE038 VA: 0x21F2038 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x21F2040 Offset: 0x21EE040 VA: 0x21F2040 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x21F2048 Offset: 0x21EE048 VA: 0x21F2048 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x21F234C Offset: 0x21EE34C VA: 0x21F234C Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x21F2550 Offset: 0x21EE550 VA: 0x21F2550 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x21F2650 Offset: 0x21EE650 VA: 0x21F2650 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x21F2D70 Offset: 0x21EED70 VA: 0x21F2D70 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x21F3008 Offset: 0x21EF008 VA: 0x21F3008 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x21F30CC Offset: 0x21EF0CC VA: 0x21F30CC
	public void .ctor() { }
}
