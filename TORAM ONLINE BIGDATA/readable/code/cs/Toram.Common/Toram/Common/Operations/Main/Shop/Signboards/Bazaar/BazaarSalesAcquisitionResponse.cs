// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Shop.Signboards.Bazaar
public class BazaarSalesAcquisitionResponse : OperationResponseBase // TypeDefIndex: 11970
{
	// Fields
	[CompilerGenerated]
	private int <Sales>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Gold>k__BackingField; // 0x24

	// Properties
	public int Sales { get; set; }
	public int Gold { get; set; }
	public override byte SubCode { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x376FCD0 Offset: 0x376BCD0 VA: 0x376FCD0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x376FCD8 Offset: 0x376BCD8 VA: 0x376FCD8
	public int get_Sales() { }

	[CompilerGenerated]
	// RVA: 0x376FCE0 Offset: 0x376BCE0 VA: 0x376FCE0
	public void set_Sales(int value) { }

	[CompilerGenerated]
	// RVA: 0x376FCE8 Offset: 0x376BCE8 VA: 0x376FCE8
	public int get_Gold() { }

	[CompilerGenerated]
	// RVA: 0x376FCF0 Offset: 0x376BCF0 VA: 0x376FCF0
	public void set_Gold(int value) { }

	// RVA: 0x376FCF8 Offset: 0x376BCF8 VA: 0x376FCF8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x376FD00 Offset: 0x376BD00 VA: 0x376FD00 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x376FD08 Offset: 0x376BD08 VA: 0x376FD08 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x376FDD0 Offset: 0x376BDD0 VA: 0x376FDD0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
