// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events
public class SystemChatEvent : PacketBase // TypeDefIndex: 12611
{
	// Fields
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <UserName>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <ChannelType>k__BackingField; // 0x30
	[CompilerGenerated]
	private short <SystemMessageId>k__BackingField; // 0x32

	// Properties
	public int ArchetypeId { get; set; }
	public string UserName { get; set; }
	public byte ChannelType { get; set; }
	public short SystemMessageId { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x362FF64 Offset: 0x362BF64 VA: 0x362FF64
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x362FF6C Offset: 0x362BF6C VA: 0x362FF6C
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x362FF74 Offset: 0x362BF74 VA: 0x362FF74
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x362FF7C Offset: 0x362BF7C VA: 0x362FF7C
	public string get_UserName() { }

	[CompilerGenerated]
	// RVA: 0x362FF84 Offset: 0x362BF84 VA: 0x362FF84
	public void set_UserName(string value) { }

	[CompilerGenerated]
	// RVA: 0x362FF8C Offset: 0x362BF8C VA: 0x362FF8C
	public byte get_ChannelType() { }

	[CompilerGenerated]
	// RVA: 0x362FF94 Offset: 0x362BF94 VA: 0x362FF94
	public void set_ChannelType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x362FF9C Offset: 0x362BF9C VA: 0x362FF9C
	public short get_SystemMessageId() { }

	[CompilerGenerated]
	// RVA: 0x362FFA4 Offset: 0x362BFA4 VA: 0x362FFA4
	public void set_SystemMessageId(short value) { }

	// RVA: 0x362FFAC Offset: 0x362BFAC VA: 0x362FFAC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x362FFB4 Offset: 0x362BFB4 VA: 0x362FFB4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3630114 Offset: 0x362C114 VA: 0x3630114 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
