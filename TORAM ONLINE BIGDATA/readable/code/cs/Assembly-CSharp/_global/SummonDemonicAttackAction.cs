// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SummonDemonicAttackAction : SummonDemonicSkillBase // TypeDefIndex: 3604
{
	// Fields
	private readonly SkillId[] invalidSkillBufIds; // 0x130
	private int skillRate; // 0x138
	private int constantDamage; // 0x13C
	private SkillAttackType attackType; // 0x140

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

	// RVA: 0x23A7228 Offset: 0x23A3228 VA: 0x23A7228 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x23A7230 Offset: 0x23A3230 VA: 0x23A7230 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23A7238 Offset: 0x23A3238 VA: 0x23A7238 Slot: 7
	public override SkillAttackType get_ExpType() { }

	// RVA: 0x23A7240 Offset: 0x23A3240 VA: 0x23A7240 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23A7248 Offset: 0x23A3248 VA: 0x23A7248 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23A7250 Offset: 0x23A3250 VA: 0x23A7250 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23A7258 Offset: 0x23A3258 VA: 0x23A7258 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23A7260 Offset: 0x23A3260 VA: 0x23A7260 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23A7268 Offset: 0x23A3268 VA: 0x23A7268 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23A7270 Offset: 0x23A3270 VA: 0x23A7270 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23A74CC Offset: 0x23A34CC VA: 0x23A74CC Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23A7554 Offset: 0x23A3554 VA: 0x23A7554 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23A7558 Offset: 0x23A3558 VA: 0x23A7558 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23A77B8 Offset: 0x23A37B8 VA: 0x23A77B8 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x23A8D68 Offset: 0x23A4D68 VA: 0x23A8D68 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23A8EDC Offset: 0x23A4EDC VA: 0x23A8EDC Slot: 86
	protected override int calcBaseDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction, SkillAttackType type, SkillEqLimitFlag eqLimit, bool isCritical) { }

	// RVA: 0x23A9284 Offset: 0x23A5284 VA: 0x23A9284
	public void .ctor() { }
}
