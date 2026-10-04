// Assembly: Assembly-CSharp.dll
// Namespace: ExtensionMethod.ExSkillData
[Extension]
public static class SkillDataExtentionMethod // TypeDefIndex: 9079
{
	// Methods

	[Extension]
	// RVA: 0x1EA9270 Offset: 0x1EA5270 VA: 0x1EA9270
	public static BonusType GetSkillBonusType(SkillAttackType attackType, int actionID) { }

	[Extension]
	// RVA: 0x1EA9294 Offset: 0x1EA5294 VA: 0x1EA9294
	public static float GetTargetExpRate(SkillAttackType attackType, int actionID, IMobStatusCalculator mob) { }

	[Extension]
	// RVA: 0x1EA9480 Offset: 0x1EA5480 VA: 0x1EA9480
	public static int GetActorAtk(SkillAttackType attackType, IPlayerStatusCalculator status) { }

	[Extension]
	// RVA: 0x1EA9594 Offset: 0x1EA5594 VA: 0x1EA9594
	public static int GetTargetCutAtk(SkillAttackType attackType, IMobStatusCalculator mob) { }

	[Extension]
	// RVA: 0x1EA96A8 Offset: 0x1EA56A8 VA: 0x1EA96A8
	public static BonusType GetSkillTreeBonus(SkillTreeType treeType, int actionID) { }
}
