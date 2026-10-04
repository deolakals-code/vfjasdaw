// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Lottery
public class HouseLotteryInfoResponse : OperationResponseBase // TypeDefIndex: 11530
{
	// Fields
	[CompilerGenerated]
	private int <LotteryListCount>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 253)]
	public int LotteryListCount { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3716A0C Offset: 0x3712A0C VA: 0x3716A0C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3716A14 Offset: 0x3712A14 VA: 0x3716A14
	public int get_LotteryListCount() { }

	[CompilerGenerated]
	// RVA: 0x3716A1C Offset: 0x3712A1C VA: 0x3716A1C
	public void set_LotteryListCount(int value) { }

	// RVA: 0x3716A24 Offset: 0x3712A24 VA: 0x3716A24
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3716A28 Offset: 0x3712A28 VA: 0x3716A28
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3716A2C Offset: 0x3712A2C VA: 0x3716A2C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3716A34 Offset: 0x3712A34 VA: 0x3716A34 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3716A3C Offset: 0x3712A3C VA: 0x3716A3C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3716B5C Offset: 0x3712B5C VA: 0x3716B5C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
