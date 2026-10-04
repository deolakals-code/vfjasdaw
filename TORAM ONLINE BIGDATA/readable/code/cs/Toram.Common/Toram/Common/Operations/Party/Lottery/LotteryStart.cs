// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Party.Lottery
public class LotteryStart : OperationRequestBase // TypeDefIndex: 11517
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

	// RVA: 0x3715894 Offset: 0x3711894 VA: 0x3715894
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x371589C Offset: 0x371189C VA: 0x371589C
	public string get_Message() { }

	[CompilerGenerated]
	// RVA: 0x37158A4 Offset: 0x37118A4 VA: 0x37158A4
	public void set_Message(string value) { }

	// RVA: 0x37158AC Offset: 0x37118AC VA: 0x37158AC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37158B4 Offset: 0x37118B4 VA: 0x37158B4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37158BC Offset: 0x37118BC VA: 0x37158BC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37159DC Offset: 0x37119DC VA: 0x37159DC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
