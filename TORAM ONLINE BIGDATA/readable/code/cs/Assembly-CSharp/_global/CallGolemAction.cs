// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CallGolemAction : PlayerAttackBase, IEnchantSkill // TypeDefIndex: 3625
{
	// Properties
	public override bool IsSupport { get; }
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public override SkillChargingType ChargingType { get; }
	public bool IsEnchantStartMotion { get; }
	public bool IsEnchantMotion { get; }
	public bool IsStackChainCast { get; }

	// Methods

	// RVA: 0x23B1CB8 Offset: 0x23ADCB8 VA: 0x23B1CB8 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23B1CC0 Offset: 0x23ADCC0 VA: 0x23B1CC0 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23B1CC8 Offset: 0x23ADCC8 VA: 0x23B1CC8 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23B1CD0 Offset: 0x23ADCD0 VA: 0x23B1CD0 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23B1CD8 Offset: 0x23ADCD8 VA: 0x23B1CD8 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23B1CE0 Offset: 0x23ADCE0 VA: 0x23B1CE0 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23B1CE8 Offset: 0x23ADCE8 VA: 0x23B1CE8 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23B1CF0 Offset: 0x23ADCF0 VA: 0x23B1CF0 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23B1CF8 Offset: 0x23ADCF8 VA: 0x23B1CF8 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23B1D00 Offset: 0x23ADD00 VA: 0x23B1D00 Slot: 27
	public override SkillChargingType get_ChargingType() { }

	// RVA: 0x23B1D08 Offset: 0x23ADD08 VA: 0x23B1D08 Slot: 91
	public bool get_IsEnchantStartMotion() { }

	// RVA: 0x23B1D10 Offset: 0x23ADD10 VA: 0x23B1D10 Slot: 92
	public bool get_IsEnchantMotion() { }

	// RVA: 0x23B1D18 Offset: 0x23ADD18 VA: 0x23B1D18 Slot: 93
	public bool get_IsStackChainCast() { }

	// RVA: 0x23B1D20 Offset: 0x23ADD20 VA: 0x23B1D20 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23B1E40 Offset: 0x23ADE40 VA: 0x23B1E40 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23B1ED0 Offset: 0x23ADED0 VA: 0x23B1ED0 Slot: 94
	public void EnchantStart(CharacterActionManagerBase actor) { }

	// RVA: 0x23B1FA4 Offset: 0x23ADFA4 VA: 0x23B1FA4 Slot: 95
	public void EnchantEnd(CharacterActionManagerBase actor) { }

	// RVA: 0x23B21FC Offset: 0x23AE1FC VA: 0x23B21FC
	public static Vector3 CenterShiftPos(Transform transform) { }

	// RVA: 0x23B2540 Offset: 0x23AE540 VA: 0x23B2540
	public void .ctor() { }
}
