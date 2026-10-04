// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main
public class Chat : PacketBase // TypeDefIndex: 11898
{
	// Fields
	[CompilerGenerated]
	private byte <ChannelType>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <Message>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <TargetId>k__BackingField; // 0x30
	[CompilerGenerated]
	private ChatMacroResultData <MacroResultData>k__BackingField; // 0x38

	// Properties
	public override byte Code { get; }
	[PacketParameter(Code = 82, IsOptional = True)]
	public byte ChannelType { get; set; }
	[PacketParameter(Code = 83)]
	public string Message { get; set; }
	[PacketParameter(Code = 96, IsOptional = True)]
	public int TargetId { get; set; }
	[PacketParameter(Code = 206, IsOptional = True)]
	public ChatMacroResultData MacroResultData { get; set; }

	// Methods

	// RVA: 0x3760C50 Offset: 0x375CC50 VA: 0x3760C50
	public void .ctor() { }

	// RVA: 0x3760C58 Offset: 0x375CC58 VA: 0x3760C58 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x3760C60 Offset: 0x375CC60 VA: 0x3760C60
	public byte get_ChannelType() { }

	[CompilerGenerated]
	// RVA: 0x3760C68 Offset: 0x375CC68 VA: 0x3760C68
	public void set_ChannelType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3760C70 Offset: 0x375CC70 VA: 0x3760C70
	public string get_Message() { }

	[CompilerGenerated]
	// RVA: 0x3760C78 Offset: 0x375CC78 VA: 0x3760C78
	public void set_Message(string value) { }

	[CompilerGenerated]
	// RVA: 0x3760C80 Offset: 0x375CC80 VA: 0x3760C80
	public int get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x3760C88 Offset: 0x375CC88 VA: 0x3760C88
	public void set_TargetId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3760C90 Offset: 0x375CC90 VA: 0x3760C90
	public ChatMacroResultData get_MacroResultData() { }

	[CompilerGenerated]
	// RVA: 0x3760C98 Offset: 0x375CC98 VA: 0x3760C98
	public void set_MacroResultData(ChatMacroResultData value) { }

	// RVA: 0x3760CA0 Offset: 0x375CCA0 VA: 0x3760CA0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3760F6C Offset: 0x375CF6C VA: 0x3760F6C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
