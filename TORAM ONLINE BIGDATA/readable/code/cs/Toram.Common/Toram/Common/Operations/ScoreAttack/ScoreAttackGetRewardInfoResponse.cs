// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.ScoreAttack
public class ScoreAttackGetRewardInfoResponse : OperationResponseBase // TypeDefIndex: 11728
{
	// Fields
	[CompilerGenerated]
	private ScoreAttackRewardData[] <RewardDatas>k__BackingField; // 0x20
	[CompilerGenerated]
	private ScoreAttackRankUpData[] <RankUpDatas>k__BackingField; // 0x28

	// Properties
	public ScoreAttackRewardData[] RewardDatas { get; set; }
	public ScoreAttackRankUpData[] RankUpDatas { get; set; }
	public int RankUpTotalPoint { get; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x373D4B4 Offset: 0x37394B4 VA: 0x373D4B4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x373D4BC Offset: 0x37394BC VA: 0x373D4BC
	public ScoreAttackRewardData[] get_RewardDatas() { }

	[CompilerGenerated]
	// RVA: 0x373D4C4 Offset: 0x37394C4 VA: 0x373D4C4
	public void set_RewardDatas(ScoreAttackRewardData[] value) { }

	[CompilerGenerated]
	// RVA: 0x373D4CC Offset: 0x37394CC VA: 0x373D4CC
	public ScoreAttackRankUpData[] get_RankUpDatas() { }

	[CompilerGenerated]
	// RVA: 0x373D4D4 Offset: 0x37394D4 VA: 0x373D4D4
	public void set_RankUpDatas(ScoreAttackRankUpData[] value) { }

	// RVA: 0x373D4DC Offset: 0x37394DC VA: 0x373D4DC
	public int get_RankUpTotalPoint() { }

	// RVA: 0x373D57C Offset: 0x373957C VA: 0x373D57C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x373D584 Offset: 0x3739584 VA: 0x373D584 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x373D58C Offset: 0x373958C VA: 0x373D58C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x373D678 Offset: 0x3739678 VA: 0x373D678 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
