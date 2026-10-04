// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Channel
public class ReturnServerResponse : PacketBase // TypeDefIndex: 12038
{
	// Fields
	[CompilerGenerated]
	private short <ReturnCode>k__BackingField; // 0x20

	// Properties
	public short ReturnCode { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x377BAFC Offset: 0x3777AFC VA: 0x377BAFC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x377BB04 Offset: 0x3777B04 VA: 0x377BB04
	public short get_ReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x377BB0C Offset: 0x3777B0C VA: 0x377BB0C
	public void set_ReturnCode(short value) { }

	// RVA: 0x377BB14 Offset: 0x3777B14 VA: 0x377BB14 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x377BB1C Offset: 0x3777B1C VA: 0x377BB1C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x377BC3C Offset: 0x3777C3C VA: 0x377BC3C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
