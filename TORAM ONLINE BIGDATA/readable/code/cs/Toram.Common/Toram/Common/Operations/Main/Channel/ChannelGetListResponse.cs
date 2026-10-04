// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Channel
public class ChannelGetListResponse : PacketBase // TypeDefIndex: 12042
{
	// Fields
	[CompilerGenerated]
	private int <FieldId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <WorldType>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <WorldId>k__BackingField; // 0x28
	[CompilerGenerated]
	private Dictionary<byte, short> <ChannelList>k__BackingField; // 0x30

	// Properties
	[PacketParameter(Code = 60)]
	public int FieldId { get; set; }
	[PacketParameter(Code = 10)]
	public byte WorldType { get; set; }
	[PacketParameter(Code = 11)]
	public int WorldId { get; set; }
	[PacketParameter(Code = 178, IsOptional = True)]
	public Dictionary<byte, short> ChannelList { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x377C3F8 Offset: 0x37783F8 VA: 0x377C3F8
	public void .ctor() { }

	// RVA: 0x377C400 Offset: 0x3778400 VA: 0x377C400
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x377C408 Offset: 0x3778408 VA: 0x377C408
	public int get_FieldId() { }

	[CompilerGenerated]
	// RVA: 0x377C410 Offset: 0x3778410 VA: 0x377C410
	public void set_FieldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x377C418 Offset: 0x3778418 VA: 0x377C418
	public byte get_WorldType() { }

	[CompilerGenerated]
	// RVA: 0x377C420 Offset: 0x3778420 VA: 0x377C420
	public void set_WorldType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x377C428 Offset: 0x3778428 VA: 0x377C428
	public int get_WorldId() { }

	[CompilerGenerated]
	// RVA: 0x377C430 Offset: 0x3778430 VA: 0x377C430
	public void set_WorldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x377C438 Offset: 0x3778438 VA: 0x377C438
	public Dictionary<byte, short> get_ChannelList() { }

	[CompilerGenerated]
	// RVA: 0x377C440 Offset: 0x3778440 VA: 0x377C440
	public void set_ChannelList(Dictionary<byte, short> value) { }

	// RVA: 0x377C448 Offset: 0x3778448 VA: 0x377C448 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x377C450 Offset: 0x3778450 VA: 0x377C450 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x377C6B4 Offset: 0x37786B4 VA: 0x377C6B4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
