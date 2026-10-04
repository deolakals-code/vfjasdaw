// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds
public class GuildUnreceivedMessageResponse : OperationResponseBase // TypeDefIndex: 12376
{
	// Fields
	[CompilerGenerated]
	private ChatData[] <GuildMessages>k__BackingField; // 0x20

	// Properties
	public ChatData[] GuildMessages { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35FD1A4 Offset: 0x35F91A4 VA: 0x35FD1A4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35FD1AC Offset: 0x35F91AC VA: 0x35FD1AC
	public ChatData[] get_GuildMessages() { }

	[CompilerGenerated]
	// RVA: 0x35FD1B4 Offset: 0x35F91B4 VA: 0x35FD1B4
	public void set_GuildMessages(ChatData[] value) { }

	// RVA: 0x35FD1BC Offset: 0x35F91BC VA: 0x35FD1BC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35FD1C4 Offset: 0x35F91C4 VA: 0x35FD1C4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35FD1CC Offset: 0x35F91CC VA: 0x35FD1CC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35FD344 Offset: 0x35F9344 VA: 0x35FD344 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
