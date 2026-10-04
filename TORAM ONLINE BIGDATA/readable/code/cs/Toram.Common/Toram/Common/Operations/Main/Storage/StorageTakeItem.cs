// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Storage
public class StorageTakeItem : OperationRequestBase // TypeDefIndex: 12067
{
	// Fields
	[CompilerGenerated]
	private byte <StorageNo>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Location>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <ItemId>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <BagId>k__BackingField; // 0x2C
	[CompilerGenerated]
	private short <Num>k__BackingField; // 0x2E
	[CompilerGenerated]
	private byte <UseType>k__BackingField; // 0x30

	// Properties
	[PacketParameter(Code = 210)]
	public byte StorageNo { get; set; }
	[PacketParameter(Code = 134)]
	public int Location { get; set; }
	[PacketParameter(Code = 91)]
	public int ItemId { get; set; }
	[PacketParameter(Code = 166)]
	public byte BagId { get; set; }
	[PacketParameter(Code = 253, IsOptional = True)]
	public short Num { get; set; }
	[PacketParameter(Code = 245, IsOptional = True)]
	public byte UseType { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3780C94 Offset: 0x377CC94 VA: 0x3780C94
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3780C9C Offset: 0x377CC9C VA: 0x3780C9C
	public byte get_StorageNo() { }

	[CompilerGenerated]
	// RVA: 0x3780CA4 Offset: 0x377CCA4 VA: 0x3780CA4
	public void set_StorageNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3780CAC Offset: 0x377CCAC VA: 0x3780CAC
	public int get_Location() { }

	[CompilerGenerated]
	// RVA: 0x3780CB4 Offset: 0x377CCB4 VA: 0x3780CB4
	public void set_Location(int value) { }

	[CompilerGenerated]
	// RVA: 0x3780CBC Offset: 0x377CCBC VA: 0x3780CBC
	public int get_ItemId() { }

	[CompilerGenerated]
	// RVA: 0x3780CC4 Offset: 0x377CCC4 VA: 0x3780CC4
	public void set_ItemId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3780CCC Offset: 0x377CCCC VA: 0x3780CCC
	public byte get_BagId() { }

	[CompilerGenerated]
	// RVA: 0x3780CD4 Offset: 0x377CCD4 VA: 0x3780CD4
	public void set_BagId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3780CDC Offset: 0x377CCDC VA: 0x3780CDC
	public short get_Num() { }

	[CompilerGenerated]
	// RVA: 0x3780CE4 Offset: 0x377CCE4 VA: 0x3780CE4
	public void set_Num(short value) { }

	[CompilerGenerated]
	// RVA: 0x3780CEC Offset: 0x377CCEC VA: 0x3780CEC
	public byte get_UseType() { }

	[CompilerGenerated]
	// RVA: 0x3780CF4 Offset: 0x377CCF4 VA: 0x3780CF4
	public void set_UseType(byte value) { }

	// RVA: 0x3780CFC Offset: 0x377CCFC VA: 0x3780CFC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3780D04 Offset: 0x377CD04 VA: 0x3780D04 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3780D0C Offset: 0x377CD0C VA: 0x3780D0C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3780FF4 Offset: 0x377CFF4 VA: 0x3780FF4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
