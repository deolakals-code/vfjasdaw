// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Storage
public class StorageGetItems : OperationRequestBase // TypeDefIndex: 12057
{
	// Fields
	[CompilerGenerated]
	private byte <StorageNo>k__BackingField; // 0x20

	// Properties
	public byte StorageNo { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x377F07C Offset: 0x377B07C VA: 0x377F07C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x377F084 Offset: 0x377B084 VA: 0x377F084
	public byte get_StorageNo() { }

	[CompilerGenerated]
	// RVA: 0x377F08C Offset: 0x377B08C VA: 0x377F08C
	public void set_StorageNo(byte value) { }

	// RVA: 0x377F094 Offset: 0x377B094 VA: 0x377F094 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x377F09C Offset: 0x377B09C VA: 0x377F09C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x377F0A4 Offset: 0x377B0A4 VA: 0x377F0A4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x377F1C4 Offset: 0x377B1C4 VA: 0x377F1C4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
