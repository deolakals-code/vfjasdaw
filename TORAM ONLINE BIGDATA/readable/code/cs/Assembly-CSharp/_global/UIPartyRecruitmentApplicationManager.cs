// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPartyRecruitmentApplicationManager : UIBasePanelConnection // TypeDefIndex: 7705
{
	// Fields
	[SerializeField]
	private GameObject tweenObject; // 0x30
	[SerializeField]
	private GameObject[] screenPanels; // 0x38
	[SerializeField]
	private GameObject[] mainPanel; // 0x40
	[SerializeField]
	private UILabel partyNameLabel; // 0x48
	[SerializeField]
	private GameObject titleParent; // 0x50
	[Space(20)]
	[SerializeField]
	private Transform recruitmentDisplayContentParent; // 0x58
	[SerializeField]
	private UIPartyRecruitmentApplicationContentManager recruitmentDisplayContent; // 0x60
	[SerializeField]
	private UILabel itemSelectionPartyTypeLabel; // 0x68
	[SerializeField]
	private UILabel itemSelectionPartyDescriptionLabel; // 0x70
	[SerializeField]
	[Space(20)]
	private UILabel confPartyTypeLabel; // 0x78
	[SerializeField]
	private UILabel confPartyDescriptionLabel; // 0x80
	[SerializeField]
	private UIPartyRecruitmentApplicationContentManager confRecruitmentDisplay; // 0x88
	[SerializeField]
	private GameObject requestButton; // 0x90
	[SerializeField]
	private UILabel[] resultDescriptionLabels; // 0x98
	[Space(20)]
	[SerializeField]
	private UILabel errorTitleLabel; // 0xA0
	[SerializeField]
	private UILabel errorDescriptionLabel; // 0xA8
	[SerializeField]
	private UIScrollWindow scrollWindow; // 0xB0
	[SerializeField]
	private Transform listContentParent; // 0xB8
	[SerializeField]
	private UIPartyRecruitmentListViewContentManager listContent; // 0xC0
	[SerializeField]
	private GameObject listContentNonMesLabel; // 0xC8
	private UIPartyRecruitmentApplicationManager.PanelState panelState; // 0xD0
	private bool isThroughListView; // 0xD4
	private PartyRecruitmentData partyRecruitmentData; // 0xD8
	private byte selectFrameNo; // 0xE0
	private const float recruitmentDisplayContentSpacing = -94;
	private float requestDisplayDelay; // 0xE4
	private PartyRecruitmentData[] recruitmentDatas; // 0xE8
	private const int ListViewContentHeight = 95;
	private const int InstanceNum = 100;

	// Properties
	private bool isInputLock { get; }
	private bool isReScaleItemSelectionLabelWait { get; }
	private bool isReScaleConfLabelWait { get; }

	// Methods

	// RVA: 0x1BE8DF4 Offset: 0x1BE4DF4 VA: 0x1BE8DF4
	private bool get_isInputLock() { }

	// RVA: 0x1BE8E04 Offset: 0x1BE4E04 VA: 0x1BE8E04
	private bool get_isReScaleItemSelectionLabelWait() { }

	// RVA: 0x1BE8E28 Offset: 0x1BE4E28 VA: 0x1BE8E28
	private bool get_isReScaleConfLabelWait() { }

	// RVA: 0x1BE8E4C Offset: 0x1BE4E4C VA: 0x1BE8E4C
	private void Update() { }

	// RVA: 0x1BE8EC0 Offset: 0x1BE4EC0 VA: 0x1BE8EC0
	private void Initialize() { }

	// RVA: 0x1BE90A4 Offset: 0x1BE50A4 VA: 0x1BE90A4
	private void ChangePanel(UIPartyRecruitmentApplicationManager.PanelState state) { }

	// RVA: 0x1BEA95C Offset: 0x1BE695C VA: 0x1BEA95C
	private void ApplyErrorWindowMessage(string message) { }

	// RVA: 0x1BEA978 Offset: 0x1BE6978 VA: 0x1BEA978
	private void CloseMenu() { }

	// RVA: 0x1BEA9D4 Offset: 0x1BE69D4 VA: 0x1BEA9D4
	private void SetPartyName(string name, bool isActive = True) { }

	// RVA: 0x1BEAA24 Offset: 0x1BE6A24 VA: 0x1BEAA24
	private void SetLabelScale(UILabel label, int width, float scale) { }

	// RVA: 0x1BE92E4 Offset: 0x1BE52E4 VA: 0x1BE92E4
	private void InitializeItemSelectionScreen() { }

	// RVA: 0x1BEACC0 Offset: 0x1BE6CC0 VA: 0x1BEACC0
	private void OnClickRequestButton(int frameNo) { }

	// RVA: 0x1BE9C0C Offset: 0x1BE5C0C VA: 0x1BE9C0C
	private void InitializeConfirmationScreen() { }

	// RVA: 0x1BE9DBC Offset: 0x1BE5DBC VA: 0x1BE9DBC
	private void InitializeResultScreen() { }

	// RVA: 0x1BE9EB4 Offset: 0x1BE5EB4 VA: 0x1BE9EB4
	private void InitializeListView() { }

	// RVA: 0x1BEA8A0 Offset: 0x1BE68A0 VA: 0x1BEA8A0
	private void InitializeErrorPop() { }

	// RVA: 0x1BEB0DC Offset: 0x1BE70DC VA: 0x1BEB0DC
	public void InitializeToRecruitmentDetail(int recruitId, bool isPlayeSE = True) { }

	// RVA: 0x1BEB1F8 Offset: 0x1BE71F8 VA: 0x1BEB1F8
	public void ReceivePartyRecruitmentCheckCallback(PartyRecruitmentData data) { }

	// RVA: 0x1BEB2D8 Offset: 0x1BE72D8 VA: 0x1BEB2D8
	public void OnClickApplication() { }

	// RVA: 0x1BEB43C Offset: 0x1BE743C VA: 0x1BEB43C
	public void ReceivePartyRecruitmentApply(int recruitmentId) { }

	// RVA: 0x1BEB504 Offset: 0x1BE7504 VA: 0x1BEB504
	public void InitializeToGetPartyRecruitmentList(bool isPlayeSE = True) { }

	// RVA: 0x1BEB610 Offset: 0x1BE7610 VA: 0x1BEB610
	public void GetRecruitmentListCallBack(PartyRecruitmentListResponse response) { }

	// RVA: 0x1BEAC70 Offset: 0x1BE6C70 VA: 0x1BEAC70
	public void PopUpErrorWindow(string key) { }

	// RVA: 0x1BEB7B4 Offset: 0x1BE77B4 VA: 0x1BEB7B4
	public void OnClickCloseMenu() { }

	// RVA: 0x1BEB828 Offset: 0x1BE7828 VA: 0x1BEB828 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1BEB93C Offset: 0x1BE793C VA: 0x1BEB93C Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1BEB9B0 Offset: 0x1BE79B0 VA: 0x1BEB9B0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1BEB9B8 Offset: 0x1BE79B8 VA: 0x1BEB9B8
	private bool <InitializeConfirmationScreen>b__45_0(PartyMemberFrameData x) { }
}
