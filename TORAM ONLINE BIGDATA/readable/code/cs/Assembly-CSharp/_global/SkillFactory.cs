// Assembly: Assembly-CSharp.dll
// Namespace: 
public static class SkillFactory // TypeDefIndex: 3589
{
	// Methods

	// RVA: 0x2396104 Offset: 0x2392104 VA: 0x2396104
	public static SkillActionBase CreateSkill(SkillId id) { }

	// RVA: 0x2396894 Offset: 0x2392894 VA: 0x2396894
	public static SkillActionBase CreateSkill(int id) { }

	// RVA: 0x239AFD4 Offset: 0x2396FD4 VA: 0x239AFD4
	public static SkillActionBase CreateSkill(short id, byte lv, CharacterActionManagerBase playerAction) { }

	// RVA: 0x239B19C Offset: 0x239719C VA: 0x239B19C
	public static SkillMasteryBase CreateMasterySkill(SkillData skillData) { }

	// RVA: 0x239CE70 Offset: 0x2398E70 VA: 0x239CE70
	public static SkillBufferDataBase CreateSkillBuffer(SkillId id, byte lv, bool self, float time, int val) { }

	// RVA: 0x239CE78 Offset: 0x2398E78 VA: 0x239CE78
	public static SkillBufferDataBase CreateSkillBuffer(int id, byte lv, bool self, float time, int val) { }

	// RVA: 0x239E7D0 Offset: 0x239A7D0 VA: 0x239E7D0
	public static SkillActionBase CreateFamiliaSkill(int skillId) { }

	// RVA: 0x239E9B4 Offset: 0x239A9B4 VA: 0x239E9B4
	public static SkillActionBase CreateHuntingOneSkill(int skillId) { }

	// RVA: 0x239EAB8 Offset: 0x239AAB8 VA: 0x239EAB8
	public static SkillActionBase CreateSummonDemonicSkill(int skillId) { }

	// RVA: 0x239EBB0 Offset: 0x239ABB0 VA: 0x239EBB0
	public static SkillActionBase CreateCallGolemSkill(int skillId) { }
}
