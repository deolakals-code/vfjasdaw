// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events
public class ChatEvent : PacketBase // TypeDefIndex: 12621
{
	// Fields
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ChannelType>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <FieldId>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <Region>k__BackingField; // 0x2C
	[CompilerGenerated]
	private string <UserName>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <Message>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <TargetId>k__BackingField; // 0x40
	[CompilerGenerated]
	private ChatMacroResultData <MacroResultData>k__BackingField; // 0x48

	// Properties
	public override byte Code { get; }
	[PacketParameter(Code = 74)]
	public int ArchetypeId { get; set; }
	[PacketParameter(Code = 82, IsOptional = True)]
	public byte ChannelType { get; set; }
	[PacketParameter(Code = 60, IsOptional = True)]
	public int FieldId { get; set; }
	[PacketParameter(Code = 217)]
	public byte Region { get; set; }
	[PacketParameter(Code = 66)]
	public string UserName { get; set; }
	[PacketParameter(Code = 83)]
	public string Message { get; set; }
	[PacketParameter(Code = 96, IsOptional = True)]
	public int TargetId { get; set; }
	[PacketParameter(Code = 206, IsOptional = True)]
	public ChatMacroResultData MacroResultData { get; set; }

	// Methods

	// RVA: 0x3632CA8 Offset: 0x362ECA8 VA: 0x3632CA8
	public void .ctor() { }

	// RVA: 0x3632CB0 Offset: 0x362ECB0 VA: 0x3632CB0
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x3632CB8 Offset: 0x362ECB8 VA: 0x3632CB8 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x3632CC0 Offset: 0x362ECC0 VA: 0x3632CC0
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x3632CC8 Offset: 0x362ECC8 VA: 0x3632CC8
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3632CD0 Offset: 0x362ECD0 VA: 0x3632CD0
	public byte get_ChannelType() { }

	[CompilerGenerated]
	// RVA: 0x3632CD8 Offset: 0x362ECD8 VA: 0x3632CD8
	public void set_ChannelType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3632CE0 Offset: 0x362ECE0 VA: 0x3632CE0
	public int get_FieldId() { }

	[CompilerGenerated]
	// RVA: 0x3632CE8 Offset: 0x362ECE8 VA: 0x3632CE8
	public void set_FieldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3632CF0 Offset: 0x362ECF0 VA: 0x3632CF0
	public byte get_Region() { }

	[CompilerGenerated]
	// RVA: 0x3632CF8 Offset: 0x362ECF8 VA: 0x3632CF8
	public void set_Region(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3632D00 Offset: 0x362ED00 VA: 0x3632D00
	public string get_UserName() { }

	[CompilerGenerated]
	// RVA: 0x3632D08 Offset: 0x362ED08 VA: 0x3632D08
	public void set_UserName(string value) { }

	[CompilerGenerated]
	// RVA: 0x3632D10 Offset: 0x362ED10 VA: 0x3632D10
	public string get_Message() { }

	[CompilerGenerated]
	// RVA: 0x3632D18 Offset: 0x362ED18 VA: 0x3632D18
	public void set_Message(string value) { }

	[CompilerGenerated]
	// RVA: 0x3632D20 Offset: 0x362ED20 VA: 0x3632D20
	public int get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x3632D28 Offset: 0x362ED28 VA: 0x3632D28
	public void set_TargetId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3632D30 Offset: 0x362ED30 VA: 0x3632D30
	public ChatMacroResultData get_MacroResultData() { }

	[CompilerGenerated]
	// RVA: 0x3632D38 Offset: 0x362ED38 VA: 0x3632D38
	public void set_MacroResultData(ChatMacroResultData value) { }

	// RVA: 0x3632D40 Offset: 0x362ED40 VA: 0x3632D40 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x363313C Offset: 0x362F13C VA: 0x363313C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
