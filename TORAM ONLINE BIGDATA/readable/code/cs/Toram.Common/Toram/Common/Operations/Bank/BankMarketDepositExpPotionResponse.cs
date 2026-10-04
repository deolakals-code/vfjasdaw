// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Bank
public class BankMarketDepositExpPotionResponse : OperationResponseBase // TypeDefIndex: 11695
{
	// Fields
	[CompilerGenerated]
	private BankPotionData <Potion>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <UnsendCount>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <NotReceiveCount>k__BackingField; // 0x2C
	[CompilerGenerated]
	private short <MarketReturnCode>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <UserDepositRemaining>k__BackingField; // 0x34

	// Properties
	public BankPotionData Potion { get; set; }
	public int UnsendCount { get; set; }
	public int NotReceiveCount { get; set; }
	public short MarketReturnCode { get; set; }
	public int UserDepositRemaining { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3734814 Offset: 0x3730814 VA: 0x3734814
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x373481C Offset: 0x373081C VA: 0x373481C
	public BankPotionData get_Potion() { }

	[CompilerGenerated]
	// RVA: 0x3734824 Offset: 0x3730824 VA: 0x3734824
	public void set_Potion(BankPotionData value) { }

	[CompilerGenerated]
	// RVA: 0x373482C Offset: 0x373082C VA: 0x373482C
	public int get_UnsendCount() { }

	[CompilerGenerated]
	// RVA: 0x3734834 Offset: 0x3730834 VA: 0x3734834
	public void set_UnsendCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x373483C Offset: 0x373083C VA: 0x373483C
	public int get_NotReceiveCount() { }

	[CompilerGenerated]
	// RVA: 0x3734844 Offset: 0x3730844 VA: 0x3734844
	public void set_NotReceiveCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x373484C Offset: 0x373084C VA: 0x373484C
	public short get_MarketReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x3734854 Offset: 0x3730854 VA: 0x3734854
	public void set_MarketReturnCode(short value) { }

	[CompilerGenerated]
	// RVA: 0x373485C Offset: 0x373085C VA: 0x373485C
	public int get_UserDepositRemaining() { }

	[CompilerGenerated]
	// RVA: 0x3734864 Offset: 0x3730864 VA: 0x3734864
	public void set_UserDepositRemaining(int value) { }

	// RVA: 0x373486C Offset: 0x373086C VA: 0x373486C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3734874 Offset: 0x3730874 VA: 0x3734874 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x373487C Offset: 0x373087C VA: 0x373487C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3734B50 Offset: 0x3730B50 VA: 0x3734B50 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
