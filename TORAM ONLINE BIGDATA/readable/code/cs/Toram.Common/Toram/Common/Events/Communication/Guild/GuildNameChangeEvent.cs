// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Guild
public class GuildNameChangeEvent : PacketBase // TypeDefIndex: 12919
{
	// Fields
	[CompilerGenerated]
	private int <GuildId>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <GuildName>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 219)]
	public int GuildId { get; set; }
	[PacketParameter(Code = 220)]
	public string GuildName { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3678638 Offset: 0x3674638 VA: 0x3678638
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3678640 Offset: 0x3674640 VA: 0x3678640
	public int get_GuildId() { }

	[CompilerGenerated]
	// RVA: 0x3678648 Offset: 0x3674648 VA: 0x3678648
	public void set_GuildId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3678650 Offset: 0x3674650 VA: 0x3678650
	public string get_GuildName() { }

	[CompilerGenerated]
	// RVA: 0x3678658 Offset: 0x3674658 VA: 0x3678658
	public void set_GuildName(string value) { }

	// RVA: 0x3678660 Offset: 0x3674660 VA: 0x3678660 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3678668 Offset: 0x3674668 VA: 0x3678668 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36787E0 Offset: 0x36747E0 VA: 0x36787E0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
