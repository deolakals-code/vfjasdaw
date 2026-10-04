// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMiniMailGetMailContentView : UIMiniMailManager // TypeDefIndex: 7444
{
	// Fields
	private PlayerDataManager playerData; // 0x1B0
	[SerializeField]
	private UILabel nameLabel; // 0x1B8
	[SerializeField]
	private UILabel getDateLabel; // 0x1C0
	[SerializeField]
	private UILabel mailTitleLabel; // 0x1C8
	[SerializeField]
	private UILabel stateLabel; // 0x1D0
	[SerializeField]
	private UISprite stateIcon; // 0x1D8
	[SerializeField]
	private UISprite stateMailIcon; // 0x1E0
	[SerializeField]
	private GameObject openButton; // 0x1E8
	[SerializeField]
	private UILabel openButtonLabel; // 0x1F0
	[SerializeField]
	private UISprite openButtonIcon; // 0x1F8
	[SerializeField]
	private UISprite[] imageButtonIcon; // 0x200
	[SerializeField]
	private UIImageButton[] menuButton; // 0x208
	[SerializeField]
	private UILabel mainText; // 0x210
	[SerializeField]
	private GameObject mainTextBackPanel; // 0x218
	[SerializeField]
	private GameObject[] frameBarObject; // 0x220
	[SerializeField]
	private GameObject frameUnderObject; // 0x228
	[SerializeField]
	private GameObject backPanel; // 0x230
	[SerializeField]
	private GameObject coverPanelObject; // 0x238
	[SerializeField]
	private UILabel lastCheckDeleteLabel; // 0x240
	[SerializeField]
	private UILabel textMessageLabel; // 0x248
	[SerializeField]
	private GameObject mailViewObject; // 0x250
	[SerializeField]
	private GameObject ReturnMailObject; // 0x258
	[SerializeField]
	private UILabel sendMailTitleTapLabel; // 0x260
	[SerializeField]
	private UILabel sendMailTitleLabel; // 0x268
	[SerializeField]
	private UILabel sendMailTitlePrintLabel; // 0x270
	[SerializeField]
	private UILabel sendMailContentTapLabel; // 0x278
	[SerializeField]
	private UILabel sendMailContentLabel; // 0x280
	[SerializeField]
	private UILabel sendMailContentPrintLabel; // 0x288
	[SerializeField]
	private UIImageButton SendMailButton; // 0x290
	[SerializeField]
	private UILabel SendMailButtonLabel; // 0x298
	[SerializeField]
	private UILabel getterNameLabel; // 0x2A0
	[SerializeField]
	private GameObject sendEndObject; // 0x2A8
	[SerializeField]
	private UILabel sendEndLabel; // 0x2B0
	[SerializeField]
	private GameObject nameButtonBackObj; // 0x2B8
	[SerializeField]
	private UIInput titleInput; // 0x2C0
	[SerializeField]
	private UIInput contentInput; // 0x2C8
	[SerializeField]
	private GameObject noMemberPanel; // 0x2D0
	[SerializeField]
	private UILabel noMemberNameLabel; // 0x2D8
	private bool frameSizeChangeFlag; // 0x2E0
	private bool protectedFlag; // 0x2E1
	private bool deleteFlag; // 0x2E2
	private int mailType; // 0x2E4
	private string titleText; // 0x2E8
	private string contentText; // 0x2F0
	private float ScaleChangeSpeed; // 0x2F8
	private MailBodyData getMailData; // 0x300
	private int toAvatarUuid; // 0x308
	private long[] uniqueId; // 0x310
	private UIBasePanelControl uiBasePanelControl; // 0x318
	private bool isHistory; // 0x320
	private bool noTitleFlag; // 0x321
	private GameObject popWindowObj; // 0x328
	private UIPopWindow popWindow; // 0x330

	// Properties
	private PlayerDataManager playerDataManager { get; }

	// Methods

	// RVA: 0x1B4FB80 Offset: 0x1B4BB80 VA: 0x1B4FB80
	private PlayerDataManager get_playerDataManager() { }

	// RVA: 0x1B4FC08 Offset: 0x1B4BC08 VA: 0x1B4FC08
	private void Awake() { }

	// RVA: 0x1B4FCF0 Offset: 0x1B4BCF0 VA: 0x1B4FCF0
	private void Start() { }

	// RVA: 0x1B4FDC0 Offset: 0x1B4BDC0 VA: 0x1B4FDC0
	private void onClose() { }

	// RVA: 0x1B4FF10 Offset: 0x1B4BF10 VA: 0x1B4FF10
	public void Initialize(MailWholeData mailData, MailBodyData bodyData, UIBasePanelControl control) { }

	// RVA: 0x1B5089C Offset: 0x1B4C89C VA: 0x1B5089C
	public void Initialize(MailHistoryData mailData, UIBasePanelControl control) { }

	// RVA: 0x1B4FFC0 Offset: 0x1B4BFC0 VA: 0x1B4FFC0
	private void SetMailText(int uuid, byte state, string name, string title, string body, DateTime dateTime) { }

	// RVA: 0x1B50920 Offset: 0x1B4C920 VA: 0x1B50920
	private void Update() { }

	// RVA: 0x1B51078 Offset: 0x1B4D078 VA: 0x1B51078
	public void FrameSpreadFlag() { }

	[IteratorStateMachine(typeof(UIMiniMailGetMailContentView.<ChangeMailStateToRead>d__64))]
	// RVA: 0x1B5100C Offset: 0x1B4D00C VA: 0x1B5100C
	private IEnumerator ChangeMailStateToRead() { }

	// RVA: 0x1B50EC8 Offset: 0x1B4CEC8 VA: 0x1B50EC8
	private void OpenHistoryMail() { }

	// RVA: 0x1B51404 Offset: 0x1B4D404 VA: 0x1B51404
	private void onReturnMail() { }

	// RVA: 0x1B51544 Offset: 0x1B4D544 VA: 0x1B51544
	private void OpenReplyPanel() { }

	// RVA: 0x1B5168C Offset: 0x1B4D68C VA: 0x1B5168C
	private void OnPopUpClose() { }

	// RVA: 0x1B5166C Offset: 0x1B4D66C VA: 0x1B5166C
	private void ClosePopWindow() { }

	// RVA: 0x1B51728 Offset: 0x1B4D728 VA: 0x1B51728
	private void onProtected() { }

	[IteratorStateMachine(typeof(UIMiniMailGetMailContentView.<ProtectedMail>d__71))]
	// RVA: 0x1B51748 Offset: 0x1B4D748 VA: 0x1B51748
	private IEnumerator ProtectedMail() { }

	// RVA: 0x1B510AC Offset: 0x1B4D0AC VA: 0x1B510AC
	private void ProtectedLabels() { }

	// RVA: 0x1B517DC Offset: 0x1B4D7DC VA: 0x1B517DC
	private void onBeforeDelete() { }

	// RVA: 0x1B51990 Offset: 0x1B4D990 VA: 0x1B51990
	public void OnSubmitTitle() { }

	[IteratorStateMachine(typeof(UIMiniMailGetMailContentView.<UpdateSendMailTitle>d__75))]
	// RVA: 0x1B51A58 Offset: 0x1B4DA58 VA: 0x1B51A58
	private IEnumerator UpdateSendMailTitle() { }

	// RVA: 0x1B51ACC Offset: 0x1B4DACC VA: 0x1B51ACC
	public void OnSubmitContent() { }

	[IteratorStateMachine(typeof(UIMiniMailGetMailContentView.<UpdateSendMailContent>d__77))]
	// RVA: 0x1B51B94 Offset: 0x1B4DB94 VA: 0x1B51B94
	private IEnumerator UpdateSendMailContent() { }

	// RVA: 0x1B51C08 Offset: 0x1B4DC08 VA: 0x1B51C08
	private void OnTitleLabelNone() { }

	// RVA: 0x1B51CD4 Offset: 0x1B4DCD4 VA: 0x1B51CD4
	private void OnContentLabelNone() { }

	// RVA: 0x1B51DA0 Offset: 0x1B4DDA0 VA: 0x1B51DA0
	private void onSendMail() { }

	[IteratorStateMachine(typeof(UIMiniMailGetMailContentView.<SendMail>d__81))]
	// RVA: 0x1B520D8 Offset: 0x1B4E0D8 VA: 0x1B520D8
	private IEnumerator SendMail() { }

	// RVA: 0x1B5214C Offset: 0x1B4E14C VA: 0x1B5214C
	private void OnName() { }

	// RVA: 0x1B522F0 Offset: 0x1B4E2F0 VA: 0x1B522F0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1B52438 Offset: 0x1B4E438 VA: 0x1B52438
	private void <onSendMail>b__80_0() { }
}
