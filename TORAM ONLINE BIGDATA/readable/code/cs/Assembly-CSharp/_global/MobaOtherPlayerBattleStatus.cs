// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobaOtherPlayerBattleStatus : IMobStatusCalculator, IMobLevelFluctuation // TypeDefIndex: 1227
{
	// Fields
	private PlayerBattleStatus battleStatus; // 0x10
	private AbnormalStateManager abnormalManager; // 0x18
	private SkillBufferManager bufferManager; // 0x20
	private MobPropertyManager property; // 0x28
	private int level; // 0x30
	private MobStatus mobStatus; // 0x38

	// Properties
	public int MaxHp { get; }
	public int Level { get; }
	public int NecessaryHit { get; }
	public int Def { get; }
	public int MagicDef { get; }
	public int CutAttack { get; }
	public int CutMagicAttack { get; }
	public int GuardProbability { get; }
	public int AvoidProbability { get; }
	public ElementType Element { get; }
	public int MoveSpeed { get; }
	public byte Persona { get; }
	public int PersonaValue { get; }
	public float DamagePercent { get; }
	public float NecessaryFleePercent { get; }
	public float StablePercent { get; }
	public int ExpDefNormal { get; }
	public int ExpDefSkill { get; }
	public int ExpDefMagic { get; }
	public MobPropertyManager Property { get; }

	// Methods

	// RVA: 0x1F93D70 Offset: 0x1F8FD70 VA: 0x1F93D70 Slot: 4
	public int get_MaxHp() { }

	// RVA: 0x1F93D78 Offset: 0x1F8FD78 VA: 0x1F93D78 Slot: 5
	public int get_Level() { }

	// RVA: 0x1F93D80 Offset: 0x1F8FD80 VA: 0x1F93D80 Slot: 6
	public int get_NecessaryHit() { }

	// RVA: 0x1F93D88 Offset: 0x1F8FD88 VA: 0x1F93D88 Slot: 7
	public int get_Def() { }

	// RVA: 0x1F93D90 Offset: 0x1F8FD90 VA: 0x1F93D90 Slot: 8
	public int get_MagicDef() { }

	// RVA: 0x1F93D98 Offset: 0x1F8FD98 VA: 0x1F93D98 Slot: 9
	public int get_CutAttack() { }

	// RVA: 0x1F93DA0 Offset: 0x1F8FDA0 VA: 0x1F93DA0 Slot: 10
	public int get_CutMagicAttack() { }

	// RVA: 0x1F93DA8 Offset: 0x1F8FDA8 VA: 0x1F93DA8 Slot: 11
	public int get_GuardProbability() { }

	// RVA: 0x1F93DB0 Offset: 0x1F8FDB0 VA: 0x1F93DB0 Slot: 12
	public int get_AvoidProbability() { }

	// RVA: 0x1F93DB8 Offset: 0x1F8FDB8 VA: 0x1F93DB8 Slot: 13
	public ElementType get_Element() { }

	// RVA: 0x1F93DC0 Offset: 0x1F8FDC0 VA: 0x1F93DC0 Slot: 14
	public int get_MoveSpeed() { }

	// RVA: 0x1F93DC8 Offset: 0x1F8FDC8 VA: 0x1F93DC8 Slot: 15
	public byte get_Persona() { }

	// RVA: 0x1F93DD0 Offset: 0x1F8FDD0 VA: 0x1F93DD0 Slot: 16
	public int get_PersonaValue() { }

	// RVA: 0x1F93DD8 Offset: 0x1F8FDD8 VA: 0x1F93DD8 Slot: 17
	public float get_DamagePercent() { }

	// RVA: 0x1F93DE0 Offset: 0x1F8FDE0 VA: 0x1F93DE0 Slot: 18
	public float get_NecessaryFleePercent() { }

	// RVA: 0x1F93E18 Offset: 0x1F8FE18 VA: 0x1F93E18 Slot: 19
	public float get_StablePercent() { }

	// RVA: 0x1F93E4C Offset: 0x1F8FE4C VA: 0x1F93E4C Slot: 20
	public int get_ExpDefNormal() { }

	// RVA: 0x1F93E64 Offset: 0x1F8FE64 VA: 0x1F93E64 Slot: 21
	public int get_ExpDefSkill() { }

	// RVA: 0x1F93E7C Offset: 0x1F8FE7C VA: 0x1F93E7C Slot: 22
	public int get_ExpDefMagic() { }

	// RVA: 0x1F93E94 Offset: 0x1F8FE94 VA: 0x1F93E94 Slot: 23
	public MobPropertyManager get_Property() { }

	// RVA: 0x1F90A34 Offset: 0x1F8CA34 VA: 0x1F90A34
	public void .ctor(PlayerBattleStatus battleStatus, AbnormalStateManager abnormalManager, SkillBufferManager bufferManager) { }

	// RVA: 0x1F93E9C Offset: 0x1F8FE9C VA: 0x1F93E9C Slot: 25
	public int CalcDef(PlayerStatusBase status) { }

	// RVA: 0x1F93EA4 Offset: 0x1F8FEA4 VA: 0x1F93EA4 Slot: 26
	public int CalcMdef(PlayerStatusBase status) { }

	// RVA: 0x1F93EAC Offset: 0x1F8FEAC VA: 0x1F93EAC Slot: 27
	public void SetMobLevel(int level) { }

	// RVA: 0x1F93EB4 Offset: 0x1F8FEB4 VA: 0x1F93EB4 Slot: 24
	public void SetMobStatus(MobStatus mobStatus) { }
}
