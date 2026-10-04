// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GuildRaidBossMobBattleStatus : IMobStatusCalculator, IBossPartsStatus // TypeDefIndex: 884
{
	// Fields
	[CompilerGenerated]
	private int <Level>k__BackingField; // 0x10
	[CompilerGenerated]
	private Dictionary<int, MobPartsStatus> <PartsStatus>k__BackingField; // 0x18
	private readonly MobStatusMaster statusMaster; // 0x20
	private readonly AbnormalStateManager abnormalManager; // 0x28
	private readonly MobBuffManager buffManager; // 0x30
	private MobStatus mobStatus; // 0x38
	private MobPropertyManager mobProperty; // 0x40
	private MobPropertyMaster[] randomProperty; // 0x48
	private int hpGage; // 0x50

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
	public Dictionary<int, MobPartsStatus> PartsStatus { get; set; }

	// Methods

	// RVA: 0x1EF6060 Offset: 0x1EF2060 VA: 0x1EF6060 Slot: 4
	public int get_MaxHp() { }

	[CompilerGenerated]
	// RVA: 0x1EF6194 Offset: 0x1EF2194 VA: 0x1EF6194 Slot: 5
	public int get_Level() { }

	[CompilerGenerated]
	// RVA: 0x1EF619C Offset: 0x1EF219C VA: 0x1EF619C
	private void set_Level(int value) { }

	// RVA: 0x1EF61A4 Offset: 0x1EF21A4 VA: 0x1EF61A4 Slot: 6
	public int get_NecessaryHit() { }

	// RVA: 0x1EF6424 Offset: 0x1EF2424 VA: 0x1EF6424 Slot: 7
	public int get_Def() { }

	// RVA: 0x1EF66D4 Offset: 0x1EF26D4 VA: 0x1EF66D4 Slot: 8
	public int get_MagicDef() { }

	// RVA: 0x1EF6984 Offset: 0x1EF2984 VA: 0x1EF6984 Slot: 9
	public int get_CutAttack() { }

	// RVA: 0x1EF6AEC Offset: 0x1EF2AEC VA: 0x1EF6AEC Slot: 10
	public int get_CutMagicAttack() { }

	// RVA: 0x1EF6C54 Offset: 0x1EF2C54 VA: 0x1EF6C54 Slot: 11
	public int get_GuardProbability() { }

	// RVA: 0x1EF6E74 Offset: 0x1EF2E74 VA: 0x1EF6E74 Slot: 12
	public int get_AvoidProbability() { }

	// RVA: 0x1EF7054 Offset: 0x1EF3054 VA: 0x1EF7054 Slot: 13
	public ElementType get_Element() { }

	// RVA: 0x1EF7070 Offset: 0x1EF3070 VA: 0x1EF7070 Slot: 14
	public int get_MoveSpeed() { }

	// RVA: 0x1EF71B8 Offset: 0x1EF31B8 VA: 0x1EF71B8 Slot: 15
	public byte get_Persona() { }

	// RVA: 0x1EF71D4 Offset: 0x1EF31D4 VA: 0x1EF71D4 Slot: 16
	public int get_PersonaValue() { }

	// RVA: 0x1EF71F0 Offset: 0x1EF31F0 VA: 0x1EF71F0 Slot: 17
	public float get_DamagePercent() { }

	// RVA: 0x1EF7290 Offset: 0x1EF3290 VA: 0x1EF7290 Slot: 18
	public float get_NecessaryFleePercent() { }

	// RVA: 0x1EF72F0 Offset: 0x1EF32F0 VA: 0x1EF72F0 Slot: 19
	public float get_StablePercent() { }

	// RVA: 0x1EF7324 Offset: 0x1EF3324 VA: 0x1EF7324 Slot: 20
	public int get_ExpDefNormal() { }

	// RVA: 0x1EF733C Offset: 0x1EF333C VA: 0x1EF733C Slot: 21
	public int get_ExpDefSkill() { }

	// RVA: 0x1EF7354 Offset: 0x1EF3354 VA: 0x1EF7354 Slot: 22
	public int get_ExpDefMagic() { }

	// RVA: 0x1EF736C Offset: 0x1EF336C VA: 0x1EF736C Slot: 23
	public MobPropertyManager get_Property() { }

	[CompilerGenerated]
	// RVA: 0x1EF7374 Offset: 0x1EF3374 VA: 0x1EF7374 Slot: 27
	public Dictionary<int, MobPartsStatus> get_PartsStatus() { }

	[CompilerGenerated]
	// RVA: 0x1EF737C Offset: 0x1EF337C VA: 0x1EF737C
	private void set_PartsStatus(Dictionary<int, MobPartsStatus> value) { }

	// RVA: 0x1EF7384 Offset: 0x1EF3384 VA: 0x1EF7384
	public void .ctor(MobStatusMaster statusMaster, AbnormalStateManager abnormalManager, MobBuffManager buffManager, int level, MobPropertyMaster[] randomProperty) { }

	// RVA: 0x1EF75AC Offset: 0x1EF35AC VA: 0x1EF75AC Slot: 25
	public int CalcDef(PlayerStatusBase status) { }

	// RVA: 0x1EF76C0 Offset: 0x1EF36C0 VA: 0x1EF76C0 Slot: 26
	public int CalcMdef(PlayerStatusBase status) { }

	// RVA: 0x1EF77D4 Offset: 0x1EF37D4 VA: 0x1EF77D4 Slot: 24
	public void SetMobStatus(MobStatus mobStatus) { }

	// RVA: 0x1EF77DC Offset: 0x1EF37DC VA: 0x1EF77DC Slot: 28
	public void SetPartsMaster(int id, MobPartsStatus parts) { }

	// RVA: 0x1EF78EC Offset: 0x1EF38EC VA: 0x1EF78EC Slot: 29
	public void ClearParts() { }

	// RVA: 0x1EF793C Offset: 0x1EF393C VA: 0x1EF793C
	public void SetHpGage(int gage) { }

	// RVA: 0x1EF6374 Offset: 0x1EF2374 VA: 0x1EF6374
	private bool TryGetCollectionValue(MonsterPropertyStatusCollectionType type, out int constant, out float rate) { }

	// RVA: 0x1EF74C4 Offset: 0x1EF34C4 VA: 0x1EF74C4
	private void InitializeMobProperty() { }
}
