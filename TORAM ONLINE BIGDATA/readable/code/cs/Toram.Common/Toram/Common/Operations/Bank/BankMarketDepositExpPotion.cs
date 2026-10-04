// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Bank
public class BankMarketDepositExpPotion : OperationRequestBase // TypeDefIndex: 11684
{
	// Fields
	[CompilerGenerated]
	private byte <PotionNo>k__BackingField; // 0x20

	// Properties
	public byte PotionNo { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3731CB8 Offset: 0x372DCB8 VA: 0x3731CB8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3731CC0 Offset: 0x372DCC0 VA: 0x3731CC0
	public byte get_PotionNo() { }

	[CompilerGenerated]
	// RVA: 0x3731CC8 Offset: 0x372DCC8 VA: 0x3731CC8
	public void set_PotionNo(byte value) { }

	// RVA: 0x3731CD0 Offset: 0x372DCD0 VA: 0x3731CD0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3731CD8 Offset: 0x372DCD8 VA: 0x3731CD8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3731CE0 Offset: 0x372DCE0 VA: 0x3731CE0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3731E00 Offset: 0x372DE00 VA: 0x3731E00 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
