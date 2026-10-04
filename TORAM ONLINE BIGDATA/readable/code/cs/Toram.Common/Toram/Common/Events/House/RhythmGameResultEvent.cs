// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.House
public class RhythmGameResultEvent : EventSubBase // TypeDefIndex: 12814
{
	// Fields
	[CompilerGenerated]
	private RhythmSettingData <Setting>k__BackingField; // 0x20
	[CompilerGenerated]
	private RhythmMemberData[] <Members>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <IsSuccess>k__BackingField; // 0x30
	[CompilerGenerated]
	private RhythmMemberScoreData[] <Scores>k__BackingField; // 0x38
	[CompilerGenerated]
	private RewardData <RewardData>k__BackingField; // 0x40
	[CompilerGenerated]
	private RewardResponseDatav2 <Reward>k__BackingField; // 0x48
	[CompilerGenerated]
	private RhythmRecordData <Record>k__BackingField; // 0x50

	// Properties
	public RhythmSettingData Setting { get; set; }
	public RhythmMemberData[] Members { get; set; }
	public bool IsSuccess { get; set; }
	public RhythmMemberScoreData[] Scores { get; set; }
	public RewardData RewardData { get; set; }
	public RewardResponseDatav2 Reward { get; set; }
	public RhythmRecordData Record { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x365F5D8 Offset: 0x365B5D8 VA: 0x365F5D8
	public void .ctor() { }

	// RVA: 0x365F5E0 Offset: 0x365B5E0 VA: 0x365F5E0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x365F5E8 Offset: 0x365B5E8 VA: 0x365F5E8
	public RhythmSettingData get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x365F5F0 Offset: 0x365B5F0 VA: 0x365F5F0
	public void set_Setting(RhythmSettingData value) { }

	[CompilerGenerated]
	// RVA: 0x365F5F8 Offset: 0x365B5F8 VA: 0x365F5F8
	public RhythmMemberData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x365F600 Offset: 0x365B600 VA: 0x365F600
	public void set_Members(RhythmMemberData[] value) { }

	[CompilerGenerated]
	// RVA: 0x365F608 Offset: 0x365B608 VA: 0x365F608
	public bool get_IsSuccess() { }

	[CompilerGenerated]
	// RVA: 0x365F610 Offset: 0x365B610 VA: 0x365F610
	public void set_IsSuccess(bool value) { }

	[CompilerGenerated]
	// RVA: 0x365F61C Offset: 0x365B61C VA: 0x365F61C
	public RhythmMemberScoreData[] get_Scores() { }

	[CompilerGenerated]
	// RVA: 0x365F624 Offset: 0x365B624 VA: 0x365F624
	public void set_Scores(RhythmMemberScoreData[] value) { }

	[CompilerGenerated]
	// RVA: 0x365F62C Offset: 0x365B62C VA: 0x365F62C
	public RewardData get_RewardData() { }

	[CompilerGenerated]
	// RVA: 0x365F634 Offset: 0x365B634 VA: 0x365F634
	public void set_RewardData(RewardData value) { }

	[CompilerGenerated]
	// RVA: 0x365F63C Offset: 0x365B63C VA: 0x365F63C
	public RewardResponseDatav2 get_Reward() { }

	[CompilerGenerated]
	// RVA: 0x365F644 Offset: 0x365B644 VA: 0x365F644
	public void set_Reward(RewardResponseDatav2 value) { }

	[CompilerGenerated]
	// RVA: 0x365F64C Offset: 0x365B64C VA: 0x365F64C
	public RhythmRecordData get_Record() { }

	[CompilerGenerated]
	// RVA: 0x365F654 Offset: 0x365B654 VA: 0x365F654
	public void set_Record(RhythmRecordData value) { }

	// RVA: 0x365F65C Offset: 0x365B65C VA: 0x365F65C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x365F664 Offset: 0x365B664 VA: 0x365F664 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x365F66C Offset: 0x365B66C VA: 0x365F66C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x365FBAC Offset: 0x365BBAC VA: 0x365FBAC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
