// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Pets
public class HouseTakePetResponse : OperationResponseBase // TypeDefIndex: 12333
{
	// Fields
	[CompilerGenerated]
	private PetInfoData <Pet>k__BackingField; // 0x20

	// Properties
	public PetInfoData Pet { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35F5980 Offset: 0x35F1980 VA: 0x35F5980
	public void .ctor() { }

	// RVA: 0x35F5988 Offset: 0x35F1988 VA: 0x35F5988
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35F5990 Offset: 0x35F1990 VA: 0x35F5990
	public PetInfoData get_Pet() { }

	[CompilerGenerated]
	// RVA: 0x35F5998 Offset: 0x35F1998 VA: 0x35F5998
	public void set_Pet(PetInfoData value) { }

	// RVA: 0x35F59A0 Offset: 0x35F19A0 VA: 0x35F59A0
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F5ABC Offset: 0x35F1ABC VA: 0x35F5ABC
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F5B38 Offset: 0x35F1B38 VA: 0x35F5B38 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35F5B40 Offset: 0x35F1B40 VA: 0x35F5B40 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35F5B48 Offset: 0x35F1B48 VA: 0x35F5B48 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F5BE0 Offset: 0x35F1BE0 VA: 0x35F5BE0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
