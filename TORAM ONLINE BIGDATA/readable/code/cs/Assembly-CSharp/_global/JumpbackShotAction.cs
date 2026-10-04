// Assembly: Assembly-CSharp.dll
// Namespace: 
public class JumpbackShotAction : PlayerAttackBase // TypeDefIndex: 2994
{
	// Fields
	private float skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private float attackRange; // 0x128
	private float width; // 0x12C
	private MobActionManagerBase targetMob; // 0x130
	private bool autoEnd; // 0x138
	private Vector3 attackDir; // 0x13C

	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public override bool IsMove { get; }
	public override bool IsSkillStartTargetLook { get; }

	// Methods

	// RVA: 0x22F5AFC Offset: 0x22F1AFC VA: 0x22F5AFC Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22F5B04 Offset: 0x22F1B04 VA: 0x22F5B04 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22F5B0C Offset: 0x22F1B0C VA: 0x22F5B0C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22F5B14 Offset: 0x22F1B14 VA: 0x22F5B14 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22F5B1C Offset: 0x22F1B1C VA: 0x22F5B1C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22F5B24 Offset: 0x22F1B24 VA: 0x22F5B24 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22F5B2C Offset: 0x22F1B2C VA: 0x22F5B2C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22F5B34 Offset: 0x22F1B34 VA: 0x22F5B34 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22F5B3C Offset: 0x22F1B3C VA: 0x22F5B3C Slot: 28
	public override bool get_IsMove() { }

	// RVA: 0x22F5B44 Offset: 0x22F1B44 VA: 0x22F5B44 Slot: 32
	public override bool get_IsSkillStartTargetLook() { }

	// RVA: 0x22F5B4C Offset: 0x22F1B4C VA: 0x22F5B4C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22F5DA0 Offset: 0x22F1DA0 VA: 0x22F5DA0 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22F6684 Offset: 0x22F2684 VA: 0x22F6684 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22F67A4 Offset: 0x22F27A4 VA: 0x22F67A4 Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22F6B40 Offset: 0x22F2B40 VA: 0x22F6B40 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x22F6C28 Offset: 0x22F2C28 VA: 0x22F6C28 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22F6EC4 Offset: 0x22F2EC4 VA: 0x22F6EC4
	public static void ReceiveAttackResult(MobResponseData responseData) { }

	// RVA: 0x22F72A0 Offset: 0x22F32A0 VA: 0x22F72A0
	public static void ReceiveAttackResult(MobaMobResponseData responseData) { }

	// RVA: 0x22F6424 Offset: 0x22F2424 VA: 0x22F6424
	private bool CheckForwardInput(GameObject actor, GameObject target) { }

	// RVA: 0x22F7558 Offset: 0x22F3558 VA: 0x22F7558
	public void .ctor() { }
}
