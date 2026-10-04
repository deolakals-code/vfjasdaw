// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Fishing
public class ExpansionFishingFishBagSlotResponse : OperationResponseBase // TypeDefIndex: 11652
{
	// Fields
	[CompilerGenerated]
	private short <Capacity>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Gold>k__BackingField; // 0x24

	// Properties
	[PacketParameter(Code = 10)]
	public short Capacity { get; set; }
	[PacketParameter(Code = 11)]
	public int Gold { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x372BA8C Offset: 0x3727A8C VA: 0x372BA8C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x372BA94 Offset: 0x3727A94 VA: 0x372BA94
	public short get_Capacity() { }

	[CompilerGenerated]
	// RVA: 0x372BA9C Offset: 0x3727A9C VA: 0x372BA9C
	public void set_Capacity(short value) { }

	[CompilerGenerated]
	// RVA: 0x372BAA4 Offset: 0x3727AA4 VA: 0x372BAA4
	public int get_Gold() { }

	[CompilerGenerated]
	// RVA: 0x372BAAC Offset: 0x3727AAC VA: 0x372BAAC
	public void set_Gold(int value) { }

	// RVA: 0x372BAB4 Offset: 0x3727AB4 VA: 0x372BAB4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x372BABC Offset: 0x3727ABC VA: 0x372BABC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x372BAC4 Offset: 0x3727AC4 VA: 0x372BAC4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x372BBA0 Offset: 0x3727BA0 VA: 0x372BBA0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
