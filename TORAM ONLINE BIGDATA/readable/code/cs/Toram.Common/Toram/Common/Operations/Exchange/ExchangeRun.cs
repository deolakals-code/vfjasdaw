// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Exchange
public class ExchangeRun : OperationRequestBase // TypeDefIndex: 11664
{
	// Fields
	[CompilerGenerated]
	private int <ClientExchItemNum>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <ExchangeId>k__BackingField; // 0x24
	[CompilerGenerated]
	private short <ExchangeNo>k__BackingField; // 0x26
	[CompilerGenerated]
	private byte <ExchangeType>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <ExchangeMethod>k__BackingField; // 0x29

	// Properties
	[PacketParameter(Code = 253)]
	public int ClientExchItemNum { get; set; }
	[PacketParameter(Code = 200)]
	public short ExchangeId { get; set; }
	[PacketParameter(Code = 153)]
	public short ExchangeNo { get; set; }
	[PacketParameter(Code = 245)]
	public byte ExchangeType { get; set; }
	[PacketParameter(Code = 164)]
	public byte ExchangeMethod { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x372D928 Offset: 0x3729928 VA: 0x372D928
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x372D930 Offset: 0x3729930 VA: 0x372D930
	public int get_ClientExchItemNum() { }

	[CompilerGenerated]
	// RVA: 0x372D938 Offset: 0x3729938 VA: 0x372D938
	public void set_ClientExchItemNum(int value) { }

	[CompilerGenerated]
	// RVA: 0x372D940 Offset: 0x3729940 VA: 0x372D940
	public short get_ExchangeId() { }

	[CompilerGenerated]
	// RVA: 0x372D948 Offset: 0x3729948 VA: 0x372D948
	public void set_ExchangeId(short value) { }

	[CompilerGenerated]
	// RVA: 0x372D950 Offset: 0x3729950 VA: 0x372D950
	public short get_ExchangeNo() { }

	[CompilerGenerated]
	// RVA: 0x372D958 Offset: 0x3729958 VA: 0x372D958
	public void set_ExchangeNo(short value) { }

	[CompilerGenerated]
	// RVA: 0x372D960 Offset: 0x3729960 VA: 0x372D960
	public byte get_ExchangeType() { }

	[CompilerGenerated]
	// RVA: 0x372D968 Offset: 0x3729968 VA: 0x372D968
	public void set_ExchangeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x372D970 Offset: 0x3729970 VA: 0x372D970
	public byte get_ExchangeMethod() { }

	[CompilerGenerated]
	// RVA: 0x372D978 Offset: 0x3729978 VA: 0x372D978
	public void set_ExchangeMethod(byte value) { }

	// RVA: 0x372D980 Offset: 0x3729980 VA: 0x372D980
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x372D984 Offset: 0x3729984 VA: 0x372D984
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x372D988 Offset: 0x3729988 VA: 0x372D988 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x372D990 Offset: 0x3729990 VA: 0x372D990 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x372D998 Offset: 0x3729998 VA: 0x372D998 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x372DBF8 Offset: 0x3729BF8 VA: 0x372DBF8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
