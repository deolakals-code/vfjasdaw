// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Scenario.Quests
public class QuestEndResponse : OperationBase // TypeDefIndex: 11435
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <QuestId>k__BackingField; // 0x28
	[CompilerGenerated]
	private QuestCommon <QuestData>k__BackingField; // 0x30

	// Properties
	public override byte Code { get; }
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 77)]
	public int QuestId { get; set; }
	[PacketClass(Code = 118, IsOptional = True)]
	public QuestCommon QuestData { get; set; }

	// Methods

	// RVA: 0x3708FBC Offset: 0x3704FBC VA: 0x3708FBC
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x3708FC4 Offset: 0x3704FC4 VA: 0x3708FC4 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x3708FCC Offset: 0x3704FCC VA: 0x3708FCC
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3708FD4 Offset: 0x3704FD4 VA: 0x3708FD4
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3708FDC Offset: 0x3704FDC VA: 0x3708FDC
	public int get_QuestId() { }

	[CompilerGenerated]
	// RVA: 0x3708FE4 Offset: 0x3704FE4 VA: 0x3708FE4
	public void set_QuestId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3708FEC Offset: 0x3704FEC VA: 0x3708FEC
	public QuestCommon get_QuestData() { }

	[CompilerGenerated]
	// RVA: 0x3708FF4 Offset: 0x3704FF4 VA: 0x3708FF4
	public void set_QuestData(QuestCommon value) { }

	// RVA: 0x3708FFC Offset: 0x3704FFC VA: 0x3708FFC
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3709118 Offset: 0x3705118 VA: 0x3709118
	private void GetClass(Dictionary<byte, object> dictionary) { }

	// RVA: 0x3709194 Offset: 0x3705194 VA: 0x3709194 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3709324 Offset: 0x3705324 VA: 0x3709324 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
