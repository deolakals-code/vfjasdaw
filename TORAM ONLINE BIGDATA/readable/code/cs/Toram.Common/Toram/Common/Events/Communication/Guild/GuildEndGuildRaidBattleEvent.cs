// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Guild
public class GuildEndGuildRaidBattleEvent : EventSubBase // TypeDefIndex: 12911
{
	// Fields
	[CompilerGenerated]
	private int <GuildId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <CurrentHpCount>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <Damage>k__BackingField; // 0x28
	[CompilerGenerated]
	private AbnormalHitData[] <AbnormalHitList>k__BackingField; // 0x30
	[CompilerGenerated]
	private GuildItemData <Item>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <Num>k__BackingField; // 0x40
	[CompilerGenerated]
	private bool <IsSubdue>k__BackingField; // 0x44
	[CompilerGenerated]
	private byte <OpenPropertyIndex>k__BackingField; // 0x45
	[CompilerGenerated]
	private GuildRaidLogData <Log>k__BackingField; // 0x48
	[CompilerGenerated]
	private BossResultData <Result>k__BackingField; // 0x50
	[CompilerGenerated]
	private int <Stamina>k__BackingField; // 0x58
	[CompilerGenerated]
	private bool <IsEscape>k__BackingField; // 0x5C
	[CompilerGenerated]
	private bool <IsPractice>k__BackingField; // 0x5D
	[CompilerGenerated]
	private bool <IsAllianceReward>k__BackingField; // 0x5E

	// Properties
	[PacketParameter(Code = 0, IsOptional = True)]
	public int GuildId { get; set; }
	[PacketParameter(Code = 29)]
	public byte CurrentHpCount { get; set; }
	[PacketParameter(Code = 30)]
	public int Damage { get; set; }
	[PacketParameter(Code = 15, IsOptional = True)]
	public AbnormalHitData[] AbnormalHitList { get; set; }
	[PacketClass(Code = 31, IsOptional = True)]
	public GuildItemData Item { get; set; }
	[PacketParameter(Code = 32, IsOptional = True)]
	public int Num { get; set; }
	[PacketParameter(Code = 20)]
	public bool IsSubdue { get; set; }
	[PacketParameter(Code = 10)]
	public byte OpenPropertyIndex { get; set; }
	[PacketParameter(Code = 33)]
	public GuildRaidLogData Log { get; set; }
	[PacketParameter(Code = 2)]
	public BossResultData Result { get; set; }
	[PacketParameter(Code = 11)]
	public int Stamina { get; set; }
	[PacketParameter(Code = 12)]
	public bool IsEscape { get; set; }
	[PacketParameter(Code = 13)]
	public bool IsPractice { get; set; }
	[PacketParameter(Code = 14, IsOptional = True)]
	public bool IsAllianceReward { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3675A0C Offset: 0x3671A0C VA: 0x3675A0C
	public void .ctor() { }

	// RVA: 0x3675A2C Offset: 0x3671A2C VA: 0x3675A2C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3675A34 Offset: 0x3671A34 VA: 0x3675A34
	public int get_GuildId() { }

	[CompilerGenerated]
	// RVA: 0x3675A3C Offset: 0x3671A3C VA: 0x3675A3C
	public void set_GuildId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3675A44 Offset: 0x3671A44 VA: 0x3675A44
	public byte get_CurrentHpCount() { }

	[CompilerGenerated]
	// RVA: 0x3675A4C Offset: 0x3671A4C VA: 0x3675A4C
	public void set_CurrentHpCount(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3675A54 Offset: 0x3671A54 VA: 0x3675A54
	public int get_Damage() { }

	[CompilerGenerated]
	// RVA: 0x3675A5C Offset: 0x3671A5C VA: 0x3675A5C
	public void set_Damage(int value) { }

	[CompilerGenerated]
	// RVA: 0x3675A64 Offset: 0x3671A64 VA: 0x3675A64
	public AbnormalHitData[] get_AbnormalHitList() { }

	[CompilerGenerated]
	// RVA: 0x3675A6C Offset: 0x3671A6C VA: 0x3675A6C
	public void set_AbnormalHitList(AbnormalHitData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3675A74 Offset: 0x3671A74 VA: 0x3675A74
	public GuildItemData get_Item() { }

	[CompilerGenerated]
	// RVA: 0x3675A7C Offset: 0x3671A7C VA: 0x3675A7C
	public void set_Item(GuildItemData value) { }

	[CompilerGenerated]
	// RVA: 0x3675A84 Offset: 0x3671A84 VA: 0x3675A84
	public int get_Num() { }

	[CompilerGenerated]
	// RVA: 0x3675A8C Offset: 0x3671A8C VA: 0x3675A8C
	public void set_Num(int value) { }

	[CompilerGenerated]
	// RVA: 0x3675A94 Offset: 0x3671A94 VA: 0x3675A94
	public bool get_IsSubdue() { }

	[CompilerGenerated]
	// RVA: 0x3675A9C Offset: 0x3671A9C VA: 0x3675A9C
	public void set_IsSubdue(bool value) { }

	[CompilerGenerated]
	// RVA: 0x3675AA8 Offset: 0x3671AA8 VA: 0x3675AA8
	public byte get_OpenPropertyIndex() { }

	[CompilerGenerated]
	// RVA: 0x3675AB0 Offset: 0x3671AB0 VA: 0x3675AB0
	public void set_OpenPropertyIndex(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3675AB8 Offset: 0x3671AB8 VA: 0x3675AB8
	public GuildRaidLogData get_Log() { }

	[CompilerGenerated]
	// RVA: 0x3675AC0 Offset: 0x3671AC0 VA: 0x3675AC0
	public void set_Log(GuildRaidLogData value) { }

	[CompilerGenerated]
	// RVA: 0x3675AC8 Offset: 0x3671AC8 VA: 0x3675AC8
	public BossResultData get_Result() { }

	[CompilerGenerated]
	// RVA: 0x3675AD0 Offset: 0x3671AD0 VA: 0x3675AD0
	public void set_Result(BossResultData value) { }

	[CompilerGenerated]
	// RVA: 0x3675AD8 Offset: 0x3671AD8 VA: 0x3675AD8
	public int get_Stamina() { }

	[CompilerGenerated]
	// RVA: 0x3675AE0 Offset: 0x3671AE0 VA: 0x3675AE0
	public void set_Stamina(int value) { }

	[CompilerGenerated]
	// RVA: 0x3675AE8 Offset: 0x3671AE8 VA: 0x3675AE8
	public bool get_IsEscape() { }

	[CompilerGenerated]
	// RVA: 0x3675AF0 Offset: 0x3671AF0 VA: 0x3675AF0
	public void set_IsEscape(bool value) { }

	[CompilerGenerated]
	// RVA: 0x3675AFC Offset: 0x3671AFC VA: 0x3675AFC
	public bool get_IsPractice() { }

	[CompilerGenerated]
	// RVA: 0x3675B04 Offset: 0x3671B04 VA: 0x3675B04
	public void set_IsPractice(bool value) { }

	[CompilerGenerated]
	// RVA: 0x3675B10 Offset: 0x3671B10 VA: 0x3675B10
	public bool get_IsAllianceReward() { }

	[CompilerGenerated]
	// RVA: 0x3675B18 Offset: 0x3671B18 VA: 0x3675B18
	public void set_IsAllianceReward(bool value) { }

	// RVA: 0x3675B24 Offset: 0x3671B24 VA: 0x3675B24 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3675B2C Offset: 0x3671B2C VA: 0x3675B2C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3675B34 Offset: 0x3671B34 VA: 0x3675B34 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3675E4C Offset: 0x3671E4C VA: 0x3675E4C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
