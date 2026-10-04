// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HolyLightActin : PlayerAttackBase, IEnchantSkill, IEnchantedSpellInvokeSkill // TypeDefIndex: 2956
{
	// Fields
	private float skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private int hpRecovery; // 0x128
	private int maxHpRecovery; // 0x12C

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public bool IsEnchantStartMotion { get; }
	public bool IsEnchantMotion { get; }
	public bool IsStackChainCast { get; }
	public override bool IsNoMotionTake { get; }
	private bool IsEnchantedSpell { get; }

	// Methods

	// RVA: 0x22E42C8 Offset: 0x22E02C8 VA: 0x22E42C8 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22E42D0 Offset: 0x22E02D0 VA: 0x22E42D0 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22E42D8 Offset: 0x22E02D8 VA: 0x22E42D8 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22E4340 Offset: 0x22E0340 VA: 0x22E4340 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22E4348 Offset: 0x22E0348 VA: 0x22E4348 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22E4350 Offset: 0x22E0350 VA: 0x22E4350 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22E4358 Offset: 0x22E0358 VA: 0x22E4358 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22E4360 Offset: 0x22E0360 VA: 0x22E4360 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22E4368 Offset: 0x22E0368 VA: 0x22E4368 Slot: 91
	public bool get_IsEnchantStartMotion() { }

	// RVA: 0x22E4370 Offset: 0x22E0370 VA: 0x22E4370 Slot: 92
	public bool get_IsEnchantMotion() { }

	// RVA: 0x22E4378 Offset: 0x22E0378 VA: 0x22E4378 Slot: 93
	public bool get_IsStackChainCast() { }

	// RVA: 0x22E4380 Offset: 0x22E0380 VA: 0x22E4380 Slot: 31
	public override bool get_IsNoMotionTake() { }

	// RVA: 0x22E430C Offset: 0x22E030C VA: 0x22E430C
	private bool get_IsEnchantedSpell() { }

	// RVA: 0x22E43B4 Offset: 0x22E03B4 VA: 0x22E43B4 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22E4644 Offset: 0x22E0644 VA: 0x22E4644 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22E49C0 Offset: 0x22E09C0 VA: 0x22E49C0 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22E4C3C Offset: 0x22E0C3C VA: 0x22E4C3C Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x22E4DF4 Offset: 0x22E0DF4 VA: 0x22E4DF4 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22E4FF8 Offset: 0x22E0FF8 VA: 0x22E4FF8 Slot: 94
	public void EnchantStart(CharacterActionManagerBase actor) { }

	// RVA: 0x22E50CC Offset: 0x22E10CC VA: 0x22E50CC Slot: 95
	public void EnchantEnd(CharacterActionManagerBase actor) { }

	// RVA: 0x22E4804 Offset: 0x22E0804 VA: 0x22E4804 Slot: 96
	public void InitializeEnchantedSpell(CharacterActionManagerBase actarAction, bool isPlayer) { }

	// RVA: 0x22E51A0 Offset: 0x22E11A0 VA: 0x22E51A0
	public void .ctor() { }
}
