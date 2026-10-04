// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Pets
public class HousePetOwnershipGet : OperationRequestBase // TypeDefIndex: 12320
{
	// Fields
	[CompilerGenerated]
	private PetSendData[] <Pets>k__BackingField; // 0x20

	// Properties
	public PetSendData[] Pets { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35F2EC4 Offset: 0x35EEEC4 VA: 0x35F2EC4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35F2ECC Offset: 0x35EEECC VA: 0x35F2ECC
	public PetSendData[] get_Pets() { }

	[CompilerGenerated]
	// RVA: 0x35F2ED4 Offset: 0x35EEED4 VA: 0x35F2ED4
	public void set_Pets(PetSendData[] value) { }

	// RVA: 0x35F2EDC Offset: 0x35EEEDC VA: 0x35F2EDC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35F2EE4 Offset: 0x35EEEE4 VA: 0x35F2EE4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35F2EEC Offset: 0x35EEEEC VA: 0x35F2EEC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F306C Offset: 0x35EF06C VA: 0x35F306C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
