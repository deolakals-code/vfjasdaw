// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GuildRaidMobBattleStatus : IMobStatusCalculator // TypeDefIndex: 888
{
	// Fields
	[CompilerGenerated]
	private int <Level>k__BackingField; // 0x10
	private readonly MobStatusMaster statusMaster; // 0x18
	private readonly AbnormalStateManager abnormalManager; // 0x20
	private readonly MobBuffManager buffManager; // 0x28
	private MobStatus mobStatus; // 0x30
	private MobPropertyManager mobProperty; // 0x38
	private MobPropertyMaster[] randomProperty; // 0x40

	// Properties
	public int MaxHp { get; }
	public int Level { get; set; }
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

	// RVA: 0x1EF94BC Offset: 0x1EF54BC VA: 0x1EF94BC Slot: 4
	public int get_MaxHp() { }

	[CompilerGenerated]
	// RVA: 0x1EF94D8 Offset: 0x1EF54D8 VA: 0x1EF94D8 Slot: 5
	public int get_Level() { }

	[CompilerGenerated]
	// RVA: 0x1EF94E0 Offset: 0x1EF54E0 VA: 0x1EF94E0
	private void set_Level(int value) { }

	// RVA: 0x1EF94E8 Offset: 0x1EF54E8 VA: 0x1EF94E8 Slot: 6
	public int get_NecessaryHit() { }

	// RVA: 0x1EF9504 Offset: 0x1EF5504 VA: 0x1EF9504 Slot: 7
	public int get_Def() { }

	// RVA: 0x1EF9610 Offset: 0x1EF5610 VA: 0x1EF9610 Slot: 8
	public int get_MagicDef() { }

	// RVA: 0x1EF971C Offset: 0x1EF571C VA: 0x1EF971C Slot: 9
	public int get_CutAttack() { }

	// RVA: 0x1EF9738 Offset: 0x1EF5738 VA: 0x1EF9738 Slot: 10
	public int get_CutMagicAttack() { }

	// RVA: 0x1EF9754 Offset: 0x1EF5754 VA: 0x1EF9754 Slot: 11
	public int get_GuardProbability() { }

	// RVA: 0x1EF979C Offset: 0x1EF579C VA: 0x1EF979C Slot: 12
	public int get_AvoidProbability() { }

	// RVA: 0x1EF97E8 Offset: 0x1EF57E8 VA: 0x1EF97E8 Slot: 13
	public ElementType get_Element() { }

	// RVA: 0x1EF9804 Offset: 0x1EF5804 VA: 0x1EF9804 Slot: 14
	public int get_MoveSpeed() { }

	// RVA: 0x1EF9820 Offset: 0x1EF5820 VA: 0x1EF9820 Slot: 15
	public byte get_Persona() { }

	// RVA: 0x1EF983C Offset: 0x1EF583C VA: 0x1EF983C Slot: 16
	public int get_PersonaValue() { }

	// RVA: 0x1EF9858 Offset: 0x1EF5858 VA: 0x1EF9858 Slot: 17
	public float get_DamagePercent() { }

	// RVA: 0x1EF9860 Offset: 0x1EF5860 VA: 0x1EF9860 Slot: 18
	public float get_NecessaryFleePercent() { }

	// RVA: 0x1EF9898 Offset: 0x1EF5898 VA: 0x1EF9898 Slot: 19
	public float get_StablePercent() { }

	// RVA: 0x1EF98CC Offset: 0x1EF58CC VA: 0x1EF98CC Slot: 20
	public int get_ExpDefNormal() { }

	// RVA: 0x1EF98E4 Offset: 0x1EF58E4 VA: 0x1EF98E4 Slot: 21
	public int get_ExpDefSkill() { }

	// RVA: 0x1EF98FC Offset: 0x1EF58FC VA: 0x1EF98FC Slot: 22
	public int get_ExpDefMagic() { }

	// RVA: 0x1EF9914 Offset: 0x1EF5914 VA: 0x1EF9914 Slot: 23
	public MobPropertyManager get_Property() { }

	// RVA: 0x1EF92E0 Offset: 0x1EF52E0 VA: 0x1EF92E0
	public void .ctor(MobStatusMaster statusMaster, AbnormalStateManager abnormalManager, MobBuffManager buffManager, MobPropertyMaster[] randomProperty) { }

	// RVA: 0x1EF9A04 Offset: 0x1EF5A04 VA: 0x1EF9A04 Slot: 25
	public int CalcDef(PlayerStatusBase status) { }

	// RVA: 0x1EF9B18 Offset: 0x1EF5B18 VA: 0x1EF9B18 Slot: 26
	public int CalcMdef(PlayerStatusBase status) { }

	// RVA: 0x1EF9C2C Offset: 0x1EF5C2C VA: 0x1EF9C2C Slot: 24
	public void SetMobStatus(MobStatus mobStatus) { }

	// RVA: 0x1EF991C Offset: 0x1EF591C VA: 0x1EF991C
	private void InitializeMobProperty() { }
}
