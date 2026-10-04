// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Storage
public class StorageOrderChangeResponse : OperationResponseBase // TypeDefIndex: 12048
{
	// Fields
	[CompilerGenerated]
	private byte[] <StorageOrder>k__BackingField; // 0x20

	// Properties
	public byte[] StorageOrder { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x377D4F0 Offset: 0x37794F0 VA: 0x377D4F0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x377D4F8 Offset: 0x37794F8 VA: 0x377D4F8
	public byte[] get_StorageOrder() { }

	[CompilerGenerated]
	// RVA: 0x377D500 Offset: 0x3779500 VA: 0x377D500
	public void set_StorageOrder(byte[] value) { }

	// RVA: 0x377D508 Offset: 0x3779508 VA: 0x377D508 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x377D510 Offset: 0x3779510 VA: 0x377D510 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x377D518 Offset: 0x3779518 VA: 0x377D518 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x377D670 Offset: 0x3779670 VA: 0x377D670 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
