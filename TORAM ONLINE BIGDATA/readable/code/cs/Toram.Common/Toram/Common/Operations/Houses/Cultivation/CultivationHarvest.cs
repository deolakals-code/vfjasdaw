// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Cultivation
public class CultivationHarvest : OperationRequestBase // TypeDefIndex: 12199
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

	// RVA: 0x35DF66C Offset: 0x35DB66C VA: 0x35DF66C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35DF674 Offset: 0x35DB674 VA: 0x35DF674
	public int get_Id() { }

	[CompilerGenerated]
	// RVA: 0x35DF67C Offset: 0x35DB67C VA: 0x35DF67C
	public void set_Id(int value) { }

	[CompilerGenerated]
	// RVA: 0x35DF684 Offset: 0x35DB684 VA: 0x35DF684
	public short get_Index() { }

	[CompilerGenerated]
	// RVA: 0x35DF68C Offset: 0x35DB68C VA: 0x35DF68C
	public void set_Index(short value) { }

	// RVA: 0x35DF694 Offset: 0x35DB694 VA: 0x35DF694 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35DF69C Offset: 0x35DB69C VA: 0x35DF69C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35DF6A4 Offset: 0x35DB6A4 VA: 0x35DF6A4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35DF81C Offset: 0x35DB81C VA: 0x35DF81C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
