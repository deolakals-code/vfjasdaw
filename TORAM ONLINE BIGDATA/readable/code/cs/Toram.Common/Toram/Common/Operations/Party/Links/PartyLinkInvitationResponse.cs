// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Party.Links
public class PartyLinkInvitationResponse : OperationResponseBase // TypeDefIndex: 11504
{
	// Fields
	[CompilerGenerated]
	private int <PartyId>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <LeaderName>k__BackingField; // 0x28

	// Properties
	public int PartyId { get; set; }
	public string LeaderName { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x37148A0 Offset: 0x37108A0 VA: 0x37148A0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x37148A8 Offset: 0x37108A8 VA: 0x37148A8
	public int get_PartyId() { }

	[CompilerGenerated]
	// RVA: 0x37148B0 Offset: 0x37108B0 VA: 0x37148B0
	public void set_PartyId(int value) { }

	[CompilerGenerated]
	// RVA: 0x37148B8 Offset: 0x37108B8 VA: 0x37148B8
	public string get_LeaderName() { }

	[CompilerGenerated]
	// RVA: 0x37148C0 Offset: 0x37108C0 VA: 0x37148C0
	public void set_LeaderName(string value) { }

	// RVA: 0x37148C8 Offset: 0x37108C8 VA: 0x37148C8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37148D0 Offset: 0x37108D0 VA: 0x37148D0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37148D8 Offset: 0x37108D8 VA: 0x37148D8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3714A50 Offset: 0x3710A50 VA: 0x3714A50 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
