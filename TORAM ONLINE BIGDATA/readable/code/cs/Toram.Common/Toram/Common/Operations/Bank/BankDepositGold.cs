// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Bank
public class BankDepositGold : OperationRequestBase // TypeDefIndex: 11674
{
	// Fields
	[CompilerGenerated]
	private int <GoldNum>k__BackingField; // 0x20
	[CompilerGenerated]
	private long <BankPoint>k__BackingField; // 0x28

	// Properties
	public int GoldNum { get; set; }
	public long BankPoint { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x372FDA8 Offset: 0x372BDA8 VA: 0x372FDA8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x372FDB0 Offset: 0x372BDB0 VA: 0x372FDB0
	public int get_GoldNum() { }

	[CompilerGenerated]
	// RVA: 0x372FDB8 Offset: 0x372BDB8 VA: 0x372FDB8
	public void set_GoldNum(int value) { }

	[CompilerGenerated]
	// RVA: 0x372FDC0 Offset: 0x372BDC0 VA: 0x372FDC0
	public long get_BankPoint() { }

	[CompilerGenerated]
	// RVA: 0x372FDC8 Offset: 0x372BDC8 VA: 0x372FDC8
	public void set_BankPoint(long value) { }

	// RVA: 0x372FDD0 Offset: 0x372BDD0 VA: 0x372FDD0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x372FDD8 Offset: 0x372BDD8 VA: 0x372FDD8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x372FDE0 Offset: 0x372BDE0 VA: 0x372FDE0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x372FF58 Offset: 0x372BF58 VA: 0x372FF58 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
