// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Party.Lottery
public class LotteryInfoResponse : OperationResponseBase // TypeDefIndex: 11510
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

	// RVA: 0x3715014 Offset: 0x3711014 VA: 0x3715014
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x371501C Offset: 0x371101C VA: 0x371501C
	public int get_LotteryListCount() { }

	[CompilerGenerated]
	// RVA: 0x3715024 Offset: 0x3711024 VA: 0x3715024
	public void set_LotteryListCount(int value) { }

	// RVA: 0x371502C Offset: 0x371102C VA: 0x371502C
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3715030 Offset: 0x3711030 VA: 0x3715030
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3715034 Offset: 0x3711034 VA: 0x3715034 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x371503C Offset: 0x371103C VA: 0x371503C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3715044 Offset: 0x3711044 VA: 0x3715044 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3715164 Offset: 0x3711164 VA: 0x3715164 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
