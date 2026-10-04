// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BlessAction : PlayerAttackBase, IEnchantSkill // TypeDefIndex: 3622
{
	// Fields
	private int count; // 0x120

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

	// RVA: 0x23B0BF4 Offset: 0x23ACBF4 VA: 0x23B0BF4 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23B0BFC Offset: 0x23ACBFC VA: 0x23B0BFC Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23B0C04 Offset: 0x23ACC04 VA: 0x23B0C04 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23B0C0C Offset: 0x23ACC0C VA: 0x23B0C0C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23B0C14 Offset: 0x23ACC14 VA: 0x23B0C14 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23B0C1C Offset: 0x23ACC1C VA: 0x23B0C1C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23B0C24 Offset: 0x23ACC24 VA: 0x23B0C24 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23B0C2C Offset: 0x23ACC2C VA: 0x23B0C2C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23B0C34 Offset: 0x23ACC34 VA: 0x23B0C34 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23B0C3C Offset: 0x23ACC3C VA: 0x23B0C3C Slot: 27
	public override SkillChargingType get_ChargingType() { }

	// RVA: 0x23B0C44 Offset: 0x23ACC44 VA: 0x23B0C44 Slot: 91
	public bool get_IsEnchantStartMotion() { }

	// RVA: 0x23B0C4C Offset: 0x23ACC4C VA: 0x23B0C4C Slot: 92
	public bool get_IsEnchantMotion() { }

	// RVA: 0x23B0C54 Offset: 0x23ACC54 VA: 0x23B0C54 Slot: 93
	public bool get_IsStackChainCast() { }

	// RVA: 0x23B0C5C Offset: 0x23ACC5C VA: 0x23B0C5C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23B10F4 Offset: 0x23AD0F4 VA: 0x23B10F4 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23B11C4 Offset: 0x23AD1C4 VA: 0x23B11C4 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23B12CC Offset: 0x23AD2CC VA: 0x23B12CC Slot: 94
	public void EnchantStart(CharacterActionManagerBase actor) { }

	// RVA: 0x23B13A0 Offset: 0x23AD3A0 VA: 0x23B13A0 Slot: 95
	public void EnchantEnd(CharacterActionManagerBase actor) { }

	// RVA: 0x23B1474 Offset: 0x23AD474 VA: 0x23B1474
	public void .ctor() { }
}
