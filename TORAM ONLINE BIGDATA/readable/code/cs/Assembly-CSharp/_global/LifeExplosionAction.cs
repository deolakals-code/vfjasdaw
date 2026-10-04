// Assembly: Assembly-CSharp.dll
// Namespace: 
public class LifeExplosionAction : PlayerAttackBase // TypeDefIndex: 3037
{
	// Fields
	private int skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private int hpHeal; // 0x128
	private int chargeVal; // 0x12C

	// Properties
	public override int ActionID { get; }
	public override SkillAttackType AttackType { get; }
	public override bool IsSupport { get; }
	public override SkillTreeType TreeType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public override bool NoCost { get; }
	public override bool IsMoveAssistContinue { get; }
	public override bool IsNoMotionTake { get; }
	public override bool IsHideAttackApplied { get; }
	protected override bool IsRangeEquipBonus { get; }
	protected override bool IsRangeSkillBonus { get; }
	protected override bool CheckBlank { get; }

	// Methods

	// RVA: 0x230EE38 Offset: 0x230AE38 VA: 0x230EE38 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x230EE40 Offset: 0x230AE40 VA: 0x230EE40 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x230EE48 Offset: 0x230AE48 VA: 0x230EE48 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x230EE50 Offset: 0x230AE50 VA: 0x230EE50 Slot: 69
	public override SkillTreeType get_TreeType() { }

	// RVA: 0x230EE58 Offset: 0x230AE58 VA: 0x230EE58 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x230EE60 Offset: 0x230AE60 VA: 0x230EE60 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x230EE68 Offset: 0x230AE68 VA: 0x230EE68 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x230EE70 Offset: 0x230AE70 VA: 0x230EE70 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x230EE78 Offset: 0x230AE78 VA: 0x230EE78 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x230EE80 Offset: 0x230AE80 VA: 0x230EE80 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x230EE88 Offset: 0x230AE88 VA: 0x230EE88 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x230EE90 Offset: 0x230AE90 VA: 0x230EE90 Slot: 67
	public override bool get_NoCost() { }

	// RVA: 0x230EE98 Offset: 0x230AE98 VA: 0x230EE98 Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x230EEA0 Offset: 0x230AEA0 VA: 0x230EEA0 Slot: 31
	public override bool get_IsNoMotionTake() { }

	// RVA: 0x230EEA8 Offset: 0x230AEA8 VA: 0x230EEA8 Slot: 70
	public override bool get_IsHideAttackApplied() { }

	// RVA: 0x230EEB0 Offset: 0x230AEB0 VA: 0x230EEB0 Slot: 71
	protected override bool get_IsRangeEquipBonus() { }

	// RVA: 0x230EEB8 Offset: 0x230AEB8 VA: 0x230EEB8 Slot: 72
	protected override bool get_IsRangeSkillBonus() { }

	// RVA: 0x230EEC0 Offset: 0x230AEC0 VA: 0x230EEC0 Slot: 73
	protected override bool get_CheckBlank() { }

	// RVA: 0x230EEC8 Offset: 0x230AEC8 VA: 0x230EEC8 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x230EF60 Offset: 0x230AF60 VA: 0x230EF60
	public void SetEnhanceLevel(int charge) { }

	// RVA: 0x230EF6C Offset: 0x230AF6C VA: 0x230EF6C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x230EFF4 Offset: 0x230AFF4 VA: 0x230EFF4 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x230F418 Offset: 0x230B418 VA: 0x230F418 Slot: 86
	protected override int calcBaseDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction, SkillAttackType type, SkillEqLimitFlag eqLimit, bool isCritical) { }

	// RVA: 0x230F698 Offset: 0x230B698 VA: 0x230F698
	public void .ctor() { }
}
