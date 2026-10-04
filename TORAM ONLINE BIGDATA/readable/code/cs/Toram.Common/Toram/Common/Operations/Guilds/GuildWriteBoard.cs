// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds
public class GuildWriteBoard : PacketBase // TypeDefIndex: 12408
{
	// Fields
	[CompilerGenerated]
	private string <Message>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <BoardType>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 83, IsOptional = True)]
	public string Message { get; set; }
	[PacketParameter(Code = 245, IsOptional = True)]
	public byte BoardType { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3602CDC Offset: 0x35FECDC VA: 0x3602CDC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3602CE4 Offset: 0x35FECE4 VA: 0x3602CE4
	public string get_Message() { }

	[CompilerGenerated]
	// RVA: 0x3602CEC Offset: 0x35FECEC VA: 0x3602CEC
	public void set_Message(string value) { }

	[CompilerGenerated]
	// RVA: 0x3602CF4 Offset: 0x35FECF4 VA: 0x3602CF4
	public byte get_BoardType() { }

	[CompilerGenerated]
	// RVA: 0x3602CFC Offset: 0x35FECFC VA: 0x3602CFC
	public void set_BoardType(byte value) { }

	// RVA: 0x3602D04 Offset: 0x35FED04 VA: 0x3602D04
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3602D08 Offset: 0x35FED08 VA: 0x3602D08
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3602D0C Offset: 0x35FED0C VA: 0x3602D0C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3602D14 Offset: 0x35FED14 VA: 0x3602D14 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3602ED8 Offset: 0x35FEED8 VA: 0x3602ED8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
