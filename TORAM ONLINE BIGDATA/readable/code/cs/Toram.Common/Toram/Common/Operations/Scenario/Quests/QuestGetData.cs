// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Scenario.Quests
public class QuestGetData : PacketBase // TypeDefIndex: 11437
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <QuestId>k__BackingField; // 0x24

	// Properties
	public override byte Code { get; }
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 77)]
	public int QuestId { get; set; }

	// Methods

	// RVA: 0x3709B34 Offset: 0x3705B34 VA: 0x3709B34
	public void .ctor() { }

	// RVA: 0x3709B3C Offset: 0x3705B3C VA: 0x3709B3C Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x3709B44 Offset: 0x3705B44 VA: 0x3709B44
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3709B4C Offset: 0x3705B4C VA: 0x3709B4C
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3709B54 Offset: 0x3705B54 VA: 0x3709B54
	public int get_QuestId() { }

	[CompilerGenerated]
	// RVA: 0x3709B5C Offset: 0x3705B5C VA: 0x3709B5C
	public void set_QuestId(int value) { }

	// RVA: 0x3709B64 Offset: 0x3705B64 VA: 0x3709B64 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3709CD0 Offset: 0x3705CD0 VA: 0x3709CD0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
