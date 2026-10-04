// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Scenario.Quests
public class QuestViewChange : OperationBase // TypeDefIndex: 11443
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <QuestId>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <Flag>k__BackingField; // 0x2C
	[CompilerGenerated]
	private short <KeySetting>k__BackingField; // 0x2E
	[CompilerGenerated]
	private short <ItemSetting>k__BackingField; // 0x30
	[CompilerGenerated]
	private short <MobSetting>k__BackingField; // 0x32
	[CompilerGenerated]
	private byte <QuestInfoNo>k__BackingField; // 0x34

	// Properties
	public override byte Code { get; }
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 77)]
	public int QuestId { get; set; }
	[PacketParameter(Code = 43)]
	public byte Flag { get; set; }
	[PacketParameter(Code = 125, IsOptional = True)]
	public short KeySetting { get; set; }
	[PacketParameter(Code = 126, IsOptional = True)]
	public short ItemSetting { get; set; }
	[PacketParameter(Code = 127, IsOptional = True)]
	public short MobSetting { get; set; }
	[PacketParameter(Code = 128, IsOptional = True)]
	public byte QuestInfoNo { get; set; }

	// Methods

	// RVA: 0x370B0D0 Offset: 0x37070D0 VA: 0x370B0D0
	public void .ctor() { }

	// RVA: 0x370B0D8 Offset: 0x37070D8 VA: 0x370B0D8 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x370B0E0 Offset: 0x37070E0 VA: 0x370B0E0
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x370B0E8 Offset: 0x37070E8 VA: 0x370B0E8
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x370B0F0 Offset: 0x37070F0 VA: 0x370B0F0
	public int get_QuestId() { }

	[CompilerGenerated]
	// RVA: 0x370B0F8 Offset: 0x37070F8 VA: 0x370B0F8
	public void set_QuestId(int value) { }

	[CompilerGenerated]
	// RVA: 0x370B100 Offset: 0x3707100 VA: 0x370B100
	public byte get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x370B108 Offset: 0x3707108 VA: 0x370B108
	public void set_Flag(byte value) { }

	[CompilerGenerated]
	// RVA: 0x370B110 Offset: 0x3707110 VA: 0x370B110
	public short get_KeySetting() { }

	[CompilerGenerated]
	// RVA: 0x370B118 Offset: 0x3707118 VA: 0x370B118
	public void set_KeySetting(short value) { }

	[CompilerGenerated]
	// RVA: 0x370B120 Offset: 0x3707120 VA: 0x370B120
	public short get_ItemSetting() { }

	[CompilerGenerated]
	// RVA: 0x370B128 Offset: 0x3707128 VA: 0x370B128
	public void set_ItemSetting(short value) { }

	[CompilerGenerated]
	// RVA: 0x370B130 Offset: 0x3707130 VA: 0x370B130
	public short get_MobSetting() { }

	[CompilerGenerated]
	// RVA: 0x370B138 Offset: 0x3707138 VA: 0x370B138
	public void set_MobSetting(short value) { }

	[CompilerGenerated]
	// RVA: 0x370B140 Offset: 0x3707140 VA: 0x370B140
	public byte get_QuestInfoNo() { }

	[CompilerGenerated]
	// RVA: 0x370B148 Offset: 0x3707148 VA: 0x370B148
	public void set_QuestInfoNo(byte value) { }

	// RVA: 0x370B150 Offset: 0x3707150 VA: 0x370B150 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x370B4D0 Offset: 0x37074D0 VA: 0x370B4D0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
