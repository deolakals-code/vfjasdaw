// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Pets
public class HousePetStopSaleResponse : OperationResponseBase // TypeDefIndex: 12300
{
	// Fields
	[CompilerGenerated]
	private HousePetSaleData <PetSale>k__BackingField; // 0x20

	// Properties
	public HousePetSaleData PetSale { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35EED1C Offset: 0x35EAD1C VA: 0x35EED1C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35EED24 Offset: 0x35EAD24 VA: 0x35EED24
	public HousePetSaleData get_PetSale() { }

	[CompilerGenerated]
	// RVA: 0x35EED2C Offset: 0x35EAD2C VA: 0x35EED2C
	public void set_PetSale(HousePetSaleData value) { }

	// RVA: 0x35EED34 Offset: 0x35EAD34 VA: 0x35EED34 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35EED3C Offset: 0x35EAD3C VA: 0x35EED3C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35EED44 Offset: 0x35EAD44 VA: 0x35EED44 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35EEDCC Offset: 0x35EADCC VA: 0x35EEDCC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
