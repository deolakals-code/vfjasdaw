// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Communication
public class ChatData : BinaryBase // TypeDefIndex: 12981
{
	// Fields
	[CompilerGenerated]
	private DateTime <TimeStamp>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <ChannelType>k__BackingField; // 0x2C
	[CompilerGenerated]
	private int <FieldId>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte <Region>k__BackingField; // 0x34
	[CompilerGenerated]
	private string <UserName>k__BackingField; // 0x38
	[CompilerGenerated]
	private string <Message>k__BackingField; // 0x40
	[CompilerGenerated]
	private int <ChannelUniqueId>k__BackingField; // 0x48
	[CompilerGenerated]
	private ChatMacroResultData <MacroResultData>k__BackingField; // 0x50

	// Properties
	public DateTime TimeStamp { get; set; }
	public int ArchetypeId { get; set; }
	public byte ChannelType { get; set; }
	public int FieldId { get; set; }
	public byte Region { get; set; }
	public string UserName { get; set; }
	public string Message { get; set; }
	public int ChannelUniqueId { get; set; }
	public ChatMacroResultData MacroResultData { get; set; }

	// Methods

	// RVA: 0x3686E8C Offset: 0x3682E8C VA: 0x3686E8C
	public void .ctor() { }

	// RVA: 0x3686E94 Offset: 0x3682E94 VA: 0x3686E94
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x3686E9C Offset: 0x3682E9C VA: 0x3686E9C
	public DateTime get_TimeStamp() { }

	[CompilerGenerated]
	// RVA: 0x3686EA4 Offset: 0x3682EA4 VA: 0x3686EA4
	public void set_TimeStamp(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x3686EAC Offset: 0x3682EAC VA: 0x3686EAC
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x3686EB4 Offset: 0x3682EB4 VA: 0x3686EB4
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3686EBC Offset: 0x3682EBC VA: 0x3686EBC
	public byte get_ChannelType() { }

	[CompilerGenerated]
	// RVA: 0x3686EC4 Offset: 0x3682EC4 VA: 0x3686EC4
	public void set_ChannelType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3686ECC Offset: 0x3682ECC VA: 0x3686ECC
	public int get_FieldId() { }

	[CompilerGenerated]
	// RVA: 0x3686ED4 Offset: 0x3682ED4 VA: 0x3686ED4
	public void set_FieldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3686EDC Offset: 0x3682EDC VA: 0x3686EDC
	public byte get_Region() { }

	[CompilerGenerated]
	// RVA: 0x3686EE4 Offset: 0x3682EE4 VA: 0x3686EE4
	public void set_Region(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3686EEC Offset: 0x3682EEC VA: 0x3686EEC
	public string get_UserName() { }

	[CompilerGenerated]
	// RVA: 0x3686EF4 Offset: 0x3682EF4 VA: 0x3686EF4
	public void set_UserName(string value) { }

	[CompilerGenerated]
	// RVA: 0x3686EFC Offset: 0x3682EFC VA: 0x3686EFC
	public string get_Message() { }

	[CompilerGenerated]
	// RVA: 0x3686F04 Offset: 0x3682F04 VA: 0x3686F04
	public void set_Message(string value) { }

	[CompilerGenerated]
	// RVA: 0x3686F0C Offset: 0x3682F0C VA: 0x3686F0C
	public int get_ChannelUniqueId() { }

	[CompilerGenerated]
	// RVA: 0x3686F14 Offset: 0x3682F14 VA: 0x3686F14
	public void set_ChannelUniqueId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3686F1C Offset: 0x3682F1C VA: 0x3686F1C
	public ChatMacroResultData get_MacroResultData() { }

	[CompilerGenerated]
	// RVA: 0x3686F24 Offset: 0x3682F24 VA: 0x3686F24
	public void set_MacroResultData(ChatMacroResultData value) { }

	// RVA: 0x3686F2C Offset: 0x3682F2C VA: 0x3686F2C Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x368713C Offset: 0x368313C VA: 0x368713C Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
