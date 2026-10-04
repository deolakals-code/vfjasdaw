// Assembly: Toram.Common.dll
// Namespace: Toram.Common.House.Rhythm
public class RhythmMemberScoreData : BinaryBase // TypeDefIndex: 12525
{
	// Fields
	[CompilerGenerated]
	private int <MemberId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private int <Score>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <Critical>k__BackingField; // 0x24
	[CompilerGenerated]
	private short <Hit>k__BackingField; // 0x26
	[CompilerGenerated]
	private short <Graze>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <Miss>k__BackingField; // 0x2A
	[CompilerGenerated]
	private byte <ClearState>k__BackingField; // 0x2C
	[CompilerGenerated]
	private int <TrueScore>k__BackingField; // 0x30

	// Properties
	public int MemberId { get; set; }
	public int Score { get; set; }
	public short Critical { get; set; }
	public short Hit { get; set; }
	public short Graze { get; set; }
	public short Miss { get; set; }
	public byte ClearState { get; set; }

	// Methods

	// RVA: 0x36180C0 Offset: 0x36140C0 VA: 0x36180C0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x36180C8 Offset: 0x36140C8 VA: 0x36180C8
	public int get_MemberId() { }

	[CompilerGenerated]
	// RVA: 0x36180D0 Offset: 0x36140D0 VA: 0x36180D0
	public void set_MemberId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36180D8 Offset: 0x36140D8 VA: 0x36180D8
	public int get_Score() { }

	[CompilerGenerated]
	// RVA: 0x36180E0 Offset: 0x36140E0 VA: 0x36180E0
	public void set_Score(int value) { }

	[CompilerGenerated]
	// RVA: 0x36180E8 Offset: 0x36140E8 VA: 0x36180E8
	public short get_Critical() { }

	[CompilerGenerated]
	// RVA: 0x36180F0 Offset: 0x36140F0 VA: 0x36180F0
	public void set_Critical(short value) { }

	[CompilerGenerated]
	// RVA: 0x36180F8 Offset: 0x36140F8 VA: 0x36180F8
	public short get_Hit() { }

	[CompilerGenerated]
	// RVA: 0x3618100 Offset: 0x3614100 VA: 0x3618100
	public void set_Hit(short value) { }

	[CompilerGenerated]
	// RVA: 0x3618108 Offset: 0x3614108 VA: 0x3618108
	public short get_Graze() { }

	[CompilerGenerated]
	// RVA: 0x3618110 Offset: 0x3614110 VA: 0x3618110
	public void set_Graze(short value) { }

	[CompilerGenerated]
	// RVA: 0x3618118 Offset: 0x3614118 VA: 0x3618118
	public short get_Miss() { }

	[CompilerGenerated]
	// RVA: 0x3618120 Offset: 0x3614120 VA: 0x3618120
	public void set_Miss(short value) { }

	[CompilerGenerated]
	// RVA: 0x3618128 Offset: 0x3614128 VA: 0x3618128
	public byte get_ClearState() { }

	[CompilerGenerated]
	// RVA: 0x3618130 Offset: 0x3614130 VA: 0x3618130
	public void set_ClearState(byte value) { }

	// RVA: 0x3618138 Offset: 0x3614138 VA: 0x3618138 Slot: 3
	public override string ToString() { }

	// RVA: 0x36183C0 Offset: 0x36143C0 VA: 0x36183C0 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x3618530 Offset: 0x3614530 VA: 0x3618530 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
