// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Global.Contents.Moba
public class MobaChestCancel : OperationRequestBase // TypeDefIndex: 11596
{
	// Fields
	[CompilerGenerated]
	private int <ChestUniqueId>k__BackingField; // 0x20

	// Properties
	public int ChestUniqueId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x37219E8 Offset: 0x371D9E8 VA: 0x37219E8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x37219F0 Offset: 0x371D9F0 VA: 0x37219F0
	public int get_ChestUniqueId() { }

	[CompilerGenerated]
	// RVA: 0x37219F8 Offset: 0x371D9F8 VA: 0x37219F8
	public void set_ChestUniqueId(int value) { }

	// RVA: 0x3721A00 Offset: 0x371DA00 VA: 0x3721A00 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3721A08 Offset: 0x371DA08 VA: 0x3721A08 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3721A10 Offset: 0x371DA10 VA: 0x3721A10 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3721AB0 Offset: 0x371DAB0 VA: 0x3721AB0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
