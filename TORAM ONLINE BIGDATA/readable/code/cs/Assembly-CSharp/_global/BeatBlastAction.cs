// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BeatBlastAction : PlayerAttackBase // TypeDefIndex: 2819
{
	// Fields
	public const int TakeId = 202014000;
	private float skillRate; // 0x120
	private int constantDamage; // 0x124
	private int magicBreak; // 0x128
	private int attackCount; // 0x12C

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

	// RVA: 0x228B2F8 Offset: 0x22872F8 VA: 0x228B2F8 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x228B300 Offset: 0x2287300 VA: 0x228B300 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x228B308 Offset: 0x2287308 VA: 0x228B308 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x228B310 Offset: 0x2287310 VA: 0x228B310 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x228B318 Offset: 0x2287318 VA: 0x228B318 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x228B320 Offset: 0x2287320 VA: 0x228B320 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x228B328 Offset: 0x2287328 VA: 0x228B328 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x228B330 Offset: 0x2287330 VA: 0x228B330 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x228B338 Offset: 0x2287338 VA: 0x228B338 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x228B4E0 Offset: 0x22874E0 VA: 0x228B4E0 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x228B6A0 Offset: 0x22876A0 VA: 0x228B6A0 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x228B93C Offset: 0x228793C VA: 0x228B93C Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x228BA68 Offset: 0x2287A68 VA: 0x228BA68 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x228BC18 Offset: 0x2287C18 VA: 0x228BC18 Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x228BC8C Offset: 0x2287C8C VA: 0x228BC8C Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x228BEA0 Offset: 0x2287EA0 VA: 0x228BEA0 Slot: 86
	protected override int calcBaseDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction, SkillAttackType type, SkillEqLimitFlag eqLimit, bool isCritical) { }

	// RVA: 0x228C2A4 Offset: 0x22882A4 VA: 0x228C2A4 Slot: 63
	public override bool IsFailure(PlayerStatusBase status, out UI3DLabelManager.SkillMissType missType) { }

	// RVA: 0x228C314 Offset: 0x2288314 VA: 0x228C314 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x228C3D8 Offset: 0x22883D8 VA: 0x228C3D8
	public void .ctor() { }
}
