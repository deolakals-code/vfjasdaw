// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UICraneGameManager : UIBasePanelConnection // TypeDefIndex: 4331
{
	// Fields
	[SerializeField]
	private UICraneGameFlashingManager inputWideButton; // 0x30
	[SerializeField]
	private UICraneGameFlashingManager inputForwardButton; // 0x38
	[SerializeField]
	private GameObject itemPosResetButton; // 0x40
	[SerializeField]
	private UIImageButton[] startButton; // 0x48
	[SerializeField]
	private UILabel totalScoreLabel; // 0x50
	[SerializeField]
	private UILabel userGoldLabel; // 0x58
	[SerializeField]
	private UILabel playCountLabel; // 0x60
	[SerializeField]
	private GameObject[] changeActiveGroup; // 0x68
	[SerializeField]
	private GameObject pcOnlyExitButton; // 0x70
	private CraneGameController controller; // 0x78
	private CraneGameRoomData roomData; // 0x80
	private int playCount; // 0x88
	private bool inputWide; // 0x8C
	private bool inputForward; // 0x8D
	private UICraneGameManager.GameProgress gameProgress; // 0x90
	private bool startOperationEnabled; // 0x94
	private bool playOneLoopEnabled; // 0x95
	private UIPopBaseWindow popWindow; // 0x98
	private UIPopBaseWindow popLoadWindow; // 0xA0
	private const int MINSCORE = 100;
	private bool isFirstInitialize; // 0xA8
	private UICraneGameManager.DisplayStatus displayStatus; // 0xAC
	private GameObject shortcutManager; // 0xB0
	private bool stopLeftButtonAction; // 0xB8

	// Properties
	public UICraneGameManager.DisplayStatus ReadOnlyDisplayStatus { get; }

	// Methods

	// RVA: 0x24CE2F8 Offset: 0x24CA2F8 VA: 0x24CE2F8
	public UICraneGameManager.DisplayStatus get_ReadOnlyDisplayStatus() { }

	// RVA: 0x24CE300 Offset: 0x24CA300 VA: 0x24CE300
	public void SetCranegameController(CraneGameController controller) { }

	// RVA: 0x24CE308 Offset: 0x24CA308 VA: 0x24CE308
	public void SetRoomData(CraneGameRoomData roomData) { }

	// RVA: 0x24CE310 Offset: 0x24CA310 VA: 0x24CE310
	private void Awake() { }

	// RVA: 0x24CE318 Offset: 0x24CA318 VA: 0x24CE318
	private void Start() { }

	// RVA: 0x24CE660 Offset: 0x24CA660 VA: 0x24CE660
	private void Update() { }

	// RVA: 0x24CEAE8 Offset: 0x24CAAE8 VA: 0x24CEAE8
	public void Initialize() { }

	[IteratorStateMachine(typeof(UICraneGameManager.<UpdateKeyLabel>d__34))]
	// RVA: 0x24CEBE0 Offset: 0x24CABE0 VA: 0x24CEBE0
	private IEnumerator UpdateKeyLabel() { }

	// RVA: 0x24CEC60 Offset: 0x24CAC60 VA: 0x24CEC60
	public void OnPushWideButton(bool input) { }

	// RVA: 0x24CEE4C Offset: 0x24CAE4C VA: 0x24CEE4C
	public void OnPushForwordButton(bool input) { }

	// RVA: 0x24CF000 Offset: 0x24CB000 VA: 0x24CF000
	public void OnPushItemPosReset() { }

	// RVA: 0x24CF2A8 Offset: 0x24CB2A8 VA: 0x24CF2A8
	public void OnPushLeaveRoom() { }

	// RVA: 0x24CF55C Offset: 0x24CB55C VA: 0x24CF55C
	public void OnPushAddPlayCount(int count) { }

	// RVA: 0x24CF6CC Offset: 0x24CB6CC VA: 0x24CF6CC
	public void CraneGameResult(int getCount) { }

	// RVA: 0x24CEDE8 Offset: 0x24CADE8 VA: 0x24CEDE8
	private void ChangeGameProgress(byte num) { }

	// RVA: 0x24CEB2C Offset: 0x24CAB2C VA: 0x24CEB2C
	private void ApplyScoreLabel(int score) { }

	// RVA: 0x24CF820 Offset: 0x24CB820 VA: 0x24CF820
	private void AddScoreApplyLabel(int getScore) { }

	// RVA: 0x24CF924 Offset: 0x24CB924 VA: 0x24CF924
	private void ApplyGoldLabel(int gold) { }

	// RVA: 0x24CF5F8 Offset: 0x24CB5F8 VA: 0x24CF5F8
	private void GoldLabelAnim(int playCount) { }

	// RVA: 0x24CF618 Offset: 0x24CB618 VA: 0x24CF618
	private void ApplyPlayCountLabel(int playCount) { }

	[IteratorStateMachine(typeof(UICraneGameManager.<CreatLoadingWaitPopUp>d__47))]
	// RVA: 0x24CF1DC Offset: 0x24CB1DC VA: 0x24CF1DC
	private IEnumerator CreatLoadingWaitPopUp(string title, string text, Action completedAction, Action canecelAction) { }

	[IteratorStateMachine(typeof(UICraneGameManager.<CreatePopup>d__48))]
	// RVA: 0x24CF490 Offset: 0x24CB490 VA: 0x24CF490
	private IEnumerator CreatePopup(string title, string text, Action completedAction, Action cancelAction) { }

	// RVA: 0x24CE414 Offset: 0x24CA414 VA: 0x24CE414
	private void ChangeDisplayStatus(UICraneGameManager.DisplayStatus status) { }

	// RVA: 0x24CFAA4 Offset: 0x24CBAA4 VA: 0x24CFAA4
	private void LeaveRoom() { }

	// RVA: 0x24CFB38 Offset: 0x24CBB38 VA: 0x24CFB38
	private void CheckConnectionLeaveOperation(Action callBack) { }

	// RVA: 0x24CFCCC Offset: 0x24CBCCC VA: 0x24CFCCC
	private void DefaultLeftTopButton() { }

	// RVA: 0x24CFE1C Offset: 0x24CBE1C VA: 0x24CFE1C
	private void DefaultRightButton() { }

	// RVA: 0x24CFEB4 Offset: 0x24CBEB4 VA: 0x24CFEB4
	private void GameReset() { }

	// RVA: 0x24CFF58 Offset: 0x24CBF58 VA: 0x24CFF58 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x24CFFCC Offset: 0x24CBFCC VA: 0x24CFFCC Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x24D0040 Offset: 0x24CC040 VA: 0x24D0040 Slot: 4
	public override void OnOpenShortcutPanel(GameObject shortcutManager) { }

	// RVA: 0x24D00D8 Offset: 0x24CC0D8 VA: 0x24D00D8
	public void SetGoldLabel() { }

	// RVA: 0x24D00F4 Offset: 0x24CC0F4 VA: 0x24D00F4
	public void .ctor() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(UICraneGameManager.<<GoldLabelAnim>g__Anim|45_0>d))]
	// RVA: 0x24CF9D8 Offset: 0x24CB9D8 VA: 0x24CF9D8
	private IEnumerator <GoldLabelAnim>g__Anim|45_0(int playCount) { }

	[IteratorStateMachine(typeof(UICraneGameManager.<<GameReset>g__CheckConnectionError|54_0>d))]
	[CompilerGenerated]
	// RVA: 0x24CFEEC Offset: 0x24CBEEC VA: 0x24CFEEC
	private IEnumerator <GameReset>g__CheckConnectionError|54_0() { }

	[CompilerGenerated]
	// RVA: 0x24D01E0 Offset: 0x24CC1E0 VA: 0x24D01E0
	private void <GameReset>b__54_2() { }

	[CompilerGenerated]
	// RVA: 0x24D03C0 Offset: 0x24CC3C0 VA: 0x24D03C0
	private void <GameReset>b__54_3() { }
}
