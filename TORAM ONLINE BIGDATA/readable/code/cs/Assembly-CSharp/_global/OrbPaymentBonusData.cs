// Assembly: Assembly-CSharp.dll
// Namespace: 
public class OrbPaymentBonusData // TypeDefIndex: 2151
{
	// Fields
	public readonly int BonusId; // 0x10
	public readonly TimeSpan LostTime; // 0x18
	public readonly List<OrbPaymentBonusDetailData> DetailDataList; // 0x20

	// Methods

	// RVA: 0x214FD94 Offset: 0x214BD94 VA: 0x214FD94
	public void .ctor() { }

	// RVA: 0x214FE28 Offset: 0x214BE28 VA: 0x214FE28
	public void .ctor(int bonusId, TimeSpan lostTime) { }

	// RVA: 0x214FEC8 Offset: 0x214BEC8 VA: 0x214FEC8
	public bool AddDetailData(OrbPaymentBonusDetailData data) { }

	// RVA: 0x214FFB0 Offset: 0x214BFB0 VA: 0x214FFB0
	public bool RemoveDetailData(OrbPaymentBonusDetailData data) { }

	// RVA: 0x2150048 Offset: 0x214C048 VA: 0x2150048
	public bool CheckBonusData(string productId) { }

	// RVA: 0x215010C Offset: 0x214C10C VA: 0x215010C
	public int GetBonusNum(string productId) { }

	// RVA: 0x2150234 Offset: 0x214C234 VA: 0x2150234
	public bool IsActiveLostTime() { }

	// RVA: 0x215029C Offset: 0x214C29C VA: 0x215029C
	public bool IsDisplayBonus() { }
}
