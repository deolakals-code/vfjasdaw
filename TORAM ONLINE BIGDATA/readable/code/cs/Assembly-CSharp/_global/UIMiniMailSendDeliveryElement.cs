// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMiniMailSendDeliveryElement : UIMiniMailManager // TypeDefIndex: 7466
{
	// Fields
	private PlayerDataManager playerDataManager; // 0x1B0
	private UIMiniMailSendDeliveryElement.GetterMode getmode; // 0x1B8
	[SerializeField]
	private GameObject mainWindowObject; // 0x1C0
	[SerializeField]
	private GameObject menuObject; // 0x1C8
	[SerializeField]
	private GameObject selectGetterObject; // 0x1D0
	[SerializeField]
	private GameObject sendDeliveryObject; // 0x1D8
	[SerializeField]
	private GameObject selectItemObject; // 0x1E0
	[SerializeField]
	private UILabel[] DeliveryListLabel; // 0x1E8
	[SerializeField]
	private UIImageButton[] DeliveryListButton; // 0x1F0
	[SerializeField]
	private UILabel listTitleLabel; // 0x1F8
	[SerializeField]
	private UILabel sendDeliveryTitleTapLabel; // 0x200
	[SerializeField]
	private UILabel sendDeliveryTitleLabel; // 0x208
	[SerializeField]
	private UILabel sendDeliveryTitlePrintLabel; // 0x210
	[SerializeField]
	private UILabel sendDeliveryContentTapLabel; // 0x218
	[SerializeField]
	private UILabel sendDeliveryContentLabel; // 0x220
	[SerializeField]
	private UIIcon sendDeliveryContentIcon; // 0x228
	[SerializeField]
	private GameObject ListButton; // 0x230
	[SerializeField]
	private GameObject SendDeliveryGetterButton; // 0x238
	[SerializeField]
	private UIImageButton SendDeliveryButton; // 0x240
	[SerializeField]
	private UILabel SendDeliveryButtonLabel; // 0x248
	[SerializeField]
	private UIScrollWindow selectGetterScrollWindow; // 0x250
	[SerializeField]
	private UIScrollWindow sendItemPropScrollWindow; // 0x258
	private Camera scrollCamera; // 0x260
	[SerializeField]
	private GameObject itemIconObject; // 0x268
	[SerializeField]
	private UIImageButton itemConfirmButton; // 0x270
	[SerializeField]
	private UILabel itemPropatyLabel; // 0x278
	[SerializeField]
	private UILabel playerTextLabel; // 0x280
	[SerializeField]
	private UIItemProperty property; // 0x288
	[SerializeField]
	private UIIconLabel iconLabel; // 0x290
	[SerializeField]
	private GameObject sendEndObject; // 0x298
	[SerializeField]
	private UILabel sendEndLabel; // 0x2A0
	private ItemSelector itemSelector; // 0x2A8
	private ItemData selectedItemData; // 0x2B0
	private int itemId; // 0x2B8
	private int itemCount; // 0x2BC
	public List<Pair<int, int>> SetItemList; // 0x2C0
	[CompilerGenerated]
	private bool <sendEndFlag>k__BackingField; // 0x2C8
	private List<FriendManager.FriendState> friendList; // 0x2D0
	private FriendManager friendManager; // 0x2D8
	private List<GuildMemberData> guildList; // 0x2E0
	private List<PartyMemberData> partyList; // 0x2E8
	private string titleText; // 0x2F0
	private string contentText; // 0x2F8
	private ItemTextManager itemTextManager; // 0x300
	private string getterNameText; // 0x308
	private int toAvatarUuid; // 0x310
	private int itemUuid; // 0x314
	private UIBasePanelControl uiBasePanel; // 0x318
	private bool noTitleFlag; // 0x320
	private MailSendType sendType; // 0x324

	// Properties
	public bool sendEndFlag { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1B5BFD8 Offset: 0x1B57FD8 VA: 0x1B5BFD8
	public void set_sendEndFlag(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1B5BFE4 Offset: 0x1B57FE4 VA: 0x1B5BFE4
	public bool get_sendEndFlag() { }

	// RVA: 0x1B5BFEC Offset: 0x1B57FEC VA: 0x1B5BFEC
	private void Start() { }

	// RVA: 0x1B5C07C Offset: 0x1B5807C VA: 0x1B5C07C
	private void onClose() { }

	// RVA: 0x1B56B04 Offset: 0x1B52B04 VA: 0x1B56B04
	public void Initialize(UIBasePanelControl control) { }

	// RVA: 0x1B59208 Offset: 0x1B55208 VA: 0x1B59208
	public void InitUI() { }

	// RVA: 0x1B5C140 Offset: 0x1B58140 VA: 0x1B5C140
	private void UiInit() { }

	[IteratorStateMachine(typeof(UIMiniMailSendDeliveryElement.<GetReceiverList>d__60))]
	// RVA: 0x1B5C57C Offset: 0x1B5857C VA: 0x1B5C57C
	private IEnumerator GetReceiverList() { }

	// RVA: 0x1B5C5E8 Offset: 0x1B585E8 VA: 0x1B5C5E8
	private void CreateReceiverList() { }

	// RVA: 0x1B5D628 Offset: 0x1B59628 VA: 0x1B5D628
	private void Update() { }

	// RVA: 0x1B5D880 Offset: 0x1B59880 VA: 0x1B5D880
	private void OnParty() { }

	// RVA: 0x1B5E6AC Offset: 0x1B5A6AC VA: 0x1B5E6AC
	private void OnGuild() { }

	// RVA: 0x1B5EAF4 Offset: 0x1B5AAF4 VA: 0x1B5EAF4
	private void OnFriend() { }

	// RVA: 0x1B5EF38 Offset: 0x1B5AF38 VA: 0x1B5EF38
	private void OnClick(int param) { }

	// RVA: 0x1B58D5C Offset: 0x1B54D5C VA: 0x1B58D5C
	public void ReturnSendDeliveryListMenu() { }

	// RVA: 0x1B5DC44 Offset: 0x1B59C44 VA: 0x1B5DC44
	private void GetterListText(int param, GameObject Obj) { }

	// RVA: 0x1B5F200 Offset: 0x1B5B200 VA: 0x1B5F200
	private void OnSubmitTitle() { }

	// RVA: 0x1B5F2B8 Offset: 0x1B5B2B8 VA: 0x1B5F2B8
	private void UpdateSendDeliveryTitle() { }

	// RVA: 0x1B5F3F8 Offset: 0x1B5B3F8 VA: 0x1B5F3F8
	private void OnTitleLabelNone() { }

	// RVA: 0x1B5F498 Offset: 0x1B5B498 VA: 0x1B5F498
	private void OnContentLabelNone() { }

	// RVA: 0x1B5F538 Offset: 0x1B5B538 VA: 0x1B5F538
	private void onSendDelivery() { }

	[IteratorStateMachine(typeof(UIMiniMailSendDeliveryElement.<SendDelivery>d__74))]
	// RVA: 0x1B5F558 Offset: 0x1B5B558 VA: 0x1B5F558
	private IEnumerator SendDelivery() { }

	// RVA: 0x1B5F5EC Offset: 0x1B5B5EC VA: 0x1B5F5EC
	private void OnItemMenuOpen() { }

	// RVA: 0x1B5FC9C Offset: 0x1B5BC9C VA: 0x1B5FC9C
	private void onItemSelected(ItemData item, int count) { }

	// RVA: 0x1B5FB04 Offset: 0x1B5BB04 VA: 0x1B5FB04
	private void OnResetSelectItem() { }

	// RVA: 0x1B5F0E8 Offset: 0x1B5B0E8 VA: 0x1B5F0E8
	private void OnItemMenuDelete() { }

	// RVA: 0x1B601C8 Offset: 0x1B5C1C8 VA: 0x1B601C8
	public void ReturnMailMain() { }

	// RVA: 0x1B59168 Offset: 0x1B55168 VA: 0x1B59168
	public void ReturnLeftTopButtonMailMain() { }

	// RVA: 0x1B5FC3C Offset: 0x1B5BC3C VA: 0x1B5FC3C
	private void ActiveButton() { }

	// RVA: 0x1B60364 Offset: 0x1B5C364 VA: 0x1B60364
	private void NonActiveButton() { }

	// RVA: 0x1B60388 Offset: 0x1B5C388 VA: 0x1B60388
	public void .ctor() { }

	[CompilerGenerated]
	[DebuggerHidden]
	// RVA: 0x1B604D0 Offset: 0x1B5C4D0 VA: 0x1B604D0
	private void <>n__0(Action pushFunction) { }

	[CompilerGenerated]
	// RVA: 0x1B604D8 Offset: 0x1B5C4D8 VA: 0x1B604D8
	private bool <OnItemMenuOpen>b__75_0(ItemData it) { }
}
