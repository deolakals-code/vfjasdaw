// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Storage
public class StorageSearchItemMove : OperationRequestBase // TypeDefIndex: 12045
{
	// Fields
	[CompilerGenerated]
	private int <Location>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ItemId>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <UseType>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <BeforeStorageNo>k__BackingField; // 0x29
	[CompilerGenerated]
	private byte <AfterStorageNo>k__BackingField; // 0x2A

	// Properties
	public int Location { get; set; }
	public int ItemId { get; set; }
	public byte UseType { get; set; }
	public byte BeforeStorageNo { get; set; }
	public byte AfterStorageNo { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x377CEC4 Offset: 0x3778EC4 VA: 0x377CEC4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x377CECC Offset: 0x3778ECC VA: 0x377CECC
	public int get_Location() { }

	[CompilerGenerated]
	// RVA: 0x377CED4 Offset: 0x3778ED4 VA: 0x377CED4
	public void set_Location(int value) { }

	[CompilerGenerated]
	// RVA: 0x377CEDC Offset: 0x3778EDC VA: 0x377CEDC
	public int get_ItemId() { }

	[CompilerGenerated]
	// RVA: 0x377CEE4 Offset: 0x3778EE4 VA: 0x377CEE4
	public void set_ItemId(int value) { }

	[CompilerGenerated]
	// RVA: 0x377CEEC Offset: 0x3778EEC VA: 0x377CEEC
	public byte get_UseType() { }

	[CompilerGenerated]
	// RVA: 0x377CEF4 Offset: 0x3778EF4 VA: 0x377CEF4
	public void set_UseType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x377CEFC Offset: 0x3778EFC VA: 0x377CEFC
	public byte get_BeforeStorageNo() { }

	[CompilerGenerated]
	// RVA: 0x377CF04 Offset: 0x3778F04 VA: 0x377CF04
	public void set_BeforeStorageNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x377CF0C Offset: 0x3778F0C VA: 0x377CF0C
	public byte get_AfterStorageNo() { }

	[CompilerGenerated]
	// RVA: 0x377CF14 Offset: 0x3778F14 VA: 0x377CF14
	public void set_AfterStorageNo(byte value) { }

	// RVA: 0x377CF1C Offset: 0x3778F1C VA: 0x377CF1C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x377CF24 Offset: 0x3778F24 VA: 0x377CF24 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x377CF2C Offset: 0x3778F2C VA: 0x377CF2C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x377D088 Offset: 0x3779088 VA: 0x377D088 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
