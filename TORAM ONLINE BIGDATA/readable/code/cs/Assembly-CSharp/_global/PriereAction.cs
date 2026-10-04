// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PriereAction : PlayerAttackBase, IEnchantSkill // TypeDefIndex: 3725
{
	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override bool IsSupport { get; }
	public override SkillChargingType ChargingType { get; }
	public bool IsEnchantStartMotion { get; }
	public bool IsEnchantMotion { get; }
	public bool IsStackChainCast { get; }

	// Methods

	// RVA: 0x23D4D94 Offset: 0x23D0D94 VA: 0x23D4D94 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23D4D9C Offset: 0x23D0D9C VA: 0x23D4D9C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23D4DA4 Offset: 0x23D0DA4 VA: 0x23D4DA4 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23D4DAC Offset: 0x23D0DAC VA: 0x23D4DAC Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23D4DB4 Offset: 0x23D0DB4 VA: 0x23D4DB4 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23D4DBC Offset: 0x23D0DBC VA: 0x23D4DBC Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23D4DC4 Offset: 0x23D0DC4 VA: 0x23D4DC4 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23D4DCC Offset: 0x23D0DCC VA: 0x23D4DCC Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23D4DD4 Offset: 0x23D0DD4 VA: 0x23D4DD4 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23D4DDC Offset: 0x23D0DDC VA: 0x23D4DDC Slot: 27
	public override SkillChargingType get_ChargingType() { }

	// RVA: 0x23D4DE4 Offset: 0x23D0DE4 VA: 0x23D4DE4 Slot: 91
	public bool get_IsEnchantStartMotion() { }

	// RVA: 0x23D4DEC Offset: 0x23D0DEC VA: 0x23D4DEC Slot: 92
	public bool get_IsEnchantMotion() { }

	// RVA: 0x23D4DF4 Offset: 0x23D0DF4 VA: 0x23D4DF4 Slot: 93
	public bool get_IsStackChainCast() { }

	// RVA: 0x23D4DFC Offset: 0x23D0DFC VA: 0x23D4DFC Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23D4F94 Offset: 0x23D0F94 VA: 0x23D4F94 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23D5064 Offset: 0x23D1064 VA: 0x23D5064 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23D5170 Offset: 0x23D1170 VA: 0x23D5170 Slot: 94
	public void EnchantStart(CharacterActionManagerBase actor) { }

	// RVA: 0x23D5244 Offset: 0x23D1244 VA: 0x23D5244 Slot: 95
	public void EnchantEnd(CharacterActionManagerBase actor) { }

	// RVA: 0x23D5318 Offset: 0x23D1318 VA: 0x23D5318
	public void .ctor() { }
}
