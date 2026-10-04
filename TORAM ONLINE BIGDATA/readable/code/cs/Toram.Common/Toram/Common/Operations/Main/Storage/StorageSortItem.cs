// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Storage
public class StorageSortItem : OperationRequestBase // TypeDefIndex: 12065
{
	// Fields
	[CompilerGenerated]
	private byte <StorageNo>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <StorageBagId>k__BackingField; // 0x21

	// Properties
	[PacketParameter(Code = 210)]
	public byte StorageNo { get; set; }
	[PacketParameter(Code = 166)]
	public byte StorageBagId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3780798 Offset: 0x377C798 VA: 0x3780798
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x37807A0 Offset: 0x377C7A0 VA: 0x37807A0
	public byte get_StorageNo() { }

	[CompilerGenerated]
	// RVA: 0x37807A8 Offset: 0x377C7A8 VA: 0x37807A8
	public void set_StorageNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x37807B0 Offset: 0x377C7B0 VA: 0x37807B0
	public byte get_StorageBagId() { }

	[CompilerGenerated]
	// RVA: 0x37807B8 Offset: 0x377C7B8 VA: 0x37807B8
	public void set_StorageBagId(byte value) { }

	// RVA: 0x37807C0 Offset: 0x377C7C0 VA: 0x37807C0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37807C8 Offset: 0x377C7C8 VA: 0x37807C8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37807D0 Offset: 0x377C7D0 VA: 0x37807D0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x378093C Offset: 0x377C93C VA: 0x378093C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
