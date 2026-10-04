// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Pets
public class HouseTrainFirstSkillPetResponse : OperationResponseBase // TypeDefIndex: 12335
{
	// Fields
	[CompilerGenerated]
	private long <PetUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private PetBreedStatusData <BreedStatus>k__BackingField; // 0x28
	[CompilerGenerated]
	private PetSkillData <Skill>k__BackingField; // 0x30

	// Properties
	public long PetUuid { get; set; }
	public PetBreedStatusData BreedStatus { get; set; }
	public PetSkillData Skill { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35F5EA8 Offset: 0x35F1EA8 VA: 0x35F5EA8
	public void .ctor() { }

	// RVA: 0x35F5EB0 Offset: 0x35F1EB0 VA: 0x35F5EB0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35F5EB8 Offset: 0x35F1EB8 VA: 0x35F5EB8
	public long get_PetUuid() { }

	[CompilerGenerated]
	// RVA: 0x35F5EC0 Offset: 0x35F1EC0 VA: 0x35F5EC0
	public void set_PetUuid(long value) { }

	[CompilerGenerated]
	// RVA: 0x35F5EC8 Offset: 0x35F1EC8 VA: 0x35F5EC8
	public PetBreedStatusData get_BreedStatus() { }

	[CompilerGenerated]
	// RVA: 0x35F5ED0 Offset: 0x35F1ED0 VA: 0x35F5ED0
	public void set_BreedStatus(PetBreedStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x35F5ED8 Offset: 0x35F1ED8 VA: 0x35F5ED8
	public PetSkillData get_Skill() { }

	[CompilerGenerated]
	// RVA: 0x35F5EE0 Offset: 0x35F1EE0 VA: 0x35F5EE0
	public void set_Skill(PetSkillData value) { }

	// RVA: 0x35F5EE8 Offset: 0x35F1EE8 VA: 0x35F5EE8
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F60B4 Offset: 0x35F20B4 VA: 0x35F60B4
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F615C Offset: 0x35F215C VA: 0x35F615C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35F6164 Offset: 0x35F2164 VA: 0x35F6164 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35F616C Offset: 0x35F216C VA: 0x35F616C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F629C Offset: 0x35F229C VA: 0x35F629C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
