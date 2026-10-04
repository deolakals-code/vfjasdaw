// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGuildMember : UIFriendList, IUIGuild // TypeDefIndex: 7144
{
	// Fields
	[SerializeField]
	private UIGuildMemberAuthority authorityWindow; // 0xE8
	[SerializeField]
	private UIGuildChangeNameWindow renameWindow; // 0xF0
	[SerializeField]
	private UIGuildTransferWindow transferWindow; // 0xF8
	[SerializeField]
	private UIGuildCandidacyWindow candidacyWindow; // 0x100
	private UIGuildMember.actionType nowActionType; // 0x108
	private UIGuildMember.actionMode nowActionMode; // 0x10C
	private UIGuildMember.sortType lastSortType; // 0x110
	private PlayerDataManager playerDataManager; // 0x118
	private List<GuildMemberData> memberList; // 0x120
	private GuildMemberData masterData; // 0x128
	private UserOnLineNoticeType noticeType; // 0x130
	private UILabel onlineStatusButtonLabel; // 0x138
	private Coroutine progressCoroutine; // 0x140
	private Coroutine loadCoroutine; // 0x148

	// Methods

	// RVA: 0x1AA1280 Offset: 0x1A9D280 VA: 0x1AA1280
	private void Awake() { }

	[IteratorStateMachine(typeof(UIGuildMember.<Start>d__16))]
	// RVA: 0x1AA1410 Offset: 0x1A9D410 VA: 0x1AA1410
	private IEnumerator Start() { }

	// RVA: 0x1AA1484 Offset: 0x1A9D484 VA: 0x1AA1484
	public void InitGuildMemberList() { }

	[IteratorStateMachine(typeof(UIGuildMember.<getGuildMember>d__18))]
	// RVA: 0x1AA14A4 Offset: 0x1A9D4A4 VA: 0x1AA14A4
	private IEnumerator getGuildMember() { }

	// RVA: 0x1AA1518 Offset: 0x1A9D518 VA: 0x1AA1518 Slot: 4
	public override void InitializeList() { }

	// RVA: 0x1AA19EC Offset: 0x1A9D9EC VA: 0x1AA19EC Slot: 5
	public override void UpdateList() { }

	// RVA: 0x1AA216C Offset: 0x1A9E16C VA: 0x1AA216C
	private void initializeMenu() { }

	// RVA: 0x1AA2FA8 Offset: 0x1A9EFA8 VA: 0x1AA2FA8 Slot: 11
	protected override void onSelected(int index) { }

	// RVA: 0x1AA3694 Offset: 0x1A9F694 VA: 0x1AA3694 Slot: 12
	protected override void OnClick() { }

	// RVA: 0x1AA45EC Offset: 0x1AA05EC VA: 0x1AA45EC Slot: 10
	protected override void onSortByLv() { }

	// RVA: 0x1AA47B8 Offset: 0x1AA07B8 VA: 0x1AA47B8 Slot: 9
	protected override void onSortByName() { }

	// RVA: 0x1AA4984 Offset: 0x1AA0984 VA: 0x1AA4984
	private void onSortByContribution() { }

	// RVA: 0x1AA4B50 Offset: 0x1AA0B50 VA: 0x1AA4B50
	private void onSortByOnline() { }

	// RVA: 0x1AA4CE0 Offset: 0x1AA0CE0 VA: 0x1AA4CE0 Slot: 13
	protected override void onFriendTell() { }

	// RVA: 0x1AA4DC8 Offset: 0x1AA0DC8 VA: 0x1AA4DC8
	private void onSecede() { }

	// RVA: 0x1AA3E28 Offset: 0x1A9FE28 VA: 0x1AA3E28
	private void onExile() { }

	// RVA: 0x1AA3BD8 Offset: 0x1A9FBD8 VA: 0x1AA3BD8
	private void onAuthority() { }

	// RVA: 0x1AA41EC Offset: 0x1AA01EC VA: 0x1AA41EC
	private void onTransfer() { }

	// RVA: 0x1AA4330 Offset: 0x1AA0330 VA: 0x1AA4330
	private void onRename() { }

	// RVA: 0x1AA44F0 Offset: 0x1AA04F0 VA: 0x1AA44F0
	private void onCandidacy() { }

	// RVA: 0x1AA3820 Offset: 0x1A9F820 VA: 0x1AA3820
	protected void onPartyInvitation() { }

	// RVA: 0x1AA4FCC Offset: 0x1AA0FCC VA: 0x1AA4FCC
	protected void onOpenPartyPopup() { }

	// RVA: 0x1AA4FEC Offset: 0x1AA0FEC VA: 0x1AA4FEC
	protected void doPartyInvitation() { }

	[IteratorStateMachine(typeof(UIGuildMember.<PartyInvitation>d__38))]
	// RVA: 0x1AA500C Offset: 0x1AA100C VA: 0x1AA500C
	protected IEnumerator PartyInvitation() { }

	// RVA: 0x1AA5080 Offset: 0x1AA1080 VA: 0x1AA5080
	private void doSecede() { }

	// RVA: 0x1AA50F8 Offset: 0x1AA10F8 VA: 0x1AA50F8
	private void doExile() { }

	[IteratorStateMachine(typeof(UIGuildMember.<Exile>d__41))]
	// RVA: 0x1AA516C Offset: 0x1AA116C VA: 0x1AA516C
	private IEnumerator Exile() { }

	// RVA: 0x1AA51E0 Offset: 0x1AA11E0 VA: 0x1AA51E0
	private void ReturnTopMenu() { }

	// RVA: 0x1AA520C Offset: 0x1AA120C VA: 0x1AA520C
	private void doAuthority(byte newAuthority) { }

	// RVA: 0x1AA53AC Offset: 0x1AA13AC VA: 0x1AA53AC
	private void closeAuthority() { }

	// RVA: 0x1AA53EC Offset: 0x1AA13EC VA: 0x1AA53EC
	private void checkRename(string checkname) { }

	// RVA: 0x1AA5484 Offset: 0x1AA1484 VA: 0x1AA5484
	private void progressRename(string newName) { }

	// RVA: 0x1AA55A0 Offset: 0x1AA15A0 VA: 0x1AA55A0
	private void cancelProgress() { }

	// RVA: 0x1AA5668 Offset: 0x1AA1668 VA: 0x1AA5668
	private void doRename(string newName) { }

	[IteratorStateMachine(typeof(UIGuildMember.<connectRename>d__50))]
	// RVA: 0x1AA5748 Offset: 0x1AA1748 VA: 0x1AA5748
	private IEnumerator connectRename(string newName) { }

	// RVA: 0x1AA57D8 Offset: 0x1AA17D8 VA: 0x1AA57D8
	private void closeRename() { }

	// RVA: 0x1AA5814 Offset: 0x1AA1814 VA: 0x1AA5814
	private void doTransfer() { }

	// RVA: 0x1AA5834 Offset: 0x1AA1834 VA: 0x1AA5834
	private void progressTransfer() { }

	// RVA: 0x1AA5978 Offset: 0x1AA1978 VA: 0x1AA5978
	private void doTransfer(int id) { }

	[IteratorStateMachine(typeof(UIGuildMember.<connectTransfer>d__56))]
	// RVA: 0x1AA5998 Offset: 0x1AA1998 VA: 0x1AA5998
	private IEnumerator connectTransfer(int id) { }

	// RVA: 0x1AA5A1C Offset: 0x1AA1A1C VA: 0x1AA5A1C
	private void cancelTransferLoad() { }

	// RVA: 0x1AA5AE8 Offset: 0x1AA1AE8 VA: 0x1AA5AE8
	private void backTransferToMemberList() { }

	// RVA: 0x1AA5BAC Offset: 0x1AA1BAC VA: 0x1AA5BAC
	private void closeTransfer() { }

	// RVA: 0x1AA5CA4 Offset: 0x1AA1CA4 VA: 0x1AA5CA4
	private void doCandidacy() { }

	// RVA: 0x1AA5CC4 Offset: 0x1AA1CC4 VA: 0x1AA5CC4
	private void progressCandidacy() { }

	// RVA: 0x1AA5DFC Offset: 0x1AA1DFC VA: 0x1AA5DFC
	private void doCandidacy(int id) { }

	[IteratorStateMachine(typeof(UIGuildMember.<connectCandidacy>d__63))]
	// RVA: 0x1AA5E1C Offset: 0x1AA1E1C VA: 0x1AA5E1C
	private IEnumerator connectCandidacy(int id) { }

	// RVA: 0x1AA5EA0 Offset: 0x1AA1EA0 VA: 0x1AA5EA0
	private void cancelCandidacyLoad() { }

	// RVA: 0x1AA5F80 Offset: 0x1AA1F80 VA: 0x1AA5F80
	private void backCandidacyToMemberList() { }

	// RVA: 0x1AA6040 Offset: 0x1AA2040 VA: 0x1AA6040
	private void closeCandidacy() { }

	// RVA: 0x1AA6134 Offset: 0x1AA2134 VA: 0x1AA6134 Slot: 7
	protected override void onChangeState() { }

	// RVA: 0x1AA619C Offset: 0x1AA219C VA: 0x1AA619C Slot: 16
	public void OnClose() { }

	// RVA: 0x1AA6258 Offset: 0x1AA2258 VA: 0x1AA6258 Slot: 8
	protected override void onSetting() { }

	// RVA: 0x1AA62B0 Offset: 0x1AA22B0 VA: 0x1AA62B0 Slot: 6
	public override bool IsSelected(int archetypeId) { }

	// RVA: 0x1AA631C Offset: 0x1AA231C VA: 0x1AA631C Slot: 14
	protected override string getActionButtonKey() { }

	// RVA: 0x1AA6398 Offset: 0x1AA2398 VA: 0x1AA6398 Slot: 15
	protected override string getActionStateText() { }

	// RVA: 0x1AA6430 Offset: 0x1AA2430 VA: 0x1AA6430
	private void onChangeAction(int param) { }

	// RVA: 0x1AA2114 Offset: 0x1A9E114 VA: 0x1AA2114
	private void closeMasterWindow() { }

	// RVA: 0x1AA2E70 Offset: 0x1A9EE70 VA: 0x1AA2E70
	private void ChangeNoticeButtonLabel() { }

	// RVA: 0x1AA64E8 Offset: 0x1AA24E8 VA: 0x1AA64E8
	public void .ctor() { }
}
