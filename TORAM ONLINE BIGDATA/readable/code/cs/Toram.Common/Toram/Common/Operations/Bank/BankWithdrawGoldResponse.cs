// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Bank
public class BankWithdrawGoldResponse : OperationResponseBase // TypeDefIndex: 11690
{
	// Fields
	[CompilerGenerated]
	private BankData <Bank>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <PossessionGold>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <WithdrawGold>k__BackingField; // 0x2C
	[CompilerGenerated]
	private int <Fee>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte <DepositType>k__BackingField; // 0x34
	[CompilerGenerated]
	private long <DepositValue>k__BackingField; // 0x38

	// Properties
	public BankData Bank { get; set; }
	public int PossessionGold { get; set; }
	public int WithdrawGold { get; set; }
	public int Fee { get; set; }
	public byte DepositType { get; set; }
	public long DepositValue { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3733264 Offset: 0x372F264 VA: 0x3733264
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x373326C Offset: 0x372F26C VA: 0x373326C
	public BankData get_Bank() { }

	[CompilerGenerated]
	// RVA: 0x3733274 Offset: 0x372F274 VA: 0x3733274
	public void set_Bank(BankData value) { }

	[CompilerGenerated]
	// RVA: 0x373327C Offset: 0x372F27C VA: 0x373327C
	public int get_PossessionGold() { }

	[CompilerGenerated]
	// RVA: 0x3733284 Offset: 0x372F284 VA: 0x3733284
	public void set_PossessionGold(int value) { }

	[CompilerGenerated]
	// RVA: 0x373328C Offset: 0x372F28C VA: 0x373328C
	public int get_WithdrawGold() { }

	[CompilerGenerated]
	// RVA: 0x3733294 Offset: 0x372F294 VA: 0x3733294
	public void set_WithdrawGold(int value) { }

	[CompilerGenerated]
	// RVA: 0x373329C Offset: 0x372F29C VA: 0x373329C
	public int get_Fee() { }

	[CompilerGenerated]
	// RVA: 0x37332A4 Offset: 0x372F2A4 VA: 0x37332A4
	public void set_Fee(int value) { }

	[CompilerGenerated]
	// RVA: 0x37332AC Offset: 0x372F2AC VA: 0x37332AC
	public byte get_DepositType() { }

	[CompilerGenerated]
	// RVA: 0x37332B4 Offset: 0x372F2B4 VA: 0x37332B4
	public void set_DepositType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x37332BC Offset: 0x372F2BC VA: 0x37332BC
	public long get_DepositValue() { }

	[CompilerGenerated]
	// RVA: 0x37332C4 Offset: 0x372F2C4 VA: 0x37332C4
	public void set_DepositValue(long value) { }

	// RVA: 0x37332CC Offset: 0x372F2CC VA: 0x37332CC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37332D4 Offset: 0x372F2D4 VA: 0x37332D4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37332DC Offset: 0x372F2DC VA: 0x37332DC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3733610 Offset: 0x372F610 VA: 0x3733610 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
