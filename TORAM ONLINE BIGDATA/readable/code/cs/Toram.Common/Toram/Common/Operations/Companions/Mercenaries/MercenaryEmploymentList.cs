// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Companions.Mercenaries
public class MercenaryEmploymentList : OperationRequestBase // TypeDefIndex: 11390
{
	// Fields
	[CompilerGenerated]
	private byte <EmploymentType>k__BackingField; // 0x20

	// Properties
	public byte EmploymentType { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x36FFCEC Offset: 0x36FBCEC VA: 0x36FFCEC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x36FFCF4 Offset: 0x36FBCF4 VA: 0x36FFCF4
	public byte get_EmploymentType() { }

	[CompilerGenerated]
	// RVA: 0x36FFCFC Offset: 0x36FBCFC VA: 0x36FFCFC
	public void set_EmploymentType(byte value) { }

	// RVA: 0x36FFD04 Offset: 0x36FBD04 VA: 0x36FFD04 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36FFD0C Offset: 0x36FBD0C VA: 0x36FFD0C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x36FFD14 Offset: 0x36FBD14 VA: 0x36FFD14 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36FFE34 Offset: 0x36FBE34 VA: 0x36FFE34 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
