// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIOrbShopDailyGameManager : UIBasePanel // TypeDefIndex: 2182
{
	// Fields
	[SerializeField]
	private Camera gameCamera; // 0x30
	[SerializeField]
	private GameObject startPopButton; // 0x38
	private UIIruna2Anchor startPopButtonAnchor; // 0x40
	[SerializeField]
	private GameObject tapPopButton; // 0x48
	private UIIruna2Anchor tapPopButtonAnchor; // 0x50
	[SerializeField]
	private Transform popWindowParent; // 0x58
	private UIPopBaseWindow popWindow; // 0x60
	private bool windowCancelCheck; // 0x68
	[SerializeField]
	private GameObject popWindowButton; // 0x70
	private UIButtonMessage popWindowButtonMessage; // 0x78
	[SerializeField]
	private UILabel popWindowButtonLabel; // 0x80
	private int hitId; // 0x88
	[SerializeField]
	private GameObject boardItemIcon; // 0x90
	[SerializeField]
	private Transform boardItemIconTrans; // 0x98
	[SerializeField]
	private GameObject[] screenBar; // 0xA0
	private UISprite[] screenBarSprite; // 0xA8
	private TweenAlpha[] screenBarAlpha; // 0xB0
	[SerializeField]
	private GameObject okButton; // 0xB8
	private UIIruna2Anchor okButtonAnchor; // 0xC0
	[SerializeField]
	private Transform dartsAnchor; // 0xC8
	[SerializeField]
	private Transform mobAnchor; // 0xD0
	private OrbShopDailyDartsGameManager manager; // 0xD8
	private int[] rewardBoardList; // 0xE0
	private GameObject[] boardObject; // 0xE8
	private Dictionary<int, TweenScale> hitItemIcon; // 0xF0
	private UIOrbShopDailyGameManager.ResultState resultItemCheck; // 0xF8
	private GameObject board; // 0x100
	private GameObject darts; // 0x108
	private GameObject dartsRoot; // 0x110
	private GameObject[] dartsCountObject; // 0x118
	private bool dartsMoveFlag; // 0x120
	private bool dartsInput; // 0x121
	private Vector2 dartsInputPos; // 0x124
	private Vector3 dartsMove; // 0x12C
	private float moveSpeed; // 0x138
	private float rotSpeed; // 0x13C
	private float subRot; // 0x140
	private Action mainProc; // 0x148
	private Vector3 initGravity; // 0x150
	private Vector3 initAccelerator; // 0x15C
	private float waitTimer; // 0x168
	private PlayerDataManager playerDataManager; // 0x170
	private GameObject mobModel; // 0x178
	private Animation mobAnimation; // 0x180
	private Transform mobShadow; // 0x188

	// Methods

	// RVA: 0x215519C Offset: 0x215119C VA: 0x215519C
	private void Awake() { }

	// RVA: 0x2155500 Offset: 0x2151500 VA: 0x2155500
	private void OnDestory() { }

	[IteratorStateMachine(typeof(UIOrbShopDailyGameManager.<Start>d__48))]
	// RVA: 0x2155538 Offset: 0x2151538 VA: 0x2155538
	private IEnumerator Start() { }

	[IteratorStateMachine(typeof(UIOrbShopDailyGameManager.<InitPopUp>d__49))]
	// RVA: 0x21555CC Offset: 0x21515CC VA: 0x21555CC
	private IEnumerator InitPopUp(string title, string message) { }

	// RVA: 0x2155690 Offset: 0x2151690 VA: 0x2155690
	private void Update() { }

	// RVA: 0x21558D8 Offset: 0x21518D8 VA: 0x21558D8
	private void LateUpdate() { }

	// RVA: 0x2155998 Offset: 0x2151998 VA: 0x2155998
	private void ThrowingAction() { }

	// RVA: 0x2155E08 Offset: 0x2151E08 VA: 0x2155E08
	private void MoveAction() { }

	// RVA: 0x215660C Offset: 0x215260C VA: 0x215660C
	private void EndAction() { }

	// RVA: 0x2156EE4 Offset: 0x2152EE4 VA: 0x2156EE4
	private void ResultWaitAction() { }

	// RVA: 0x2157088 Offset: 0x2153088 VA: 0x2157088
	private void OnTapGameStart() { }

	[IteratorStateMachine(typeof(UIOrbShopDailyGameManager.<TapGameStartWindow>d__57))]
	// RVA: 0x21570C4 Offset: 0x21530C4 VA: 0x21570C4
	private IEnumerator TapGameStartWindow() { }

	// RVA: 0x2157158 Offset: 0x2153158 VA: 0x2157158
	private void ResultDartsReset() { }

	// RVA: 0x2156A6C Offset: 0x2152A6C VA: 0x2156A6C
	private void OnResultSelect() { }

	// RVA: 0x2157894 Offset: 0x2153894 VA: 0x2157894
	private void OnResultReward() { }

	// RVA: 0x2157BA4 Offset: 0x2153BA4 VA: 0x2157BA4
	private void OnResultNextCheck() { }

	// RVA: 0x2157FAC Offset: 0x2153FAC VA: 0x2157FAC
	private void OnResultNextTry() { }

	// RVA: 0x2158200 Offset: 0x2154200 VA: 0x2158200
	private void onFinishRewardEffect() { }

	// RVA: 0x21573A0 Offset: 0x21533A0 VA: 0x21573A0
	private string getRewardName(OrbShopDailyDartsGameManager.RewardPanelData data) { }

	// RVA: 0x21584DC Offset: 0x21544DC VA: 0x21584DC
	private void OnPress(bool pressed) { }

	// RVA: 0x21585B8 Offset: 0x21545B8 VA: 0x21585B8
	public void OnClick_EndGame() { }

	// RVA: 0x2158644 Offset: 0x2154644 VA: 0x2158644 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x215873C Offset: 0x215473C VA: 0x215873C Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x2158860 Offset: 0x2154860 VA: 0x2158860
	public void .ctor() { }
}
