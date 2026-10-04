// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DefenceBossBattleStatus : IMobStatusCalculator, IBossPartsStatus // TypeDefIndex: 862
{
	// Fields
	private readonly MobStatusMaster statusMaster; // 0x10
	private readonly AbnormalStateManager abnormalManager; // 0x18
	private readonly MobBuffManager buffManager; // 0x20
	private Dictionary<int, MobPartsStatus> partsStatus; // 0x28
	private MobStatus mobStatus; // 0x30
	private int mobLevel; // 0x38
	[CompilerGenerated]
	private Func<int, int> <Guard>k__BackingField; // 0x40

	// Properties
	public Dictionary<int, MobPartsStatus> PartsStatus { get; }
	public int AvoidProbability { get; }
	public int CutAttack { get; }
	public int CutMagicAttack { get; }
	public float DamagePercent { get; }
	public int Def { get; }
	public ElementType Element { get; }
	public int ExpDefNormal { get; }
	public int ExpDefSkill { get; }
	public int ExpDefMagic { get; }
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

	// RVA: 0x1ECFF78 Offset: 0x1ECBF78 VA: 0x1ECFF78 Slot: 27
	public Dictionary<int, MobPartsStatus> get_PartsStatus() { }

	// RVA: 0x1ECFF80 Offset: 0x1ECBF80 VA: 0x1ECFF80 Slot: 12
	public int get_AvoidProbability() { }

	// RVA: 0x1ED01A8 Offset: 0x1ECC1A8 VA: 0x1ED01A8 Slot: 9
	public int get_CutAttack() { }

	// RVA: 0x1ED01F0 Offset: 0x1ECC1F0 VA: 0x1ED01F0 Slot: 10
	public int get_CutMagicAttack() { }

	// RVA: 0x1ED0238 Offset: 0x1ECC238 VA: 0x1ED0238 Slot: 17
	public float get_DamagePercent() { }

	// RVA: 0x1ED02EC Offset: 0x1ECC2EC VA: 0x1ED02EC Slot: 7
	public int get_Def() { }

	// RVA: 0x1ED0564 Offset: 0x1ECC564 VA: 0x1ED0564 Slot: 13
	public ElementType get_Element() { }

	// RVA: 0x1ED0580 Offset: 0x1ECC580 VA: 0x1ED0580 Slot: 20
	public int get_ExpDefNormal() { }

	// RVA: 0x1ED0598 Offset: 0x1ECC598 VA: 0x1ED0598 Slot: 21
	public int get_ExpDefSkill() { }

	// RVA: 0x1ED05B0 Offset: 0x1ECC5B0 VA: 0x1ED05B0 Slot: 22
	public int get_ExpDefMagic() { }

	// RVA: 0x1ED05C8 Offset: 0x1ECC5C8 VA: 0x1ED05C8 Slot: 11
	public int get_GuardProbability() { }

	// RVA: 0x1ED0848 Offset: 0x1ECC848 VA: 0x1ED0848 Slot: 5
	public int get_Level() { }

	// RVA: 0x1ED0850 Offset: 0x1ECC850 VA: 0x1ED0850 Slot: 8
	public int get_MagicDef() { }

	// RVA: 0x1ED0AC8 Offset: 0x1ECCAC8 VA: 0x1ED0AC8 Slot: 4
	public int get_MaxHp() { }

	// RVA: 0x1ED0B34 Offset: 0x1ECCB34 VA: 0x1ED0B34 Slot: 14
	public int get_MoveSpeed() { }

	// RVA: 0x1ED0CE4 Offset: 0x1ECCCE4 VA: 0x1ED0CE4 Slot: 18
	public float get_NecessaryFleePercent() { }

	// RVA: 0x1ED0D44 Offset: 0x1ECCD44 VA: 0x1ED0D44 Slot: 6
	public int get_NecessaryHit() { }

	// RVA: 0x1ED0F30 Offset: 0x1ECCF30 VA: 0x1ED0F30 Slot: 15
	public byte get_Persona() { }

	// RVA: 0x1ED0F4C Offset: 0x1ECCF4C VA: 0x1ED0F4C Slot: 16
	public int get_PersonaValue() { }

	// RVA: 0x1ED0F68 Offset: 0x1ECCF68 VA: 0x1ED0F68 Slot: 19
	public float get_StablePercent() { }

	[CompilerGenerated]
	// RVA: 0x1ED0F9C Offset: 0x1ECCF9C VA: 0x1ED0F9C
	public Func<int, int> get_Guard() { }

	[CompilerGenerated]
	// RVA: 0x1ED0FA4 Offset: 0x1ECCFA4 VA: 0x1ED0FA4
	public void set_Guard(Func<int, int> value) { }

	// RVA: 0x1ED0FAC Offset: 0x1ECCFAC VA: 0x1ED0FAC Slot: 23
	public MobPropertyManager get_Property() { }

	// RVA: 0x1ED0FC8 Offset: 0x1ECCFC8 VA: 0x1ED0FC8
	public void .ctor(MobStatusMaster statusMaster, AbnormalStateManager abnormalManager, MobBuffManager buffManager, int level) { }

	// RVA: 0x1ED10A8 Offset: 0x1ECD0A8 VA: 0x1ED10A8 Slot: 24
	public void SetMobStatus(MobStatus mobStatus) { }

	// RVA: 0x1ED10B0 Offset: 0x1ECD0B0 VA: 0x1ED10B0 Slot: 28
	public void SetPartsMaster(int id, MobPartsStatus parts) { }

	// RVA: 0x1ED11C0 Offset: 0x1ECD1C0 VA: 0x1ED11C0 Slot: 29
	public void ClearParts() { }

	// RVA: 0x1ED1210 Offset: 0x1ECD210 VA: 0x1ED1210 Slot: 25
	public int CalcDef(PlayerStatusBase status) { }

	// RVA: 0x1ED1324 Offset: 0x1ECD324 VA: 0x1ED1324 Slot: 26
	public int CalcMdef(PlayerStatusBase status) { }
}
