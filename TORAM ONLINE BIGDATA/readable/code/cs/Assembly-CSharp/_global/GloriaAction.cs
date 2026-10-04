// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GloriaAction : PlayerAttackBase, IEnchantSkill // TypeDefIndex: 3662
{
	// Fields
	private int guard; // 0x120

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

	// RVA: 0x23BD0EC Offset: 0x23B90EC VA: 0x23BD0EC Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23BD0F4 Offset: 0x23B90F4 VA: 0x23BD0F4 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23BD0FC Offset: 0x23B90FC VA: 0x23BD0FC Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23BD104 Offset: 0x23B9104 VA: 0x23BD104 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23BD10C Offset: 0x23B910C VA: 0x23BD10C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23BD114 Offset: 0x23B9114 VA: 0x23BD114 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23BD11C Offset: 0x23B911C VA: 0x23BD11C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23BD124 Offset: 0x23B9124 VA: 0x23BD124 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23BD12C Offset: 0x23B912C VA: 0x23BD12C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23BD134 Offset: 0x23B9134 VA: 0x23BD134 Slot: 27
	public override SkillChargingType get_ChargingType() { }

	// RVA: 0x23BD13C Offset: 0x23B913C VA: 0x23BD13C Slot: 91
	public bool get_IsEnchantStartMotion() { }

	// RVA: 0x23BD144 Offset: 0x23B9144 VA: 0x23BD144 Slot: 92
	public bool get_IsEnchantMotion() { }

	// RVA: 0x23BD14C Offset: 0x23B914C VA: 0x23BD14C Slot: 93
	public bool get_IsStackChainCast() { }

	// RVA: 0x23BD154 Offset: 0x23B9154 VA: 0x23BD154 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23BD2EC Offset: 0x23B92EC VA: 0x23BD2EC Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23BD3BC Offset: 0x23B93BC VA: 0x23BD3BC Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23BD4B0 Offset: 0x23B94B0 VA: 0x23BD4B0 Slot: 94
	public void EnchantStart(CharacterActionManagerBase actor) { }

	// RVA: 0x23BD584 Offset: 0x23B9584 VA: 0x23BD584 Slot: 95
	public void EnchantEnd(CharacterActionManagerBase actor) { }

	// RVA: 0x23BD658 Offset: 0x23B9658 VA: 0x23BD658
	public void .ctor() { }
}
