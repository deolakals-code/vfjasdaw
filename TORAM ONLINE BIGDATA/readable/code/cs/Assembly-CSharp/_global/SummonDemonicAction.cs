// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SummonDemonicAction : PlayerAttackBase, IEnchantSkill // TypeDefIndex: 3757
{
	// Fields
	private int mp; // 0x120

	// Properties
	public override bool IsSupport { get; }
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override bool IsOverMp { get; }
	public override int BaseMp { get; }
	public override SkillChargingType ChargingType { get; }
	public bool IsEnchantStartMotion { get; }
	public bool IsEnchantMotion { get; }
	public bool IsStackChainCast { get; }

	// Methods

	// RVA: 0x23DEF64 Offset: 0x23DAF64 VA: 0x23DEF64 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23DEF6C Offset: 0x23DAF6C VA: 0x23DEF6C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23DEF74 Offset: 0x23DAF74 VA: 0x23DEF74 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23DEF7C Offset: 0x23DAF7C VA: 0x23DEF7C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23DEF84 Offset: 0x23DAF84 VA: 0x23DEF84 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23DEF8C Offset: 0x23DAF8C VA: 0x23DEF8C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23DEF94 Offset: 0x23DAF94 VA: 0x23DEF94 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23DEF9C Offset: 0x23DAF9C VA: 0x23DEF9C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23DEFA4 Offset: 0x23DAFA4 VA: 0x23DEFA4 Slot: 24
	public override bool get_IsOverMp() { }

	// RVA: 0x23DEFB4 Offset: 0x23DAFB4 VA: 0x23DEFB4 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23DEFBC Offset: 0x23DAFBC VA: 0x23DEFBC Slot: 27
	public override SkillChargingType get_ChargingType() { }

	// RVA: 0x23DEFC4 Offset: 0x23DAFC4 VA: 0x23DEFC4 Slot: 91
	public bool get_IsEnchantStartMotion() { }

	// RVA: 0x23DEFCC Offset: 0x23DAFCC VA: 0x23DEFCC Slot: 92
	public bool get_IsEnchantMotion() { }

	// RVA: 0x23DEFD4 Offset: 0x23DAFD4 VA: 0x23DEFD4 Slot: 93
	public bool get_IsStackChainCast() { }

	// RVA: 0x23DEFDC Offset: 0x23DAFDC VA: 0x23DEFDC Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23DF21C Offset: 0x23DB21C VA: 0x23DF21C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23DF2AC Offset: 0x23DB2AC VA: 0x23DF2AC Slot: 63
	public override bool IsFailure(PlayerStatusBase status, out UI3DLabelManager.SkillMissType missType) { }

	// RVA: 0x23DF694 Offset: 0x23DB694 VA: 0x23DF694
	public static Vector3 CenterShiftPos(Transform transform) { }

	// RVA: 0x23DF0F8 Offset: 0x23DB0F8 VA: 0x23DF0F8
	private void calcCostMp(PlayerActionManagerBase playerAction) { }

	// RVA: 0x23DF9DC Offset: 0x23DB9DC VA: 0x23DF9DC Slot: 94
	public void EnchantStart(CharacterActionManagerBase actor) { }

	// RVA: 0x23DFAB0 Offset: 0x23DBAB0 VA: 0x23DFAB0 Slot: 95
	public void EnchantEnd(CharacterActionManagerBase actor) { }

	// RVA: 0x23DFB84 Offset: 0x23DBB84 VA: 0x23DFB84
	public static int GetDamageResistRate(MobAttackBase mobAttack, PlayerStatusBase playerStatus) { }

	// RVA: 0x23DFE20 Offset: 0x23DBE20 VA: 0x23DFE20
	public static void AddAbnormal(MobActionManagerBase mobAction, AbnormalType abnormalType) { }

	// RVA: 0x23DFF58 Offset: 0x23DBF58 VA: 0x23DFF58
	public static void ChangeHateManaged(PlayerActionManagerBase playerAction) { }

	// RVA: 0x23E020C Offset: 0x23DC20C VA: 0x23E020C
	public static void PartyAcceptance() { }

	// RVA: 0x23E02C0 Offset: 0x23DC2C0 VA: 0x23E02C0
	public void .ctor() { }
}
