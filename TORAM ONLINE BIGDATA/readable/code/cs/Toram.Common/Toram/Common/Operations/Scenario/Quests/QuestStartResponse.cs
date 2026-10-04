// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Scenario.Quests
public class QuestStartResponse : OperationBase // TypeDefIndex: 11442
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

	// RVA: 0x370AC94 Offset: 0x3706C94 VA: 0x370AC94
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x370AC9C Offset: 0x3706C9C VA: 0x370AC9C Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x370ACA4 Offset: 0x3706CA4 VA: 0x370ACA4
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x370ACAC Offset: 0x3706CAC VA: 0x370ACAC
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x370ACB4 Offset: 0x3706CB4 VA: 0x370ACB4
	public int get_QuestId() { }

	[CompilerGenerated]
	// RVA: 0x370ACBC Offset: 0x3706CBC VA: 0x370ACBC
	public void set_QuestId(int value) { }

	[CompilerGenerated]
	// RVA: 0x370ACC4 Offset: 0x3706CC4 VA: 0x370ACC4
	public QuestCommon get_QuestData() { }

	[CompilerGenerated]
	// RVA: 0x370ACCC Offset: 0x3706CCC VA: 0x370ACCC
	public void set_QuestData(QuestCommon value) { }

	// RVA: 0x370ACD4 Offset: 0x3706CD4 VA: 0x370ACD4
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x370ADF0 Offset: 0x3706DF0 VA: 0x370ADF0
	private void GetClass(Dictionary<byte, object> dictionary) { }

	// RVA: 0x370AE6C Offset: 0x3706E6C VA: 0x370AE6C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x370AFFC Offset: 0x3706FFC VA: 0x370AFFC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
