// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events
public class ChatMessageEvent : PacketBase // TypeDefIndex: 12622
{
	// Fields
	[CompilerGenerated]
	private ChatData <Chat>k__BackingField; // 0x20
	[CompilerGenerated]
	private DateTime <PrevTimeStamp>k__BackingField; // 0x28

	// Properties
	public ChatData Chat { get; set; }
	public DateTime PrevTimeStamp { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3633320 Offset: 0x362F320 VA: 0x3633320
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3633328 Offset: 0x362F328 VA: 0x3633328
	public ChatData get_Chat() { }

	[CompilerGenerated]
	// RVA: 0x3633330 Offset: 0x362F330 VA: 0x3633330
	public void set_Chat(ChatData value) { }

	[CompilerGenerated]
	// RVA: 0x3633338 Offset: 0x362F338 VA: 0x3633338
	public DateTime get_PrevTimeStamp() { }

	[CompilerGenerated]
	// RVA: 0x3633340 Offset: 0x362F340 VA: 0x3633340
	public void set_PrevTimeStamp(DateTime value) { }

	// RVA: 0x3633348 Offset: 0x362F348 VA: 0x3633348 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3633350 Offset: 0x362F350 VA: 0x3633350 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x363357C Offset: 0x362F57C VA: 0x363357C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
