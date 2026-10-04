// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Party
public class PartyLinkInviteEvent : PacketBase // TypeDefIndex: 12859
{
	// Fields
	[CompilerGenerated]
	private int <PartyId>k__BackingField; // 0x20
	[CompilerGenerated]
	private PartyLinkInviteData <InviteData>k__BackingField; // 0x28

	// Properties
	public int PartyId { get; set; }
	public PartyLinkInviteData InviteData { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x366A77C Offset: 0x366677C VA: 0x366A77C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x366A784 Offset: 0x3666784 VA: 0x366A784
	public int get_PartyId() { }

	[CompilerGenerated]
	// RVA: 0x366A78C Offset: 0x366678C VA: 0x366A78C
	public void set_PartyId(int value) { }

	[CompilerGenerated]
	// RVA: 0x366A794 Offset: 0x3666794 VA: 0x366A794
	public PartyLinkInviteData get_InviteData() { }

	[CompilerGenerated]
	// RVA: 0x366A79C Offset: 0x366679C VA: 0x366A79C
	public void set_InviteData(PartyLinkInviteData value) { }

	// RVA: 0x366A7A4 Offset: 0x36667A4 VA: 0x366A7A4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x366A7AC Offset: 0x36667AC VA: 0x366A7AC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x366A9A0 Offset: 0x36669A0 VA: 0x366A9A0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
