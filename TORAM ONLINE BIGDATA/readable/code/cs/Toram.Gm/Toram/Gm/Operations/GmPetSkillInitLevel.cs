// Assembly: Toram.Gm.dll
// Namespace: Toram.Gm.Operations
public class GmPetSkillInitLevel : OperationRequestBase // TypeDefIndex: 17622
{
	// Fields
	[CompilerGenerated]
	private long <PetUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <SkillNo>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <InitLevel>k__BackingField; // 0x29

	// Properties
	public long PetUuid { get; set; }
	public byte SkillNo { get; set; }
	public byte InitLevel { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x379965C Offset: 0x379565C VA: 0x379965C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3799664 Offset: 0x3795664 VA: 0x3799664
	public long get_PetUuid() { }

	[CompilerGenerated]
	// RVA: 0x379966C Offset: 0x379566C VA: 0x379966C
	public void set_PetUuid(long value) { }

	[CompilerGenerated]
	// RVA: 0x3799674 Offset: 0x3795674 VA: 0x3799674
	public byte get_SkillNo() { }

	[CompilerGenerated]
	// RVA: 0x379967C Offset: 0x379567C VA: 0x379967C
	public void set_SkillNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3799684 Offset: 0x3795684 VA: 0x3799684
	public byte get_InitLevel() { }

	[CompilerGenerated]
	// RVA: 0x379968C Offset: 0x379568C VA: 0x379968C
	public void set_InitLevel(byte value) { }

	// RVA: 0x3799694 Offset: 0x3795694 VA: 0x3799694 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x379969C Offset: 0x379569C VA: 0x379969C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37996A4 Offset: 0x37956A4 VA: 0x37996A4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3799868 Offset: 0x3795868 VA: 0x3799868 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
