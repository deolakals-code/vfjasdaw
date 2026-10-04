// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Guild
public class GuildPointEvent : PacketBase // TypeDefIndex: 12920
{
	// Fields
	[CompilerGenerated]
	private int <GuildId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Point>k__BackingField; // 0x24

	// Properties
	public int GuildId { get; set; }
	public int Point { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36788C8 Offset: 0x36748C8 VA: 0x36788C8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36788D0 Offset: 0x36748D0 VA: 0x36788D0
	public int get_GuildId() { }

	[CompilerGenerated]
	// RVA: 0x36788D8 Offset: 0x36748D8 VA: 0x36788D8
	public void set_GuildId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36788E0 Offset: 0x36748E0 VA: 0x36788E0
	public int get_Point() { }

	[CompilerGenerated]
	// RVA: 0x36788E8 Offset: 0x36748E8 VA: 0x36788E8
	public void set_Point(int value) { }

	// RVA: 0x36788F0 Offset: 0x36748F0 VA: 0x36788F0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36788F8 Offset: 0x36748F8 VA: 0x36788F8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3678A64 Offset: 0x3674A64 VA: 0x3678A64 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
