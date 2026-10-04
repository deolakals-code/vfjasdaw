// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Player
public class OffenderData : BinaryBase // TypeDefIndex: 11106
{
	// Fields
	[CompilerGenerated]
	private int <Id>k__BackingField; // 0x1C
	[CompilerGenerated]
	private int <Flag>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <Level>k__BackingField; // 0x24
	[CompilerGenerated]
	private DateTime <PrisonTime>k__BackingField; // 0x28
	[CompilerGenerated]
	private DateTime <AcquittalTime>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte <Prison>k__BackingField; // 0x38
	[CompilerGenerated]
	private byte <Acquittal>k__BackingField; // 0x39

	// Properties
	[BinaryParameter]
	public int Id { get; set; }
	[BinaryParameter]
	public int Flag { get; set; }
	[BinaryParameter]
	public byte Level { get; set; }
	[BinaryParameter]
	public DateTime PrisonTime { get; set; }
	[BinaryParameter]
	public DateTime AcquittalTime { get; set; }
	[BinaryParameter]
	public byte Prison { get; set; }
	[BinaryParameter]
	public byte Acquittal { get; set; }

	// Methods

	// RVA: 0x35BC084 Offset: 0x35B8084 VA: 0x35BC084
	public void .ctor() { }

	// RVA: 0x35BC08C Offset: 0x35B808C VA: 0x35BC08C
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x35BC094 Offset: 0x35B8094 VA: 0x35BC094
	public int get_Id() { }

	[CompilerGenerated]
	// RVA: 0x35BC09C Offset: 0x35B809C VA: 0x35BC09C
	protected void set_Id(int value) { }

	[CompilerGenerated]
	// RVA: 0x35BC0A4 Offset: 0x35B80A4 VA: 0x35BC0A4
	public int get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x35BC0AC Offset: 0x35B80AC VA: 0x35BC0AC
	protected void set_Flag(int value) { }

	[CompilerGenerated]
	// RVA: 0x35BC0B4 Offset: 0x35B80B4 VA: 0x35BC0B4
	public byte get_Level() { }

	[CompilerGenerated]
	// RVA: 0x35BC0BC Offset: 0x35B80BC VA: 0x35BC0BC
	protected void set_Level(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35BC0C4 Offset: 0x35B80C4 VA: 0x35BC0C4
	public DateTime get_PrisonTime() { }

	[CompilerGenerated]
	// RVA: 0x35BC0CC Offset: 0x35B80CC VA: 0x35BC0CC
	protected void set_PrisonTime(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x35BC0D4 Offset: 0x35B80D4 VA: 0x35BC0D4
	public DateTime get_AcquittalTime() { }

	[CompilerGenerated]
	// RVA: 0x35BC0DC Offset: 0x35B80DC VA: 0x35BC0DC
	protected void set_AcquittalTime(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x35BC0E4 Offset: 0x35B80E4 VA: 0x35BC0E4
	public byte get_Prison() { }

	[CompilerGenerated]
	// RVA: 0x35BC0EC Offset: 0x35B80EC VA: 0x35BC0EC
	protected void set_Prison(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35BC0F4 Offset: 0x35B80F4 VA: 0x35BC0F4
	public byte get_Acquittal() { }

	[CompilerGenerated]
	// RVA: 0x35BC0FC Offset: 0x35B80FC VA: 0x35BC0FC
	protected void set_Acquittal(byte value) { }

	// RVA: 0x35BC104 Offset: 0x35B8104 VA: 0x35BC104 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35BC2B4 Offset: 0x35B82B4 VA: 0x35BC2B4 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
