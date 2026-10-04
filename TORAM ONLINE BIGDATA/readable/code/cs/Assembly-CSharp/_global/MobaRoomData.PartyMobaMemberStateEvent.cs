// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobaRoomData.PartyMobaMemberStateEvent : IPartyStateEvent // TypeDefIndex: 2390
{
	// Fields
	[CompilerGenerated]
	private int <PartyId>k__BackingField; // 0x10
	[CompilerGenerated]
	private int <LeaderId>k__BackingField; // 0x14
	private List<MobaRoomData.PartyMobaMemberStateEvent.PartyMobaMemberStateData> memberList; // 0x18

	// Properties
	public int PartyId { get; set; }
	public int LeaderId { get; set; }
	public string LeaderName { get; set; }
	public IPartyMemberStateData[] Members { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x21A8368 Offset: 0x21A4368 VA: 0x21A8368 Slot: 4
	public int get_PartyId() { }

	[CompilerGenerated]
	// RVA: 0x21A8370 Offset: 0x21A4370 VA: 0x21A8370 Slot: 7
	public void set_PartyId(int value) { }

	[CompilerGenerated]
	// RVA: 0x21A8378 Offset: 0x21A4378 VA: 0x21A8378 Slot: 5
	public int get_LeaderId() { }

	[CompilerGenerated]
	// RVA: 0x21A8380 Offset: 0x21A4380 VA: 0x21A8380 Slot: 8
	public void set_LeaderId(int value) { }

	// RVA: 0x21A8388 Offset: 0x21A4388 VA: 0x21A8388 Slot: 9
	public string get_LeaderName() { }

	// RVA: 0x21A83D0 Offset: 0x21A43D0 VA: 0x21A83D0 Slot: 10
	public void set_LeaderName(string value) { }

	// RVA: 0x21A83D4 Offset: 0x21A43D4 VA: 0x21A83D4 Slot: 6
	public IPartyMemberStateData[] get_Members() { }

	// RVA: 0x21A8424 Offset: 0x21A4424 VA: 0x21A8424 Slot: 11
	public void set_Members(IPartyMemberStateData[] value) { }

	// RVA: 0x21A8428 Offset: 0x21A4428 VA: 0x21A8428
	public void .ctor(int userId, MobaMemberStateEvent state) { }

	// RVA: 0x21A8644 Offset: 0x21A4644 VA: 0x21A8644
	public void UpdateMemberData(MobaMemberData[] members) { }
}
