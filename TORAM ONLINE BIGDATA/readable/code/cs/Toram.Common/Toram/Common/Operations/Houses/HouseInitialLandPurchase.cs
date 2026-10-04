// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses
public class HouseInitialLandPurchase : OperationRequestBase // TypeDefIndex: 12177
{
	// Fields
	[CompilerGenerated]
	private int <LandPrice>k__BackingField; // 0x20

	// Properties
	public int LandPrice { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3795C70 Offset: 0x3791C70 VA: 0x3795C70
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3795C78 Offset: 0x3791C78 VA: 0x3795C78
	public int get_LandPrice() { }

	[CompilerGenerated]
	// RVA: 0x3795C80 Offset: 0x3791C80 VA: 0x3795C80
	public void set_LandPrice(int value) { }

	// RVA: 0x3795C88 Offset: 0x3791C88 VA: 0x3795C88 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3795C90 Offset: 0x3791C90 VA: 0x3795C90 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3795C98 Offset: 0x3791C98 VA: 0x3795C98 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3795DB8 Offset: 0x3791DB8 VA: 0x3795DB8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
