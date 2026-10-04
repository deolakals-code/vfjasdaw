// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.PetRace
public class PetRaceJoinResponse : OperationResponseBase // TypeDefIndex: 12233
{
	// Fields
	[CompilerGenerated]
	private int <PetRaceId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <PetRacePhase>k__BackingField; // 0x24
	[CompilerGenerated]
	private PetRaceMemberData[] <Members>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <CourseId>k__BackingField; // 0x30
	[CompilerGenerated]
	private short <SettingBitFlag>k__BackingField; // 0x34
	[CompilerGenerated]
	private byte <RaceType>k__BackingField; // 0x36

	// Properties
	public int PetRaceId { get; set; }
	public byte PetRacePhase { get; set; }
	public PetRaceMemberData[] Members { get; set; }
	public int CourseId { get; set; }
	public short SettingBitFlag { get; set; }
	public byte RaceType { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35E40E0 Offset: 0x35E00E0 VA: 0x35E40E0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35E4F34 Offset: 0x35E0F34 VA: 0x35E4F34
	public int get_PetRaceId() { }

	[CompilerGenerated]
	// RVA: 0x35E4F3C Offset: 0x35E0F3C VA: 0x35E4F3C
	public void set_PetRaceId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35E4F44 Offset: 0x35E0F44 VA: 0x35E4F44
	public byte get_PetRacePhase() { }

	[CompilerGenerated]
	// RVA: 0x35E4F4C Offset: 0x35E0F4C VA: 0x35E4F4C
	public void set_PetRacePhase(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35E4F54 Offset: 0x35E0F54 VA: 0x35E4F54
	public PetRaceMemberData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x35E4F5C Offset: 0x35E0F5C VA: 0x35E4F5C
	public void set_Members(PetRaceMemberData[] value) { }

	[CompilerGenerated]
	// RVA: 0x35E4F64 Offset: 0x35E0F64 VA: 0x35E4F64
	public int get_CourseId() { }

	[CompilerGenerated]
	// RVA: 0x35E4F6C Offset: 0x35E0F6C VA: 0x35E4F6C
	public void set_CourseId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35E4F74 Offset: 0x35E0F74 VA: 0x35E4F74
	public short get_SettingBitFlag() { }

	[CompilerGenerated]
	// RVA: 0x35E4F7C Offset: 0x35E0F7C VA: 0x35E4F7C
	public void set_SettingBitFlag(short value) { }

	[CompilerGenerated]
	// RVA: 0x35E4F84 Offset: 0x35E0F84 VA: 0x35E4F84
	public byte get_RaceType() { }

	[CompilerGenerated]
	// RVA: 0x35E4F8C Offset: 0x35E0F8C VA: 0x35E4F8C
	public void set_RaceType(byte value) { }

	// RVA: 0x35E4F94 Offset: 0x35E0F94 VA: 0x35E4F94 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35E4F9C Offset: 0x35E0F9C VA: 0x35E4F9C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35E4270 Offset: 0x35E0270 VA: 0x35E4270 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E45F8 Offset: 0x35E05F8 VA: 0x35E45F8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
