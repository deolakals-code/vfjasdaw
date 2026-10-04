// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Pets
public class HousePetBuyResponse : OperationResponseBase // TypeDefIndex: 12290
{
	// Fields
	[CompilerGenerated]
	private PetInfoData <Pet>k__BackingField; // 0x20
	[CompilerGenerated]
	private HousePetSaleItemData <PetSale>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <Gold>k__BackingField; // 0x30

	// Properties
	public PetInfoData Pet { get; set; }
	public HousePetSaleItemData PetSale { get; set; }
	public int Gold { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35ECE58 Offset: 0x35E8E58 VA: 0x35ECE58
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35ECE60 Offset: 0x35E8E60 VA: 0x35ECE60
	public PetInfoData get_Pet() { }

	[CompilerGenerated]
	// RVA: 0x35ECE68 Offset: 0x35E8E68 VA: 0x35ECE68
	public void set_Pet(PetInfoData value) { }

	[CompilerGenerated]
	// RVA: 0x35ECE70 Offset: 0x35E8E70 VA: 0x35ECE70
	public HousePetSaleItemData get_PetSale() { }

	[CompilerGenerated]
	// RVA: 0x35ECE78 Offset: 0x35E8E78 VA: 0x35ECE78
	public void set_PetSale(HousePetSaleItemData value) { }

	[CompilerGenerated]
	// RVA: 0x35ECE80 Offset: 0x35E8E80 VA: 0x35ECE80
	public int get_Gold() { }

	[CompilerGenerated]
	// RVA: 0x35ECE88 Offset: 0x35E8E88 VA: 0x35ECE88
	public void set_Gold(int value) { }

	// RVA: 0x35ECE90 Offset: 0x35E8E90 VA: 0x35ECE90 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35ECE98 Offset: 0x35E8E98 VA: 0x35ECE98 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35ECEA0 Offset: 0x35E8EA0 VA: 0x35ECEA0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35ECF94 Offset: 0x35E8F94 VA: 0x35ECF94 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
