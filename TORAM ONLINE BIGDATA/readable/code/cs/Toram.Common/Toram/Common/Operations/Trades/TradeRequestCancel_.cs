// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Trades
public class TradeRequestCancel_ : OperationRequestBase // TypeDefIndex: 11699
{
	// Fields
	[CompilerGenerated]
	private int <SenderId>k__BackingField; // 0x20

	// Properties
	public int SenderId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x373523C Offset: 0x373123C VA: 0x373523C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3735244 Offset: 0x3731244 VA: 0x3735244
	public int get_SenderId() { }

	[CompilerGenerated]
	// RVA: 0x373524C Offset: 0x373124C VA: 0x373524C
	public void set_SenderId(int value) { }

	// RVA: 0x3735254 Offset: 0x3731254 VA: 0x3735254 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x373525C Offset: 0x373125C VA: 0x373525C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3735264 Offset: 0x3731264 VA: 0x3735264 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3735304 Offset: 0x3731304 VA: 0x3735304 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
