// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Bank
public class BankExpPotionUse : OperationRequestBase // TypeDefIndex: 11682
{
	// Fields
	[CompilerGenerated]
	private byte <PotionNo>k__BackingField; // 0x20

	// Properties
	public byte PotionNo { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x37315C4 Offset: 0x372D5C4 VA: 0x37315C4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x37315CC Offset: 0x372D5CC VA: 0x37315CC
	public byte get_PotionNo() { }

	[CompilerGenerated]
	// RVA: 0x37315D4 Offset: 0x372D5D4 VA: 0x37315D4
	public void set_PotionNo(byte value) { }

	// RVA: 0x37315DC Offset: 0x372D5DC VA: 0x37315DC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37315E4 Offset: 0x372D5E4 VA: 0x37315E4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37315EC Offset: 0x372D5EC VA: 0x37315EC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x373170C Offset: 0x372D70C VA: 0x373170C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
