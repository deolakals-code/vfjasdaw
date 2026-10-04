// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HighRaidMobBattleStatus : IMobStatusCalculator // TypeDefIndex: 893
{
	// Fields
	private readonly MobStatusMaster statusMaster; // 0x10
	private readonly AbnormalStateManager abnormalManager; // 0x18
	private readonly MobBuffManager buffManager; // 0x20
	private MobStatus mobStatus; // 0x28
	private int mobLevel; // 0x30

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

	// RVA: 0x1EFE120 Offset: 0x1EFA120 VA: 0x1EFE120 Slot: 24
	public void SetMobStatus(MobStatus mobStatus) { }

	// RVA: 0x1EFE128 Offset: 0x1EFA128 VA: 0x1EFE128 Slot: 4
	public int get_MaxHp() { }

	// RVA: 0x1EFE264 Offset: 0x1EFA264 VA: 0x1EFE264 Slot: 5
	public int get_Level() { }

	// RVA: 0x1EFE26C Offset: 0x1EFA26C VA: 0x1EFE26C Slot: 6
	public int get_NecessaryHit() { }

	// RVA: 0x1EFE304 Offset: 0x1EFA304 VA: 0x1EFE304 Slot: 7
	public int get_Def() { }

	// RVA: 0x1EFE42C Offset: 0x1EFA42C VA: 0x1EFE42C Slot: 8
	public int get_MagicDef() { }

	// RVA: 0x1EFE590 Offset: 0x1EFA590 VA: 0x1EFE590 Slot: 9
	public int get_CutAttack() { }

	// RVA: 0x1EFE61C Offset: 0x1EFA61C VA: 0x1EFE61C Slot: 10
	public int get_CutMagicAttack() { }

	// RVA: 0x1EFE6A8 Offset: 0x1EFA6A8 VA: 0x1EFE6A8 Slot: 11
	public int get_GuardProbability() { }

	// RVA: 0x1EFE794 Offset: 0x1EFA794 VA: 0x1EFE794 Slot: 12
	public int get_AvoidProbability() { }

	// RVA: 0x1EFE804 Offset: 0x1EFA804 VA: 0x1EFE804 Slot: 13
	public ElementType get_Element() { }

	// RVA: 0x1EFE820 Offset: 0x1EFA820 VA: 0x1EFE820 Slot: 14
	public int get_MoveSpeed() { }

	// RVA: 0x1EFE83C Offset: 0x1EFA83C VA: 0x1EFE83C Slot: 15
	public byte get_Persona() { }

	// RVA: 0x1EFE858 Offset: 0x1EFA858 VA: 0x1EFE858 Slot: 16
	public int get_PersonaValue() { }

	// RVA: 0x1EFE874 Offset: 0x1EFA874 VA: 0x1EFE874 Slot: 17
	public float get_DamagePercent() { }

	// RVA: 0x1EFE87C Offset: 0x1EFA87C VA: 0x1EFE87C Slot: 18
	public float get_NecessaryFleePercent() { }

	// RVA: 0x1EFE8B4 Offset: 0x1EFA8B4 VA: 0x1EFE8B4 Slot: 19
	public float get_StablePercent() { }

	// RVA: 0x1EFE8E8 Offset: 0x1EFA8E8 VA: 0x1EFE8E8 Slot: 20
	public int get_ExpDefNormal() { }

	// RVA: 0x1EFE900 Offset: 0x1EFA900 VA: 0x1EFE900 Slot: 21
	public int get_ExpDefSkill() { }

	// RVA: 0x1EFE918 Offset: 0x1EFA918 VA: 0x1EFE918 Slot: 22
	public int get_ExpDefMagic() { }

	// RVA: 0x1EFE930 Offset: 0x1EFA930 VA: 0x1EFE930 Slot: 23
	public MobPropertyManager get_Property() { }

	// RVA: 0x1EFD8E0 Offset: 0x1EF98E0 VA: 0x1EFD8E0
	public void .ctor(MobStatusMaster statusMaster, AbnormalStateManager abnormalStateManager, MobBuffManager buffManager, int level) { }

	// RVA: 0x1EFE94C Offset: 0x1EFA94C VA: 0x1EFE94C Slot: 25
	public int CalcDef(PlayerStatusBase status) { }

	// RVA: 0x1EFEA60 Offset: 0x1EFAA60 VA: 0x1EFEA60 Slot: 26
	public int CalcMdef(PlayerStatusBase status) { }

	// RVA: 0x1EFE200 Offset: 0x1EFA200 VA: 0x1EFE200
	private bool GetCalcExceptionFlag(out MobPropertyHighRaidCalcExceptionFlag flag) { }
}
