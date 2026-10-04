// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main
public class ChatMacroResponse : PacketBase // TypeDefIndex: 11896
{
	// Fields
	[CompilerGenerated]
	private byte <ChannelType>k__BackingField; // 0x20
	[CompilerGenerated]
	private ChatMacroResultData <MacroResultData>k__BackingField; // 0x28

	// Properties
	public byte ChannelType { get; set; }
	public ChatMacroResultData MacroResultData { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x37606AC Offset: 0x375C6AC VA: 0x37606AC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x37606B4 Offset: 0x375C6B4 VA: 0x37606B4
	public byte get_ChannelType() { }

	[CompilerGenerated]
	// RVA: 0x37606BC Offset: 0x375C6BC VA: 0x37606BC
	public void set_ChannelType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x37606C4 Offset: 0x375C6C4 VA: 0x37606C4
	public ChatMacroResultData get_MacroResultData() { }

	[CompilerGenerated]
	// RVA: 0x37606CC Offset: 0x375C6CC VA: 0x37606CC
	public void set_MacroResultData(ChatMacroResultData value) { }

	// RVA: 0x37606D4 Offset: 0x375C6D4 VA: 0x37606D4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37606DC Offset: 0x375C6DC VA: 0x37606DC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x376089C Offset: 0x375C89C VA: 0x376089C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
