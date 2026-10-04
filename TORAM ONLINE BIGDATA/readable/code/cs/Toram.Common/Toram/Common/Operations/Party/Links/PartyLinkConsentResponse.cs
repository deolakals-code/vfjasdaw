// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Party.Links
public class PartyLinkConsentResponse : OperationResponseBase // TypeDefIndex: 11502
{
	// Fields
	[CompilerGenerated]
	private PartyLinkInviteData <InviteData>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <ReturnCode>k__BackingField; // 0x28

	// Properties
	public PartyLinkInviteData InviteData { get; set; }
	public short ReturnCode { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x37143B4 Offset: 0x37103B4 VA: 0x37143B4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x37143BC Offset: 0x37103BC VA: 0x37143BC
	public PartyLinkInviteData get_InviteData() { }

	[CompilerGenerated]
	// RVA: 0x37143C4 Offset: 0x37103C4 VA: 0x37143C4
	public void set_InviteData(PartyLinkInviteData value) { }

	[CompilerGenerated]
	// RVA: 0x37143CC Offset: 0x37103CC VA: 0x37143CC
	public short get_ReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x37143D4 Offset: 0x37103D4 VA: 0x37143D4
	public void set_ReturnCode(short value) { }

	// RVA: 0x37143DC Offset: 0x37103DC VA: 0x37143DC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37143E4 Offset: 0x37103E4 VA: 0x37143E4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37143EC Offset: 0x37103EC VA: 0x37143EC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37145E8 Offset: 0x37105E8 VA: 0x37145E8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
