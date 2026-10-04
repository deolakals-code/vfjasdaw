// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPartyInvitation : MonoBehaviour // TypeDefIndex: 7687
{
	// Fields
	[SerializeField]
	private GameObject addButtonObject; // 0x20
	[SerializeField]
	private float buttonHeight; // 0x28
	[SerializeField]
	private GameObject subObject; // 0x30
	[SerializeField]
	private UIPartyLinkInviteElement linkAddButtonObject; // 0x38
	[SerializeField]
	private UIPartyRequestInviteElement requestAddButtonObject; // 0x40
	private UIScrollWindow scrollWindow; // 0x48
	private int selectedPartyId; // 0x50
	private List<AnnouncementBase> noticeData; // 0x58
	private List<UIFriendReserveElement> addedElement; // 0x60
	private List<AnnouncementBase> noticeLinkData; // 0x68
	private List<UIPartyLinkInviteElement> linkAddedElementList; // 0x70
	private List<AnnouncementBase> noticeRequestData; // 0x78
	private List<UIPartyRequestInviteElement> requestAddedElementList; // 0x80
	private byte targetFrameNo; // 0x88
	private int targetAvatarUuid; // 0x8C
	[CompilerGenerated]
	private Action <LeftTopAction>k__BackingField; // 0x90
	private bool isEnable; // 0x98
	private UIPopWindow popWindow; // 0xA0
	private UIPopWindow popYesNoWindow; // 0xA8
	private Transform parentTransform; // 0xB0
	private bool isClose; // 0xB8
	private bool isConnection; // 0xB9

	// Properties
	public Action LeftTopAction { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1BE1108 Offset: 0x1BDD108 VA: 0x1BE1108
	public Action get_LeftTopAction() { }

	[CompilerGenerated]
	// RVA: 0x1BE1110 Offset: 0x1BDD110 VA: 0x1BE1110
	private void set_LeftTopAction(Action value) { }

	// RVA: 0x1BE1118 Offset: 0x1BDD118 VA: 0x1BE1118
	private void SetLoading(bool acitve) { }

	// RVA: 0x1BE1190 Offset: 0x1BDD190 VA: 0x1BE1190
	public void SetParentTransform(Transform transform) { }

	// RVA: 0x1BE1198 Offset: 0x1BDD198 VA: 0x1BE1198
	public void SetLeftTopAction(Action action) { }

	// RVA: 0x1BE11A0 Offset: 0x1BDD1A0 VA: 0x1BE11A0
	public void Initialize(bool enable) { }

	// RVA: 0x1BE2864 Offset: 0x1BDE864 VA: 0x1BE2864
	public bool CloseCheck() { }

	// RVA: 0x1BE294C Offset: 0x1BDE94C VA: 0x1BE294C
	private void onSelected(int partyId) { }

	// RVA: 0x1BE2AA4 Offset: 0x1BDEAA4 VA: 0x1BE2AA4
	private void onAccept() { }

	[IteratorStateMachine(typeof(UIPartyInvitation.<Accept>d__32))]
	// RVA: 0x1BE2B38 Offset: 0x1BDEB38 VA: 0x1BE2B38
	private IEnumerator Accept() { }

	// RVA: 0x1BE2BCC Offset: 0x1BDEBCC VA: 0x1BE2BCC
	private void onReject() { }

	[IteratorStateMachine(typeof(UIPartyInvitation.<Rejection>d__34))]
	// RVA: 0x1BE2C60 Offset: 0x1BDEC60 VA: 0x1BE2C60
	private IEnumerator Rejection() { }

	// RVA: 0x1BE2CF4 Offset: 0x1BDECF4 VA: 0x1BE2CF4
	private void acceptanceCallback() { }

	// RVA: 0x1BE2D44 Offset: 0x1BDED44 VA: 0x1BE2D44
	private PartyAnnouncementData getPartyInfo(int partyId) { }

	// RVA: 0x1BE2E88 Offset: 0x1BDEE88 VA: 0x1BE2E88
	private PartyLinkAnnouncementData GetPartyLinkInfo(int partyId) { }

	// RVA: 0x1BE2FCC Offset: 0x1BDEFCC VA: 0x1BE2FCC
	private PartyRequestAnnouncementData GetPartyRecruitmentInfo(int archetypeId) { }

	// RVA: 0x1BE3110 Offset: 0x1BDF110 VA: 0x1BE3110
	public void Clear() { }

	// RVA: 0x1BE3138 Offset: 0x1BDF138 VA: 0x1BE3138
	private void OnEnable() { }

	// RVA: 0x1BE3158 Offset: 0x1BDF158 VA: 0x1BE3158
	private void OnDisable() { }

	// RVA: 0x1BE3198 Offset: 0x1BDF198 VA: 0x1BE3198
	public void OnBlock() { }

	[IteratorStateMachine(typeof(UIPartyInvitation.<BlockWindow>d__43))]
	// RVA: 0x1BE3250 Offset: 0x1BDF250 VA: 0x1BE3250
	private IEnumerator BlockWindow(int id, string name, Action rejectAction, bool isPartyRequest = False) { }

	// RVA: 0x1BE3330 Offset: 0x1BDF330 VA: 0x1BE3330
	private void OnLinkAccept() { }

	[IteratorStateMachine(typeof(UIPartyInvitation.<WaitLinkAccept>d__45))]
	// RVA: 0x1BE33F4 Offset: 0x1BDF3F4 VA: 0x1BE33F4
	private IEnumerator WaitLinkAccept() { }

	// RVA: 0x1BE3488 Offset: 0x1BDF488 VA: 0x1BE3488
	private void OnLinkReject() { }

	[IteratorStateMachine(typeof(UIPartyInvitation.<WaitLinkReject>d__47))]
	// RVA: 0x1BE354C Offset: 0x1BDF54C VA: 0x1BE354C
	private IEnumerator WaitLinkReject() { }

	// RVA: 0x1BE35E0 Offset: 0x1BDF5E0 VA: 0x1BE35E0
	public void OnBlockPartyRecruitment() { }

	// RVA: 0x1BE36A0 Offset: 0x1BDF6A0 VA: 0x1BE36A0
	private void OnRequestAccept() { }

	// RVA: 0x1BE38A8 Offset: 0x1BDF8A8 VA: 0x1BE38A8
	private void OnRequestReject() { }

	// RVA: 0x1BE3A70 Offset: 0x1BDFA70 VA: 0x1BE3A70
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1BE3C34 Offset: 0x1BDFC34 VA: 0x1BE3C34
	private void <Initialize>b__28_1(byte frameNo, int targetAvatarUuid) { }

	[CompilerGenerated]
	// RVA: 0x1BE3DA0 Offset: 0x1BDFDA0 VA: 0x1BE3DA0
	private void <Accept>b__32_0() { }

	[CompilerGenerated]
	// RVA: 0x1BE3DA4 Offset: 0x1BDFDA4 VA: 0x1BE3DA4
	private void <Accept>b__32_1() { }

	[CompilerGenerated]
	// RVA: 0x1BE3DA8 Offset: 0x1BDFDA8 VA: 0x1BE3DA8
	private void <OnBlockPartyRecruitment>b__48_0() { }

	[CompilerGenerated]
	// RVA: 0x1BE3F40 Offset: 0x1BDFF40 VA: 0x1BE3F40
	private void <OnBlockPartyRecruitment>b__48_1() { }

	[CompilerGenerated]
	// RVA: 0x1BE3F98 Offset: 0x1BDFF98 VA: 0x1BE3F98
	private void <OnRequestAccept>b__49_0() { }

	[CompilerGenerated]
	// RVA: 0x1BE3FF0 Offset: 0x1BDFFF0 VA: 0x1BE3FF0
	private void <OnRequestReject>b__50_0() { }
}
