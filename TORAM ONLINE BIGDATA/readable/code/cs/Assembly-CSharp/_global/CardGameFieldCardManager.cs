// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CardGameFieldCardManager // TypeDefIndex: 4292
{
	// Fields
	private Dictionary<byte, CardGamePlayerCard> fieldCard; // 0x10
	public const int SpecialCardId = 47;

	// Properties
	public bool IsPlayerCardMax { get; }

	// Methods

	// RVA: 0x24C0BB8 Offset: 0x24BCBB8 VA: 0x24C0BB8
	public bool get_IsPlayerCardMax() { }

	// RVA: 0x24C65A8 Offset: 0x24C25A8 VA: 0x24C65A8
	private CardGamePlayerCard CreateFieldCard(byte type, byte cardIndex, short drawTrun, byte recycleSetting, byte marketSellPrice) { }

	// RVA: 0x24BEE68 Offset: 0x24BAE68 VA: 0x24BEE68
	public CardGamePlayerCard CreatePlayerCard(byte cardId, byte recycleSetting, int trun) { }

	// RVA: 0x24C16D8 Offset: 0x24BD6D8 VA: 0x24C16D8
	public CardGamePlayerCard CreateMarketCard(byte cardId, byte recycleSetting, byte pritec) { }

	// RVA: 0x24BF0AC Offset: 0x24BB0AC VA: 0x24BF0AC
	public void AllCardClear(byte type) { }

	// RVA: 0x24C0064 Offset: 0x24BC064 VA: 0x24C0064
	public void AllCardClear() { }

	// RVA: 0x24C0FCC Offset: 0x24BCFCC VA: 0x24C0FCC
	public void RemoveCard(byte uniqueId) { }

	// RVA: 0x24BF40C Offset: 0x24BB40C VA: 0x24BF40C
	public CardGamePlayerCard GetCard(byte uniqueId) { }

	// RVA: 0x24BB2C4 Offset: 0x24B72C4 VA: 0x24BB2C4
	public List<CardGamePlayerCard> CreateCardList(byte type) { }

	// RVA: 0x24C2980 Offset: 0x24BE980 VA: 0x24C2980
	public void .ctor() { }
}
