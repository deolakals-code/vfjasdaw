// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.House.PetRace
public class PetRaceReturnPreparationEvent : EventSubBase // TypeDefIndex: 12824
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

	// RVA: 0x366166C Offset: 0x365D66C VA: 0x366166C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3661674 Offset: 0x365D674 VA: 0x3661674
	public byte get_PetRacePhase() { }

	[CompilerGenerated]
	// RVA: 0x366167C Offset: 0x365D67C VA: 0x366167C
	public void set_PetRacePhase(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3661684 Offset: 0x365D684 VA: 0x3661684
	public PetRaceMemberData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x366168C Offset: 0x365D68C VA: 0x366168C
	public void set_Members(PetRaceMemberData[] value) { }

	// RVA: 0x3661694 Offset: 0x365D694 VA: 0x3661694 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x366169C Offset: 0x365D69C VA: 0x366169C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x36616A4 Offset: 0x365D6A4 VA: 0x36616A4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x366187C Offset: 0x365D87C VA: 0x366187C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
