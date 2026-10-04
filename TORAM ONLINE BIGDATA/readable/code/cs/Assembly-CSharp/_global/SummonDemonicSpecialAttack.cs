// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SummonDemonicSpecialAttack : SummonDemonicSkillBase // TypeDefIndex: 3606
{
	// Fields
	private readonly SkillId[] invalidSkillBufIds; // 0x130
	private SkillAttackType attackType; // 0x138
	private int skillRate; // 0x13C
	private int constantDamage; // 0x140

	// Properties
	public override int ActionID { get; }
	public override SkillAttackType AttackType { get; }
	public override SkillAttackType ExpType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }

	// Methods

	// RVA: 0x23A936C Offset: 0x23A536C VA: 0x23A936C Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x23A9374 Offset: 0x23A5374 VA: 0x23A9374 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23A937C Offset: 0x23A537C VA: 0x23A937C Slot: 7
	public override SkillAttackType get_ExpType() { }

	// RVA: 0x23A9384 Offset: 0x23A5384 VA: 0x23A9384 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23A938C Offset: 0x23A538C VA: 0x23A938C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23A9394 Offset: 0x23A5394 VA: 0x23A9394 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23A939C Offset: 0x23A539C VA: 0x23A939C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23A93A4 Offset: 0x23A53A4 VA: 0x23A93A4 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23A93AC Offset: 0x23A53AC VA: 0x23A93AC Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23A93B4 Offset: 0x23A53B4 VA: 0x23A93B4 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23A9618 Offset: 0x23A5618 VA: 0x23A9618 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23A96A0 Offset: 0x23A56A0 VA: 0x23A96A0 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23A96A4 Offset: 0x23A56A4 VA: 0x23A96A4 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23A9904 Offset: 0x23A5904 VA: 0x23A9904 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x23AADC8 Offset: 0x23A6DC8 VA: 0x23AADC8 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23AAF3C Offset: 0x23A6F3C VA: 0x23AAF3C Slot: 86
	protected override int calcBaseDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction, SkillAttackType type, SkillEqLimitFlag eqLimit, bool isCritical) { }

	// RVA: 0x23AB2E4 Offset: 0x23A72E4 VA: 0x23AB2E4
	public void .ctor() { }
}
