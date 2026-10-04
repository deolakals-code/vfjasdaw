// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HayateAction : PlayerAttackBase // TypeDefIndex: 2835
{
	// Fields
	public const int TakeId = 201233000;
	private float skillRate; // 0x120
	private int constantDamage; // 0x124
	private GameObject mainTarget; // 0x128
	private SkillActionBase.DamageData calcDamageData; // 0x130
	private float jumpStartTime; // 0x138
	private float jumpElapsedTime; // 0x13C
	private byte invincibilityId; // 0x140
	private bool otherNextAnimation; // 0x141

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

	// RVA: 0x2290FEC Offset: 0x228CFEC VA: 0x2290FEC Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2290FF4 Offset: 0x228CFF4 VA: 0x2290FF4 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2290FFC Offset: 0x228CFFC VA: 0x2290FFC Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2291004 Offset: 0x228D004 VA: 0x2291004 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x229100C Offset: 0x228D00C VA: 0x229100C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2291014 Offset: 0x228D014 VA: 0x2291014 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x229101C Offset: 0x228D01C VA: 0x229101C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2291024 Offset: 0x228D024 VA: 0x2291024 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x229102C Offset: 0x228D02C VA: 0x229102C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22911A8 Offset: 0x228D1A8 VA: 0x22911A8 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22912C8 Offset: 0x228D2C8 VA: 0x22912C8 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x2291388 Offset: 0x228D388 VA: 0x2291388 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x22915D0 Offset: 0x228D5D0 VA: 0x22915D0 Slot: 49
	public override bool ActionSkillEventIfMoveIndex(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22919A8 Offset: 0x228D9A8 VA: 0x22919A8 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2291E84 Offset: 0x228DE84 VA: 0x2291E84 Slot: 63
	public override bool IsFailure(PlayerStatusBase status, out UI3DLabelManager.SkillMissType missType) { }

	// RVA: 0x2291EF8 Offset: 0x228DEF8 VA: 0x2291EF8 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2291FBC Offset: 0x228DFBC VA: 0x2291FBC Slot: 83
	public override void OtherPlayerSkillEventReceive(CharacterActionManagerBase actorAction, short skillEventId, Dictionary<int, int> values) { }

	// RVA: 0x2292010 Offset: 0x228E010 VA: 0x2292010 Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2292120 Offset: 0x228E120 VA: 0x2292120
	public void .ctor() { }
}
