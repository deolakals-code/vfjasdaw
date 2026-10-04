// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIEquipPowerUpCristaPanel : MonoBehaviour // TypeDefIndex: 6982
{
	// Fields
	[SerializeField]
	private GameObject mainPanel; // 0x20
	[SerializeField]
	private GameObject checkPanel; // 0x28
	[SerializeField]
	private GameObject reinforcePanel; // 0x30
	[SerializeField]
	private GameObject loadPanel; // 0x38
	[SerializeField]
	private GameObject resultPanel; // 0x40
	[SerializeField]
	private GameObject titleObj; // 0x48
	private UILabel titleLabel; // 0x50
	private UISprite titleIcon; // 0x58
	[SerializeField]
	private UIImageButton imageButton; // 0x60
	private UIButtonMessage buttonMessage; // 0x68
	private UILabel buttonLabel; // 0x70
	private UIIcon buttonItemIcon; // 0x78
	private UIButtonColor buttonColor; // 0x80
	[SerializeField]
	private UILabel checkExpLabel; // 0x88
	[SerializeField]
	private GameObject checkPanelButton; // 0x90
	[SerializeField]
	private UILabel reinforceExpLabel; // 0x98
	[SerializeField]
	private GameObject dontHaveObj; // 0xA0
	[SerializeField]
	private UIIcon orbItemIcon; // 0xA8
	[SerializeField]
	private UILabel orbItemLabel; // 0xB0
	[SerializeField]
	private UILabel orbItemCountLabel; // 0xB8
	[SerializeField]
	private GameObject recruitButtonObj; // 0xC0
	[SerializeField]
	private GameObject inputGoldObj; // 0xC8
	[SerializeField]
	private GameObject attentionObj; // 0xD0
	[SerializeField]
	private UILabel cristaLabel; // 0xD8
	[SerializeField]
	private UIIcon cristaIcon; // 0xE0
	[SerializeField]
	private UILabel exstractLabel; // 0xE8
	[SerializeField]
	private UISlider loadSlider; // 0xF0
	[SerializeField]
	private UIIcon weaponIcon; // 0xF8
	[SerializeField]
	private UILabel weaponLabel; // 0x100
	[SerializeField]
	private UILabel extractChristaLabel; // 0x108
	[SerializeField]
	private UIIcon equipedCristaIcon; // 0x110
	[SerializeField]
	private UILabel equipedCristaLabel; // 0x118
	[SerializeField]
	private GameObject effectObj; // 0x120
	private bool isActiveEffect; // 0x128
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x129
	[CompilerGenerated]
	private bool <IsPopWindow>k__BackingField; // 0x12A
	private bool isUseItem; // 0x12B
	private OrbManager orbManager; // 0x130
	private bool orbInitConnect; // 0x138
	private int orbItemNum; // 0x13C
	private const int buyOrbNum = 4;
	private PlayerDataManager playerDataManager; // 0x140
	private SystemTextManager systemTextManager; // 0x148
	private ItemTextManager itemTextManager; // 0x150
	private bool inputLock; // 0x158
	private float loadingTimer; // 0x15C
	private GameObject loadingObject; // 0x160
	private Coroutine loadCoroutine; // 0x168
	private UIEquipCristaPanel panel; // 0x170
	private ItemData equipItemData; // 0x178
	private int slotId; // 0x180
	private int normalChristaId; // 0x184
	private int selectExChristaId; // 0x188
	private int selectExChristaUuId; // 0x18C
	private UIPopBaseWindow popWindow; // 0x190
	private bool isButtonEnable; // 0x198

	// Properties
	public bool IsOpen { get; set; }
	public bool IsPopWindow { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1A643D4 Offset: 0x1A603D4 VA: 0x1A643D4
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x1A643DC Offset: 0x1A603DC VA: 0x1A643DC
	private void set_IsOpen(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1A643E8 Offset: 0x1A603E8 VA: 0x1A643E8
	public bool get_IsPopWindow() { }

	[CompilerGenerated]
	// RVA: 0x1A643F0 Offset: 0x1A603F0 VA: 0x1A643F0
	private void set_IsPopWindow(bool value) { }

	// RVA: 0x1A643FC Offset: 0x1A603FC VA: 0x1A643FC
	public void WindowClose() { }

	// RVA: 0x1A644DC Offset: 0x1A604DC VA: 0x1A644DC
	public void ClosePopWindow() { }

	// RVA: 0x1A64514 Offset: 0x1A60514 VA: 0x1A64514
	private void Start() { }

	// RVA: 0x1A6482C Offset: 0x1A6082C VA: 0x1A6482C
	public void Initialize(UIEquipCristaPanel panel, bool isUseCrista, ItemData equipItem, int slotId, int normalChristaId, int exCristaId, int exCristaUuid) { }

	[IteratorStateMachine(typeof(UIEquipPowerUpCristaPanel.<InitPanel>d__66))]
	// RVA: 0x1A64858 Offset: 0x1A60858 VA: 0x1A64858
	private IEnumerator InitPanel(UIEquipCristaPanel panel, bool isUseCrista, ItemData equipItem, int slotId, int normalChristaId, int exCristaId, int exCristaUuid) { }

	[IteratorStateMachine(typeof(UIEquipPowerUpCristaPanel.<InitCheckOrbConnection>d__67))]
	// RVA: 0x1A64958 Offset: 0x1A60958 VA: 0x1A64958
	private IEnumerator InitCheckOrbConnection() { }

	// RVA: 0x1A649EC Offset: 0x1A609EC VA: 0x1A649EC
	private void UIinit() { }

	// RVA: 0x1A64BE0 Offset: 0x1A60BE0 VA: 0x1A64BE0
	private void InitReinforcePanel() { }

	// RVA: 0x1A65274 Offset: 0x1A61274 VA: 0x1A65274
	private void InitCheckPanel() { }

	// RVA: 0x1A65820 Offset: 0x1A61820 VA: 0x1A65820
	private void Update() { }

	// RVA: 0x1A65868 Offset: 0x1A61868 VA: 0x1A65868
	private void Result(bool isReturn) { }

	// RVA: 0x1A6563C Offset: 0x1A6163C VA: 0x1A6563C
	private bool IsCanRecruit() { }

	[IteratorStateMachine(typeof(UIEquipPowerUpCristaPanel.<onReinforce>d__74))]
	// RVA: 0x1A65D6C Offset: 0x1A61D6C VA: 0x1A65D6C
	private IEnumerator onReinforce() { }

	// RVA: 0x1A65E00 Offset: 0x1A61E00 VA: 0x1A65E00
	private void onWait() { }

	// RVA: 0x1A663B0 Offset: 0x1A623B0 VA: 0x1A663B0
	private void onOkCancel() { }

	[IteratorStateMachine(typeof(UIEquipPowerUpCristaPanel.<ConnectWait>d__77))]
	// RVA: 0x1A66404 Offset: 0x1A62404 VA: 0x1A66404
	private IEnumerator ConnectWait(OrbManager.ConnectFlag connectFlag) { }

	[IteratorStateMachine(typeof(UIEquipPowerUpCristaPanel.<WaitPowerUp>d__78))]
	// RVA: 0x1A66344 Offset: 0x1A62344 VA: 0x1A66344
	private IEnumerator WaitPowerUp() { }

	[IteratorStateMachine(typeof(UIEquipPowerUpCristaPanel.<AttachReinforce>d__79))]
	// RVA: 0x1A664D0 Offset: 0x1A624D0 VA: 0x1A664D0
	private IEnumerator AttachReinforce() { }

	[IteratorStateMachine(typeof(UIEquipPowerUpCristaPanel.<OpenEffect>d__80))]
	// RVA: 0x1A65D00 Offset: 0x1A61D00 VA: 0x1A65D00
	private IEnumerator OpenEffect() { }

	[IteratorStateMachine(typeof(UIEquipPowerUpCristaPanel.<ActiveFalsePanel>d__81))]
	// RVA: 0x1A64470 Offset: 0x1A60470 VA: 0x1A64470
	private IEnumerator ActiveFalsePanel() { }

	[IteratorStateMachine(typeof(UIEquipPowerUpCristaPanel.<OnRecruitWindow>d__82))]
	// RVA: 0x1A665B4 Offset: 0x1A625B4 VA: 0x1A665B4
	private IEnumerator OnRecruitWindow() { }

	[IteratorStateMachine(typeof(UIEquipPowerUpCristaPanel.<PopWindow>d__83))]
	// RVA: 0x1A66648 Offset: 0x1A62648 VA: 0x1A66648
	private IEnumerator PopWindow(bool isRecruit, UIPopBaseWindow popWindow, bool destroy, Action<int> result) { }

	// RVA: 0x1A6672C Offset: 0x1A6272C VA: 0x1A6672C
	public void .ctor() { }
}
