// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Trophy
public class GetTrophyProgressResponse : PacketBase // TypeDefIndex: 11410
{
	// Fields
	[CompilerGenerated]
	private TrophyProgressData[] <TrophyList>k__BackingField; // 0x20
	[CompilerGenerated]
	private TrophyProgressData[] <DailyList>k__BackingField; // 0x28
	[CompilerGenerated]
	private TrophyProgressData[] <WeeklyList>k__BackingField; // 0x30

	// Properties
	public TrophyProgressData[] TrophyList { get; set; }
	public TrophyProgressData[] DailyList { get; set; }
	public TrophyProgressData[] WeeklyList { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3702C54 Offset: 0x36FEC54 VA: 0x3702C54
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3702C5C Offset: 0x36FEC5C VA: 0x3702C5C
	public TrophyProgressData[] get_TrophyList() { }

	[CompilerGenerated]
	// RVA: 0x3702C64 Offset: 0x36FEC64 VA: 0x3702C64
	public void set_TrophyList(TrophyProgressData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3702C6C Offset: 0x36FEC6C VA: 0x3702C6C
	public TrophyProgressData[] get_DailyList() { }

	[CompilerGenerated]
	// RVA: 0x3702C74 Offset: 0x36FEC74 VA: 0x3702C74
	public void set_DailyList(TrophyProgressData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3702C7C Offset: 0x36FEC7C VA: 0x3702C7C
	public TrophyProgressData[] get_WeeklyList() { }

	[CompilerGenerated]
	// RVA: 0x3702C84 Offset: 0x36FEC84 VA: 0x3702C84
	public void set_WeeklyList(TrophyProgressData[] value) { }

	// RVA: 0x3702C8C Offset: 0x36FEC8C VA: 0x3702C8C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3702C94 Offset: 0x36FEC94 VA: 0x3702C94 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3702F2C Offset: 0x36FEF2C VA: 0x3702F2C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
