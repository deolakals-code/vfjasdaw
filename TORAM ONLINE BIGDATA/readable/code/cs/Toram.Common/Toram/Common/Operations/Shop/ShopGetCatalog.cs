// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Shop
public class ShopGetCatalog : OperationRequestBase // TypeDefIndex: 11716
{
	// Fields
	[CompilerGenerated]
	private int <ShopId>k__BackingField; // 0x20
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x28

	// Properties
	public int ShopId { get; set; }
	public short[] Position { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3739CC0 Offset: 0x3735CC0 VA: 0x3739CC0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3739CC8 Offset: 0x3735CC8 VA: 0x3739CC8
	public int get_ShopId() { }

	[CompilerGenerated]
	// RVA: 0x3739CD0 Offset: 0x3735CD0 VA: 0x3739CD0
	public void set_ShopId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3739CD8 Offset: 0x3735CD8 VA: 0x3739CD8
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x3739CE0 Offset: 0x3735CE0 VA: 0x3739CE0
	public void set_Position(short[] value) { }

	// RVA: 0x3739CE8 Offset: 0x3735CE8 VA: 0x3739CE8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3739CF0 Offset: 0x3735CF0 VA: 0x3739CF0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3739CF8 Offset: 0x3735CF8 VA: 0x3739CF8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3739DB0 Offset: 0x3735DB0 VA: 0x3739DB0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
