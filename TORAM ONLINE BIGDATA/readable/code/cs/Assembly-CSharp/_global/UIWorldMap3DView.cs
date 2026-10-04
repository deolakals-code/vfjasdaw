// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIWorldMap3DView : MonoBehaviour // TypeDefIndex: 7384
{
	// Fields
	private readonly float animationScale; // 0x20
	[SerializeField]
	private UIFont fontData; // 0x28
	[SerializeField]
	private UIAtlas iconAtlasData; // 0x30
	[SerializeField]
	private float offsetX; // 0x38
	[SerializeField]
	private float fade; // 0x3C
	private GameObject playerModel; // 0x40
	private ClonePlayerAnimation playerAnimation; // 0x48
	private int playerLevel; // 0x50
	private GameObject worldModel; // 0x58
	private Camera thisCamera; // 0x60
	private Material[] worldModelMaterials; // 0x68
	private Mesh[] worldModelMeshs; // 0x70
	private Dictionary<int, List<UIWorldMap3DView.ViewModelData>> transList; // 0x78
	private Dictionary<int, Vector3> positionList; // 0x80
	private Dictionary<byte, string> popTextData; // 0x88
	private FieldTextManager fieldTextManager; // 0x90
	private Vector3 updateCameraPos; // 0x98
	private Vector3 minPos; // 0xA4
	private Vector3 maxPos; // 0xB0
	private int selectedFieldId; // 0xBC
	private float selectedFieldAnimationTimer; // 0xC0
	private int cancelFieldId; // 0xC4
	private float cancelFieldAnimationTimer; // 0xC8
	private UIGL3DLabelView bonusLabel; // 0xD0
	private UIGLSpriteView bonusIcon; // 0xD8
	private UIGLSpriteView warpIcon; // 0xE0
	private bool isExIcon; // 0xE8
	private bool isActive; // 0xE9
	private float iconAnimationY; // 0xEC
	private Vector3 setPlayerPosition; // 0xF0
	private Animation thisAnimation; // 0x100
	private int rootModelId; // 0x108
	public bool IsPickupView; // 0x10C

	// Methods

	// RVA: 0x1B32B0C Offset: 0x1B2EB0C VA: 0x1B32B0C
	private void Awake() { }

	// RVA: 0x1B32BB0 Offset: 0x1B2EBB0 VA: 0x1B32BB0
	public void Initialize(GameObject player, int playerLevel, GameObject worldModel, int modelNum, Dictionary<byte, string> popTextDat, FieldTextManager fieldTextManager) { }

	// RVA: 0x1B3317C Offset: 0x1B2F17C VA: 0x1B3317C
	private void OnDestroy() { }

	// RVA: 0x1B32FE4 Offset: 0x1B2EFE4 VA: 0x1B32FE4
	private void SetMeshData(string name, int id) { }

	// RVA: 0x1B3320C Offset: 0x1B2F20C VA: 0x1B3320C
	private List<UIWorldMap3DView.ViewModelData> GetTransList(int id) { }

	// RVA: 0x1B332EC Offset: 0x1B2F2EC VA: 0x1B332EC
	public void SetWorldMap(byte worldId, List<UIWorldMapPanel.WorldMapData> worldMapDataList, int fieldId, bool isAllView) { }

	// RVA: 0x1B3483C Offset: 0x1B3083C VA: 0x1B3483C
	public bool TryGetTapFieldId(Vector3 touchPos, out int hitField) { }

	// RVA: 0x1B34A80 Offset: 0x1B30A80 VA: 0x1B34A80
	public bool SelectedFieldId(int fieldId, bool isLookAt) { }

	// RVA: 0x1B34D34 Offset: 0x1B30D34 VA: 0x1B34D34
	public bool SelectedClear() { }

	// RVA: 0x1B34E78 Offset: 0x1B30E78 VA: 0x1B34E78
	public void SetDrawActive(bool active) { }

	// RVA: 0x1B344FC Offset: 0x1B304FC VA: 0x1B344FC
	public void UpdateViewArea() { }

	// RVA: 0x1B34EEC Offset: 0x1B30EEC VA: 0x1B34EEC
	public void FadeAnimation() { }

	// RVA: 0x1B34F40 Offset: 0x1B30F40 VA: 0x1B34F40
	private void LateUpdate() { }

	// RVA: 0x1B34030 Offset: 0x1B30030 VA: 0x1B34030
	private void SetPlayerModel(Vector3 position) { }

	// RVA: 0x1B351D4 Offset: 0x1B311D4 VA: 0x1B351D4
	private void OnRenderObject() { }

	// RVA: 0x1B36C8C Offset: 0x1B32C8C VA: 0x1B36C8C
	public void .ctor() { }
}
