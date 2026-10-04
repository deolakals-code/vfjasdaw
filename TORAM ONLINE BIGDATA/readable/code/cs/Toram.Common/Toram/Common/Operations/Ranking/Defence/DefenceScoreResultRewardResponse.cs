// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Ranking.Defence
public class DefenceScoreResultRewardResponse : OperationResponseBase // TypeDefIndex: 11459
{
	// Fields
	[CompilerGenerated]
	private DefenceRankingData <RankingData>k__BackingField; // 0x20
	[CompilerGenerated]
	private RewardResponseDatav2 <Reward>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <OldRank>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte <CurrentRank>k__BackingField; // 0x31

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }
	public DefenceRankingData RankingData { get; set; }
	public RewardResponseDatav2 Reward { get; set; }
	public byte OldRank { get; set; }
	public byte CurrentRank { get; set; }

	// Methods

	// RVA: 0x370D6E0 Offset: 0x37096E0 VA: 0x370D6E0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x370D6E8 Offset: 0x37096E8 VA: 0x370D6E8 Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x370D6F0 Offset: 0x37096F0 VA: 0x370D6F0
	public DefenceRankingData get_RankingData() { }

	[CompilerGenerated]
	// RVA: 0x370D6F8 Offset: 0x37096F8 VA: 0x370D6F8
	public void set_RankingData(DefenceRankingData value) { }

	[CompilerGenerated]
	// RVA: 0x370D700 Offset: 0x3709700 VA: 0x370D700
	public RewardResponseDatav2 get_Reward() { }

	[CompilerGenerated]
	// RVA: 0x370D708 Offset: 0x3709708 VA: 0x370D708
	public void set_Reward(RewardResponseDatav2 value) { }

	[CompilerGenerated]
	// RVA: 0x370D710 Offset: 0x3709710 VA: 0x370D710
	public byte get_OldRank() { }

	[CompilerGenerated]
	// RVA: 0x370D718 Offset: 0x3709718 VA: 0x370D718
	public void set_OldRank(byte value) { }

	[CompilerGenerated]
	// RVA: 0x370D720 Offset: 0x3709720 VA: 0x370D720
	public byte get_CurrentRank() { }

	[CompilerGenerated]
	// RVA: 0x370D728 Offset: 0x3709728 VA: 0x370D728
	public void set_CurrentRank(byte value) { }

	// RVA: 0x370D730 Offset: 0x3709730 VA: 0x370D730
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x370D738 Offset: 0x3709738 VA: 0x370D738 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x370DA60 Offset: 0x3709A60 VA: 0x370DA60 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
