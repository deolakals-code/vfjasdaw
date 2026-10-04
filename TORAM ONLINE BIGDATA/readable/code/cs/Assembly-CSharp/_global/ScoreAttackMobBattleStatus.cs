// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ScoreAttackMobBattleStatus : IMobStatusCalculator // TypeDefIndex: 1130
{
	// Fields
	private readonly MobStatusMaster statusMaster; // 0x10
	private readonly AbnormalStateManager abnormalManager; // 0x18
	private readonly MobBuffManager buffManager; // 0x20
	private MobStatus mobStatus; // 0x28

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

	// RVA: 0x1F4FBF4 Offset: 0x1F4BBF4 VA: 0x1F4FBF4 Slot: 4
	public int get_MaxHp() { }

	// RVA: 0x1F4FC10 Offset: 0x1F4BC10 VA: 0x1F4FC10 Slot: 5
	public int get_Level() { }

	// RVA: 0x1F4FC2C Offset: 0x1F4BC2C VA: 0x1F4FC2C Slot: 6
	public int get_NecessaryHit() { }

	// RVA: 0x1F4FC48 Offset: 0x1F4BC48 VA: 0x1F4FC48 Slot: 7
	public int get_Def() { }

	// RVA: 0x1F4FD40 Offset: 0x1F4BD40 VA: 0x1F4FD40 Slot: 8
	public int get_MagicDef() { }

	// RVA: 0x1F4FE74 Offset: 0x1F4BE74 VA: 0x1F4FE74 Slot: 9
	public int get_CutAttack() { }

	// RVA: 0x1F4FE90 Offset: 0x1F4BE90 VA: 0x1F4FE90 Slot: 10
	public int get_CutMagicAttack() { }

	// RVA: 0x1F4FEAC Offset: 0x1F4BEAC VA: 0x1F4FEAC Slot: 11
	public int get_GuardProbability() { }

	// RVA: 0x1F4FF98 Offset: 0x1F4BF98 VA: 0x1F4FF98 Slot: 12
	public int get_AvoidProbability() { }

	// RVA: 0x1F50004 Offset: 0x1F4C004 VA: 0x1F50004 Slot: 13
	public ElementType get_Element() { }

	// RVA: 0x1F50020 Offset: 0x1F4C020 VA: 0x1F50020 Slot: 14
	public int get_MoveSpeed() { }

	// RVA: 0x1F5003C Offset: 0x1F4C03C VA: 0x1F5003C Slot: 15
	public byte get_Persona() { }

	// RVA: 0x1F50058 Offset: 0x1F4C058 VA: 0x1F50058 Slot: 16
	public int get_PersonaValue() { }

	// RVA: 0x1F50074 Offset: 0x1F4C074 VA: 0x1F50074 Slot: 17
	public float get_DamagePercent() { }

	// RVA: 0x1F5007C Offset: 0x1F4C07C VA: 0x1F5007C Slot: 18
	public float get_NecessaryFleePercent() { }

	// RVA: 0x1F500B4 Offset: 0x1F4C0B4 VA: 0x1F500B4 Slot: 19
	public float get_StablePercent() { }

	// RVA: 0x1F500E8 Offset: 0x1F4C0E8 VA: 0x1F500E8 Slot: 20
	public int get_ExpDefNormal() { }

	// RVA: 0x1F50100 Offset: 0x1F4C100 VA: 0x1F50100 Slot: 21
	public int get_ExpDefSkill() { }

	// RVA: 0x1F50118 Offset: 0x1F4C118 VA: 0x1F50118 Slot: 22
	public int get_ExpDefMagic() { }

	// RVA: 0x1F50130 Offset: 0x1F4C130 VA: 0x1F50130 Slot: 23
	public MobPropertyManager get_Property() { }

	// RVA: 0x1F4F144 Offset: 0x1F4B144 VA: 0x1F4F144
	public void .ctor(MobStatusMaster statusMaster, AbnormalStateManager abnormalManager, MobBuffManager buffManager) { }

	// RVA: 0x1F5014C Offset: 0x1F4C14C VA: 0x1F5014C Slot: 24
	public void SetMobStatus(MobStatus mobStatus) { }

	// RVA: 0x1F50154 Offset: 0x1F4C154 VA: 0x1F50154 Slot: 25
	public int CalcDef(PlayerStatusBase status) { }

	// RVA: 0x1F50268 Offset: 0x1F4C268 VA: 0x1F50268 Slot: 26
	public int CalcMdef(PlayerStatusBase status) { }
}
