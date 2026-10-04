// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Shop
public class ArmorRemodeling : OperationRequestBase // TypeDefIndex: 11702
{
	// Fields
	[CompilerGenerated]
	private int <ShopId>k__BackingField; // 0x20
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <ItemUuid>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte <Custom>k__BackingField; // 0x34

	// Properties
	public int ShopId { get; set; }
	public short[] Position { get; set; }
	public int ItemUuid { get; set; }
	public byte Custom { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3735870 Offset: 0x3731870 VA: 0x3735870
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3735878 Offset: 0x3731878 VA: 0x3735878
	public int get_ShopId() { }

	[CompilerGenerated]
	// RVA: 0x3735880 Offset: 0x3731880 VA: 0x3735880
	public void set_ShopId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3735888 Offset: 0x3731888 VA: 0x3735888
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x3735890 Offset: 0x3731890 VA: 0x3735890
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x3735898 Offset: 0x3731898 VA: 0x3735898
	public int get_ItemUuid() { }

	[CompilerGenerated]
	// RVA: 0x37358A0 Offset: 0x37318A0 VA: 0x37358A0
	public void set_ItemUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x37358A8 Offset: 0x37318A8 VA: 0x37358A8
	public byte get_Custom() { }

	[CompilerGenerated]
	// RVA: 0x37358B0 Offset: 0x37318B0 VA: 0x37358B0
	public void set_Custom(byte value) { }

	// RVA: 0x37358B8 Offset: 0x37318B8 VA: 0x37358B8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37358C0 Offset: 0x37318C0 VA: 0x37358C0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37358C8 Offset: 0x37318C8 VA: 0x37358C8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x37359F8 Offset: 0x37319F8 VA: 0x37359F8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
