// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPetSkillTreePanel : MonoBehaviour // TypeDefIndex: 7841
{
	// Fields
	[SerializeField]
	private GameObject skillTreePanel; // 0x20
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
	private Dictionary<int, UIPetSkillSelectIcon> skillIconList; // 0xB8
	private List<GameObject> treeObject; // 0xC0
	private List<GameObject> wideMapObject; // 0xC8
	private UIPetSkillSelectIcon selectIcon; // 0xD0
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
	private GameObject skillWideMapObject; // 0x120
	[SerializeField]
	private UISprite skillWideMapArea; // 0x128
	private Dictionary<int, SkillMasterData> skillListData; // 0x130
	private int mapChipSize; // 0x138
	[SerializeField]
	private GameObject levelUpObject; // 0x140
	private UIIruna2Label levelUpLabel; // 0x148
	private TweenAlpha levelUpTweenAlpha; // 0x150
	[SerializeField]
	private GameObject helpButtonObj; // 0x158
	private Dictionary<int, SkillPos> skillPosList; // 0x160
	private bool firstSkillFlag; // 0x168
	private PetDataManager.PetViewData petData; // 0x170
	private Dictionary<int, int> haveSkillList; // 0x178
	private int petSkillCount; // 0x180
	private Dictionary<int, int> inheritSkillList; // 0x188
	private int inheritSkillCount; // 0x190
	private SkillTextManager skillTManager; // 0x198

	// Properties
	private SkillTextManager skillTextManager { get; }

	// Methods

	// RVA: 0x1C34C5C Offset: 0x1C30C5C VA: 0x1C34C5C
	public void HelpButtonActive(bool flag) { }

	// RVA: 0x1C36844 Offset: 0x1C32844 VA: 0x1C36844
	private SkillTextManager get_skillTextManager() { }

	// RVA: 0x1C36934 Offset: 0x1C32934 VA: 0x1C36934
	private void Update() { }

	// RVA: 0x1C35040 Offset: 0x1C31040 VA: 0x1C35040
	public void PanelOpen(int skillType, bool firstFlag, PetDataManager.PetViewData data) { }

	// RVA: 0x1C36E14 Offset: 0x1C32E14 VA: 0x1C36E14
	private void TreeCreate() { }

	// RVA: 0x1C387A8 Offset: 0x1C347A8 VA: 0x1C387A8
	private void CrankCheckHegiht(int x, int y) { }

	// RVA: 0x1C38D58 Offset: 0x1C34D58 VA: 0x1C38D58
	private void CrankCheckWidth(int x, int y) { }

	// RVA: 0x1C3939C Offset: 0x1C3539C VA: 0x1C3939C
	private void CreateLine(Vector3 position, Vector2 size, UIWidget.Pivot pivot, string spriteName, Color setColor, int depth, bool portrait) { }

	// RVA: 0x1C39158 Offset: 0x1C35158 VA: 0x1C39158
	private GameObject CreateLineObject(Transform parent, Vector3 position, Vector2 size, UIWidget.Pivot pivot, string spriteName, Color setColor, int depth) { }

	// RVA: 0x1C37F98 Offset: 0x1C33F98 VA: 0x1C37F98
	private void DrawLine(int parentStartPoint, int endPoint, int x, int y, int parentX, int parentY, int skillId, bool child) { }

	// RVA: 0x1C395F8 Offset: 0x1C355F8 VA: 0x1C395F8
	private void DrawLineCheck(int point1x, int point1y, int point2x, int point2y, bool have, bool isInherit) { }

	// RVA: 0x1C35600 Offset: 0x1C31600 VA: 0x1C35600
	public void SelectSkill(int skillId) { }

	// RVA: 0x1C35BF4 Offset: 0x1C31BF4 VA: 0x1C35BF4
	public void PopWindowOpen() { }

	// RVA: 0x1C35CF8 Offset: 0x1C31CF8 VA: 0x1C35CF8
	public void PopWindowClose(bool reCreate) { }

	// RVA: 0x1C396CC Offset: 0x1C356CC VA: 0x1C396CC
	public int PopUpSkillTreeReset() { }

	// RVA: 0x1C35F34 Offset: 0x1C31F34 VA: 0x1C35F34
	public void SelectSkillCancel() { }

	// RVA: 0x1C3970C Offset: 0x1C3570C VA: 0x1C3970C
	public void SkillLevelUp() { }

	// RVA: 0x1C34C7C Offset: 0x1C30C7C VA: 0x1C34C7C
	public void PanelClose() { }

	// RVA: 0x1C36A00 Offset: 0x1C32A00 VA: 0x1C36A00
	private void LoadSkillTreeText() { }

	// RVA: 0x1C398B4 Offset: 0x1C358B4 VA: 0x1C398B4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1C39BB4 Offset: 0x1C35BB4 VA: 0x1C39BB4
	private bool <DrawLine>b__60_0(KeyValuePair<int, int> a) { }
}
