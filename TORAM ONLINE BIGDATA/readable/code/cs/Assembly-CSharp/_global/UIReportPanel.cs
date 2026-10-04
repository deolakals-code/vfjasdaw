// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIReportPanel : UIBasePanelControl, IUIReportFreeFlame // TypeDefIndex: 7663
{
	// Fields
	protected Dictionary<UIReportPanel.ReportType, UIReportPanel.ReportElementType[]> reportElementData; // 0x58
	protected Dictionary<UIReportPanel.ReportType, string> reportTypeLocalizeKey; // 0x60
	protected Dictionary<UIReportPanel.ReportType, Dictionary<UIReportPanel.ReportElementType, string>> reportElementTextOverrideKey; // 0x68
	protected Dictionary<UIReportPanel.ReportType, string> reportTypeToCategory; // 0x70
	protected Dictionary<UIReportPanel.ReportType, string> reportTypeToSpriteName; // 0x78
	[SerializeField]
	protected GameObject addElementDefault; // 0x80
	[SerializeField]
	private GameObject addElementMultiLine; // 0x88
	[SerializeField]
	private GameObject addElementShort; // 0x90
	[SerializeField]
	private GameObject addElementTwin; // 0x98
	[SerializeField]
	private GameObject addElementSentence; // 0xA0
	[SerializeField]
	private GameObject addElementCheckBox; // 0xA8
	[SerializeField]
	private GameObject reportWindowObject; // 0xB0
	[SerializeField]
	private UIScrollWindow scrollWindow; // 0xB8
	[SerializeField]
	private GameObject selectorObject; // 0xC0
	[SerializeField]
	private UIScrollWindow selectorScrollWindow; // 0xC8
	[SerializeField]
	private UILabel titleLabel; // 0xD0
	[SerializeField]
	private GameObject selectorElementObject; // 0xD8
	[SerializeField]
	private GameObject descriptLabel; // 0xE0
	[SerializeField]
	private GameObject descriptTitle; // 0xE8
	[SerializeField]
	private GameObject selectorElementPrisonObject; // 0xF0
	[SerializeField]
	private GameObject sendButtonObject; // 0xF8
	[SerializeField]
	private GameObject resultWindowObject; // 0x100
	[SerializeField]
	private UIScrollWindow resultScrollWindow; // 0x108
	[SerializeField]
	private GameObject resultSuccessElement; // 0x110
	[SerializeField]
	private GameObject resultFailureElement; // 0x118
	[SerializeField]
	private GameObject resultSuccessDomainElement; // 0x120
	[SerializeField]
	private UILabel result_send_title_label; // 0x128
	[SerializeField]
	private GameObject orbCheckPanel; // 0x130
	[SerializeField]
	private GameObject deleteImportantWindow; // 0x138
	[SerializeField]
	private UITextListEx deleteImportantTextList; // 0x140
	private bool isDeleteImportantOk; // 0x148
	private UIReportPanel.ReportType reportType; // 0x14C
	private List<UIReportElement> elementList; // 0x150
	private string term; // 0x158
	private float send_cancell_time; // 0x160
	private readonly float SendStopTime; // 0x164
	private bool isInitialzedSelector; // 0x168
	private bool IsExpectionOpen; // 0x169
	private bool isFromMail; // 0x16A
	private int fromMailUuid; // 0x16C
	private string fromMailAvatarName; // 0x170
	private bool isPrisonField; // 0x178

	// Methods

	// RVA: 0x1BD67A8 Offset: 0x1BD27A8 VA: 0x1BD67A8 Slot: 15
	protected virtual void Awake() { }

	// RVA: 0x1BD696C Offset: 0x1BD296C VA: 0x1BD696C
	private void Start() { }

	// RVA: 0x1BD6B48 Offset: 0x1BD2B48 VA: 0x1BD6B48
	public void OnSelectType(UIReportPanel.ReportType type) { }

	// RVA: 0x1BD6DC0 Offset: 0x1BD2DC0 VA: 0x1BD6DC0
	private void OpenReportWindow(Action backAction) { }

	// RVA: 0x1BD7BF0 Offset: 0x1BD3BF0 VA: 0x1BD7BF0
	public void ExpextionOpenType(UIReportPanel.ReportType _type) { }

	// RVA: 0x1BD7BFC Offset: 0x1BD3BFC VA: 0x1BD7BFC
	public void SetFromMailData(int uuid, string name) { }

	// RVA: 0x1BD75AC Offset: 0x1BD35AC VA: 0x1BD75AC
	private void InitalizeSentence() { }

	// RVA: 0x1BD6E44 Offset: 0x1BD2E44 VA: 0x1BD6E44
	public void InitializeReportWindow() { }

	// RVA: 0x1BD7C1C Offset: 0x1BD3C1C VA: 0x1BD7C1C Slot: 14
	public void relolcation_scroll_widget() { }

	// RVA: 0x1BD8020 Offset: 0x1BD4020 VA: 0x1BD8020
	private void initializeSelectorWindow() { }

	// RVA: 0x1BD8C70 Offset: 0x1BD4C70 VA: 0x1BD8C70 Slot: 16
	protected virtual Array GetReportTypeAll() { }

	// RVA: 0x1BD8954 Offset: 0x1BD4954 VA: 0x1BD8954
	private float add_height_of_label_to_the_scroll(GameObject _object, float _elementHeight) { }

	// RVA: 0x1BD8AFC Offset: 0x1BD4AFC VA: 0x1BD8AFC
	private float add_largest_parts_in_button_object(GameObject _button_obj, float _elementHeigth) { }

	// RVA: 0x1BD90C0 Offset: 0x1BD50C0 VA: 0x1BD90C0 Slot: 17
	protected virtual GameObject getElementObject(UIReportPanel.ReportElementType type) { }

	// RVA: 0x1BD910C Offset: 0x1BD510C VA: 0x1BD910C
	private void Close() { }

	// RVA: 0x1BD9180 Offset: 0x1BD5180 VA: 0x1BD9180
	private void Update() { }

	// RVA: 0x1BD91B4 Offset: 0x1BD51B4 VA: 0x1BD91B4
	private void onSendButton() { }

	// RVA: 0x1BD92C4 Offset: 0x1BD52C4 VA: 0x1BD92C4
	private bool is_can_send_status() { }

	// RVA: 0x1BD967C Offset: 0x1BD567C VA: 0x1BD967C
	private bool CheckInSpecifiedMailAddress(out byte returnCode) { }

	// RVA: 0x1BD9BE0 Offset: 0x1BD5BE0 VA: 0x1BD9BE0
	private bool IsRFCInvalid(string email) { }

	// RVA: 0x1BD92D4 Offset: 0x1BD52D4 VA: 0x1BD92D4
	private bool isSendable() { }

	// RVA: 0x1BD9444 Offset: 0x1BD5444 VA: 0x1BD9444
	private void scrollToEmptyElement() { }

	// RVA: 0x1BD9E58 Offset: 0x1BD5E58 VA: 0x1BD9E58
	private string getSendTitle() { }

	// RVA: 0x1BD9EE4 Offset: 0x1BD5EE4 VA: 0x1BD9EE4
	private string getSendText(UIReportPanel.ReportElementType type) { }

	// RVA: 0x1BDA04C Offset: 0x1BD604C VA: 0x1BDA04C
	private string getSendContent() { }

	[IteratorStateMachine(typeof(UIReportPanel.<sendWebAPI>d__69))]
	// RVA: 0x1BD9B6C Offset: 0x1BD5B6C VA: 0x1BD9B6C
	private IEnumerator sendWebAPI() { }

	// RVA: 0x1BDA310 Offset: 0x1BD6310 VA: 0x1BDA310
	private string create_post_data(out WWWForm _post_data, UIReportPanel.ReportType _report_type) { }

	// RVA: 0x1BDA97C Offset: 0x1BD697C VA: 0x1BDA97C
	private string trim_space(string _mes) { }

	// RVA: 0x1BDAC5C Offset: 0x1BD6C5C VA: 0x1BDAC5C
	private void display_result(bool _result, string _response_message, string _error_code) { }

	// RVA: 0x1BD9978 Offset: 0x1BD5978 VA: 0x1BD9978
	private void DisplayFailerResultPanel(string message) { }

	// RVA: 0x1BDB1D8 Offset: 0x1BD71D8 VA: 0x1BDB1D8
	private void send_result_message_display(bool _send_result, UILabel _title, GameObject _element) { }

	// RVA: 0x1BDB358 Offset: 0x1BD7358 VA: 0x1BDB358
	private string response_result_data_get(string _response_json_text) { }

	// RVA: 0x1BDB5AC Offset: 0x1BD75AC VA: 0x1BDB5AC
	private void onCloseButton() { }

	// RVA: 0x1BD6A64 Offset: 0x1BD2A64 VA: 0x1BD6A64
	private void getReportTerm() { }

	[IteratorStateMachine(typeof(UIReportPanel.<loading_now>d__78))]
	// RVA: 0x1BDB780 Offset: 0x1BD7780 VA: 0x1BDB780
	private IEnumerator loading_now() { }

	[IteratorStateMachine(typeof(UIReportPanel.<get_asset_bundle>d__79))]
	// RVA: 0x1BDB6DC Offset: 0x1BD76DC VA: 0x1BDB6DC
	private IEnumerator get_asset_bundle(string _file_name, string _bundle_file_path) { }

	// RVA: 0x1BDB7F4 Offset: 0x1BD77F4 VA: 0x1BDB7F4
	public void OnPress() { }

	// RVA: 0x1BDB800 Offset: 0x1BD7800 VA: 0x1BDB800
	public void OnClick() { }

	// RVA: 0x1BDB80C Offset: 0x1BD780C VA: 0x1BDB80C
	private void OnOrbCheck() { }

	// RVA: 0x1BDB868 Offset: 0x1BD7868 VA: 0x1BDB868
	private void OnOrbNextPanel() { }

	// RVA: 0x1BDB918 Offset: 0x1BD7918 VA: 0x1BDB918
	private void SelectOrbBuyPanel() { }

	// RVA: 0x1BDB948 Offset: 0x1BD7948 VA: 0x1BDB948
	public void OnDeleteImportantAgree() { }

	[IteratorStateMachine(typeof(UIReportPanel.<OpenAccountDeleteTextList>d__86))]
	// RVA: 0x1BD6D38 Offset: 0x1BD2D38 VA: 0x1BD6D38
	private IEnumerator OpenAccountDeleteTextList(Action<Action> backAction) { }

	// RVA: 0x1BDB97C Offset: 0x1BD797C VA: 0x1BDB97C
	public void .ctor() { }

	[CompilerGenerated]
	[DebuggerHidden]
	// RVA: 0x1BDC2E0 Offset: 0x1BD82E0 VA: 0x1BDC2E0
	private void <>n__0(Action pushFunction) { }

	[CompilerGenerated]
	// RVA: 0x1BDC2E8 Offset: 0x1BD82E8 VA: 0x1BDC2E8
	private void <OpenAccountDeleteTextList>b__86_0() { }
}
