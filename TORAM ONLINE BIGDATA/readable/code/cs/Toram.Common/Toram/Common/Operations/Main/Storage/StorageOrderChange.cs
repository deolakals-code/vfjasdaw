// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Storage
public class StorageOrderChange : OperationRequestBase // TypeDefIndex: 12047
{
	// Fields
	[CompilerGenerated]
	private byte[] <StorageOrder>k__BackingField; // 0x20

	// Properties
	public byte[] StorageOrder { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x377D2FC Offset: 0x37792FC VA: 0x377D2FC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x377D304 Offset: 0x3779304 VA: 0x377D304
	public byte[] get_StorageOrder() { }

	[CompilerGenerated]
	// RVA: 0x377D30C Offset: 0x377930C VA: 0x377D30C
	public void set_StorageOrder(byte[] value) { }

	// RVA: 0x377D314 Offset: 0x3779314 VA: 0x377D314 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x377D31C Offset: 0x377931C VA: 0x377D31C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x377D324 Offset: 0x3779324 VA: 0x377D324 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x377D47C Offset: 0x377947C VA: 0x377D47C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
