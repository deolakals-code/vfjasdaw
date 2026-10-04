// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MoonSlashPursuitAction : PlayerAttackBase // TypeDefIndex: 2565
{
	// Fields
	private float skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private int criticalPercent; // 0x128

	// Properties
	public override int ActionID { get; }
	public override SkillTreeType TreeType { get; }
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public override bool IsExpDefFluctuate { get; }
	public override bool NoCost { get; }
	public override bool IsSupport { get; }
	public override bool IsMoveAssistContinue { get; }

	// Methods

	// RVA: 0x21F73B0 Offset: 0x21F33B0 VA: 0x21F73B0 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x21F73B8 Offset: 0x21F33B8 VA: 0x21F73B8 Slot: 69
	public override SkillTreeType get_TreeType() { }

	// RVA: 0x21F73C0 Offset: 0x21F33C0 VA: 0x21F73C0 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x21F73C8 Offset: 0x21F33C8 VA: 0x21F73C8 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x21F73D0 Offset: 0x21F33D0 VA: 0x21F73D0 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x21F73D8 Offset: 0x21F33D8 VA: 0x21F73D8 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x21F73E0 Offset: 0x21F33E0 VA: 0x21F73E0 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x21F73E8 Offset: 0x21F33E8 VA: 0x21F73E8 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x21F73F0 Offset: 0x21F33F0 VA: 0x21F73F0 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x21F73F8 Offset: 0x21F33F8 VA: 0x21F73F8 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x21F7400 Offset: 0x21F3400 VA: 0x21F7400 Slot: 29
	public override bool get_IsExpDefFluctuate() { }

	// RVA: 0x21F7408 Offset: 0x21F3408 VA: 0x21F7408 Slot: 67
	public override bool get_NoCost() { }

	// RVA: 0x21F7410 Offset: 0x21F3410 VA: 0x21F7410 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x21F7418 Offset: 0x21F3418 VA: 0x21F7418 Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x21F7420 Offset: 0x21F3420 VA: 0x21F7420 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x21F75F8 Offset: 0x21F35F8 VA: 0x21F75F8 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x21F76C0 Offset: 0x21F36C0 VA: 0x21F76C0 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x21F76CC Offset: 0x21F36CC VA: 0x21F76CC Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x21F7CC8 Offset: 0x21F3CC8 VA: 0x21F7CC8
	public void .ctor() { }
}
