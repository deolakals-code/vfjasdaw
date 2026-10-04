// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIHouseItemButton : MonoBehaviour // TypeDefIndex: 7250
{
	// Fields
	[SerializeField]
	private GameObject lockIcon; // 0x20
	[SerializeField]
	private GameObject countIcon; // 0x28
	[SerializeField]
	private UILabel countLabel; // 0x30
	[SerializeField]
	private UILabel nameLabel; // 0x38
	[CompilerGenerated]
	private bool <IsLoadedModel>k__BackingField; // 0x40
	private HousePartsModelType setType; // 0x44
	private int setItemId; // 0x48
	private int setModelId; // 0x4C

	// Properties
	public bool IsLoadedModel { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1AED3D0 Offset: 0x1AE93D0 VA: 0x1AED3D0
	public bool get_IsLoadedModel() { }

	[CompilerGenerated]
	// RVA: 0x1AED3D8 Offset: 0x1AE93D8 VA: 0x1AED3D8
	private void set_IsLoadedModel(bool value) { }

	// RVA: 0x1AED3E4 Offset: 0x1AE93E4 VA: 0x1AED3E4
	public void SetLockIcon(bool active) { }

	// RVA: 0x1AED47C Offset: 0x1AE947C VA: 0x1AED47C
	public void SetCountLabel(string label) { }

	// RVA: 0x1AE3160 Offset: 0x1ADF160 VA: 0x1AE3160
	public void SetLabel(string label) { }

	// RVA: 0x1AE313C Offset: 0x1ADF13C VA: 0x1AE313C
	public void UpdatePartsModelData(HousePartsModelType type, int itemId, string assetPath, string fliePath) { }

	// RVA: 0x1AED5D8 Offset: 0x1AE95D8 VA: 0x1AED5D8
	public void UpdatePartsModelData(HousePartsModelType type, int itemId, int modelId) { }

	// RVA: 0x1AED70C Offset: 0x1AE970C VA: 0x1AED70C
	public void SetLoadPartsModelData(HousePartsModelType type, int itemId, int modelId) { }

	// RVA: 0x1AED71C Offset: 0x1AE971C VA: 0x1AED71C
	public void LoadingStart() { }

	[IteratorStateMachine(typeof(UIHouseItemButton.<UpdatePartsModelDataLoad>d__18))]
	// RVA: 0x1AED528 Offset: 0x1AE9528 VA: 0x1AED528
	private IEnumerator UpdatePartsModelDataLoad(HousePartsModelType type, int itemId, string assetPath, string fliePath) { }

	// RVA: 0x1AED75C Offset: 0x1AE975C VA: 0x1AED75C
	private void UpdatePartsModel(HousePartsModelType type, Transform model, Vector3 pos, Vector3 rot, float scale) { }

	// RVA: 0x1AED860 Offset: 0x1AE9860 VA: 0x1AED860
	private void UpdatePartsModel(HousePartsModelType type, GameObject model, Vector3 pos, Vector3 rot, float scale) { }

	// RVA: 0x1AEDA50 Offset: 0x1AE9A50 VA: 0x1AEDA50
	public void .ctor() { }
}
