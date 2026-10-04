// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.House.PetRace
public class PetRaceSettingPhaseEndEvent : EventSubBase // TypeDefIndex: 12823
{
	// Fields
	[CompilerGenerated]
	private byte <PetRacePhase>k__BackingField; // 0x20
	[CompilerGenerated]
	private PetRaceMemberData[] <Members>k__BackingField; // 0x28

	// Properties
	public byte PetRacePhase { get; set; }
	public PetRaceMemberData[] Members { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3661384 Offset: 0x365D384 VA: 0x3661384
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x366138C Offset: 0x365D38C VA: 0x366138C
	public byte get_PetRacePhase() { }

	[CompilerGenerated]
	// RVA: 0x3661394 Offset: 0x365D394 VA: 0x3661394
	public void set_PetRacePhase(byte value) { }

	[CompilerGenerated]
	// RVA: 0x366139C Offset: 0x365D39C VA: 0x366139C
	public PetRaceMemberData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x36613A4 Offset: 0x365D3A4 VA: 0x36613A4
	public void set_Members(PetRaceMemberData[] value) { }

	// RVA: 0x36613AC Offset: 0x365D3AC VA: 0x36613AC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36613B4 Offset: 0x365D3B4 VA: 0x36613B4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x36613BC Offset: 0x365D3BC VA: 0x36613BC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3661594 Offset: 0x365D594 VA: 0x3661594 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
