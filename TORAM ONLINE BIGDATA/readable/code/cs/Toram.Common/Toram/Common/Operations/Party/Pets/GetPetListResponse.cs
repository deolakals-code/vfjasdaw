// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Party.Pets
public class GetPetListResponse : OperationResponseBase // TypeDefIndex: 11498
{
	// Fields
	[CompilerGenerated]
	private PetData[] <SummonPets>k__BackingField; // 0x20

	// Properties
	public PetData[] SummonPets { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x37139E8 Offset: 0x370F9E8 VA: 0x37139E8
	public void .ctor() { }

	// RVA: 0x37139F0 Offset: 0x370F9F0 VA: 0x37139F0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x37139F8 Offset: 0x370F9F8 VA: 0x37139F8
	public PetData[] get_SummonPets() { }

	[CompilerGenerated]
	// RVA: 0x3713A00 Offset: 0x370FA00 VA: 0x3713A00
	public void set_SummonPets(PetData[] value) { }

	// RVA: 0x3713A08 Offset: 0x370FA08 VA: 0x3713A08
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3713B08 Offset: 0x370FB08 VA: 0x3713B08
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3713B94 Offset: 0x370FB94 VA: 0x3713B94 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3713B9C Offset: 0x370FB9C VA: 0x3713B9C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3713BA4 Offset: 0x370FBA4 VA: 0x3713BA4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3713C3C Offset: 0x370FC3C VA: 0x3713C3C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
