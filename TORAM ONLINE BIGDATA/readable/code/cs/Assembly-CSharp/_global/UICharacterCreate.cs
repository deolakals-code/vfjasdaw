// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UICharacterCreate : MonoBehaviour // TypeDefIndex: 9072
{
	// Fields
	private string playerName; // 0x20
	[SerializeField]
	private UILabel playerNameLabel; // 0x28
	[SerializeField]
	private UIInput playerNameInput; // 0x30
	[SerializeField]
	private TweenAlpha playerNameTweenAlpha; // 0x38
	[SerializeField]
	private GameObject keybordOptionSettingButton; // 0x40
	[SerializeField]
	private UILabel keybordOptionSettingButtonLabel; // 0x48
	[SerializeField]
	private GameObject keybordOptionSettingButtonIcon; // 0x50
	[SerializeField]
	private Camera uiMainCamera; // 0x58
	[SerializeField]
	private GameObject precautionsWindowObject; // 0x60
	[SerializeField]
	private UITextListEx precautionsListLabel; // 0x68
	[SerializeField]
	private UIIruna2AnchorSimple namePanel; // 0x70
	[SerializeField]
	private UIIruna2AnchorSimple accountButtonPanel; // 0x78
	[SerializeField]
	private UIIruna2AnchorSimple changePanel; // 0x80
	[SerializeField]
	private UIIruna2AnchorSimple keybordButton; // 0x88
	[SerializeField]
	private UIIruna2AnchorSimple accountPanel; // 0x90
	[CompilerGenerated]
	private bool <IsCustomerRegistered>k__BackingField; // 0x98
	private CharacterCreateManager characterCreateManager; // 0xA0
	private UICharacterModelManager characterModelManager; // 0xA8
	private SystemTextManager systemTManager; // 0xB0
	private GameObject loadingModel; // 0xB8
	private bool isToCreate; // 0xC0
	private string inheritingName; // 0xC8
	private bool isStarted; // 0xD0
	private bool isPopupOptionWindow; // 0xD1
	private bool isPrecautionsWindowClose; // 0xD2
	private UICharacterCreate.CharaCreatePages nowPageId; // 0xD4

	// Properties
	public bool IsCustomerRegistered { get; set; }
	private SystemTextManager systemTextManager { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1EA55B8 Offset: 0x1EA15B8 VA: 0x1EA55B8
	public bool get_IsCustomerRegistered() { }

	[CompilerGenerated]
	// RVA: 0x1EA55C0 Offset: 0x1EA15C0 VA: 0x1EA55C0
	public void set_IsCustomerRegistered(bool value) { }

	// RVA: 0x1EA55CC Offset: 0x1EA15CC VA: 0x1EA55CC
	private SystemTextManager get_systemTextManager() { }

	// RVA: 0x1EA56C4 Offset: 0x1EA16C4 VA: 0x1EA56C4
	private void Awake() { }

	// RVA: 0x1EA59C4 Offset: 0x1EA19C4 VA: 0x1EA59C4
	public void Initialize(CharacterCreateManager characterCreateManager) { }

	// RVA: 0x1EA5C50 Offset: 0x1EA1C50 VA: 0x1EA5C50
	private void initializeServerSceneFailureCallback() { }

	[IteratorStateMachine(typeof(UICharacterCreate.<initializeServerSceneCoroutine>d__34))]
	// RVA: 0x1EA5C70 Offset: 0x1EA1C70 VA: 0x1EA5C70
	private IEnumerator initializeServerSceneCoroutine() { }

	[IteratorStateMachine(typeof(UICharacterCreate.<initializeLocalize>d__35))]
	// RVA: 0x1EA5D04 Offset: 0x1EA1D04 VA: 0x1EA5D04
	private IEnumerator initializeLocalize() { }

	// RVA: 0x1EA5D84 Offset: 0x1EA1D84 VA: 0x1EA5D84
	private void toCreate() { }

	// RVA: 0x1EA5E14 Offset: 0x1EA1E14 VA: 0x1EA5E14
	public void CreateCharacter() { }

	[IteratorStateMachine(typeof(UICharacterCreate.<toAccountLogin>d__38))]
	// RVA: 0x1EA5E48 Offset: 0x1EA1E48 VA: 0x1EA5E48 Slot: 4
	protected virtual IEnumerator toAccountLogin() { }

	[IteratorStateMachine(typeof(UICharacterCreate.<toSelectAccountLogin>d__39))]
	// RVA: 0x1EA5EDC Offset: 0x1EA1EDC VA: 0x1EA5EDC Slot: 5
	protected virtual IEnumerator toSelectAccountLogin() { }

	[IteratorStateMachine(typeof(UICharacterCreate.<OpenPrecautionsWindow>d__40))]
	// RVA: 0x1EA5F70 Offset: 0x1EA1F70 VA: 0x1EA5F70
	private IEnumerator OpenPrecautionsWindow() { }

	// RVA: 0x1EA6004 Offset: 0x1EA2004 VA: 0x1EA6004
	private void OnClosePrecautionsWindow() { }

	// RVA: 0x1EA5C28 Offset: 0x1EA1C28 VA: 0x1EA5C28
	public void OnStartCreate() { }

	[IteratorStateMachine(typeof(UICharacterCreate.<onStartCreateCoroutine>d__43))]
	// RVA: 0x1EA6010 Offset: 0x1EA2010 VA: 0x1EA6010
	private IEnumerator onStartCreateCoroutine() { }

	// RVA: 0x1EA60A4 Offset: 0x1EA20A4 VA: 0x1EA60A4
	private void OnDestroy() { }

	// RVA: 0x1EA61AC Offset: 0x1EA21AC VA: 0x1EA61AC
	private void OnPress() { }

	// RVA: 0x1EA61C8 Offset: 0x1EA21C8 VA: 0x1EA61C8
	public void OnPopOptionWindow() { }

	[IteratorStateMachine(typeof(UICharacterCreate.<popOptionWindow>d__47))]
	// RVA: 0x1EA61F8 Offset: 0x1EA21F8 VA: 0x1EA61F8
	private IEnumerator popOptionWindow() { }

	// RVA: 0x1EA628C Offset: 0x1EA228C VA: 0x1EA628C
	private void OnChangeKeybordOption() { }

	// RVA: 0x1EA63C4 Offset: 0x1EA23C4 VA: 0x1EA63C4
	private void Update() { }

	// RVA: 0x1EA63F0 Offset: 0x1EA23F0 VA: 0x1EA63F0 Slot: 6
	protected virtual void ReturnKey(bool returnButton) { }

	// RVA: 0x1EA5E34 Offset: 0x1EA1E34 VA: 0x1EA5E34
	private void PlayerCreate() { }

	// RVA: 0x1EA6740 Offset: 0x1EA2740 VA: 0x1EA6740
	private void SelectCreatePanel() { }

	// RVA: 0x1EA64FC Offset: 0x1EA24FC VA: 0x1EA64FC
	private void changePage(int add) { }

	// RVA: 0x1EA6744 Offset: 0x1EA2744 VA: 0x1EA6744
	private void charCreateProc(UICharacterCreate.CharaCreatePages page) { }

	// RVA: 0x1EA6A4C Offset: 0x1EA2A4C VA: 0x1EA6A4C
	private void OnCharacterCreateResult(LoginResultType result) { }

	[IteratorStateMachine(typeof(UICharacterCreate.<createSuccess>d__57))]
	// RVA: 0x1EA6DD8 Offset: 0x1EA2DD8 VA: 0x1EA6DD8
	private IEnumerator createSuccess() { }

	// RVA: 0x1EA6E6C Offset: 0x1EA2E6C VA: 0x1EA6E6C
	private void login() { }

	// RVA: 0x1EA6EBC Offset: 0x1EA2EBC VA: 0x1EA6EBC
	private void getPlayerName() { }

	// RVA: 0x1EA7200 Offset: 0x1EA3200 VA: 0x1EA7200
	public void .ctor() { }
}
