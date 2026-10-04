// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Party
public class PartyLinkCancelEvent : PacketBase // TypeDefIndex: 12857
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

	// RVA: 0x366A11C Offset: 0x366611C VA: 0x366A11C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x366A124 Offset: 0x3666124 VA: 0x366A124
	public int get_PartyId() { }

	[CompilerGenerated]
	// RVA: 0x366A12C Offset: 0x366612C VA: 0x366A12C
	public void set_PartyId(int value) { }

	[CompilerGenerated]
	// RVA: 0x366A134 Offset: 0x3666134 VA: 0x366A134
	public PartyLinkInviteData get_InviteData() { }

	[CompilerGenerated]
	// RVA: 0x366A13C Offset: 0x366613C VA: 0x366A13C
	public void set_InviteData(PartyLinkInviteData value) { }

	[CompilerGenerated]
	// RVA: 0x366A144 Offset: 0x3666144 VA: 0x366A144
	public bool get_IsTimeout() { }

	[CompilerGenerated]
	// RVA: 0x366A14C Offset: 0x366614C VA: 0x366A14C
	public void set_IsTimeout(bool value) { }

	// RVA: 0x366A158 Offset: 0x3666158 VA: 0x366A158 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x366A160 Offset: 0x3666160 VA: 0x366A160 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x366A3B4 Offset: 0x36663B4 VA: 0x366A3B4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
