// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.Quest
public class GuildQuestReportQuestResponse : OperationResponseBase // TypeDefIndex: 12428
{
	// Fields
	[CompilerGenerated]
	private RewardResponseDatav2 <Reward>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <GuildGold>k__BackingField; // 0x28
	[CompilerGenerated]
	private GuildVariableData[] <Data>k__BackingField; // 0x30
	[CompilerGenerated]
	private GuildOrderQuestData <NewQuestData>k__BackingField; // 0x38
	[CompilerGenerated]
	private GuildQuestData <GuildQuestData>k__BackingField; // 0x40

	// Properties
	[PacketClass(Code = 29)]
	public RewardResponseDatav2 Reward { get; set; }
	[PacketParameter(Code = 11)]
	public int GuildGold { get; set; }
	[PacketParameter(Code = 30)]
	public GuildVariableData[] Data { get; set; }
	[PacketClass(Code = 31, IsOptional = True)]
	public GuildOrderQuestData NewQuestData { get; set; }
	[PacketClass(Code = 32)]
	public GuildQuestData GuildQuestData { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3605E38 Offset: 0x3601E38 VA: 0x3605E38
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3605E40 Offset: 0x3601E40 VA: 0x3605E40
	public RewardResponseDatav2 get_Reward() { }

	[CompilerGenerated]
	// RVA: 0x3605E48 Offset: 0x3601E48 VA: 0x3605E48
	public void set_Reward(RewardResponseDatav2 value) { }

	[CompilerGenerated]
	// RVA: 0x3605E50 Offset: 0x3601E50 VA: 0x3605E50
	public int get_GuildGold() { }

	[CompilerGenerated]
	// RVA: 0x3605E58 Offset: 0x3601E58 VA: 0x3605E58
	public void set_GuildGold(int value) { }

	[CompilerGenerated]
	// RVA: 0x3605E60 Offset: 0x3601E60 VA: 0x3605E60
	public GuildVariableData[] get_Data() { }

	[CompilerGenerated]
	// RVA: 0x3605E68 Offset: 0x3601E68 VA: 0x3605E68
	public void set_Data(GuildVariableData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3605E70 Offset: 0x3601E70 VA: 0x3605E70
	public GuildOrderQuestData get_NewQuestData() { }

	[CompilerGenerated]
	// RVA: 0x3605E78 Offset: 0x3601E78 VA: 0x3605E78
	public void set_NewQuestData(GuildOrderQuestData value) { }

	[CompilerGenerated]
	// RVA: 0x3605E80 Offset: 0x3601E80 VA: 0x3605E80
	public GuildQuestData get_GuildQuestData() { }

	[CompilerGenerated]
	// RVA: 0x3605E88 Offset: 0x3601E88 VA: 0x3605E88
	public void set_GuildQuestData(GuildQuestData value) { }

	// RVA: 0x3605E90 Offset: 0x3601E90 VA: 0x3605E90 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3605E98 Offset: 0x3601E98 VA: 0x3605E98 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3605EA0 Offset: 0x3601EA0 VA: 0x3605EA0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3605FF8 Offset: 0x3601FF8 VA: 0x3605FF8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
