// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Trophies
public class TrophyData : BinaryBase // TypeDefIndex: 11069
{
	// Fields
	[CompilerGenerated]
	private int <TrophyId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private byte <Flag>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Value>k__BackingField; // 0x24

	// Properties
	[BinaryParameter]
	public int TrophyId { get; set; }
	[BinaryParameter]
	public byte Flag { get; set; }
	[BinaryParameter]
	public int Value { get; set; }

	// Methods

	// RVA: 0x35B244C Offset: 0x35AE44C VA: 0x35B244C
	public void .ctor() { }

	// RVA: 0x35B2454 Offset: 0x35AE454 VA: 0x35B2454
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x35B245C Offset: 0x35AE45C VA: 0x35B245C
	public int get_TrophyId() { }

	[CompilerGenerated]
	// RVA: 0x35B2464 Offset: 0x35AE464 VA: 0x35B2464
	protected void set_TrophyId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35B246C Offset: 0x35AE46C VA: 0x35B246C
	public byte get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x35B2474 Offset: 0x35AE474 VA: 0x35B2474
	protected void set_Flag(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35B247C Offset: 0x35AE47C VA: 0x35B247C
	public int get_Value() { }

	[CompilerGenerated]
	// RVA: 0x35B2484 Offset: 0x35AE484 VA: 0x35B2484
	protected void set_Value(int value) { }

	// RVA: 0x35B248C Offset: 0x35AE48C VA: 0x35B248C Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35B25AC Offset: 0x35AE5AC VA: 0x35B25AC Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
