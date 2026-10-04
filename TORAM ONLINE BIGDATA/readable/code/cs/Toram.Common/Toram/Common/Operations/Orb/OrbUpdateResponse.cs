// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Orb
public class OrbUpdateResponse : OperationResponseBase // TypeDefIndex: 11827
{
	// Fields
	[CompilerGenerated]
	private int <Orb>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <PaidOrb>k__BackingField; // 0x24

	// Properties
	public int Orb { get; set; }
	public int PaidOrb { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x37524FC Offset: 0x374E4FC VA: 0x37524FC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3752504 Offset: 0x374E504 VA: 0x3752504
	public int get_Orb() { }

	[CompilerGenerated]
	// RVA: 0x375250C Offset: 0x374E50C VA: 0x375250C
	public void set_Orb(int value) { }

	[CompilerGenerated]
	// RVA: 0x3752514 Offset: 0x374E514 VA: 0x3752514
	public int get_PaidOrb() { }

	[CompilerGenerated]
	// RVA: 0x375251C Offset: 0x374E51C VA: 0x375251C
	public void set_PaidOrb(int value) { }

	// RVA: 0x3752524 Offset: 0x374E524 VA: 0x3752524 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x375252C Offset: 0x374E52C VA: 0x375252C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3752534 Offset: 0x374E534 VA: 0x3752534 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37526CC Offset: 0x374E6CC VA: 0x37526CC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
