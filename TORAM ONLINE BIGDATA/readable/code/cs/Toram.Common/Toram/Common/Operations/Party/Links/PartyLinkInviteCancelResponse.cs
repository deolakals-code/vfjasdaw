// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Party.Links
public class PartyLinkInviteCancelResponse : OperationResponseBase // TypeDefIndex: 11506
{
	// Fields
	[CompilerGenerated]
	private PartyLinkInviteData <InviteData>k__BackingField; // 0x20

	// Properties
	public PartyLinkInviteData InviteData { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3714D50 Offset: 0x3710D50 VA: 0x3714D50
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3714D58 Offset: 0x3710D58 VA: 0x3714D58
	public PartyLinkInviteData get_InviteData() { }

	[CompilerGenerated]
	// RVA: 0x3714D60 Offset: 0x3710D60 VA: 0x3714D60
	public void set_InviteData(PartyLinkInviteData value) { }

	// RVA: 0x3714D68 Offset: 0x3710D68 VA: 0x3714D68 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3714D70 Offset: 0x3710D70 VA: 0x3714D70 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3714D78 Offset: 0x3710D78 VA: 0x3714D78 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3714F14 Offset: 0x3710F14 VA: 0x3714F14 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
