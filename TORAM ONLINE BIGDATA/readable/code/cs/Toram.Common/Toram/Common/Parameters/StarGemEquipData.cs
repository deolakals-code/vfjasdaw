// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Parameters
public class StarGemEquipData : BinaryBase // TypeDefIndex: 11132
{
	// Fields
	[CompilerGenerated]
	private byte <EquipNo>k__BackingField; // 0x19
	[CompilerGenerated]
	private long <GemUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <SkillId>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <SkillLv>k__BackingField; // 0x2A
	[CompilerGenerated]
	private int <Flag>k__BackingField; // 0x2C

	// Properties
	public byte EquipNo { get; set; }
	public long GemUuid { get; set; }
	public short SkillId { get; set; }
	public byte SkillLv { get; set; }
	public int Flag { get; set; }

	// Methods

	// RVA: 0x35C5B1C Offset: 0x35C1B1C VA: 0x35C5B1C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35C5B24 Offset: 0x35C1B24 VA: 0x35C5B24
	public byte get_EquipNo() { }

	[CompilerGenerated]
	// RVA: 0x35C5B2C Offset: 0x35C1B2C VA: 0x35C5B2C
	public void set_EquipNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35C5B34 Offset: 0x35C1B34 VA: 0x35C5B34
	public long get_GemUuid() { }

	[CompilerGenerated]
	// RVA: 0x35C5B3C Offset: 0x35C1B3C VA: 0x35C5B3C
	public void set_GemUuid(long value) { }

	[CompilerGenerated]
	// RVA: 0x35C5B44 Offset: 0x35C1B44 VA: 0x35C5B44
	public short get_SkillId() { }

	[CompilerGenerated]
	// RVA: 0x35C5B4C Offset: 0x35C1B4C VA: 0x35C5B4C
	public void set_SkillId(short value) { }

	[CompilerGenerated]
	// RVA: 0x35C5B54 Offset: 0x35C1B54 VA: 0x35C5B54
	public byte get_SkillLv() { }

	[CompilerGenerated]
	// RVA: 0x35C5B5C Offset: 0x35C1B5C VA: 0x35C5B5C
	public void set_SkillLv(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35C5B64 Offset: 0x35C1B64 VA: 0x35C5B64
	public int get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x35C5B6C Offset: 0x35C1B6C VA: 0x35C5B6C
	public void set_Flag(int value) { }

	// RVA: 0x35C5B74 Offset: 0x35C1B74 VA: 0x35C5B74 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35C5CBC Offset: 0x35C1CBC VA: 0x35C5CBC Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
