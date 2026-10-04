// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EnchantedSwordAction : PlayerAttackBase, IEnchantSkill // TypeDefIndex: 2757
{
	// Fields
	private float skillRate; // 0x120
	private int constantDamage; // 0x124
	private int critical; // 0x128
	private int magicResistBreaker; // 0x12C
	private int attackCount; // 0x130
	private bool conversion; // 0x134
	private bool enchantedBurstStack; // 0x135

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
	public override string LocalizeKey { get; }

	// Methods

	// RVA: 0x2259D6C Offset: 0x2255D6C VA: 0x2259D6C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2259D80 Offset: 0x2255D80 VA: 0x2259D80 Slot: 27
	public override SkillChargingType get_ChargingType() { }

	// RVA: 0x2259D88 Offset: 0x2255D88 VA: 0x2259D88 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2259D90 Offset: 0x2255D90 VA: 0x2259D90 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2259D98 Offset: 0x2255D98 VA: 0x2259D98 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2259DA0 Offset: 0x2255DA0 VA: 0x2259DA0 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2259DA8 Offset: 0x2255DA8 VA: 0x2259DA8 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2259DB0 Offset: 0x2255DB0 VA: 0x2259DB0 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2259DB8 Offset: 0x2255DB8 VA: 0x2259DB8 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2259DC0 Offset: 0x2255DC0 VA: 0x2259DC0 Slot: 91
	public bool get_IsEnchantStartMotion() { }

	// RVA: 0x2259DC8 Offset: 0x2255DC8 VA: 0x2259DC8 Slot: 92
	public bool get_IsEnchantMotion() { }

	// RVA: 0x2259DD0 Offset: 0x2255DD0 VA: 0x2259DD0 Slot: 93
	public bool get_IsStackChainCast() { }

	// RVA: 0x2259DD8 Offset: 0x2255DD8 VA: 0x2259DD8 Slot: 21
	public override string get_LocalizeKey() { }

	// RVA: 0x2259E50 Offset: 0x2255E50 VA: 0x2259E50 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2259FD0 Offset: 0x2255FD0 VA: 0x2259FD0 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x225A6A0 Offset: 0x22566A0 VA: 0x225A6A0 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x225A744 Offset: 0x2256744 VA: 0x225A744 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x225A75C Offset: 0x225675C VA: 0x225A75C Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x225AAAC Offset: 0x2256AAC VA: 0x225AAAC Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x225B0F4 Offset: 0x22570F4 VA: 0x225B0F4
	private void CalcDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction, int damageCount) { }

	// RVA: 0x225B4B0 Offset: 0x22574B0 VA: 0x225B4B0 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x225B6F8 Offset: 0x22576F8 VA: 0x225B6F8
	public static void ReceiveAttackResult(byte skillLocalId) { }

	// RVA: 0x225B820 Offset: 0x2257820 VA: 0x225B820
	private static bool CheckEnchantedBurst(PlayerStatusBase status) { }

	// RVA: 0x225A634 Offset: 0x2256634 VA: 0x225A634
	private static int CreateTakeId(ItemDBData.ItemType mainWeapon, bool isEnchantedBurstSword) { }

	// RVA: 0x225B89C Offset: 0x225789C VA: 0x225B89C Slot: 94
	public void EnchantStart(CharacterActionManagerBase actor) { }

	// RVA: 0x225B970 Offset: 0x2257970 VA: 0x225B970 Slot: 95
	public void EnchantEnd(CharacterActionManagerBase actor) { }

	// RVA: 0x225BA44 Offset: 0x2257A44 VA: 0x225BA44
	public void .ctor() { }
}
