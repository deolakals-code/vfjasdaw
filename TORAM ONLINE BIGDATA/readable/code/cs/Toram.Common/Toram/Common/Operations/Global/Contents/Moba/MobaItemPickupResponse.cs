// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Global.Contents.Moba
public class MobaItemPickupResponse : OperationResponseBase // TypeDefIndex: 11607
{
	// Fields
	[CompilerGenerated]
	private short <ReturnCode>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ItemUniqueId>k__BackingField; // 0x24

	// Properties
	public short ReturnCode { get; set; }
	public int ItemUniqueId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3723A34 Offset: 0x371FA34 VA: 0x3723A34
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3723A3C Offset: 0x371FA3C VA: 0x3723A3C
	public short get_ReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x3723A44 Offset: 0x371FA44 VA: 0x3723A44
	public void set_ReturnCode(short value) { }

	[CompilerGenerated]
	// RVA: 0x3723A4C Offset: 0x371FA4C VA: 0x3723A4C
	public int get_ItemUniqueId() { }

	[CompilerGenerated]
	// RVA: 0x3723A54 Offset: 0x371FA54 VA: 0x3723A54
	public void set_ItemUniqueId(int value) { }

	// RVA: 0x3723A5C Offset: 0x371FA5C VA: 0x3723A5C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3723A64 Offset: 0x371FA64 VA: 0x3723A64 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3723A6C Offset: 0x371FA6C VA: 0x3723A6C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3723B48 Offset: 0x371FB48 VA: 0x3723B48 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
