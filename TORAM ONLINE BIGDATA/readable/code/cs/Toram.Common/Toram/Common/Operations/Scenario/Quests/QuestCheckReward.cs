// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Scenario.Quests
public class QuestCheckReward : OperationBase // TypeDefIndex: 11432
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <QuestId>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <RewardId>k__BackingField; // 0x2C

	// Properties
	public override byte Code { get; }
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 77)]
	public int QuestId { get; set; }
	[PacketParameter(Code = 122)]
	public byte RewardId { get; set; }

	// Methods

	// RVA: 0x3708400 Offset: 0x3704400 VA: 0x3708400
	public void .ctor() { }

	// RVA: 0x3708408 Offset: 0x3704408 VA: 0x3708408 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x3708410 Offset: 0x3704410 VA: 0x3708410
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3708418 Offset: 0x3704418 VA: 0x3708418
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3708420 Offset: 0x3704420 VA: 0x3708420
	public int get_QuestId() { }

	[CompilerGenerated]
	// RVA: 0x3708428 Offset: 0x3704428 VA: 0x3708428
	public void set_QuestId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3708430 Offset: 0x3704430 VA: 0x3708430
	public byte get_RewardId() { }

	[CompilerGenerated]
	// RVA: 0x3708438 Offset: 0x3704438 VA: 0x3708438
	public void set_RewardId(byte value) { }

	// RVA: 0x3708440 Offset: 0x3704440 VA: 0x3708440 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3708618 Offset: 0x3704618 VA: 0x3708618 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
