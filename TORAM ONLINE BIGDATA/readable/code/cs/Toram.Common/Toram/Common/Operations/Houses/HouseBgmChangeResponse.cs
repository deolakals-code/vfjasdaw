// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses
public class HouseBgmChangeResponse : OperationResponseBase // TypeDefIndex: 12160
{
	// Fields
	[CompilerGenerated]
	private int <BgmItemId>k__BackingField; // 0x20

	// Properties
	public int BgmItemId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x379319C Offset: 0x378F19C VA: 0x379319C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x37931A4 Offset: 0x378F1A4 VA: 0x37931A4
	public int get_BgmItemId() { }

	[CompilerGenerated]
	// RVA: 0x37931AC Offset: 0x378F1AC VA: 0x37931AC
	public void set_BgmItemId(int value) { }

	// RVA: 0x37931B4 Offset: 0x378F1B4 VA: 0x37931B4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37931BC Offset: 0x378F1BC VA: 0x37931BC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37931C4 Offset: 0x378F1C4 VA: 0x37931C4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37932E4 Offset: 0x378F2E4 VA: 0x37932E4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
