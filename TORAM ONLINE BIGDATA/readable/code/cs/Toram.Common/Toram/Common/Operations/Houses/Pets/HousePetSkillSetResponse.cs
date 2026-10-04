// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Pets
public class HousePetSkillSetResponse : OperationResponseBase // TypeDefIndex: 12324
{
	// Fields
	[CompilerGenerated]
	private long <PetUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private PetSkillData <PetSkill>k__BackingField; // 0x28

	// Properties
	public long PetUuid { get; set; }
	public PetSkillData PetSkill { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35F387C Offset: 0x35EF87C VA: 0x35F387C
	public void .ctor() { }

	// RVA: 0x35F3884 Offset: 0x35EF884 VA: 0x35F3884
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35F388C Offset: 0x35EF88C VA: 0x35F388C
	public long get_PetUuid() { }

	[CompilerGenerated]
	// RVA: 0x35F3894 Offset: 0x35EF894 VA: 0x35F3894
	public void set_PetUuid(long value) { }

	[CompilerGenerated]
	// RVA: 0x35F389C Offset: 0x35EF89C VA: 0x35F389C
	public PetSkillData get_PetSkill() { }

	[CompilerGenerated]
	// RVA: 0x35F38A4 Offset: 0x35EF8A4 VA: 0x35F38A4
	public void set_PetSkill(PetSkillData value) { }

	// RVA: 0x35F38AC Offset: 0x35EF8AC VA: 0x35F38AC
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F39C8 Offset: 0x35EF9C8 VA: 0x35F39C8
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F3A44 Offset: 0x35EFA44 VA: 0x35F3A44 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35F3A4C Offset: 0x35EFA4C VA: 0x35F3A4C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35F3A54 Offset: 0x35EFA54 VA: 0x35F3A54 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F3B84 Offset: 0x35EFB84 VA: 0x35F3B84 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
