// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Scenario.Mission
public class MissionCheckRewardResponse : OperationBase // TypeDefIndex: 11414
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <MissionId>k__BackingField; // 0x28
	[CompilerGenerated]
	private ScenarioRewardData[] <ScenarioRewards>k__BackingField; // 0x30
	[CompilerGenerated]
	private RewardResponseDatav2 <Reward>k__BackingField; // 0x38
	[CompilerGenerated]
	private RandomRewardData[] <RandomRewards>k__BackingField; // 0x40

	// Properties
	public override byte Code { get; }
	public int AvatarUuid { get; set; }
	public int MissionId { get; set; }
	public ScenarioRewardData[] ScenarioRewards { get; set; }
	public RewardResponseDatav2 Reward { get; set; }
	public RandomRewardData[] RandomRewards { get; set; }

	// Methods

	// RVA: 0x37038D4 Offset: 0x36FF8D4 VA: 0x37038D4
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x37038DC Offset: 0x36FF8DC VA: 0x37038DC Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x37038E4 Offset: 0x36FF8E4 VA: 0x37038E4
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x37038EC Offset: 0x36FF8EC VA: 0x37038EC
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x37038F4 Offset: 0x36FF8F4 VA: 0x37038F4
	public int get_MissionId() { }

	[CompilerGenerated]
	// RVA: 0x37038FC Offset: 0x36FF8FC VA: 0x37038FC
	public void set_MissionId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3703904 Offset: 0x36FF904 VA: 0x3703904
	public ScenarioRewardData[] get_ScenarioRewards() { }

	[CompilerGenerated]
	// RVA: 0x370390C Offset: 0x36FF90C VA: 0x370390C
	public void set_ScenarioRewards(ScenarioRewardData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3703914 Offset: 0x36FF914 VA: 0x3703914
	public RewardResponseDatav2 get_Reward() { }

	[CompilerGenerated]
	// RVA: 0x370391C Offset: 0x36FF91C VA: 0x370391C
	public void set_Reward(RewardResponseDatav2 value) { }

	[CompilerGenerated]
	// RVA: 0x3703924 Offset: 0x36FF924 VA: 0x3703924
	public RandomRewardData[] get_RandomRewards() { }

	[CompilerGenerated]
	// RVA: 0x370392C Offset: 0x36FF92C VA: 0x370392C
	public void set_RandomRewards(RandomRewardData[] value) { }

	// RVA: 0x3703934 Offset: 0x36FF934 VA: 0x3703934 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3703CBC Offset: 0x36FFCBC VA: 0x3703CBC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
