// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Pets
public class HouseEntrustPetResponse : OperationResponseBase // TypeDefIndex: 12303
{
	// Fields
	[CompilerGenerated]
	private PetInfoData <Pet>k__BackingField; // 0x20

	// Properties
	public PetInfoData Pet { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35EF388 Offset: 0x35EB388 VA: 0x35EF388
	public void .ctor() { }

	// RVA: 0x35EF390 Offset: 0x35EB390 VA: 0x35EF390
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35EF398 Offset: 0x35EB398 VA: 0x35EF398
	public PetInfoData get_Pet() { }

	[CompilerGenerated]
	// RVA: 0x35EF3A0 Offset: 0x35EB3A0 VA: 0x35EF3A0
	public void set_Pet(PetInfoData value) { }

	// RVA: 0x35EF3A8 Offset: 0x35EB3A8 VA: 0x35EF3A8
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35EF4C4 Offset: 0x35EB4C4 VA: 0x35EF4C4
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35EF540 Offset: 0x35EB540 VA: 0x35EF540 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35EF548 Offset: 0x35EB548 VA: 0x35EF548 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35EF550 Offset: 0x35EB550 VA: 0x35EF550 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35EF5E8 Offset: 0x35EB5E8 VA: 0x35EF5E8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
