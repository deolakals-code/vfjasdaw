// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMahjongResultManager : MonoBehaviour // TypeDefIndex: 5933
{
	// Fields
	[SerializeField]
	private Transform mainPanel; // 0x20
	[SerializeField]
	private UISprite screenMask; // 0x28
	[SerializeField]
	private GameObject[] panels; // 0x30
	[SerializeField]
	private UILabel buttonWaitTimeLabel; // 0x38
	[SerializeField]
	private UIButtonCallAction nextWindowButton; // 0x40
	[SerializeField]
	private UISprite backGround; // 0x48
	[SerializeField]
	private UILabel winPlayerNameLabel; // 0x50
	[SerializeField]
	private UIMahjongTileController handTileContent; // 0x58
	[SerializeField]
	private UIMahjongTileController doraTileContent; // 0x60
	[SerializeField]
	private UIMahjongTileController uraDoraTileContent; // 0x68
	[SerializeField]
	private GameObject harvestDanceDoraObj; // 0x70
	[SerializeField]
	private UIMahjongTileController harvestDanceDoraTileContent; // 0x78
	[SerializeField]
	private UILabel hanLabel; // 0x80
	[SerializeField]
	private GameObject hanTextLabel; // 0x88
	[SerializeField]
	private UILabel fuLabel; // 0x90
	[SerializeField]
	private UILabel scoreLabel; // 0x98
	[SerializeField]
	private UIMahjongResultYakuContentManager yakuContent; // 0xA0
	[SerializeField]
	private GameObject scoreTitle; // 0xA8
	[SerializeField]
	private UILabel scoreTitleLabel; // 0xB0
	[SerializeField]
	private UILabel riichiCountLabel; // 0xB8
	[SerializeField]
	private UILabel honbaCountLabel; // 0xC0
	[SerializeField]
	private TweenAlpha[] normalResultScoreTweenAlphas; // 0xC8
	[SerializeField]
	private TweenPosition[] normalResultScoreTweenPos; // 0xD0
	[SerializeField]
	private TweenAlpha normalResultScoreTitleTweenAlphas; // 0xD8
	[SerializeField]
	private TweenScale normalResultScoreTitleTweenScale; // 0xE0
	[SerializeField]
	private GameObject waremeIcon; // 0xE8
	[SerializeField]
	private GameObject psiIcon; // 0xF0
	[SerializeField]
	private UILabel psiNameLabel; // 0xF8
	[SerializeField]
	private UIMahjongResultPlayerScoreManager playerScore; // 0x100
	[SerializeField]
	private Vector2[] playerScorePos; // 0x108
	[SerializeField]
	private GameObject centerArrow; // 0x110
	[SerializeField]
	private UISprite centerArrowSprite; // 0x118
	[SerializeField]
	private GameObject scoreArrow; // 0x120
	[SerializeField]
	private Vector2[] scoreArrowPos; // 0x128
	[SerializeField]
	private UILabel honbaLabel; // 0x130
	[SerializeField]
	private AnimationCurve scoreArrowAnimCurve; // 0x138
	[SerializeField]
	private GameObject centerWaremeIcon; // 0x140
	[SerializeField]
	private UILabel normalDrawLabel; // 0x148
	[SerializeField]
	private UIMahjongWinningTileList[] tenpaiWindows; // 0x150
	[SerializeField]
	private UIMahjongResultScoreRankingManager resultScoreRankingManagerContent; // 0x158
	[SerializeField]
	private Transform resultScoreRankingParentTransform; // 0x160
	private MahjongRoomData roomData; // 0x168
	private SystemTextManager sys; // 0x170
	private UIMahjongResultManager.PanelState panelState; // 0x178
	private MahjongPlayerRoundResultData[] resultList; // 0x180
	private MahjongTileData[] uraDoraList; // 0x188
	private float waitTime; // 0x190
	private const float maxWaitTime = 10;
	private List<UIMahjongTileController> resultHands; // 0x198
	private UIMahjongTileController[] doraTiles; // 0x1A0
	private UIMahjongTileController[] uraDoraTiles; // 0x1A8
	private List<UIMahjongResultYakuContentManager> yakuContentList; // 0x1B0
	private List<int> displayResultUserArchetypeIds; // 0x1B8
	private int displayResultUserIndex; // 0x1C0
	private readonly int yakuContentMaxNum; // 0x1C4
	private readonly float yakuContentSpacingHeight; // 0x1C8
	private readonly float yakuContentSpacingWidht; // 0x1CC
	private Coroutine normalResultAnimCoroutine; // 0x1D0
	private UIMahjongResultPlayerScoreManager[] playerScoreContents; // 0x1D8
	private GameObject[] scoreArrows; // 0x1E0
	private UISprite[] scoreArrowBases; // 0x1E8
	private Dictionary<GameObject, GameObject> waremeIcons; // 0x1F0
	private MahjongWindType playerFirstWindType; // 0x1F8
	private float scoreArrowAnimTime; // 0x1FC
	private const float scoreArrowAnimMaxPosX = 40;
	private UIMahjongResultScoreRankingManager[] resultScoreRankingManagers; // 0x200
	private int[] umaValues; // 0x208
	private int[] umaValuesThree; // 0x210
	private int defalutScore; // 0x218
	private int defalutScoreThree; // 0x21C
	private bool isGameFinished; // 0x220
	private MahjongEndRoundType endRoundType; // 0x224
	private const byte ResultTileInstanceSpace = 59;
	private const byte ResultCallTileInstanceSpace = 71;
	private const byte DoraCount = 5;
	private const byte DoraTileInstanceSpace = 51;

	// Properties
	public bool isEndResult { get; }
	public bool IsResultActive { get; }

	// Methods

	// RVA: 0x183D7E4 Offset: 0x18397E4 VA: 0x183D7E4
	public bool get_isEndResult() { }

	// RVA: 0x183D7F4 Offset: 0x18397F4 VA: 0x183D7F4
	public bool get_IsResultActive() { }

	// RVA: 0x1844B84 Offset: 0x1840B84 VA: 0x1844B84
	private void Update() { }

	// RVA: 0x1844F28 Offset: 0x1840F28 VA: 0x1844F28
	private void OnDestroy() { }

	// RVA: 0x183FDEC Offset: 0x183BDEC VA: 0x183FDEC
	public void SetResultDatas(MahjongRoomData roomData, MahjongEndRoundType endType, MahjongPlayerRoundResultData[] resultList, MahjongTileData[] uraDoraList) { }

	// RVA: 0x183FDB8 Offset: 0x183BDB8 VA: 0x183FDB8
	public void ResetResultDatas() { }

	// RVA: 0x183FE48 Offset: 0x183BE48 VA: 0x183FE48
	public void Initialize() { }

	// RVA: 0x1845578 Offset: 0x1841578 VA: 0x1845578
	private void ChangeScreen(UIMahjongResultManager.PanelState state) { }

	// RVA: 0x184576C Offset: 0x184176C VA: 0x184576C
	private void NormalResult() { }

	[IteratorStateMachine(typeof(UIMahjongResultManager.<DisplayYakuContent>d__88))]
	// RVA: 0x184A7A4 Offset: 0x18467A4 VA: 0x184A7A4
	private IEnumerator DisplayYakuContent(int yakuCount, bool isYakuman, MahjongWindType windType, int archetypeId, MahjongVoiceType scoreTitleVoiceType) { }

	// RVA: 0x1847EB4 Offset: 0x1843EB4 VA: 0x1847EB4
	private void ScoreResult() { }

	// RVA: 0x184A858 Offset: 0x1846858 VA: 0x184A858
	private void ScoreResultToThree(MahjongMemberData[] memberDatas) { }

	[IteratorStateMachine(typeof(UIMahjongResultManager.<PlayScoreChangeSE>d__91))]
	// RVA: 0x184B4E4 Offset: 0x18474E4 VA: 0x184B4E4
	private IEnumerator PlayScoreChangeSE() { }

	// RVA: 0x184B44C Offset: 0x184744C VA: 0x184B44C
	private void ChangeWaremeIcons(GameObject activeArrowObj) { }

	// RVA: 0x184979C Offset: 0x184579C VA: 0x184979C
	private void NormalDraw() { }

	// RVA: 0x1849E80 Offset: 0x1845E80 VA: 0x1849E80
	private void GameEnd() { }

	// RVA: 0x184B414 Offset: 0x1847414 VA: 0x184B414
	private void ActiveNextWindowButton() { }

	// RVA: 0x184A728 Offset: 0x1846728 VA: 0x184A728
	private void ResultComplete() { }

	// RVA: 0x1844E48 Offset: 0x1840E48 VA: 0x1844E48
	public void ChangeNextWindow() { }

	// RVA: 0x184B560 Offset: 0x1847560 VA: 0x184B560
	public void ChangeFinishedFlag(bool flag) { }

	// RVA: 0x184B56C Offset: 0x184756C VA: 0x184B56C
	public void ResetResultObjects() { }

	// RVA: 0x184B8D0 Offset: 0x18478D0 VA: 0x184B8D0
	public void UpdatePlayerFirstWindType(MahjongWindType windType) { }

	// RVA: 0x184B558 Offset: 0x1847558 VA: 0x184B558
	public void ResetPlayerFirstWindType() { }

	// RVA: 0x184B8E4 Offset: 0x18478E4 VA: 0x184B8E4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x184B9DC Offset: 0x18479DC VA: 0x184B9DC
	private bool <ScoreResult>b__89_6(MahjongClientRoundData.PlayerData x) { }

	[CompilerGenerated]
	// RVA: 0x184BA10 Offset: 0x1847A10 VA: 0x184BA10
	private bool <PlayScoreChangeSE>b__91_1() { }
}
