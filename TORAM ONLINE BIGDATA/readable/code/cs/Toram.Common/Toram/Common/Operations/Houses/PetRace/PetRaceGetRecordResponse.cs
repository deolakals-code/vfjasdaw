// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.PetRace
public class PetRaceGetRecordResponse : OperationResponseBase // TypeDefIndex: 12223
{
	// Fields
	[CompilerGenerated]
	private int <CourseId>k__BackingField; // 0x20
	[CompilerGenerated]
	private PetRaceRecordData <Record>k__BackingField; // 0x28
	[CompilerGenerated]
	private PetRaceRecordData[] <AllRecords>k__BackingField; // 0x30

	// Properties
	public int CourseId { get; set; }
	public PetRaceRecordData Record { get; set; }
	public PetRaceRecordData[] AllRecords { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35E2F54 Offset: 0x35DEF54 VA: 0x35E2F54
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35E2F5C Offset: 0x35DEF5C VA: 0x35E2F5C
	public int get_CourseId() { }

	[CompilerGenerated]
	// RVA: 0x35E2F64 Offset: 0x35DEF64 VA: 0x35E2F64
	public void set_CourseId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35E2F6C Offset: 0x35DEF6C VA: 0x35E2F6C
	public PetRaceRecordData get_Record() { }

	[CompilerGenerated]
	// RVA: 0x35E2F74 Offset: 0x35DEF74 VA: 0x35E2F74
	public void set_Record(PetRaceRecordData value) { }

	[CompilerGenerated]
	// RVA: 0x35E2F7C Offset: 0x35DEF7C VA: 0x35E2F7C
	public PetRaceRecordData[] get_AllRecords() { }

	[CompilerGenerated]
	// RVA: 0x35E2F84 Offset: 0x35DEF84 VA: 0x35E2F84
	public void set_AllRecords(PetRaceRecordData[] value) { }

	// RVA: 0x35E2F8C Offset: 0x35DEF8C VA: 0x35E2F8C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35E2F94 Offset: 0x35DEF94 VA: 0x35E2F94 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35E2F9C Offset: 0x35DEF9C VA: 0x35E2F9C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E3238 Offset: 0x35DF238 VA: 0x35E3238 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
