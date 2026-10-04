// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIFriendList : MonoBehaviour // TypeDefIndex: 7083
{
	// Fields
	protected static Color menuColorWarning; // 0x0
	[SerializeField]
	protected UIScrollWindow scrollWindow; // 0x20
	[SerializeField]
	protected GameObject scrollElementObject; // 0x28
	[SerializeField]
	protected float scrollHeight; // 0x30
	[SerializeField]
	protected UILabel actionChangeLabel; // 0x38
	[SerializeField]
	protected GameObject partyInput; // 0x40
	[SerializeField]
	protected UIScrollWindow menuScrollWindow; // 0x48
	[SerializeField]
	protected GameObject menuButton; // 0x50
	[SerializeField]
	protected UIIruna2AnchorSimple menuAnchor; // 0x58
	[SerializeField]
	protected UILabel frindCountLabel; // 0x60
	[SerializeField]
	protected GameObject onlineButtonObj; // 0x68
	[SerializeField]
	protected GameObject mainPanel; // 0x70
	[SerializeField]
	protected UIFriendExpansionSlotPanel expansionSlotPanel; // 0x78
	protected UILabel onlineButtonLabel; // 0x80
	private List<FriendManager.FriendState> friendList; // 0x88
	private FriendManager friendManager; // 0x90
	private UIFriendList.sortType lastSortType; // 0x98
	private UIFriendList.actionType nowActionType; // 0x9C
	private UIFriendList.actionMode nowActionMode; // 0xA0
	protected int selectedIndex; // 0xA4
	protected List<UIFriendListElement> elementList; // 0xA8
	[CompilerGenerated]
	private UIBasePanelControl <TopControl>k__BackingField; // 0xB0
	protected SystemTextManager systemTextManager; // 0xB8
	protected UIPopWindow popWindow; // 0xC0
	protected GameObject addedInputObject; // 0xC8
	private string onlineSettingKey; // 0xD0
	private int onlineSetting; // 0xD8
	private UserOnLineNoticeType noticeType; // 0xDC
	private UILabel onlineStatusButtonLabel; // 0xE0

	// Properties
	public UIBasePanelControl TopControl { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1A8BBFC Offset: 0x1A87BFC VA: 0x1A8BBFC
	public UIBasePanelControl get_TopControl() { }

	[CompilerGenerated]
	// RVA: 0x1A8BC04 Offset: 0x1A87C04 VA: 0x1A8BC04
	public void set_TopControl(UIBasePanelControl value) { }

	// RVA: 0x1A8BC0C Offset: 0x1A87C0C VA: 0x1A8BC0C
	private void Awake() { }

	// RVA: 0x1A8BED0 Offset: 0x1A87ED0 VA: 0x1A8BED0
	private void Update() { }

	// RVA: 0x1A8C160 Offset: 0x1A88160 VA: 0x1A8C160
	private void Start() { }

	// RVA: 0x1A8C254 Offset: 0x1A88254 VA: 0x1A8C254
	private void OnDestroy() { }

	// RVA: 0x1A8C268 Offset: 0x1A88268 VA: 0x1A8C268
	private void initializeMenu() { }

	// RVA: 0x1A8C9A0 Offset: 0x1A889A0 VA: 0x1A8C9A0 Slot: 4
	public virtual void InitializeList() { }

	// RVA: 0x1A8CAEC Offset: 0x1A88AEC VA: 0x1A8CAEC Slot: 5
	public virtual void UpdateList() { }

	// RVA: 0x1A8D688 Offset: 0x1A89688 VA: 0x1A8D688 Slot: 6
	public virtual bool IsSelected(int archetypeId) { }

	// RVA: 0x1A8D6F4 Offset: 0x1A896F4 VA: 0x1A8D6F4 Slot: 7
	protected virtual void onChangeState() { }

	// RVA: 0x1A8D774 Offset: 0x1A89774 VA: 0x1A8D774 Slot: 8
	protected virtual void onSetting() { }

	// RVA: 0x1A8D984 Offset: 0x1A89984 VA: 0x1A8D984 Slot: 9
	protected virtual void onSortByName() { }

	// RVA: 0x1A8DB24 Offset: 0x1A89B24 VA: 0x1A8DB24 Slot: 10
	protected virtual void onSortByLv() { }

	// RVA: 0x1A8DCC4 Offset: 0x1A89CC4 VA: 0x1A8DCC4
	private void onSortByTime() { }

	// RVA: 0x1A8DE64 Offset: 0x1A89E64 VA: 0x1A8DE64 Slot: 11
	protected virtual void onSelected(int index) { }

	// RVA: 0x1A8E324 Offset: 0x1A8A324 VA: 0x1A8E324 Slot: 12
	protected virtual void OnClick() { }

	// RVA: 0x1A8E3C8 Offset: 0x1A8A3C8 VA: 0x1A8E3C8
	private void onFriendRemove() { }

	// RVA: 0x1A8EA40 Offset: 0x1A8AA40 VA: 0x1A8EA40
	private void doFriendRemove() { }

	// RVA: 0x1A8D058 Offset: 0x1A89058 VA: 0x1A8D058
	protected void closePopup() { }

	// RVA: 0x1A8E68C Offset: 0x1A8A68C VA: 0x1A8E68C
	protected void onPartyInvitation() { }

	// RVA: 0x1A8EC08 Offset: 0x1A8AC08 VA: 0x1A8EC08
	protected void onOpenPartyPopup() { }

	// RVA: 0x1A8EC28 Offset: 0x1A8AC28 VA: 0x1A8EC28
	protected void doPartyInvitation() { }

	[IteratorStateMachine(typeof(UIFriendList.<PartyInvitation>d__56))]
	// RVA: 0x1A8EC48 Offset: 0x1A8AC48 VA: 0x1A8EC48
	protected IEnumerator PartyInvitation() { }

	// RVA: 0x1A8ECBC Offset: 0x1A8ACBC VA: 0x1A8ECBC Slot: 13
	protected virtual void onFriendTell() { }

	// RVA: 0x1A8EDF0 Offset: 0x1A8ADF0 VA: 0x1A8EDF0
	protected void onTrade() { }

	// RVA: 0x1A8EE40 Offset: 0x1A8AE40 VA: 0x1A8EE40 Slot: 14
	protected virtual string getActionButtonKey() { }

	// RVA: 0x1A8EEF4 Offset: 0x1A8AEF4 VA: 0x1A8EEF4 Slot: 15
	protected virtual string getActionStateText() { }

	// RVA: 0x1A8D150 Offset: 0x1A89150 VA: 0x1A8D150
	protected void closeMenu() { }

	// RVA: 0x1A8EFB4 Offset: 0x1A8AFB4 VA: 0x1A8EFB4
	private void onChangeAction(int param) { }

	// RVA: 0x1A8F100 Offset: 0x1A8B100 VA: 0x1A8F100
	private void onOnlineSetting() { }

	// RVA: 0x1A8BE04 Offset: 0x1A87E04 VA: 0x1A8BE04
	private void UpdateOnlineSettingText() { }

	[IteratorStateMachine(typeof(UIFriendList.<FriendGetList>d__65))]
	// RVA: 0x1A8C1E0 Offset: 0x1A881E0 VA: 0x1A8C1E0
	private IEnumerator FriendGetList() { }

	// RVA: 0x1A8C868 Offset: 0x1A88868 VA: 0x1A8C868
	private void ChangeNoticeButtonLabel() { }

	// RVA: 0x1A8F140 Offset: 0x1A8B140 VA: 0x1A8F140
	public void OnTapScroll() { }

	// RVA: 0x1A8BED4 Offset: 0x1A87ED4 VA: 0x1A8BED4
	private void UpdateScrollElementActive() { }

	// RVA: 0x1A8F03C Offset: 0x1A8B03C VA: 0x1A8F03C
	private void OpenExpansionSlotWindow() { }

	// RVA: 0x1A8F150 Offset: 0x1A8B150 VA: 0x1A8F150
	private void CloseExpansionSlotWindow() { }

	// RVA: 0x1A8D36C Offset: 0x1A8936C VA: 0x1A8D36C
	private void UpdateFriendNumText() { }

	// RVA: 0x1A8F1B0 Offset: 0x1A8B1B0 VA: 0x1A8F1B0
	public void .ctor() { }

	// RVA: 0x1A8F264 Offset: 0x1A8B264 VA: 0x1A8F264
	private static void .cctor() { }
}
