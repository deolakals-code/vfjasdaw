// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Bank
public class BankWithdrawGold : OperationRequestBase // TypeDefIndex: 11689
{
	// Fields
	[CompilerGenerated]
	private int <GoldNum>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ClientFee>k__BackingField; // 0x24
	[CompilerGenerated]
	private long <BankPoint>k__BackingField; // 0x28

	// Properties
	public int GoldNum { get; set; }
	public int ClientFee { get; set; }
	public long BankPoint { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3732F4C Offset: 0x372EF4C VA: 0x3732F4C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3732F54 Offset: 0x372EF54 VA: 0x3732F54
	public int get_GoldNum() { }

	[CompilerGenerated]
	// RVA: 0x3732F5C Offset: 0x372EF5C VA: 0x3732F5C
	public void set_GoldNum(int value) { }

	[CompilerGenerated]
	// RVA: 0x3732F64 Offset: 0x372EF64 VA: 0x3732F64
	public int get_ClientFee() { }

	[CompilerGenerated]
	// RVA: 0x3732F6C Offset: 0x372EF6C VA: 0x3732F6C
	public void set_ClientFee(int value) { }

	[CompilerGenerated]
	// RVA: 0x3732F74 Offset: 0x372EF74 VA: 0x3732F74
	public long get_BankPoint() { }

	[CompilerGenerated]
	// RVA: 0x3732F7C Offset: 0x372EF7C VA: 0x3732F7C
	public void set_BankPoint(long value) { }

	// RVA: 0x3732F84 Offset: 0x372EF84 VA: 0x3732F84 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3732F8C Offset: 0x372EF8C VA: 0x3732F8C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3732F94 Offset: 0x372EF94 VA: 0x3732F94 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3733158 Offset: 0x372F158 VA: 0x3733158 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
