// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UISnowballFightManager : UIBasePanel // TypeDefIndex: 6016
{
	// Fields
	[SerializeField]
	private GameObject[] buttonObj; // 0x30
	private UIIruna2Anchor[] buttonAnchor; // 0x38
	[SerializeField]
	protected UIImageButton autoButton; // 0x40
	[SerializeField]
	private UILabel autoButtonLabel; // 0x48
	[SerializeField]
	private UISprite autoButtonIcon; // 0x50
	[SerializeField]
	private GameObject attentionIconObj; // 0x58
	[SerializeField]
	private UIIcon stockIcon; // 0x60
	[SerializeField]
	private UIIcon freezeIcon; // 0x68
	[SerializeField]
	private Transform stockParent; // 0x70
	[SerializeField]
	private UISlider gaugeSlider; // 0x78
	[SerializeField]
	private UISnowballFightMemberPanel memberPanel; // 0x80
	[SerializeField]
	private UISnowballHpPanel hpPanel; // 0x88
	[SerializeField]
	protected UISnowballNameTime nameTimePanel; // 0x90
	[SerializeField]
	protected UISnowballMatchPanel matchPanel; // 0x98
	[SerializeField]
	private UISnowballLeftTopButton leftTopButton; // 0xA0
	[SerializeField]
	private GameObject situationObj; // 0xA8
	[SerializeField]
	protected UISnowballPopWindow windowPanel; // 0xB0
	[SerializeField]
	private UISnowballAnnouce annoucePanel; // 0xB8
	[SerializeField]
	private UIIruna2Anchor endAnchor; // 0xC0
	[SerializeField]
	private UISprite crossHair; // 0xC8
	[SerializeField]
	private GameObject areaWarningObj; // 0xD0
	[SerializeField]
	private GameObject invincibleIcon; // 0xD8
	[SerializeField]
	private UISnowballItemPanel itemPanel; // 0xE0
	[SerializeField]
	private UIIruna2Anchor leftButtonAnchor; // 0xE8
	[SerializeField]
	private UILabel cameraButtonLabel; // 0xF0
	protected bool isInit; // 0xF8
	protected PlayerDataManager playerDataManager; // 0x100
	protected IPlayerControl playerControl; // 0x108
	private List<MaterialLayer> materialLayerList; // 0x110
	private List<ScreenIceFadeManager> fadeList; // 0x118
	private GameObject shortcutManager; // 0x120
	private bool isOpenShortCut; // 0x128
	private Coroutine reloadCoroutine; // 0x130
	private int prevStockNum; // 0x138
	private List<GameObject> stockList; // 0x140
	private int prevFreezeNum; // 0x148
	private List<GameObject> freezeList; // 0x150
	private GameObject emotionBarObj; // 0x158
	private MiniGameLobbyRoomData lobbyRoomData; // 0x160
	protected MiniGameRoomData roomData; // 0x168
	protected UIMainManager.UIElicitFlag uiElicitFlag; // 0x170
	private bool isToStartFive; // 0x174
	private Coroutine endCoroutine; // 0x178
	private bool[] hpAnnouceFlag; // 0x180
	private bool[] timeAnnounceFlag; // 0x188
	protected bool isBattleUI; // 0x190
	private UILabel[] situationLabels; // 0x198
	private int prevBattleCount; // 0x1A0
	private int prevWaitCount; // 0x1A4

	// Properties
	protected bool isLobby { get; }

	// Methods

	// RVA: 0x1865CBC Offset: 0x1861CBC VA: 0x1865CBC
	protected bool get_isLobby() { }

	// RVA: 0x1865D18 Offset: 0x1861D18 VA: 0x1865D18
	private void Start() { }

	// RVA: 0x1865D20 Offset: 0x1861D20 VA: 0x1865D20 Slot: 7
	protected virtual void Update() { }

	// RVA: 0x1867318 Offset: 0x1863318 VA: 0x1867318
	private void OnDestroy() { }

	// RVA: 0x18673D0 Offset: 0x18633D0 VA: 0x18673D0
	public void Initialize() { }

	// RVA: 0x18673E8 Offset: 0x18633E8 VA: 0x18673E8
	public void StartReloadBar(float reloadTime) { }

	// RVA: 0x18674B4 Offset: 0x18634B4 VA: 0x18674B4
	public void StopReloadBar() { }

	// RVA: 0x1867530 Offset: 0x1863530 VA: 0x1867530
	public void OpenTimeOutWindow() { }

	// RVA: 0x1867B84 Offset: 0x1863B84 VA: 0x1867B84
	public void SetItemData(SnowballFightItemType type) { }

	// RVA: 0x1867B8C Offset: 0x1863B8C VA: 0x1867B8C
	public void SetItemData(SnowballFightItemType type, int time) { }

	// RVA: 0x1867BEC Offset: 0x1863BEC VA: 0x1867BEC
	public void DeleteItemData() { }

	// RVA: 0x1867C0C Offset: 0x1863C0C VA: 0x1867C0C
	public void UpdateItemData(SnowballFightItemType type, bool isValid) { }

	// RVA: 0x1867C2C Offset: 0x1863C2C VA: 0x1867C2C
	public void PlayItemAnnouce(bool isGet, string playerName) { }

	// RVA: 0x1867CE0 Offset: 0x1863CE0 VA: 0x1867CE0 Slot: 8
	protected virtual void InitUI() { }

	// RVA: 0x1866094 Offset: 0x1862094 VA: 0x1866094
	private void UpdateAutoButtonEnable(bool isEnable) { }

	// RVA: 0x186974C Offset: 0x186574C VA: 0x186974C
	private void OpenExitWindow() { }

	// RVA: 0x186994C Offset: 0x186594C VA: 0x186994C
	private void ClosePopWindow() { }

	// RVA: 0x186713C Offset: 0x186313C VA: 0x186713C
	private void CloseShortcutPanel() { }

	// RVA: 0x1869A9C Offset: 0x1865A9C VA: 0x1869A9C
	private void StartMatching() { }

	// RVA: 0x1869B04 Offset: 0x1865B04 VA: 0x1869B04
	private void AddStockIcon(Vector3 pos) { }

	// RVA: 0x1869D24 Offset: 0x1865D24 VA: 0x1869D24
	private void RemoveStockIcon() { }

	// RVA: 0x18661A8 Offset: 0x18621A8 VA: 0x18661A8
	private void UpdateStockIcon() { }

	// RVA: 0x1869E88 Offset: 0x1865E88 VA: 0x1869E88
	private void AddFreezeIcon(Vector3 pos) { }

	// RVA: 0x186A098 Offset: 0x1866098 VA: 0x186A098
	private void RemoveFreezeIcon() { }

	// RVA: 0x186628C Offset: 0x186228C VA: 0x186628C
	private void UpdateFreezeEffect() { }

	// RVA: 0x1866534 Offset: 0x1862534 VA: 0x1866534
	private void UpdateInvincibleIcon() { }

	[IteratorStateMachine(typeof(UISnowballFightManager.<InvincibleIconScaleOff>d__78))]
	// RVA: 0x186A1FC Offset: 0x18661FC VA: 0x186A1FC
	private IEnumerator InvincibleIconScaleOff() { }

	// RVA: 0x186A290 Offset: 0x1866290 VA: 0x186A290
	private void UpdateToBattleUI() { }

	// RVA: 0x18666C0 Offset: 0x18626C0 VA: 0x18666C0
	private void UpdateMatchingPanel() { }

	// RVA: 0x18667A8 Offset: 0x18627A8 VA: 0x18667A8
	private void UpdateBattleUI() { }

	// RVA: 0x1866D78 Offset: 0x1862D78 VA: 0x1866D78
	private void UpdateAnnounce() { }

	[IteratorStateMachine(typeof(UISnowballFightManager.<ReloadGauge>d__83))]
	// RVA: 0x1867438 Offset: 0x1863438 VA: 0x1867438
	private IEnumerator ReloadGauge(float seconds) { }

	[IteratorStateMachine(typeof(UISnowballFightManager.<SetTopButtonWait>d__84))]
	// RVA: 0x1869028 Offset: 0x1865028 VA: 0x1869028
	private IEnumerator SetTopButtonWait() { }

	[IteratorStateMachine(typeof(UISnowballFightManager.<EndPerformance>d__85))]
	// RVA: 0x186A8C0 Offset: 0x18668C0 VA: 0x186A8C0
	private IEnumerator EndPerformance() { }

	// RVA: 0x186A9A4 Offset: 0x18669A4 VA: 0x186A9A4 Slot: 9
	protected virtual void EndUIProcess() { }

	// RVA: 0x186A9A8 Offset: 0x18669A8 VA: 0x186A9A8 Slot: 10
	public virtual void OnAction(int param) { }

	// RVA: 0x186AC24 Offset: 0x1866C24 VA: 0x186AC24 Slot: 11
	public virtual void OnInfo() { }

	// RVA: 0x186B108 Offset: 0x1867108 VA: 0x186B108 Slot: 12
	public virtual void OnCamera() { }

	// RVA: 0x186B234 Offset: 0x1867234 VA: 0x186B234
	public void OnLeftThrow() { }

	// RVA: 0x186B244 Offset: 0x1867244 VA: 0x186B244 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x186B304 Offset: 0x1867304 VA: 0x186B304 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x186B3AC Offset: 0x18673AC VA: 0x186B3AC Slot: 4
	public override void OnOpenShortcutPanel(GameObject shortcutManager) { }

	// RVA: 0x186B558 Offset: 0x1867558 VA: 0x186B558
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x186B790 Offset: 0x1867790 VA: 0x186B790
	private void <UpdateToBattleUI>b__79_0() { }
}
