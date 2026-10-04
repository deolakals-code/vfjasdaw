// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Bank
public class BankMarketDepositGold : OperationRequestBase // TypeDefIndex: 11693
{
	// Fields
	[CompilerGenerated]
	private int <Gold>k__BackingField; // 0x20
	[CompilerGenerated]
	private long <BankPoint>k__BackingField; // 0x28

	// Properties
	public int Gold { get; set; }
	public long BankPoint { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x37341C4 Offset: 0x37301C4 VA: 0x37341C4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x37341CC Offset: 0x37301CC VA: 0x37341CC
	public int get_Gold() { }

	[CompilerGenerated]
	// RVA: 0x37341D4 Offset: 0x37301D4 VA: 0x37341D4
	public void set_Gold(int value) { }

	[CompilerGenerated]
	// RVA: 0x37341DC Offset: 0x37301DC VA: 0x37341DC
	public long get_BankPoint() { }

	[CompilerGenerated]
	// RVA: 0x37341E4 Offset: 0x37301E4 VA: 0x37341E4
	public void set_BankPoint(long value) { }

	// RVA: 0x37341EC Offset: 0x37301EC VA: 0x37341EC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37341F4 Offset: 0x37301F4 VA: 0x37341F4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37341FC Offset: 0x37301FC VA: 0x37341FC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3734374 Offset: 0x3730374 VA: 0x3734374 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
