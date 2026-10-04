// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Pets
public class HousePetCancelExhabitSaleResponse : OperationResponseBase // TypeDefIndex: 12292
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

	// RVA: 0x35ED3C8 Offset: 0x35E93C8 VA: 0x35ED3C8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35ED3D0 Offset: 0x35E93D0 VA: 0x35ED3D0
	public HousePetSaleItemData get_PetSale() { }

	[CompilerGenerated]
	// RVA: 0x35ED3D8 Offset: 0x35E93D8 VA: 0x35ED3D8
	public void set_PetSale(HousePetSaleItemData value) { }

	[CompilerGenerated]
	// RVA: 0x35ED3E0 Offset: 0x35E93E0 VA: 0x35ED3E0
	public PetInfoData get_PetInfo() { }

	[CompilerGenerated]
	// RVA: 0x35ED3E8 Offset: 0x35E93E8 VA: 0x35ED3E8
	public void set_PetInfo(PetInfoData value) { }

	// RVA: 0x35ED3F0 Offset: 0x35E93F0 VA: 0x35ED3F0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35ED3F8 Offset: 0x35E93F8 VA: 0x35ED3F8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35ED400 Offset: 0x35E9400 VA: 0x35ED400 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35ED4B0 Offset: 0x35E94B0 VA: 0x35ED4B0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
