// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EtherFlareAction : PlayerAttackBase, IEnchantSkill, IAbnormalStateSkill // TypeDefIndex: 2758
{
	// Fields
	private float skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private int percent; // 0x128
	private bool isGemCartBuf; // 0x12C
	private bool conversion; // 0x12D

	// Properties
	public override SkillAttackType AttackType { get; }
	public override SkillChargingType ChargingType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }
	public bool IsEnchantStartMotion { get; }
	public bool IsEnchantMotion { get; }
	public bool IsStackChainCast { get; }

	// Methods

	// RVA: 0x225BA54 Offset: 0x2257A54 VA: 0x225BA54 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x225BA68 Offset: 0x2257A68 VA: 0x225BA68 Slot: 27
	public override SkillChargingType get_ChargingType() { }

	// RVA: 0x225BA70 Offset: 0x2257A70 VA: 0x225BA70 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x225BA78 Offset: 0x2257A78 VA: 0x225BA78 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x225BA80 Offset: 0x2257A80 VA: 0x225BA80 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x225BA88 Offset: 0x2257A88 VA: 0x225BA88 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x225BA90 Offset: 0x2257A90 VA: 0x225BA90 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x225BA98 Offset: 0x2257A98 VA: 0x225BA98 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x225BAA0 Offset: 0x2257AA0 VA: 0x225BAA0 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x225BAA8 Offset: 0x2257AA8 VA: 0x225BAA8 Slot: 91
	public bool get_IsEnchantStartMotion() { }

	// RVA: 0x225BAB0 Offset: 0x2257AB0 VA: 0x225BAB0 Slot: 92
	public bool get_IsEnchantMotion() { }

	// RVA: 0x225BAB8 Offset: 0x2257AB8 VA: 0x225BAB8 Slot: 93
	public bool get_IsStackChainCast() { }

	// RVA: 0x225BAC0 Offset: 0x2257AC0 VA: 0x225BAC0 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x225BCD8 Offset: 0x2257CD8 VA: 0x225BCD8 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x225BDFC Offset: 0x2257DFC VA: 0x225BDFC Slot: 89
	public override void CheckAbnormalSubEffect(AbnormalType abnormalType, GameObject actor) { }

	// RVA: 0x225BF8C Offset: 0x2257F8C VA: 0x225BF8C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x225C0BC Offset: 0x22580BC VA: 0x225C0BC Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x225C5D8 Offset: 0x22585D8 VA: 0x225C5D8 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x225C63C Offset: 0x225863C VA: 0x225C63C Slot: 94
	public void EnchantStart(CharacterActionManagerBase actor) { }

	// RVA: 0x225C710 Offset: 0x2258710 VA: 0x225C710 Slot: 95
	public void EnchantEnd(CharacterActionManagerBase actor) { }

	// RVA: 0x225C7E4 Offset: 0x22587E4 VA: 0x225C7E4
	public void .ctor() { }
}
