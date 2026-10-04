// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.House.PetRace
public class PetRaceStateEvent : EventSubBase // TypeDefIndex: 12828
{
	// Fields
	[CompilerGenerated]
	private byte <PetRacePhase>k__BackingField; // 0x20
	[CompilerGenerated]
	private PetRaceMemberData[] <Members>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <RemainingSeconds>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <CourseId>k__BackingField; // 0x34
	[CompilerGenerated]
	private short <SettingBitFlag>k__BackingField; // 0x38

	// Properties
	public byte PetRacePhase { get; set; }
	public PetRaceMemberData[] Members { get; set; }
	public short RemainingSeconds { get; set; }
	public int CourseId { get; set; }
	public short SettingBitFlag { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3663080 Offset: 0x365F080 VA: 0x3663080
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3663088 Offset: 0x365F088 VA: 0x3663088
	public byte get_PetRacePhase() { }

	[CompilerGenerated]
	// RVA: 0x3663090 Offset: 0x365F090 VA: 0x3663090
	public void set_PetRacePhase(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3663098 Offset: 0x365F098 VA: 0x3663098
	public PetRaceMemberData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x36630A0 Offset: 0x365F0A0 VA: 0x36630A0
	public void set_Members(PetRaceMemberData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36630A8 Offset: 0x365F0A8 VA: 0x36630A8
	public short get_RemainingSeconds() { }

	[CompilerGenerated]
	// RVA: 0x36630B0 Offset: 0x365F0B0 VA: 0x36630B0
	public void set_RemainingSeconds(short value) { }

	[CompilerGenerated]
	// RVA: 0x36630B8 Offset: 0x365F0B8 VA: 0x36630B8
	public int get_CourseId() { }

	[CompilerGenerated]
	// RVA: 0x36630C0 Offset: 0x365F0C0 VA: 0x36630C0
	public void set_CourseId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36630C8 Offset: 0x365F0C8 VA: 0x36630C8
	public short get_SettingBitFlag() { }

	[CompilerGenerated]
	// RVA: 0x36630D0 Offset: 0x365F0D0 VA: 0x36630D0
	public void set_SettingBitFlag(short value) { }

	// RVA: 0x36630D8 Offset: 0x365F0D8 VA: 0x36630D8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36630E0 Offset: 0x365F0E0 VA: 0x36630E0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x36630E8 Offset: 0x365F0E8 VA: 0x36630E8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36633BC Offset: 0x365F3BC VA: 0x36633BC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x366353C Offset: 0x365F53C VA: 0x366353C Slot: 3
	public override string ToString() { }
}
