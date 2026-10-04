// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ItemPropertyTextManager : TextManagerBase // TypeDefIndex: 5232
{
	// Fields
	private Dictionary<int, TextManagerDataSingle> TextData; // 0x18
	private BonusType[] searchBonusType; // 0x20

	// Methods

	// RVA: 0x2611D78 Offset: 0x260DD78 VA: 0x2611D78 Slot: 6
	public override void Initialize(byte[] binary) { }

	// RVA: -1 Offset: -1 Slot: 4
	public override T Get<T>(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C5DCC Offset: 0x26C1DCC VA: 0x26C5DCC
	|-ItemPropertyTextManager.Get<object>
	*/

	// RVA: 0x2612224 Offset: 0x260E224 VA: 0x2612224 Slot: 7
	public override void Clear() { }

	// RVA: 0x261227C Offset: 0x260E27C VA: 0x261227C
	public Dictionary<int, string> GetDatas() { }

	// RVA: 0x2612454 Offset: 0x260E454 VA: 0x2612454
	public Dictionary<int, string> GetSearchDatas() { }

	// RVA: 0x2612700 Offset: 0x260E700 VA: 0x2612700
	public void .ctor() { }
}
