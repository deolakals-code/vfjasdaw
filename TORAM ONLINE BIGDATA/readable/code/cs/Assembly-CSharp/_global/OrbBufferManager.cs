// Assembly: Assembly-CSharp.dll
// Namespace: 
public class OrbBufferManager // TypeDefIndex: 2140
{
	// Fields
	public const int MaxOrbBuffer = 5;
	private Dictionary<int, OrbBufferManager.OrbBufferData> orbBufferList; // 0x10
	private bool updateTimer; // 0x18
	private int trainingItemId; // 0x1C

	// Properties
	public Dictionary<int, OrbBufferManager.OrbBufferData> OrbBufferList { get; }

	// Methods

	// RVA: 0x214D46C Offset: 0x214946C VA: 0x214D46C
	public Dictionary<int, OrbBufferManager.OrbBufferData> get_OrbBufferList() { }

	// RVA: 0x214D474 Offset: 0x2149474 VA: 0x214D474
	public void Initialize(OrbBonusData[] OrbBonus) { }

	// RVA: 0x214D5E8 Offset: 0x21495E8 VA: 0x214D5E8
	public void Update() { }

	// RVA: 0x214D7C4 Offset: 0x21497C4 VA: 0x214D7C4
	public void UpdateOrbBuffer(OrbBonusData[] bufDataList) { }

	// RVA: 0x214D9D8 Offset: 0x21499D8 VA: 0x214D9D8
	public void RemoveOrbBuffer(int itemId) { }

	// RVA: 0x214DA48 Offset: 0x2149A48 VA: 0x214DA48
	public void SetUpdateTimer(bool update) { }

	// RVA: 0x214D5D0 Offset: 0x21495D0 VA: 0x214D5D0
	public bool CheckTrainingItem(int itemId) { }

	// RVA: 0x214DA54 Offset: 0x2149A54 VA: 0x214DA54
	public void UpdateTrainingCount(int count) { }

	// RVA: 0x214DAEC Offset: 0x2149AEC VA: 0x214DAEC
	public void .ctor() { }
}
