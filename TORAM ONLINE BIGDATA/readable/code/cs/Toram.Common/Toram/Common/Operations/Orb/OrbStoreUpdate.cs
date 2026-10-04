// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Orb
public class OrbStoreUpdate : OperationRequestBase // TypeDefIndex: 11822
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

	// RVA: 0x3751AC8 Offset: 0x374DAC8 VA: 0x3751AC8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3751AD0 Offset: 0x374DAD0 VA: 0x3751AD0
	public int get_Orb() { }

	[CompilerGenerated]
	// RVA: 0x3751AD8 Offset: 0x374DAD8 VA: 0x3751AD8
	public void set_Orb(int value) { }

	// RVA: 0x3751AE0 Offset: 0x374DAE0 VA: 0x3751AE0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3751AE8 Offset: 0x374DAE8 VA: 0x3751AE8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3751AF0 Offset: 0x374DAF0 VA: 0x3751AF0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3751C10 Offset: 0x374DC10 VA: 0x3751C10 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
