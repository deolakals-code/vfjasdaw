// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Item
[CLSCompliant(False)]
public class _ItemUserFlagChangeResponse : OperationResponseBase // TypeDefIndex: 12144
{
	// Fields
	[CompilerGenerated]
	private ItemDatav2 <ItemData>k__BackingField; // 0x20

	// Properties
	public ItemDatav2 ItemData { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x37901C4 Offset: 0x378C1C4 VA: 0x37901C4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x37901CC Offset: 0x378C1CC VA: 0x37901CC
	public ItemDatav2 get_ItemData() { }

	[CompilerGenerated]
	// RVA: 0x37901D4 Offset: 0x378C1D4 VA: 0x37901D4
	public void set_ItemData(ItemDatav2 value) { }

	// RVA: 0x37901DC Offset: 0x378C1DC VA: 0x37901DC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37901E4 Offset: 0x378C1E4 VA: 0x37901E4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37901EC Offset: 0x378C1EC VA: 0x37901EC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3790274 Offset: 0x378C274 VA: 0x3790274 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
