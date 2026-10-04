// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HighnessHealAction : PlayerAttackBase, IEnchantSkill // TypeDefIndex: 3678
{
	// Fields
	private float healRange; // 0x120

	// Properties
	public override bool IsSupport { get; }
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override SkillChargingType ChargingType { get; }
	public bool IsEnchantStartMotion { get; }
	public bool IsEnchantMotion { get; }
	public bool IsStackChainCast { get; }

	// Methods

	// RVA: 0x23C2CD8 Offset: 0x23BECD8 VA: 0x23C2CD8 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23C2CE0 Offset: 0x23BECE0 VA: 0x23C2CE0 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23C2CE8 Offset: 0x23BECE8 VA: 0x23C2CE8 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23C2CF0 Offset: 0x23BECF0 VA: 0x23C2CF0 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23C2CF8 Offset: 0x23BECF8 VA: 0x23C2CF8 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23C2D00 Offset: 0x23BED00 VA: 0x23C2D00 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23C2D08 Offset: 0x23BED08 VA: 0x23C2D08 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23C2D10 Offset: 0x23BED10 VA: 0x23C2D10 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23C2D18 Offset: 0x23BED18 VA: 0x23C2D18 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23C2D20 Offset: 0x23BED20 VA: 0x23C2D20 Slot: 27
	public override SkillChargingType get_ChargingType() { }

	// RVA: 0x23C2D28 Offset: 0x23BED28 VA: 0x23C2D28 Slot: 91
	public bool get_IsEnchantStartMotion() { }

	// RVA: 0x23C2D30 Offset: 0x23BED30 VA: 0x23C2D30 Slot: 92
	public bool get_IsEnchantMotion() { }

	// RVA: 0x23C2D38 Offset: 0x23BED38 VA: 0x23C2D38 Slot: 93
	public bool get_IsStackChainCast() { }

	// RVA: 0x23C2D40 Offset: 0x23BED40 VA: 0x23C2D40 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23C3124 Offset: 0x23BF124 VA: 0x23C3124 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23C3278 Offset: 0x23BF278 VA: 0x23C3278 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23C33C0 Offset: 0x23BF3C0 VA: 0x23C33C0 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x23C344C Offset: 0x23BF44C VA: 0x23C344C Slot: 94
	public void EnchantStart(CharacterActionManagerBase actor) { }

	// RVA: 0x23C3520 Offset: 0x23BF520 VA: 0x23C3520 Slot: 95
	public void EnchantEnd(CharacterActionManagerBase actor) { }

	// RVA: 0x23C35F4 Offset: 0x23BF5F4 VA: 0x23C35F4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x23C35FC Offset: 0x23BF5FC VA: 0x23C35FC
	private void <ActionStart>b__29_0(bool cancel) { }

	[CompilerGenerated]
	// RVA: 0x23C3654 Offset: 0x23BF654 VA: 0x23C3654
	private void <ActionStart>b__29_1() { }
}
