// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Bank
public class BankMarketDepositGoldResponse : OperationResponseBase // TypeDefIndex: 11685
{
	// Fields
	[CompilerGenerated]
	private byte <DepositType>k__BackingField; // 0x20
	[CompilerGenerated]
	private long <DepositValue>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <UnsendCount>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <NotReceiveCount>k__BackingField; // 0x34
	[CompilerGenerated]
	private short <MarketReturnCode>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <UserDepositRemaining>k__BackingField; // 0x3C

	// Properties
	public byte DepositType { get; set; }
	public long DepositValue { get; set; }
	public int UnsendCount { get; set; }
	public int NotReceiveCount { get; set; }
	public short MarketReturnCode { get; set; }
	public int UserDepositRemaining { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3731EA0 Offset: 0x372DEA0 VA: 0x3731EA0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3731EA8 Offset: 0x372DEA8 VA: 0x3731EA8
	public byte get_DepositType() { }

	[CompilerGenerated]
	// RVA: 0x3731EB0 Offset: 0x372DEB0 VA: 0x3731EB0
	public void set_DepositType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3731EB8 Offset: 0x372DEB8 VA: 0x3731EB8
	public long get_DepositValue() { }

	[CompilerGenerated]
	// RVA: 0x3731EC0 Offset: 0x372DEC0 VA: 0x3731EC0
	public void set_DepositValue(long value) { }

	[CompilerGenerated]
	// RVA: 0x3731EC8 Offset: 0x372DEC8 VA: 0x3731EC8
	public int get_UnsendCount() { }

	[CompilerGenerated]
	// RVA: 0x3731ED0 Offset: 0x372DED0 VA: 0x3731ED0
	public void set_UnsendCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x3731ED8 Offset: 0x372DED8 VA: 0x3731ED8
	public int get_NotReceiveCount() { }

	[CompilerGenerated]
	// RVA: 0x3731EE0 Offset: 0x372DEE0 VA: 0x3731EE0
	public void set_NotReceiveCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x3731EE8 Offset: 0x372DEE8 VA: 0x3731EE8
	public short get_MarketReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x3731EF0 Offset: 0x372DEF0 VA: 0x3731EF0
	public void set_MarketReturnCode(short value) { }

	[CompilerGenerated]
	// RVA: 0x3731EF8 Offset: 0x372DEF8 VA: 0x3731EF8
	public int get_UserDepositRemaining() { }

	[CompilerGenerated]
	// RVA: 0x3731F00 Offset: 0x372DF00 VA: 0x3731F00
	public void set_UserDepositRemaining(int value) { }

	// RVA: 0x3731F08 Offset: 0x372DF08 VA: 0x3731F08 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3731F10 Offset: 0x372DF10 VA: 0x3731F10 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3731F18 Offset: 0x372DF18 VA: 0x3731F18 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37321D0 Offset: 0x372E1D0 VA: 0x37321D0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
