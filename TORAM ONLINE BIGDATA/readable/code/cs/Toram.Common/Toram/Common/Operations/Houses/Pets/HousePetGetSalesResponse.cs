// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Pets
public class HousePetGetSalesResponse : OperationResponseBase // TypeDefIndex: 12297
{
	// Fields
	[CompilerGenerated]
	private bool <IsSale>k__BackingField; // 0x20
	[CompilerGenerated]
	private HousePetSaleItemData[] <PetSaleList>k__BackingField; // 0x28

	// Properties
	public bool IsSale { get; set; }
	public HousePetSaleItemData[] PetSaleList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35EE698 Offset: 0x35EA698 VA: 0x35EE698
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35EE6A0 Offset: 0x35EA6A0 VA: 0x35EE6A0
	public bool get_IsSale() { }

	[CompilerGenerated]
	// RVA: 0x35EE6A8 Offset: 0x35EA6A8 VA: 0x35EE6A8
	public void set_IsSale(bool value) { }

	[CompilerGenerated]
	// RVA: 0x35EE6B4 Offset: 0x35EA6B4 VA: 0x35EE6B4
	public HousePetSaleItemData[] get_PetSaleList() { }

	[CompilerGenerated]
	// RVA: 0x35EE6BC Offset: 0x35EA6BC VA: 0x35EE6BC
	public void set_PetSaleList(HousePetSaleItemData[] value) { }

	// RVA: 0x35EE6C4 Offset: 0x35EA6C4 VA: 0x35EE6C4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35EE6CC Offset: 0x35EA6CC VA: 0x35EE6CC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35EE6D4 Offset: 0x35EA6D4 VA: 0x35EE6D4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35EE7B8 Offset: 0x35EA7B8 VA: 0x35EE7B8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
