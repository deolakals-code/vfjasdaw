// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Scenario.Quests
public class QuestCheckRewardResponse : OperationBase // TypeDefIndex: 11433
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <QuestId>k__BackingField; // 0x28
	[CompilerGenerated]
	private ScenarioRewardData[] <ScenarioRewards>k__BackingField; // 0x30
	[CompilerGenerated]
	private RewardResponseDatav2 <Reward>k__BackingField; // 0x38
	[CompilerGenerated]
	private RandomRewardData[] <RandomRewards>k__BackingField; // 0x40
	[CompilerGenerated]
	private QuestMobCommon[] <Mobs>k__BackingField; // 0x48

	// Properties
	public override byte Code { get; }
	public int AvatarUuid { get; set; }
	public int QuestId { get; set; }
	public ScenarioRewardData[] ScenarioRewards { get; set; }
	public RewardResponseDatav2 Reward { get; set; }
	public RandomRewardData[] RandomRewards { get; set; }
	public QuestMobCommon[] Mobs { get; set; }

	// Methods

	// RVA: 0x3708724 Offset: 0x3704724 VA: 0x3708724
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x370872C Offset: 0x370472C VA: 0x370872C Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x3708734 Offset: 0x3704734 VA: 0x3708734
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x370873C Offset: 0x370473C VA: 0x370873C
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3708744 Offset: 0x3704744 VA: 0x3708744
	public int get_QuestId() { }

	[CompilerGenerated]
	// RVA: 0x370874C Offset: 0x370474C VA: 0x370874C
	public void set_QuestId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3708754 Offset: 0x3704754 VA: 0x3708754
	public ScenarioRewardData[] get_ScenarioRewards() { }

	[CompilerGenerated]
	// RVA: 0x370875C Offset: 0x370475C VA: 0x370875C
	public void set_ScenarioRewards(ScenarioRewardData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3708764 Offset: 0x3704764 VA: 0x3708764
	public RewardResponseDatav2 get_Reward() { }

	[CompilerGenerated]
	// RVA: 0x370876C Offset: 0x370476C VA: 0x370876C
	public void set_Reward(RewardResponseDatav2 value) { }

	[CompilerGenerated]
	// RVA: 0x3708774 Offset: 0x3704774 VA: 0x3708774
	public RandomRewardData[] get_RandomRewards() { }

	[CompilerGenerated]
	// RVA: 0x370877C Offset: 0x370477C VA: 0x370877C
	public void set_RandomRewards(RandomRewardData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3708784 Offset: 0x3704784 VA: 0x3708784
	public QuestMobCommon[] get_Mobs() { }

	[CompilerGenerated]
	// RVA: 0x370878C Offset: 0x370478C VA: 0x370878C
	public void set_Mobs(QuestMobCommon[] value) { }

	// RVA: 0x3708794 Offset: 0x3704794 VA: 0x3708794 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3708BAC Offset: 0x3704BAC VA: 0x3708BAC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
