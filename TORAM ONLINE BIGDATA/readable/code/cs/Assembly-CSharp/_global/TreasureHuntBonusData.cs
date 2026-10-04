// Assembly: Assembly-CSharp.dll
// Namespace: 
public class TreasureHuntBonusData // TypeDefIndex: 1748
{
	// Fields
	private BonusData bonusData; // 0x10
	private int bonusId; // 0x18
	private string userName; // 0x20

	// Properties
	public BonusData BonusData { get; }
	public int BonusId { get; }
	public string UserName { get; }

	// Methods

	// RVA: 0x20C11B0 Offset: 0x20BD1B0 VA: 0x20C11B0
	public void .ctor(int bonusType, string userName) { }

	// RVA: 0x20C11E8 Offset: 0x20BD1E8 VA: 0x20C11E8
	public BonusData get_BonusData() { }

	// RVA: 0x20C11F0 Offset: 0x20BD1F0 VA: 0x20C11F0
	public int get_BonusId() { }

	// RVA: 0x20C11F8 Offset: 0x20BD1F8 VA: 0x20C11F8
	public string get_UserName() { }

	// RVA: 0x20C1200 Offset: 0x20BD200 VA: 0x20C1200
	public void SetBonusData(BonusData bonusData) { }

	// RVA: 0x20C1208 Offset: 0x20BD208 VA: 0x20C1208
	public IList<BonusParameter> GetBonusParameter() { }
}
