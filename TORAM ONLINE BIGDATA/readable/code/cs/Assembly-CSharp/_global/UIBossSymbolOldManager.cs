// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIBossSymbolOldManager : UIBasePanel // TypeDefIndex: 6396
{
	// Fields
	private PlayerDataManager playerData; // 0x30
	private Dictionary<int, UIBossSymbolOldManager.GemData> gemList; // 0x38
	private List<int> selectedGemList; // 0x40
	private List<int> selectedOrbGemList; // 0x48
	[SerializeField]
	private GameObject gemIcon; // 0x50
	private Dictionary<int, GameObject> gemIconList; // 0x58
	[SerializeField]
	private GameObject[] partyMemberObject; // 0x60
	[SerializeField]
	private GameObject mainPanelObject; // 0x68
	[SerializeField]
	private UIImageButton[] imageButton; // 0x70
	[SerializeField]
	private UIImageButton enterButton; // 0x78
	[SerializeField]
	private UILabel enterButtonLabel; // 0x80
	[SerializeField]
	private GameObject partyButton; // 0x88
	private UIToggle partyToggle; // 0x90
	[SerializeField]
	private GameObject reinforceButton; // 0x98
	private UIToggle reinforceToggle; // 0xA0
	[SerializeField]
	private GameObject bossStatusPanel; // 0xA8
	[SerializeField]
	private UIIruna2Anchor mainPanelAnchor; // 0xB0
	[SerializeField]
	private UILabel bossStatusLabel; // 0xB8
	private UIScrollWindow itemListWindow; // 0xC0
	private UIIruna2Anchor itemListWindowAnchor; // 0xC8
	[SerializeField]
	private GameObject itemButton; // 0xD0
	[SerializeField]
	private UILabel itemPopUpLabel; // 0xD8
	[SerializeField]
	private GameObject gemPropertyObject; // 0xE0
	private UIItemProperty gemPropertyLabel; // 0xE8
	private bool inputLock; // 0xF0
	private UIBossSymbolBasePanel bossSymbolPanel; // 0xF8
	[SerializeField]
	private UILabel bossBattleLevel; // 0x100
	private bool cancel; // 0x108
	private bool close; // 0x109
	private UIBossSymbolOldManager.PanelState panelState; // 0x10C
	private ItemTextManager itemTextManager; // 0x110
	private float connectTimer; // 0x118
	private int battleLevel; // 0x11C
	private bool initCheck; // 0x120
	private bool popWindow; // 0x121
	private GameObject shortcutManager; // 0x128
	private bool openShortcut; // 0x130
	private BossRoomData bossRoomData; // 0x138

	// Properties
	private PlayerDataManager playerDataManager { get; }
	public bool IsCancel { get; }
	public bool IsClose { get; }

	// Methods

	// RVA: 0x1920D70 Offset: 0x191CD70 VA: 0x1920D70
	private PlayerDataManager get_playerDataManager() { }

	// RVA: 0x1920DF4 Offset: 0x191CDF4 VA: 0x1920DF4
	public bool get_IsCancel() { }

	// RVA: 0x1920DFC Offset: 0x191CDFC VA: 0x1920DFC
	public bool get_IsClose() { }

	// RVA: 0x1920E04 Offset: 0x191CE04 VA: 0x1920E04
	private void Awake() { }

	// RVA: 0x1920E0C Offset: 0x191CE0C VA: 0x1920E0C
	private void Start() { }

	// RVA: 0x1921D08 Offset: 0x191DD08 VA: 0x1921D08
	public void Initialize(int fieldId, byte roomId, Vector3 pos, float rot, EmergencyPositionData emergencyPosition, int level) { }

	// RVA: 0x1922DF8 Offset: 0x191EDF8 VA: 0x1922DF8
	private void ReceiveCheckBossSymbol() { }

	[IteratorStateMachine(typeof(UIBossSymbolOldManager.<PopErrWindow>d__50))]
	// RVA: 0x1922E48 Offset: 0x191EE48 VA: 0x1922E48
	private IEnumerator PopErrWindow() { }

	// RVA: 0x1922EDC Offset: 0x191EEDC VA: 0x1922EDC
	private void Update() { }

	// RVA: 0x19236F8 Offset: 0x191F6F8 VA: 0x19236F8
	private void CloseShortcutPanel() { }

	// RVA: 0x1923E10 Offset: 0x191FE10 VA: 0x1923E10
	private void CheckPartyToggle() { }

	// RVA: 0x1923E48 Offset: 0x191FE48 VA: 0x1923E48
	private void CheckReinforceToggle() { }

	// RVA: 0x19237A0 Offset: 0x191F7A0 VA: 0x19237A0
	private void OpenBossData() { }

	// RVA: 0x1923E80 Offset: 0x191FE80 VA: 0x1923E80
	private bool CheckBossData() { }

	// RVA: 0x1923F2C Offset: 0x191FF2C VA: 0x1923F2C
	private void OpenBossDataWindow() { }

	// RVA: 0x1923880 Offset: 0x191F880 VA: 0x1923880
	private void OpenItemList() { }

	// RVA: 0x19244E8 Offset: 0x19204E8 VA: 0x19244E8
	public void CheckUseItem(int itemId) { }

	// RVA: 0x1921B94 Offset: 0x191DB94 VA: 0x1921B94
	private void OpenMainPanel() { }

	// RVA: 0x1924748 Offset: 0x1920748 VA: 0x1924748
	private void BattleReady() { }

	// RVA: 0x192488C Offset: 0x192088C VA: 0x192488C
	private void BattleReadyCancel() { }

	[IteratorStateMachine(typeof(UIBossSymbolOldManager.<ConnectWait>d__63))]
	// RVA: 0x1922D5C Offset: 0x191ED5C VA: 0x1922D5C
	private IEnumerator ConnectWait(Func<bool> checkConnect, Action callBack) { }

	// RVA: 0x192497C Offset: 0x192097C VA: 0x192497C Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1924A98 Offset: 0x1920A98 VA: 0x1924A98 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1924B20 Offset: 0x1920B20 VA: 0x1924B20 Slot: 4
	public override void OnOpenShortcutPanel(GameObject shortcutManager) { }

	// RVA: 0x1924C60 Offset: 0x1920C60 VA: 0x1924C60
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1924E24 Offset: 0x1920E24 VA: 0x1924E24
	private bool <Initialize>b__48_0() { }
}
