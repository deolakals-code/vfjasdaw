// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FamiliaManaCrystalAction : FamiliaSkillBase, IEnchantSkill // TypeDefIndex: 3357
{
	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsSupport { get; }
	public override SkillChargingType ChargingType { get; }
	public bool IsEnchantStartMotion { get; }
	public bool IsEnchantMotion { get; }
	public bool IsStackChainCast { get; }

	// Methods

	// RVA: 0x234B484 Offset: 0x2347484 VA: 0x234B484 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x234B48C Offset: 0x234748C VA: 0x234B48C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x234B494 Offset: 0x2347494 VA: 0x234B494 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x234B49C Offset: 0x234749C VA: 0x234B49C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x234B4A4 Offset: 0x23474A4 VA: 0x234B4A4 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x234B4AC Offset: 0x23474AC VA: 0x234B4AC Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x234B4B4 Offset: 0x23474B4 VA: 0x234B4B4 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x234B4BC Offset: 0x23474BC VA: 0x234B4BC Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x234B4C4 Offset: 0x23474C4 VA: 0x234B4C4 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x234B4CC Offset: 0x23474CC VA: 0x234B4CC Slot: 27
	public override SkillChargingType get_ChargingType() { }

	// RVA: 0x234B4D4 Offset: 0x23474D4 VA: 0x234B4D4 Slot: 92
	public bool get_IsEnchantStartMotion() { }

	// RVA: 0x234B4DC Offset: 0x23474DC VA: 0x234B4DC Slot: 93
	public bool get_IsEnchantMotion() { }

	// RVA: 0x234B4E4 Offset: 0x23474E4 VA: 0x234B4E4 Slot: 94
	public bool get_IsStackChainCast() { }

	// RVA: 0x234B4EC Offset: 0x23474EC VA: 0x234B4EC Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x234B7AC Offset: 0x23477AC VA: 0x234B7AC Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x234B880 Offset: 0x2347880 VA: 0x234B880 Slot: 95
	public void EnchantStart(CharacterActionManagerBase actor) { }

	// RVA: 0x234B954 Offset: 0x2347954 VA: 0x234B954 Slot: 96
	public void EnchantEnd(CharacterActionManagerBase actor) { }

	// RVA: 0x234BA28 Offset: 0x2347A28 VA: 0x234BA28
	public void .ctor() { }
}
