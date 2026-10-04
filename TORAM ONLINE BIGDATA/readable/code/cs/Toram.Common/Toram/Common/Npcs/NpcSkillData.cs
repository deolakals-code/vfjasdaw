// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Npcs
public class NpcSkillData : BinaryBase // TypeDefIndex: 11159
{
	// Fields
	[CompilerGenerated]
	private short <SkillId>k__BackingField; // 0x1A
	[CompilerGenerated]
	private byte <SkillLv>k__BackingField; // 0x1C
	[CompilerGenerated]
	private byte <MotionIndex>k__BackingField; // 0x1D

	// Properties
	[BinaryParameter]
	public short SkillId { get; set; }
	[BinaryParameter]
	public byte SkillLv { get; set; }
	[BinaryParameter]
	public byte MotionIndex { get; set; }

	// Methods

	// RVA: 0x35CBEAC Offset: 0x35C7EAC VA: 0x35CBEAC
	public void .ctor() { }

	// RVA: 0x35CBEB4 Offset: 0x35C7EB4 VA: 0x35CBEB4
	public void .ctor(short skillId, byte skillLv, byte motionIdx) { }

	[CompilerGenerated]
	// RVA: 0x35CBEF4 Offset: 0x35C7EF4 VA: 0x35CBEF4
	public short get_SkillId() { }

	[CompilerGenerated]
	// RVA: 0x35CBEFC Offset: 0x35C7EFC VA: 0x35CBEFC
	protected void set_SkillId(short value) { }

	[CompilerGenerated]
	// RVA: 0x35CBF04 Offset: 0x35C7F04 VA: 0x35CBF04
	public byte get_SkillLv() { }

	[CompilerGenerated]
	// RVA: 0x35CBF0C Offset: 0x35C7F0C VA: 0x35CBF0C
	protected void set_SkillLv(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35CBF14 Offset: 0x35C7F14 VA: 0x35CBF14
	public byte get_MotionIndex() { }

	[CompilerGenerated]
	// RVA: 0x35CBF1C Offset: 0x35C7F1C VA: 0x35CBF1C
	protected void set_MotionIndex(byte value) { }

	// RVA: 0x35CBF24 Offset: 0x35C7F24 VA: 0x35CBF24 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35CC044 Offset: 0x35C8044 VA: 0x35CC044 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
