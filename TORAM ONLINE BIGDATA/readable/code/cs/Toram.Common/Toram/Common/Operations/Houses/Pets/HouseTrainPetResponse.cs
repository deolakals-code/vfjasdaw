// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Pets
public class HouseTrainPetResponse : OperationResponseBase // TypeDefIndex: 12337
{
	// Fields
	[CompilerGenerated]
	private long <PetUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <IsSuccess>k__BackingField; // 0x28
	[CompilerGenerated]
	private PetBreedStatusData <BreedStatus>k__BackingField; // 0x30
	[CompilerGenerated]
	private PetPotentialData <Potential>k__BackingField; // 0x38
	[CompilerGenerated]
	private PetSkillData <Skill>k__BackingField; // 0x40
	[CompilerGenerated]
	private int <Orb>k__BackingField; // 0x48
	[CompilerGenerated]
	private int <PaidOrb>k__BackingField; // 0x4C

	// Properties
	public long PetUuid { get; set; }
	public bool IsSuccess { get; set; }
	public PetBreedStatusData BreedStatus { get; set; }
	public PetPotentialData Potential { get; set; }
	public PetSkillData Skill { get; set; }
	public int Orb { get; set; }
	public int PaidOrb { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35F66B0 Offset: 0x35F26B0 VA: 0x35F66B0
	public void .ctor() { }

	// RVA: 0x35F66B8 Offset: 0x35F26B8 VA: 0x35F66B8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35F66C0 Offset: 0x35F26C0 VA: 0x35F66C0
	public long get_PetUuid() { }

	[CompilerGenerated]
	// RVA: 0x35F66C8 Offset: 0x35F26C8 VA: 0x35F66C8
	public void set_PetUuid(long value) { }

	[CompilerGenerated]
	// RVA: 0x35F66D0 Offset: 0x35F26D0 VA: 0x35F66D0
	public bool get_IsSuccess() { }

	[CompilerGenerated]
	// RVA: 0x35F66D8 Offset: 0x35F26D8 VA: 0x35F66D8
	public void set_IsSuccess(bool value) { }

	[CompilerGenerated]
	// RVA: 0x35F66E4 Offset: 0x35F26E4 VA: 0x35F66E4
	public PetBreedStatusData get_BreedStatus() { }

	[CompilerGenerated]
	// RVA: 0x35F66EC Offset: 0x35F26EC VA: 0x35F66EC
	public void set_BreedStatus(PetBreedStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x35F66F4 Offset: 0x35F26F4 VA: 0x35F66F4
	public PetPotentialData get_Potential() { }

	[CompilerGenerated]
	// RVA: 0x35F66FC Offset: 0x35F26FC VA: 0x35F66FC
	public void set_Potential(PetPotentialData value) { }

	[CompilerGenerated]
	// RVA: 0x35F6704 Offset: 0x35F2704 VA: 0x35F6704
	public PetSkillData get_Skill() { }

	[CompilerGenerated]
	// RVA: 0x35F670C Offset: 0x35F270C VA: 0x35F670C
	public void set_Skill(PetSkillData value) { }

	[CompilerGenerated]
	// RVA: 0x35F6714 Offset: 0x35F2714 VA: 0x35F6714
	public int get_Orb() { }

	[CompilerGenerated]
	// RVA: 0x35F671C Offset: 0x35F271C VA: 0x35F671C
	public void set_Orb(int value) { }

	[CompilerGenerated]
	// RVA: 0x35F6724 Offset: 0x35F2724 VA: 0x35F6724
	public int get_PaidOrb() { }

	[CompilerGenerated]
	// RVA: 0x35F672C Offset: 0x35F272C VA: 0x35F672C
	public void set_PaidOrb(int value) { }

	// RVA: 0x35F6734 Offset: 0x35F2734 VA: 0x35F6734
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F699C Offset: 0x35F299C VA: 0x35F699C
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F6A70 Offset: 0x35F2A70 VA: 0x35F6A70 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35F6A78 Offset: 0x35F2A78 VA: 0x35F6A78 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35F6A80 Offset: 0x35F2A80 VA: 0x35F6A80 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F6CD8 Offset: 0x35F2CD8 VA: 0x35F6CD8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
