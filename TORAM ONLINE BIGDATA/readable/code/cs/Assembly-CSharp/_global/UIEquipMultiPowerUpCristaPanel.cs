// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIEquipMultiPowerUpCristaPanel : MonoBehaviour // TypeDefIndex: 6970
{
	// Fields
	[SerializeField]
	private GameObject[] frameObjs; // 0x20
	[SerializeField]
	private GameObject windowObj; // 0x28
	[SerializeField]
	private UIScrollWindow scrollWindow; // 0x30
	[SerializeField]
	private GameObject[] scrollAreaObjs; // 0x38
	[SerializeField]
	private UIScrollBar scrollBar; // 0x40
	[SerializeField]
	private GameObject[] scrollElements; // 0x48
	[SerializeField]
	private GameObject[] panelObjs; // 0x50
	[SerializeField]
	private UILabel checkPanekLabel; // 0x58
	[SerializeField]
	private UISlider delayPanelSlider; // 0x60
	[SerializeField]
	private UILabel errorPanelLabel; // 0x68
	[SerializeField]
	private UIImageButton button; // 0x70
	[SerializeField]
	private UILabel buttonLabel; // 0x78
	[SerializeField]
	private UIIruna2Anchor orbPanel; // 0x80
	[SerializeField]
	private UILabel orbNumLabel; // 0x88
	[SerializeField]
	private UILabel orbPanelLabel; // 0x90
	[SerializeField]
	private UILabel orbButtonLabel; // 0x98
	[SerializeField]
	private UILabel orbPanelNumLabel; // 0xA0
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0xA8
	private UIEquipMultiPowerUpCristaPanel.PanelState panelState; // 0xAC
	private UIEquipCristaPanel cristaPanel; // 0xB0
	private Dictionary<int, int> itemIds; // 0xB8
	private bool isFirstUseExtract; // 0xC0
	private OrbManager orbManager; // 0xC8
	private int orbItemNum; // 0xD0
	private PlayerDataManager playerDataManager; // 0xD8
	private SystemTextManager systemTextManager; // 0xE0
	private ItemTextManager itemTextManager; // 0xE8
	private Dictionary<int, UIToggle> useExtractToggleList; // 0xF0
	private Dictionary<int, bool> useExtractItemList; // 0xF8
	private Coroutine loadCoroutine; // 0x100
	private Coroutine resultCoroutine; // 0x108
	private List<UIEquipMultiPowerUpCristaPanel.ResultElement> resultElementList; // 0x110
	private const float ResultElementHeight = 100;
	private const int ItemNeedOrbNum = 4;
	private bool isNeedBuyOrb; // 0x118
	private bool inputLock; // 0x119
	private float loadingTimer; // 0x11C
	private GameObject loadingObject; // 0x120
	private int equipItemUuid; // 0x128
	private byte slotId; // 0x12C
	private int nowAttachedItemId; // 0x130
	private List<ItemData> itemDataList; // 0x138

	// Properties
	public bool IsOpen { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1A5FB84 Offset: 0x1A5BB84 VA: 0x1A5FB84
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x1A5FB8C Offset: 0x1A5BB8C VA: 0x1A5FB8C
	private void set_IsOpen(bool value) { }

	// RVA: 0x1A5FB98 Offset: 0x1A5BB98 VA: 0x1A5FB98
	private void Start() { }

	// RVA: 0x1A5FD5C Offset: 0x1A5BD5C VA: 0x1A5FD5C
	private void Update() { }

	// RVA: 0x1A5FDF4 Offset: 0x1A5BDF4 VA: 0x1A5FDF4
	public void Open(UIEquipCristaPanel panel, int nowAttachedItemId, int equipItemUuid, byte slotId, List<ItemData> itemDataList, bool isUseExtract) { }

	// RVA: 0x1A60078 Offset: 0x1A5C078 VA: 0x1A60078
	public bool Close() { }

	// RVA: 0x1A6060C Offset: 0x1A5C60C VA: 0x1A6060C
	public void OnWindowButton() { }

	// RVA: 0x1A60A8C Offset: 0x1A5CA8C VA: 0x1A60A8C
	public void OnOrbUse() { }

	// RVA: 0x1A60240 Offset: 0x1A5C240 VA: 0x1A60240
	private void ChangePanelState(UIEquipMultiPowerUpCristaPanel.PanelState panelState) { }

	[IteratorStateMachine(typeof(UIEquipMultiPowerUpCristaPanel.<InitPanel>d__56))]
	// RVA: 0x1A60004 Offset: 0x1A5C004 VA: 0x1A60004
	private IEnumerator InitPanel() { }

	// RVA: 0x1A60B30 Offset: 0x1A5CB30 VA: 0x1A60B30
	private void UpdateCheckScrollWindow(bool isInitSelectItem = True) { }

	// RVA: 0x1A61204 Offset: 0x1A5D204 VA: 0x1A61204
	private void UpdateDelayScrollWindow() { }

	// RVA: 0x1A617D0 Offset: 0x1A5D7D0 VA: 0x1A617D0
	private void UpdateResultScrollWindow() { }

	// RVA: 0x1A61FC0 Offset: 0x1A5DFC0 VA: 0x1A61FC0
	private void ChangeFrameSize(UIEquipMultiPowerUpCristaPanel.FrameType type) { }

	[IteratorStateMachine(typeof(UIEquipMultiPowerUpCristaPanel.<ActiveFalsePanel>d__61))]
	// RVA: 0x1A605A0 Offset: 0x1A5C5A0 VA: 0x1A605A0
	private IEnumerator ActiveFalsePanel() { }

	[IteratorStateMachine(typeof(UIEquipMultiPowerUpCristaPanel.<WaitPowerUp>d__62))]
	// RVA: 0x1A6175C Offset: 0x1A5D75C VA: 0x1A6175C
	private IEnumerator WaitPowerUp() { }

	[IteratorStateMachine(typeof(UIEquipMultiPowerUpCristaPanel.<ResultFlashObject>d__63))]
	// RVA: 0x1A620B4 Offset: 0x1A5E0B4 VA: 0x1A620B4
	private IEnumerator ResultFlashObject() { }

	[IteratorStateMachine(typeof(UIEquipMultiPowerUpCristaPanel.<InitCheckOrbConnection>d__64))]
	// RVA: 0x1A62150 Offset: 0x1A5E150 VA: 0x1A62150
	private IEnumerator InitCheckOrbConnection() { }

	[IteratorStateMachine(typeof(UIEquipMultiPowerUpCristaPanel.<ConnectWaitOrb>d__65))]
	// RVA: 0x1A621C4 Offset: 0x1A5E1C4 VA: 0x1A621C4
	private IEnumerator ConnectWaitOrb(OrbManager.ConnectFlag connectFlag) { }

	// RVA: 0x1A60160 Offset: 0x1A5C160 VA: 0x1A60160
	private void OrbPanelEnable(bool enable) { }

	[IteratorStateMachine(typeof(UIEquipMultiPowerUpCristaPanel.<Attach>d__67))]
	// RVA: 0x1A62248 Offset: 0x1A5E248 VA: 0x1A62248
	private IEnumerator Attach() { }

	// RVA: 0x1A622DC Offset: 0x1A5E2DC VA: 0x1A622DC
	private void SetErrorText(short returnCode) { }

	// RVA: 0x1A623DC Offset: 0x1A5E3DC VA: 0x1A623DC
	public void .ctor() { }
}
