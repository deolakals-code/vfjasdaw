// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Orb
public class OrbTicketExchange : OperationRequestBase // TypeDefIndex: 11824
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

	// RVA: 0x3751FFC Offset: 0x374DFFC VA: 0x3751FFC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3752004 Offset: 0x374E004 VA: 0x3752004
	public int get_ExchangeNum() { }

	[CompilerGenerated]
	// RVA: 0x375200C Offset: 0x374E00C VA: 0x375200C
	public void set_ExchangeNum(int value) { }

	// RVA: 0x3752014 Offset: 0x374E014 VA: 0x3752014 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x375201C Offset: 0x374E01C VA: 0x375201C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3752024 Offset: 0x374E024 VA: 0x3752024 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3752144 Offset: 0x374E144 VA: 0x3752144 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
