// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobaRoomData.PartyMobaMemberStatusEvent : IPartyStatusEvent // TypeDefIndex: 2392
{
	// Fields
	[CompilerGenerated]
	private int <PartyId>k__BackingField; // 0x10
	private List<MobaRoomData.PartyMobaMemberStatusEvent.PartyMobaMemberStatusData> memberList; // 0x18

	// Properties
	public int PartyId { get; set; }
	public IPartyMemberStatusData[] Members { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x21A88E0 Offset: 0x21A48E0 VA: 0x21A88E0 Slot: 4
	public int get_PartyId() { }

	[CompilerGenerated]
	// RVA: 0x21A88E8 Offset: 0x21A48E8 VA: 0x21A88E8 Slot: 6
	public void set_PartyId(int value) { }

	// RVA: 0x21A88F0 Offset: 0x21A48F0 VA: 0x21A88F0 Slot: 5
	public IPartyMemberStatusData[] get_Members() { }

	// RVA: 0x21A8940 Offset: 0x21A4940 VA: 0x21A8940 Slot: 7
	public void set_Members(IPartyMemberStatusData[] value) { }

	// RVA: 0x21A8944 Offset: 0x21A4944 VA: 0x21A8944
	public void .ctor(int userId, MobaMemberStatusEvent status) { }

	// RVA: 0x21A8B0C Offset: 0x21A4B0C VA: 0x21A8B0C
	public void UpdateMemberData(MobaMemberStatusData[] members) { }
}
