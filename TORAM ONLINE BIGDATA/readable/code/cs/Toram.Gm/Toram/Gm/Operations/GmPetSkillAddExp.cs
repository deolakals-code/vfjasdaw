// Assembly: Toram.Gm.dll
// Namespace: Toram.Gm.Operations
public class GmPetSkillAddExp : OperationRequestBase // TypeDefIndex: 17621
{
	// Fields
	[CompilerGenerated]
	private long <PetUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <SkillNo>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <Exp>k__BackingField; // 0x2C

	// Properties
	public long PetUuid { get; set; }
	public byte SkillNo { get; set; }
	public int Exp { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3799324 Offset: 0x3795324 VA: 0x3799324
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x379932C Offset: 0x379532C VA: 0x379932C
	public long get_PetUuid() { }

	[CompilerGenerated]
	// RVA: 0x3799334 Offset: 0x3795334 VA: 0x3799334
	public void set_PetUuid(long value) { }

	[CompilerGenerated]
	// RVA: 0x379933C Offset: 0x379533C VA: 0x379933C
	public byte get_SkillNo() { }

	[CompilerGenerated]
	// RVA: 0x3799344 Offset: 0x3795344 VA: 0x3799344
	public void set_SkillNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x379934C Offset: 0x379534C VA: 0x379934C
	public int get_Exp() { }

	[CompilerGenerated]
	// RVA: 0x3799354 Offset: 0x3795354 VA: 0x3799354
	public void set_Exp(int value) { }

	// RVA: 0x379935C Offset: 0x379535C VA: 0x379935C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3799364 Offset: 0x3795364 VA: 0x3799364 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x379936C Offset: 0x379536C VA: 0x379936C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x379953C Offset: 0x379553C VA: 0x379953C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
