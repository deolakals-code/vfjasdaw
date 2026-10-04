// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Scenario.Quests
public class QuestStart : OperationBase // TypeDefIndex: 11441
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

	// RVA: 0x370AA1C Offset: 0x3706A1C VA: 0x370AA1C
	public void .ctor() { }

	// RVA: 0x370AA24 Offset: 0x3706A24 VA: 0x370AA24 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x370AA2C Offset: 0x3706A2C VA: 0x370AA2C
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x370AA34 Offset: 0x3706A34 VA: 0x370AA34
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x370AA3C Offset: 0x3706A3C VA: 0x370AA3C
	public int get_QuestId() { }

	[CompilerGenerated]
	// RVA: 0x370AA44 Offset: 0x3706A44 VA: 0x370AA44
	public void set_QuestId(int value) { }

	// RVA: 0x370AA4C Offset: 0x3706A4C VA: 0x370AA4C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x370ABCC Offset: 0x3706BCC VA: 0x370ABCC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
