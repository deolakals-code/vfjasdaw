// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Scenario.Quests
public class QuestGetDataResponse : PacketBase // TypeDefIndex: 11438
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private QuestCommon <QuestData>k__BackingField; // 0x28

	// Properties
	public override byte Code { get; }
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketClass(Code = 118, IsOptional = True)]
	public QuestCommon QuestData { get; set; }

	// Methods

	// RVA: 0x3709DCC Offset: 0x3705DCC VA: 0x3709DCC
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x3709DD4 Offset: 0x3705DD4 VA: 0x3709DD4 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x3709DDC Offset: 0x3705DDC VA: 0x3709DDC
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3709DE4 Offset: 0x3705DE4 VA: 0x3709DE4
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3709DEC Offset: 0x3705DEC VA: 0x3709DEC
	public QuestCommon get_QuestData() { }

	[CompilerGenerated]
	// RVA: 0x3709DF4 Offset: 0x3705DF4 VA: 0x3709DF4
	public void set_QuestData(QuestCommon value) { }

	// RVA: 0x3709DFC Offset: 0x3705DFC VA: 0x3709DFC
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3709F18 Offset: 0x3705F18 VA: 0x3709F18
	private void GetClass(Dictionary<byte, object> dictionary) { }

	// RVA: 0x3709F94 Offset: 0x3705F94 VA: 0x3709F94 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x370A0C4 Offset: 0x37060C4 VA: 0x370A0C4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
