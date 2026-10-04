// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FinishingTouchAction : PlayerAttackBase // TypeDefIndex: 2827
{
	// Fields
	private float skillRate; // 0x120
	private float fixAddDamage; // 0x124
	private int damageCount; // 0x128
	private int critical; // 0x12C
	private int resist; // 0x130

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

	// RVA: 0x228E43C Offset: 0x228A43C VA: 0x228E43C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x228E444 Offset: 0x228A444 VA: 0x228E444 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x228E44C Offset: 0x228A44C VA: 0x228E44C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x228E454 Offset: 0x228A454 VA: 0x228E454 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x228E45C Offset: 0x228A45C VA: 0x228E45C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x228E464 Offset: 0x228A464 VA: 0x228E464 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x228E46C Offset: 0x228A46C VA: 0x228E46C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x228E474 Offset: 0x228A474 VA: 0x228E474 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x228E47C Offset: 0x228A47C VA: 0x228E47C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x228E688 Offset: 0x228A688 VA: 0x228E688 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x228E74C Offset: 0x228A74C VA: 0x228E74C Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x228EA7C Offset: 0x228AA7C VA: 0x228EA7C Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x228EB00 Offset: 0x228AB00 VA: 0x228EB00 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x228EEAC Offset: 0x228AEAC VA: 0x228EEAC
	public static bool AddSwordSoul(PlayerActionManagerBase playerAction, int addCount = 1) { }

	// RVA: 0x228F010 Offset: 0x228B010 VA: 0x228F010
	public void .ctor() { }
}
