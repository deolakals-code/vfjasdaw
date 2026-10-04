// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIScoreAttackRewardsManager : MonoBehaviour // TypeDefIndex: 6280
{
	// Fields
	[SerializeField]
	private GameObject window; // 0x20
	[SerializeField]
	private GameObject titleWindow; // 0x28
	[SerializeField]
	private UIScrollWindow scrollWindow; // 0x30
	[SerializeField]
	private UIScoreAttackRewardsContent rewardContent; // 0x38
	[SerializeField]
	private GameObject bulkReceiveObj; // 0x40
	[SerializeField]
	private UIImageButton bulkReveiveButton; // 0x48
	[SerializeField]
	private UILabel bulkReceiveLabel; // 0x50
	[SerializeField]
	private GameObject popupMessageObj; // 0x58
	[SerializeField]
	private UILabel popupTitleLabel; // 0x60
	[SerializeField]
	private UILabel popupMessageLabel; // 0x68
	[SerializeField]
	private GameObject receiveRewardButton; // 0x70
	private ScoreAttackRoomData roomData; // 0x78
	private SystemTextManager sys; // 0x80
	private UIScoreAttackRewardsManager.ScreenState screenState; // 0x88
	private UIScoreAttackRewardsContent[] scrollButtons; // 0x90
	private const float rewardContentBasePos = -80;
	private const float rewardContentHeight = 147;
	private Action popupWindowCallBack; // 0x98
	private EffectPlayer effectPlayer; // 0xA0
	private GameObject rewardObject; // 0xA8
	private bool isBulkReceivable; // 0xB0
	private int totalAllReceiveRewardCount; // 0xB4
	private readonly int[] rewardCount; // 0xB8

	// Properties
	public bool IsRewardActive { get; }
	public bool IsPopupWindow { get; }
	public bool IsReceiveReward { get; }

	// Methods

	// RVA: 0x18CF3C8 Offset: 0x18CB3C8 VA: 0x18CF3C8
	public bool get_IsRewardActive() { }

	// RVA: 0x18CF3E4 Offset: 0x18CB3E4 VA: 0x18CF3E4
	public bool get_IsPopupWindow() { }

	// RVA: 0x18CF474 Offset: 0x18CB474 VA: 0x18CF474
	public bool get_IsReceiveReward() { }

	// RVA: 0x18D7AF0 Offset: 0x18D3AF0 VA: 0x18D7AF0
	private void Update() { }

	// RVA: 0x18CD300 Offset: 0x18C9300 VA: 0x18CD300
	public void Initialize(ScoreAttackRoomData roomData, Action rewardConfCallBack) { }

	// RVA: 0x18D7DB0 Offset: 0x18D3DB0 VA: 0x18D7DB0
	public void OnClickAllReceive() { }

	// RVA: 0x18D8060 Offset: 0x18D4060 VA: 0x18D8060
	public void OnClickReceiveRewardCompleate() { }

	// RVA: 0x18CD2E0 Offset: 0x18C92E0 VA: 0x18CD2E0
	public void ChangeWindowActive(bool active) { }

	// RVA: 0x18CF3F4 Offset: 0x18CB3F4 VA: 0x18CF3F4
	public void ClosePopUpWindow() { }

	// RVA: 0x18CF484 Offset: 0x18CB484 VA: 0x18CF484
	public void ReceiveRewardCompleate() { }

	// RVA: 0x18D7BDC Offset: 0x18D3BDC VA: 0x18D7BDC
	private void ChangePanel(UIScoreAttackRewardsManager.ScreenState state) { }

	// RVA: 0x18D80C4 Offset: 0x18D40C4 VA: 0x18D80C4
	private void InitializeRewardList() { }

	// RVA: 0x18D8938 Offset: 0x18D4938 VA: 0x18D8938
	private int GetRotationSortKey(int rotationId, int currentRotationId) { }

	// RVA: 0x18D8968 Offset: 0x18D4968 VA: 0x18D8968
	private void ReceiveReward(int rewardIndex) { }

	[IteratorStateMachine(typeof(UIScoreAttackRewardsManager.<AllReceiveReward>d__43))]
	// RVA: 0x18D7FF4 Offset: 0x18D3FF4 VA: 0x18D7FF4
	private IEnumerator AllReceiveReward() { }

	// RVA: 0x18D8C2C Offset: 0x18D4C2C VA: 0x18D8C2C
	private void GetEffectPlayer() { }

	// RVA: 0x18D7E58 Offset: 0x18D3E58 VA: 0x18D7E58
	private void ChangeBulkReceiveButton() { }

	// RVA: 0x18D7C98 Offset: 0x18D3C98 VA: 0x18D7C98
	private void PopUpWindow(UIScoreAttackRewardsManager.PopUpType popUpType) { }

	// RVA: 0x18D8D1C Offset: 0x18D4D1C VA: 0x18D8D1C
	private void PopUpWindow(string titleKey, string messageKey) { }

	// RVA: 0x18D8D98 Offset: 0x18D4D98 VA: 0x18D8D98
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x18D8E38 Offset: 0x18D4E38 VA: 0x18D8E38
	private int <InitializeRewardList>b__40_4(IGrouping<byte, <>f__AnonymousType0<ScoreAttackRewardData, int>> g) { }
}
