// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIHouseCultivationButton : MonoBehaviour // TypeDefIndex: 7224
{
	// Fields
	[SerializeField]
	private UIIcon cultivationIcon; // 0x20
	[SerializeField]
	private UILabel cultivationNameLabel; // 0x28
	[SerializeField]
	private GameObject waterPanel; // 0x30
	private UIHouseWaterPanel waterPanelData; // 0x38
	[SerializeField]
	private GameObject harvestButton; // 0x40
	[SerializeField]
	private GameObject growthTopLabel; // 0x48
	[SerializeField]
	private GameObject growthLabel; // 0x50
	[SerializeField]
	private Transform modelPanel; // 0x58
	private GameObject modelData; // 0x60
	[SerializeField]
	private Transform barPanel; // 0x68
	[SerializeField]
	private GameObject treeGrowthIcon; // 0x70
	[SerializeField]
	private GameObject flowerGrowthIcon; // 0x78
	[SerializeField]
	private GameObject fieldGrowthIcon; // 0x80
	private GameObject[] iconDataList; // 0x88
	[SerializeField]
	private GameObject treeWaterLabel; // 0x90
	private UIHouseCultivationManager manager; // 0x98
	private ProduceDataBase data; // 0xA0

	// Methods

	// RVA: 0x1ADF2B4 Offset: 0x1ADB2B4 VA: 0x1ADF2B4
	private void IconCreate(int num) { }

	// RVA: 0x1ADF3D8 Offset: 0x1ADB3D8 VA: 0x1ADF3D8
	private void AddIcon(int i, GameObject icon, Vector3 pos) { }

	// RVA: 0x1ADF588 Offset: 0x1ADB588 VA: 0x1ADF588
	private void SetItemName(int id) { }

	// RVA: 0x1ADF6A0 Offset: 0x1ADB6A0 VA: 0x1ADF6A0
	public void InitializeTree(UIHouseCultivationManager manager, ProduceDataBase data) { }

	// RVA: 0x1ADFCE4 Offset: 0x1ADBCE4 VA: 0x1ADFCE4
	public void InitializeFlower(UIHouseCultivationManager manager, ProduceDataBase data) { }

	// RVA: 0x1AE0490 Offset: 0x1ADC490 VA: 0x1AE0490
	public void InitializeFarm(UIHouseCultivationManager manager, ProduceDataBase data) { }

	// RVA: 0x1ADFAFC Offset: 0x1ADBAFC VA: 0x1ADFAFC
	private void HarvestButton(bool isHarvest, Vector3 pos, string text) { }

	// RVA: 0x1AE0220 Offset: 0x1ADC220 VA: 0x1AE0220
	private void SetWaterPanel(bool isWater, bool isGrowthMax, byte waterNum, int time) { }

	// RVA: 0x1AE08E0 Offset: 0x1ADC8E0 VA: 0x1AE08E0
	public void UpdateWaterMax() { }

	[IteratorStateMachine(typeof(UIHouseCultivationButton.<UpdatePartsModelDataLoad>d__26))]
	// RVA: 0x1ADFC38 Offset: 0x1ADBC38 VA: 0x1ADFC38
	private IEnumerator UpdatePartsModelDataLoad(int produceId, Quaternion rot, int growthPercent) { }

	// RVA: 0x1AE09A8 Offset: 0x1ADC9A8 VA: 0x1AE09A8
	public void OnClickTargetWaterButton() { }

	// RVA: 0x1AE0C04 Offset: 0x1ADCC04 VA: 0x1AE0C04
	public void OnClickTargetProduceHarvest() { }

	// RVA: 0x1AE0E80 Offset: 0x1ADCE80 VA: 0x1AE0E80
	public void .ctor() { }
}
