// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIHouseEditPanel : MonoBehaviour // TypeDefIndex: 7238
{
	// Fields
	[SerializeField]
	private GameObject basePanel; // 0x20
	[SerializeField]
	private GameObject baseBackPanel; // 0x28
	[SerializeField]
	private Transform parentPanel; // 0x30
	[SerializeField]
	private Camera scrollCamera; // 0x38
	[SerializeField]
	private Transform[] cameraArea; // 0x40
	[SerializeField]
	private GameObject iconBase; // 0x48
	[SerializeField]
	private UILabel iconLabelBase; // 0x50
	[SerializeField]
	private GameObject atlasBase; // 0x58
	private Dictionary<int, GameObject> panelList; // 0x60
	private UIDraggableCamera draggableCamera; // 0x68
	private const float uiPanelSize = 100;
	private Vector3 leftBottom; // 0x70
	private UIHousePartitionManager manager; // 0x80

	// Methods

	// RVA: 0x1AE870C Offset: 0x1AE470C VA: 0x1AE870C
	public void SetCenterCameraPosition(Vector3 leftBottom, Vector3 size) { }

	// RVA: 0x1AE88A8 Offset: 0x1AE48A8 VA: 0x1AE88A8
	public void InitButtonTexture(Texture ground, Texture floor) { }

	// RVA: 0x1AE8A88 Offset: 0x1AE4A88 VA: 0x1AE8A88
	public void CreateChipPanel(Vector3 point, Vector3 size, Vector3 pos, UIHousePartitionManager manager) { }

	// RVA: 0x1AE90B0 Offset: 0x1AE50B0 VA: 0x1AE90B0
	public void CameraAreaSet(Vector3 center, Vector3 area) { }

	// RVA: 0x1AE9200 Offset: 0x1AE5200 VA: 0x1AE9200
	public GameObject CreateDoorIcon(int chipId) { }

	// RVA: 0x1AE9568 Offset: 0x1AE5568 VA: 0x1AE9568
	public GameObject CreateWindowIcon(int chipId) { }

	// RVA: 0x1AE9610 Offset: 0x1AE5610 VA: 0x1AE9610
	public GameObject CreateRoomWallIcon(int chipId) { }

	// RVA: 0x1AE9700 Offset: 0x1AE5700 VA: 0x1AE9700
	public GameObject CreateStartIcon(int partitionId) { }

	// RVA: 0x1AE97D8 Offset: 0x1AE57D8 VA: 0x1AE97D8
	public GameObject CreatePetStartIcon(int partitionId, string name) { }

	// RVA: 0x1AE9A34 Offset: 0x1AE5A34 VA: 0x1AE9A34
	public GameObject CreateFloorIcon(int chipId) { }

	// RVA: 0x1AE9BB8 Offset: 0x1AE5BB8 VA: 0x1AE9BB8
	public GameObject CreateChipAtlas() { }

	// RVA: 0x1AE93F4 Offset: 0x1AE53F4 VA: 0x1AE93F4
	private UISprite SetIconObject(GameObject baseObj, Vector3 pos, string spriteName) { }

	// RVA: 0x1AE9D04 Offset: 0x1AE5D04 VA: 0x1AE9D04
	public void AddPanelObject(GameObject obj, Vector3 pos, float scale) { }

	// RVA: 0x1AE9E58 Offset: 0x1AE5E58 VA: 0x1AE9E58
	public void AddScreenObject(GameObject obj, Vector3 pos, float scale) { }

	// RVA: 0x1AE8860 Offset: 0x1AE4860 VA: 0x1AE8860
	public Vector3 GetPanelPosition(int panelId) { }

	// RVA: 0x1AE92A8 Offset: 0x1AE52A8 VA: 0x1AE92A8
	public Vector3 GetWallItemPosition(int wallId) { }

	// RVA: 0x1AE9F98 Offset: 0x1AE5F98 VA: 0x1AE9F98
	public void OnClickPanel(int chipId) { }

	// RVA: 0x1AEA090 Offset: 0x1AE6090 VA: 0x1AEA090
	public void .ctor() { }
}
