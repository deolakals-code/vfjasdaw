// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Global.Contents.Moba
public class MobaSellAbility : OperationRequestBase // TypeDefIndex: 11613
{
	// Fields
	[CompilerGenerated]
	private int <AbilityId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Price>k__BackingField; // 0x24

	// Properties
	public int AbilityId { get; set; }
	public int Price { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x37251E0 Offset: 0x37211E0 VA: 0x37251E0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x37251E8 Offset: 0x37211E8 VA: 0x37251E8
	public int get_AbilityId() { }

	[CompilerGenerated]
	// RVA: 0x37251F0 Offset: 0x37211F0 VA: 0x37251F0
	public void set_AbilityId(int value) { }

	[CompilerGenerated]
	// RVA: 0x37251F8 Offset: 0x37211F8 VA: 0x37251F8
	public int get_Price() { }

	[CompilerGenerated]
	// RVA: 0x3725200 Offset: 0x3721200 VA: 0x3725200
	public void set_Price(int value) { }

	// RVA: 0x3725208 Offset: 0x3721208 VA: 0x3725208 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3725210 Offset: 0x3721210 VA: 0x3725210 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3725218 Offset: 0x3721218 VA: 0x3725218 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x37252E0 Offset: 0x37212E0 VA: 0x37252E0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
