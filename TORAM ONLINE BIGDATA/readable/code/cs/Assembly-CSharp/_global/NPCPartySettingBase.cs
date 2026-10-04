// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class NPCPartySettingBase // TypeDefIndex: 500
{
	// Fields
	[CompilerGenerated]
	private string <NpcNameKey>k__BackingField; // 0x10
	[CompilerGenerated]
	private int <NpcId>k__BackingField; // 0x18
	[CompilerGenerated]
	private bool <IsUsedFirstSkill>k__BackingField; // 0x1C
	[CompilerGenerated]
	private bool <IsDead>k__BackingField; // 0x1D
	[CompilerGenerated]
	private short <RespawnTime>k__BackingField; // 0x1E
	public Vector3 DefaultPosition; // 0x20
	public Quaternion DefaultRotation; // 0x2C
	[SerializeField]
	public NPCPartySettingBase.CustomAnimationSetting CustomAnimation; // 0x40
	public IPrimaryStatus NpcStatus; // 0x48
	public GameStatusData GameStatus; // 0x50
	public int AddMaxHp; // 0x58
	public int AddMaxMp; // 0x5C
	public NPCPartySettingBase.Equip EquipType; // 0x60
	public List<NPCPartySettingBase.SkillPair> SkillList; // 0x68
	public SkillId FirstSkill; // 0x70
	public List<NPCPartySettingBase.Pattern> TacticalPattern; // 0x78
	public List<NPCPartySettingBase.Pattern> LoopPattern; // 0x80
	[CompilerGenerated]
	private int <RetreatFlag>k__BackingField; // 0x88
	[CompilerGenerated]
	private int <SpecialFlag>k__BackingField; // 0x8C

	// Properties
	public string NpcNameKey { get; set; }
	public int NpcId { get; set; }
	public bool IsUsedFirstSkill { get; set; }
	public bool IsDead { get; set; }
	public short RespawnTime { get; set; }
	public int RetreatFlag { get; set; }
	public int SpecialFlag { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x182A96C Offset: 0x182696C VA: 0x182A96C
	protected void set_NpcNameKey(string value) { }

	[CompilerGenerated]
	// RVA: 0x182A974 Offset: 0x1826974 VA: 0x182A974
	public string get_NpcNameKey() { }

	[CompilerGenerated]
	// RVA: 0x182A97C Offset: 0x182697C VA: 0x182A97C
	protected void set_NpcId(int value) { }

	[CompilerGenerated]
	// RVA: 0x182A984 Offset: 0x1826984 VA: 0x182A984
	public int get_NpcId() { }

	[CompilerGenerated]
	// RVA: 0x182A98C Offset: 0x182698C VA: 0x182A98C
	protected void set_IsUsedFirstSkill(bool value) { }

	[CompilerGenerated]
	// RVA: 0x182A998 Offset: 0x1826998 VA: 0x182A998
	public bool get_IsUsedFirstSkill() { }

	[CompilerGenerated]
	// RVA: 0x182A9A0 Offset: 0x18269A0 VA: 0x182A9A0
	protected void set_IsDead(bool value) { }

	[CompilerGenerated]
	// RVA: 0x182A9AC Offset: 0x18269AC VA: 0x182A9AC
	public bool get_IsDead() { }

	[CompilerGenerated]
	// RVA: 0x182A9B4 Offset: 0x18269B4 VA: 0x182A9B4
	protected void set_RespawnTime(short value) { }

	[CompilerGenerated]
	// RVA: 0x182A9BC Offset: 0x18269BC VA: 0x182A9BC
	public short get_RespawnTime() { }

	[CompilerGenerated]
	// RVA: 0x182A9C4 Offset: 0x18269C4 VA: 0x182A9C4
	protected void set_RetreatFlag(int value) { }

	[CompilerGenerated]
	// RVA: 0x182A9CC Offset: 0x18269CC VA: 0x182A9CC
	public int get_RetreatFlag() { }

	[CompilerGenerated]
	// RVA: 0x182A9D4 Offset: 0x18269D4 VA: 0x182A9D4
	protected void set_SpecialFlag(int value) { }

	[CompilerGenerated]
	// RVA: 0x182A9DC Offset: 0x18269DC VA: 0x182A9DC
	public int get_SpecialFlag() { }

	// RVA: 0x1828F7C Offset: 0x1824F7C VA: 0x1828F7C
	protected void SetCustomAnimation(NpcMotionData[] motionList) { }

	// RVA: 0x1828FF0 Offset: 0x1824FF0 VA: 0x1828FF0
	protected void SetSkillList(NpcSkillData[] skillData) { }

	// RVA: 0x1829164 Offset: 0x1825164 VA: 0x1829164
	protected void SetFirstSkill(NpcPatternData[] patternData) { }

	// RVA: 0x1828F5C Offset: 0x1824F5C VA: 0x1828F5C
	protected void SetFlag(NpcSettingData setting) { }

	// RVA: 0x1828854 Offset: 0x1824854 VA: 0x1828854
	protected void .ctor() { }
}
