// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Party.Links
public class PartyLinkConsent : OperationRequestBase // TypeDefIndex: 11501
{
	// Fields
	[CompilerGenerated]
	private PartyLinkInviteData <InviteData>k__BackingField; // 0x20

	// Properties
	public PartyLinkInviteData InviteData { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3714168 Offset: 0x3710168 VA: 0x3714168
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3714170 Offset: 0x3710170 VA: 0x3714170
	public PartyLinkInviteData get_InviteData() { }

	[CompilerGenerated]
	// RVA: 0x3714178 Offset: 0x3710178 VA: 0x3714178
	public void set_InviteData(PartyLinkInviteData value) { }

	// RVA: 0x3714180 Offset: 0x3710180 VA: 0x3714180 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3714188 Offset: 0x3710188 VA: 0x3714188 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3714190 Offset: 0x3710190 VA: 0x3714190 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x371432C Offset: 0x371032C VA: 0x371432C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
