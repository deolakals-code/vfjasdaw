// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Party
public class PartyStateLightEvent : EventSubBase, IPartyStateEvent // TypeDefIndex: 12863
{
	// Fields
	[CompilerGenerated]
	private int <PartyId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <LeaderId>k__BackingField; // 0x24
	[CompilerGenerated]
	private IPartyMemberStateData[] <Members>k__BackingField; // 0x28

	// Properties
	public int PartyId { get; set; }
	public int LeaderId { get; set; }
	public IPartyMemberStateData[] Members { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x366B248 Offset: 0x3667248 VA: 0x366B248
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x366B250 Offset: 0x3667250 VA: 0x366B250 Slot: 8
	public int get_PartyId() { }

	[CompilerGenerated]
	// RVA: 0x366B258 Offset: 0x3667258 VA: 0x366B258 Slot: 11
	public void set_PartyId(int value) { }

	[CompilerGenerated]
	// RVA: 0x366B260 Offset: 0x3667260 VA: 0x366B260 Slot: 9
	public int get_LeaderId() { }

	[CompilerGenerated]
	// RVA: 0x366B268 Offset: 0x3667268 VA: 0x366B268 Slot: 12
	public void set_LeaderId(int value) { }

	[CompilerGenerated]
	// RVA: 0x366B270 Offset: 0x3667270 VA: 0x366B270 Slot: 10
	public IPartyMemberStateData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x366B278 Offset: 0x3667278 VA: 0x366B278 Slot: 13
	public void set_Members(IPartyMemberStateData[] value) { }

	// RVA: 0x366B280 Offset: 0x3667280 VA: 0x366B280 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x366B288 Offset: 0x3667288 VA: 0x366B288 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x366B290 Offset: 0x3667290 VA: 0x366B290 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x366B3C4 Offset: 0x36673C4 VA: 0x366B3C4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
