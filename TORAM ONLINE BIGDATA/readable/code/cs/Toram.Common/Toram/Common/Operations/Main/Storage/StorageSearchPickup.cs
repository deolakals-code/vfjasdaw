// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Storage
public class StorageSearchPickup : OperationRequestBase // TypeDefIndex: 12050
{
	// Fields
	[CompilerGenerated]
	private int <Location>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ItemId>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <UseType>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <Num>k__BackingField; // 0x2A

	// Properties
	public int Location { get; set; }
	public int ItemId { get; set; }
	public byte UseType { get; set; }
	public short Num { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x377DBFC Offset: 0x3779BFC VA: 0x377DBFC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x377DC04 Offset: 0x3779C04 VA: 0x377DC04
	public int get_Location() { }

	[CompilerGenerated]
	// RVA: 0x377DC0C Offset: 0x3779C0C VA: 0x377DC0C
	public void set_Location(int value) { }

	[CompilerGenerated]
	// RVA: 0x377DC14 Offset: 0x3779C14 VA: 0x377DC14
	public int get_ItemId() { }

	[CompilerGenerated]
	// RVA: 0x377DC1C Offset: 0x3779C1C VA: 0x377DC1C
	public void set_ItemId(int value) { }

	[CompilerGenerated]
	// RVA: 0x377DC24 Offset: 0x3779C24 VA: 0x377DC24
	public byte get_UseType() { }

	[CompilerGenerated]
	// RVA: 0x377DC2C Offset: 0x3779C2C VA: 0x377DC2C
	public void set_UseType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x377DC34 Offset: 0x3779C34 VA: 0x377DC34
	public short get_Num() { }

	[CompilerGenerated]
	// RVA: 0x377DC3C Offset: 0x3779C3C VA: 0x377DC3C
	public void set_Num(short value) { }

	// RVA: 0x377DC44 Offset: 0x3779C44 VA: 0x377DC44 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x377DC4C Offset: 0x3779C4C VA: 0x377DC4C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x377DC54 Offset: 0x3779C54 VA: 0x377DC54 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x377DDA4 Offset: 0x3779DA4 VA: 0x377DDA4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
