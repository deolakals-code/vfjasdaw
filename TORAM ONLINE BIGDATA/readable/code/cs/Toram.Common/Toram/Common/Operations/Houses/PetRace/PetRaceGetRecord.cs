// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.PetRace
public class PetRaceGetRecord : OperationRequestBase // TypeDefIndex: 12222
{
	// Fields
	[CompilerGenerated]
	private int <CourseId>k__BackingField; // 0x20

	// Properties
	public int CourseId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35E2D6C Offset: 0x35DED6C VA: 0x35E2D6C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35E2D74 Offset: 0x35DED74 VA: 0x35E2D74
	public int get_CourseId() { }

	[CompilerGenerated]
	// RVA: 0x35E2D7C Offset: 0x35DED7C VA: 0x35E2D7C
	public void set_CourseId(int value) { }

	// RVA: 0x35E2D84 Offset: 0x35DED84 VA: 0x35E2D84 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35E2D8C Offset: 0x35DED8C VA: 0x35E2D8C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35E2D94 Offset: 0x35DED94 VA: 0x35E2D94 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35E2E34 Offset: 0x35DEE34 VA: 0x35E2E34 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
