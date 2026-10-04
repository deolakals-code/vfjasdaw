// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Party
public class PartyStatusLightEvent : EventSubBase, IPartyStatusEvent // TypeDefIndex: 12865
{
	// Fields
	[CompilerGenerated]
	private int <PartyId>k__BackingField; // 0x20
	[CompilerGenerated]
	private IPartyMemberStatusData[] <Members>k__BackingField; // 0x28

	// Properties
	public int PartyId { get; set; }
	public IPartyMemberStatusData[] Members { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x366B5E4 Offset: 0x36675E4 VA: 0x366B5E4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x366B5EC Offset: 0x36675EC VA: 0x366B5EC Slot: 8
	public int get_PartyId() { }

	[CompilerGenerated]
	// RVA: 0x366B5F4 Offset: 0x36675F4 VA: 0x366B5F4 Slot: 10
	public void set_PartyId(int value) { }

	[CompilerGenerated]
	// RVA: 0x366B5FC Offset: 0x36675FC VA: 0x366B5FC Slot: 9
	public IPartyMemberStatusData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x366B604 Offset: 0x3667604 VA: 0x366B604 Slot: 11
	public void set_Members(IPartyMemberStatusData[] value) { }

	// RVA: 0x366B60C Offset: 0x366760C VA: 0x366B60C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x366B614 Offset: 0x3667614 VA: 0x366B614 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x366B61C Offset: 0x366761C VA: 0x366B61C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x366B728 Offset: 0x3667728 VA: 0x366B728 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
