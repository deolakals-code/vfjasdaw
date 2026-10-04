// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPartyManager : UIBasePanelConnection, IUIMenuShortcutClose // TypeDefIndex: 8204
{
	// Fields
	[SerializeField]
	private GameObject addButtonObject; // 0x30
	[SerializeField]
	private GameObject addPlayerButtonObject; // 0x38
	[SerializeField]
	private float buttonHeight; // 0x40
	[SerializeField]
	private GameObject fullScreenScrollWindow; // 0x48
	[SerializeField]
	private UIPartyMember[] partyMemberData; // 0x50
	[SerializeField]
	private GameObject partyEmptyButtonText; // 0x58
	[SerializeField]
	private GameObject cantChangePartyLeaderText; // 0x60
	[SerializeField]
	private GameObject partyLinkObj; // 0x68
	[SerializeField]
	private UILabel partyLinkLabel; // 0x70
	private GameObject scrollWindowObject; // 0x78
	private UIScrollWindow scrollWindow; // 0x80
	private Camera scrollCamera; // 0x88
	private PlayerDataManager playerDataManager; // 0x90
	private int lastSelectedMemberId; // 0x98
	private UIPopWindow popWindow; // 0xA0
	private UIPartyInvitation invitation; // 0xA8
	private List<ArchetypeUid> archetypeUidList; // 0xB0
	private Dictionary<int, string> scrollMessage; // 0xB8
	private List<GameObject> fixButtonList; // 0xC0
	private bool isTopPanel; // 0xC8
	private int myPetArcheTypeId; // 0xCC
	private UIPartyManager.PanelState panelState; // 0xD0

	// Properties
	public bool IsInvitationPanel { get; }
	public bool IsShortcutClose { get; }
	public bool IsTopPanel { get; }

	// Methods

	// RVA: 0x1CEB44C Offset: 0x1CE744C VA: 0x1CEB44C
	public bool get_IsInvitationPanel() { }

	// RVA: 0x1CEB4D4 Offset: 0x1CE74D4 VA: 0x1CEB4D4 Slot: 8
	public bool get_IsShortcutClose() { }

	// RVA: 0x1CEB4F4 Offset: 0x1CE74F4 VA: 0x1CEB4F4
	public bool get_IsTopPanel() { }

	// RVA: 0x1CEB4FC Offset: 0x1CE74FC VA: 0x1CEB4FC
	private void Awake() { }

	// RVA: 0x1CEDC00 Offset: 0x1CE9C00 VA: 0x1CEDC00
	private void Start() { }

	// RVA: 0x1CEDC04 Offset: 0x1CE9C04 VA: 0x1CEDC04
	private void Update() { }

	// RVA: 0x1CEB644 Offset: 0x1CE7644 VA: 0x1CEB644
	private void initializeScrollWindow() { }

	// RVA: 0x1CEB7F8 Offset: 0x1CE77F8 VA: 0x1CEB7F8
	public void InitializeMainMenu() { }

	// RVA: 0x1CEE31C Offset: 0x1CEA31C VA: 0x1CEE31C
	private void addButton(int index, string buttonText, string messageText, string functionName, string iconName, bool isSystem = False) { }

	// RVA: 0x1CEE364 Offset: 0x1CEA364 VA: 0x1CEE364
	private void addButton(int index, string buttonText, string messageText, string functionName, bool enabled, string iconName, bool isSystem = False) { }

	// RVA: 0x1CEE3AC Offset: 0x1CEA3AC VA: 0x1CEE3AC
	private void fixAddButton(int index, string buttonText, string messageText, string functionName, string iconName) { }

	// RVA: 0x1CEE3EC Offset: 0x1CEA3EC VA: 0x1CEE3EC
	private void addButton(GameObject addButton, int index, string buttonText, string messageText, string functionName, int sendParam, bool enabled, string iconName, bool isSystem) { }

	// RVA: 0x1CEE770 Offset: 0x1CEA770 VA: 0x1CEE770
	private void fixAddButton(GameObject addButton, int index, string buttonText, string messageText, string functionName, int sendParam, string iconName) { }

	// RVA: 0x1CEEB40 Offset: 0x1CEAB40 VA: 0x1CEEB40
	private void onHover(int index) { }

	// RVA: 0x1CE6460 Offset: 0x1CE2460 VA: 0x1CE6460
	public void InitializeInvitation() { }

	// RVA: 0x1CEF044 Offset: 0x1CEB044 VA: 0x1CEF044
	private void doInitializeInvitation(bool enable) { }

	// RVA: 0x1CEF178 Offset: 0x1CEB178 VA: 0x1CEF178
	public void UpdateInvitation() { }

	// RVA: 0x1CEE148 Offset: 0x1CEA148 VA: 0x1CEE148
	private void setShowMemberData(bool isShow) { }

	// RVA: 0x1CEF230 Offset: 0x1CEB230 VA: 0x1CEF230
	private void RegisterMercenary() { }

	// RVA: 0x1CEF284 Offset: 0x1CEB284 VA: 0x1CEF284
	private void EmployMercenary() { }

	// RVA: 0x1CEF2D8 Offset: 0x1CEB2D8 VA: 0x1CEF2D8
	private void PetAdventure() { }

	// RVA: 0x1CEF32C Offset: 0x1CEB32C VA: 0x1CEF32C
	private void secedeParty() { }

	// RVA: 0x1CEF4C4 Offset: 0x1CEB4C4 VA: 0x1CEF4C4
	private void doSecedeParty() { }

	// RVA: 0x1CEF638 Offset: 0x1CEB638 VA: 0x1CEF638
	private void dissolutionParty() { }

	// RVA: 0x1CEF7D0 Offset: 0x1CEB7D0 VA: 0x1CEF7D0
	private void doDissolutionParty() { }

	// RVA: 0x1CEF944 Offset: 0x1CEB944 VA: 0x1CEF944
	private void kickoutParty() { }

	// RVA: 0x1CEFFE0 Offset: 0x1CEBFE0 VA: 0x1CEFFE0
	private void onKickout(int id) { }

	// RVA: 0x1CF0360 Offset: 0x1CEC360 VA: 0x1CF0360
	private void doKickout() { }

	[IteratorStateMachine(typeof(UIPartyManager.<PartyKickOut>d__54))]
	// RVA: 0x1CF0530 Offset: 0x1CEC530 VA: 0x1CF0530
	private IEnumerator PartyKickOut(byte targetType, int targetId) { }

	[IteratorStateMachine(typeof(UIPartyManager.<PartyPetKickOut>d__55))]
	// RVA: 0x1CF04B4 Offset: 0x1CEC4B4 VA: 0x1CF04B4
	private IEnumerator PartyPetKickOut(int petId) { }

	// RVA: 0x1CF0604 Offset: 0x1CEC604 VA: 0x1CF0604
	private void AfterPetKickOut() { }

	// RVA: 0x1CF0644 Offset: 0x1CEC644 VA: 0x1CF0644
	private void AfterKickOut() { }

	// RVA: 0x1CF06A8 Offset: 0x1CEC6A8 VA: 0x1CF06A8
	private void changeLeaderParty() { }

	// RVA: 0x1CF06FC Offset: 0x1CEC6FC VA: 0x1CF06FC
	private void onChangeLeader(int id) { }

	// RVA: 0x1CF0A7C Offset: 0x1CECA7C VA: 0x1CF0A7C
	private void doChangeLeader() { }

	// RVA: 0x1CF0C40 Offset: 0x1CECC40 VA: 0x1CF0C40
	private void cancelInvitation() { }

	// RVA: 0x1CF0F74 Offset: 0x1CECF74 VA: 0x1CF0F74
	private void onPartyLottery() { }

	// RVA: 0x1CF0FD0 Offset: 0x1CECFD0 VA: 0x1CF0FD0
	private void CancelLinkInvitate() { }

	[IteratorStateMachine(typeof(UIPartyManager.<WaitCancelLinkInvite>d__64))]
	// RVA: 0x1CF104C Offset: 0x1CED04C VA: 0x1CF104C
	private IEnumerator WaitCancelLinkInvite() { }

	[IteratorStateMachine(typeof(UIPartyManager.<LinkRelease>d__65))]
	// RVA: 0x1CF10E0 Offset: 0x1CED0E0 VA: 0x1CF10E0
	private IEnumerator LinkRelease() { }

	// RVA: 0x1CF1174 Offset: 0x1CED174 VA: 0x1CF1174
	private void PartyRecruitmentRegistration() { }

	// RVA: 0x1CF1228 Offset: 0x1CED228 VA: 0x1CF1228
	private void PartyRecruitmentListView() { }

	// RVA: 0x1CEF998 Offset: 0x1CEB998 VA: 0x1CEF998
	private void InitializePartyMemberNameList(string callbackFuncName) { }

	// RVA: 0x1CEEBE8 Offset: 0x1CEABE8 VA: 0x1CEEBE8
	private void invitationCaptureWarningPopup() { }

	// RVA: 0x1CF0ED8 Offset: 0x1CECED8 VA: 0x1CF0ED8
	private void OnClose() { }

	// RVA: 0x1CF13F8 Offset: 0x1CED3F8 VA: 0x1CF13F8
	private void OnDestroy() { }

	// RVA: 0x1CEE260 Offset: 0x1CEA260 VA: 0x1CEE260
	private void ClosePopwindow() { }

	// RVA: 0x1CF1308 Offset: 0x1CED308 VA: 0x1CF1308
	private void enableCantChangeLeaderMes(bool enable) { }

	// RVA: 0x1CF1478 Offset: 0x1CED478 VA: 0x1CF1478 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1CF1538 Offset: 0x1CED538 VA: 0x1CF1538 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1CF1594 Offset: 0x1CED594 VA: 0x1CF1594
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1CF1704 Offset: 0x1CED704 VA: 0x1CF1704
	private void <doSecedeParty>b__48_1() { }

	[CompilerGenerated]
	// RVA: 0x1CF1928 Offset: 0x1CED928 VA: 0x1CF1928
	private void <doDissolutionParty>b__50_1() { }

	[CompilerGenerated]
	// RVA: 0x1CF1B4C Offset: 0x1CEDB4C VA: 0x1CF1B4C
	private void <doDissolutionParty>b__50_2() { }

	[CompilerGenerated]
	// RVA: 0x1CF1B50 Offset: 0x1CEDB50 VA: 0x1CF1B50
	private void <doChangeLeader>b__60_1() { }

	[CompilerGenerated]
	// RVA: 0x1CF1DAC Offset: 0x1CEDDAC VA: 0x1CF1DAC
	private void <doChangeLeader>b__60_2() { }

	[CompilerGenerated]
	// RVA: 0x1CF1E10 Offset: 0x1CEDE10 VA: 0x1CF1E10
	private void <cancelInvitation>b__61_2() { }

	[CompilerGenerated]
	// RVA: 0x1CF1EA0 Offset: 0x1CEDEA0 VA: 0x1CF1EA0
	private void <invitationCaptureWarningPopup>b__69_0() { }
}
