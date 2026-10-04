// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ScoreAttackBossBattleStatus : IMobStatusCalculator, IBossPartsStatus // TypeDefIndex: 1128
{
	// Fields
	private readonly MobStatusMaster statusMaster; // 0x10
	private readonly AbnormalStateManager abnormalManager; // 0x18
	private readonly MobBuffManager buffManager; // 0x20
	private MobStatus mobStatus; // 0x28
	private Dictionary<int, MobPartsStatus> partsStatus; // 0x30
	private int playerLevelCap; // 0x38
	[CompilerGenerated]
	private int <Level>k__BackingField; // 0x3C

	// Properties
	public Dictionary<int, MobPartsStatus> PartsStatus { get; }
	public int MaxHp { get; }
	public int Level { get; set; }
	public int CalcLv { get; }
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

	// RVA: 0x1F4D7A8 Offset: 0x1F497A8 VA: 0x1F4D7A8 Slot: 27
	public Dictionary<int, MobPartsStatus> get_PartsStatus() { }

	// RVA: 0x1F4D7B0 Offset: 0x1F497B0 VA: 0x1F4D7B0 Slot: 4
	public int get_MaxHp() { }

	[CompilerGenerated]
	// RVA: 0x1F4D7CC Offset: 0x1F497CC VA: 0x1F4D7CC Slot: 5
	public int get_Level() { }

	[CompilerGenerated]
	// RVA: 0x1F4D7D4 Offset: 0x1F497D4 VA: 0x1F4D7D4
	private void set_Level(int value) { }

	// RVA: 0x1F4D7DC Offset: 0x1F497DC VA: 0x1F4D7DC
	public int get_CalcLv() { }

	// RVA: 0x1F4D7E8 Offset: 0x1F497E8 VA: 0x1F4D7E8 Slot: 6
	public int get_NecessaryHit() { }

	// RVA: 0x1F4D9CC Offset: 0x1F499CC VA: 0x1F4D9CC Slot: 7
	public int get_Def() { }

	// RVA: 0x1F4DC40 Offset: 0x1F49C40 VA: 0x1F4DC40 Slot: 8
	public int get_MagicDef() { }

	// RVA: 0x1F4DEB4 Offset: 0x1F49EB4 VA: 0x1F4DEB4 Slot: 9
	public int get_CutAttack() { }

	// RVA: 0x1F4E080 Offset: 0x1F4A080 VA: 0x1F4E080 Slot: 10
	public int get_CutMagicAttack() { }

	// RVA: 0x1F4E24C Offset: 0x1F4A24C VA: 0x1F4E24C Slot: 11
	public int get_GuardProbability() { }

	// RVA: 0x1F4E4D4 Offset: 0x1F4A4D4 VA: 0x1F4E4D4 Slot: 12
	public int get_AvoidProbability() { }

	// RVA: 0x1F4E700 Offset: 0x1F4A700 VA: 0x1F4E700 Slot: 13
	public ElementType get_Element() { }

	// RVA: 0x1F4E71C Offset: 0x1F4A71C VA: 0x1F4E71C Slot: 14
	public int get_MoveSpeed() { }

	// RVA: 0x1F4E8CC Offset: 0x1F4A8CC VA: 0x1F4E8CC Slot: 15
	public byte get_Persona() { }

	// RVA: 0x1F4E8E8 Offset: 0x1F4A8E8 VA: 0x1F4E8E8 Slot: 16
	public int get_PersonaValue() { }

	// RVA: 0x1F4E904 Offset: 0x1F4A904 VA: 0x1F4E904 Slot: 17
	public float get_DamagePercent() { }

	// RVA: 0x1F4E90C Offset: 0x1F4A90C VA: 0x1F4E90C Slot: 18
	public float get_NecessaryFleePercent() { }

	// RVA: 0x1F4E944 Offset: 0x1F4A944 VA: 0x1F4E944 Slot: 19
	public float get_StablePercent() { }

	// RVA: 0x1F4E978 Offset: 0x1F4A978 VA: 0x1F4E978 Slot: 20
	public int get_ExpDefNormal() { }

	// RVA: 0x1F4E990 Offset: 0x1F4A990 VA: 0x1F4E990 Slot: 21
	public int get_ExpDefSkill() { }

	// RVA: 0x1F4E9A8 Offset: 0x1F4A9A8 VA: 0x1F4E9A8 Slot: 22
	public int get_ExpDefMagic() { }

	// RVA: 0x1F4E9C0 Offset: 0x1F4A9C0 VA: 0x1F4E9C0 Slot: 23
	public MobPropertyManager get_Property() { }

	// RVA: 0x1F4B370 Offset: 0x1F47370 VA: 0x1F4B370
	public void .ctor(MobStatusMaster statusMaster, AbnormalStateManager abnormalManager, MobBuffManager buffManager, int level) { }

	// RVA: 0x1F4E9DC Offset: 0x1F4A9DC VA: 0x1F4E9DC Slot: 24
	public void SetMobStatus(MobStatus mobStatus) { }

	// RVA: 0x1F4B5FC Offset: 0x1F475FC VA: 0x1F4B5FC
	public void UpdateLevel(int level) { }

	// RVA: 0x1F4E9E4 Offset: 0x1F4A9E4 VA: 0x1F4E9E4 Slot: 28
	public void SetPartsMaster(int id, MobPartsStatus parts) { }

	// RVA: 0x1F4EAF4 Offset: 0x1F4AAF4 VA: 0x1F4EAF4 Slot: 29
	public void ClearParts() { }

	// RVA: 0x1F4EB44 Offset: 0x1F4AB44 VA: 0x1F4EB44 Slot: 25
	public int CalcDef(PlayerStatusBase status) { }

	// RVA: 0x1F4EC58 Offset: 0x1F4AC58 VA: 0x1F4EC58 Slot: 26
	public int CalcMdef(PlayerStatusBase status) { }
}
