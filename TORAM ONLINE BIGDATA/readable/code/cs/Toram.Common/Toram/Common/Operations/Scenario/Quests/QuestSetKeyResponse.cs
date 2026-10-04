// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Scenario.Quests
public class QuestSetKeyResponse : OperationBase // TypeDefIndex: 11440
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <QuestId>k__BackingField; // 0x28
	[CompilerGenerated]
	private QuestKeyCommon <QuestKey>k__BackingField; // 0x30

	// Properties
	public override byte Code { get; }
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 77)]
	public int QuestId { get; set; }
	[PacketClass(Code = 124, IsOptional = True)]
	public QuestKeyCommon QuestKey { get; set; }

	// Methods

	// RVA: 0x370A5E0 Offset: 0x37065E0 VA: 0x370A5E0
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x370A5E8 Offset: 0x37065E8 VA: 0x370A5E8 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x370A5F0 Offset: 0x37065F0 VA: 0x370A5F0
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x370A5F8 Offset: 0x37065F8 VA: 0x370A5F8
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x370A600 Offset: 0x3706600 VA: 0x370A600
	public int get_QuestId() { }

	[CompilerGenerated]
	// RVA: 0x370A608 Offset: 0x3706608 VA: 0x370A608
	public void set_QuestId(int value) { }

	[CompilerGenerated]
	// RVA: 0x370A610 Offset: 0x3706610 VA: 0x370A610
	public QuestKeyCommon get_QuestKey() { }

	[CompilerGenerated]
	// RVA: 0x370A618 Offset: 0x3706618 VA: 0x370A618
	public void set_QuestKey(QuestKeyCommon value) { }

	// RVA: 0x370A620 Offset: 0x3706620 VA: 0x370A620
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x370A73C Offset: 0x370673C VA: 0x370A73C
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x370A7B8 Offset: 0x37067B8 VA: 0x370A7B8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x370A948 Offset: 0x3706948 VA: 0x370A948 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
