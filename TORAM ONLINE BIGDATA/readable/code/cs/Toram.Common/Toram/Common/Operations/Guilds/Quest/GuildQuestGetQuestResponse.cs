// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.Quest
public class GuildQuestGetQuestResponse : OperationResponseBase // TypeDefIndex: 12431
{
	// Fields
	[CompilerGenerated]
	private GuildOrderQuestData[] <QuestList>k__BackingField; // 0x20
	[CompilerGenerated]
	private GuildQuestData <GuildQuestData>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <QuestResetLeftTime>k__BackingField; // 0x30

	// Properties
	[PacketClass(Code = 15)]
	public GuildOrderQuestData[] QuestList { get; set; }
	[PacketClass(Code = 2)]
	public GuildQuestData GuildQuestData { get; set; }
	public int QuestResetLeftTime { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3606714 Offset: 0x3602714 VA: 0x3606714
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x360671C Offset: 0x360271C VA: 0x360671C
	public GuildOrderQuestData[] get_QuestList() { }

	[CompilerGenerated]
	// RVA: 0x3606724 Offset: 0x3602724 VA: 0x3606724
	public void set_QuestList(GuildOrderQuestData[] value) { }

	[CompilerGenerated]
	// RVA: 0x360672C Offset: 0x360272C VA: 0x360672C
	public GuildQuestData get_GuildQuestData() { }

	[CompilerGenerated]
	// RVA: 0x3606734 Offset: 0x3602734 VA: 0x3606734
	public void set_GuildQuestData(GuildQuestData value) { }

	[CompilerGenerated]
	// RVA: 0x360673C Offset: 0x360273C VA: 0x360673C
	public int get_QuestResetLeftTime() { }

	[CompilerGenerated]
	// RVA: 0x3606744 Offset: 0x3602744 VA: 0x3606744
	public void set_QuestResetLeftTime(int value) { }

	// RVA: 0x360674C Offset: 0x360274C VA: 0x360674C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3606754 Offset: 0x3602754 VA: 0x3606754 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x360675C Offset: 0x360275C VA: 0x360675C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x360685C Offset: 0x360285C VA: 0x360685C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
