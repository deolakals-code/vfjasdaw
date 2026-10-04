// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIRhythmGameResultManager : UIBasePanel // TypeDefIndex: 6216
{
	// Fields
	[SerializeField]
	private Transform centerPanelTrans; // 0x30
	[SerializeField]
	private UISprite basePanel; // 0x38
	[SerializeField]
	private GameObject titleObj; // 0x40
	[SerializeField]
	private UILabel titleLabel; // 0x48
	[SerializeField]
	private GameObject[] titleIcons; // 0x50
	[SerializeField]
	private UIRhythmGameResultElement elementObj; // 0x58
	[SerializeField]
	private ItemIcon rewardItemIcon; // 0x60
	[SerializeField]
	private UIIruna2Anchor bottomAnchor; // 0x68
	[SerializeField]
	private UILabel waitLabel; // 0x70
	private TweenPosition titleObjTween; // 0x78
	private TweenPosition basePanelTweenPos; // 0x80
	private TweenHeight basePanelTweenHeight; // 0x88
	private readonly Dictionary<int, Vector3[]> rankPosList; // 0x90
	private bool isSuccess; // 0x98
	private RhythmMemberScoreData[] scoreDatas; // 0xA0
	private RewardResponseDatav2 rewardData; // 0xA8
	private bool isResultEnd; // 0xB0
	private bool isCanReturn; // 0xB1
	private float canScreenTapTimer; // 0xB4
	private const float canScreenTapTime = 1;

	// Methods

	// RVA: 0x18BADAC Offset: 0x18B6DAC VA: 0x18BADAC
	public void Initialize(bool isSuccess, RhythmMemberScoreData[] datas, RewardResponseDatav2 reward) { }

	// RVA: 0x18BB2BC Offset: 0x18B72BC VA: 0x18BB2BC
	private void Update() { }

	[IteratorStateMachine(typeof(UIRhythmGameResultManager.<OpenPanel>d__23))]
	// RVA: 0x18BB250 Offset: 0x18B7250 VA: 0x18BB250
	private IEnumerator OpenPanel() { }

	// RVA: 0x18BB52C Offset: 0x18B752C VA: 0x18BB52C
	private void SetTweenPos(TweenPosition tPos, float duration, Vector3 from, Vector3 to) { }

	// RVA: 0x18BB5B0 Offset: 0x18B75B0 VA: 0x18BB5B0
	private void SetTweenHeight(TweenHeight tHeight, float duration, int from, int to) { }

	// RVA: 0x18BB60C Offset: 0x18B760C VA: 0x18BB60C
	private void CreateElement(Vector3 pos, int rank, string name, int score, int critical, int hit, int graze) { }

	// RVA: 0x18BB7D0 Offset: 0x18B77D0 VA: 0x18BB7D0
	private float GetRankWaitTime(int memberNum, int rank) { }

	// RVA: 0x18BB45C Offset: 0x18B745C VA: 0x18BB45C
	private void ResultEnd() { }

	[IteratorStateMachine(typeof(UIRhythmGameResultManager.<ResultEndWait>d__29))]
	// RVA: 0x18BB7E8 Offset: 0x18B77E8 VA: 0x18BB7E8
	private IEnumerator ResultEndWait() { }

	// RVA: 0x18BB868 Offset: 0x18B7868 VA: 0x18BB868 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x18BB8E0 Offset: 0x18B78E0 VA: 0x18BB8E0 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x18BB958 Offset: 0x18B7958 VA: 0x18BB958
	public void .ctor() { }
}
