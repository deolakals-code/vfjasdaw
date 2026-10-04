// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Exchange
public class ExchangeGetMyData : OperationRequestBase // TypeDefIndex: 11665
{
	// Fields
	[CompilerGenerated]
	private short <ExchangeId>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 200)]
	public short ExchangeId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x372DD68 Offset: 0x3729D68 VA: 0x372DD68
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x372DD70 Offset: 0x3729D70 VA: 0x372DD70
	public short get_ExchangeId() { }

	[CompilerGenerated]
	// RVA: 0x372DD78 Offset: 0x3729D78 VA: 0x372DD78
	public void set_ExchangeId(short value) { }

	// RVA: 0x372DD80 Offset: 0x3729D80 VA: 0x372DD80
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x372DD84 Offset: 0x3729D84 VA: 0x372DD84
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x372DD88 Offset: 0x3729D88 VA: 0x372DD88 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x372DD90 Offset: 0x3729D90 VA: 0x372DD90 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x372DD98 Offset: 0x3729D98 VA: 0x372DD98 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x372DEB8 Offset: 0x3729EB8 VA: 0x372DEB8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
