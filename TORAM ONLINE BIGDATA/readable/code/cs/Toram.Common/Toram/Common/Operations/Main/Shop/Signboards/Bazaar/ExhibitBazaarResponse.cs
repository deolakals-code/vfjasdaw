// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Shop.Signboards.Bazaar
public class ExhibitBazaarResponse : OperationResponseBase // TypeDefIndex: 11976
{
	// Fields
	[CompilerGenerated]
	private BazaarItemData <BazaarItem>k__BackingField; // 0x20
	[CompilerGenerated]
	private ItemDatav2 <UpdateItem>k__BackingField; // 0x28

	// Properties
	public BazaarItemData BazaarItem { get; set; }
	public ItemDatav2 UpdateItem { get; set; }
	public override byte SubCode { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3770BA4 Offset: 0x376CBA4 VA: 0x3770BA4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3770BAC Offset: 0x376CBAC VA: 0x3770BAC
	public BazaarItemData get_BazaarItem() { }

	[CompilerGenerated]
	// RVA: 0x3770BB4 Offset: 0x376CBB4 VA: 0x3770BB4
	public void set_BazaarItem(BazaarItemData value) { }

	[CompilerGenerated]
	// RVA: 0x3770BBC Offset: 0x376CBBC VA: 0x3770BBC
	public ItemDatav2 get_UpdateItem() { }

	[CompilerGenerated]
	// RVA: 0x3770BC4 Offset: 0x376CBC4 VA: 0x3770BC4
	public void set_UpdateItem(ItemDatav2 value) { }

	// RVA: 0x3770BCC Offset: 0x376CBCC VA: 0x3770BCC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3770BD4 Offset: 0x376CBD4 VA: 0x3770BD4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3770BDC Offset: 0x376CBDC VA: 0x3770BDC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3770C8C Offset: 0x376CC8C VA: 0x3770C8C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
