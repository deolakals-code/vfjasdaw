// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Ranking.Defence
public class DefenceScoreResultRankingResponse : OperationResponseBase // TypeDefIndex: 11457
{
	// Fields
	[CompilerGenerated]
	private DefenceRankingData <RankingData>k__BackingField; // 0x20
	[CompilerGenerated]
	private RewardData <Reward>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <OldRank>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte <CurrentRank>k__BackingField; // 0x31
	[CompilerGenerated]
	private bool <ReceivedReward>k__BackingField; // 0x32

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }
	[PacketParameter(Code = 199)]
	public DefenceRankingData RankingData { get; set; }
	[PacketParameter(Code = 123)]
	public RewardData Reward { get; set; }
	[PacketParameter(Code = 195)]
	public byte OldRank { get; set; }
	[PacketParameter(Code = 245)]
	public byte CurrentRank { get; set; }
	[PacketParameter(Code = 43)]
	public bool ReceivedReward { get; set; }

	// Methods

	// RVA: 0x370D100 Offset: 0x3709100 VA: 0x370D100 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x370D108 Offset: 0x3709108 VA: 0x370D108 Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x370D110 Offset: 0x3709110 VA: 0x370D110
	public DefenceRankingData get_RankingData() { }

	[CompilerGenerated]
	// RVA: 0x370D118 Offset: 0x3709118 VA: 0x370D118
	public void set_RankingData(DefenceRankingData value) { }

	[CompilerGenerated]
	// RVA: 0x370D120 Offset: 0x3709120 VA: 0x370D120
	public RewardData get_Reward() { }

	[CompilerGenerated]
	// RVA: 0x370D128 Offset: 0x3709128 VA: 0x370D128
	public void set_Reward(RewardData value) { }

	[CompilerGenerated]
	// RVA: 0x370D130 Offset: 0x3709130 VA: 0x370D130
	public byte get_OldRank() { }

	[CompilerGenerated]
	// RVA: 0x370D138 Offset: 0x3709138 VA: 0x370D138
	public void set_OldRank(byte value) { }

	[CompilerGenerated]
	// RVA: 0x370D140 Offset: 0x3709140 VA: 0x370D140
	public byte get_CurrentRank() { }

	[CompilerGenerated]
	// RVA: 0x370D148 Offset: 0x3709148 VA: 0x370D148
	public void set_CurrentRank(byte value) { }

	[CompilerGenerated]
	// RVA: 0x370D150 Offset: 0x3709150 VA: 0x370D150
	public bool get_ReceivedReward() { }

	[CompilerGenerated]
	// RVA: 0x370D158 Offset: 0x3709158 VA: 0x370D158
	public void set_ReceivedReward(bool value) { }

	// RVA: 0x370D164 Offset: 0x3709164 VA: 0x370D164
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x370D16C Offset: 0x370916C VA: 0x370D16C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x370D4F4 Offset: 0x37094F4 VA: 0x370D4F4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
