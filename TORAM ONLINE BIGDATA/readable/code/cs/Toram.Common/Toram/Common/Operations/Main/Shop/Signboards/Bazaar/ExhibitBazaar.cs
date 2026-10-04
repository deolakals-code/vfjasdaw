// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Shop.Signboards.Bazaar
public class ExhibitBazaar : OperationRequestBase // TypeDefIndex: 11975
{
	// Fields
	[CompilerGenerated]
	private byte <SlotIndex>k__BackingField; // 0x20
	[CompilerGenerated]
	private ItemSelectData <SelectItem>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <Price>k__BackingField; // 0x30

	// Properties
	public byte SlotIndex { get; set; }
	public ItemSelectData SelectItem { get; set; }
	public int Price { get; set; }
	public override byte SubCode { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3770838 Offset: 0x376C838 VA: 0x3770838
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3770840 Offset: 0x376C840 VA: 0x3770840
	public byte get_SlotIndex() { }

	[CompilerGenerated]
	// RVA: 0x3770848 Offset: 0x376C848 VA: 0x3770848
	public void set_SlotIndex(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3770850 Offset: 0x376C850 VA: 0x3770850
	public ItemSelectData get_SelectItem() { }

	[CompilerGenerated]
	// RVA: 0x3770858 Offset: 0x376C858 VA: 0x3770858
	public void set_SelectItem(ItemSelectData value) { }

	[CompilerGenerated]
	// RVA: 0x3770860 Offset: 0x376C860 VA: 0x3770860
	public int get_Price() { }

	[CompilerGenerated]
	// RVA: 0x3770868 Offset: 0x376C868 VA: 0x3770868
	public void set_Price(int value) { }

	// RVA: 0x3770870 Offset: 0x376C870 VA: 0x3770870 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3770878 Offset: 0x376C878 VA: 0x3770878 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3770880 Offset: 0x376C880 VA: 0x3770880 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3770984 Offset: 0x376C984 VA: 0x3770984 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
