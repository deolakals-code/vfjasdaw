// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Scenario.Quests
public class QuestCheckContinuousRewardResponse : OperationBase // TypeDefIndex: 11428
{
	// Fields
	[CompilerGenerated]
	private int <QuestId>k__BackingField; // 0x24
	[CompilerGenerated]
	private ScenarioRewardData[] <ScenarioRewards>k__BackingField; // 0x28
	[CompilerGenerated]
	private RewardResponseDatav2 <Reward>k__BackingField; // 0x30
	[CompilerGenerated]
	private RandomRewardData[] <RandomRewards>k__BackingField; // 0x38
	[CompilerGenerated]
	private QuestMobCommon[] <Mobs>k__BackingField; // 0x40
	[CompilerGenerated]
	private byte <EndCheckType>k__BackingField; // 0x48

	// Properties
	public int QuestId { get; set; }
	public ScenarioRewardData[] ScenarioRewards { get; set; }
	public RewardResponseDatav2 Reward { get; set; }
	public RandomRewardData[] RandomRewards { get; set; }
	public QuestMobCommon[] Mobs { get; set; }
	public byte EndCheckType { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x37074FC Offset: 0x37034FC VA: 0x37074FC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3707504 Offset: 0x3703504 VA: 0x3707504
	public int get_QuestId() { }

	[CompilerGenerated]
	// RVA: 0x370750C Offset: 0x370350C VA: 0x370750C
	public void set_QuestId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3707514 Offset: 0x3703514 VA: 0x3707514
	public ScenarioRewardData[] get_ScenarioRewards() { }

	[CompilerGenerated]
	// RVA: 0x370751C Offset: 0x370351C VA: 0x370751C
	public void set_ScenarioRewards(ScenarioRewardData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3707524 Offset: 0x3703524 VA: 0x3707524
	public RewardResponseDatav2 get_Reward() { }

	[CompilerGenerated]
	// RVA: 0x370752C Offset: 0x370352C VA: 0x370752C
	public void set_Reward(RewardResponseDatav2 value) { }

	[CompilerGenerated]
	// RVA: 0x3707534 Offset: 0x3703534 VA: 0x3707534
	public RandomRewardData[] get_RandomRewards() { }

	[CompilerGenerated]
	// RVA: 0x370753C Offset: 0x370353C VA: 0x370753C
	public void set_RandomRewards(RandomRewardData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3707544 Offset: 0x3703544 VA: 0x3707544
	public QuestMobCommon[] get_Mobs() { }

	[CompilerGenerated]
	// RVA: 0x370754C Offset: 0x370354C VA: 0x370754C
	public void set_Mobs(QuestMobCommon[] value) { }

	[CompilerGenerated]
	// RVA: 0x3707554 Offset: 0x3703554 VA: 0x3707554
	public byte get_EndCheckType() { }

	[CompilerGenerated]
	// RVA: 0x370755C Offset: 0x370355C VA: 0x370755C
	public void set_EndCheckType(byte value) { }

	// RVA: 0x3707564 Offset: 0x3703564 VA: 0x3707564 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x370756C Offset: 0x370356C VA: 0x370756C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3707718 Offset: 0x3703718 VA: 0x3707718 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
