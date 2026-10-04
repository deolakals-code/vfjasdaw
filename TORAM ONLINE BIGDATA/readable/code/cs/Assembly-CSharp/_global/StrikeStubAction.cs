// Assembly: Assembly-CSharp.dll
// Namespace: 
public class StrikeStubAction : PlayerAttackBase // TypeDefIndex: 2689
{
	// Fields
	private float skillRate; // 0x120
	private float bonusSkillRate; // 0x124
	private float fixAddDamage; // 0x128
	private readonly int damageCount; // 0x12C
	private float criticalPercent; // 0x130
	private float abnormalRate; // 0x134

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

	// RVA: 0x2235C68 Offset: 0x2231C68 VA: 0x2235C68 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2235C70 Offset: 0x2231C70 VA: 0x2235C70 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2235C78 Offset: 0x2231C78 VA: 0x2235C78 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2235C80 Offset: 0x2231C80 VA: 0x2235C80 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2235C88 Offset: 0x2231C88 VA: 0x2235C88 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2235C90 Offset: 0x2231C90 VA: 0x2235C90 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2235C98 Offset: 0x2231C98 VA: 0x2235C98 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2235CA0 Offset: 0x2231CA0 VA: 0x2235CA0 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2235CA8 Offset: 0x2231CA8 VA: 0x2235CA8 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2235F88 Offset: 0x2231F88 VA: 0x2235F88 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22360D8 Offset: 0x22320D8 VA: 0x22360D8 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2236644 Offset: 0x2232644 VA: 0x2236644
	public void .ctor() { }
}
