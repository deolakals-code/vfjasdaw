// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Guild.Alliance
public class GuildAllianceInviteCancelEvent : EventSubBase // TypeDefIndex: 12936
{
	// Fields
	[CompilerGenerated]
	private GuildAllianceInvitationData <InviteData>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <IsTimeout>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 2)]
	public GuildAllianceInvitationData InviteData { get; set; }
	[PacketParameter(Code = 20)]
	public bool IsTimeout { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x367C364 Offset: 0x3678364 VA: 0x367C364
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x367C36C Offset: 0x367836C VA: 0x367C36C
	public GuildAllianceInvitationData get_InviteData() { }

	[CompilerGenerated]
	// RVA: 0x367C374 Offset: 0x3678374 VA: 0x367C374
	public void set_InviteData(GuildAllianceInvitationData value) { }

	[CompilerGenerated]
	// RVA: 0x367C37C Offset: 0x367837C VA: 0x367C37C
	public bool get_IsTimeout() { }

	[CompilerGenerated]
	// RVA: 0x367C384 Offset: 0x3678384 VA: 0x367C384
	public void set_IsTimeout(bool value) { }

	// RVA: 0x367C390 Offset: 0x3678390 VA: 0x367C390 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x367C398 Offset: 0x3678398 VA: 0x367C398 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x367C3A0 Offset: 0x36783A0 VA: 0x367C3A0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x367C474 Offset: 0x3678474 VA: 0x367C474 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
