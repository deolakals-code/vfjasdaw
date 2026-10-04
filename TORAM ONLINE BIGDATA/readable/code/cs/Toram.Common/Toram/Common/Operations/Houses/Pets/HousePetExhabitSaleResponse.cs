// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Pets
public class HousePetExhabitSaleResponse : OperationResponseBase // TypeDefIndex: 12296
{
	// Fields
	[CompilerGenerated]
	private HousePetSaleItemData <PetSale>k__BackingField; // 0x20
	[CompilerGenerated]
	private PetInfoData <PetInfo>k__BackingField; // 0x28

	// Properties
	public HousePetSaleItemData PetSale { get; set; }
	public PetInfoData PetInfo { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35EE390 Offset: 0x35EA390 VA: 0x35EE390
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35EE398 Offset: 0x35EA398 VA: 0x35EE398
	public HousePetSaleItemData get_PetSale() { }

	[CompilerGenerated]
	// RVA: 0x35EE3A0 Offset: 0x35EA3A0 VA: 0x35EE3A0
	public void set_PetSale(HousePetSaleItemData value) { }

	[CompilerGenerated]
	// RVA: 0x35EE3A8 Offset: 0x35EA3A8 VA: 0x35EE3A8
	public PetInfoData get_PetInfo() { }

	[CompilerGenerated]
	// RVA: 0x35EE3B0 Offset: 0x35EA3B0 VA: 0x35EE3B0
	public void set_PetInfo(PetInfoData value) { }

	// RVA: 0x35EE3B8 Offset: 0x35EA3B8 VA: 0x35EE3B8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35EE3C0 Offset: 0x35EA3C0 VA: 0x35EE3C0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35EE3C8 Offset: 0x35EA3C8 VA: 0x35EE3C8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35EE478 Offset: 0x35EA478 VA: 0x35EE478 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
