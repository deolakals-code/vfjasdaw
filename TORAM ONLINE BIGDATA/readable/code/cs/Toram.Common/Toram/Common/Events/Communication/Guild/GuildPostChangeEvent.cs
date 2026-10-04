// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Guild
public class GuildPostChangeEvent : PacketBase // TypeDefIndex: 12921
{
	// Fields
	[CompilerGenerated]
	private int <GuildId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <PostFlag>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 219)]
	public int GuildId { get; set; }
	[PacketParameter(Code = 96)]
	public int ArchetypeId { get; set; }
	[PacketParameter(Code = 43)]
	public byte PostFlag { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3678B60 Offset: 0x3674B60 VA: 0x3678B60
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3678B68 Offset: 0x3674B68 VA: 0x3678B68
	public int get_GuildId() { }

	[CompilerGenerated]
	// RVA: 0x3678B70 Offset: 0x3674B70 VA: 0x3678B70
	public void set_GuildId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3678B78 Offset: 0x3674B78 VA: 0x3678B78
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x3678B80 Offset: 0x3674B80 VA: 0x3678B80
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3678B88 Offset: 0x3674B88 VA: 0x3678B88
	public byte get_PostFlag() { }

	[CompilerGenerated]
	// RVA: 0x3678B90 Offset: 0x3674B90 VA: 0x3678B90
	public void set_PostFlag(byte value) { }

	// RVA: 0x3678B98 Offset: 0x3674B98 VA: 0x3678B98 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3678BA0 Offset: 0x3674BA0 VA: 0x3678BA0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3678D64 Offset: 0x3674D64 VA: 0x3678D64 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
