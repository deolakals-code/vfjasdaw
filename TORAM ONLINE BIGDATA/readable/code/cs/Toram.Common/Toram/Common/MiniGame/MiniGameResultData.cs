// Assembly: Toram.Common.dll
// Namespace: Toram.Common.MiniGame
public class MiniGameResultData : UnityHashBase // TypeDefIndex: 11162
{
	// Fields
	[CompilerGenerated]
	private byte <VictoryTeamNo>k__BackingField; // 0x19
	[CompilerGenerated]
	private MiniGameTeamResultData <TeamA>k__BackingField; // 0x20
	[CompilerGenerated]
	private MiniGameTeamResultData <TeamB>k__BackingField; // 0x28
	[CompilerGenerated]
	private long <ResultTime>k__BackingField; // 0x30
	[CompilerGenerated]
	private bool <IsReward>k__BackingField; // 0x38
	[CompilerGenerated]
	private RewardData[] <RewardData>k__BackingField; // 0x40
	[CompilerGenerated]
	private int <RewardPoint>k__BackingField; // 0x48

	// Properties
	public byte VictoryTeamNo { get; set; }
	public MiniGameTeamResultData TeamA { get; set; }
	public MiniGameTeamResultData TeamB { get; set; }
	public long ResultTime { get; set; }
	public bool IsReward { get; set; }
	public RewardData[] RewardData { get; set; }
	public int RewardPoint { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x35CD128 Offset: 0x35C9128 VA: 0x35CD128
	public void .ctor() { }

	// RVA: 0x35CD130 Offset: 0x35C9130 VA: 0x35CD130
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35CD138 Offset: 0x35C9138 VA: 0x35CD138
	public byte get_VictoryTeamNo() { }

	[CompilerGenerated]
	// RVA: 0x35CD140 Offset: 0x35C9140 VA: 0x35CD140
	public void set_VictoryTeamNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35CD148 Offset: 0x35C9148 VA: 0x35CD148
	public MiniGameTeamResultData get_TeamA() { }

	[CompilerGenerated]
	// RVA: 0x35CD150 Offset: 0x35C9150 VA: 0x35CD150
	public void set_TeamA(MiniGameTeamResultData value) { }

	[CompilerGenerated]
	// RVA: 0x35CD158 Offset: 0x35C9158 VA: 0x35CD158
	public MiniGameTeamResultData get_TeamB() { }

	[CompilerGenerated]
	// RVA: 0x35CD160 Offset: 0x35C9160 VA: 0x35CD160
	public void set_TeamB(MiniGameTeamResultData value) { }

	[CompilerGenerated]
	// RVA: 0x35CD168 Offset: 0x35C9168 VA: 0x35CD168
	public long get_ResultTime() { }

	[CompilerGenerated]
	// RVA: 0x35CD170 Offset: 0x35C9170 VA: 0x35CD170
	public void set_ResultTime(long value) { }

	[CompilerGenerated]
	// RVA: 0x35CD178 Offset: 0x35C9178 VA: 0x35CD178
	public bool get_IsReward() { }

	[CompilerGenerated]
	// RVA: 0x35CD180 Offset: 0x35C9180 VA: 0x35CD180
	public void set_IsReward(bool value) { }

	[CompilerGenerated]
	// RVA: 0x35CD18C Offset: 0x35C918C VA: 0x35CD18C
	public RewardData[] get_RewardData() { }

	[CompilerGenerated]
	// RVA: 0x35CD194 Offset: 0x35C9194 VA: 0x35CD194
	public void set_RewardData(RewardData[] value) { }

	[CompilerGenerated]
	// RVA: 0x35CD19C Offset: 0x35C919C VA: 0x35CD19C
	public int get_RewardPoint() { }

	[CompilerGenerated]
	// RVA: 0x35CD1A4 Offset: 0x35C91A4 VA: 0x35CD1A4
	public void set_RewardPoint(int value) { }

	// RVA: 0x35CD1AC Offset: 0x35C91AC VA: 0x35CD1AC
	private void SetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x35CD498 Offset: 0x35C9498 VA: 0x35CD498
	private void GetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x35CD600 Offset: 0x35C9600 VA: 0x35CD600 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35CD608 Offset: 0x35C9608 VA: 0x35CD608 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x35CD8F0 Offset: 0x35C98F0 VA: 0x35CD8F0 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
