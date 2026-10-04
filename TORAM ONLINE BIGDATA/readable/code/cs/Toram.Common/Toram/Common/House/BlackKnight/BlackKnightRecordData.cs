// Assembly: Toram.Common.dll
// Namespace: Toram.Common.House.BlackKnight
public class BlackKnightRecordData : BinaryBase // TypeDefIndex: 12552
{
	// Fields
	[CompilerGenerated]
	private byte <StageId>k__BackingField; // 0x19
	[CompilerGenerated]
	private byte <ClearFlag>k__BackingField; // 0x1A
	[CompilerGenerated]
	private int <Score>k__BackingField; // 0x1C
	[CompilerGenerated]
	private DateTime <BestTime>k__BackingField; // 0x20

	// Properties
	public byte StageId { get; set; }
	public byte ClearFlag { get; set; }
	public int Score { get; set; }
	public DateTime BestTime { get; set; }

	// Methods

	// RVA: 0x362077C Offset: 0x361C77C VA: 0x362077C
	public void .ctor() { }

	// RVA: 0x3620784 Offset: 0x361C784 VA: 0x3620784
	public void .ctor(byte stageId) { }

	[CompilerGenerated]
	// RVA: 0x3620808 Offset: 0x361C808 VA: 0x3620808
	public byte get_StageId() { }

	[CompilerGenerated]
	// RVA: 0x3620810 Offset: 0x361C810 VA: 0x3620810
	public void set_StageId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3620818 Offset: 0x361C818 VA: 0x3620818
	public byte get_ClearFlag() { }

	[CompilerGenerated]
	// RVA: 0x3620820 Offset: 0x361C820 VA: 0x3620820
	public void set_ClearFlag(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3620828 Offset: 0x361C828 VA: 0x3620828
	public int get_Score() { }

	[CompilerGenerated]
	// RVA: 0x3620830 Offset: 0x361C830 VA: 0x3620830
	public void set_Score(int value) { }

	[CompilerGenerated]
	// RVA: 0x3620838 Offset: 0x361C838 VA: 0x3620838
	public DateTime get_BestTime() { }

	[CompilerGenerated]
	// RVA: 0x3620840 Offset: 0x361C840 VA: 0x3620840
	public void set_BestTime(DateTime value) { }

	// RVA: 0x3620848 Offset: 0x361C848 VA: 0x3620848 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x36208F8 Offset: 0x361C8F8 VA: 0x36208F8 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
