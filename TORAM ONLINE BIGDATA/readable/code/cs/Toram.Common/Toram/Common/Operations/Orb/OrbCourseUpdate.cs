// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Orb
public class OrbCourseUpdate : OperationRequestBase // TypeDefIndex: 11805
{
	// Fields
	[CompilerGenerated]
	private int <Orb>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 229)]
	public int Orb { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x374ED64 Offset: 0x374AD64 VA: 0x374ED64
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x374ED6C Offset: 0x374AD6C VA: 0x374ED6C
	public int get_Orb() { }

	[CompilerGenerated]
	// RVA: 0x374ED74 Offset: 0x374AD74 VA: 0x374ED74
	public void set_Orb(int value) { }

	// RVA: 0x374ED7C Offset: 0x374AD7C VA: 0x374ED7C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x374ED84 Offset: 0x374AD84 VA: 0x374ED84 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x374ED8C Offset: 0x374AD8C VA: 0x374ED8C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x374EEAC Offset: 0x374AEAC VA: 0x374EEAC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
