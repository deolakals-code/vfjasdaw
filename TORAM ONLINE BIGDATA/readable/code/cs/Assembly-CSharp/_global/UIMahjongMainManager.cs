// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMahjongMainManager : UIBasePanelConnection // TypeDefIndex: 5914
{
	// Fields
	[SerializeField]
	private GameObject frame; // 0x30
	[SerializeField]
	private UILabel titleLabel; // 0x38
	[SerializeField]
	private GameObject titleIcon; // 0x40
	[SerializeField]
	private GameObject topLabelFaram; // 0x48
	[SerializeField]
	private UILabel topLabel; // 0x50
	[SerializeField]
	private GameObject[] panels; // 0x58
	[SerializeField]
	private UIMahjongTitleController title; // 0x60
	[SerializeField]
	private UIMahjongRoomController room; // 0x68
	[SerializeField]
	private UIMahjongGameStartAnimController startAnim; // 0x70
	[SerializeField]
	private UIMahjongGameManager gameManager; // 0x78
	[SerializeField]
	private UIMahjongSettingWindowController setting; // 0x80
	[SerializeField]
	private UIMahjongErrorWindowController error; // 0x88
	[SerializeField]
	private GameObject titleSettingsButton; // 0x90
	[SerializeField]
	private GameObject titleExclamationMarkIcon; // 0x98
	[SerializeField]
	private UIMahjongVoiceListWindowController voiceListWindowController; // 0xA0
	[SerializeField]
	private UIMahjongDoraWindowManager doraWindow; // 0xA8
	[SerializeField]
	private UIMahjongUsefulToolsWindowManager usefulToolWindow; // 0xB0
	[SerializeField]
	private GameObject roundLabelObj; // 0xB8
	[SerializeField]
	private UILabel roundLabel; // 0xC0
	[SerializeField]
	private GameObject gameScreenButtonParent; // 0xC8
	[SerializeField]
	private Transform psiTileSelecteParent; // 0xD0
	[SerializeField]
	private UIMahjongTileController psiTileSelecteTile; // 0xD8
	[SerializeField]
	private UIMahjongResultManager resultManager; // 0xE0
	private MahjongRoomData roomData; // 0xE8
	private GameObject shortcutManager; // 0xF0
	private UIMahjongMainManager.PanelState panelState; // 0xF8
	private UIMahjongMainManager.PanelState beforeState; // 0xFC
	private MahjongUpdateRoomStateEvent updateRoomState; // 0x100
	private MahjongChangeSettingEvent changeSetting; // 0x108
	private List<MahjongMemberData> newJoinMemberDatas; // 0x110
	private List<int> leaveMemberArchetypeIds; // 0x118
	private List<int> kickOutMemberIds; // 0x120
	private bool isRoomDissolutionWaitWindow; // 0x128
	private MahjongSynchronizationEvent syncEvent; // 0x130
	private List<UIMahjongTileController> psiTileSelecteTiles; // 0x138
	private Coroutine waitCloseChatWindowCoroutine; // 0x140

	// Properties
	public UIMahjongRoomController Room { get; }
	public UIMahjongGameManager GameManager { get; }
	public UIMahjongMainManager.PanelState ActivePanel { get; }
	public bool InputLock { get; }
	public UIMahjongResultManager ResultManager { get; }
	public SystemTextManager Sys { get; }
	public UIMahjongUsefulToolsWindowManager UsefulToolsWindowManager { get; }
	public UIMahjongErrorWindowController Error { get; }
	public MahjongSynchronizationEvent SyncEvent { get; }

	// Methods

	// RVA: 0x183B204 Offset: 0x1837204 VA: 0x183B204
	public UIMahjongRoomController get_Room() { }

	// RVA: 0x183B20C Offset: 0x183720C VA: 0x183B20C
	public UIMahjongGameManager get_GameManager() { }

	// RVA: 0x183B214 Offset: 0x1837214 VA: 0x183B214
	public UIMahjongMainManager.PanelState get_ActivePanel() { }

	// RVA: 0x183B21C Offset: 0x183721C VA: 0x183B21C
	public bool get_InputLock() { }

	// RVA: 0x183B2A4 Offset: 0x18372A4 VA: 0x183B2A4
	public UIMahjongResultManager get_ResultManager() { }

	// RVA: 0x183A770 Offset: 0x1836770 VA: 0x183A770
	public SystemTextManager get_Sys() { }

	// RVA: 0x183B2AC Offset: 0x18372AC VA: 0x183B2AC
	public UIMahjongUsefulToolsWindowManager get_UsefulToolsWindowManager() { }

	// RVA: 0x183B2B4 Offset: 0x18372B4 VA: 0x183B2B4
	public UIMahjongErrorWindowController get_Error() { }

	// RVA: 0x183B2BC Offset: 0x18372BC VA: 0x183B2BC
	public MahjongSynchronizationEvent get_SyncEvent() { }

	// RVA: 0x183B2C4 Offset: 0x18372C4 VA: 0x183B2C4
	private void Awake() { }

	// RVA: 0x183B2CC Offset: 0x18372CC VA: 0x183B2CC
	private void Update() { }

	// RVA: 0x183C04C Offset: 0x183804C VA: 0x183C04C
	public void Initialize() { }

	// RVA: 0x183C1E0 Offset: 0x18381E0 VA: 0x183C1E0
	public void SetRoomData(MahjongRoomData mahjongRoomData) { }

	// RVA: 0x183C1E8 Offset: 0x18381E8 VA: 0x183C1E8
	public void SetFrameTitleLabel(string title, bool isIconActive) { }

	// RVA: 0x183C228 Offset: 0x1838228 VA: 0x183C228
	public void ReSizeLabelWidth(UILabel label, int width, float magnification) { }

	// RVA: 0x183B3C0 Offset: 0x18373C0 VA: 0x183B3C0
	public void ChangePanel(UIMahjongMainManager.PanelState state) { }

	// RVA: 0x183D54C Offset: 0x183954C VA: 0x183D54C
	public void ChangeMainUITopButtons(UIMahjongMainManager.PanelState state) { }

	// RVA: 0x183CD44 Offset: 0x1838D44 VA: 0x183CD44
	public void CheckWaitUpdateRoomState(MahjongUpdateRoomStateEvent update) { }

	// RVA: 0x183CE58 Offset: 0x1838E58 VA: 0x183CE58
	public void CheckWaitChangeRoomSetting(MahjongChangeSettingEvent change) { }

	// RVA: 0x183CF40 Offset: 0x1838F40 VA: 0x183CF40
	public void CheckWaitNewJoinMember(MahjongMemberData memberData) { }

	// RVA: 0x183D1D8 Offset: 0x18391D8 VA: 0x183D1D8
	public void CheckWaitLeaveMember(int archetypeId) { }

	// RVA: 0x183C950 Offset: 0x1838950 VA: 0x183C950
	public bool CheckKickOut(int kickUserArchetypeId) { }

	// RVA: 0x183D8F4 Offset: 0x18398F4 VA: 0x183D8F4
	public void OnEnterKickOutRoom() { }

	// RVA: 0x183C7C0 Offset: 0x18387C0 VA: 0x183C7C0
	public void CheckRoomDissolution() { }

	// RVA: 0x183D45C Offset: 0x183945C VA: 0x183D45C
	public void ChangeMatchingFlag(bool flag) { }

	// RVA: 0x183D47C Offset: 0x183947C VA: 0x183D47C
	public void ChangeTopLabel(string text) { }

	// RVA: 0x183DA20 Offset: 0x1839A20 VA: 0x183DA20
	public void CheckSynchronization(MahjongSynchronizationEvent syncEvent) { }

	// RVA: 0x183DBE4 Offset: 0x1839BE4 VA: 0x183DBE4
	public void ActiveLeaveRoomConfirmationWindow() { }

	// RVA: 0x183DEAC Offset: 0x1839EAC VA: 0x183DEAC
	public void UpdateDoraDisplay() { }

	// RVA: 0x183DF50 Offset: 0x1839F50 VA: 0x183DF50
	public void ActiveDestinyDrawWindow() { }

	// RVA: 0x183E730 Offset: 0x183A730 VA: 0x183E730
	public void ActiveStickyFingersWindow() { }

	// RVA: 0x183EE64 Offset: 0x183AE64 VA: 0x183EE64
	public void ActiveGraffitiWindow() { }

	// RVA: 0x183C2E8 Offset: 0x18382E8 VA: 0x183C2E8
	public void BackGameWindow() { }

	// RVA: 0x183F578 Offset: 0x183B578 VA: 0x183F578
	public void GameStartAnimStart(Action callBack) { }

	// RVA: 0x183F630 Offset: 0x183B630 VA: 0x183F630
	public void DisplayResult(byte endType, MahjongPlayerRoundResultData[] resultList, MahjongTileData[] uraDoraList, bool isGameEnd) { }

	// RVA: 0x18401C8 Offset: 0x183C1C8 VA: 0x18401C8
	public void GameEnd() { }

	// RVA: 0x18401E8 Offset: 0x183C1E8 VA: 0x18401E8
	public void OnClickLeaveRoom() { }

	// RVA: 0x183D804 Offset: 0x1839804 VA: 0x183D804
	public void OnClickBackRoomMenu() { }

	// RVA: 0x1840244 Offset: 0x183C244 VA: 0x1840244
	public void OnClickOpenGmPanel() { }

	// RVA: 0x184027C Offset: 0x183C27C VA: 0x184027C
	public void OnClickSettingWindow() { }

	// RVA: 0x18402CC Offset: 0x183C2CC VA: 0x18402CC
	public void OnClickChangeChatButton() { }

	[IteratorStateMachine(typeof(UIMahjongMainManager.<WaitGameStartAnim>d__87))]
	// RVA: 0x183F5B4 Offset: 0x183B5B4 VA: 0x183F5B4
	private IEnumerator WaitGameStartAnim(float waitTime, Action callBack) { }

	[IteratorStateMachine(typeof(UIMahjongMainManager.<WaitVoiceToSE>d__88))]
	// RVA: 0x1840374 Offset: 0x183C374 VA: 0x1840374
	private IEnumerator WaitVoiceToSE(float waitTime, MahjongSEType mahjongSE, MahjongVoiceType voiceType, List<int> archetypeIds) { }

	// RVA: 0x183D498 Offset: 0x1839498 VA: 0x183D498
	private void Initialize_GameMenu() { }

	// RVA: 0x184044C Offset: 0x183C44C VA: 0x184044C
	private void DestinyDrawSelect(int tileId) { }

	// RVA: 0x18404CC Offset: 0x183C4CC VA: 0x18404CC
	private void StickyFingersPickUpSelect(int tileUid) { }

	// RVA: 0x18405BC Offset: 0x183C5BC VA: 0x18405BC
	private void StickyFingersDiscardSelect(int tileUid) { }

	// RVA: 0x184072C Offset: 0x183C72C VA: 0x184072C
	private void GraffitiSelect(int tileId) { }

	// RVA: 0x183D4E8 Offset: 0x18394E8 VA: 0x183D4E8
	private void Initialize_ResultMenu() { }

	// RVA: 0x183D4EC Offset: 0x18394EC VA: 0x183D4EC
	private void InitializeErrorWindow() { }

	// RVA: 0x18407AC Offset: 0x183C7AC VA: 0x18407AC Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1840B1C Offset: 0x183CB1C VA: 0x1840B1C Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x18409B4 Offset: 0x183C9B4 VA: 0x18409B4
	private void OnClickRightTopButton() { }

	// RVA: 0x1840850 Offset: 0x183C850 VA: 0x1840850
	private void OnClickLeftTopButton() { }

	// RVA: 0x1840C2C Offset: 0x183CC2C VA: 0x1840C2C Slot: 4
	public override void OnOpenShortcutPanel(GameObject shortcutManager) { }

	[IteratorStateMachine(typeof(UIMahjongMainManager.<WaitCloseChatWindow>d__101))]
	// RVA: 0x1840BC0 Offset: 0x183CBC0 VA: 0x1840BC0
	private IEnumerator WaitCloseChatWindow() { }

	// RVA: 0x1840C74 Offset: 0x183CC74 VA: 0x1840C74
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1840C7C Offset: 0x183CC7C VA: 0x1840C7C
	private void <CheckKickOut>b__67_0() { }

	[CompilerGenerated]
	// RVA: 0x1840C84 Offset: 0x183CC84 VA: 0x1840C84
	private void <OnEnterKickOutRoom>b__68_0() { }

	[CompilerGenerated]
	// RVA: 0x1840C8C Offset: 0x183CC8C VA: 0x1840C8C
	private void <CheckRoomDissolution>b__69_0() { }

	[CompilerGenerated]
	// RVA: 0x1840C94 Offset: 0x183CC94 VA: 0x1840C94
	private void <ActiveLeaveRoomConfirmationWindow>b__73_0() { }

	[CompilerGenerated]
	// RVA: 0x1840C9C Offset: 0x183CC9C VA: 0x1840C9C
	private void <ActiveStickyFingersWindow>b__76_0() { }

	[CompilerGenerated]
	// RVA: 0x1840CD0 Offset: 0x183CCD0 VA: 0x1840CD0
	private bool <DisplayResult>b__80_2(MahjongPlayerRoundResultData x) { }
}
