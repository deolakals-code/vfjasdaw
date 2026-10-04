// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMiniMailSendMailElement : UIMiniMailManager // TypeDefIndex: 7473
{
	// Fields
	private PlayerDataManager playerDataManager; // 0x1B0
	private UIMiniMailSendMailElement.GetterMode getmode; // 0x1B8
	[SerializeField]
	private GameObject menuObject; // 0x1C0
	[SerializeField]
	private GameObject selectGetterObject; // 0x1C8
	[SerializeField]
	private GameObject sendMailObject; // 0x1D0
	[SerializeField]
	private UILabel[] MailListLabel; // 0x1D8
	[SerializeField]
	private UIImageButton[] MailListButton; // 0x1E0
	[SerializeField]
	private UILabel listTitleLabel; // 0x1E8
	[SerializeField]
	private UILabel sendMailTitleTapLabel; // 0x1F0
	[SerializeField]
	private UILabel sendMailTitleLabel; // 0x1F8
	[SerializeField]
	private UILabel sendMailTitlePrintLabel; // 0x200
	[SerializeField]
	private UILabel sendMailContentTapLabel; // 0x208
	[SerializeField]
	private UILabel sendMailContentLabel; // 0x210
	[SerializeField]
	private UILabel sendMailContentPrintLabel; // 0x218
	[SerializeField]
	private GameObject ListButton; // 0x220
	[SerializeField]
	private GameObject SendMailGetterButton; // 0x228
	[SerializeField]
	private UIImageButton SendMailButton; // 0x230
	[SerializeField]
	private UILabel SendMailButtonLabel; // 0x238
	[SerializeField]
	private UIScrollWindow sendScrollWindow; // 0x240
	[SerializeField]
	private GameObject sendEndObject; // 0x248
	[SerializeField]
	private UILabel sendEndLabel; // 0x250
	[SerializeField]
	private UIInput titleInput; // 0x258
	[SerializeField]
	private UIInput contentInput; // 0x260
	private List<FriendManager.FriendState> friendList; // 0x268
	private FriendManager friendManager; // 0x270
	private List<GuildMemberData> guildList; // 0x278
	private List<PartyMemberData> partyList; // 0x280
	private string titleText; // 0x288
	private string contentText; // 0x290
	private string getterNameText; // 0x298
	private int toAvatarUuid; // 0x2A0
	private UIBasePanelControl uiBasePanel; // 0x2A8
	private bool noTitleFlag; // 0x2B0
	private GameObject popWindowObj; // 0x2B8
	private UIPopWindow popWindow; // 0x2C0
	[CompilerGenerated]
	private bool <sendEndFlag>k__BackingField; // 0x2C8
	private MailSendType sendType; // 0x2CC

	// Properties
	public bool sendEndFlag { get; set; }
	public bool IsNGMailWindow { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1B61054 Offset: 0x1B5D054 VA: 0x1B61054
	public void set_sendEndFlag(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1B61060 Offset: 0x1B5D060 VA: 0x1B61060
	public bool get_sendEndFlag() { }

	// RVA: 0x1B58848 Offset: 0x1B54848 VA: 0x1B58848
	public bool get_IsNGMailWindow() { }

	// RVA: 0x1B588A8 Offset: 0x1B548A8 VA: 0x1B588A8
	public void CloseNGWindow() { }

	// RVA: 0x1B61068 Offset: 0x1B5D068 VA: 0x1B61068
	private void Start() { }

	// RVA: 0x1B610F8 Offset: 0x1B5D0F8 VA: 0x1B610F8
	private void onClose() { }

	// RVA: 0x1B56550 Offset: 0x1B52550 VA: 0x1B56550
	public void Initialize(UIBasePanelControl basePanel) { }

	// RVA: 0x1B58C74 Offset: 0x1B54C74 VA: 0x1B58C74
	public void InitUI() { }

	// RVA: 0x1B61248 Offset: 0x1B5D248 VA: 0x1B61248
	private void UiInit() { }

	[IteratorStateMachine(typeof(UIMiniMailSendMailElement.<GetReceiverList>d__50))]
	// RVA: 0x1B615E4 Offset: 0x1B5D5E4 VA: 0x1B615E4
	private IEnumerator GetReceiverList() { }

	// RVA: 0x1B61658 Offset: 0x1B5D658 VA: 0x1B61658
	private void CreateReceiverList() { }

	// RVA: 0x1B62678 Offset: 0x1B5E678 VA: 0x1B62678
	private void Update() { }

	// RVA: 0x1B628B8 Offset: 0x1B5E8B8 VA: 0x1B628B8
	private void OnParty() { }

	// RVA: 0x1B636D8 Offset: 0x1B5F6D8 VA: 0x1B636D8
	private void OnGuild() { }

	// RVA: 0x1B63B18 Offset: 0x1B5FB18 VA: 0x1B63B18
	private void OnFriend() { }

	// RVA: 0x1B63F50 Offset: 0x1B5FF50 VA: 0x1B63F50
	private void OnClick(int param) { }

	// RVA: 0x1B58970 Offset: 0x1B54970 VA: 0x1B58970
	public void ReturnSendMailListMenu() { }

	// RVA: 0x1B62C70 Offset: 0x1B5EC70 VA: 0x1B62C70
	private void GetterListText(int param, GameObject Obj) { }

	// RVA: 0x1B640A4 Offset: 0x1B600A4 VA: 0x1B640A4
	public void OnSubmitTitle() { }

	// RVA: 0x1B6415C Offset: 0x1B6015C VA: 0x1B6415C
	private void UpdateSendMailTitle() { }

	// RVA: 0x1B6429C Offset: 0x1B6029C VA: 0x1B6429C
	public void OnSubmitContent() { }

	// RVA: 0x1B64354 Offset: 0x1B60354 VA: 0x1B64354
	private void UpdateSendMailContent() { }

	// RVA: 0x1B64494 Offset: 0x1B60494 VA: 0x1B64494
	private void OnTitleLabelNone() { }

	// RVA: 0x1B64560 Offset: 0x1B60560 VA: 0x1B64560
	private void OnContentLabelNone() { }

	// RVA: 0x1B6462C Offset: 0x1B6062C VA: 0x1B6462C
	private void onSendMail() { }

	[IteratorStateMachine(typeof(UIMiniMailSendMailElement.<SendMail>d__66))]
	// RVA: 0x1B64938 Offset: 0x1B60938 VA: 0x1B64938
	private IEnumerator SendMail() { }

	// RVA: 0x1B649AC Offset: 0x1B609AC VA: 0x1B649AC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1B64AA0 Offset: 0x1B60AA0 VA: 0x1B64AA0
	private void <onSendMail>b__65_0() { }

	[DebuggerHidden]
	[CompilerGenerated]
	// RVA: 0x1B64ABC Offset: 0x1B60ABC VA: 0x1B64ABC
	private void <>n__0(Action pushFunction) { }
}
