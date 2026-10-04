// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Scenario.Mission
public class MissionSkipResponse : OperationBase // TypeDefIndex: 11425
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <MissionId>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <Gold>k__BackingField; // 0x2C
	[CompilerGenerated]
	private int <ScenarioProgress>k__BackingField; // 0x30
	[CompilerGenerated]
	private RewardResponseDatav2 <Reward>k__BackingField; // 0x38

	// Properties
	public override byte Code { get; }
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 154)]
	public int MissionId { get; set; }
	[PacketParameter(Code = 28)]
	public int Gold { get; set; }
	[PacketParameter(Code = 158)]
	public int ScenarioProgress { get; set; }
	public RewardResponseDatav2 Reward { get; set; }

	// Methods

	// RVA: 0x370654C Offset: 0x370254C VA: 0x370654C
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x3706554 Offset: 0x3702554 VA: 0x3706554 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x370655C Offset: 0x370255C VA: 0x370655C
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3706564 Offset: 0x3702564 VA: 0x3706564
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x370656C Offset: 0x370256C VA: 0x370656C
	public int get_MissionId() { }

	[CompilerGenerated]
	// RVA: 0x3706574 Offset: 0x3702574 VA: 0x3706574
	public void set_MissionId(int value) { }

	[CompilerGenerated]
	// RVA: 0x370657C Offset: 0x370257C VA: 0x370657C
	public int get_Gold() { }

	[CompilerGenerated]
	// RVA: 0x3706584 Offset: 0x3702584 VA: 0x3706584
	public void set_Gold(int value) { }

	[CompilerGenerated]
	// RVA: 0x370658C Offset: 0x370258C VA: 0x370658C
	public int get_ScenarioProgress() { }

	[CompilerGenerated]
	// RVA: 0x3706594 Offset: 0x3702594 VA: 0x3706594
	public void set_ScenarioProgress(int value) { }

	[CompilerGenerated]
	// RVA: 0x370659C Offset: 0x370259C VA: 0x370659C
	public RewardResponseDatav2 get_Reward() { }

	[CompilerGenerated]
	// RVA: 0x37065A4 Offset: 0x37025A4 VA: 0x37065A4
	public void set_Reward(RewardResponseDatav2 value) { }

	// RVA: 0x37065AC Offset: 0x37025AC VA: 0x37065AC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3706888 Offset: 0x3702888 VA: 0x3706888 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
