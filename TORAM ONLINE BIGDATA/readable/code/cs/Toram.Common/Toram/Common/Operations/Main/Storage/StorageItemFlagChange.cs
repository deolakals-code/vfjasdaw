// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Storage
public class StorageItemFlagChange : OperationRequestBase // TypeDefIndex: 12061
{
	// Fields
	[CompilerGenerated]
	private byte <StorageNo>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Location>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <ItemId>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <ItemUserFlag>k__BackingField; // 0x2C

	// Properties
	[PacketParameter(Code = 210)]
	public byte StorageNo { get; set; }
	[PacketParameter(Code = 134)]
	public int Location { get; set; }
	[PacketParameter(Code = 91)]
	public int ItemId { get; set; }
	[PacketParameter(Code = 43)]
	public byte ItemUserFlag { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x377F9BC Offset: 0x377B9BC VA: 0x377F9BC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x377F9C4 Offset: 0x377B9C4 VA: 0x377F9C4
	public byte get_StorageNo() { }

	[CompilerGenerated]
	// RVA: 0x377F9CC Offset: 0x377B9CC VA: 0x377F9CC
	public void set_StorageNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x377F9D4 Offset: 0x377B9D4 VA: 0x377F9D4
	public int get_Location() { }

	[CompilerGenerated]
	// RVA: 0x377F9DC Offset: 0x377B9DC VA: 0x377F9DC
	public void set_Location(int value) { }

	[CompilerGenerated]
	// RVA: 0x377F9E4 Offset: 0x377B9E4 VA: 0x377F9E4
	public int get_ItemId() { }

	[CompilerGenerated]
	// RVA: 0x377F9EC Offset: 0x377B9EC VA: 0x377F9EC
	public void set_ItemId(int value) { }

	[CompilerGenerated]
	// RVA: 0x377F9F4 Offset: 0x377B9F4 VA: 0x377F9F4
	public byte get_ItemUserFlag() { }

	[CompilerGenerated]
	// RVA: 0x377F9FC Offset: 0x377B9FC VA: 0x377F9FC
	public void set_ItemUserFlag(byte value) { }

	// RVA: 0x377FA04 Offset: 0x377BA04 VA: 0x377FA04 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x377FA0C Offset: 0x377BA0C VA: 0x377FA0C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x377FA14 Offset: 0x377BA14 VA: 0x377FA14 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x377FC1C Offset: 0x377BC1C VA: 0x377FC1C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
