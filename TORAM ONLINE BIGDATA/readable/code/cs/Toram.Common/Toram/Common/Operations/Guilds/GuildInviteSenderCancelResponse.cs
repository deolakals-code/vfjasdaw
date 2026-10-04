// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds
public class GuildInviteSenderCancelResponse : PacketBase // TypeDefIndex: 12390
{
	// Fields
	[CompilerGenerated]
	private int <TargetId>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <TargetName>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 96)]
	public int TargetId { get; set; }
	[PacketParameter(Code = 98)]
	public string TargetName { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x360067C Offset: 0x35FC67C VA: 0x360067C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3600684 Offset: 0x35FC684 VA: 0x3600684
	public int get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x360068C Offset: 0x35FC68C VA: 0x360068C
	public void set_TargetId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3600694 Offset: 0x35FC694 VA: 0x3600694
	public string get_TargetName() { }

	[CompilerGenerated]
	// RVA: 0x360069C Offset: 0x35FC69C VA: 0x360069C
	public void set_TargetName(string value) { }

	// RVA: 0x36006A4 Offset: 0x35FC6A4 VA: 0x36006A4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36006AC Offset: 0x35FC6AC VA: 0x36006AC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3600824 Offset: 0x35FC824 VA: 0x3600824 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
