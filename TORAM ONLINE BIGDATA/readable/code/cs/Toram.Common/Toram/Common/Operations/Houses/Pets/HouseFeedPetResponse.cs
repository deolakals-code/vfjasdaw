// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Pets
public class HouseFeedPetResponse : OperationResponseBase // TypeDefIndex: 12307
{
	// Fields
	[CompilerGenerated]
	private long <PetUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private PetBreedStatusData <BreedStatus>k__BackingField; // 0x28
	[CompilerGenerated]
	private PetStatusData <Status>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <Orb>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <PaidOrb>k__BackingField; // 0x3C
	[CompilerGenerated]
	private int <Gold>k__BackingField; // 0x40

	// Properties
	public long PetUuid { get; set; }
	public PetBreedStatusData BreedStatus { get; set; }
	public PetStatusData Status { get; set; }
	public int Orb { get; set; }
	public int PaidOrb { get; set; }
	public int Gold { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35EFFA4 Offset: 0x35EBFA4 VA: 0x35EFFA4
	public void .ctor() { }

	// RVA: 0x35EFFAC Offset: 0x35EBFAC VA: 0x35EFFAC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35EFFB4 Offset: 0x35EBFB4 VA: 0x35EFFB4
	public long get_PetUuid() { }

	[CompilerGenerated]
	// RVA: 0x35EFFBC Offset: 0x35EBFBC VA: 0x35EFFBC
	public void set_PetUuid(long value) { }

	[CompilerGenerated]
	// RVA: 0x35EFFC4 Offset: 0x35EBFC4 VA: 0x35EFFC4
	public PetBreedStatusData get_BreedStatus() { }

	[CompilerGenerated]
	// RVA: 0x35EFFCC Offset: 0x35EBFCC VA: 0x35EFFCC
	public void set_BreedStatus(PetBreedStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x35EFFD4 Offset: 0x35EBFD4 VA: 0x35EFFD4
	public PetStatusData get_Status() { }

	[CompilerGenerated]
	// RVA: 0x35EFFDC Offset: 0x35EBFDC VA: 0x35EFFDC
	public void set_Status(PetStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x35EFFE4 Offset: 0x35EBFE4 VA: 0x35EFFE4
	public int get_Orb() { }

	[CompilerGenerated]
	// RVA: 0x35EFFEC Offset: 0x35EBFEC VA: 0x35EFFEC
	public void set_Orb(int value) { }

	[CompilerGenerated]
	// RVA: 0x35EFFF4 Offset: 0x35EBFF4 VA: 0x35EFFF4
	public int get_PaidOrb() { }

	[CompilerGenerated]
	// RVA: 0x35EFFFC Offset: 0x35EBFFC VA: 0x35EFFFC
	public void set_PaidOrb(int value) { }

	[CompilerGenerated]
	// RVA: 0x35F0004 Offset: 0x35EC004 VA: 0x35F0004
	public int get_Gold() { }

	[CompilerGenerated]
	// RVA: 0x35F000C Offset: 0x35EC00C VA: 0x35F000C
	public void set_Gold(int value) { }

	// RVA: 0x35F0014 Offset: 0x35EC014 VA: 0x35F0014 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35F001C Offset: 0x35EC01C VA: 0x35F001C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35F0024 Offset: 0x35EC024 VA: 0x35F0024 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F03B4 Offset: 0x35EC3B4 VA: 0x35F03B4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
