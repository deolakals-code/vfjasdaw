// Assembly: Assembly-CSharp.dll
// Namespace: 
internal class PartyLinkAnnouncementData : AnnouncementBase // TypeDefIndex: 1702
{
	// Fields
	[CompilerGenerated]
	private int <PartyLinkId>k__BackingField; // 0x14
	[CompilerGenerated]
	private PartyLinkInviteData <Data>k__BackingField; // 0x18
	[CompilerGenerated]
	private float <Time>k__BackingField; // 0x20

	// Properties
	public int PartyLinkId { get; set; }
	public PartyLinkInviteData Data { get; set; }
	public float Time { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x20AC2C4 Offset: 0x20A82C4 VA: 0x20AC2C4
	public int get_PartyLinkId() { }

	[CompilerGenerated]
	// RVA: 0x20AC2CC Offset: 0x20A82CC VA: 0x20AC2CC
	private void set_PartyLinkId(int value) { }

	[CompilerGenerated]
	// RVA: 0x20AC2D4 Offset: 0x20A82D4 VA: 0x20AC2D4
	public PartyLinkInviteData get_Data() { }

	[CompilerGenerated]
	// RVA: 0x20AC2DC Offset: 0x20A82DC VA: 0x20AC2DC
	private void set_Data(PartyLinkInviteData value) { }

	[CompilerGenerated]
	// RVA: 0x20AC2E4 Offset: 0x20A82E4 VA: 0x20AC2E4
	public float get_Time() { }

	[CompilerGenerated]
	// RVA: 0x20AC2EC Offset: 0x20A82EC VA: 0x20AC2EC
	private void set_Time(float value) { }

	// RVA: 0x20AC2F4 Offset: 0x20A82F4 VA: 0x20AC2F4
	public void .ctor() { }

	// RVA: 0x20A8510 Offset: 0x20A4510 VA: 0x20A8510
	public void .ctor(int partyId, PartyLinkInviteData data) { }

	// RVA: 0x20A855C Offset: 0x20A455C VA: 0x20A855C
	public void UpdateData(int partyId, PartyLinkInviteData data) { }
}
