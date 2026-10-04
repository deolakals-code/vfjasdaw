// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Orb
public class OrbCourseUpdateResponse : OperationResponseBase // TypeDefIndex: 11806
{
	// Fields
	[CompilerGenerated]
	private CourseData[] <UpdateCourses>k__BackingField; // 0x20

	// Properties
	public CourseData[] UpdateCourses { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x374EF4C Offset: 0x374AF4C VA: 0x374EF4C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x374EF54 Offset: 0x374AF54 VA: 0x374EF54
	public CourseData[] get_UpdateCourses() { }

	[CompilerGenerated]
	// RVA: 0x374EF5C Offset: 0x374AF5C VA: 0x374EF5C
	public void set_UpdateCourses(CourseData[] value) { }

	// RVA: 0x374EF64 Offset: 0x374AF64 VA: 0x374EF64 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x374EF6C Offset: 0x374AF6C VA: 0x374EF6C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x374EF74 Offset: 0x374AF74 VA: 0x374EF74 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x374F0EC Offset: 0x374B0EC VA: 0x374F0EC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
