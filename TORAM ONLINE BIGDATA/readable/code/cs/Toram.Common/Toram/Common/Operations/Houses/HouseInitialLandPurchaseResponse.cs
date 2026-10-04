// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses
public class HouseInitialLandPurchaseResponse : OperationResponseBase // TypeDefIndex: 12176
{
	// Fields
	[CompilerGenerated]
	private int <Gold>k__BackingField; // 0x20

	// Properties
	public int Gold { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3795A88 Offset: 0x3791A88 VA: 0x3795A88
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3795A90 Offset: 0x3791A90 VA: 0x3795A90
	public int get_Gold() { }

	[CompilerGenerated]
	// RVA: 0x3795A98 Offset: 0x3791A98 VA: 0x3795A98
	public void set_Gold(int value) { }

	// RVA: 0x3795AA0 Offset: 0x3791AA0 VA: 0x3795AA0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3795AA8 Offset: 0x3791AA8 VA: 0x3795AA8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3795AB0 Offset: 0x3791AB0 VA: 0x3795AB0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3795BD0 Offset: 0x3791BD0 VA: 0x3795BD0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
