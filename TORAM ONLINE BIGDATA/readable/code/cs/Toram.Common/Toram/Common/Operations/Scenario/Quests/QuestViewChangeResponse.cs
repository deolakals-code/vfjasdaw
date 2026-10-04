// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Scenario.Quests
public class QuestViewChangeResponse : OperationBase // TypeDefIndex: 11444
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <QuestId>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <KeySetting>k__BackingField; // 0x2C
	[CompilerGenerated]
	private short <ItemSetting>k__BackingField; // 0x2E
	[CompilerGenerated]
	private short <MobSetting>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte <QuestInfoNo>k__BackingField; // 0x32

	// Properties
	public override byte Code { get; }
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 77)]
	public int QuestId { get; set; }
	[PacketParameter(Code = 125, IsOptional = True)]
	public short KeySetting { get; set; }
	[PacketParameter(Code = 126, IsOptional = True)]
	public short ItemSetting { get; set; }
	[PacketParameter(Code = 127, IsOptional = True)]
	public short MobSetting { get; set; }
	[PacketParameter(Code = 128, IsOptional = True)]
	public byte QuestInfoNo { get; set; }

	// Methods

	// RVA: 0x370B6A8 Offset: 0x37076A8 VA: 0x370B6A8
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x370B6B0 Offset: 0x37076B0 VA: 0x370B6B0 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x370B6B8 Offset: 0x37076B8 VA: 0x370B6B8
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x370B6C0 Offset: 0x37076C0 VA: 0x370B6C0
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x370B6C8 Offset: 0x37076C8 VA: 0x370B6C8
	public int get_QuestId() { }

	[CompilerGenerated]
	// RVA: 0x370B6D0 Offset: 0x37076D0 VA: 0x370B6D0
	public void set_QuestId(int value) { }

	[CompilerGenerated]
	// RVA: 0x370B6D8 Offset: 0x37076D8 VA: 0x370B6D8
	public short get_KeySetting() { }

	[CompilerGenerated]
	// RVA: 0x370B6E0 Offset: 0x37076E0 VA: 0x370B6E0
	public void set_KeySetting(short value) { }

	[CompilerGenerated]
	// RVA: 0x370B6E8 Offset: 0x37076E8 VA: 0x370B6E8
	public short get_ItemSetting() { }

	[CompilerGenerated]
	// RVA: 0x370B6F0 Offset: 0x37076F0 VA: 0x370B6F0
	public void set_ItemSetting(short value) { }

	[CompilerGenerated]
	// RVA: 0x370B6F8 Offset: 0x37076F8 VA: 0x370B6F8
	public short get_MobSetting() { }

	[CompilerGenerated]
	// RVA: 0x370B700 Offset: 0x3707700 VA: 0x370B700
	public void set_MobSetting(short value) { }

	[CompilerGenerated]
	// RVA: 0x370B708 Offset: 0x3707708 VA: 0x370B708
	public byte get_QuestInfoNo() { }

	[CompilerGenerated]
	// RVA: 0x370B710 Offset: 0x3707710 VA: 0x370B710
	public void set_QuestInfoNo(byte value) { }

	// RVA: 0x370B718 Offset: 0x3707718 VA: 0x370B718 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x370BA54 Offset: 0x3707A54 VA: 0x370BA54 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
