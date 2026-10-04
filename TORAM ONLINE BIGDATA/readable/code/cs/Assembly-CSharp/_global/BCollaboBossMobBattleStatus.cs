// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BCollaboBossMobBattleStatus : IMobStatusCalculator, IBossPartsStatus // TypeDefIndex: 844
{
	// Fields
	[CompilerGenerated]
	private int <Level>k__BackingField; // 0x10
	private readonly MobStatusMaster statusMaster; // 0x18
	private readonly AbnormalStateManager abnormalState; // 0x20
	private readonly MobBuffManager buffManager; // 0x28
	private MobStatus mobStatus; // 0x30
	private Dictionary<int, MobPartsStatus> partsStatus; // 0x38
	private int hpGage; // 0x40

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
	public Dictionary<int, MobPartsStatus> PartsStatus { get; }

	// Methods

	// RVA: 0x1EC7B5C Offset: 0x1EC3B5C VA: 0x1EC7B5C
	public void .ctor(MobStatusMaster master, AbnormalStateManager abnormal, MobBuffManager buff, int level) { }

	// RVA: 0x1EC8600 Offset: 0x1EC4600 VA: 0x1EC8600 Slot: 4
	public int get_MaxHp() { }

	[CompilerGenerated]
	// RVA: 0x1EC8734 Offset: 0x1EC4734 VA: 0x1EC8734 Slot: 5
	public int get_Level() { }

	[CompilerGenerated]
	// RVA: 0x1EC873C Offset: 0x1EC473C VA: 0x1EC873C
	private void set_Level(int value) { }

	// RVA: 0x1EC8744 Offset: 0x1EC4744 VA: 0x1EC8744 Slot: 6
	public int get_NecessaryHit() { }

	// RVA: 0x1EC874C Offset: 0x1EC474C VA: 0x1EC874C Slot: 7
	public int get_Def() { }

	// RVA: 0x1EC88C0 Offset: 0x1EC48C0 VA: 0x1EC88C0 Slot: 8
	public int get_MagicDef() { }

	// RVA: 0x1EC8990 Offset: 0x1EC4990 VA: 0x1EC8990 Slot: 9
	public int get_CutAttack() { }

	// RVA: 0x1EC89AC Offset: 0x1EC49AC VA: 0x1EC89AC Slot: 10
	public int get_CutMagicAttack() { }

	// RVA: 0x1EC89C8 Offset: 0x1EC49C8 VA: 0x1EC89C8 Slot: 11
	public int get_GuardProbability() { }

	// RVA: 0x1EC8A58 Offset: 0x1EC4A58 VA: 0x1EC8A58 Slot: 12
	public int get_AvoidProbability() { }

	// RVA: 0x1EC8AE8 Offset: 0x1EC4AE8 VA: 0x1EC8AE8 Slot: 13
	public ElementType get_Element() { }

	// RVA: 0x1EC5B30 Offset: 0x1EC1B30 VA: 0x1EC5B30 Slot: 14
	public int get_MoveSpeed() { }

	// RVA: 0x1EC8B04 Offset: 0x1EC4B04 VA: 0x1EC8B04 Slot: 15
	public byte get_Persona() { }

	// RVA: 0x1EC8B20 Offset: 0x1EC4B20 VA: 0x1EC8B20 Slot: 16
	public int get_PersonaValue() { }

	// RVA: 0x1EC8B3C Offset: 0x1EC4B3C VA: 0x1EC8B3C Slot: 17
	public float get_DamagePercent() { }

	// RVA: 0x1EC8BD8 Offset: 0x1EC4BD8 VA: 0x1EC8BD8 Slot: 18
	public float get_NecessaryFleePercent() { }

	// RVA: 0x1EC8C4C Offset: 0x1EC4C4C VA: 0x1EC8C4C Slot: 19
	public float get_StablePercent() { }

	// RVA: 0x1EC8C80 Offset: 0x1EC4C80 VA: 0x1EC8C80 Slot: 20
	public int get_ExpDefNormal() { }

	// RVA: 0x1EC8C98 Offset: 0x1EC4C98 VA: 0x1EC8C98 Slot: 21
	public int get_ExpDefSkill() { }

	// RVA: 0x1EC8CB0 Offset: 0x1EC4CB0 VA: 0x1EC8CB0 Slot: 22
	public int get_ExpDefMagic() { }

	// RVA: 0x1EC8CC8 Offset: 0x1EC4CC8 VA: 0x1EC8CC8 Slot: 23
	public MobPropertyManager get_Property() { }

	// RVA: 0x1EC8CE4 Offset: 0x1EC4CE4 VA: 0x1EC8CE4 Slot: 27
	public Dictionary<int, MobPartsStatus> get_PartsStatus() { }

	// RVA: 0x1EC8CEC Offset: 0x1EC4CEC VA: 0x1EC8CEC
	public void SetHpGage(int gage) { }

	// RVA: 0x1EC8CF4 Offset: 0x1EC4CF4 VA: 0x1EC8CF4 Slot: 25
	public int CalcDef(PlayerStatusBase status) { }

	// RVA: 0x1EC8E08 Offset: 0x1EC4E08 VA: 0x1EC8E08 Slot: 26
	public int CalcMdef(PlayerStatusBase status) { }

	// RVA: 0x1EC8F1C Offset: 0x1EC4F1C VA: 0x1EC8F1C Slot: 24
	public void SetMobStatus(MobStatus mobStatus) { }

	// RVA: 0x1EC5E30 Offset: 0x1EC1E30 VA: 0x1EC5E30 Slot: 29
	public void ClearParts() { }

	// RVA: 0x1EC6018 Offset: 0x1EC2018 VA: 0x1EC6018 Slot: 28
	public void SetPartsMaster(int id, MobPartsStatus parts) { }
}
