// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.Quest
public class GuildQuestResetQuestResponse : OperationResponseBase // TypeDefIndex: 12426
{
	// Fields
	[CompilerGenerated]
	private GuildOrderQuestData[] <QuestList>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <QuestResetLeftTime>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 15)]
	public GuildOrderQuestData[] QuestList { get; set; }
	public int QuestResetLeftTime { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3605750 Offset: 0x3601750 VA: 0x3605750
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3605758 Offset: 0x3601758 VA: 0x3605758
	public GuildOrderQuestData[] get_QuestList() { }

	[CompilerGenerated]
	// RVA: 0x3605760 Offset: 0x3601760 VA: 0x3605760
	public void set_QuestList(GuildOrderQuestData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3605768 Offset: 0x3601768 VA: 0x3605768
	public int get_QuestResetLeftTime() { }

	[CompilerGenerated]
	// RVA: 0x3605770 Offset: 0x3601770 VA: 0x3605770
	public void set_QuestResetLeftTime(int value) { }

	// RVA: 0x3605778 Offset: 0x3601778 VA: 0x3605778 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3605780 Offset: 0x3601780 VA: 0x3605780 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3605788 Offset: 0x3601788 VA: 0x3605788 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3605860 Offset: 0x3601860 VA: 0x3605860 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
