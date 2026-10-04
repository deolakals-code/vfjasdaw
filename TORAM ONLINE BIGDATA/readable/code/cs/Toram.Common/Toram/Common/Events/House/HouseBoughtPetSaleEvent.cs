// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.House
public class HouseBoughtPetSaleEvent : EventSubBase // TypeDefIndex: 12810
{
	// Fields
	[CompilerGenerated]
	private HousePetSaleItemData <PetSale>k__BackingField; // 0x20

	// Properties
	public HousePetSaleItemData PetSale { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x365EAF4 Offset: 0x365AAF4 VA: 0x365EAF4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x365EAFC Offset: 0x365AAFC VA: 0x365EAFC
	public HousePetSaleItemData get_PetSale() { }

	[CompilerGenerated]
	// RVA: 0x365EB04 Offset: 0x365AB04 VA: 0x365EB04
	public void set_PetSale(HousePetSaleItemData value) { }

	// RVA: 0x365EB0C Offset: 0x365AB0C VA: 0x365EB0C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x365EB14 Offset: 0x365AB14 VA: 0x365EB14 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x365EB1C Offset: 0x365AB1C VA: 0x365EB1C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x365EBA4 Offset: 0x365ABA4 VA: 0x365EBA4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
