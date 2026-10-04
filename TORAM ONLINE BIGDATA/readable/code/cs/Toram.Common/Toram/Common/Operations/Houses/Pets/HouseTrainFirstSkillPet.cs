// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Pets
public class HouseTrainFirstSkillPet : OperationRequestBase // TypeDefIndex: 12334
{
	// Fields
	[CompilerGenerated]
	private long <PetUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <SelectSkillId>k__BackingField; // 0x28

	// Properties
	public long PetUuid { get; set; }
	public int SelectSkillId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35F5C14 Offset: 0x35F1C14 VA: 0x35F5C14
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35F5C1C Offset: 0x35F1C1C VA: 0x35F5C1C
	public long get_PetUuid() { }

	[CompilerGenerated]
	// RVA: 0x35F5C24 Offset: 0x35F1C24 VA: 0x35F5C24
	public void set_PetUuid(long value) { }

	[CompilerGenerated]
	// RVA: 0x35F5C2C Offset: 0x35F1C2C VA: 0x35F5C2C
	public int get_SelectSkillId() { }

	[CompilerGenerated]
	// RVA: 0x35F5C34 Offset: 0x35F1C34 VA: 0x35F5C34
	public void set_SelectSkillId(int value) { }

	// RVA: 0x35F5C3C Offset: 0x35F1C3C VA: 0x35F5C3C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35F5C44 Offset: 0x35F1C44 VA: 0x35F5C44 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35F5C4C Offset: 0x35F1C4C VA: 0x35F5C4C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F5DC4 Offset: 0x35F1DC4 VA: 0x35F5DC4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
