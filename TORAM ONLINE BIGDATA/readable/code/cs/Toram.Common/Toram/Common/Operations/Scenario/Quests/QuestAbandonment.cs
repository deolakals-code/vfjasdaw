// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Scenario.Quests
public class QuestAbandonment : OperationBase // TypeDefIndex: 11430
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <QuestId>k__BackingField; // 0x28

	// Properties
	public override byte Code { get; }
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 77)]
	public int QuestId { get; set; }

	// Methods

	// RVA: 0x3707F10 Offset: 0x3703F10 VA: 0x3707F10
	public void .ctor() { }

	// RVA: 0x3707F18 Offset: 0x3703F18 VA: 0x3707F18 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x3707F20 Offset: 0x3703F20 VA: 0x3707F20
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3707F28 Offset: 0x3703F28 VA: 0x3707F28
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3707F30 Offset: 0x3703F30 VA: 0x3707F30
	public int get_QuestId() { }

	[CompilerGenerated]
	// RVA: 0x3707F38 Offset: 0x3703F38 VA: 0x3707F38
	public void set_QuestId(int value) { }

	// RVA: 0x3707F40 Offset: 0x3703F40 VA: 0x3707F40 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37080C0 Offset: 0x37040C0 VA: 0x37080C0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
