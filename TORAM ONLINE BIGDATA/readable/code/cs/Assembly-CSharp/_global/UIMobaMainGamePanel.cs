// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMobaMainGamePanel : UIBasePanelConnection // TypeDefIndex: 6099
{
	// Fields
	[SerializeField]
	private GameObject mainMenuPanel; // 0x30
	[SerializeField]
	private GameObject mainButtonPanel; // 0x38
	[SerializeField]
	private GameObject[] mainButtonMainPanel; // 0x40
	[SerializeField]
	private GameObject[] mainButtonHidePanel; // 0x48
	[SerializeField]
	private GameObject miniButtonPanel; // 0x50
	[SerializeField]
	private GameObject[] miniButtonObjs; // 0x58
	[SerializeField]
	private GameObject menuPanel; // 0x60
	[SerializeField]
	private GameObject[] menuPanelObjs; // 0x68
	[SerializeField]
	private UILabel mainMenuGoldLabel; // 0x70
	[SerializeField]
	private UILabel statusButtonLabel; // 0x78
	[SerializeField]
	private UILabel abilityNumLabel; // 0x80
	[SerializeField]
	private UISprite[] equipWeaponIcons; // 0x88
	[SerializeField]
	private UILabel[] equipWeaponLabels; // 0x90
	[SerializeField]
	private UIImageButton[] otherMenuButton; // 0x98
	[SerializeField]
	private GameObject popWindowObj; // 0xA0
	[SerializeField]
	private UILabel[] popWindowLabels; // 0xA8
	private UIMobaMainGamePanel.PanelState panelState; // 0xB0
	private GameObject shortcutManager; // 0xB8
	private bool openShortcut; // 0xC0
	private UIMobaEditBasePanel[] editPanels; // 0xC8
	private UIMobaMainGamePanel.MenuType nowMenuType; // 0xD0
	private MobaRoomData roomData; // 0xD8
	private PlayerDataManager playerDataManager; // 0xE0
	private IPlayerControl playerControl; // 0xE8
	private byte startMenuId; // 0xF0
	private bool isInputLock; // 0xF1

	// Properties
	public bool IsOpenPopWindow { get; }
	private IPlayerControl PlayerControl { get; }

	// Methods

	// RVA: 0x1883D44 Offset: 0x187FD44 VA: 0x1883D44
	public bool get_IsOpenPopWindow() { }

	// RVA: 0x1883D60 Offset: 0x187FD60 VA: 0x1883D60
	private IPlayerControl get_PlayerControl() { }

	// RVA: 0x1883DEC Offset: 0x187FDEC VA: 0x1883DEC
	private void Awake() { }

	// RVA: 0x1884188 Offset: 0x1880188 VA: 0x1884188
	private void Start() { }

	// RVA: 0x1884728 Offset: 0x1880728 VA: 0x1884728
	private void Update() { }

	// RVA: 0x188472C Offset: 0x188072C VA: 0x188472C
	private void OnDestroy() { }

	// RVA: 0x1884190 Offset: 0x1880190 VA: 0x1884190
	public void ChangeState(UIMobaMainGamePanel.PanelState panelState) { }

	// RVA: 0x18849FC Offset: 0x18809FC VA: 0x18849FC
	public void OpenPopWindow(string title, string mes) { }

	// RVA: 0x1884A80 Offset: 0x1880A80 VA: 0x1884A80
	public void ClosePopWinodw() { }

	// RVA: 0x1884828 Offset: 0x1880828 VA: 0x1884828
	public string GetGoldText() { }

	// RVA: 0x18848E8 Offset: 0x18808E8 VA: 0x18848E8
	public string GetAbilityNumText() { }

	// RVA: 0x1884AA0 Offset: 0x1880AA0 VA: 0x1884AA0
	public void OnMainButton(int param) { }

	// RVA: 0x1884BE4 Offset: 0x1880BE4 VA: 0x1884BE4
	public void OnCombo() { }

	// RVA: 0x1884C70 Offset: 0x1880C70 VA: 0x1884C70
	public void OnShortcutOption() { }

	// RVA: 0x1884CFC Offset: 0x1880CFC VA: 0x1884CFC
	public void OnPopWindowOk() { }

	// RVA: 0x1884D60 Offset: 0x1880D60 VA: 0x1884D60
	private void CloseShortcutPanel() { }

	[IteratorStateMachine(typeof(UIMobaMainGamePanel.<GetItemList>d__47))]
	// RVA: 0x18847BC Offset: 0x18807BC VA: 0x18847BC
	private IEnumerator GetItemList() { }

	[IteratorStateMachine(typeof(UIMobaMainGamePanel.<MainButtonProccess>d__48))]
	// RVA: 0x1884B68 Offset: 0x1880B68 VA: 0x1884B68
	private IEnumerator MainButtonProccess(int param) { }

	[IteratorStateMachine(typeof(UIMobaMainGamePanel.<LeftTopButtonProccess>d__49))]
	// RVA: 0x1884E4C Offset: 0x1880E4C VA: 0x1884E4C
	private IEnumerator LeftTopButtonProccess() { }

	[IteratorStateMachine(typeof(UIMobaMainGamePanel.<RightTopButtonProccess>d__50))]
	// RVA: 0x1884EE0 Offset: 0x1880EE0 VA: 0x1884EE0
	private IEnumerator RightTopButtonProccess() { }

	// RVA: 0x1884F74 Offset: 0x1880F74 VA: 0x1884F74 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1884FA4 Offset: 0x1880FA4 VA: 0x1884FA4 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1884FD4 Offset: 0x1880FD4 VA: 0x1884FD4
	public void .ctor() { }
}
