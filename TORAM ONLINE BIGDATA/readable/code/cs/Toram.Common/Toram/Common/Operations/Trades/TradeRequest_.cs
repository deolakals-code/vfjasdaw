// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Trades
public class TradeRequest_ : OperationRequestBase // TypeDefIndex: 11701
{
	// Fields
	[CompilerGenerated]
	private int <TargetId>k__BackingField; // 0x20

	// Properties
	public int TargetId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3735688 Offset: 0x3731688 VA: 0x3735688
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3735690 Offset: 0x3731690 VA: 0x3735690
	public int get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x3735698 Offset: 0x3731698 VA: 0x3735698
	public void set_TargetId(int value) { }

	// RVA: 0x37356A0 Offset: 0x37316A0 VA: 0x37356A0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37356A8 Offset: 0x37316A8 VA: 0x37356A8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37356B0 Offset: 0x37316B0 VA: 0x37356B0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3735750 Offset: 0x3731750 VA: 0x3735750 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
