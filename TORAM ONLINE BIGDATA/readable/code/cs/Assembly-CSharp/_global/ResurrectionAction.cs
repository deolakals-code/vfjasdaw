// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ResurrectionAction : PlayerAttackBase, IEnchantSkill // TypeDefIndex: 3040
{
	// Fields
	public const int TARGET_MAX = 15;

	// Properties
	public override bool IsSupport { get; }
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsPlace { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsOverlay { get; }
	public override SkillChargingType ChargingType { get; }
	public bool IsEnchantStartMotion { get; }
	public bool IsEnchantMotion { get; }
	public bool IsStackChainCast { get; }

	// Methods

	// RVA: 0x2310E9C Offset: 0x230CE9C VA: 0x2310E9C Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x2310EA4 Offset: 0x230CEA4 VA: 0x2310EA4 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2310EAC Offset: 0x230CEAC VA: 0x2310EAC Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2310EB4 Offset: 0x230CEB4 VA: 0x2310EB4 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2310EBC Offset: 0x230CEBC VA: 0x2310EBC Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2310EC4 Offset: 0x230CEC4 VA: 0x2310EC4 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2310ECC Offset: 0x230CECC VA: 0x2310ECC Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2310ED4 Offset: 0x230CED4 VA: 0x2310ED4 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2310EDC Offset: 0x230CEDC VA: 0x2310EDC Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2310EE4 Offset: 0x230CEE4 VA: 0x2310EE4 Slot: 19
	public override bool get_IsOverlay() { }

	// RVA: 0x2310EEC Offset: 0x230CEEC VA: 0x2310EEC Slot: 27
	public override SkillChargingType get_ChargingType() { }

	// RVA: 0x2310EF4 Offset: 0x230CEF4 VA: 0x2310EF4 Slot: 91
	public bool get_IsEnchantStartMotion() { }

	// RVA: 0x2310EFC Offset: 0x230CEFC VA: 0x2310EFC Slot: 92
	public bool get_IsEnchantMotion() { }

	// RVA: 0x2310F04 Offset: 0x230CF04 VA: 0x2310F04 Slot: 93
	public bool get_IsStackChainCast() { }

	// RVA: 0x2310F0C Offset: 0x230CF0C VA: 0x2310F0C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2311150 Offset: 0x230D150 VA: 0x2311150 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2311280 Offset: 0x230D280 VA: 0x2311280 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x2311300 Offset: 0x230D300 VA: 0x2311300 Slot: 94
	public void EnchantStart(CharacterActionManagerBase actor) { }

	// RVA: 0x23113D4 Offset: 0x230D3D4 VA: 0x23113D4 Slot: 95
	public void EnchantEnd(CharacterActionManagerBase actor) { }

	// RVA: 0x23114A8 Offset: 0x230D4A8 VA: 0x23114A8
	public void .ctor() { }
}
