// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.House.PetRace
public class PetRaceStartEvent : EventSubBase // TypeDefIndex: 12822
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

	// RVA: 0x366109C Offset: 0x365D09C VA: 0x366109C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36610A4 Offset: 0x365D0A4 VA: 0x36610A4
	public byte get_PetRacePhase() { }

	[CompilerGenerated]
	// RVA: 0x36610AC Offset: 0x365D0AC VA: 0x36610AC
	public void set_PetRacePhase(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36610B4 Offset: 0x365D0B4 VA: 0x36610B4
	public PetRaceMemberData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x36610BC Offset: 0x365D0BC VA: 0x36610BC
	public void set_Members(PetRaceMemberData[] value) { }

	// RVA: 0x36610C4 Offset: 0x365D0C4 VA: 0x36610C4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36610CC Offset: 0x365D0CC VA: 0x36610CC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x36610D4 Offset: 0x365D0D4 VA: 0x36610D4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36612AC Offset: 0x365D2AC VA: 0x36612AC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
