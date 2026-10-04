// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Scenario.Quests
public class QuestSetKey : OperationBase // TypeDefIndex: 11439
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

	// RVA: 0x370A1A4 Offset: 0x37061A4 VA: 0x370A1A4
	public void .ctor() { }

	// RVA: 0x370A1AC Offset: 0x37061AC VA: 0x370A1AC Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x370A1B4 Offset: 0x37061B4 VA: 0x370A1B4
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x370A1BC Offset: 0x37061BC VA: 0x370A1BC
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x370A1C4 Offset: 0x37061C4 VA: 0x370A1C4
	public int get_QuestId() { }

	[CompilerGenerated]
	// RVA: 0x370A1CC Offset: 0x37061CC VA: 0x370A1CC
	public void set_QuestId(int value) { }

	[CompilerGenerated]
	// RVA: 0x370A1D4 Offset: 0x37061D4 VA: 0x370A1D4
	public QuestKeyCommon get_QuestKey() { }

	[CompilerGenerated]
	// RVA: 0x370A1DC Offset: 0x37061DC VA: 0x370A1DC
	public void set_QuestKey(QuestKeyCommon value) { }

	// RVA: 0x370A1E4 Offset: 0x37061E4 VA: 0x370A1E4
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x370A300 Offset: 0x3706300 VA: 0x370A300
	private void GetClass(Dictionary<byte, object> dictionary) { }

	// RVA: 0x370A37C Offset: 0x370637C VA: 0x370A37C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x370A50C Offset: 0x370650C VA: 0x370A50C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
