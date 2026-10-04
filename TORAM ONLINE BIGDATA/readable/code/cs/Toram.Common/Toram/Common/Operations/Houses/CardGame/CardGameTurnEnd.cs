// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.CardGame
public class CardGameTurnEnd : OperationRequestBase // TypeDefIndex: 12278
{
	// Fields
	[CompilerGenerated]
	private byte <TurnCount>k__BackingField; // 0x20
	[CompilerGenerated]
	private CardGameTurnCardData <TurnData>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte[] <MarketSell>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte[] <MarketBuy>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <UseSpecialCardId>k__BackingField; // 0x40

	// Properties
	public byte TurnCount { get; set; }
	public CardGameTurnCardData TurnData { get; set; }
	public byte[] MarketSell { get; set; }
	public byte[] MarketBuy { get; set; }
	public int UseSpecialCardId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35EB5E0 Offset: 0x35E75E0 VA: 0x35EB5E0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35EB5E8 Offset: 0x35E75E8 VA: 0x35EB5E8
	public byte get_TurnCount() { }

	[CompilerGenerated]
	// RVA: 0x35EB5F0 Offset: 0x35E75F0 VA: 0x35EB5F0
	public void set_TurnCount(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35EB5F8 Offset: 0x35E75F8 VA: 0x35EB5F8
	public CardGameTurnCardData get_TurnData() { }

	[CompilerGenerated]
	// RVA: 0x35EB600 Offset: 0x35E7600 VA: 0x35EB600
	public void set_TurnData(CardGameTurnCardData value) { }

	[CompilerGenerated]
	// RVA: 0x35EB608 Offset: 0x35E7608 VA: 0x35EB608
	public byte[] get_MarketSell() { }

	[CompilerGenerated]
	// RVA: 0x35EB610 Offset: 0x35E7610 VA: 0x35EB610
	public void set_MarketSell(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x35EB618 Offset: 0x35E7618 VA: 0x35EB618
	public byte[] get_MarketBuy() { }

	[CompilerGenerated]
	// RVA: 0x35EB620 Offset: 0x35E7620 VA: 0x35EB620
	public void set_MarketBuy(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x35EB628 Offset: 0x35E7628 VA: 0x35EB628
	public int get_UseSpecialCardId() { }

	[CompilerGenerated]
	// RVA: 0x35EB630 Offset: 0x35E7630 VA: 0x35EB630
	public void set_UseSpecialCardId(int value) { }

	// RVA: 0x35EB638 Offset: 0x35E7638 VA: 0x35EB638 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35EB640 Offset: 0x35E7640 VA: 0x35EB640 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35EB648 Offset: 0x35E7648 VA: 0x35EB648 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35EB9C0 Offset: 0x35E79C0 VA: 0x35EB9C0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
