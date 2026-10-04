// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Bank
public class BankExpPotionPurchaseResponse : OperationResponseBase // TypeDefIndex: 11681
{
	// Fields
	[CompilerGenerated]
	private BankPotionData <Potion>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Orb>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <PaidOrb>k__BackingField; // 0x2C

	// Properties
	public BankPotionData Potion { get; set; }
	public int Orb { get; set; }
	public int PaidOrb { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x373124C Offset: 0x372D24C VA: 0x373124C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3731254 Offset: 0x372D254 VA: 0x3731254
	public BankPotionData get_Potion() { }

	[CompilerGenerated]
	// RVA: 0x373125C Offset: 0x372D25C VA: 0x373125C
	public void set_Potion(BankPotionData value) { }

	[CompilerGenerated]
	// RVA: 0x3731264 Offset: 0x372D264 VA: 0x3731264
	public int get_Orb() { }

	[CompilerGenerated]
	// RVA: 0x373126C Offset: 0x372D26C VA: 0x373126C
	public void set_Orb(int value) { }

	[CompilerGenerated]
	// RVA: 0x3731274 Offset: 0x372D274 VA: 0x3731274
	public int get_PaidOrb() { }

	[CompilerGenerated]
	// RVA: 0x373127C Offset: 0x372D27C VA: 0x373127C
	public void set_PaidOrb(int value) { }

	// RVA: 0x3731284 Offset: 0x372D284 VA: 0x3731284 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x373128C Offset: 0x372D28C VA: 0x373128C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3731294 Offset: 0x372D294 VA: 0x3731294 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37314CC Offset: 0x372D4CC VA: 0x37314CC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
