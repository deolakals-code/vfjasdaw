// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GuildRaidEntourageMobBattleStatus : IMobStatusCalculator // TypeDefIndex: 886
{
	// Fields
	[CompilerGenerated]
	private int <Level>k__BackingField; // 0x10
	private readonly MobStatusMaster statusMaster; // 0x18
	private readonly AbnormalStateManager abnormalManager; // 0x20
	private readonly MobBuffManager buffManager; // 0x28
	private MobStatus mobStatus; // 0x30
	private MobPropertyManager mobProperty; // 0x38
	private int startHpCount; // 0x40
	private int targetLevel; // 0x44

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

	// RVA: 0x1EF839C Offset: 0x1EF439C VA: 0x1EF839C Slot: 4
	public int get_MaxHp() { }

	[CompilerGenerated]
	// RVA: 0x1EF8528 Offset: 0x1EF4528 VA: 0x1EF8528 Slot: 5
	public int get_Level() { }

	[CompilerGenerated]
	// RVA: 0x1EF8530 Offset: 0x1EF4530 VA: 0x1EF8530
	private void set_Level(int value) { }

	// RVA: 0x1EF8538 Offset: 0x1EF4538 VA: 0x1EF8538 Slot: 6
	public int get_NecessaryHit() { }

	// RVA: 0x1EF8698 Offset: 0x1EF4698 VA: 0x1EF8698 Slot: 7
	public int get_Def() { }

	// RVA: 0x1EF881C Offset: 0x1EF481C VA: 0x1EF881C Slot: 8
	public int get_MagicDef() { }

	// RVA: 0x1EF89A0 Offset: 0x1EF49A0 VA: 0x1EF89A0 Slot: 9
	public int get_CutAttack() { }

	// RVA: 0x1EF89DC Offset: 0x1EF49DC VA: 0x1EF89DC Slot: 10
	public int get_CutMagicAttack() { }

	// RVA: 0x1EF8A18 Offset: 0x1EF4A18 VA: 0x1EF8A18 Slot: 11
	public int get_GuardProbability() { }

	// RVA: 0x1EF8B20 Offset: 0x1EF4B20 VA: 0x1EF8B20 Slot: 12
	public int get_AvoidProbability() { }

	// RVA: 0x1EF8BD4 Offset: 0x1EF4BD4 VA: 0x1EF8BD4 Slot: 13
	public ElementType get_Element() { }

	// RVA: 0x1EF8BF0 Offset: 0x1EF4BF0 VA: 0x1EF8BF0 Slot: 14
	public int get_MoveSpeed() { }

	// RVA: 0x1EF8C0C Offset: 0x1EF4C0C VA: 0x1EF8C0C Slot: 15
	public byte get_Persona() { }

	// RVA: 0x1EF8C28 Offset: 0x1EF4C28 VA: 0x1EF8C28 Slot: 16
	public int get_PersonaValue() { }

	// RVA: 0x1EF8C44 Offset: 0x1EF4C44 VA: 0x1EF8C44 Slot: 17
	public float get_DamagePercent() { }

	// RVA: 0x1EF8CF8 Offset: 0x1EF4CF8 VA: 0x1EF8CF8 Slot: 18
	public float get_NecessaryFleePercent() { }

	// RVA: 0x1EF8D58 Offset: 0x1EF4D58 VA: 0x1EF8D58 Slot: 19
	public float get_StablePercent() { }

	// RVA: 0x1EF8D8C Offset: 0x1EF4D8C VA: 0x1EF8D8C Slot: 20
	public int get_ExpDefNormal() { }

	// RVA: 0x1EF8DA4 Offset: 0x1EF4DA4 VA: 0x1EF8DA4 Slot: 21
	public int get_ExpDefSkill() { }

	// RVA: 0x1EF8DBC Offset: 0x1EF4DBC VA: 0x1EF8DBC Slot: 22
	public int get_ExpDefMagic() { }

	// RVA: 0x1EF8DD4 Offset: 0x1EF4DD4 VA: 0x1EF8DD4 Slot: 23
	public MobPropertyManager get_Property() { }

	// RVA: 0x1EF8204 Offset: 0x1EF4204 VA: 0x1EF8204
	public void .ctor(MobStatusMaster statusMaster, AbnormalStateManager abnormalManager, MobBuffManager buffManager, int level, int startHpCount) { }

	// RVA: 0x1EF8E78 Offset: 0x1EF4E78 VA: 0x1EF8E78 Slot: 25
	public int CalcDef(PlayerStatusBase status) { }

	// RVA: 0x1EF8F8C Offset: 0x1EF4F8C VA: 0x1EF8F8C Slot: 26
	public int CalcMdef(PlayerStatusBase status) { }

	// RVA: 0x1EF90A0 Offset: 0x1EF50A0 VA: 0x1EF90A0 Slot: 24
	public void SetMobStatus(MobStatus mobStatus) { }

	// RVA: 0x1EF82E0 Offset: 0x1EF42E0 VA: 0x1EF82E0
	public void SetHpGage(int gage) { }

	// RVA: 0x1EF85E8 Offset: 0x1EF45E8 VA: 0x1EF85E8
	private bool TryGetCollectionValue(MonsterPropertyStatusCollectionType type, out int constant, out float rate) { }

	// RVA: 0x1EF8DDC Offset: 0x1EF4DDC VA: 0x1EF8DDC
	private void InitializeMobProperty() { }
}
