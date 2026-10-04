// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Item
[CLSCompliant(False)]
public class _WarrantyDiscardResponse : OperationResponseBase // TypeDefIndex: 12146
{
	// Fields
	[CompilerGenerated]
	private byte <DiscardIndex>k__BackingField; // 0x20

	// Properties
	public byte DiscardIndex { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3790688 Offset: 0x378C688 VA: 0x3790688
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3790690 Offset: 0x378C690 VA: 0x3790690
	public byte get_DiscardIndex() { }

	[CompilerGenerated]
	// RVA: 0x3790698 Offset: 0x378C698 VA: 0x3790698
	public void set_DiscardIndex(byte value) { }

	// RVA: 0x37906A0 Offset: 0x378C6A0 VA: 0x37906A0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37906A8 Offset: 0x378C6A8 VA: 0x37906A8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37906B0 Offset: 0x378C6B0 VA: 0x37906B0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3790750 Offset: 0x378C750 VA: 0x3790750 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
