// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Bank
public class BankExpPotionDepositResponse : OperationResponseBase // TypeDefIndex: 11679
{
	// Fields
	[CompilerGenerated]
	private BankData <Bank>k__BackingField; // 0x20
	[CompilerGenerated]
	private BankPotionData <Potion>k__BackingField; // 0x28

	// Properties
	public BankData Bank { get; set; }
	public BankPotionData Potion { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3730D1C Offset: 0x372CD1C VA: 0x3730D1C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3730D24 Offset: 0x372CD24 VA: 0x3730D24
	public BankData get_Bank() { }

	[CompilerGenerated]
	// RVA: 0x3730D2C Offset: 0x372CD2C VA: 0x3730D2C
	public void set_Bank(BankData value) { }

	[CompilerGenerated]
	// RVA: 0x3730D34 Offset: 0x372CD34 VA: 0x3730D34
	public BankPotionData get_Potion() { }

	[CompilerGenerated]
	// RVA: 0x3730D3C Offset: 0x372CD3C VA: 0x3730D3C
	public void set_Potion(BankPotionData value) { }

	// RVA: 0x3730D44 Offset: 0x372CD44 VA: 0x3730D44 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3730D4C Offset: 0x372CD4C VA: 0x3730D4C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3730D54 Offset: 0x372CD54 VA: 0x3730D54 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3730FB0 Offset: 0x372CFB0 VA: 0x3730FB0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
