// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIStarGemMainManager : UIBasePanel // TypeDefIndex: 8025
{
	// Fields
	[SerializeField]
	private UILabel titleLabel; // 0x30
	[SerializeField]
	private UIIcon titleIcon; // 0x38
	[SerializeField]
	private UIScrollWindow starGemListWindow; // 0x40
	[SerializeField]
	private UICamera starGemUICamera; // 0x48
	[SerializeField]
	private GameObject complatePanel; // 0x50
	[SerializeField]
	private UILabel complateMessagealabel; // 0x58
	[SerializeField]
	private UILabel complateButtonLabels; // 0x60
	[SerializeField]
	private UILabel complateButtonUpLabel; // 0x68
	[SerializeField]
	private UIStarGemElement element; // 0x70
	[SerializeField]
	private GameObject noPossessionMesObj; // 0x78
	[SerializeField]
	private GameObject completeBackIcon; // 0x80
	[SerializeField]
	private GameObject removeWindowObj; // 0x88
	[SerializeField]
	private GameObject removeSkillElement; // 0x90
	[SerializeField]
	private UIScrollWindow removeWindow; // 0x98
	[SerializeField]
	private GameObject bottomObj; // 0xA0
	[SerializeField]
	private GameObject ErrObj; // 0xA8
	private UIStarGemBasePanel[] panel; // 0xB0
	private UIStarGemMainManager.PanelState state; // 0xB8
	private SkillTextManager skillTextManager; // 0xC0
	private MasterSkillDataManager masterSkillManager; // 0xC8
	private Dictionary<SkillTreeType, List<SkillMasterData>> createSkillList; // 0xD0
	private PlayerDataManager playerDataManager; // 0xD8
	private GameObject listButtonObj; // 0xE0
	private GameObject skillIconObj; // 0xE8
	private bool isSkillPopWindow; // 0xF0
	private UIPopBaseWindow popWindow; // 0xF8
	private Dictionary<byte, long> equipDatas; // 0x100
	private StarGemData selectStarGem; // 0x108
	private List<GameObject> buttonList; // 0x110
	private bool isCompleteActive; // 0x118
	private List<StarGemData> equipStarGemList; // 0x120
	private Dictionary<long, bool> clientEquipList; // 0x128
	public Action complateCloseAction; // 0x130

	// Properties
	public Vector3 scrollButtonBasePos { get; }
	public float scrollButtonSpaceHeight { get; }
	public GameObject ActivePanel { get; }
	public bool IsScrollActive { get; }
	public bool IsActiveRemoveWindow { get; }

	// Methods

	// RVA: 0x1C9FBFC Offset: 0x1C9BBFC VA: 0x1C9FBFC
	public Vector3 get_scrollButtonBasePos() { }

	// RVA: 0x1C99C8C Offset: 0x1C95C8C VA: 0x1C99C8C
	public float get_scrollButtonSpaceHeight() { }

	// RVA: 0x1C927E4 Offset: 0x1C8E7E4 VA: 0x1C927E4
	public GameObject get_ActivePanel() { }

	// RVA: 0x1C9A558 Offset: 0x1C96558 VA: 0x1C9A558
	public bool get_IsScrollActive() { }

	// RVA: 0x1C915A8 Offset: 0x1C8D5A8 VA: 0x1C915A8
	public bool get_IsActiveRemoveWindow() { }

	[IteratorStateMachine(typeof(UIStarGemMainManager.<Start>d__44))]
	// RVA: 0x1C9FC40 Offset: 0x1C9BC40 VA: 0x1C9FC40
	private IEnumerator Start() { }

	// RVA: 0x1C9FCD4 Offset: 0x1C9BCD4 VA: 0x1C9FCD4
	private void Update() { }

	// RVA: 0x1CA0004 Offset: 0x1C9C004 VA: 0x1CA0004
	private UIStarGemBasePanel LoadPanel(string path) { }

	// RVA: 0x1CA0234 Offset: 0x1C9C234 VA: 0x1CA0234
	private void OnDestroy() { }

	// RVA: 0x1C932F8 Offset: 0x1C8F2F8 VA: 0x1C932F8
	public bool EquipStarGemRegister() { }

	// RVA: 0x1CA027C Offset: 0x1C9C27C VA: 0x1CA027C Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1CA0440 Offset: 0x1C9C440 VA: 0x1CA0440 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1C91620 Offset: 0x1C8D620 VA: 0x1C91620
	public void ChangePanelState(UIStarGemMainManager.PanelState change) { }

	// RVA: 0x1C913B0 Offset: 0x1C8D3B0 VA: 0x1C913B0
	public void ChangeTitleLabel(string icon, string title) { }

	// RVA: 0x1C929E4 Offset: 0x1C8E9E4 VA: 0x1C929E4
	public void OpenSkillPopWindow(int skillId, int skillLv, string text, string buttonText, string iconName, bool buttonEnabled, Action act) { }

	// RVA: 0x1C95600 Offset: 0x1C91600 VA: 0x1C95600
	public void OpenSkillPopWindow(int skillId, string text, string buttonText, string iconName, bool buttonEnabled, Action act) { }

	[IteratorStateMachine(typeof(UIStarGemMainManager.<openSkillPopWindow>d__55))]
	// RVA: 0x1CA05F8 Offset: 0x1C9C5F8 VA: 0x1CA05F8
	private IEnumerator openSkillPopWindow(int skillId, int skillLv, string text, string buttonText, string iconName, bool buttonEnabled, Action act) { }

	// RVA: 0x1C9F6B4 Offset: 0x1C9B6B4 VA: 0x1C9F6B4
	public void PopComplatePanel(string title, string mes, string bottomMes, StarGemData gem, Action complateCloseAction) { }

	// RVA: 0x1C96F4C Offset: 0x1C92F4C VA: 0x1C96F4C
	public void PopCreateComplatePanel(string title, string mes, string bottomMes, StarGemData gem, Action complateCloseAction) { }

	// RVA: 0x1CA06F4 Offset: 0x1C9C6F4 VA: 0x1CA06F4
	private void CloseComplatePanelButton() { }

	// RVA: 0x1C944B0 Offset: 0x1C904B0 VA: 0x1C944B0
	public void CloseComplatePanel() { }

	// RVA: 0x1CA0710 Offset: 0x1C9C710 VA: 0x1CA0710
	private void OpenRemoveWindow(short[] idList, byte[] levelList) { }

	// RVA: 0x1C915C4 Offset: 0x1C8D5C4 VA: 0x1C915C4
	public void CloseRemoveWindow() { }

	// RVA: 0x1C9EC34 Offset: 0x1C9AC34 VA: 0x1C9EC34
	public void DuplicationEquipRemove(Action act) { }

	[IteratorStateMachine(typeof(UIStarGemMainManager.<DuplicationEquipGemRemove>d__63))]
	// RVA: 0x1CA0A98 Offset: 0x1C9CA98 VA: 0x1CA0A98
	private IEnumerator DuplicationEquipGemRemove(Action act) { }

	// RVA: 0x1C935CC Offset: 0x1C8F5CC VA: 0x1C935CC
	public void UpdateClientEquipList() { }

	// RVA: 0x1C9B50C Offset: 0x1C9750C VA: 0x1C9B50C
	public void SetEquipClientEquipList(long uuid, bool isEquip) { }

	// RVA: 0x1CA0B48 Offset: 0x1C9CB48 VA: 0x1CA0B48
	private void UpdateEquipList() { }

	// RVA: 0x1C91B58 Offset: 0x1C8DB58 VA: 0x1C91B58
	public void SetEnableStarGemListWindow(bool enabled) { }

	// RVA: 0x1C92258 Offset: 0x1C8E258 VA: 0x1C92258
	public void SetActiveStarGemListWindow(bool flag) { }

	// RVA: 0x1C9B7FC Offset: 0x1C977FC VA: 0x1C9B7FC
	public GameObject CreateResetSkillButton(GameObject target) { }

	// RVA: 0x1C9AAC4 Offset: 0x1C96AC4 VA: 0x1C9AAC4
	public List<GameObject> CreateBagStarGemList(GameObject target, string message, bool isSetSkill, Func<StarGemData, bool> createCheck) { }

	// RVA: 0x1C91C30 Offset: 0x1C8DC30 VA: 0x1C91C30
	public List<GameObject> CreateBagStarGemList(GameObject target, string message) { }

	// RVA: 0x1CA1110 Offset: 0x1C9D110 VA: 0x1CA1110
	public List<GameObject> CreateSpecificSkillStarGemList(GameObject target, string message, short skillId) { }

	// RVA: 0x1CA0BF0 Offset: 0x1C9CBF0 VA: 0x1CA0BF0
	private GameObject AddEquipResetButton(Vector3 pos, GameObject target, string message, string buttonText, string spriteName) { }

	// RVA: 0x1CA0DA0 Offset: 0x1C9CDA0 VA: 0x1CA0DA0
	private GameObject AddPossessionGemButton(StarGemData data, Vector3 pos, GameObject target, string message) { }

	// RVA: 0x1C945E0 Offset: 0x1C905E0 VA: 0x1C945E0
	public List<GameObject> CreateStarGemSkillTreeTypeList(GameObject target, string message) { }

	// RVA: 0x1CA1718 Offset: 0x1C9D718 VA: 0x1CA1718
	private GameObject AddSkillTreeButton(SkillTreeType type, Vector3 pos, GameObject target, string func) { }

	// RVA: 0x1C94DE4 Offset: 0x1C90DE4 VA: 0x1C94DE4
	public List<GameObject> CreateStarGemSkillTreeList(int skillTreeId, GameObject target, string message) { }

	// RVA: 0x1CA1BE0 Offset: 0x1C9DBE0 VA: 0x1CA1BE0
	private GameObject AddSkillButton(int skillId, Vector3 pos, GameObject target, string func) { }

	// RVA: 0x1CA198C Offset: 0x1C9D98C VA: 0x1CA198C
	private GameObject AddBackButton(Vector3 pos, GameObject target, string func) { }

	// RVA: 0x1CA0D80 Offset: 0x1C9CD80 VA: 0x1CA0D80
	private void SetEnableNoGemMessage(bool isEnable) { }

	// RVA: 0x1C9FD24 Offset: 0x1C9BD24 VA: 0x1C9FD24
	private void UpdateScrollElementActive() { }

	// RVA: 0x1CA1E18 Offset: 0x1C9DE18 VA: 0x1CA1E18
	public void ChangeSkillMenuPanel() { }

	// RVA: 0x1CA1E6C Offset: 0x1C9DE6C VA: 0x1CA1E6C
	public void .ctor() { }
}
