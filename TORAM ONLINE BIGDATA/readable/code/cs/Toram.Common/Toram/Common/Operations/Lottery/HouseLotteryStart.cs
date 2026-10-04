// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Lottery
public class HouseLotteryStart : OperationRequestBase // TypeDefIndex: 11541
{
	// Fields
	[CompilerGenerated]
	private string <Message>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 83)]
	public string Message { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x37173F4 Offset: 0x37133F4 VA: 0x37173F4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x37173FC Offset: 0x37133FC VA: 0x37173FC
	public string get_Message() { }

	[CompilerGenerated]
	// RVA: 0x3717404 Offset: 0x3713404 VA: 0x3717404
	public void set_Message(string value) { }

	// RVA: 0x371740C Offset: 0x371340C VA: 0x371740C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3717414 Offset: 0x3713414 VA: 0x3717414 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x371741C Offset: 0x371341C VA: 0x371741C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x371753C Offset: 0x371353C VA: 0x371753C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
