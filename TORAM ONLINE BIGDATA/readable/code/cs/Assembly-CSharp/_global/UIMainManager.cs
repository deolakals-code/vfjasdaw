// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMainManager : Singleton<UIMainManager>, ISceneChangeManager // TypeDefIndex: 8995
{
	// Fields
	[SerializeField]
	private GameObject miniMapPanel; // 0x20
	private UIMiniMap uiMiniMap; // 0x28
	[SerializeField]
	private Transform parentPanel; // 0x30
	[SerializeField]
	private Transform parentWorldPanel; // 0x38
	[SerializeField]
	protected UIGLPanel uiGLWorldPanel; // 0x40
	[SerializeField]
	private Camera uiMainCamera; // 0x48
	[SerializeField]
	private GameObject fadePanelObject; // 0x50
	private ScreenFadeAnimationManager fadePanel; // 0x58
	[SerializeField]
	private GameObject uiBackPanelObject; // 0x60
	private ScreenFadeAnimationManager uiBackPanel; // 0x68
	[SerializeField]
	private GameObject loadingBarObject; // 0x70
	private UILoadingBar loadingBar; // 0x78
	private UIBagMaxTextLabel bagMaxTextLabel; // 0x80
	private UIActiveState previousState; // 0x88
	private UIActiveState activeState; // 0x8C
	private ChatChannelType chatType; // 0x90
	[SerializeField]
	protected UILabel channelLabel; // 0x98
	protected bool channelUpdateFlag; // 0xA0
	private bool worldPanelInactive; // 0xA1
	private ItemTextManager itemTextManager; // 0xA8
	private float chatTapTimer; // 0xB0
	protected PlayerDataManager playerDataManager; // 0xB8
	protected IPlayerControl playerControl; // 0xC0
	private int selectedMainMenuPanelId; // 0xC8
	[SerializeField]
	private UISeverLimitTimer serverTimerLabel; // 0xD0
	private bool isMoveLock; // 0xD8
	private UIMainManager.UISystemLockFlag systemLock; // 0xDC
	[SerializeField]
	private GameObject[] shortcutObject; // 0xE0
	private UIGLShortcutButton[] shortcutButton; // 0xE8
	[SerializeField]
	protected UIIruna2Anchor shortcutAnchor; // 0xF0
	[SerializeField]
	protected UIIruna2Anchor shortcutRightBottomAnchor; // 0xF8
	[SerializeField]
	protected UIIruna2Anchor shortcutLeftBottomAnchor; // 0x100
	[SerializeField]
	private GameObject rightTopObject; // 0x108
	private UIRightTopButton rightTopButton; // 0x110
	[SerializeField]
	private GameObject leftTopObject; // 0x118
	private UILeftTopButton leftTopButton; // 0x120
	[SerializeField]
	private GameObject chatClockObject; // 0x128
	private UIClockChatType chatClock; // 0x130
	[SerializeField]
	private GameObject playerStatusObject; // 0x138
	private UIPlayerStatus playerStatus; // 0x140
	[SerializeField]
	private GameObject rightStickObject; // 0x148
	private UIRightStick rightStick; // 0x150
	[SerializeField]
	private GameObject leftStickObject; // 0x158
	private UILeftStick leftStick; // 0x160
	[SerializeField]
	protected GameObject expBarObject; // 0x168
	private UIExpBar expBar; // 0x170
	[SerializeField]
	private GameObject chatWindowObject; // 0x178
	protected UIIruna2Anchor chatAnchor; // 0x180
	[CompilerGenerated]
	private ChatWindow <chatWindow>k__BackingField; // 0x188
	[SerializeField]
	private GameObject playerLifeGaugeObject; // 0x190
	protected UIPlayerLifeGauge playerLifeGauge; // 0x198
	[SerializeField]
	private GameObject backPanel; // 0x1A0
	private UIMissTouchArea backMissTouchAreaPanel; // 0x1A8
	[SerializeField]
	private GameObject partyMemberUI; // 0x1B0
	[CompilerGenerated]
	private UIPartyStatus <partyMemberStatus>k__BackingField; // 0x1B8
	[SerializeField]
	private GameObject castTimerObject; // 0x1C0
	private UIWaitTimer waitTimer; // 0x1C8
	[SerializeField]
	private GameObject emotionBarObject; // 0x1D0
	private UIEmotionBar emotionBar; // 0x1D8
	private UIFadeManager fadeManager; // 0x1E0
	private bool initFlag; // 0x1E8
	[SerializeField]
	private GameObject guardObject; // 0x1F0
	private UIGuardGauge guardButton; // 0x1F8
	[SerializeField]
	private GameObject avoidObject; // 0x200
	private UIAvoidGauge avoidButton; // 0x208
	protected UIMainManager.UIElicitFlag elicitFlag; // 0x210
	protected int chatPosition; // 0x214
	private static readonly float shortcutMovingDistance; // 0x0
	protected UIBasePanel manager; // 0x218
	protected Dictionary<UIActiveState, string> panelList; // 0x220
	private List<UIMainManager.DropItemData> itemPopList; // 0x228
	private float popTimer; // 0x230
	[SerializeField]
	private GameObject itemIconObject; // 0x238
	private UIGLIcon itemIcon; // 0x240
	[SerializeField]
	private GameObject itemLabelObject; // 0x248
	private IUILabel itemLabel; // 0x250
	[SerializeField]
	private GameObject itemAnchorObject; // 0x258
	protected UIIruna2Anchor itemAnchor; // 0x260
	private Action popupItemAction; // 0x268
	[SerializeField]
	private GameObject dropItemIconObject; // 0x270

	// Properties
	public bool IsWorldCheckLock { get; }
	public Transform ParentPanel { get; }
	public Transform ParentWorldPanel { get; }
	public Camera UIMainCamera { get; }
	public ScreenFadeAnimationManager FadePanel { get; }
	public ScreenFadeAnimationManager UIBackPanel { get; }
	public UILoadingBar LoadingBar { get; }
	public UIActiveState PreviousState { get; }
	public UIActiveState ActiveState { get; }
	public virtual ChatChannelType ChatType { get; set; }
	public bool IsWorldPanelInactive { get; }
	public bool IsParameterCreate { get; }
	protected IPlayerControl PlayerControl { get; }
	public int SelectedMainMenuPanelId { get; }
	public virtual bool IsPreviousChatTargetMenu { get; }
	public virtual bool IsActiveChatTargetMenu { get; }
	public bool IsNotInfluenceShortcutActiveState { get; }
	public bool IsWaitingChatTarget { get; }
	public virtual bool IsPrintUI { get; }
	public bool IsTargetMenuPanelState { get; }
	public virtual bool IsOnlyFurniture { get; }
	public UITopButtonBase.ActionSystemType RightTopButtonActionType { get; }
	public UITopButtonBase.ActionSystemType LeftTopButtonActionType { get; }
	public UIRightStick RightStickObject { get; }
	public UILeftStick LeftStickObject { get; }
	public ChatWindow chatWindow { get; set; }
	public GameObject BackPanel { get; }
	public UIPartyStatus partyMemberStatus { get; set; }
	public UIWaitTimer UIWaitTimer { get; }
	public UIEmotionBar EmotionBar { get; }
	public UIFadeManager FadeManager { get; }
	public UIGuardGauge GuardButton { get; }
	public UIMainManager.UIElicitFlag ElicitFlag { get; }
	private bool isPrison { get; }
	public GameObject ActiveManager { get; }

	// Methods

	// RVA: 0x1E81064 Offset: 0x1E7D064 VA: 0x1E81064
	public bool get_IsWorldCheckLock() { }

	// RVA: 0x1E8106C Offset: 0x1E7D06C VA: 0x1E8106C
	public Transform get_ParentPanel() { }

	// RVA: 0x1E81074 Offset: 0x1E7D074 VA: 0x1E81074
	public Transform get_ParentWorldPanel() { }

	// RVA: 0x1E8107C Offset: 0x1E7D07C VA: 0x1E8107C
	public Camera get_UIMainCamera() { }

	// RVA: 0x1E81084 Offset: 0x1E7D084 VA: 0x1E81084
	public ScreenFadeAnimationManager get_FadePanel() { }

	// RVA: 0x1E81148 Offset: 0x1E7D148 VA: 0x1E81148
	public ScreenFadeAnimationManager get_UIBackPanel() { }

	// RVA: 0x1E7BCD0 Offset: 0x1E77CD0 VA: 0x1E7BCD0
	public UILoadingBar get_LoadingBar() { }

	// RVA: 0x1E81150 Offset: 0x1E7D150 VA: 0x1E81150
	public UIActiveState get_PreviousState() { }

	// RVA: 0x1E81158 Offset: 0x1E7D158 VA: 0x1E81158
	public UIActiveState get_ActiveState() { }

	// RVA: 0x1E81160 Offset: 0x1E7D160 VA: 0x1E81160 Slot: 6
	public virtual ChatChannelType get_ChatType() { }

	// RVA: 0x1E81168 Offset: 0x1E7D168 VA: 0x1E81168 Slot: 7
	public virtual void set_ChatType(ChatChannelType value) { }

	// RVA: 0x1E81214 Offset: 0x1E7D214 VA: 0x1E81214
	public bool get_IsWorldPanelInactive() { }

	// RVA: 0x1E81234 Offset: 0x1E7D234 VA: 0x1E81234
	public bool get_IsParameterCreate() { }

	// RVA: 0x1E812A4 Offset: 0x1E7D2A4 VA: 0x1E812A4
	protected IPlayerControl get_PlayerControl() { }

	// RVA: 0x1E81330 Offset: 0x1E7D330 VA: 0x1E81330
	public int get_SelectedMainMenuPanelId() { }

	// RVA: 0x1E81338 Offset: 0x1E7D338 VA: 0x1E81338 Slot: 8
	public virtual bool get_IsPreviousChatTargetMenu() { }

	// RVA: 0x1E81354 Offset: 0x1E7D354 VA: 0x1E81354 Slot: 9
	public virtual bool get_IsActiveChatTargetMenu() { }

	// RVA: 0x1E81370 Offset: 0x1E7D370 VA: 0x1E81370
	public bool get_IsNotInfluenceShortcutActiveState() { }

	// RVA: 0x1E81434 Offset: 0x1E7D434 VA: 0x1E81434
	public bool get_IsWaitingChatTarget() { }

	// RVA: 0x1E81460 Offset: 0x1E7D460 VA: 0x1E81460 Slot: 10
	public virtual bool get_IsPrintUI() { }

	// RVA: 0x1E81468 Offset: 0x1E7D468 VA: 0x1E81468
	public bool get_IsTargetMenuPanelState() { }

	// RVA: 0x1E814C0 Offset: 0x1E7D4C0 VA: 0x1E814C0 Slot: 11
	public virtual bool get_IsOnlyFurniture() { }

	// RVA: 0x1E814C8 Offset: 0x1E7D4C8 VA: 0x1E814C8 Slot: 12
	protected virtual void Awake() { }

	// RVA: 0x1E81D00 Offset: 0x1E7DD00 VA: 0x1E81D00
	private void Start() { }

	// RVA: 0x1E81D58 Offset: 0x1E7DD58 VA: 0x1E81D58 Slot: 13
	protected virtual void Update() { }

	// RVA: 0x1E821A4 Offset: 0x1E7E1A4 VA: 0x1E821A4 Slot: 14
	protected virtual void BackKeyCheck() { }

	// RVA: 0x1E8247C Offset: 0x1E7E47C VA: 0x1E8247C
	private void LateUpdate() { }

	// RVA: 0x1E82498 Offset: 0x1E7E498 VA: 0x1E82498 Slot: 15
	public virtual void OnEnter() { }

	// RVA: 0x1E8250C Offset: 0x1E7E50C VA: 0x1E8250C Slot: 16
	public virtual void OnLeave() { }

	// RVA: 0x1E82594 Offset: 0x1E7E594 VA: 0x1E82594
	public void SetStagingTimer(int time) { }

	// RVA: 0x1E825B0 Offset: 0x1E7E5B0 VA: 0x1E825B0
	public void SetMaintenanceTimer(int time) { }

	// RVA: 0x1E825CC Offset: 0x1E7E5CC VA: 0x1E825CC
	public void SetSystemLockFlag(UIMainManager.UISystemLockFlag flag) { }

	// RVA: 0x1E825DC Offset: 0x1E7E5DC VA: 0x1E825DC
	public void ClearSystemLockFlag() { }

	// RVA: 0x1E825E4 Offset: 0x1E7E5E4 VA: 0x1E825E4
	public void ClearSystemLockFlag(UIMainManager.UISystemLockFlag flag) { }

	// RVA: 0x1E825FC Offset: 0x1E7E5FC VA: 0x1E825FC
	public bool CheckSystemLock(UIMainManager.UISystemLockFlag flag) { }

	// RVA: 0x1E8260C Offset: 0x1E7E60C VA: 0x1E8260C
	public UITopButtonBase.ActionSystemType get_RightTopButtonActionType() { }

	// RVA: 0x1E82628 Offset: 0x1E7E628 VA: 0x1E82628
	public UITopButtonBase.ActionSystemType get_LeftTopButtonActionType() { }

	// RVA: 0x1E82644 Offset: 0x1E7E644 VA: 0x1E82644
	public UIRightStick get_RightStickObject() { }

	// RVA: 0x1E8271C Offset: 0x1E7E71C VA: 0x1E8271C
	public UILeftStick get_LeftStickObject() { }

	[CompilerGenerated]
	// RVA: 0x1E827F4 Offset: 0x1E7E7F4 VA: 0x1E827F4
	public ChatWindow get_chatWindow() { }

	[CompilerGenerated]
	// RVA: 0x1E827FC Offset: 0x1E7E7FC VA: 0x1E827FC
	private void set_chatWindow(ChatWindow value) { }

	// RVA: 0x1E8280C Offset: 0x1E7E80C VA: 0x1E8280C
	public GameObject get_BackPanel() { }

	[CompilerGenerated]
	// RVA: 0x1E82814 Offset: 0x1E7E814 VA: 0x1E82814
	public UIPartyStatus get_partyMemberStatus() { }

	[CompilerGenerated]
	// RVA: 0x1E8281C Offset: 0x1E7E81C VA: 0x1E8281C
	private void set_partyMemberStatus(UIPartyStatus value) { }

	// RVA: 0x1E8282C Offset: 0x1E7E82C VA: 0x1E8282C
	public UIWaitTimer get_UIWaitTimer() { }

	// RVA: 0x1E82944 Offset: 0x1E7E944 VA: 0x1E82944
	public UIEmotionBar get_EmotionBar() { }

	// RVA: 0x1E8294C Offset: 0x1E7E94C VA: 0x1E8294C
	public UIFadeManager get_FadeManager() { }

	// RVA: 0x1E82954 Offset: 0x1E7E954 VA: 0x1E82954
	public UIGuardGauge get_GuardButton() { }

	// RVA: 0x1E8295C Offset: 0x1E7E95C VA: 0x1E8295C
	public UIMainManager.UIElicitFlag get_ElicitFlag() { }

	// RVA: 0x1E82964 Offset: 0x1E7E964 VA: 0x1E82964
	public bool ElicitCheck(UIMainManager.UIElicitFlag status) { }

	// RVA: 0x1E82974 Offset: 0x1E7E974 VA: 0x1E82974
	private bool get_isPrison() { }

	// RVA: 0x1E82A44 Offset: 0x1E7EA44 VA: 0x1E82A44 Slot: 17
	public virtual void ElicitMainUI(UIMainManager.UIElicitFlag status, int chat) { }

	// RVA: 0x1E830A8 Offset: 0x1E7F0A8 VA: 0x1E830A8
	public void ReElicitMainUI() { }

	// RVA: 0x1E81624 Offset: 0x1E7D624 VA: 0x1E81624
	private void MainPanelInitialize() { }

	// RVA: 0x1E830C4 Offset: 0x1E7F0C4 VA: 0x1E830C4
	public void SetRightTopButtonType(UITopButtonBase.ActionSystemType type) { }

	// RVA: 0x1E830F0 Offset: 0x1E7F0F0 VA: 0x1E830F0
	public void SetLeftTopButtonType(UITopButtonBase.ActionSystemType type) { }

	// RVA: 0x1E83118 Offset: 0x1E7F118 VA: 0x1E83118 Slot: 18
	protected virtual void setTopButtonType(UITopButtonBase.ActionSystemType left, UITopButtonBase.ActionSystemType right) { }

	// RVA: 0x1E833B0 Offset: 0x1E7F3B0 VA: 0x1E833B0
	public void UpdateTopButton() { }

	// RVA: 0x1E833E4 Offset: 0x1E7F3E4 VA: 0x1E833E4
	public void LeftTopButtonAction() { }

	// RVA: 0x1E83AA4 Offset: 0x1E7FAA4 VA: 0x1E83AA4 Slot: 19
	public virtual void RightTopButtonAction() { }

	// RVA: 0x1E83F88 Offset: 0x1E7FF88 VA: 0x1E83F88
	public void SetMiniMap(Texture[] tex, Vector2 size, bool mask) { }

	// RVA: 0x1E84098 Offset: 0x1E80098 VA: 0x1E84098
	public void ChangeMiniMapControlPlayer(GameObject controlPlayer) { }

	// RVA: 0x1E8415C Offset: 0x1E8015C VA: 0x1E8415C
	public void ChangeMiniMapLevel(int level) { }

	// RVA: 0x1E84178 Offset: 0x1E80178 VA: 0x1E84178
	public void ClearMiniMapMask() { }

	// RVA: 0x1E84194 Offset: 0x1E80194 VA: 0x1E84194
	public int GetMiniMapLevel() { }

	// RVA: 0x1E841B0 Offset: 0x1E801B0 VA: 0x1E841B0
	public Texture GetWorldMapTexture() { }

	// RVA: 0x1E82FE4 Offset: 0x1E7EFE4 VA: 0x1E82FE4
	public void ShortcutButtonUpdate() { }

	// RVA: 0x1E841CC Offset: 0x1E801CC VA: 0x1E841CC
	public void ShortcutButtonLabelUpdate() { }

	// RVA: 0x1E8394C Offset: 0x1E7F94C VA: 0x1E8394C
	private bool MainGame() { }

	// RVA: 0x1E842C8 Offset: 0x1E802C8 VA: 0x1E842C8
	public GameObject get_ActiveManager() { }

	// RVA: 0x1E84350 Offset: 0x1E80350 VA: 0x1E84350
	public bool ChangePanelLaod(UIActiveState nextActive) { }

	// RVA: 0x1E84360 Offset: 0x1E80360 VA: 0x1E84360 Slot: 20
	public virtual bool ChangePanelLoad(UIActiveState nextActive) { }

	// RVA: 0x1E85910 Offset: 0x1E81910 VA: 0x1E85910
	public void OpenOrbShop(int pageId, byte index, bool moveOrbMenu) { }

	// RVA: 0x1E859FC Offset: 0x1E819FC VA: 0x1E859FC Slot: 21
	public virtual bool OpenShortcutPanel(ShortcutManager.ShortcutListType type) { }

	// RVA: 0x1E85A10 Offset: 0x1E81A10 VA: 0x1E85A10
	public void ChangeMainMenuPanelId(int panelId) { }

	// RVA: 0x1E85390 Offset: 0x1E81390 VA: 0x1E85390
	private bool CheckCanPartyInvite(int id, byte type) { }

	// RVA: 0x1E838C0 Offset: 0x1E7F8C0 VA: 0x1E838C0
	private bool CheckOtherOpenHistoryLog() { }

	// RVA: 0x1E85A18 Offset: 0x1E81A18 VA: 0x1E85A18
	public void AddMiniMapEventPoint(GameObject traceObject, EventArea.MiniMapType type) { }

	// RVA: 0x1E85AE4 Offset: 0x1E81AE4 VA: 0x1E85AE4
	public void AddMiniMapPlayerPoint(GameObject traceObject) { }

	// RVA: 0x1E85B60 Offset: 0x1E81B60 VA: 0x1E85B60
	public void AddMiniMapMobPoint(GameObject traceObject) { }

	// RVA: 0x1E85BDC Offset: 0x1E81BDC VA: 0x1E85BDC
	public void AddMiniMapMarkerPoint(GameObject traceObject, string spriteName) { }

	// RVA: 0x1E85C64 Offset: 0x1E81C64 VA: 0x1E85C64
	public void RemoveMiniMapPlayerPoint(GameObject traceObject) { }

	// RVA: 0x1E85C80 Offset: 0x1E81C80 VA: 0x1E85C80
	public void AddMiniMapNPCPoint(GameObject traceObject) { }

	// RVA: 0x1E85D18 Offset: 0x1E81D18 VA: 0x1E85D18
	public void AddMiniMapPoinColort(GameObject traceObject, Color setColor) { }

	// RVA: 0x1E85DC8 Offset: 0x1E81DC8 VA: 0x1E85DC8
	public GameObject CreateDropItemIconObject() { }

	// RVA: 0x1E85E9C Offset: 0x1E81E9C VA: 0x1E85E9C Slot: 22
	public virtual void PopItemAdd(int itemId, byte rareLevel, byte type) { }

	// RVA: 0x1E82048 Offset: 0x1E7E048 VA: 0x1E82048
	private void PopItemUpdate() { }

	// RVA: 0x1E86014 Offset: 0x1E82014 VA: 0x1E86014
	private void PopItemData(UIMainManager.DropItemData itemData) { }

	// RVA: 0x1E863E0 Offset: 0x1E823E0 VA: 0x1E863E0 Slot: 23
	protected virtual void FadeInItemAnchor() { }

	// RVA: 0x1E86458 Offset: 0x1E82458 VA: 0x1E86458
	private void PopItemRareCheck() { }

	// RVA: 0x1E865A4 Offset: 0x1E825A4 VA: 0x1E865A4
	private void PopItemClose() { }

	// RVA: 0x1E86684 Offset: 0x1E82684 VA: 0x1E86684
	private void PopNextItemCheck() { }

	// RVA: 0x1E86740 Offset: 0x1E82740 VA: 0x1E86740
	public UIBagMaxTextLabel CreateBagMaxTextLabel(Transform parent, Vector3 pos) { }

	// RVA: 0x1E86940 Offset: 0x1E82940 VA: 0x1E86940
	public void PopBagMaxTextLabel() { }

	// RVA: -1 Offset: -1
	public T GetActiveManager<T>(UIActiveState state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26FA1D4 Offset: 0x26F61D4 VA: 0x26FA1D4
	|-UIMainManager.GetActiveManager<object>
	*/

	// RVA: 0x1E869E8 Offset: 0x1E829E8 VA: 0x1E869E8
	public UIForwardEvents AddTapCameraObject(GameObject addTapPanel) { }

	// RVA: 0x1E86A64 Offset: 0x1E82A64 VA: 0x1E86A64 Slot: 24
	public virtual void AddScriptIcon(int uuid, int iconType, int iconid, string title, string message) { }

	// RVA: 0x1E86A80 Offset: 0x1E82A80 VA: 0x1E86A80 Slot: 25
	public virtual void RemoveScriptIcon(int uuid) { }

	// RVA: 0x1E86A9C Offset: 0x1E82A9C VA: 0x1E86A9C Slot: 26
	public virtual void ClearScriptIcon() { }

	// RVA: 0x1E86AB8 Offset: 0x1E82AB8 VA: 0x1E86AB8 Slot: 27
	public virtual void SetKeymap(PCInputKeyMap keycode, IKeyButton keyButton) { }

	// RVA: 0x1E86ABC Offset: 0x1E82ABC VA: 0x1E86ABC Slot: 28
	public virtual void RemoveKeymap(PCInputKeyMap keycode, IKeyButton keyButton) { }

	// RVA: 0x1E86AC0 Offset: 0x1E82AC0 VA: 0x1E86AC0 Slot: 29
	public virtual void AddUIGLWorldWidget(GameObject widget) { }

	// RVA: 0x1E86BDC Offset: 0x1E82BDC VA: 0x1E86BDC Slot: 30
	public virtual void OpenTellChat(int archeTypeId) { }

	// RVA: 0x1E86BE0 Offset: 0x1E82BE0 VA: 0x1E86BE0 Slot: 31
	public virtual void CloseTellChat(int uesrId, GameObject panel) { }

	// RVA: 0x1E86BE4 Offset: 0x1E82BE4 VA: 0x1E86BE4 Slot: 32
	public virtual void TellChatInput() { }

	// RVA: 0x1E86BE8 Offset: 0x1E82BE8 VA: 0x1E86BE8 Slot: 33
	public virtual GameObject OpenQuestDetailPanel(IScenario quest) { }

	// RVA: 0x1E86BF0 Offset: 0x1E82BF0 VA: 0x1E86BF0 Slot: 34
	public virtual void CloseQuestDetailPanel(GameObject panel) { }

	// RVA: 0x1E86BF4 Offset: 0x1E82BF4 VA: 0x1E86BF4
	public void SetClickMoveLock(bool bPush) { }

	// RVA: 0x1E86C00 Offset: 0x1E82C00 VA: 0x1E86C00
	public bool GetClickMoveLock() { }

	// RVA: 0x1E86C08 Offset: 0x1E82C08 VA: 0x1E86C08 Slot: 35
	public virtual void SetClickFurniture(bool bPush) { }

	// RVA: 0x1E86C0C Offset: 0x1E82C0C VA: 0x1E86C0C Slot: 36
	public virtual void StartChat() { }

	// RVA: 0x1E86C10 Offset: 0x1E82C10 VA: 0x1E86C10 Slot: 37
	public virtual void ChatActive() { }

	// RVA: 0x1E86C14 Offset: 0x1E82C14 VA: 0x1E86C14 Slot: 38
	public virtual bool IsActiveSubCommandPanel() { }

	// RVA: 0x1E86C1C Offset: 0x1E82C1C VA: 0x1E86C1C Slot: 39
	public virtual void SetPosCommandPanel() { }

	// RVA: 0x1E86C20 Offset: 0x1E82C20 VA: 0x1E86C20 Slot: 40
	public virtual void SetSubCommandOpenCheck(bool isCheck) { }

	// RVA: 0x1E86C24 Offset: 0x1E82C24 VA: 0x1E86C24 Slot: 41
	public virtual bool IsInputSelected() { }

	// RVA: 0x1E86C2C Offset: 0x1E82C2C VA: 0x1E86C2C Slot: 42
	public virtual int GetMenuChatPosition() { }

	// RVA: 0x1E86C34 Offset: 0x1E82C34 VA: 0x1E86C34 Slot: 43
	public virtual int GetGameChatPosition() { }

	// RVA: 0x1E86C3C Offset: 0x1E82C3C VA: 0x1E86C3C Slot: 44
	public virtual bool IsActiveTargetPanel() { }

	// RVA: 0x1E86C44 Offset: 0x1E82C44 VA: 0x1E86C44 Slot: 45
	public virtual void SelectTargetPanel(float delta) { }

	// RVA: 0x1E86C48 Offset: 0x1E82C48 VA: 0x1E86C48 Slot: 46
	public virtual void ClickTargetPanel() { }

	// RVA: 0x1E86C4C Offset: 0x1E82C4C VA: 0x1E86C4C Slot: 47
	public virtual void ChatOptionActive(bool bOpen = False) { }

	// RVA: 0x1E86C50 Offset: 0x1E82C50 VA: 0x1E86C50 Slot: 48
	public virtual void ActiveSubPanel(IUISubPanelMouse obj) { }

	// RVA: 0x1E86C54 Offset: 0x1E82C54 VA: 0x1E86C54 Slot: 49
	public virtual void SetSubPanelMouse(IUISubPanelMouse obj) { }

	// RVA: 0x1E86C58 Offset: 0x1E82C58 VA: 0x1E86C58 Slot: 50
	public virtual void DeleteSubPanelMouse(IUISubPanelMouse obj) { }

	// RVA: 0x1E86C5C Offset: 0x1E82C5C VA: 0x1E86C5C Slot: 51
	public virtual void SetActiveMainUI(bool bActive) { }

	// RVA: 0x1E86C60 Offset: 0x1E82C60 VA: 0x1E86C60 Slot: 52
	public virtual void SetChatSpaceMenuAnchor(Vector2 relativeOfffset) { }

	// RVA: 0x1E86C64 Offset: 0x1E82C64 VA: 0x1E86C64 Slot: 53
	public virtual void SetInfoMenuFade(bool isActiveLeft, bool isActiveRight) { }

	// RVA: 0x1E86C68 Offset: 0x1E82C68 VA: 0x1E86C68 Slot: 54
	public virtual void SetExpBarActive(bool isActive) { }

	// RVA: 0x1E86C6C Offset: 0x1E82C6C VA: 0x1E86C6C Slot: 55
	public virtual void UpdateSendKeyLabel() { }

	// RVA: 0x1E86C70 Offset: 0x1E82C70 VA: 0x1E86C70 Slot: 56
	public virtual bool GetHouseMainEditActive() { }

	// RVA: 0x1E86C78 Offset: 0x1E82C78 VA: 0x1E86C78 Slot: 57
	public virtual bool GetHouseMainSelectActive() { }

	// RVA: 0x1E86C80 Offset: 0x1E82C80 VA: 0x1E86C80
	public void .ctor() { }

	// RVA: 0x1E8954C Offset: 0x1E8554C VA: 0x1E8954C
	private static void .cctor() { }
}
