// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Orb
public class OrbBarter : OperationRequestBase // TypeDefIndex: 11828
{
	// Fields
	[CompilerGenerated]
	private int <ExchangeNum>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 92)]
	public int ExchangeNum { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3752794 Offset: 0x374E794 VA: 0x3752794
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x375279C Offset: 0x374E79C VA: 0x375279C
	public int get_ExchangeNum() { }

	[CompilerGenerated]
	// RVA: 0x37527A4 Offset: 0x374E7A4 VA: 0x37527A4
	public void set_ExchangeNum(int value) { }

	// RVA: 0x37527AC Offset: 0x374E7AC VA: 0x37527AC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37527B4 Offset: 0x374E7B4 VA: 0x37527B4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37527BC Offset: 0x374E7BC VA: 0x37527BC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37528DC Offset: 0x374E8DC VA: 0x37528DC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
