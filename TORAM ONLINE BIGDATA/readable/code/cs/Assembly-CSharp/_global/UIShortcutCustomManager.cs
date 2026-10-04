// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIShortcutCustomManager : UIBasePanel, IUIShortcutCustomManager // TypeDefIndex: 7532
{
	// Fields
	[SerializeField]
	private GameObject selectPanelButton; // 0x30
	[SerializeField]
	private GameObject selectButton; // 0x38
	[SerializeField]
	private GameObject scrollButton; // 0x40
	[SerializeField]
	private GameObject scrollButtonIcon; // 0x48
	[SerializeField]
	private GameObject messageWindow; // 0x50
	[SerializeField]
	private GameObject pageDownButton; // 0x58
	[SerializeField]
	private GameObject pageSwitchButton; // 0x60
	[SerializeField]
	private GameObject windowObj; // 0x68
	[SerializeField]
	private UISprite windowTitleIcon; // 0x70
	[SerializeField]
	private UILabel windowTitleLabel; // 0x78
	[SerializeField]
	private UILabel windowMesLabel; // 0x80
	[SerializeField]
	private UIImageButton[] exShortcutButtons; // 0x88
	private const int LowerLeftButtonIndex = 6;
	private const int ShortcutButtonNum = 8;
	private const int DefaultShortcutButtonNum = 4;
	private SkillTextManager skillTextManager; // 0x90
	private ItemTextManager itemTextManager; // 0x98
	private PlayerDataManager playerDataManager; // 0xA0
	private UIScrollWindow scrollWindow; // 0xA8
	private UIIruna2Anchor scrollWindowAnchor; // 0xB0
	private UIScrollWindow scrollFullWindow; // 0xB8
	private UIIruna2Anchor scrollFullWindowAnchor; // 0xC0
	private UIScrollWindow activeScrollWindow; // 0xC8
	private UIIruna2Anchor activeScrollWindowAnchor; // 0xD0
	private UIIruna2Anchor messageWindowAnchor; // 0xD8
	private int selectShortcutId; // 0xE0
	private Vector3 scrollPosition; // 0xE4
	private UIShortcutCustomBase listClass; // 0xF0
	private bool selectPanel; // 0xF8
	private int shortcutPanelViewFlag; // 0xFC
	private bool cancelCheck; // 0x100
	private bool isExtendedActive; // 0x101
	private List<UISprite>[] shortcutSetButtonSprites; // 0x108
	[CompilerGenerated]
	private bool <IsSelectList>k__BackingField; // 0x110
	private float checkDist; // 0x114
	private Vector2 moveVector; // 0x118
	private int pageId; // 0x120
	private UIShortcutListButton[] listButtons; // 0x128
	private TweenScale[] listButtonTweenScales; // 0x130
	private TweenPosition[] listButtonTweenPositions; // 0x138
	private List<TweenAlpha>[] listButtonTweenAlphas; // 0x140
	[SerializeField]
	private GameObject[] shortcutButtons; // 0x148
	private TweenScale[] shortcutButtonTween; // 0x150
	[SerializeField]
	private GameObject shortcutButtonObject; // 0x158
	[SerializeField]
	private GameObject listAnchorObject; // 0x160
	private UIIruna2Anchor listAnchor; // 0x168
	[SerializeField]
	private GameObject shortcutAnchorObject; // 0x170
	private UIIruna2Anchor shortcutAnchor; // 0x178
	[SerializeField]
	private GameObject[] setChangeButton; // 0x180
	[SerializeField]
	private UILabel slotLabel; // 0x188
	[SerializeField]
	private UILabel closeLabel; // 0x190
	[SerializeField]
	private UIIruna2Anchor shortcutSetAnchor; // 0x198

	// Properties
	private bool IsCanUseGuard { get; }
	private bool IsCanUseAvoid { get; }
	public bool IsSelectPanel { get; }
	public bool IsSelectList { get; set; }

	// Methods

	// RVA: 0x1B86D14 Offset: 0x1B82D14 VA: 0x1B86D14
	private bool get_IsCanUseGuard() { }

	// RVA: 0x1B86E00 Offset: 0x1B82E00 VA: 0x1B86E00
	private bool get_IsCanUseAvoid() { }

	// RVA: 0x1B86EEC Offset: 0x1B82EEC VA: 0x1B86EEC
	public bool get_IsSelectPanel() { }

	[CompilerGenerated]
	// RVA: 0x1B86EF4 Offset: 0x1B82EF4 VA: 0x1B86EF4 Slot: 7
	public bool get_IsSelectList() { }

	[CompilerGenerated]
	// RVA: 0x1B86EFC Offset: 0x1B82EFC VA: 0x1B86EFC
	private void set_IsSelectList(bool value) { }

	// RVA: 0x1B86F08 Offset: 0x1B82F08 VA: 0x1B86F08
	private void Start() { }

	// RVA: 0x1B87ADC Offset: 0x1B83ADC VA: 0x1B87ADC
	private void PanelInitialize() { }

	// RVA: 0x1B88730 Offset: 0x1B84730 VA: 0x1B88730
	private void SetAllShortcutListButton() { }

	// RVA: 0x1B87FE8 Offset: 0x1B83FE8 VA: 0x1B87FE8
	private void SetShortcutListButton(UIShortcutListButton button, ShortcutData data) { }

	// RVA: 0x1B882F4 Offset: 0x1B842F4 VA: 0x1B882F4
	private void SetAllShortcutButton() { }

	// RVA: 0x1B887E0 Offset: 0x1B847E0 VA: 0x1B887E0
	private void SetShortcutButton(ShortcutData.ShortcutType type, int id, int index) { }

	// RVA: 0x1B88234 Offset: 0x1B84234 VA: 0x1B88234
	private void SetListViewFlagLabel() { }

	// RVA: 0x1B89168 Offset: 0x1B85168 VA: 0x1B89168
	private void OnPress(bool pressed) { }

	// RVA: 0x1B89518 Offset: 0x1B85518 VA: 0x1B89518
	private void OnDrag(Vector2 delta) { }

	// RVA: 0x1B891D4 Offset: 0x1B851D4 VA: 0x1B891D4
	private void NextPage() { }

	// RVA: 0x1B897DC Offset: 0x1B857DC VA: 0x1B897DC
	public void ShortcutViewChange() { }

	// RVA: 0x1B89D38 Offset: 0x1B85D38 VA: 0x1B89D38 Slot: 12
	public void SetShortcutData(ShortcutData.ShortcutType type, int id) { }

	// RVA: 0x1B8A068 Offset: 0x1B86068 VA: 0x1B8A068 Slot: 16
	public bool PopUpConfirmationMessage(int id, PopBaseWindow popWindow, Action<int, int> callBack) { }

	[IteratorStateMachine(typeof(UIShortcutCustomManager.<PopUpConfirmationMessageWindow>d__74))]
	// RVA: 0x1B8A0A4 Offset: 0x1B860A4 VA: 0x1B8A0A4
	private IEnumerator PopUpConfirmationMessageWindow(int id, PopBaseWindow popWindow, Action<int, int> callBack) { }

	[IteratorStateMachine(typeof(UIShortcutCustomManager.<PopUpMessage>d__75))]
	// RVA: 0x1B89FF4 Offset: 0x1B85FF4 VA: 0x1B89FF4
	private IEnumerator PopUpMessage(int id) { }

	// RVA: 0x1B89158 Offset: 0x1B85158 VA: 0x1B89158
	private int GetCurrentPageFlag() { }

	// RVA: 0x1B887CC Offset: 0x1B847CC VA: 0x1B887CC
	private bool IsCurrentPageActive() { }

	// RVA: 0x1B8A158 Offset: 0x1B86158 VA: 0x1B8A158
	private void SelectClear() { }

	// RVA: 0x1B8952C Offset: 0x1B8552C VA: 0x1B8952C
	public void ShortcutPanelClick(int id) { }

	// RVA: 0x1B8A81C Offset: 0x1B8681C VA: 0x1B8A81C
	public void ShortcutButtonClick(int id) { }

	// RVA: 0x1B89974 Offset: 0x1B85974 VA: 0x1B89974
	private void TweenScale(TweenScale tweenScale, bool select) { }

	// RVA: 0x1B8A3D4 Offset: 0x1B863D4 VA: 0x1B8A3D4
	private void ScrollWindowMove(bool isEnabled) { }

	// RVA: 0x1B87908 Offset: 0x1B83908 VA: 0x1B87908
	private void MessageWindowMove(bool isEnabled) { }

	// RVA: 0x1B885AC Offset: 0x1B845AC VA: 0x1B885AC
	private void ShortcutAnchorMove(bool isEnabled) { }

	// RVA: 0x1B87A20 Offset: 0x1B83A20 VA: 0x1B87A20
	private void ShortcutSetAnchorMove(bool isEnabled) { }

	// RVA: 0x1B888E4 Offset: 0x1B848E4 VA: 0x1B888E4 Slot: 13
	public void SetLowerShortcutLabel(ShortcutData.ShortcutType type, int id) { }

	// RVA: 0x1B8AAB8 Offset: 0x1B86AB8 VA: 0x1B8AAB8
	private string GetSkillButtonText(int id) { }

	// RVA: 0x1B8AD44 Offset: 0x1B86D44 VA: 0x1B8AD44 Slot: 9
	public GameObject SetButton(string label, int id) { }

	// RVA: 0x1B8AF80 Offset: 0x1B86F80 VA: 0x1B8AF80
	public GameObject SetExButton(string label, int id) { }

	// RVA: 0x1B8B1BC Offset: 0x1B871BC VA: 0x1B8B1BC Slot: 10
	public UIIcon SetIconButton(string label, int id) { }

	// RVA: 0x1B8B358 Offset: 0x1B87358 VA: 0x1B8B358 Slot: 11
	public UIIcon SetIconButton(string label, int id, UnityAction<int> infoCallback) { }

	// RVA: 0x1B8A494 Offset: 0x1B86494 VA: 0x1B8A494 Slot: 8
	public void CreateList(UIShortcutCustomBase baseClass) { }

	// RVA: 0x1B8B35C Offset: 0x1B8735C VA: 0x1B8B35C Slot: 15
	public void PageDownButtonSetActive(bool isActive) { }

	// RVA: 0x1B8B3A0 Offset: 0x1B873A0 VA: 0x1B8B3A0 Slot: 14
	public void PageSwitchButtonSetActive(bool isActive) { }

	// RVA: 0x1B8B3C0 Offset: 0x1B873C0 VA: 0x1B8B3C0
	private void OnButtonSelect(int id) { }

	// RVA: 0x1B8B41C Offset: 0x1B8741C VA: 0x1B8B41C
	private void OnButtonClick(int id) { }

	// RVA: 0x1B8B4A0 Offset: 0x1B874A0 VA: 0x1B8B4A0
	private void OnChangeSetButton(int nextId) { }

	// RVA: 0x1B8B6B4 Offset: 0x1B876B4 VA: 0x1B8B6B4
	private void OnPageDownButton() { }

	// RVA: 0x1B8B738 Offset: 0x1B87738 VA: 0x1B8B738
	private void OnSwitchButton() { }

	// RVA: 0x1B8B758 Offset: 0x1B87758 VA: 0x1B8B758
	public void OnWindowOk() { }

	// RVA: 0x1B8B87C Offset: 0x1B8787C VA: 0x1B8B87C
	public void OnGaurdAvoidButton(int param) { }

	// RVA: 0x1B8BC3C Offset: 0x1B87C3C VA: 0x1B8BC3C Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1B8BE64 Offset: 0x1B87E64 VA: 0x1B8BE64 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1B8BEC4 Offset: 0x1B87EC4 VA: 0x1B8BEC4
	private void OnDestroy() { }

	// RVA: 0x1B8BDC8 Offset: 0x1B87DC8 VA: 0x1B8BDC8
	private void ChangePanelLoad(UIActiveState activeState) { }

	// RVA: 0x1B8BF48 Offset: 0x1B87F48 VA: 0x1B8BF48
	public void .ctor() { }
}
