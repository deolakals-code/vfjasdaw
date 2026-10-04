// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMiniMailManager : UIBasePanelControl // TypeDefIndex: 7459
{
	// Fields
	[CompilerGenerated]
	private MiniMailManager <miniMailManager>k__BackingField; // 0x58
	[CompilerGenerated]
	private MailCountType <mailCountType>k__BackingField; // 0x60
	[CompilerGenerated]
	private UIPopWindow <errPopWindow>k__BackingField; // 0x68
	[SerializeField]
	private GameObject titleWindowObject; // 0x70
	[SerializeField]
	private UILabel titleLabel; // 0x78
	[SerializeField]
	private GameObject mailTitleObject; // 0x80
	[SerializeField]
	public UILabel[] newMailCountLabel; // 0x88
	[SerializeField]
	public UILabel[] mailTitleNumberLabel; // 0x90
	[SerializeField]
	private UILabel noMailLabel; // 0x98
	[SerializeField]
	private UILabel itemCountLabel; // 0xA0
	[SerializeField]
	private GameObject addButtonObject; // 0xA8
	[SerializeField]
	private float buttonHeight; // 0xB0
	[SerializeField]
	private UIScrollWindow fullscreenWindow; // 0xB8
	[SerializeField]
	private GameObject fullscreenSubWindow; // 0xC0
	[SerializeField]
	private GameObject cameraObject; // 0xC8
	private GameObject scrollWindowObject; // 0xD0
	private UIScrollWindow scrollWindow; // 0xD8
	[SerializeField]
	private float elementHeight; // 0xE0
	[SerializeField]
	private GameObject addGetDeliveryElementObject; // 0xE8
	[SerializeField]
	private GameObject addGetMailElementObject; // 0xF0
	[SerializeField]
	private GameObject mailButtonObj; // 0xF8
	[SerializeField]
	private UIImageButton[] mailImageButton; // 0x100
	[SerializeField]
	private GameObject GetMailMenuObject; // 0x108
	[SerializeField]
	private UILabel[] getMailCountLabel; // 0x110
	[SerializeField]
	private UILabel[] getMailCheckLabel; // 0x118
	[SerializeField]
	private GameObject getMailContentViewObject; // 0x120
	[SerializeField]
	private UIMiniMailGetMailContentView getMailContentView; // 0x128
	[SerializeField]
	private GameObject sendMailMenuObject; // 0x130
	private bool mailUpFlag; // 0x138
	private float mailViewMoveSpeed; // 0x13C
	private int pageCount; // 0x140
	private MailWholeData nowMailData; // 0x148
	private List<MailWholeData> gotMailList; // 0x150
	private UIPopWindow popWindow; // 0x158
	private bool deleteMailFlag; // 0x160
	private List<MailHistoryData> historyList; // 0x168
	private MailCountType prevMailCountType; // 0x170
	[SerializeField]
	private UIMiniMailGetDeliveryListElement getDeliveryMailListView; // 0x178
	[SerializeField]
	private GameObject sendDeliveryMenuObject; // 0x180
	private MailWholeData nowDeliveryData; // 0x188
	private List<MailWholeData> gotDeliveryList; // 0x190
	private UIMiniMailManager.Mode mode; // 0x198
	private UIMiniMailManager.MailListState mailListState; // 0x19C
	private PlayerDataManager playerDataManager; // 0x1A0
	private const int pageMailMax = 25;
	private bool isOpenPresentBox; // 0x1A8
	private bool isMailBox; // 0x1A9
	private bool isLoadSuccess; // 0x1AA

	// Properties
	public MiniMailManager miniMailManager { get; set; }
	public MailCountType mailCountType { get; set; }
	public UIPopWindow errPopWindow { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1B54AD0 Offset: 0x1B50AD0 VA: 0x1B54AD0
	public MiniMailManager get_miniMailManager() { }

	[CompilerGenerated]
	// RVA: 0x1B54AD8 Offset: 0x1B50AD8 VA: 0x1B54AD8
	public void set_miniMailManager(MiniMailManager value) { }

	[CompilerGenerated]
	// RVA: 0x1B54AE0 Offset: 0x1B50AE0 VA: 0x1B54AE0
	public MailCountType get_mailCountType() { }

	[CompilerGenerated]
	// RVA: 0x1B54AE8 Offset: 0x1B50AE8 VA: 0x1B54AE8
	public void set_mailCountType(MailCountType value) { }

	[CompilerGenerated]
	// RVA: 0x1B54AF0 Offset: 0x1B50AF0 VA: 0x1B54AF0
	public UIPopWindow get_errPopWindow() { }

	[CompilerGenerated]
	// RVA: 0x1B54AF8 Offset: 0x1B50AF8 VA: 0x1B54AF8
	public void set_errPopWindow(UIPopWindow value) { }

	// RVA: 0x1B54B00 Offset: 0x1B50B00 VA: 0x1B54B00
	public void OpenPresentBox() { }

	// RVA: 0x1B54B0C Offset: 0x1B50B0C VA: 0x1B54B0C
	private void Start() { }

	// RVA: 0x1B54E78 Offset: 0x1B50E78 VA: 0x1B54E78
	private void Update() { }

	// RVA: 0x1B54CD8 Offset: 0x1B50CD8 VA: 0x1B54CD8
	private void initializeScrollWindow() { }

	// RVA: 0x1B54E58 Offset: 0x1B50E58 VA: 0x1B54E58
	private void initializeButtonList() { }

	[IteratorStateMachine(typeof(UIMiniMailManager.<InitButtonList>d__64))]
	// RVA: 0x1B555A0 Offset: 0x1B515A0 VA: 0x1B555A0
	private IEnumerator InitButtonList() { }

	// RVA: 0x1B55634 Offset: 0x1B51634 VA: 0x1B55634
	private void initializeMailList() { }

	// RVA: 0x1B56DE0 Offset: 0x1B52DE0 VA: 0x1B56DE0
	private void InitMailHistoryMailList() { }

	// RVA: 0x1B55198 Offset: 0x1B51198 VA: 0x1B55198
	private void onClick(int param) { }

	// RVA: 0x1B57498 Offset: 0x1B53498 VA: 0x1B57498
	private void onOpen(int param) { }

	// RVA: 0x1B57C78 Offset: 0x1B53C78 VA: 0x1B57C78
	private void onHover(int index) { }

	// RVA: 0x1B57DA8 Offset: 0x1B53DA8 VA: 0x1B57DA8
	private void onReturn() { }

	// RVA: 0x1B57DFC Offset: 0x1B53DFC VA: 0x1B57DFC
	private void onPopClose() { }

	// RVA: 0x1B57F20 Offset: 0x1B53F20 VA: 0x1B57F20
	private void ReturnMailMenu() { }

	[IteratorStateMachine(typeof(UIMiniMailManager.<ReturnMailMenuProccess>d__73))]
	// RVA: 0x1B57F64 Offset: 0x1B53F64 VA: 0x1B57F64
	private IEnumerator ReturnMailMenuProccess() { }

	// RVA: 0x1B57FF8 Offset: 0x1B53FF8 VA: 0x1B57FF8
	private void OnNewMailList() { }

	// RVA: 0x1B58124 Offset: 0x1B54124 VA: 0x1B58124
	private void OnProtectedMailList() { }

	// RVA: 0x1B58130 Offset: 0x1B54130 VA: 0x1B58130
	private void OnNotReadMailList() { }

	// RVA: 0x1B5813C Offset: 0x1B5413C VA: 0x1B5813C
	private void OnReadMailList() { }

	// RVA: 0x1B58148 Offset: 0x1B54148 VA: 0x1B58148
	private void OnAllMailList() { }

	// RVA: 0x1B58154 Offset: 0x1B54154 VA: 0x1B58154
	private void OnSentMailList() { }

	// RVA: 0x1B58004 Offset: 0x1B54004 VA: 0x1B58004
	private void OpenMailList(UIMiniMailManager.MailListState state, MailCountType type) { }

	[IteratorStateMachine(typeof(UIMiniMailManager.<GetMessageMailBox>d__81))]
	// RVA: 0x1B56D74 Offset: 0x1B52D74 VA: 0x1B56D74
	private IEnumerator GetMessageMailBox() { }

	[IteratorStateMachine(typeof(UIMiniMailManager.<ChangeNewToUnread>d__82))]
	// RVA: 0x1B581F4 Offset: 0x1B541F4 VA: 0x1B581F4
	private IEnumerator ChangeNewToUnread() { }

	// RVA: 0x1B58288 Offset: 0x1B54288 VA: 0x1B58288
	private void OnDeletedMail() { }

	// RVA: 0x1B58294 Offset: 0x1B54294 VA: 0x1B58294
	private void OnMailContentClose() { }

	[IteratorStateMachine(typeof(UIMiniMailManager.<MailHistoryCheck>d__85))]
	// RVA: 0x1B58160 Offset: 0x1B54160 VA: 0x1B58160
	private IEnumerator MailHistoryCheck() { }

	[IteratorStateMachine(typeof(UIMiniMailManager.<OpenMailCheckMenu>d__86))]
	// RVA: 0x1B56704 Offset: 0x1B52704 VA: 0x1B56704
	private IEnumerator OpenMailCheckMenu() { }

	[IteratorStateMachine(typeof(UIMiniMailManager.<LoadMailBodyData>d__87))]
	// RVA: 0x1B57BE8 Offset: 0x1B53BE8 VA: 0x1B57BE8
	private IEnumerator LoadMailBodyData(UIMiniMailGetMailContentView com, int param) { }

	// RVA: 0x1B56770 Offset: 0x1B52770 VA: 0x1B56770
	public void UpdateTitleMailCountText() { }

	// RVA: 0x1B583BC Offset: 0x1B543BC VA: 0x1B583BC
	private void OnSendDeliveryItemList() { }

	// RVA: 0x1B5847C Offset: 0x1B5447C VA: 0x1B5847C
	private void onGetItem() { }

	[IteratorStateMachine(typeof(UIMiniMailManager.<GetDeliveryItem>d__91))]
	// RVA: 0x1B586C0 Offset: 0x1B546C0 VA: 0x1B586C0
	private IEnumerator GetDeliveryItem() { }

	// RVA: 0x1B58754 Offset: 0x1B54754 VA: 0x1B58754
	private void OnSendMailMenu() { }

	// RVA: 0x1B58760 Offset: 0x1B54760 VA: 0x1B58760
	private void OnSendMailMemList() { }

	// RVA: 0x1B5876C Offset: 0x1B5476C VA: 0x1B5876C
	private void OnSendDeliveryMenu() { }

	// RVA: 0x1B58778 Offset: 0x1B54778 VA: 0x1B58778
	private void OnSendDeliveryMemList() { }

	// RVA: 0x1B58784 Offset: 0x1B54784 VA: 0x1B58784
	private void OnReturnSendMail() { }

	// RVA: 0x1B58C8C Offset: 0x1B54C8C VA: 0x1B58C8C
	private void OnReturnSendDelivery() { }

	// RVA: 0x1B59220 Offset: 0x1B55220 VA: 0x1B59220
	private void OnChange() { }

	// RVA: 0x1B592B0 Offset: 0x1B552B0 VA: 0x1B592B0
	private void OnNext() { }

	// RVA: 0x1B59390 Offset: 0x1B55390 VA: 0x1B59390
	private void OnPrev() { }

	// RVA: 0x1B5930C Offset: 0x1B5530C VA: 0x1B5930C
	private void UpdateMailList() { }

	// RVA: 0x1B59464 Offset: 0x1B55464 VA: 0x1B59464
	private void addButton(int index, string buttonText, int sendParam) { }

	// RVA: 0x1B593EC Offset: 0x1B553EC VA: 0x1B593EC
	private int MailStateUpdate(UIMiniMailManager.MailListState maiiList) { }

	// RVA: 0x1B59CDC Offset: 0x1B55CDC VA: 0x1B59CDC
	private void ReturnSendToTopMenu() { }

	[IteratorStateMachine(typeof(UIMiniMailManager.<LoadProccess>d__105))]
	// RVA: 0x1B59DF8 Offset: 0x1B55DF8 VA: 0x1B59DF8
	private IEnumerator LoadProccess() { }

	// RVA: 0x1B59E8C Offset: 0x1B55E8C VA: 0x1B59E8C
	public void .ctor() { }
}
