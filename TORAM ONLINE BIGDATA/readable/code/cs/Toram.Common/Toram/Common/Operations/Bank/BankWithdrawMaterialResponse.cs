// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Bank
public class BankWithdrawMaterialResponse : OperationResponseBase // TypeDefIndex: 11692
{
	// Fields
	[CompilerGenerated]
	private BankData <Bank>k__BackingField; // 0x20
	[CompilerGenerated]
	private MaterialData <Material>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <WithdrawPoint>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <Fee>k__BackingField; // 0x34
	[CompilerGenerated]
	private byte <DepositType>k__BackingField; // 0x38
	[CompilerGenerated]
	private long <DepositValue>k__BackingField; // 0x40

	// Properties
	public BankData Bank { get; set; }
	public MaterialData Material { get; set; }
	public int WithdrawPoint { get; set; }
	public int Fee { get; set; }
	public byte DepositType { get; set; }
	public long DepositValue { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3733BF8 Offset: 0x372FBF8 VA: 0x3733BF8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3733C00 Offset: 0x372FC00 VA: 0x3733C00
	public BankData get_Bank() { }

	[CompilerGenerated]
	// RVA: 0x3733C08 Offset: 0x372FC08 VA: 0x3733C08
	public void set_Bank(BankData value) { }

	[CompilerGenerated]
	// RVA: 0x3733C10 Offset: 0x372FC10 VA: 0x3733C10
	public MaterialData get_Material() { }

	[CompilerGenerated]
	// RVA: 0x3733C18 Offset: 0x372FC18 VA: 0x3733C18
	public void set_Material(MaterialData value) { }

	[CompilerGenerated]
	// RVA: 0x3733C20 Offset: 0x372FC20 VA: 0x3733C20
	public int get_WithdrawPoint() { }

	[CompilerGenerated]
	// RVA: 0x3733C28 Offset: 0x372FC28 VA: 0x3733C28
	public void set_WithdrawPoint(int value) { }

	[CompilerGenerated]
	// RVA: 0x3733C30 Offset: 0x372FC30 VA: 0x3733C30
	public int get_Fee() { }

	[CompilerGenerated]
	// RVA: 0x3733C38 Offset: 0x372FC38 VA: 0x3733C38
	public void set_Fee(int value) { }

	[CompilerGenerated]
	// RVA: 0x3733C40 Offset: 0x372FC40 VA: 0x3733C40
	public byte get_DepositType() { }

	[CompilerGenerated]
	// RVA: 0x3733C48 Offset: 0x372FC48 VA: 0x3733C48
	public void set_DepositType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3733C50 Offset: 0x372FC50 VA: 0x3733C50
	public long get_DepositValue() { }

	[CompilerGenerated]
	// RVA: 0x3733C58 Offset: 0x372FC58 VA: 0x3733C58
	public void set_DepositValue(long value) { }

	// RVA: 0x3733C60 Offset: 0x372FC60 VA: 0x3733C60 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3733C68 Offset: 0x372FC68 VA: 0x3733C68 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3733C70 Offset: 0x372FC70 VA: 0x3733C70 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3734018 Offset: 0x3730018 VA: 0x3734018 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
