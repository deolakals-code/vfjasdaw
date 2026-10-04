// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Party.Links
public class PartyLinkInviteCancel : OperationRequestBase // TypeDefIndex: 11505
{
	// Fields
	[CompilerGenerated]
	private PartyLinkInviteData <InviteData>k__BackingField; // 0x20

	// Properties
	public PartyLinkInviteData InviteData { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3714B04 Offset: 0x3710B04 VA: 0x3714B04
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3714B0C Offset: 0x3710B0C VA: 0x3714B0C
	public PartyLinkInviteData get_InviteData() { }

	[CompilerGenerated]
	// RVA: 0x3714B14 Offset: 0x3710B14 VA: 0x3714B14
	public void set_InviteData(PartyLinkInviteData value) { }

	// RVA: 0x3714B1C Offset: 0x3710B1C VA: 0x3714B1C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3714B24 Offset: 0x3710B24 VA: 0x3714B24 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3714B2C Offset: 0x3710B2C VA: 0x3714B2C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3714CC8 Offset: 0x3710CC8 VA: 0x3714CC8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
