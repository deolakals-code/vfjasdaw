// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class AttackResponseData : UnityHashBase // TypeDefIndex: 13113
{
	// Fields
	[CompilerGenerated]
	private short <SkillId>k__BackingField; // 0x1A
	[CompilerGenerated]
	private byte <LocalId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private int <SkillIndividualFlag>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <DamageId>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <Element>k__BackingField; // 0x25
	[CompilerGenerated]
	private PlayerStatusData <PlayerStatus>k__BackingField; // 0x28
	[CompilerGenerated]
	private MobResponseData[] <MobList>k__BackingField; // 0x30
	[CompilerGenerated]
	private MobaMobResponseData[] <MobaMobList>k__BackingField; // 0x38
	[CompilerGenerated]
	private byte <AttackResultFlag>k__BackingField; // 0x40
	[CompilerGenerated]
	private short <GemCartStartDashCoolTime>k__BackingField; // 0x42
	[CompilerGenerated]
	private byte <AttackCount>k__BackingField; // 0x44
	[CompilerGenerated]
	private AbnormalData[] <AddAbnormal>k__BackingField; // 0x48
	[CompilerGenerated]
	private ActionAppendData <AppendData>k__BackingField; // 0x50

	// Properties
	public short SkillId { get; set; }
	public byte LocalId { get; set; }
	public int SkillIndividualFlag { get; set; }
	[UnityHash(Code = 50)]
	public byte DamageId { get; set; }
	[UnityHash(Code = 46, IsOptional = True)]
	public byte Element { get; set; }
	[UnityHash(Code = 7)]
	public PlayerStatusData PlayerStatus { get; set; }
	[UnityHash(Code = 21)]
	public MobResponseData[] MobList { get; set; }
	[UnityHash(Code = 99)]
	public MobaMobResponseData[] MobaMobList { get; set; }
	public byte AttackResultFlag { get; set; }
	public short GemCartStartDashCoolTime { get; set; }
	public byte AttackCount { get; set; }
	public AbnormalData[] AddAbnormal { get; set; }
	public ActionAppendData AppendData { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36A56D4 Offset: 0x36A16D4 VA: 0x36A56D4
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36A56DC Offset: 0x36A16DC VA: 0x36A56DC
	public short get_SkillId() { }

	[CompilerGenerated]
	// RVA: 0x36A56E4 Offset: 0x36A16E4 VA: 0x36A56E4
	public void set_SkillId(short value) { }

	[CompilerGenerated]
	// RVA: 0x36A56EC Offset: 0x36A16EC VA: 0x36A56EC
	public byte get_LocalId() { }

	[CompilerGenerated]
	// RVA: 0x36A56F4 Offset: 0x36A16F4 VA: 0x36A56F4
	public void set_LocalId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36A56FC Offset: 0x36A16FC VA: 0x36A56FC
	public int get_SkillIndividualFlag() { }

	[CompilerGenerated]
	// RVA: 0x36A5704 Offset: 0x36A1704 VA: 0x36A5704
	public void set_SkillIndividualFlag(int value) { }

	[CompilerGenerated]
	// RVA: 0x36A570C Offset: 0x36A170C VA: 0x36A570C
	public byte get_DamageId() { }

	[CompilerGenerated]
	// RVA: 0x36A5714 Offset: 0x36A1714 VA: 0x36A5714
	public void set_DamageId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36A571C Offset: 0x36A171C VA: 0x36A571C
	public byte get_Element() { }

	[CompilerGenerated]
	// RVA: 0x36A5724 Offset: 0x36A1724 VA: 0x36A5724
	public void set_Element(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36A572C Offset: 0x36A172C VA: 0x36A572C
	public PlayerStatusData get_PlayerStatus() { }

	[CompilerGenerated]
	// RVA: 0x36A5734 Offset: 0x36A1734 VA: 0x36A5734
	public void set_PlayerStatus(PlayerStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x36A573C Offset: 0x36A173C VA: 0x36A573C
	public MobResponseData[] get_MobList() { }

	[CompilerGenerated]
	// RVA: 0x36A5744 Offset: 0x36A1744 VA: 0x36A5744
	public void set_MobList(MobResponseData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36A574C Offset: 0x36A174C VA: 0x36A574C
	public MobaMobResponseData[] get_MobaMobList() { }

	[CompilerGenerated]
	// RVA: 0x36A5754 Offset: 0x36A1754 VA: 0x36A5754
	public void set_MobaMobList(MobaMobResponseData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36A575C Offset: 0x36A175C VA: 0x36A575C
	public byte get_AttackResultFlag() { }

	[CompilerGenerated]
	// RVA: 0x36A5764 Offset: 0x36A1764 VA: 0x36A5764
	public void set_AttackResultFlag(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36A576C Offset: 0x36A176C VA: 0x36A576C
	public short get_GemCartStartDashCoolTime() { }

	[CompilerGenerated]
	// RVA: 0x36A5774 Offset: 0x36A1774 VA: 0x36A5774
	public void set_GemCartStartDashCoolTime(short value) { }

	[CompilerGenerated]
	// RVA: 0x36A577C Offset: 0x36A177C VA: 0x36A577C
	public byte get_AttackCount() { }

	[CompilerGenerated]
	// RVA: 0x36A5784 Offset: 0x36A1784 VA: 0x36A5784
	public void set_AttackCount(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36A578C Offset: 0x36A178C VA: 0x36A578C
	public AbnormalData[] get_AddAbnormal() { }

	[CompilerGenerated]
	// RVA: 0x36A5794 Offset: 0x36A1794 VA: 0x36A5794
	public void set_AddAbnormal(AbnormalData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36A579C Offset: 0x36A179C VA: 0x36A579C
	public ActionAppendData get_AppendData() { }

	[CompilerGenerated]
	// RVA: 0x36A57A4 Offset: 0x36A17A4 VA: 0x36A57A4
	public void set_AppendData(ActionAppendData value) { }

	// RVA: 0x36A57AC Offset: 0x36A17AC VA: 0x36A57AC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36A57B4 Offset: 0x36A17B4 VA: 0x36A57B4 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36A60F8 Offset: 0x36A20F8 VA: 0x36A60F8 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
