// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HammerDownAction : PlayerAttackBase // TypeDefIndex: 2560
{
	// Fields
	private SkillAttackType attackType; // 0x120
	private int baseMp; // 0x124
	private bool continuousUse; // 0x128
	private float skillRate; // 0x12C
	private int constantDamage; // 0x130
	private float attackRange; // 0x134
	private Vector3 attackPos; // 0x138

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

	// RVA: 0x21F3AF0 Offset: 0x21EFAF0 VA: 0x21F3AF0 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x21F3AF8 Offset: 0x21EFAF8 VA: 0x21F3AF8 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x21F3B00 Offset: 0x21EFB00 VA: 0x21F3B00 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x21F3B08 Offset: 0x21EFB08 VA: 0x21F3B08 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x21F3B10 Offset: 0x21EFB10 VA: 0x21F3B10 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x21F3B18 Offset: 0x21EFB18 VA: 0x21F3B18 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x21F3B20 Offset: 0x21EFB20 VA: 0x21F3B20 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x21F3B28 Offset: 0x21EFB28 VA: 0x21F3B28 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x21F3B30 Offset: 0x21EFB30 VA: 0x21F3B30 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x21F3E10 Offset: 0x21EFE10 VA: 0x21F3E10 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x21F3F6C Offset: 0x21EFF6C VA: 0x21F3F6C Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x21F40CC Offset: 0x21F00CC VA: 0x21F40CC Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x21F413C Offset: 0x21F013C VA: 0x21F413C Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x21F4450 Offset: 0x21F0450 VA: 0x21F4450
	public void ActionRangeHit(PlayerActionManagerBase playerAction) { }

	// RVA: 0x21F4588 Offset: 0x21F0588 VA: 0x21F4588 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x21F464C Offset: 0x21F064C VA: 0x21F464C
	public void .ctor() { }
}
