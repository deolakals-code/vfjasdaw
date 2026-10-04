// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIRegistletMainManager : UIBasePanel // TypeDefIndex: 7922
{
	// Fields
	[SerializeField]
	private UIScrollWindow registletListWindow; // 0x30
	[SerializeField]
	private UISprite listBackPanel; // 0x38
	[SerializeField]
	private UICamera registletUICamera; // 0x40
	[SerializeField]
	private GameObject registletElement; // 0x48
	[SerializeField]
	private GameObject noPossessionMesObj; // 0x50
	[SerializeField]
	private GameObject detailWindowObj; // 0x58
	[SerializeField]
	private UILabel detailWindowTitleLabel; // 0x60
	[SerializeField]
	private UILabel detailWindowMesLabel; // 0x68
	[SerializeField]
	private UILabel detailWindowButtonLabel; // 0x70
	[SerializeField]
	private UIButtonCallAction detailWindowCallAction; // 0x78
	[SerializeField]
	private UILabel detailWindowLvCapLabel; // 0x80
	[SerializeField]
	private UISprite lockButtonIcon; // 0x88
	[SerializeField]
	private GameObject bottomObj; // 0x90
	[SerializeField]
	private GameObject ErrObj; // 0x98
	[SerializeField]
	private GameObject multiSelectElement; // 0xA0
	[SerializeField]
	private UIInput searchInput; // 0xA8
	[SerializeField]
	private GameObject searchObj; // 0xB0
	[SerializeField]
	private GameObject[] scrollAreaObjs; // 0xB8
	private UIRegistletBasePanel[] panel; // 0xC0
	private UIRegistletMainManager.PanelState state; // 0xC8
	private PlayerDataManager playerDataManager; // 0xD0
	private RegistletManager registletManager; // 0xD8
	private RegistletTextManager registletTextManager; // 0xE0
	private Dictionary<byte, long> equipDatas; // 0xE8
	private GemCartData prevDeteilGemCartData; // 0xF0
	private bool prevLockFlag; // 0xF8
	private UISprite multiSelectButtonIcon; // 0x100
	private UILabel multiSelectButtonLabel; // 0x108
	private Dictionary<int, string> searchNameList; // 0x110
	private List<int> searchIdList; // 0x118

	// Properties
	public Vector3 scrollButtonBasePos { get; }
	public float scrollButtonSpaceHeight { get; }
	public GameObject ActivePanel { get; }
	public bool IsActiveDetailWindow { get; }
	public bool IsOpenGemCartList { get; }
	public List<int> SearchIdList { get; }
	public bool IsActiveSearch { get; }

	// Methods

	// RVA: 0x1C63BB4 Offset: 0x1C5FBB4 VA: 0x1C63BB4
	public Vector3 get_scrollButtonBasePos() { }

	// RVA: 0x1C60894 Offset: 0x1C5C894 VA: 0x1C60894
	public float get_scrollButtonSpaceHeight() { }

	// RVA: 0x1C5E208 Offset: 0x1C5A208 VA: 0x1C5E208
	public GameObject get_ActivePanel() { }

	// RVA: 0x1C5C798 Offset: 0x1C58798 VA: 0x1C5C798
	public bool get_IsActiveDetailWindow() { }

	// RVA: 0x1C61F6C Offset: 0x1C5DF6C VA: 0x1C61F6C
	public bool get_IsOpenGemCartList() { }

	// RVA: 0x1C63BF8 Offset: 0x1C5FBF8 VA: 0x1C63BF8
	public List<int> get_SearchIdList() { }

	// RVA: 0x1C60790 Offset: 0x1C5C790 VA: 0x1C60790
	public bool get_IsActiveSearch() { }

	[IteratorStateMachine(typeof(UIRegistletMainManager.<Start>d__45))]
	// RVA: 0x1C63C00 Offset: 0x1C5FC00 VA: 0x1C63C00
	private IEnumerator Start() { }

	// RVA: 0x1C63C94 Offset: 0x1C5FC94 VA: 0x1C63C94
	private void Update() { }

	// RVA: 0x1C63F28 Offset: 0x1C5FF28 VA: 0x1C63F28
	private void OnDestroy() { }

	// RVA: 0x1C5D170 Offset: 0x1C59170 VA: 0x1C5D170
	public void ChangePanelState(UIRegistletMainManager.PanelState change) { }

	// RVA: 0x1C5E9A4 Offset: 0x1C5A9A4 VA: 0x1C5E9A4
	public bool EquipGemCartRegister() { }

	// RVA: 0x1C5DEAC Offset: 0x1C59EAC VA: 0x1C5DEAC
	public void SetActiveGemCartListWindow(bool flag) { }

	// RVA: 0x1C5DD54 Offset: 0x1C59D54 VA: 0x1C5DD54
	public void SetEnableGemCartListWindow(bool enabled) { }

	// RVA: 0x1C5DE54 Offset: 0x1C59E54 VA: 0x1C5DE54
	public List<UIRegistletListButton> CreateBagGemCartList(UnityAction<int> action, Func<GemCartData, bool> createCheck) { }

	// RVA: 0x1C640C8 Offset: 0x1C600C8 VA: 0x1C640C8
	public List<UIRegistletListButton> CreateBagGemCartList(UnityAction<int> action, UnityAction multiAction, GemCartData[] gemcartDatas, bool isHoldScroll, bool isMultiSelect, Func<GemCartData, bool> createCheck) { }

	// RVA: 0x1C61204 Offset: 0x1C5D204 VA: 0x1C61204
	public List<UIRegistletListButton> CreateBagGemCartList(UnityAction<int> action, UnityAction<int> resetAction, bool isSetSkill, Func<GemCartData, bool> createCheck) { }

	// RVA: 0x1C5C7B4 Offset: 0x1C587B4 VA: 0x1C5C7B4
	public void ChangeActiveDetailWindow(bool isActive, GemCartData data, bool isEquip = False, bool isChange = False, UnityAction action) { }

	// RVA: 0x1C64F4C Offset: 0x1C60F4C VA: 0x1C64F4C
	public void UpdateMultiSelectButton(string iconName, string text) { }

	// RVA: 0x1C5DF3C Offset: 0x1C59F3C VA: 0x1C5DF3C
	public string GetGemPowderText() { }

	// RVA: 0x1C5DFD0 Offset: 0x1C59FD0 VA: 0x1C5DFD0
	public string GetGemCartNumText() { }

	// RVA: 0x1C607AC Offset: 0x1C5C7AC VA: 0x1C607AC
	public void CloseSearchList() { }

	// RVA: 0x1C65024 Offset: 0x1C61024 VA: 0x1C65024
	public void OnLock() { }

	// RVA: 0x1C65080 Offset: 0x1C61080 VA: 0x1C65080
	public void OnSubmitSearch() { }

	// RVA: 0x1C65150 Offset: 0x1C61150 VA: 0x1C65150
	private UIRegistletBasePanel LoadPanel(string path) { }

	// RVA: 0x1C64904 Offset: 0x1C60904 VA: 0x1C64904
	private void SetEnableNoGemMessage(bool isEnable) { }

	// RVA: 0x1C64660 Offset: 0x1C60660 VA: 0x1C64660
	private UIRegistletListButton AddPossessionGemButton(GemCartData data, Vector3 pos, UnityAction<int> action) { }

	// RVA: 0x1C64AEC Offset: 0x1C60AEC VA: 0x1C64AEC
	private UIRegistletListButton AddEquipResetButton(Vector3 pos, UnityAction<int> action) { }

	// RVA: 0x1C64924 Offset: 0x1C60924 VA: 0x1C64924
	private UIRegistletListButton AddNameSearchButton(Vector3 pos) { }

	// RVA: 0x1C64C64 Offset: 0x1C60C64 VA: 0x1C64C64
	private string GetDescriptionValueText(GemCartId id, int lv, int baseValue) { }

	// RVA: 0x1C64EE4 Offset: 0x1C60EE4 VA: 0x1C64EE4
	private string GetLockIconName(bool isLock) { }

	// RVA: 0x1C63F40 Offset: 0x1C5FF40 VA: 0x1C63F40
	private void UpdateLockFlag() { }

	// RVA: 0x1C63C98 Offset: 0x1C5FC98 VA: 0x1C63C98
	private void UpdateScrollElementActive() { }

	// RVA: 0x1C63FD0 Offset: 0x1C5FFD0 VA: 0x1C63FD0
	private void ChangeActiveSearchPanel(bool isActive) { }

	[IteratorStateMachine(typeof(UIRegistletMainManager.<SearchName>d__72))]
	// RVA: 0x1C650C8 Offset: 0x1C610C8 VA: 0x1C650C8
	private IEnumerator SearchName(string name) { }

	[IteratorStateMachine(typeof(UIRegistletMainManager.<GetContainsName>d__73))]
	// RVA: 0x1C653B0 Offset: 0x1C613B0 VA: 0x1C653B0
	private IEnumerator GetContainsName(string keyword, Action<List<int>> callback) { }

	// RVA: 0x1C65474 Offset: 0x1C61474 VA: 0x1C65474
	private void ReloadList() { }

	// RVA: 0x1C655B4 Offset: 0x1C615B4 VA: 0x1C655B4 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1C656E4 Offset: 0x1C616E4 VA: 0x1C656E4 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1C65814 Offset: 0x1C61814 VA: 0x1C65814
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1C65974 Offset: 0x1C61974 VA: 0x1C65974
	private void <AddNameSearchButton>b__66_0(int num) { }

	[CompilerGenerated]
	// RVA: 0x1C6597C Offset: 0x1C6197C VA: 0x1C6597C
	private void <SearchName>b__72_0(List<int> res) { }
}
