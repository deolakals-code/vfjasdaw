// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CronosDriveAction : PlayerAttackBase // TypeDefIndex: 2667
{
	// Fields
	private float skillRate; // 0x120
	private float fixAddDamage; // 0x124
	private readonly int damageCount; // 0x128
	private SkillCalcTemplate baseHitReaction; // 0x130

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

	// RVA: 0x2229978 Offset: 0x2225978 VA: 0x2229978 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2229980 Offset: 0x2225980 VA: 0x2229980 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2229988 Offset: 0x2225988 VA: 0x2229988 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2229990 Offset: 0x2225990 VA: 0x2229990 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2229998 Offset: 0x2225998 VA: 0x2229998 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22299A0 Offset: 0x22259A0 VA: 0x22299A0 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22299A8 Offset: 0x22259A8 VA: 0x22299A8 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22299B0 Offset: 0x22259B0 VA: 0x22299B0 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22299B8 Offset: 0x22259B8 VA: 0x22299B8 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2229C58 Offset: 0x2225C58 VA: 0x2229C58 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2229D20 Offset: 0x2225D20 VA: 0x2229D20 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2229DE8 Offset: 0x2225DE8 VA: 0x2229DE8 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x222A0B0 Offset: 0x22260B0 VA: 0x222A0B0
	public SkillCalcTemplate GetHitReaction() { }

	// RVA: 0x222A0B8 Offset: 0x22260B8 VA: 0x222A0B8
	public void .ctor() { }
}
