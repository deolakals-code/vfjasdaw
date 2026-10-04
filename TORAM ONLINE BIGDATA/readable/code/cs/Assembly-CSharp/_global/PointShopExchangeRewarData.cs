// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PointShopExchangeRewarData : PointShopRewarDataBase // TypeDefIndex: 1848
{
	// Fields
	public readonly int OpenUsedPoint; // 0x2C
	public readonly int OpenAccumulationPoint; // 0x30
	public readonly short OpenLevel; // 0x34
	public readonly short Limit; // 0x36

	// Methods

	// RVA: 0x20F0680 Offset: 0x20EC680 VA: 0x20F0680
	public void .ctor(short uid, byte exchangeItemType, int point, RewardData reward, short openExchange, int openUsedPoint, int openAccumulationPointt, short openLevel, short limit) { }

	// RVA: 0x20F1058 Offset: 0x20ED058 VA: 0x20F1058
	public void .ctor(short uid, byte exchangeItemType, int point, RewardData reward, short openExchange, byte flag) { }

	// RVA: 0x20F10C8 Offset: 0x20ED0C8 VA: 0x20F10C8 Slot: 4
	public override Dictionary<byte, int> GetResultCheckData() { }
}
