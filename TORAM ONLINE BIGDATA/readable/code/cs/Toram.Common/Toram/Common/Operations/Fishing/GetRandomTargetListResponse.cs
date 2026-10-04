// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Fishing
public class GetRandomTargetListResponse : OperationResponseBase // TypeDefIndex: 11656
{
	// Fields
	[CompilerGenerated]
	private FishingRandomTargetData[] <List>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 15)]
	public FishingRandomTargetData[] List { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x372C530 Offset: 0x3728530 VA: 0x372C530
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x372C538 Offset: 0x3728538 VA: 0x372C538
	public FishingRandomTargetData[] get_List() { }

	[CompilerGenerated]
	// RVA: 0x372C540 Offset: 0x3728540 VA: 0x372C540
	public void set_List(FishingRandomTargetData[] value) { }

	// RVA: 0x372C548 Offset: 0x3728548 VA: 0x372C548 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x372C550 Offset: 0x3728550 VA: 0x372C550 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x372C558 Offset: 0x3728558 VA: 0x372C558 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x372C5EC Offset: 0x37285EC VA: 0x372C5EC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
