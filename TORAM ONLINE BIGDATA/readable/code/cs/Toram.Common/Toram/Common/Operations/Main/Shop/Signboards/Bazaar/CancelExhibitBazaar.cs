// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Shop.Signboards.Bazaar
public class CancelExhibitBazaar : OperationRequestBase // TypeDefIndex: 11971
{
	// Fields
	[CompilerGenerated]
	private byte <SlotIndex>k__BackingField; // 0x20

	// Properties
	public byte SlotIndex { get; set; }
	public override byte SubCode { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x376FF3C Offset: 0x376BF3C VA: 0x376FF3C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x376FF44 Offset: 0x376BF44 VA: 0x376FF44
	public byte get_SlotIndex() { }

	[CompilerGenerated]
	// RVA: 0x376FF4C Offset: 0x376BF4C VA: 0x376FF4C
	public void set_SlotIndex(byte value) { }

	// RVA: 0x376FF54 Offset: 0x376BF54 VA: 0x376FF54 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x376FF5C Offset: 0x376BF5C VA: 0x376FF5C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x376FF64 Offset: 0x376BF64 VA: 0x376FF64 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3770004 Offset: 0x376C004 VA: 0x3770004 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
