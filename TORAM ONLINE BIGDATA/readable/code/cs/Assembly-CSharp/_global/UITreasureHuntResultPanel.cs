// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UITreasureHuntResultPanel : UIBasePanel // TypeDefIndex: 6371
{
	// Fields
	[SerializeField]
	private GameObject resultPanel; // 0x30
	[SerializeField]
	private GameObject boxOpenPanel; // 0x38
	[SerializeField]
	private GameObject rewardPanel; // 0x40
	[SerializeField]
	private GameObject succesIconObject; // 0x48
	[SerializeField]
	private GameObject iconBack; // 0x50
	[SerializeField]
	private UILabel[] resultLabel; // 0x58
	[SerializeField]
	private GameObject acquisitionDataPrent; // 0x60
	[SerializeField]
	private UILabel[] acquisitionNumLabels; // 0x68
	[SerializeField]
	private GameObject bonusLabelObject; // 0x70
	[SerializeField]
	private UILabel acquiredBoxItemTextLabel; // 0x78
	[SerializeField]
	private UILabel bonusItemTextLabel; // 0x80
	[SerializeField]
	private UISprite bonusItemTextLabelLine; // 0x88
	[SerializeField]
	private UIScrollWindow bonusWindow; // 0x90
	[SerializeField]
	private GashaponEffectPlayer effectPlayer; // 0x98
	[SerializeField]
	private GameObject boxItemsPopWindow; // 0xA0
	[SerializeField]
	private UIScrollWindow boxItemsScrollWindow; // 0xA8
	[SerializeField]
	private GameObject boxItemsPopWindowLabelObj; // 0xB0
	[SerializeField]
	private UIImageButton boxItemsWindowButton; // 0xB8
	[SerializeField]
	private GameObject rewardElement; // 0xC0
	[SerializeField]
	private UIScrollWindow rewardWindow; // 0xC8
	[SerializeField]
	private UILabel resultWindowTitleLabel; // 0xD0
	[SerializeField]
	private UISprite resultWindowTitleIcon; // 0xD8
	[SerializeField]
	private GameObject[] rewardPanelWindow; // 0xE0
	[SerializeField]
	private GameObject testRewardElement; // 0xE8
	private static readonly float RewardElementHeihgt; // 0x0
	private static readonly int BoxItemsPopwindowMax; // 0x4
	private static readonly Vector3 BoxItemsLabelBasePosition; // 0x8
	private PlayerDataManager playerDataManager; // 0xF0
	private ItemTextManager itemTextManager; // 0xF8
	private bool isSucces; // 0x100
	private TreasureHuntGameEndEvent resultData; // 0x108
	private TreasureHuntTestGameEndEvent testResultData; // 0x110
	private TreasureHuntRoomData roomData; // 0x118
	private UILabel boxItemsWindowButtonLabel; // 0x120
	private bool isBoxItemWindowButtonOnClick; // 0x128
	private UnityAction closeCallback; // 0x130
	private RegistletManager registletManager; // 0x138
	private RegistletTextManager registletTextManager; // 0x140
	[CompilerGenerated]
	private bool <IsClose>k__BackingField; // 0x148

	// Properties
	public bool IsClose { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1910870 Offset: 0x190C870 VA: 0x1910870
	public bool get_IsClose() { }

	[CompilerGenerated]
	// RVA: 0x1910878 Offset: 0x190C878 VA: 0x1910878
	private void set_IsClose(bool value) { }

	// RVA: 0x1910884 Offset: 0x190C884 VA: 0x1910884
	public void Update() { }

	// RVA: 0x191096C Offset: 0x190C96C VA: 0x191096C
	public void Initialize(UnityAction callback) { }

	// RVA: 0x1910E4C Offset: 0x190CE4C VA: 0x1910E4C
	private void SetSuccessAndFailureLabel() { }

	// RVA: 0x1910CB0 Offset: 0x190CCB0 VA: 0x1910CB0
	private void RetireResult() { }

	// RVA: 0x1911004 Offset: 0x190D004 VA: 0x1911004
	private void SetAcquiredTreasureLabels() { }

	// RVA: 0x19111D4 Offset: 0x190D1D4 VA: 0x19111D4
	private void SetResultBonus() { }

	// RVA: 0x19116EC Offset: 0x190D6EC VA: 0x19116EC
	private string GetBonusText(int index) { }

	// RVA: 0x19117B4 Offset: 0x190D7B4 VA: 0x19117B4
	private void BoxOpenPanelInitialize() { }

	[IteratorStateMachine(typeof(UITreasureHuntResultPanel.<OpenTreasureBox>d__50))]
	// RVA: 0x1911B08 Offset: 0x190DB08 VA: 0x1911B08
	private IEnumerator OpenTreasureBox() { }

	// RVA: 0x1911B9C Offset: 0x190DB9C VA: 0x1911B9C
	private void SetRewardLabel(RewardData rewardData, UIQuestRewardList popLabel) { }

	// RVA: 0x1912374 Offset: 0x190E374 VA: 0x1912374
	private void SetRewardLabel(int point, UIQuestRewardList popLabel) { }

	// RVA: 0x1912390 Offset: 0x190E390 VA: 0x1912390
	private void OnBoxWindowButton() { }

	[IteratorStateMachine(typeof(UITreasureHuntResultPanel.<OpenTreasureBoxTest>d__54))]
	// RVA: 0x1911A9C Offset: 0x190DA9C VA: 0x1911A9C
	private IEnumerator OpenTreasureBoxTest() { }

	// RVA: 0x19123C4 Offset: 0x190E3C4 VA: 0x19123C4
	private Color GetBoxIconColor(int rank) { }

	// RVA: 0x1912408 Offset: 0x190E408 VA: 0x1912408
	private void RewardPanelInitialize() { }

	// RVA: 0x19129B0 Offset: 0x190E9B0 VA: 0x19129B0
	private void TestRewardPanelInitialize() { }

	// RVA: 0x1912B00 Offset: 0x190EB00 VA: 0x1912B00
	private UITreasureHuntRewardElement AddRewardElement(float y) { }

	// RVA: 0x1912E78 Offset: 0x190EE78 VA: 0x1912E78
	private void OnResultButton() { }

	// RVA: 0x1911A78 Offset: 0x190DA78 VA: 0x1911A78
	private void OnCloseButton() { }

	[IteratorStateMachine(typeof(UITreasureHuntResultPanel.<InitPanel>d__61))]
	// RVA: 0x1910DE0 Offset: 0x190CDE0 VA: 0x1910DE0
	private IEnumerator InitPanel() { }

	// RVA: 0x1912FA4 Offset: 0x190EFA4 VA: 0x1912FA4 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1913040 Offset: 0x190F040 VA: 0x1913040 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x19130DC Offset: 0x190F0DC VA: 0x19130DC
	public void .ctor() { }

	// RVA: 0x19130E4 Offset: 0x190F0E4 VA: 0x19130E4
	private static void .cctor() { }
}
