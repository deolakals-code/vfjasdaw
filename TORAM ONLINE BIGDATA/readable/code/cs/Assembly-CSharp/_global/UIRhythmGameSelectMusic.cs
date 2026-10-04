// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIRhythmGameSelectMusic : MonoBehaviour // TypeDefIndex: 6226
{
	// Fields
	[SerializeField]
	private GameObject mainObject; // 0x20
	[SerializeField]
	private GameObject[] selectButtonObject; // 0x28
	[SerializeField]
	private GameObject underObject; // 0x30
	[SerializeField]
	private UISprite backPanel; // 0x38
	[SerializeField]
	private UISprite[] frameVirticalObject; // 0x40
	[SerializeField]
	private GameObject frameUnderObject; // 0x48
	[SerializeField]
	private UILabel titleLabel; // 0x50
	[SerializeField]
	private UILabel bestScoreLabel; // 0x58
	[SerializeField]
	private UIImageButton[] difficultyButton; // 0x60
	[SerializeField]
	private GameObject[] scoreBaseIconObj; // 0x68
	[SerializeField]
	private UISprite[] scoreColorIconObj; // 0x70
	[SerializeField]
	private UIImageButton startButton; // 0x78
	[SerializeField]
	private ItemIcon rewardIconLabel; // 0x80
	[SerializeField]
	private GameObject playButtonObj; // 0x88
	[SerializeField]
	private GameObject[] starDiffObjs; // 0x90
	[SerializeField]
	private GameObject eventObj; // 0x98
	[SerializeField]
	private UILabel pageLabel; // 0xA0
	[SerializeField]
	private UILabel[] difficultyButtonLabels; // 0xA8
	[CompilerGenerated]
	private bool <IsOpenWindow>k__BackingField; // 0xB0
	private TweenPosition mainPanelTween; // 0xB8
	private TweenPosition frameUnderTween; // 0xC0
	private TweenHeight backPanelTween; // 0xC8
	private TweenHeight[] frameVirticalTween; // 0xD0
	private const float moveWaitTime = 0.2;
	private UILabel startButtonLabel; // 0xD8
	private RhythmGameState panelState; // 0xE0
	private UIRhythmGameSelectMusic.Difficulty selectDifficulty; // 0xE4
	private Action startAction; // 0xE8
	private int selectedIndex; // 0xF0
	private const int difficultyNum = 3;
	private bool isNoReady; // 0xF4
	private RhythmMusicData selectedMusicData; // 0xF8
	private SystemTextManager systemTextManager; // 0x100
	private PlayerDataManager playerDataManager; // 0x108
	private bool isCanSend; // 0x110
	private bool isOpenShortCut; // 0x111
	private bool isSettingPanel; // 0x112
	private RhythmGameManager manager; // 0x118

	// Properties
	public bool IsOpenWindow { get; set; }
	public RhythmGameState State { get; }
	public int MusicId { get; }
	public byte SelectDifficulty { get; }
	public bool IsCanSend { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x18BE124 Offset: 0x18BA124 VA: 0x18BE124
	public bool get_IsOpenWindow() { }

	[CompilerGenerated]
	// RVA: 0x18BE12C Offset: 0x18BA12C VA: 0x18BE12C
	private void set_IsOpenWindow(bool value) { }

	// RVA: 0x18BE138 Offset: 0x18BA138 VA: 0x18BE138
	public RhythmGameState get_State() { }

	// RVA: 0x18BE140 Offset: 0x18BA140 VA: 0x18BE140
	public int get_MusicId() { }

	// RVA: 0x18BE15C Offset: 0x18BA15C VA: 0x18BE15C
	public byte get_SelectDifficulty() { }

	// RVA: 0x18BE164 Offset: 0x18BA164 VA: 0x18BE164
	public bool get_IsCanSend() { }

	// RVA: 0x18BE16C Offset: 0x18BA16C VA: 0x18BE16C
	public void Initialize(Action startAction) { }

	// RVA: 0x18BEAE4 Offset: 0x18BAAE4 VA: 0x18BEAE4
	public void OpenSelectWindow() { }

	// RVA: 0x18BEBFC Offset: 0x18BABFC VA: 0x18BEBFC
	public void SetEnableStartButton(bool isNoReady) { }

	// RVA: 0x18BED04 Offset: 0x18BAD04 VA: 0x18BED04
	public void ChangeActivePlayButton(bool isActive) { }

	// RVA: 0x18BEED8 Offset: 0x18BAED8 VA: 0x18BEED8
	public void UpdatePanel(RhythmSettingData setting, bool isOpenShortCut, bool isSettingPanel) { }

	// RVA: 0x18BF40C Offset: 0x18BB40C VA: 0x18BF40C
	private void Start() { }

	// RVA: 0x18BF460 Offset: 0x18BB460 VA: 0x18BF460
	private void OnLeft() { }

	// RVA: 0x18BF500 Offset: 0x18BB500 VA: 0x18BF500
	private void OnRight() { }

	// RVA: 0x18BF5A4 Offset: 0x18BB5A4 VA: 0x18BF5A4
	private void OnDifficulty(int param) { }

	// RVA: 0x18BF688 Offset: 0x18BB688 VA: 0x18BF688
	private void OnStart() { }

	// RVA: 0x18BF040 Offset: 0x18BB040 VA: 0x18BF040
	private void OnPlay() { }

	[IteratorStateMachine(typeof(UIRhythmGameSelectMusic.<OpenWindowProc>d__62))]
	// RVA: 0x18BF730 Offset: 0x18BB730 VA: 0x18BF730
	private IEnumerator OpenWindowProc() { }

	// RVA: 0x18BF7C4 Offset: 0x18BB7C4 VA: 0x18BF7C4
	private void OpenWindow() { }

	// RVA: 0x18BF708 Offset: 0x18BB708 VA: 0x18BF708
	private void ForceOpenWindow() { }

	// RVA: 0x18BEAF0 Offset: 0x18BAAF0 VA: 0x18BEAF0
	private void CloseWindow() { }

	// RVA: 0x18BE7F0 Offset: 0x18BA7F0 VA: 0x18BE7F0
	private void SetTweenPos(TweenPosition tPos, float duration, Vector3 from, Vector3 to) { }

	// RVA: 0x18BE874 Offset: 0x18BA874 VA: 0x18BE874
	private void SetTweenHeight(TweenHeight tHeight, float duration, int from, int to) { }

	// RVA: 0x18BF190 Offset: 0x18BB190 VA: 0x18BF190
	private void ChangeDifficulty(UIRhythmGameSelectMusic.Difficulty diff) { }

	// RVA: 0x18BE8D0 Offset: 0x18BA8D0 VA: 0x18BE8D0
	private void SetEnableSelectButton(bool isEnable) { }

	// RVA: 0x18BE938 Offset: 0x18BA938 VA: 0x18BE938
	private void UpdateData() { }

	// RVA: 0x18BFBD8 Offset: 0x18BBBD8 VA: 0x18BFBD8
	private void UpdateTitleText() { }

	// RVA: 0x18BFCD0 Offset: 0x18BBCD0 VA: 0x18BFCD0
	private void UpdateBestScore() { }

	// RVA: 0x18BFE08 Offset: 0x18BBE08 VA: 0x18BFE08
	private void UpdateClearState() { }

	// RVA: 0x18C005C Offset: 0x18BC05C VA: 0x18C005C
	private string GetClearStateSpriteName(byte clearId) { }

	// RVA: 0x18BF930 Offset: 0x18BB930 VA: 0x18BF930
	private void UpdateRewardLabel() { }

	// RVA: 0x18BF890 Offset: 0x18BB890 VA: 0x18BF890
	private void UpdateStarDiffIcon() { }

	// RVA: 0x18BFA34 Offset: 0x18BBA34 VA: 0x18BFA34
	private void UpdateDifficulty() { }

	// RVA: 0x18BEDCC Offset: 0x18BADCC VA: 0x18BEDCC
	private bool CheckProgress() { }

	// RVA: 0x18C010C Offset: 0x18BC10C VA: 0x18C010C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x18C02A0 Offset: 0x18BC2A0 VA: 0x18C02A0
	private bool <UpdateBestScore>b__72_0(RhythmRecordData x) { }

	[CompilerGenerated]
	// RVA: 0x18C02CC Offset: 0x18BC2CC VA: 0x18C02CC
	private bool <UpdateClearState>b__73_0(RhythmRecordData x) { }
}
