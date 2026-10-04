// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Bank
public class BankExpPotionUseResponse : OperationResponseBase // TypeDefIndex: 11683
{
	// Fields
	[CompilerGenerated]
	private BankPotionData <Potion>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <IsLevelUp>k__BackingField; // 0x28
	[CompilerGenerated]
	private long <PotionExp>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <ExpI>k__BackingField; // 0x38
	[CompilerGenerated]
	private long <ExpL>k__BackingField; // 0x40

	// Properties
	public BankPotionData Potion { get; set; }
	public bool IsLevelUp { get; set; }
	public long PotionExp { get; set; }
	public int ExpI { get; set; }
	public long ExpL { get; set; }
	public long Exp { get; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x37317AC Offset: 0x372D7AC VA: 0x37317AC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x37317B4 Offset: 0x372D7B4 VA: 0x37317B4
	public BankPotionData get_Potion() { }

	[CompilerGenerated]
	// RVA: 0x37317BC Offset: 0x372D7BC VA: 0x37317BC
	public void set_Potion(BankPotionData value) { }

	[CompilerGenerated]
	// RVA: 0x37317C4 Offset: 0x372D7C4 VA: 0x37317C4
	public bool get_IsLevelUp() { }

	[CompilerGenerated]
	// RVA: 0x37317CC Offset: 0x372D7CC VA: 0x37317CC
	public void set_IsLevelUp(bool value) { }

	[CompilerGenerated]
	// RVA: 0x37317D8 Offset: 0x372D7D8 VA: 0x37317D8
	public long get_PotionExp() { }

	[CompilerGenerated]
	// RVA: 0x37317E0 Offset: 0x372D7E0 VA: 0x37317E0
	public void set_PotionExp(long value) { }

	[CompilerGenerated]
	// RVA: 0x37317E8 Offset: 0x372D7E8 VA: 0x37317E8
	public int get_ExpI() { }

	[CompilerGenerated]
	// RVA: 0x37317F0 Offset: 0x372D7F0 VA: 0x37317F0
	public void set_ExpI(int value) { }

	[CompilerGenerated]
	// RVA: 0x37317F8 Offset: 0x372D7F8 VA: 0x37317F8
	public long get_ExpL() { }

	[CompilerGenerated]
	// RVA: 0x3731800 Offset: 0x372D800 VA: 0x3731800
	public void set_ExpL(long value) { }

	// RVA: 0x3731808 Offset: 0x372D808 VA: 0x3731808
	public long get_Exp() { }

	// RVA: 0x3731810 Offset: 0x372D810 VA: 0x3731810 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3731818 Offset: 0x372D818 VA: 0x3731818 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3731820 Offset: 0x372D820 VA: 0x3731820 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3731B38 Offset: 0x372DB38 VA: 0x3731B38 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
