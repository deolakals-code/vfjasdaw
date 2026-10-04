// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DefenceMobBattleStatus : IMobStatusCalculator // TypeDefIndex: 869
{
	// Fields
	private readonly MobStatusMaster statusMaster; // 0x10
	private readonly AbnormalStateManager abnormalManager; // 0x18
	private readonly MobBuffManager buffManager; // 0x20
	private MobStatus mobStatus; // 0x28
	private int mobLevel; // 0x30
	[CompilerGenerated]
	private Func<int, int> <Guard>k__BackingField; // 0x38

	// Properties
	public int AvoidProbability { get; }
	public int CutAttack { get; }
	public int CutMagicAttack { get; }
	public float DamagePercent { get; }
	public int Def { get; }
	public ElementType Element { get; }
	public int ExpDefMagic { get; }
	public int ExpDefNormal { get; }
	public int ExpDefSkill { get; }
	public int GuardProbability { get; }
	public int Level { get; }
	public int MagicDef { get; }
	public int MaxHp { get; }
	public int MoveSpeed { get; }
	public float NecessaryFleePercent { get; }
	public int NecessaryHit { get; }
	public byte Persona { get; }
	public int PersonaValue { get; }
	public float StablePercent { get; }
	public Func<int, int> Guard { get; set; }
	public MobPropertyManager Property { get; }

	// Methods

	// RVA: 0x1EE576C Offset: 0x1EE176C VA: 0x1EE576C Slot: 12
	public int get_AvoidProbability() { }

	// RVA: 0x1EE57D8 Offset: 0x1EE17D8 VA: 0x1EE57D8 Slot: 9
	public int get_CutAttack() { }

	// RVA: 0x1EE5820 Offset: 0x1EE1820 VA: 0x1EE5820 Slot: 10
	public int get_CutMagicAttack() { }

	// RVA: 0x1EE5868 Offset: 0x1EE1868 VA: 0x1EE5868 Slot: 17
	public float get_DamagePercent() { }

	// RVA: 0x1EE591C Offset: 0x1EE191C VA: 0x1EE591C Slot: 7
	public int get_Def() { }

	// RVA: 0x1EE5A08 Offset: 0x1EE1A08 VA: 0x1EE5A08 Slot: 13
	public ElementType get_Element() { }

	// RVA: 0x1EE5A24 Offset: 0x1EE1A24 VA: 0x1EE5A24 Slot: 22
	public int get_ExpDefMagic() { }

	// RVA: 0x1EE5A3C Offset: 0x1EE1A3C VA: 0x1EE5A3C Slot: 20
	public int get_ExpDefNormal() { }

	// RVA: 0x1EE5A54 Offset: 0x1EE1A54 VA: 0x1EE5A54 Slot: 21
	public int get_ExpDefSkill() { }

	// RVA: 0x1EE5A6C Offset: 0x1EE1A6C VA: 0x1EE5A6C Slot: 11
	public int get_GuardProbability() { }

	// RVA: 0x1EE5B74 Offset: 0x1EE1B74 VA: 0x1EE5B74 Slot: 5
	public int get_Level() { }

	// RVA: 0x1EE5B7C Offset: 0x1EE1B7C VA: 0x1EE5B7C Slot: 8
	public int get_MagicDef() { }

	// RVA: 0x1EE5C68 Offset: 0x1EE1C68 VA: 0x1EE5C68 Slot: 4
	public int get_MaxHp() { }

	// RVA: 0x1EE28D0 Offset: 0x1EDE8D0 VA: 0x1EE28D0 Slot: 14
	public int get_MoveSpeed() { }

	// RVA: 0x1EE5CD4 Offset: 0x1EE1CD4 VA: 0x1EE5CD4 Slot: 18
	public float get_NecessaryFleePercent() { }

	// RVA: 0x1EE5D34 Offset: 0x1EE1D34 VA: 0x1EE5D34 Slot: 6
	public int get_NecessaryHit() { }

	// RVA: 0x1EE5D8C Offset: 0x1EE1D8C VA: 0x1EE5D8C Slot: 15
	public byte get_Persona() { }

	// RVA: 0x1EE5DA8 Offset: 0x1EE1DA8 VA: 0x1EE5DA8 Slot: 16
	public int get_PersonaValue() { }

	// RVA: 0x1EE5DC4 Offset: 0x1EE1DC4 VA: 0x1EE5DC4 Slot: 19
	public float get_StablePercent() { }

	[CompilerGenerated]
	// RVA: 0x1EE5DF8 Offset: 0x1EE1DF8 VA: 0x1EE5DF8
	public Func<int, int> get_Guard() { }

	[CompilerGenerated]
	// RVA: 0x1EE5E00 Offset: 0x1EE1E00 VA: 0x1EE5E00
	public void set_Guard(Func<int, int> value) { }

	// RVA: 0x1EE5E08 Offset: 0x1EE1E08 VA: 0x1EE5E08 Slot: 23
	public MobPropertyManager get_Property() { }

	// RVA: 0x1EE29FC Offset: 0x1EDE9FC VA: 0x1EE29FC
	public void .ctor(MobStatusMaster statusMaster, AbnormalStateManager abnormalManager, MobBuffManager buffManager, int level) { }

	// RVA: 0x1EE5E24 Offset: 0x1EE1E24 VA: 0x1EE5E24 Slot: 24
	public void SetMobStatus(MobStatus mobStatus) { }

	// RVA: 0x1EE5E2C Offset: 0x1EE1E2C VA: 0x1EE5E2C Slot: 25
	public int CalcDef(PlayerStatusBase status) { }

	// RVA: 0x1EE5F40 Offset: 0x1EE1F40 VA: 0x1EE5F40 Slot: 26
	public int CalcMdef(PlayerStatusBase status) { }
}
