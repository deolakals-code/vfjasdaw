// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIComboWindow : MonoBehaviour // TypeDefIndex: 6875
{
	// Fields
	private readonly List<SkillId> NoStatingPointSkill; // 0x20
	private readonly List<SkillId> NotSetSkill; // 0x28
	private byte comboId; // 0x30
	private int comboDepth; // 0x34
	private int useCp; // 0x38
	private int maxCp; // 0x3C
	private short[] comboSkillId; // 0x40
	private byte[] comboBufferType; // 0x48
	[SerializeField]
	private UILabel comboTitleLabel; // 0x50
	[SerializeField]
	private GameObject comboSkillButton; // 0x58
	private UILabel comboSkillLabel; // 0x60
	private UIIcon comboSkillIcon; // 0x68
	[SerializeField]
	private UILabel comboMessageLabel; // 0x70
	[SerializeField]
	private GameObject comboBufferButton; // 0x78
	private UILabel comboBufferLabel; // 0x80
	private UIIcon comboBufferIcon; // 0x88
	[SerializeField]
	private UILabel comboBufferText; // 0x90
	[SerializeField]
	private GameObject comboBufferInactiveLabel; // 0x98
	[SerializeField]
	private UISprite comboBufferInactiveIcon; // 0xA0
	[SerializeField]
	private GameObject addButton; // 0xA8
	private UISprite addSprite; // 0xB0
	private UILabel addLabel; // 0xB8
	private BoxCollider addButtonCol; // 0xC0
	[SerializeField]
	private GameObject addCombFrameButton; // 0xC8
	[SerializeField]
	private GameObject deleteCombButton; // 0xD0
	[SerializeField]
	private GameObject subButton; // 0xD8
	[SerializeField]
	private GameObject pageDownButton; // 0xE0
	[SerializeField]
	private GameObject pageSwitchButton; // 0xE8
	private UICamera uiCamera; // 0xF0
	private Camera windowCamera; // 0xF8
	private int selectPage; // 0x100
	private SystemTextManager systemTManager; // 0x108
	private SkillTextManager skillTManager; // 0x110
	[SerializeField]
	private GameObject scrollButton; // 0x118
	private UIScrollWindow scrollWindow; // 0x120
	private UIIruna2Anchor scrollWindowAnchor; // 0x128
	private InactiveTimer scrollWindowTimer; // 0x130
	private Vector3 scrollPosition; // 0x138
	[SerializeField]
	private GameObject baseComboSkillIcon; // 0x148
	private List<UIComboIcon> comboSkillIconList; // 0x150
	private UIComboPanelManager uiComboPanelManager; // 0x158
	private PlayerDataManager playerDataManager; // 0x160
	private List<short> availableSkillIDList; // 0x168
	private Dictionary<int, List<SkillMasterData>> availableSkillDataList; // 0x170
	private UIComboWindow.PageState pageState; // 0x178

	// Properties
	public Camera WindowCamera { get; }
	private SystemTextManager systemTextManager { get; }
	private SkillTextManager skillTextManager { get; }

	// Methods

	// RVA: 0x1A264D4 Offset: 0x1A224D4 VA: 0x1A264D4
	public Camera get_WindowCamera() { }

	// RVA: 0x1A26584 Offset: 0x1A22584 VA: 0x1A26584
	private SystemTextManager get_systemTextManager() { }

	// RVA: 0x1A26674 Offset: 0x1A22674 VA: 0x1A26674
	private SkillTextManager get_skillTextManager() { }

	// RVA: 0x1A203BC Offset: 0x1A1C3BC VA: 0x1A203BC
	public void Initialize(UIComboPanelManager manager) { }

	// RVA: 0x1A23468 Offset: 0x1A1F468 VA: 0x1A23468
	public void OpenPanel(byte comboId, SkillComboLine customLine, byte cp) { }

	// RVA: 0x1A26CE0 Offset: 0x1A22CE0 VA: 0x1A26CE0
	private void SetComboData(int pageId) { }

	// RVA: 0x1A27760 Offset: 0x1A23760 VA: 0x1A27760
	private bool IsMpOverSkill(short id) { }

	// RVA: 0x1A278F4 Offset: 0x1A238F4 VA: 0x1A278F4
	private void SetLeftButton(string spriteName, bool colAcitve, string text) { }

	// RVA: 0x1A2798C Offset: 0x1A2398C VA: 0x1A2798C
	private void OnAddPushButton() { }

	// RVA: 0x1A27B44 Offset: 0x1A23B44 VA: 0x1A27B44
	private void OnSubPushButton() { }

	// RVA: 0x1A1F850 Offset: 0x1A1B850 VA: 0x1A1F850
	public void SetPage(int page) { }

	// RVA: 0x1A27BC8 Offset: 0x1A23BC8 VA: 0x1A27BC8
	private void Update() { }

	// RVA: 0x1A27C6C Offset: 0x1A23C6C VA: 0x1A27C6C
	private void SaveComboLine() { }

	// RVA: 0x1A2460C Offset: 0x1A2060C VA: 0x1A2460C
	public void OnLeftTopButton() { }

	// RVA: 0x1A246EC Offset: 0x1A206EC VA: 0x1A246EC
	public void OnRightTopButton() { }

	// RVA: 0x1A28084 Offset: 0x1A24084 VA: 0x1A28084
	private void OnPushSkill() { }

	// RVA: 0x1A28F00 Offset: 0x1A24F00 VA: 0x1A28F00
	private void OnPushSkillTree(int skillTreeType) { }

	// RVA: 0x1A29BB8 Offset: 0x1A25BB8 VA: 0x1A29BB8
	private void OnSwitchPage() { }

	// RVA: 0x1A286D0 Offset: 0x1A246D0 VA: 0x1A286D0
	private void OnSwitchSkillList() { }

	// RVA: 0x1A27EC8 Offset: 0x1A23EC8 VA: 0x1A27EC8
	private void OnSwitchSkillTreeList() { }

	// RVA: 0x1A2A1C8 Offset: 0x1A261C8 VA: 0x1A2A1C8
	private void OnHoverSkillTreeButton(int id) { }

	// RVA: 0x1A2A270 Offset: 0x1A26270 VA: 0x1A2A270
	private void OnHoverSkillId(int id) { }

	// RVA: 0x1A2A338 Offset: 0x1A26338 VA: 0x1A2A338
	public void OnClickSkillId(int id) { }

	// RVA: 0x1A2A640 Offset: 0x1A26640 VA: 0x1A2A640
	public void OnPushBuffer() { }

	// RVA: 0x1A2AA68 Offset: 0x1A26A68 VA: 0x1A2AA68
	public void OnHoverBufferId(int id) { }

	// RVA: 0x1A2AB3C Offset: 0x1A26B3C VA: 0x1A2AB3C
	public void OnClickBufferId(int id) { }

	// RVA: 0x1A295B0 Offset: 0x1A255B0 VA: 0x1A295B0
	private void OpenScrollPanel() { }

	// RVA: 0x1A2161C Offset: 0x1A1D61C VA: 0x1A2161C
	public void CloseScrollPanel() { }

	// RVA: 0x1A2AC44 Offset: 0x1A26C44 VA: 0x1A2AC44
	private void OnCliclDeleteComboFrame() { }

	// RVA: 0x1A2AE3C Offset: 0x1A26E3C VA: 0x1A2AE3C
	private void OnCliclAddComboFrame() { }

	// RVA: 0x1A26764 Offset: 0x1A22764 VA: 0x1A26764
	private void AddComboIconUpdate(short skillId, byte buffer, int index) { }

	// RVA: 0x1A2A4BC Offset: 0x1A264BC VA: 0x1A2A4BC
	private void RemoveComboIcon(int index) { }

	// RVA: 0x1A26A64 Offset: 0x1A22A64 VA: 0x1A26A64
	private void UpdateComboIcon() { }

	// RVA: 0x1A27ACC Offset: 0x1A23ACC VA: 0x1A27ACC
	private int UpdateComboPoint() { }

	// RVA: 0x1A2B038 Offset: 0x1A27038 VA: 0x1A2B038
	private void OnClickPageDownButton() { }

	// RVA: 0x1A2B120 Offset: 0x1A27120 VA: 0x1A2B120
	private void OnClickPageSwitchButton() { }

	// RVA: 0x1A280E8 Offset: 0x1A240E8 VA: 0x1A280E8
	private void SetAvailableSkillList() { }

	// RVA: 0x1A2B124 Offset: 0x1A27124 VA: 0x1A2B124
	private bool CheckUsedSpecialSkill(SkillMasterData skillMaster) { }

	// RVA: 0x1A2B1E0 Offset: 0x1A271E0 VA: 0x1A2B1E0
	private GameObject CreateScrollButton(int id, string hoverMessage, string clickMessage) { }

	// RVA: 0x1A29A48 Offset: 0x1A25A48 VA: 0x1A29A48
	private void SetButton(string label, int id, string hoverMessage, string clickMessage, string iconName) { }

	// RVA: 0x1A29790 Offset: 0x1A25790 VA: 0x1A29790
	private void SetSkillButton(string label, int id, string hoverMessage, string clickMessage, int mpCost) { }

	// RVA: 0x1A29BCC Offset: 0x1A25BCC VA: 0x1A29BCC
	private void SetSkillTreeButton() { }

	// RVA: 0x1A2A8FC Offset: 0x1A268FC VA: 0x1A2A8FC
	private void SetBufferButton(string label, int id, string hoverMessage, string clickMessage) { }

	// RVA: 0x1A2B39C Offset: 0x1A2739C VA: 0x1A2B39C
	public void .ctor() { }
}
