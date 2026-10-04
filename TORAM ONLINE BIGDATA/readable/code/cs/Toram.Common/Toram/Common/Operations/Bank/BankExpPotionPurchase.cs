// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Bank
public class BankExpPotionPurchase : OperationRequestBase // TypeDefIndex: 11680
{
	// Fields
	[CompilerGenerated]
	private int <Orb>k__BackingField; // 0x20

	// Properties
	public int Orb { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3731064 Offset: 0x372D064 VA: 0x3731064
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x373106C Offset: 0x372D06C VA: 0x373106C
	public int get_Orb() { }

	[CompilerGenerated]
	// RVA: 0x3731074 Offset: 0x372D074 VA: 0x3731074
	public void set_Orb(int value) { }

	// RVA: 0x373107C Offset: 0x372D07C VA: 0x373107C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3731084 Offset: 0x372D084 VA: 0x3731084 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x373108C Offset: 0x372D08C VA: 0x373108C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37311AC Offset: 0x372D1AC VA: 0x37311AC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
