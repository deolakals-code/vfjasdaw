// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGuildRecruitSearch : UIBasePanelConnection // TypeDefIndex: 7176
{
	// Fields
	[SerializeField]
	private GameObject popUpErrorTitle; // 0x30
	[SerializeField]
	private GameObject popUpErrorMessage; // 0x38
	[SerializeField]
	private UILabel popUpErrorConditionLabel; // 0x40
	[SerializeField]
	private GameObject JoinRequestTitle; // 0x48
	[SerializeField]
	private GameObject JoinRequestMessage; // 0x50
	[SerializeField]
	private UILabel JoinRequestMessageLabel; // 0x58
	[SerializeField]
	private UILabel JoinRequestGuildName; // 0x60
	[SerializeField]
	private UILabel JoinRequestGuildMasterName; // 0x68
	[SerializeField]
	private GameObject JoinRequestJoinManualMessage; // 0x70
	[SerializeField]
	private GameObject recruitTitle; // 0x78
	[SerializeField]
	private UIImageButton prevButton; // 0x80
	[SerializeField]
	private UIImageButton nextButton; // 0x88
	[SerializeField]
	private GameObject searchWindow; // 0x90
	[SerializeField]
	private UISelectButton selectJoinType; // 0x98
	[SerializeField]
	private UISelectButton selectConditionType; // 0xA0
	[SerializeField]
	private UISelectButton selectSearchType; // 0xA8
	[SerializeField]
	private UIInput inputSearchText; // 0xB0
	[SerializeField]
	private UIImageButton searchButton; // 0xB8
	[SerializeField]
	private UILabel searchButtonLabel; // 0xC0
	[SerializeField]
	private GameObject recruitDataPlate; // 0xC8
	[SerializeField]
	private GameObject scrollWindow; // 0xD0
	[SerializeField]
	private GameObject noDataLabel; // 0xD8
	private int CurrentPage; // 0xE0
	private UIScrollWindow uIScrollWindow; // 0xE8
	private List<GuildBBSSendData> guildBBSSendDatas; // 0xF0
	private string[] missionList; // 0xF8
	private MissionTextManager missionTextManager; // 0x100
	private UIGuildRecruitSearch.STATE state; // 0x108
	private bool IsEndData; // 0x10C
	private bool isWaitSearchButton; // 0x10D
	private static DateTime searchTime; // 0x0
	private const int WAIT_RESEARCH_TIME = 5;
	private int accountLevel; // 0x110
	private int playTime; // 0x114
	private int missionProgress; // 0x118

	// Properties
	private byte JoinType { get; }
	private byte ConditionType { get; }
	private byte SearchType { get; }
	private string SearchText { get; }
	private byte NextList { get; }

	// Methods

	// RVA: 0x1AB18EC Offset: 0x1AAD8EC VA: 0x1AB18EC
	private byte get_JoinType() { }

	// RVA: 0x1AB1908 Offset: 0x1AAD908 VA: 0x1AB1908
	private byte get_ConditionType() { }

	// RVA: 0x1AB1924 Offset: 0x1AAD924 VA: 0x1AB1924
	private byte get_SearchType() { }

	// RVA: 0x1AB1940 Offset: 0x1AAD940 VA: 0x1AB1940
	private string get_SearchText() { }

	// RVA: 0x1AB195C Offset: 0x1AAD95C VA: 0x1AB195C
	private byte get_NextList() { }

	// RVA: 0x1AB19BC Offset: 0x1AAD9BC VA: 0x1AB19BC
	private void Awake() { }

	[IteratorStateMachine(typeof(UIGuildRecruitSearch.<Start>d__52))]
	// RVA: 0x1AB1C48 Offset: 0x1AADC48 VA: 0x1AB1C48
	private IEnumerator Start() { }

	// RVA: 0x1AB1CDC Offset: 0x1AADCDC VA: 0x1AB1CDC
	private void OnSearchTypeChanged() { }

	// RVA: 0x1AB1DE8 Offset: 0x1AADDE8 VA: 0x1AB1DE8
	private bool CheckCondition() { }

	// RVA: 0x1AB2020 Offset: 0x1AAE020 VA: 0x1AB2020
	private void PopErrorCondition() { }

	// RVA: 0x1AB2170 Offset: 0x1AAE170 VA: 0x1AB2170
	private void SetLayout(UIGuildRecruitSearch.STATE state) { }

	// RVA: 0x1AB23AC Offset: 0x1AAE3AC VA: 0x1AB23AC
	private void ChangeRecruitPage(int nextPage) { }

	// RVA: 0x1AB2AF8 Offset: 0x1AAEAF8 VA: 0x1AB2AF8
	private bool CheckRequestCondition(GuildBBSSendData data) { }

	// RVA: 0x1AB289C Offset: 0x1AAE89C VA: 0x1AB289C
	private string CreateConditionText(GuildBBSSendData data) { }

	// RVA: 0x1AB2BD0 Offset: 0x1AAEBD0 VA: 0x1AB2BD0
	private void PrevPageButton() { }

	// RVA: 0x1AB2BDC Offset: 0x1AAEBDC VA: 0x1AB2BDC
	private void NextPageButton() { }

	// RVA: 0x1AB2B60 Offset: 0x1AAEB60 VA: 0x1AB2B60
	private void RequestRecruitData() { }

	// RVA: 0x1AB2C88 Offset: 0x1AAEC88 VA: 0x1AB2C88
	private void SetConnection(IReconnectionSubData data) { }

	// RVA: 0x1AB2ED0 Offset: 0x1AAEED0 VA: 0x1AB2ED0
	private void AddData(GuildBBSRecruitmentSearchResponse response) { }

	// RVA: 0x1AB2F70 Offset: 0x1AAEF70 VA: 0x1AB2F70
	public void OnSearchButton() { }

	// RVA: 0x1AB2FCC Offset: 0x1AAEFCC VA: 0x1AB2FCC
	private void SetWaitSearch() { }

	[IteratorStateMachine(typeof(UIGuildRecruitSearch.<WaitEnableSearchButton>d__67))]
	// RVA: 0x1AB2340 Offset: 0x1AAE340 VA: 0x1AB2340
	private IEnumerator WaitEnableSearchButton() { }

	// RVA: 0x1AB3080 Offset: 0x1AAF080 VA: 0x1AB3080
	public void OnRequestGuildJoin(int guildId, string guildName, string guildMasterName, byte joinType) { }

	// RVA: 0x1AB329C Offset: 0x1AAF29C VA: 0x1AB329C
	private void OnSuccessJoinRequest(GuildBBSGetMyRequestResponse response) { }

	// RVA: 0x1AB32B8 Offset: 0x1AAF2B8 VA: 0x1AB32B8
	private void OnSuccessJoinRequest(string guildName, string guildMasterName) { }

	// RVA: 0x1AB3458 Offset: 0x1AAF458 VA: 0x1AB3458
	private void OnFailed(string key, string[] list, Action callback) { }

	// RVA: 0x1AB3578 Offset: 0x1AAF578 VA: 0x1AB3578 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1AB368C Offset: 0x1AAF68C VA: 0x1AB368C Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1AB373C Offset: 0x1AAF73C VA: 0x1AB373C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1AB37C4 Offset: 0x1AAF7C4 VA: 0x1AB37C4
	private void <OnSuccessJoinRequest>b__70_0() { }
}
