// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Guild.Alliance
public class GuildAllianceReleaseEvent : EventSubBase // TypeDefIndex: 12938
{
	// Fields
	[CompilerGenerated]
	private int <AllianceId>k__BackingField; // 0x20
	[CompilerGenerated]
	private GuildVariableData <ChatLink>k__BackingField; // 0x28
	[CompilerGenerated]
	private DateTime <EndDate>k__BackingField; // 0x30

	// Properties
	[PacketParameter(Code = 0)]
	public int AllianceId { get; set; }
	[PacketClass(Code = 2)]
	public GuildVariableData ChatLink { get; set; }
	[PacketParameter(Code = 25)]
	public DateTime EndDate { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x367C984 Offset: 0x3678984 VA: 0x367C984
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x367C98C Offset: 0x367898C VA: 0x367C98C
	public int get_AllianceId() { }

	[CompilerGenerated]
	// RVA: 0x367C994 Offset: 0x3678994 VA: 0x367C994
	public void set_AllianceId(int value) { }

	[CompilerGenerated]
	// RVA: 0x367C99C Offset: 0x367899C VA: 0x367C99C
	public GuildVariableData get_ChatLink() { }

	[CompilerGenerated]
	// RVA: 0x367C9A4 Offset: 0x36789A4 VA: 0x367C9A4
	public void set_ChatLink(GuildVariableData value) { }

	[CompilerGenerated]
	// RVA: 0x367C9AC Offset: 0x36789AC VA: 0x367C9AC
	public DateTime get_EndDate() { }

	[CompilerGenerated]
	// RVA: 0x367C9B4 Offset: 0x36789B4 VA: 0x367C9B4
	public void set_EndDate(DateTime value) { }

	// RVA: 0x367C9BC Offset: 0x36789BC VA: 0x367C9BC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x367C9C4 Offset: 0x36789C4 VA: 0x367C9C4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x367C9CC Offset: 0x36789CC VA: 0x367C9CC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x367CB14 Offset: 0x3678B14 VA: 0x367CB14 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
