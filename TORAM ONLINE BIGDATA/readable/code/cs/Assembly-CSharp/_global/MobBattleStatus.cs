// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobBattleStatus : IMobStatusCalculator // TypeDefIndex: 921
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

	// RVA: 0x1F03B94 Offset: 0x1EFFB94 VA: 0x1F03B94
	public void .ctor(MobStatusMaster statusMaster, AbnormalStateManager abnormalManager, MobBuffManager buffManager) { }

	// RVA: 0x1F056A0 Offset: 0x1F016A0 VA: 0x1F056A0 Slot: 24
	public void SetMobStatus(MobStatus mobStatus) { }

	// RVA: 0x1F056A8 Offset: 0x1F016A8 VA: 0x1F056A8 Slot: 25
	public int CalcDef(PlayerStatusBase status) { }

	// RVA: 0x1F058B4 Offset: 0x1F018B4 VA: 0x1F058B4 Slot: 26
	public int CalcMdef(PlayerStatusBase status) { }

	// RVA: 0x1F05B18 Offset: 0x1F01B18 VA: 0x1F05B18 Slot: 4
	public int get_MaxHp() { }

	// RVA: 0x1F05B34 Offset: 0x1F01B34 VA: 0x1F05B34 Slot: 5
	public int get_Level() { }

	// RVA: 0x1F05B50 Offset: 0x1F01B50 VA: 0x1F05B50 Slot: 6
	public int get_NecessaryHit() { }

	// RVA: 0x1F057BC Offset: 0x1F017BC VA: 0x1F057BC Slot: 7
	public int get_Def() { }

	// RVA: 0x1F059C8 Offset: 0x1F019C8 VA: 0x1F059C8 Slot: 8
	public int get_MagicDef() { }

	// RVA: 0x1F05B6C Offset: 0x1F01B6C VA: 0x1F05B6C Slot: 9
	public int get_CutAttack() { }

	// RVA: 0x1F05B88 Offset: 0x1F01B88 VA: 0x1F05B88 Slot: 10
	public int get_CutMagicAttack() { }

	// RVA: 0x1F05BA4 Offset: 0x1F01BA4 VA: 0x1F05BA4 Slot: 11
	public int get_GuardProbability() { }

	// RVA: 0x1F05CC8 Offset: 0x1F01CC8 VA: 0x1F05CC8 Slot: 12
	public int get_AvoidProbability() { }

	// RVA: 0x1F05D78 Offset: 0x1F01D78 VA: 0x1F05D78 Slot: 13
	public ElementType get_Element() { }

	// RVA: 0x1F05D94 Offset: 0x1F01D94 VA: 0x1F05D94 Slot: 14
	public int get_MoveSpeed() { }

	// RVA: 0x1F05DB0 Offset: 0x1F01DB0 VA: 0x1F05DB0 Slot: 15
	public byte get_Persona() { }

	// RVA: 0x1F05DCC Offset: 0x1F01DCC VA: 0x1F05DCC Slot: 16
	public int get_PersonaValue() { }

	// RVA: 0x1F05DE8 Offset: 0x1F01DE8 VA: 0x1F05DE8 Slot: 17
	public float get_DamagePercent() { }

	// RVA: 0x1F05DF0 Offset: 0x1F01DF0 VA: 0x1F05DF0 Slot: 18
	public float get_NecessaryFleePercent() { }

	// RVA: 0x1F05E4C Offset: 0x1F01E4C VA: 0x1F05E4C Slot: 19
	public float get_StablePercent() { }

	// RVA: 0x1F05EA0 Offset: 0x1F01EA0 VA: 0x1F05EA0 Slot: 20
	public int get_ExpDefNormal() { }

	// RVA: 0x1F05EB8 Offset: 0x1F01EB8 VA: 0x1F05EB8 Slot: 21
	public int get_ExpDefSkill() { }

	// RVA: 0x1F05ED0 Offset: 0x1F01ED0 VA: 0x1F05ED0 Slot: 22
	public int get_ExpDefMagic() { }

	// RVA: 0x1F05EE8 Offset: 0x1F01EE8 VA: 0x1F05EE8 Slot: 23
	public MobPropertyManager get_Property() { }
}
