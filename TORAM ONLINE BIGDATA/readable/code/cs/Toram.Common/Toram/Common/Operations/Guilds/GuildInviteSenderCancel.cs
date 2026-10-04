// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds
public class GuildInviteSenderCancel : PacketBase // TypeDefIndex: 12395
{
	// Fields
	[CompilerGenerated]
	private int <TargetId>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 96)]
	public int TargetId { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x360136C Offset: 0x35FD36C VA: 0x360136C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3601374 Offset: 0x35FD374 VA: 0x3601374
	public int get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x360137C Offset: 0x35FD37C VA: 0x360137C
	public void set_TargetId(int value) { }

	// RVA: 0x3601384 Offset: 0x35FD384 VA: 0x3601384 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x360138C Offset: 0x35FD38C VA: 0x360138C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36014AC Offset: 0x35FD4AC VA: 0x36014AC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
