// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Bank
public class BankDepositGoldResponse : OperationResponseBase // TypeDefIndex: 11675
{
	// Fields
	[CompilerGenerated]
	private BankData <Bank>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <DepositType>k__BackingField; // 0x28
	[CompilerGenerated]
	private long <DepositValue>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <PossessionGold>k__BackingField; // 0x38

	// Properties
	public BankData Bank { get; set; }
	public byte DepositType { get; set; }
	public long DepositValue { get; set; }
	public int PossessionGold { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x373003C Offset: 0x372C03C VA: 0x373003C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3730044 Offset: 0x372C044 VA: 0x3730044
	public BankData get_Bank() { }

	[CompilerGenerated]
	// RVA: 0x373004C Offset: 0x372C04C VA: 0x373004C
	public void set_Bank(BankData value) { }

	[CompilerGenerated]
	// RVA: 0x3730054 Offset: 0x372C054 VA: 0x3730054
	public byte get_DepositType() { }

	[CompilerGenerated]
	// RVA: 0x373005C Offset: 0x372C05C VA: 0x373005C
	public void set_DepositType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3730064 Offset: 0x372C064 VA: 0x3730064
	public long get_DepositValue() { }

	[CompilerGenerated]
	// RVA: 0x373006C Offset: 0x372C06C VA: 0x373006C
	public void set_DepositValue(long value) { }

	[CompilerGenerated]
	// RVA: 0x3730074 Offset: 0x372C074 VA: 0x3730074
	public int get_PossessionGold() { }

	[CompilerGenerated]
	// RVA: 0x373007C Offset: 0x372C07C VA: 0x373007C
	public void set_PossessionGold(int value) { }

	// RVA: 0x3730084 Offset: 0x372C084 VA: 0x3730084 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x373008C Offset: 0x372C08C VA: 0x373008C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3730094 Offset: 0x372C094 VA: 0x3730094 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3730340 Offset: 0x372C340 VA: 0x3730340 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
