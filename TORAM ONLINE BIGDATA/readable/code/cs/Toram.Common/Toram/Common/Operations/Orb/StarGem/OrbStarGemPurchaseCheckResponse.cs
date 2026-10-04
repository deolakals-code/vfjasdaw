// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Orb.StarGem
public class OrbStarGemPurchaseCheckResponse : OperationResponseBase // TypeDefIndex: 11836
{
	// Fields
	[CompilerGenerated]
	private bool <Enable>k__BackingField; // 0x20

	// Properties
	public bool Enable { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3753D48 Offset: 0x374FD48 VA: 0x3753D48
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3753D50 Offset: 0x374FD50 VA: 0x3753D50
	public bool get_Enable() { }

	[CompilerGenerated]
	// RVA: 0x3753D58 Offset: 0x374FD58 VA: 0x3753D58
	public void set_Enable(bool value) { }

	// RVA: 0x3753D64 Offset: 0x374FD64 VA: 0x3753D64 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3753D6C Offset: 0x374FD6C VA: 0x3753D6C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3753D74 Offset: 0x374FD74 VA: 0x3753D74 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3753E94 Offset: 0x374FE94 VA: 0x3753E94 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
