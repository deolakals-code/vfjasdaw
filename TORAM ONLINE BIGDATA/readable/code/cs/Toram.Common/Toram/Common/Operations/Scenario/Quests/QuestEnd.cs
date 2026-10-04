// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Scenario.Quests
public class QuestEnd : OperationBase // TypeDefIndex: 11434
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

	// RVA: 0x3708D44 Offset: 0x3704D44 VA: 0x3708D44
	public void .ctor() { }

	// RVA: 0x3708D4C Offset: 0x3704D4C VA: 0x3708D4C Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x3708D54 Offset: 0x3704D54 VA: 0x3708D54
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3708D5C Offset: 0x3704D5C VA: 0x3708D5C
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3708D64 Offset: 0x3704D64 VA: 0x3708D64
	public int get_QuestId() { }

	[CompilerGenerated]
	// RVA: 0x3708D6C Offset: 0x3704D6C VA: 0x3708D6C
	public void set_QuestId(int value) { }

	// RVA: 0x3708D74 Offset: 0x3704D74 VA: 0x3708D74 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3708EF4 Offset: 0x3704EF4 VA: 0x3708EF4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
