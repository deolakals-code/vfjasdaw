// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Guild.Alliance
public class GuildAllianceInviteEvent : EventSubBase // TypeDefIndex: 12939
{
	// Fields
	[CompilerGenerated]
	private GuildAllianceInvitationData <InviteData>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 2)]
	public GuildAllianceInvitationData InviteData { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x367CD5C Offset: 0x3678D5C VA: 0x367CD5C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x367CD64 Offset: 0x3678D64 VA: 0x367CD64
	public GuildAllianceInvitationData get_InviteData() { }

	[CompilerGenerated]
	// RVA: 0x367CD6C Offset: 0x3678D6C VA: 0x367CD6C
	public void set_InviteData(GuildAllianceInvitationData value) { }

	// RVA: 0x367CD74 Offset: 0x3678D74 VA: 0x367CD74 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x367CD7C Offset: 0x3678D7C VA: 0x367CD7C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x367CD84 Offset: 0x3678D84 VA: 0x367CD84 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x367CE0C Offset: 0x3678E0C VA: 0x367CE0C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
