// Assembly: Assembly-CSharp.dll
// Namespace: 
public class NewWaveBossBattleStatus : IMobStatusCalculator, IBossPartsStatus // TypeDefIndex: 1047
{
	// Fields
	private readonly MobStatusMaster statusMaster; // 0x10
	private readonly AbnormalStateManager abnormalManager; // 0x18
	private readonly MobBuffManager buffManager; // 0x20
	private Dictionary<int, MobPartsStatus> partsStatus; // 0x28
	private MobStatus mobStatus; // 0x30
	[CompilerGenerated]
	private int <Level>k__BackingField; // 0x38

	// Properties
	public int AvoidProbability { get; }
	public int GuardProbability { get; }
	public int CutAttack { get; }
	public int CutMagicAttack { get; }
	public float DamagePercent { get; }
	public int Def { get; }
	public int MagicDef { get; }
	public ElementType Element { get; }
	public int Level { get; set; }
	public int MaxHp { get; }
	public int MoveSpeed { get; }
	public float NecessaryFleePercent { get; }
	public int NecessaryHit { get; }
	public Dictionary<int, MobPartsStatus> PartsStatus { get; }
	public byte Persona { get; }
	public int PersonaValue { get; }
	public float StablePercent { get; }
	public int ExpDefNormal { get; }
	public int ExpDefSkill { get; }
	public int ExpDefMagic { get; }
	public MobPropertyManager Property { get; }

	// Methods

	// RVA: 0x1F3B978 Offset: 0x1F37978 VA: 0x1F3B978 Slot: 12
	public int get_AvoidProbability() { }

	// RVA: 0x1F3BB98 Offset: 0x1F37B98 VA: 0x1F3BB98 Slot: 11
	public int get_GuardProbability() { }

	// RVA: 0x1F3BE18 Offset: 0x1F37E18 VA: 0x1F3BE18 Slot: 9
	public int get_CutAttack() { }

	// RVA: 0x1F3BE60 Offset: 0x1F37E60 VA: 0x1F3BE60 Slot: 10
	public int get_CutMagicAttack() { }

	// RVA: 0x1F3BEA8 Offset: 0x1F37EA8 VA: 0x1F3BEA8 Slot: 17
	public float get_DamagePercent() { }

	// RVA: 0x1F3BF5C Offset: 0x1F37F5C VA: 0x1F3BF5C Slot: 7
	public int get_Def() { }

	// RVA: 0x1F3C1CC Offset: 0x1F381CC VA: 0x1F3C1CC Slot: 8
	public int get_MagicDef() { }

	// RVA: 0x1F3C43C Offset: 0x1F3843C VA: 0x1F3C43C Slot: 13
	public ElementType get_Element() { }

	[CompilerGenerated]
	// RVA: 0x1F3C458 Offset: 0x1F38458 VA: 0x1F3C458 Slot: 5
	public int get_Level() { }

	[CompilerGenerated]
	// RVA: 0x1F3C460 Offset: 0x1F38460 VA: 0x1F3C460
	private void set_Level(int value) { }

	// RVA: 0x1F3C468 Offset: 0x1F38468 VA: 0x1F3C468 Slot: 4
	public int get_MaxHp() { }

	// RVA: 0x1F3A238 Offset: 0x1F36238 VA: 0x1F3A238 Slot: 14
	public int get_MoveSpeed() { }

	// RVA: 0x1F3C4F8 Offset: 0x1F384F8 VA: 0x1F3C4F8 Slot: 18
	public float get_NecessaryFleePercent() { }

	// RVA: 0x1F3C558 Offset: 0x1F38558 VA: 0x1F3C558 Slot: 6
	public int get_NecessaryHit() { }

	// RVA: 0x1F3C738 Offset: 0x1F38738 VA: 0x1F3C738 Slot: 27
	public Dictionary<int, MobPartsStatus> get_PartsStatus() { }

	// RVA: 0x1F3C740 Offset: 0x1F38740 VA: 0x1F3C740 Slot: 15
	public byte get_Persona() { }

	// RVA: 0x1F3C75C Offset: 0x1F3875C VA: 0x1F3C75C Slot: 16
	public int get_PersonaValue() { }

	// RVA: 0x1F3C778 Offset: 0x1F38778 VA: 0x1F3C778 Slot: 19
	public float get_StablePercent() { }

	// RVA: 0x1F3C7AC Offset: 0x1F387AC VA: 0x1F3C7AC Slot: 20
	public int get_ExpDefNormal() { }

	// RVA: 0x1F3C7C4 Offset: 0x1F387C4 VA: 0x1F3C7C4 Slot: 21
	public int get_ExpDefSkill() { }

	// RVA: 0x1F3C7DC Offset: 0x1F387DC VA: 0x1F3C7DC Slot: 22
	public int get_ExpDefMagic() { }

	// RVA: 0x1F3C7F4 Offset: 0x1F387F4 VA: 0x1F3C7F4 Slot: 23
	public MobPropertyManager get_Property() { }

	// RVA: 0x1F3B764 Offset: 0x1F37764 VA: 0x1F3B764
	public void .ctor(MobStatusMaster statusMaster, AbnormalStateManager abnormalManager, MobBuffManager buffManager, int level) { }

	// RVA: 0x1F3C810 Offset: 0x1F38810 VA: 0x1F3C810 Slot: 24
	public void SetMobStatus(MobStatus mobStatus) { }

	// RVA: 0x1F3C818 Offset: 0x1F38818 VA: 0x1F3C818 Slot: 28
	public void SetPartsMaster(int id, MobPartsStatus parts) { }

	// RVA: 0x1F3C928 Offset: 0x1F38928 VA: 0x1F3C928 Slot: 29
	public void ClearParts() { }

	// RVA: 0x1F3C978 Offset: 0x1F38978 VA: 0x1F3C978 Slot: 25
	public int CalcDef(PlayerStatusBase status) { }

	// RVA: 0x1F3CABC Offset: 0x1F38ABC VA: 0x1F3CABC Slot: 26
	public int CalcMdef(PlayerStatusBase status) { }
}
