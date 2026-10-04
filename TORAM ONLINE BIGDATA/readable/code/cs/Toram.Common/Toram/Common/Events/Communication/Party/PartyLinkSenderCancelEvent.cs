// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Party
public class PartyLinkSenderCancelEvent : PacketBase // TypeDefIndex: 12860
{
	// Fields
	[CompilerGenerated]
	private int <PartyId>k__BackingField; // 0x20
	[CompilerGenerated]
	private PartyLinkInviteData <InviteData>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <IsTimeout>k__BackingField; // 0x30

	// Properties
	public int PartyId { get; set; }
	public PartyLinkInviteData InviteData { get; set; }
	public bool IsTimeout { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x366AA9C Offset: 0x3666A9C VA: 0x366AA9C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x366AAA4 Offset: 0x3666AA4 VA: 0x366AAA4
	public int get_PartyId() { }

	[CompilerGenerated]
	// RVA: 0x366AAAC Offset: 0x3666AAC VA: 0x366AAAC
	public void set_PartyId(int value) { }

	[CompilerGenerated]
	// RVA: 0x366AAB4 Offset: 0x3666AB4 VA: 0x366AAB4
	public PartyLinkInviteData get_InviteData() { }

	[CompilerGenerated]
	// RVA: 0x366AABC Offset: 0x3666ABC VA: 0x366AABC
	public void set_InviteData(PartyLinkInviteData value) { }

	[CompilerGenerated]
	// RVA: 0x366AAC4 Offset: 0x3666AC4 VA: 0x366AAC4
	public bool get_IsTimeout() { }

	[CompilerGenerated]
	// RVA: 0x366AACC Offset: 0x3666ACC VA: 0x366AACC
	public void set_IsTimeout(bool value) { }

	// RVA: 0x366AAD8 Offset: 0x3666AD8 VA: 0x366AAD8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x366AAE0 Offset: 0x3666AE0 VA: 0x366AAE0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x366AD34 Offset: 0x3666D34 VA: 0x366AD34 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
