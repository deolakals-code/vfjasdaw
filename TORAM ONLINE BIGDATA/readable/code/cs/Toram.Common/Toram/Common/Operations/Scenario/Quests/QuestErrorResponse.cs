// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Scenario.Quests
public class QuestErrorResponse : OperationBase // TypeDefIndex: 11436
{
	// Fields
	private byte operationCode; // 0x21
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <QuestId>k__BackingField; // 0x28
	[CompilerGenerated]
	private QuestKeyCommon <QuestKey>k__BackingField; // 0x30
	[CompilerGenerated]
	private short <KeySetting>k__BackingField; // 0x38
	[CompilerGenerated]
	private short <ItemSetting>k__BackingField; // 0x3A
	[CompilerGenerated]
	private short <MobSetting>k__BackingField; // 0x3C
	[CompilerGenerated]
	private byte <QuestInfoNo>k__BackingField; // 0x3E

	// Properties
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 77)]
	public int QuestId { get; set; }
	[PacketClass(Code = 124, IsOptional = True)]
	public QuestKeyCommon QuestKey { get; set; }
	[PacketParameter(Code = 125, IsOptional = True)]
	public short KeySetting { get; set; }
	[PacketParameter(Code = 126, IsOptional = True)]
	public short ItemSetting { get; set; }
	[PacketParameter(Code = 127, IsOptional = True)]
	public short MobSetting { get; set; }
	[PacketParameter(Code = 128, IsOptional = True)]
	public byte QuestInfoNo { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x37093F8 Offset: 0x37053F8 VA: 0x37093F8
	public void .ctor(byte operationCode, Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3709424 Offset: 0x3705424 VA: 0x3709424
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x370942C Offset: 0x370542C VA: 0x370942C
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3709434 Offset: 0x3705434 VA: 0x3709434
	public int get_QuestId() { }

	[CompilerGenerated]
	// RVA: 0x370943C Offset: 0x370543C VA: 0x370943C
	public void set_QuestId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3709444 Offset: 0x3705444 VA: 0x3709444
	public QuestKeyCommon get_QuestKey() { }

	[CompilerGenerated]
	// RVA: 0x370944C Offset: 0x370544C VA: 0x370944C
	public void set_QuestKey(QuestKeyCommon value) { }

	[CompilerGenerated]
	// RVA: 0x3709454 Offset: 0x3705454 VA: 0x3709454
	public short get_KeySetting() { }

	[CompilerGenerated]
	// RVA: 0x370945C Offset: 0x370545C VA: 0x370945C
	public void set_KeySetting(short value) { }

	[CompilerGenerated]
	// RVA: 0x3709464 Offset: 0x3705464 VA: 0x3709464
	public short get_ItemSetting() { }

	[CompilerGenerated]
	// RVA: 0x370946C Offset: 0x370546C VA: 0x370946C
	public void set_ItemSetting(short value) { }

	[CompilerGenerated]
	// RVA: 0x3709474 Offset: 0x3705474 VA: 0x3709474
	public short get_MobSetting() { }

	[CompilerGenerated]
	// RVA: 0x370947C Offset: 0x370547C VA: 0x370947C
	public void set_MobSetting(short value) { }

	[CompilerGenerated]
	// RVA: 0x3709484 Offset: 0x3705484 VA: 0x3709484
	public byte get_QuestInfoNo() { }

	[CompilerGenerated]
	// RVA: 0x370948C Offset: 0x370548C VA: 0x370948C
	public void set_QuestInfoNo(byte value) { }

	// RVA: 0x3709494 Offset: 0x3705494 VA: 0x3709494
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x37095B0 Offset: 0x37055B0 VA: 0x37095B0
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x370962C Offset: 0x370562C VA: 0x370962C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3709634 Offset: 0x3705634 VA: 0x3709634 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3709980 Offset: 0x3705980 VA: 0x3709980 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
