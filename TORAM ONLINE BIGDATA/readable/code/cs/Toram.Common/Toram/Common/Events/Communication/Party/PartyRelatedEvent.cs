// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Party
public class PartyRelatedEvent : PacketBase // TypeDefIndex: 12878
{
	// Fields
	[CompilerGenerated]
	private int <PartyId>k__BackingField; // 0x20
	[CompilerGenerated]
	private PartyReserveData[] <ReserveList>k__BackingField; // 0x28
	[CompilerGenerated]
	private PartyLinkInviteData[] <LinkInvites>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <PartyLinkId>k__BackingField; // 0x38

	// Properties
	[PacketParameter(Code = 94, IsOptional = True)]
	public int PartyId { get; set; }
	[PacketClass(Code = 176, IsOptional = True)]
	public PartyReserveData[] ReserveList { get; set; }
	public PartyLinkInviteData[] LinkInvites { get; set; }
	public int PartyLinkId { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x366E0D0 Offset: 0x366A0D0 VA: 0x366E0D0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x366E0D8 Offset: 0x366A0D8 VA: 0x366E0D8
	public int get_PartyId() { }

	[CompilerGenerated]
	// RVA: 0x366E0E0 Offset: 0x366A0E0 VA: 0x366E0E0
	public void set_PartyId(int value) { }

	[CompilerGenerated]
	// RVA: 0x366E0E8 Offset: 0x366A0E8 VA: 0x366E0E8
	public PartyReserveData[] get_ReserveList() { }

	[CompilerGenerated]
	// RVA: 0x366E0F0 Offset: 0x366A0F0 VA: 0x366E0F0
	public void set_ReserveList(PartyReserveData[] value) { }

	[CompilerGenerated]
	// RVA: 0x366E0F8 Offset: 0x366A0F8 VA: 0x366E0F8
	public PartyLinkInviteData[] get_LinkInvites() { }

	[CompilerGenerated]
	// RVA: 0x366E100 Offset: 0x366A100 VA: 0x366E100
	public void set_LinkInvites(PartyLinkInviteData[] value) { }

	[CompilerGenerated]
	// RVA: 0x366E108 Offset: 0x366A108 VA: 0x366E108
	public int get_PartyLinkId() { }

	[CompilerGenerated]
	// RVA: 0x366E110 Offset: 0x366A110 VA: 0x366E110
	public void set_PartyLinkId(int value) { }

	// RVA: 0x366E118 Offset: 0x366A118 VA: 0x366E118 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x366E120 Offset: 0x366A120 VA: 0x366E120 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x366E424 Offset: 0x366A424 VA: 0x366E424 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
