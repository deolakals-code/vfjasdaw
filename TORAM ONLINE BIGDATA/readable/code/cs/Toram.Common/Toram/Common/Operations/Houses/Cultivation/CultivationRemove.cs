// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Cultivation
public class CultivationRemove : OperationRequestBase // TypeDefIndex: 12203
{
	// Fields
	[CompilerGenerated]
	private int <Id>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <Index>k__BackingField; // 0x24

	// Properties
	[PacketParameter(Code = 200)]
	public int Id { get; set; }
	[PacketParameter(Code = 153)]
	public short Index { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35E052C Offset: 0x35DC52C VA: 0x35E052C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35E0534 Offset: 0x35DC534 VA: 0x35E0534
	public int get_Id() { }

	[CompilerGenerated]
	// RVA: 0x35E053C Offset: 0x35DC53C VA: 0x35E053C
	public void set_Id(int value) { }

	[CompilerGenerated]
	// RVA: 0x35E0544 Offset: 0x35DC544 VA: 0x35E0544
	public short get_Index() { }

	[CompilerGenerated]
	// RVA: 0x35E054C Offset: 0x35DC54C VA: 0x35E054C
	public void set_Index(short value) { }

	// RVA: 0x35E0554 Offset: 0x35DC554 VA: 0x35E0554 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35E055C Offset: 0x35DC55C VA: 0x35E055C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35E0564 Offset: 0x35DC564 VA: 0x35E0564 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E06DC Offset: 0x35DC6DC VA: 0x35E06DC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
