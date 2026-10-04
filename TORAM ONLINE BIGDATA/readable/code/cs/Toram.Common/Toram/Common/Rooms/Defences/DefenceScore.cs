// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Rooms.Defences
public class DefenceScore : UnityHashBase // TypeDefIndex: 11325
{
	// Fields
	[CompilerGenerated]
	private TimeSpan <GameTimeLeft>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <TotalScore>k__BackingField; // 0x28
	[CompilerGenerated]
	private Dictionary<byte, int> <BonusScoreList>k__BackingField; // 0x30

	// Properties
	[UnityHash(Code = 172, IsOptional = True)]
	public TimeSpan GameTimeLeft { get; set; }
	[UnityHash(Code = 195)]
	public int TotalScore { get; set; }
	[UnityHash(Code = 213, IsOptional = True)]
	public Dictionary<byte, int> BonusScoreList { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36EA340 Offset: 0x36E6340 VA: 0x36EA340
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36EA348 Offset: 0x36E6348 VA: 0x36EA348
	public TimeSpan get_GameTimeLeft() { }

	[CompilerGenerated]
	// RVA: 0x36EA350 Offset: 0x36E6350 VA: 0x36EA350
	public void set_GameTimeLeft(TimeSpan value) { }

	[CompilerGenerated]
	// RVA: 0x36EA358 Offset: 0x36E6358 VA: 0x36EA358
	public int get_TotalScore() { }

	[CompilerGenerated]
	// RVA: 0x36EA360 Offset: 0x36E6360 VA: 0x36EA360
	public void set_TotalScore(int value) { }

	[CompilerGenerated]
	// RVA: 0x36EA368 Offset: 0x36E6368 VA: 0x36EA368
	public Dictionary<byte, int> get_BonusScoreList() { }

	[CompilerGenerated]
	// RVA: 0x36EA370 Offset: 0x36E6370 VA: 0x36EA370
	public void set_BonusScoreList(Dictionary<byte, int> value) { }

	// RVA: 0x36EA378 Offset: 0x36E6378 VA: 0x36EA378 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36EA380 Offset: 0x36E6380 VA: 0x36EA380 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36EA64C Offset: 0x36E664C VA: 0x36EA64C Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
