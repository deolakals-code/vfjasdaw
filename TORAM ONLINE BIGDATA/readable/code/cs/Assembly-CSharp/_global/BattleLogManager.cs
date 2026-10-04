// Assembly: Assembly-CSharp.dll
// Namespace: 
public static class BattleLogManager // TypeDefIndex: 318
{
	// Fields
	[CompilerGenerated]
	private static SkillComboLogBase <Combo>k__BackingField; // 0x0
	private static BattleLogBase battle; // 0x8
	private static HealLogLocalize heal; // 0x10
	private static SkillTextManager skillTextManager; // 0x18
	private static bool useLocalize; // 0x20

	// Properties
	public static SkillComboLogBase Combo { get; set; }
	public static bool UseLocalize { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x238C570 Offset: 0x2388570 VA: 0x238C570
	private static void set_Combo(SkillComboLogBase value) { }

	[CompilerGenerated]
	// RVA: 0x238C5D8 Offset: 0x23885D8 VA: 0x238C5D8
	public static SkillComboLogBase get_Combo() { }

	// RVA: 0x238C630 Offset: 0x2388630 VA: 0x238C630
	public static bool get_UseLocalize() { }

	// RVA: 0x238C688 Offset: 0x2388688 VA: 0x238C688
	public static void set_UseLocalize(bool value) { }

	// RVA: 0x238C7F8 Offset: 0x23887F8 VA: 0x238C7F8
	private static void .cctor() { }

	// RVA: 0x238C9FC Offset: 0x23889FC VA: 0x238C9FC
	public static void BattleChatLog(SkillHitType hitType, bool player, int param, int nowHp, SkillActionBase action) { }

	// RVA: 0x238D320 Offset: 0x2389320 VA: 0x238D320
	public static void PlayerBattleChatLog(SkillHitType hitType, int damage, SkillId skillId, string localizeKey) { }

	// RVA: 0x238D948 Offset: 0x2389948 VA: 0x238D948
	public static void AddSupportBufLog(string name, int skillId) { }

	// RVA: 0x238DAD4 Offset: 0x2389AD4 VA: 0x238DAD4
	public static void RemoveSupportBufLog(string name, int skillId) { }

	// RVA: 0x238DC60 Offset: 0x2389C60 VA: 0x238DC60
	public static void AvoidChatLog(bool player, SkillActionBase action) { }

	// RVA: 0x238DCE8 Offset: 0x2389CE8 VA: 0x238DCE8
	public static void MobAvoidChatLog(SkillId skillId) { }

	// RVA: 0x238DDFC Offset: 0x2389DFC VA: 0x238DDFC
	public static void MercenaryAndPartnerBattleChatLog(SkillHitType hitType, int param, int nowHp, SkillActionBase action, string append) { }

	// RVA: 0x238DE70 Offset: 0x2389E70 VA: 0x238DE70
	public static void PetBattleChatLog(SkillHitType hitType, int param, int nowHp, SkillActionBase action, string append) { }

	// RVA: 0x238DEE4 Offset: 0x2389EE4 VA: 0x238DEE4
	public static void AttackPursuitLog(int damage, SkillActionBase action) { }

	// RVA: 0x238CD38 Offset: 0x2388D38 VA: 0x238CD38
	private static void AttackLog(int damage, SkillActionBase action, ElementType elementType, string append) { }

	// RVA: 0x238D5D4 Offset: 0x23895D4 VA: 0x238D5D4
	private static void AttackLog(int damage, SkillId skillId, string localizeKey, string append) { }

	// RVA: 0x238E084 Offset: 0x238A084 VA: 0x238E084
	public static void DeadlyPoisonAttackLog(int damage) { }

	// RVA: 0x238E184 Offset: 0x238A184 VA: 0x238E184
	public static void CatarabomosAttackLog(int damage) { }

	// RVA: 0x238E1F8 Offset: 0x238A1F8 VA: 0x238E1F8
	public static void BarrierLog(int reduce) { }

	// RVA: 0x238E2F8 Offset: 0x238A2F8 VA: 0x238E2F8
	public static void DamageReflectionLog(bool isPlayer, int damage) { }

	// RVA: 0x238E400 Offset: 0x238A400 VA: 0x238E400
	public static void DamageMagicalExplosionLog(int damage) { }

	// RVA: 0x238E500 Offset: 0x238A500 VA: 0x238E500
	public static void DamageChronosShiftLog(int damage) { }

	// RVA: 0x238E600 Offset: 0x238A600 VA: 0x238E600
	public static void DamageFamiliaEscape() { }

	// RVA: 0x238E6E4 Offset: 0x238A6E4 VA: 0x238E6E4
	public static void SummonDemonicKillPlayer() { }

	// RVA: 0x238D144 Offset: 0x2389144 VA: 0x238D144
	private static void DamageLog(int damage, SkillAttackType attackType, bool isRateAttack, bool isFatalDamage) { }

	// RVA: 0x238E7C8 Offset: 0x238A7C8 VA: 0x238E7C8
	public static void SkillDamageLog(int damage, int skillId, string localizeKey) { }

	// RVA: 0x238EB5C Offset: 0x238AB5C VA: 0x238EB5C
	public static void TokenManaCrystal(string userName) { }

	// RVA: 0x238EC44 Offset: 0x238AC44 VA: 0x238EC44
	public static void GetManaCrystal(int heal) { }
}
