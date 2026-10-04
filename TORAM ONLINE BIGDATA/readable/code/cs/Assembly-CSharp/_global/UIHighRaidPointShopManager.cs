// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIHighRaidPointShopManager : UIBasePanel // TypeDefIndex: 5822
{
	// Fields
	[SerializeField]
	private GameObject titleObj; // 0x30
	[SerializeField]
	private UILabel titleLabel; // 0x38
	[SerializeField]
	private GameObject[] panelObjs; // 0x40
	[SerializeField]
	private GameObject[] mainMenuButtons; // 0x48
	[SerializeField]
	private GameObject[] receiveLabelObjs; // 0x50
	[SerializeField]
	private UIScrollWindow selectScrollWindow; // 0x58
	[SerializeField]
	private GameObject elementObj; // 0x60
	[SerializeField]
	private GameObject noListLabel; // 0x68
	[SerializeField]
	private UIHIghRaidPointShopElement pointShopElement; // 0x70
	[SerializeField]
	private UIScrollWindow scrollListWindow; // 0x78
	[CompilerGenerated]
	private bool <IsClose>k__BackingField; // 0x80
	private UIHighRaidPointShopManager.PanelState panelState; // 0x84
	private UIHighRaidPointShopManager.PanelState prevPanelState; // 0x88
	private PlayerDataManager playerDataManager; // 0x90
	private EnemyTextManager enemyTextManager; // 0x98
	private List<byte> highRaidExchangeList; // 0xA0
	private byte selectHighRaidNo; // 0xA8
	private UIPopBaseWindow popWindow; // 0xB0
	private bool isPopWindow; // 0xB8
	private Coroutine rewardCoroutine; // 0xC0
	private HighRaidEventData eventData; // 0xC8

	// Properties
	public bool IsClose { get; set; }
	private HighRaidEventData highRaidEventData { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x17F96C4 Offset: 0x17F56C4 VA: 0x17F96C4
	public bool get_IsClose() { }

	[CompilerGenerated]
	// RVA: 0x17F96CC Offset: 0x17F56CC VA: 0x17F96CC
	private void set_IsClose(bool value) { }

	// RVA: 0x17F96D8 Offset: 0x17F56D8 VA: 0x17F96D8
	private HighRaidEventData get_highRaidEventData() { }

	// RVA: 0x17F9744 Offset: 0x17F5744 VA: 0x17F9744
	private void Awake() { }

	// RVA: 0x17F995C Offset: 0x17F595C VA: 0x17F995C
	public void OpenMainMenu() { }

	// RVA: 0x17F9AEC Offset: 0x17F5AEC VA: 0x17F9AEC
	public void OpenShopList() { }

	// RVA: 0x17F9B78 Offset: 0x17F5B78 VA: 0x17F9B78
	public void OpenShopList(byte no) { }

	// RVA: 0x17F9BE8 Offset: 0x17F5BE8 VA: 0x17F9BE8
	public void OnNowButton() { }

	// RVA: 0x17F9C1C Offset: 0x17F5C1C VA: 0x17F9C1C
	public void OnBeforeButton() { }

	// RVA: 0x17F9C50 Offset: 0x17F5C50 VA: 0x17F9C50
	public void OnSelectBoss(int param) { }

	// RVA: 0x17F9DB4 Offset: 0x17F5DB4 VA: 0x17F9DB4
	public void OnSelectReward(int param) { }

	// RVA: 0x17F9E50 Offset: 0x17F5E50 VA: 0x17F9E50
	public void ResultWindow(RewardResponseDatav2 reward) { }

	// RVA: 0x17F9964 Offset: 0x17F5964 VA: 0x17F9964
	private void ChangePanelState(UIHighRaidPointShopManager.PanelState panelState) { }

	[IteratorStateMachine(typeof(UIHighRaidPointShopManager.<OpenNowList>d__40))]
	// RVA: 0x17F9B0C Offset: 0x17F5B0C VA: 0x17F9B0C
	private IEnumerator OpenNowList() { }

	[IteratorStateMachine(typeof(UIHighRaidPointShopManager.<GetHighRaidExchangeHeld>d__41))]
	// RVA: 0x17F9F08 Offset: 0x17F5F08 VA: 0x17F9F08
	private IEnumerator GetHighRaidExchangeHeld() { }

	[IteratorStateMachine(typeof(UIHighRaidPointShopManager.<GetTrophys>d__42))]
	// RVA: 0x17FB070 Offset: 0x17F7070 VA: 0x17FB070
	private IEnumerator GetTrophys(List<byte> list) { }

	[IteratorStateMachine(typeof(UIHighRaidPointShopManager.<ChangePanelSelect>d__43))]
	// RVA: 0x17FB120 Offset: 0x17F7120 VA: 0x17FB120
	private IEnumerator ChangePanelSelect() { }

	// RVA: 0x17F9F74 Offset: 0x17F5F74 VA: 0x17F9F74
	private void UpdateBossListScrollWindow(bool isOld) { }

	// RVA: 0x17FA700 Offset: 0x17F6700 VA: 0x17FA700
	private void UpdateList() { }

	[IteratorStateMachine(typeof(UIHighRaidPointShopManager.<UpdateTrophyData>d__46))]
	// RVA: 0x17F9D48 Offset: 0x17F5D48 VA: 0x17F9D48
	private IEnumerator UpdateTrophyData() { }

	[IteratorStateMachine(typeof(UIHighRaidPointShopManager.<GetTrophys>d__47))]
	// RVA: 0x17FB2E8 Offset: 0x17F72E8 VA: 0x17FB2E8
	private IEnumerator GetTrophys(byte no, bool isLoadingBar) { }

	[IteratorStateMachine(typeof(UIHighRaidPointShopManager.<GetTrophyReward>d__48))]
	// RVA: 0x17F9DD4 Offset: 0x17F5DD4 VA: 0x17F9DD4
	private IEnumerator GetTrophyReward(byte trophyId) { }

	[IteratorStateMachine(typeof(UIHighRaidPointShopManager.<OpenResultWindow>d__49))]
	// RVA: 0x17F9E80 Offset: 0x17F5E80 VA: 0x17F9E80
	private IEnumerator OpenResultWindow(RewardResponseDatav2 reward) { }

	// RVA: 0x17FB3E8 Offset: 0x17F73E8 VA: 0x17FB3E8
	private void EndRewardWindow() { }

	// RVA: 0x17FB1B4 Offset: 0x17F71B4 VA: 0x17FB1B4
	private List<byte> GetExchangeList(bool isOld) { }

	// RVA: 0x17FB46C Offset: 0x17F746C VA: 0x17FB46C Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x17FB560 Offset: 0x17F7560 VA: 0x17FB560 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x17FB5C8 Offset: 0x17F75C8 VA: 0x17FB5C8
	public void .ctor() { }
}
