// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Storage
public class StorageDiscardItem : OperationRequestBase // TypeDefIndex: 12055
{
	// Fields
	[CompilerGenerated]
	private byte <StorageNo>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ItemId>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <Location>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 210)]
	public byte StorageNo { get; set; }
	[PacketParameter(Code = 91)]
	public int ItemId { get; set; }
	[PacketParameter(Code = 134)]
	public int Location { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x377EA78 Offset: 0x377AA78 VA: 0x377EA78
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x377EA80 Offset: 0x377AA80 VA: 0x377EA80
	public byte get_StorageNo() { }

	[CompilerGenerated]
	// RVA: 0x377EA88 Offset: 0x377AA88 VA: 0x377EA88
	public void set_StorageNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x377EA90 Offset: 0x377AA90 VA: 0x377EA90
	public int get_ItemId() { }

	[CompilerGenerated]
	// RVA: 0x377EA98 Offset: 0x377AA98 VA: 0x377EA98
	public void set_ItemId(int value) { }

	[CompilerGenerated]
	// RVA: 0x377EAA0 Offset: 0x377AAA0 VA: 0x377EAA0
	public int get_Location() { }

	[CompilerGenerated]
	// RVA: 0x377EAA8 Offset: 0x377AAA8 VA: 0x377EAA8
	public void set_Location(int value) { }

	// RVA: 0x377EAB0 Offset: 0x377AAB0 VA: 0x377EAB0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x377EAB8 Offset: 0x377AAB8 VA: 0x377EAB8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x377EAC0 Offset: 0x377AAC0 VA: 0x377EAC0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x377EC84 Offset: 0x377AC84 VA: 0x377EC84 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
