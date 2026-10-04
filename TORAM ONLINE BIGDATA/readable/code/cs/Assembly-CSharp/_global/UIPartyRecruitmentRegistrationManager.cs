// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPartyRecruitmentRegistrationManager : UIBasePanelConnection // TypeDefIndex: 7717
{
	// Fields
	[SerializeField]
	private GameObject titleIcon; // 0x30
	[SerializeField]
	private UILabel titleLabel; // 0x38
	[SerializeField]
	private GameObject[] screenPanels; // 0x40
	[SerializeField]
	private UIScrollWindow scrollWindow; // 0x48
	[SerializeField]
	private GameObject registrationMenu; // 0x50
	[SerializeField]
	private UIPartyRecruitmentInputField partyNameInputField; // 0x58
	[SerializeField]
	private UIPartyRecruitmentInputField partyDescriptionInputField; // 0x60
	[SerializeField]
	private UILabel partyRecruitmentTypeLabel; // 0x68
	[SerializeField]
	private UISprite roleRecruitmentBoard; // 0x70
	[SerializeField]
	private Transform roleRecruitmentBoardContentParent; // 0x78
	[SerializeField]
	private GameObject roleRecruitmentBoardContent; // 0x80
	[SerializeField]
	private GameObject bottomMenu; // 0x88
	[SerializeField]
	private UIImageButton partyRecruitmentEnterButton; // 0x90
	[SerializeField]
	private UILabel partyRecruitmentEnterButtonLabel; // 0x98
	[SerializeField]
	private UILabel errorDescriptionLabel; // 0xA0
	private UIPartyRecruitmentRegistrationManager.PanelState panelState; // 0xA8
	private const int BaseRoleRecruitmentBoardHeight = 203;
	private const int RoleRecruitmentBoardContentHeight = 85;
	private const int BottomMenuInitialY = -445;
	private const int BottomMenuStepSize = 95;
	private byte selectRecruitmentType; // 0xAC
	private UIPartyRecruitmentRegistrationRoleBoardContentManager[] roleContentManagers; // 0xB0
	private int recruitmentCount; // 0xB8
	private const int maxRecruitmentCount = 3;
	private PartyMemberFrameData[] mediumRecruitmentFrameDatas; // 0xC0
	private PartyMemberFrameData[] beforeRecruitmentFrameDatas; // 0xC8

	// Properties
	private bool IsInputLock { get; }

	// Methods

	// RVA: 0x1BEC908 Offset: 0x1BE8908 VA: 0x1BEC908
	private bool get_IsInputLock() { }

	// RVA: 0x1BEC918 Offset: 0x1BE8918 VA: 0x1BEC918
	private void Start() { }

	// RVA: 0x1BED018 Offset: 0x1BE9018 VA: 0x1BED018
	private void OnDestroy() { }

	// RVA: 0x1BEC974 Offset: 0x1BE8974 VA: 0x1BEC974
	private void Initialize() { }

	// RVA: 0x1BED06C Offset: 0x1BE906C VA: 0x1BED06C
	private void ChangePanel(UIPartyRecruitmentRegistrationManager.PanelState state, string errorPopMessage = "") { }

	// RVA: 0x1BED19C Offset: 0x1BE919C VA: 0x1BED19C
	private void InitializeRegistrationMenu() { }

	// RVA: 0x1BEDB20 Offset: 0x1BE9B20 VA: 0x1BEDB20
	private void InitializeErrorPop(string errorMessage) { }

	// RVA: 0x1BEDB9C Offset: 0x1BE9B9C VA: 0x1BEDB9C
	private void UpdatePartyRecruitmentType() { }

	// RVA: 0x1BEE4E8 Offset: 0x1BEA4E8 VA: 0x1BEE4E8
	private byte SwitchPartyRecruitmentType(byte type, bool next) { }

	// RVA: 0x1BEDFC0 Offset: 0x1BE9FC0 VA: 0x1BEDFC0
	private void SetTitles(string title, bool isActiveIcon) { }

	// RVA: 0x1BEE4CC Offset: 0x1BEA4CC VA: 0x1BEE4CC
	private void ApplyErrorWindowMessage(string message) { }

	// RVA: 0x1BEE000 Offset: 0x1BEA000 VA: 0x1BEE000
	public void ChangeEnterButtonVisual() { }

	// RVA: 0x1BEE5E4 Offset: 0x1BEA5E4 VA: 0x1BEE5E4
	private bool NgWordCheck(string text) { }

	// RVA: 0x1BEE774 Offset: 0x1BEA774 VA: 0x1BEE774
	public void OnClickChangePartyRecruitmentType(bool isRight) { }

	// RVA: 0x1BEE800 Offset: 0x1BEA800 VA: 0x1BEE800
	public void PopUpErrorWindow(string key) { }

	// RVA: 0x1BEE8C0 Offset: 0x1BEA8C0 VA: 0x1BEE8C0
	public void OnClickCloseMenu() { }

	// RVA: 0x1BEE990 Offset: 0x1BEA990 VA: 0x1BEE990
	public void OnClickPartyRecruiting() { }

	// RVA: 0x1BEE934 Offset: 0x1BEA934 VA: 0x1BEE934
	public void CloseMenu() { }

	// RVA: 0x1BEF260 Offset: 0x1BEB260 VA: 0x1BEF260
	public void RemoveCandidate(byte[] frameNo, int[] candidateIds) { }

	// RVA: 0x1BEF7D8 Offset: 0x1BEB7D8 VA: 0x1BEF7D8 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1BEF894 Offset: 0x1BEB894 VA: 0x1BEF894 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1BEF908 Offset: 0x1BEB908 VA: 0x1BEF908
	public void .ctor() { }
}
