// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Pets
public class HouseEntrustPet : OperationRequestBase // TypeDefIndex: 12302
{
	// Fields
	[CompilerGenerated]
	private long <PetUuid>k__BackingField; // 0x20

	// Properties
	public long PetUuid { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35EF1A0 Offset: 0x35EB1A0 VA: 0x35EF1A0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35EF1A8 Offset: 0x35EB1A8 VA: 0x35EF1A8
	public long get_PetUuid() { }

	[CompilerGenerated]
	// RVA: 0x35EF1B0 Offset: 0x35EB1B0 VA: 0x35EF1B0
	public void set_PetUuid(long value) { }

	// RVA: 0x35EF1B8 Offset: 0x35EB1B8 VA: 0x35EF1B8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35EF1C0 Offset: 0x35EB1C0 VA: 0x35EF1C0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35EF1C8 Offset: 0x35EB1C8 VA: 0x35EF1C8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35EF2E8 Offset: 0x35EB2E8 VA: 0x35EF2E8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
