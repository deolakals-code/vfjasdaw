// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Scenario.Quests
public class QuestCheckContinuousReward : OperationBase // TypeDefIndex: 11429
{
	// Fields
	[CompilerGenerated]
	private int <QuestId>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <RewardId>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <Count>k__BackingField; // 0x29
	[CompilerGenerated]
	private bool <IsStopMaxExp>k__BackingField; // 0x2A

	// Properties
	[PacketParameter(Code = 77)]
	public int QuestId { get; set; }
	[PacketParameter(Code = 122)]
	public byte RewardId { get; set; }
	[PacketParameter(Code = 21)]
	public byte Count { get; set; }
	[PacketParameter(Code = 43)]
	public bool IsStopMaxExp { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3707B44 Offset: 0x3703B44 VA: 0x3707B44
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3707B4C Offset: 0x3703B4C VA: 0x3707B4C
	public int get_QuestId() { }

	[CompilerGenerated]
	// RVA: 0x3707B54 Offset: 0x3703B54 VA: 0x3707B54
	public void set_QuestId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3707B5C Offset: 0x3703B5C VA: 0x3707B5C
	public byte get_RewardId() { }

	[CompilerGenerated]
	// RVA: 0x3707B64 Offset: 0x3703B64 VA: 0x3707B64
	public void set_RewardId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3707B6C Offset: 0x3703B6C VA: 0x3707B6C
	public byte get_Count() { }

	[CompilerGenerated]
	// RVA: 0x3707B74 Offset: 0x3703B74 VA: 0x3707B74
	public void set_Count(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3707B7C Offset: 0x3703B7C VA: 0x3707B7C
	public bool get_IsStopMaxExp() { }

	[CompilerGenerated]
	// RVA: 0x3707B84 Offset: 0x3703B84 VA: 0x3707B84
	public void set_IsStopMaxExp(bool value) { }

	// RVA: 0x3707B90 Offset: 0x3703B90 VA: 0x3707B90 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3707B98 Offset: 0x3703B98 VA: 0x3707B98 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3707CE0 Offset: 0x3703CE0 VA: 0x3707CE0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
