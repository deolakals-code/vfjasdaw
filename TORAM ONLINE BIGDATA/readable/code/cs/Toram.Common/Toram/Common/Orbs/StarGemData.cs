// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Orbs
public class StarGemData : BinaryBase // TypeDefIndex: 11142
{
	// Fields
	[CompilerGenerated]
	private short <No>k__BackingField; // 0x1A
	[CompilerGenerated]
	private long <Uuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <SkillId>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <SkillLv>k__BackingField; // 0x2A
	[CompilerGenerated]
	private int <Flag>k__BackingField; // 0x2C
	[CompilerGenerated]
	private short <Max>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte <Use>k__BackingField; // 0x32

	// Properties
	[BinaryParameter]
	public short No { get; set; }
	[BinaryParameter]
	public long Uuid { get; set; }
	[BinaryParameter]
	public short SkillId { get; set; }
	[BinaryParameter]
	public byte SkillLv { get; set; }
	[BinaryParameter]
	public int Flag { get; set; }
	[BinaryParameter]
	public short Max { get; set; }
	[BinaryParameter]
	public byte Use { get; set; }

	// Methods

	// RVA: 0x35C8940 Offset: 0x35C4940 VA: 0x35C8940
	public void .ctor() { }

	// RVA: 0x35C8960 Offset: 0x35C4960 VA: 0x35C8960
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x35C8968 Offset: 0x35C4968 VA: 0x35C8968
	public short get_No() { }

	[CompilerGenerated]
	// RVA: 0x35C8970 Offset: 0x35C4970 VA: 0x35C8970
	protected void set_No(short value) { }

	[CompilerGenerated]
	// RVA: 0x35C8978 Offset: 0x35C4978 VA: 0x35C8978
	public long get_Uuid() { }

	[CompilerGenerated]
	// RVA: 0x35C8980 Offset: 0x35C4980 VA: 0x35C8980
	protected void set_Uuid(long value) { }

	[CompilerGenerated]
	// RVA: 0x35C8988 Offset: 0x35C4988 VA: 0x35C8988
	public short get_SkillId() { }

	[CompilerGenerated]
	// RVA: 0x35C8990 Offset: 0x35C4990 VA: 0x35C8990
	protected void set_SkillId(short value) { }

	[CompilerGenerated]
	// RVA: 0x35C8998 Offset: 0x35C4998 VA: 0x35C8998
	public byte get_SkillLv() { }

	[CompilerGenerated]
	// RVA: 0x35C89A0 Offset: 0x35C49A0 VA: 0x35C89A0
	protected void set_SkillLv(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35C89A8 Offset: 0x35C49A8 VA: 0x35C89A8
	public int get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x35C89B0 Offset: 0x35C49B0 VA: 0x35C89B0
	protected void set_Flag(int value) { }

	[CompilerGenerated]
	// RVA: 0x35C89B8 Offset: 0x35C49B8 VA: 0x35C89B8
	public short get_Max() { }

	[CompilerGenerated]
	// RVA: 0x35C89C0 Offset: 0x35C49C0 VA: 0x35C89C0
	protected void set_Max(short value) { }

	[CompilerGenerated]
	// RVA: 0x35C89C8 Offset: 0x35C49C8 VA: 0x35C89C8
	public byte get_Use() { }

	[CompilerGenerated]
	// RVA: 0x35C89D0 Offset: 0x35C49D0 VA: 0x35C89D0
	protected void set_Use(byte value) { }

	// RVA: 0x35C89D8 Offset: 0x35C49D8 VA: 0x35C89D8 Slot: 3
	public override string ToString() { }

	// RVA: 0x35C8C28 Offset: 0x35C4C28 VA: 0x35C8C28 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35C8D98 Offset: 0x35C4D98 VA: 0x35C8D98 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
