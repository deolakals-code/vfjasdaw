// Assembly: Assembly-CSharp.dll
// Namespace: 
public static class SkillUtil // TypeDefIndex: 3603
{
	// Fields
	public static readonly SkillId[] NextSkillBufferTargetSkills; // 0x0
	public static readonly SkillId[] UpdateSkillListCheckStopSkills; // 0x8

	// Methods

	// RVA: 0x23A54F8 Offset: 0x23A14F8 VA: 0x23A54F8
	public static bool IsChargeSkill(int skillId) { }

	// RVA: 0x23A5580 Offset: 0x23A1580 VA: 0x23A5580
	public static bool IsChargeSkill(SkillId skillid) { }

	// RVA: 0x23A55C0 Offset: 0x23A15C0 VA: 0x23A55C0
	public static bool IsExpSkill(SkillId id) { }

	// RVA: 0x23A55F0 Offset: 0x23A15F0 VA: 0x23A55F0
	public static bool CheckExclusionSkill(SkillId id) { }

	// RVA: 0x23A56BC Offset: 0x23A16BC VA: 0x23A56BC
	public static bool IsPursuitSkill(SkillId id) { }

	// RVA: 0x23A5760 Offset: 0x23A1760 VA: 0x23A5760
	public static bool CheckAbnormalStopActionStartSkill(SkillActionBase action) { }

	// RVA: 0x23A57FC Offset: 0x23A17FC VA: 0x23A57FC
	public static bool CheckWeakElemet(ElementType useType, ElementType targetType) { }

	// RVA: 0x23A585C Offset: 0x23A185C VA: 0x23A585C
	public static bool CheakResistanceElement(ElementType useType, ElementType targetType) { }

	// RVA: 0x23A58AC Offset: 0x23A18AC VA: 0x23A58AC
	public static ElementType GetWeakElement(ElementType target) { }

	// RVA: 0x23A58D0 Offset: 0x23A18D0 VA: 0x23A58D0
	public static byte HitTypeConvert(SkillHitType hitType, SkillHitReactionType reaction, bool justGuard) { }

	// RVA: 0x23A5960 Offset: 0x23A1960 VA: 0x23A5960
	public static void GetServerHitTypeV2(short serverHitTypeValue, out SkillHitType hitType, out SkillHitReactionType reactionType, out bool isScratch, out bool justGuard) { }

	// RVA: 0x23A5A4C Offset: 0x23A1A4C VA: 0x23A5A4C
	public static bool CheckDanceSkill(int id) { }

	// RVA: 0x23A5AB4 Offset: 0x23A1AB4 VA: 0x23A5AB4
	public static bool CheckDanceSkill(SkillId id) { }

	// RVA: 0x23A5AD0 Offset: 0x23A1AD0 VA: 0x23A5AD0
	public static float[] SkillCalcConvert(SkillDamageData damageData) { }

	// RVA: 0x23A5DC4 Offset: 0x23A1DC4 VA: 0x23A5DC4
	public static SkillId ConvertSkillId(int skillId) { }

	// RVA: 0x23A5E24 Offset: 0x23A1E24 VA: 0x23A5E24
	public static SkillId ConvertSkillId(SkillId skillId) { }

	// RVA: 0x23A5E38 Offset: 0x23A1E38 VA: 0x23A5E38
	public static bool CheckSameSkill(SkillActionBase checkSkill, int targetSkillId) { }

	// RVA: 0x23A5E9C Offset: 0x23A1E9C VA: 0x23A5E9C
	public static bool CheckSameSkill(SkillActionBase checkSkill, SkillId targetSkillId) { }

	// RVA: 0x23A5F9C Offset: 0x23A1F9C VA: 0x23A5F9C
	public static bool CheckSpecialSkill(SkillId skillId) { }

	// RVA: 0x23A5FF0 Offset: 0x23A1FF0 VA: 0x23A5FF0
	public static bool CheckSpecialSkill(int skillId) { }

	// RVA: 0x23A6070 Offset: 0x23A2070 VA: 0x23A6070
	public static int ConvertMotionSpeed(int speed) { }

	// RVA: 0x23A607C Offset: 0x23A207C VA: 0x23A607C
	public static float CalcCastTime(float baseTime, IPlayerStatusCalculator status) { }

	// RVA: 0x23A6164 Offset: 0x23A2164 VA: 0x23A6164
	public static float CalcCastTime(int cspd, float baseTime, IPlayerStatusCalculator status) { }

	// RVA: 0x23A62A8 Offset: 0x23A22A8 VA: 0x23A62A8
	public static bool CheckPursuitAttack(SkillActionBase skill) { }

	// RVA: 0x23A63B8 Offset: 0x23A23B8 VA: 0x23A63B8
	public static bool CheckSkillEquipLimit(EquipItemData itemData, SkillMasterData skillMaster) { }

	// RVA: 0x23A642C Offset: 0x23A242C VA: 0x23A642C
	public static bool CheckSkillEquipLimit(EquipItemData itemData, SkillMasterData skillMaster, out SkillEqLimitFlag eqLimit) { }

	// RVA: 0x23A6984 Offset: 0x23A2984 VA: 0x23A6984
	public static bool CheckSkillMainEquipLimit(EquipItemData itemData, SkillMasterData skillMaster) { }

	// RVA: 0x23A69F8 Offset: 0x23A29F8 VA: 0x23A69F8
	public static bool CheckSkillMainEquipLimit(EquipItemData itemData, SkillMasterData skillMaster, out SkillEqLimitFlag eqLimit) { }

	// RVA: 0x23A6CC4 Offset: 0x23A2CC4 VA: 0x23A6CC4
	public static bool CheckSkillSubEquipLimit(EquipItemData itemData, SkillMasterData skillMaster) { }

	// RVA: 0x23A6D38 Offset: 0x23A2D38 VA: 0x23A6D38
	public static bool CheckSkillSubEquipLimit(EquipItemData itemData, SkillMasterData skillMaster, out SkillEqLimitFlag eqLimit) { }

	// RVA: 0x23A6F60 Offset: 0x23A2F60 VA: 0x23A6F60
	public static bool CheckSkillBodyEquipLimit(EquipItemData itemData, SkillMasterData skillMaster) { }

	// RVA: 0x23A6FD4 Offset: 0x23A2FD4 VA: 0x23A6FD4
	public static bool CheckSkillBodyEquipLimit(EquipItemData itemData, SkillMasterData skillMaster, out SkillEqLimitFlag eqLimit) { }

	// RVA: 0x23A713C Offset: 0x23A313C VA: 0x23A713C
	private static void .cctor() { }
}
