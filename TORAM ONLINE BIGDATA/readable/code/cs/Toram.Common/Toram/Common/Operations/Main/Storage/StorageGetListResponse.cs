// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Storage
public class StorageGetListResponse : OperationResponseBase // TypeDefIndex: 12060
{
	// Fields
	[CompilerGenerated]
	private StorageDatav2[] <StorageList>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <StorageLimit>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte[] <StorageOrder>k__BackingField; // 0x30

	// Properties
	[PacketClass(Code = 213, IsOptional = True)]
	public StorageDatav2[] StorageList { get; set; }
	[PacketParameter(Code = 185)]
	public byte StorageLimit { get; set; }
	[PacketClass(Code = 153, IsOptional = True)]
	public byte[] StorageOrder { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x377F56C Offset: 0x377B56C VA: 0x377F56C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x377F574 Offset: 0x377B574 VA: 0x377F574
	public StorageDatav2[] get_StorageList() { }

	[CompilerGenerated]
	// RVA: 0x377F57C Offset: 0x377B57C VA: 0x377F57C
	public void set_StorageList(StorageDatav2[] value) { }

	[CompilerGenerated]
	// RVA: 0x377F584 Offset: 0x377B584 VA: 0x377F584
	public byte get_StorageLimit() { }

	[CompilerGenerated]
	// RVA: 0x377F58C Offset: 0x377B58C VA: 0x377F58C
	public void set_StorageLimit(byte value) { }

	[CompilerGenerated]
	// RVA: 0x377F594 Offset: 0x377B594 VA: 0x377F594
	public byte[] get_StorageOrder() { }

	[CompilerGenerated]
	// RVA: 0x377F59C Offset: 0x377B59C VA: 0x377F59C
	public void set_StorageOrder(byte[] value) { }

	// RVA: 0x377F5A4 Offset: 0x377B5A4 VA: 0x377F5A4
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x377F694 Offset: 0x377B694 VA: 0x377F694
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x377F720 Offset: 0x377B720 VA: 0x377F720 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x377F728 Offset: 0x377B728 VA: 0x377F728 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x377F730 Offset: 0x377B730 VA: 0x377F730 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x377F8F8 Offset: 0x377B8F8 VA: 0x377F8F8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
