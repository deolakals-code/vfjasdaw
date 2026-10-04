// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Bank
public class BankSetupResponse : OperationResponseBase // TypeDefIndex: 11688
{
	// Fields
	[CompilerGenerated]
	private BankData[] <Banks>k__BackingField; // 0x20
	[CompilerGenerated]
	private Dictionary<byte, long> <Deposits>k__BackingField; // 0x28
	[CompilerGenerated]
	private BankPotionData[] <Potions>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <UnsendCount>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <NotReceiveCount>k__BackingField; // 0x3C
	[CompilerGenerated]
	private bool <MarketState>k__BackingField; // 0x40
	[CompilerGenerated]
	private int <UserDepositRemaining>k__BackingField; // 0x44
	[CompilerGenerated]
	private int <ServerDepositMax>k__BackingField; // 0x48

	// Properties
	public BankData[] Banks { get; set; }
	public Dictionary<byte, long> Deposits { get; set; }
	public BankPotionData[] Potions { get; set; }
	public int UnsendCount { get; set; }
	public int NotReceiveCount { get; set; }
	public bool MarketState { get; set; }
	public int UserDepositRemaining { get; set; }
	public int ServerDepositMax { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3732890 Offset: 0x372E890 VA: 0x3732890
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3732898 Offset: 0x372E898 VA: 0x3732898
	public BankData[] get_Banks() { }

	[CompilerGenerated]
	// RVA: 0x37328A0 Offset: 0x372E8A0 VA: 0x37328A0
	public void set_Banks(BankData[] value) { }

	[CompilerGenerated]
	// RVA: 0x37328A8 Offset: 0x372E8A8 VA: 0x37328A8
	public Dictionary<byte, long> get_Deposits() { }

	[CompilerGenerated]
	// RVA: 0x37328B0 Offset: 0x372E8B0 VA: 0x37328B0
	public void set_Deposits(Dictionary<byte, long> value) { }

	[CompilerGenerated]
	// RVA: 0x37328B8 Offset: 0x372E8B8 VA: 0x37328B8
	public BankPotionData[] get_Potions() { }

	[CompilerGenerated]
	// RVA: 0x37328C0 Offset: 0x372E8C0 VA: 0x37328C0
	public void set_Potions(BankPotionData[] value) { }

	[CompilerGenerated]
	// RVA: 0x37328C8 Offset: 0x372E8C8 VA: 0x37328C8
	public int get_UnsendCount() { }

	[CompilerGenerated]
	// RVA: 0x37328D0 Offset: 0x372E8D0 VA: 0x37328D0
	public void set_UnsendCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x37328D8 Offset: 0x372E8D8 VA: 0x37328D8
	public int get_NotReceiveCount() { }

	[CompilerGenerated]
	// RVA: 0x37328E0 Offset: 0x372E8E0 VA: 0x37328E0
	public void set_NotReceiveCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x37328E8 Offset: 0x372E8E8 VA: 0x37328E8
	public bool get_MarketState() { }

	[CompilerGenerated]
	// RVA: 0x37328F0 Offset: 0x372E8F0 VA: 0x37328F0
	public void set_MarketState(bool value) { }

	[CompilerGenerated]
	// RVA: 0x37328FC Offset: 0x372E8FC VA: 0x37328FC
	public int get_UserDepositRemaining() { }

	[CompilerGenerated]
	// RVA: 0x3732904 Offset: 0x372E904 VA: 0x3732904
	public void set_UserDepositRemaining(int value) { }

	[CompilerGenerated]
	// RVA: 0x373290C Offset: 0x372E90C VA: 0x373290C
	public int get_ServerDepositMax() { }

	[CompilerGenerated]
	// RVA: 0x3732914 Offset: 0x372E914 VA: 0x3732914
	public void set_ServerDepositMax(int value) { }

	// RVA: 0x373291C Offset: 0x372E91C VA: 0x373291C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3732924 Offset: 0x372E924 VA: 0x3732924 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x373292C Offset: 0x372E92C VA: 0x373292C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3732D58 Offset: 0x372ED58 VA: 0x3732D58 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
