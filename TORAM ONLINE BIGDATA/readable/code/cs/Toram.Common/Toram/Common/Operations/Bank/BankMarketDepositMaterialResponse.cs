// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Bank
public class BankMarketDepositMaterialResponse : OperationResponseBase // TypeDefIndex: 11686
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

	// RVA: 0x3732384 Offset: 0x372E384 VA: 0x3732384
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x373238C Offset: 0x372E38C VA: 0x373238C
	public byte get_DepositType() { }

	[CompilerGenerated]
	// RVA: 0x3732394 Offset: 0x372E394 VA: 0x3732394
	public void set_DepositType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x373239C Offset: 0x372E39C VA: 0x373239C
	public long get_DepositValue() { }

	[CompilerGenerated]
	// RVA: 0x37323A4 Offset: 0x372E3A4 VA: 0x37323A4
	public void set_DepositValue(long value) { }

	[CompilerGenerated]
	// RVA: 0x37323AC Offset: 0x372E3AC VA: 0x37323AC
	public int get_UnsendCount() { }

	[CompilerGenerated]
	// RVA: 0x37323B4 Offset: 0x372E3B4 VA: 0x37323B4
	public void set_UnsendCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x37323BC Offset: 0x372E3BC VA: 0x37323BC
	public int get_NotReceiveCount() { }

	[CompilerGenerated]
	// RVA: 0x37323C4 Offset: 0x372E3C4 VA: 0x37323C4
	public void set_NotReceiveCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x37323CC Offset: 0x372E3CC VA: 0x37323CC
	public short get_MarketReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x37323D4 Offset: 0x372E3D4 VA: 0x37323D4
	public void set_MarketReturnCode(short value) { }

	[CompilerGenerated]
	// RVA: 0x37323DC Offset: 0x372E3DC VA: 0x37323DC
	public int get_UserDepositRemaining() { }

	[CompilerGenerated]
	// RVA: 0x37323E4 Offset: 0x372E3E4 VA: 0x37323E4
	public void set_UserDepositRemaining(int value) { }

	// RVA: 0x37323EC Offset: 0x372E3EC VA: 0x37323EC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37323F4 Offset: 0x372E3F4 VA: 0x37323F4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37323FC Offset: 0x372E3FC VA: 0x37323FC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37326B4 Offset: 0x372E6B4 VA: 0x37326B4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
