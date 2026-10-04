// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIDefenceEnterManager : UIBasePanel // TypeDefIndex: 5744
{
	// Fields
	[SerializeField]
	private GameObject mainPanel; // 0x30
	private UIIruna2Anchor mainAnchor; // 0x38
	[SerializeField]
	private GameObject subPanel; // 0x40
	private UIIruna2Anchor subAnchor; // 0x48
	[SerializeField]
	private GameObject rankPanel; // 0x50
	private UIIruna2Anchor rankAnchor; // 0x58
	[SerializeField]
	private GameObject partyNamePanel; // 0x60
	private UIIruna2Anchor partyNameAnchor; // 0x68
	private UIDefenceEnterManager.PanelState panelFlag; // 0x70
	[SerializeField]
	private GameObject partyMessage; // 0x78
	[SerializeField]
	private GameObject lockMessage; // 0x80
	[SerializeField]
	private UILabel rimitTimeLabel; // 0x88
	[SerializeField]
	private UILabel bestScoreLabel; // 0x90
	[SerializeField]
	private UILabel bestTimeLabel; // 0x98
	private int clock; // 0xA0
	[SerializeField]
	private GameObject difficultyRightButton; // 0xA8
	[SerializeField]
	private GameObject difficultyLeftButton; // 0xB0
	[SerializeField]
	private UILabel difficultyLevelLabel; // 0xB8
	[SerializeField]
	private UILabel diffBestLevel; // 0xC0
	[SerializeField]
	private UILabel difficultyLabel; // 0xC8
	[SerializeField]
	private UIImageButton rankButton; // 0xD0
	[SerializeField]
	private UIImageButton presentButton; // 0xD8
	private GameObject presentPopUp; // 0xE0
	[SerializeField]
	private GameObject recoveryButton; // 0xE8
	[SerializeField]
	private GameObject[] popupWinButton; // 0xF0
	private UIIruna2Anchor okButtonAnchor; // 0xF8
	[SerializeField]
	private UILabel creditLabel; // 0x100
	[SerializeField]
	private GameObject gemSprite; // 0x108
	private int gemCount; // 0x110
	private int nowgemCount; // 0x114
	[SerializeField]
	private UIImageButton defenceEnterButton; // 0x118
	[SerializeField]
	private UILabel defenceEnterLabel; // 0x120
	[SerializeField]
	private GameObject[] partyMemberObj; // 0x128
	protected UIPartyMember[] partyMemberData; // 0x130
	protected TweenPosition[] partyMemberEffect; // 0x138
	[SerializeField]
	private GameObject topObj; // 0x140
	[SerializeField]
	private GameObject bottomObj; // 0x148
	[SerializeField]
	private GameObject errLabel; // 0x150
	private bool partnerFlag; // 0x158
	private UIPopBaseWindow popWindow; // 0x160
	private UIPopWindow errPopWindow; // 0x168
	private UIDefenceEnterBasePanel defenceEnterBasePanel; // 0x170
	private bool initFlag; // 0x178
	private float connectTimer; // 0x17C
	private float countDownTimer; // 0x180
	private PlayerDataManager playerDataManager; // 0x188
	private DefenceRoomData defenceRoomData; // 0x190
	private int fieldId; // 0x198
	private byte flag; // 0x19C
	private List<int> difficultyLevel; // 0x1A0
	private int difficultyCount; // 0x1A8
	private int beforeDifficultyCount; // 0x1AC
	private int memberDifficulty; // 0x1B0
	private bool rewardGetFlag; // 0x1B4
	private bool cancel; // 0x1B5
	private bool close; // 0x1B6
	private bool orbShop; // 0x1B7
	private GameObject shortcutManager; // 0x1B8
	private bool openShortcut; // 0x1C0
	private DefenceRoomData roomData; // 0x1C8
	private bool updateCoinItem; // 0x1D0
	private OrbManager orbManager; // 0x1D8
	private bool inputLock; // 0x1E0
	private float loadingTimer; // 0x1E4
	private GameObject loadingObject; // 0x1E8
	private int orbNum; // 0x1F0
	private int orbItemNum; // 0x1F4
	private bool orbFlag; // 0x1F8
	private bool isReconnected; // 0x1F9
	private DefenceRoomData beforeRoomData; // 0x200

	// Properties
	public bool IsCancel { get; }
	public bool IsClose { get; }
	public bool IsOrbShop { get; }

	// Methods

	// RVA: 0x17D3A38 Offset: 0x17CFA38 VA: 0x17D3A38
	public bool get_IsCancel() { }

	// RVA: 0x17D3A40 Offset: 0x17CFA40 VA: 0x17D3A40
	public bool get_IsClose() { }

	// RVA: 0x17D3A48 Offset: 0x17CFA48 VA: 0x17D3A48
	public bool get_IsOrbShop() { }

	// RVA: 0x17D3A50 Offset: 0x17CFA50 VA: 0x17D3A50
	private void Awake() { }

	// RVA: 0x17D3A58 Offset: 0x17CFA58 VA: 0x17D3A58
	private void Start() { }

	// RVA: 0x17D3D90 Offset: 0x17CFD90 VA: 0x17D3D90
	private void OnDestroy() { }

	// RVA: 0x17D3DE8 Offset: 0x17CFDE8 VA: 0x17D3DE8
	public void Initialize(int fieldId, byte flag, List<int> difficulty, int diffNum) { }

	// RVA: 0x17D42F0 Offset: 0x17D02F0 VA: 0x17D42F0
	private void InitPartnerMercenary() { }

	[IteratorStateMachine(typeof(UIDefenceEnterManager.<WaitRoomData>d__83))]
	// RVA: 0x17D4378 Offset: 0x17D0378 VA: 0x17D4378
	private IEnumerator WaitRoomData() { }

	// RVA: 0x17D43E4 Offset: 0x17D03E4 VA: 0x17D43E4
	private void Initialize() { }

	// RVA: 0x17D4C98 Offset: 0x17D0C98 VA: 0x17D4C98
	private void SetTrialPoint() { }

	[IteratorStateMachine(typeof(UIDefenceEnterManager.<UpdateOrbItem>d__86))]
	// RVA: 0x17D50B8 Offset: 0x17D10B8 VA: 0x17D50B8
	private IEnumerator UpdateOrbItem() { }

	// RVA: 0x17D514C Offset: 0x17D114C VA: 0x17D514C
	private void Update() { }

	// RVA: 0x17D5C20 Offset: 0x17D1C20 VA: 0x17D5C20
	private void BattleReady() { }

	// RVA: 0x17D5A98 Offset: 0x17D1A98 VA: 0x17D5A98
	private void BattleReadyCancel() { }

	// RVA: 0x17D5EE0 Offset: 0x17D1EE0 VA: 0x17D5EE0
	private void PopUpRanking() { }

	[IteratorStateMachine(typeof(UIDefenceEnterManager.<WaitRankScore>d__91))]
	// RVA: 0x17D6764 Offset: 0x17D2764 VA: 0x17D6764
	private IEnumerator WaitRankScore() { }

	[IteratorStateMachine(typeof(UIDefenceEnterManager.<WaitRanking>d__92))]
	// RVA: 0x17D617C Offset: 0x17D217C VA: 0x17D617C
	private IEnumerator WaitRanking() { }

	// RVA: 0x17D6820 Offset: 0x17D2820 VA: 0x17D6820
	private void PopUpRecovery(int type) { }

	[IteratorStateMachine(typeof(UIDefenceEnterManager.<CheckOrbNum>d__94))]
	// RVA: 0x17D6840 Offset: 0x17D2840 VA: 0x17D6840
	private IEnumerator CheckOrbNum() { }

	[IteratorStateMachine(typeof(UIDefenceEnterManager.<CheckOrbItemNum>d__95))]
	// RVA: 0x17D68D4 Offset: 0x17D28D4 VA: 0x17D68D4
	private IEnumerator CheckOrbItemNum() { }

	// RVA: 0x17D6968 Offset: 0x17D2968 VA: 0x17D6968
	private void PopUpInputData() { }

	[IteratorStateMachine(typeof(UIDefenceEnterManager.<RecoveryTrialPoint>d__97))]
	// RVA: 0x17D6AC0 Offset: 0x17D2AC0 VA: 0x17D6AC0
	private IEnumerator RecoveryTrialPoint() { }

	[IteratorStateMachine(typeof(UIDefenceEnterManager.<RecoveryItemTrialPoint>d__98))]
	// RVA: 0x17D6A54 Offset: 0x17D2A54 VA: 0x17D6A54
	private IEnumerator RecoveryItemTrialPoint() { }

	[IteratorStateMachine(typeof(UIDefenceEnterManager.<ConnectWait>d__99))]
	// RVA: 0x17D6B7C Offset: 0x17D2B7C VA: 0x17D6B7C
	private IEnumerator ConnectWait(OrbManager.ConnectFlag connectFlag) { }

	// RVA: 0x17D6C20 Offset: 0x17D2C20 VA: 0x17D6C20
	private void DifficultyUp() { }

	// RVA: 0x17D6D88 Offset: 0x17D2D88 VA: 0x17D6D88
	private void DifficultyDown() { }

	// RVA: 0x17D6EB8 Offset: 0x17D2EB8 VA: 0x17D6EB8
	private void PopUpPresent(int type) { }

	[IteratorStateMachine(typeof(UIDefenceEnterManager.<WaitResultData>d__103))]
	// RVA: 0x17D6F84 Offset: 0x17D2F84 VA: 0x17D6F84
	private IEnumerator WaitResultData() { }

	// RVA: 0x17D7018 Offset: 0x17D3018 VA: 0x17D7018
	private void PopUpGetPresent() { }

	[IteratorStateMachine(typeof(UIDefenceEnterManager.<WaitReward>d__105))]
	// RVA: 0x17D7138 Offset: 0x17D3138 VA: 0x17D7138
	private IEnumerator WaitReward() { }

	// RVA: 0x17D71CC Offset: 0x17D31CC VA: 0x17D71CC
	private void rewardEffect() { }

	// RVA: 0x17D727C Offset: 0x17D327C VA: 0x17D727C
	private void onEndRewardEffect() { }

	// RVA: 0x17D7550 Offset: 0x17D3550 VA: 0x17D7550
	private void RewardSystem(UIQuestRewardList list) { }

	// RVA: 0x17D7788 Offset: 0x17D3788 VA: 0x17D7788
	private void onEndRewardPanel() { }

	// RVA: 0x17D7A0C Offset: 0x17D3A0C VA: 0x17D7A0C
	private void onPopUpClose() { }

	// RVA: 0x17D3C68 Offset: 0x17CFC68 VA: 0x17D3C68
	private void SetLeftButtonType(UITopButtonBase.ActionSystemType type) { }

	// RVA: 0x17D3CFC Offset: 0x17CFCFC VA: 0x17D3CFC
	private void SetRightButtonType(UITopButtonBase.ActionSystemType type) { }

	// RVA: 0x17D7AFC Offset: 0x17D3AFC VA: 0x17D7AFC
	public void ForceClose() { }

	// RVA: 0x17D7B2C Offset: 0x17D3B2C VA: 0x17D7B2C
	public void CopeGroupNotFound() { }

	// RVA: 0x17D59C0 Offset: 0x17D19C0 VA: 0x17D59C0
	private void CloseShortcutPanel() { }

	// RVA: 0x17D7EF8 Offset: 0x17D3EF8 VA: 0x17D7EF8 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x17D839C Offset: 0x17D439C VA: 0x17D839C Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x17D86E4 Offset: 0x17D46E4 VA: 0x17D86E4 Slot: 4
	public override void OnOpenShortcutPanel(GameObject shortcutManager) { }

	// RVA: 0x17D8824 Offset: 0x17D4824 VA: 0x17D8824
	public void .ctor() { }
}
