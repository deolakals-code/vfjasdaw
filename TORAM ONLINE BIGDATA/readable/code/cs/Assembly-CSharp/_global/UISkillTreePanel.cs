// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UISkillTreePanel : MonoBehaviour // TypeDefIndex: 6890
{
	// Fields
	[SerializeField]
	private GameObject panel; // 0x20
	[SerializeField]
	private GameObject line; // 0x28
	[SerializeField]
	private GameObject skillIconObject; // 0x30
	[SerializeField]
	private GameObject viewCamera; // 0x38
	private Camera viewCameraObj; // 0x40
	private UICamera uiCamera; // 0x48
	private UIIruna2Viewport viewport; // 0x50
	private UISkillTreeDraggableCamera draggableCamera; // 0x58
	private List<Vector3> skillTreePositionList; // 0x60
	[SerializeField]
	private UIWidget topBar; // 0x68
	[SerializeField]
	private UIWidget bottomBar; // 0x70
	[SerializeField]
	private UIWidget leftBar; // 0x78
	[SerializeField]
	private UIWidget rightBar; // 0x80
	[SerializeField]
	private UIWidget topFrameSprite; // 0x88
	[SerializeField]
	private UIWidget bottomFrameSprite; // 0x90
	[SerializeField]
	private UIWidget leftFrameSprite; // 0x98
	[SerializeField]
	private UIWidget rightFrameSprite; // 0xA0
	private PlayerDataManager playerDataManager; // 0xA8
	private int skillTreeLevel; // 0xB0
	private SkillTreeType selectSkillTreeType; // 0xB4
	private Dictionary<int, UISkillSelectIcon> skillIconList; // 0xB8
	private List<GameObject> treeObject; // 0xC0
	private List<GameObject> wideMapObject; // 0xC8
	private UISkillSelectIcon selectIcon; // 0xD0
	private readonly int[] spriteId; // 0xD8
	private byte[] skillTreePanelX; // 0xE0
	private byte[] skillTreePanelY; // 0xE8
	private int width; // 0xF0
	private int height; // 0xF4
	private Vector2 cameraInitPosition; // 0xF8
	[SerializeField]
	private UILabel skillTreeTypeLabel; // 0x100
	[SerializeField]
	private GameObject skillTreeIconObject; // 0x108
	private UIIcon skillTreeIcon; // 0x110
	[SerializeField]
	private GameObject selectedButton; // 0x118
	[SerializeField]
	private UILabel selectedSkillLabel; // 0x120
	[SerializeField]
	private GameObject skillPointObject; // 0x128
	[SerializeField]
	private GameObject skillWideMapObject; // 0x130
	[SerializeField]
	private UISprite skillWideMapArea; // 0x138
	[SerializeField]
	private UILabel skillPointLabel; // 0x140
	private Dictionary<int, SkillMasterData> skillListData; // 0x148
	private int mapChipSize; // 0x150
	[SerializeField]
	private GameObject levelUpObject; // 0x158
	private UIIruna2Label levelUpLabel; // 0x160
	private TweenAlpha levelUpTweenAlpha; // 0x168
	[SerializeField]
	private GameObject selectSkillTreeReset; // 0x170
	[SerializeField]
	private UILabel selectSkillTreeResetButtonLabel; // 0x178
	[SerializeField]
	private UISprite selectSkillTreeResetButtonIcon; // 0x180
	[SerializeField]
	private UIButtonColor selectSkillTreeResetButtonColor; // 0x188
	[SerializeField]
	private UIImageButton selectSkillTreeResetImageButton; // 0x190
	private SkillTextManager skillTManager; // 0x198
	private SystemTextManager sysTManager; // 0x1A0

	// Properties
	private SkillTextManager skillTextManager { get; }
	private SystemTextManager systemTextManager { get; }

	// Methods

	// RVA: 0x1A381B0 Offset: 0x1A341B0 VA: 0x1A381B0
	private SkillTextManager get_skillTextManager() { }

	// RVA: 0x1A382A0 Offset: 0x1A342A0 VA: 0x1A382A0
	private SystemTextManager get_systemTextManager() { }

	// RVA: 0x1A38390 Offset: 0x1A34390 VA: 0x1A38390
	private void Update() { }

	// RVA: 0x1A3845C Offset: 0x1A3445C VA: 0x1A3845C
	private void Awake() { }

	// RVA: 0x1A336A4 Offset: 0x1A2F6A4 VA: 0x1A336A4
	public void PanelOpen(int skillType) { }

	// RVA: 0x1A3877C Offset: 0x1A3477C VA: 0x1A3877C
	private void TreeCreate() { }

	// RVA: 0x1A3A148 Offset: 0x1A36148 VA: 0x1A3A148
	private void CrankCheckHegiht(int x, int y) { }

	// RVA: 0x1A3A6F8 Offset: 0x1A366F8 VA: 0x1A3A6F8
	private void CrankCheckWidth(int x, int y) { }

	// RVA: 0x1A3AD3C Offset: 0x1A36D3C VA: 0x1A3AD3C
	private void CreateLine(Vector3 position, Vector2 size, UIWidget.Pivot pivot, string spriteName, Color setColor, int depth, bool portrait) { }

	// RVA: 0x1A3AAF8 Offset: 0x1A36AF8 VA: 0x1A3AAF8
	private GameObject CreateLineObject(Transform parent, Vector3 position, Vector2 size, UIWidget.Pivot pivot, string spriteName, Color setColor, int depth) { }

	// RVA: 0x1A39BE4 Offset: 0x1A35BE4 VA: 0x1A39BE4
	private void DrawLine(int parentStartPoint, int endPoint, int x, int y, int parentX, int parentY, int skillId, int level, int parentLevel) { }

	// RVA: 0x1A3AF98 Offset: 0x1A36F98 VA: 0x1A3AF98
	private void DrawLineCheck(int point1x, int point1y, int point2x, int point2y, int level) { }

	// RVA: 0x1A33C88 Offset: 0x1A2FC88 VA: 0x1A33C88
	public void SelectSkill(int skillId) { }

	// RVA: 0x1A34138 Offset: 0x1A30138 VA: 0x1A34138
	public void PopWindowOpen() { }

	// RVA: 0x1A34324 Offset: 0x1A30324 VA: 0x1A34324
	public void PopWindowClose(bool reCreate) { }

	// RVA: 0x1A3331C Offset: 0x1A2F31C VA: 0x1A3331C
	public int PopUpSkillTreeReset() { }

	// RVA: 0x1A39930 Offset: 0x1A35930 VA: 0x1A39930
	private void UpdateSkillResetButtonText() { }

	// RVA: 0x1A33238 Offset: 0x1A2F238 VA: 0x1A33238
	public void SelectSkillCancel() { }

	// RVA: 0x1A353D8 Offset: 0x1A313D8 VA: 0x1A353D8
	public void SkillLevelUp() { }

	// RVA: 0x1A326B0 Offset: 0x1A2E6B0 VA: 0x1A326B0
	public void PanelClose() { }

	// RVA: 0x1A38460 Offset: 0x1A34460 VA: 0x1A38460
	private void LoadSkillTreeText() { }

	// RVA: 0x1A3B068 Offset: 0x1A37068 VA: 0x1A3B068
	public void .ctor() { }
}
