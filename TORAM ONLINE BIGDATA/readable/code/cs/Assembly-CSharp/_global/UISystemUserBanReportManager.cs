// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UISystemUserBanReportManager : MonoBehaviour, IUIReportFreeFlame // TypeDefIndex: 9049
{
	// Fields
	private const string createPrefab = "UI/SystemUserBanReportPanel";
	[SerializeField]
	private UILabel titleLabel; // 0x20
	[SerializeField]
	private GameObject sendButtonObject; // 0x28
	[SerializeField]
	private GameObject reportWindowObject; // 0x30
	[SerializeField]
	private UIScrollWindow scrollWindow; // 0x38
	[SerializeField]
	private UIIruna2Viewport scrollViewport; // 0x40
	[SerializeField]
	private GameObject addElementDefault; // 0x48
	[SerializeField]
	private GameObject addElementMultiLine; // 0x50
	[SerializeField]
	private GameObject addElementShort; // 0x58
	[SerializeField]
	private GameObject addElementTwin; // 0x60
	[SerializeField]
	private GameObject addElementSentence; // 0x68
	[SerializeField]
	private UIIruna2Viewport resultScrollViewport; // 0x70
	[SerializeField]
	private GameObject resultWindowObject; // 0x78
	[SerializeField]
	private UIScrollWindow resultScrollWindow; // 0x80
	[SerializeField]
	private GameObject resultSuccessElement; // 0x88
	[SerializeField]
	private GameObject resultFailureElement; // 0x90
	[SerializeField]
	private GameObject resultSuccessDomainElement; // 0x98
	[SerializeField]
	private UILabel result_send_title_label; // 0xA0
	[SerializeField]
	private UILabel result_Text_label; // 0xA8
	[SerializeField]
	private UILabel result_send_Button_label; // 0xB0
	[SerializeField]
	private UILabel result_send_Domin_label; // 0xB8
	[SerializeField]
	private UILabel result_send_DominText_label; // 0xC0
	private List<UIReportElement> elementList; // 0xC8
	protected SystemTextManager systemTextManager; // 0xD0
	private string userName; // 0xD8
	private string region; // 0xE0
	private string banId; // 0xE8
	protected byte dataType; // 0xF0
	protected int randNum; // 0xF4

	// Methods

	// RVA: 0x1E9ED5C Offset: 0x1E9AD5C VA: 0x1E9ED5C
	public static void CreateBanReportPanel(SystemTextManager sys, string title, string text, string banId, string region, string userName) { }

	// RVA: 0x1E9EFFC Offset: 0x1E9AFFC VA: 0x1E9EFFC
	public static void CreateBanReportPanel(SystemTextManager sys, string title, string text, string paramData) { }

	// RVA: 0x1E9F218 Offset: 0x1E9B218 VA: 0x1E9F218
	public static void CreateBanReportBanPanel(SystemTextManager sys, string title, string text, string banId) { }

	// RVA: 0x1E9F44C Offset: 0x1E9B44C VA: 0x1E9F44C
	public static void CreateRegionReportPanel(SystemTextManager sys, string title, string text) { }

	// RVA: 0x1E9F5D0 Offset: 0x1E9B5D0 VA: 0x1E9F5D0
	private void Initialize() { }

	// RVA: 0x1E9F8B8 Offset: 0x1E9B8B8 VA: 0x1E9F8B8
	private void Initialize(string banId) { }

	// RVA: 0x1E9F630 Offset: 0x1E9B630 VA: 0x1E9F630
	private void Initialize(string banId, string region, string userName) { }

	// RVA: 0x1E9F924 Offset: 0x1E9B924 VA: 0x1E9F924 Slot: 5
	protected virtual UIReportPanel.ReportElementType[] getTempElement() { }

	// RVA: 0x1E9F994 Offset: 0x1E9B994 VA: 0x1E9F994 Slot: 6
	protected virtual UIReportElement AddElement(GameObject obj, UIReportPanel.ReportElementType type, string userName, string banId, string deviceDefaultWord) { }

	// RVA: 0x1E9FA50 Offset: 0x1E9BA50 VA: 0x1E9FA50
	protected void SetBanText(UIReportPanel.ReportElementType type, UIReportElement element) { }

	// RVA: 0x1E9FBE8 Offset: 0x1E9BBE8 VA: 0x1E9FBE8
	protected void UpdateRandomInputNum(bool isInit, UIReportElement element, string color) { }

	// RVA: 0x1E9FD08 Offset: 0x1E9BD08 VA: 0x1E9FD08
	private GameObject getElementObject(UIReportPanel.ReportElementType type) { }

	// RVA: 0x1E9FD38 Offset: 0x1E9BD38 VA: 0x1E9FD38
	private void scrollToEmptyElement() { }

	// RVA: 0x1E9FF70 Offset: 0x1E9BF70 VA: 0x1E9FF70
	private string response_result_data_get(string _response_json_text) { }

	// RVA: 0x1EA01C4 Offset: 0x1E9C1C4 VA: 0x1EA01C4
	private string getSendText(UIReportPanel.ReportElementType type) { }

	// RVA: 0x1EA032C Offset: 0x1E9C32C VA: 0x1EA032C
	private string getSendContent() { }

	// RVA: 0x1EA05F4 Offset: 0x1E9C5F4 VA: 0x1EA05F4
	private bool CheckCashText(string asobimoId, string address, string content) { }

	[IteratorStateMachine(typeof(UISystemUserBanReportManager.<sendWebAPI>d__47))]
	// RVA: 0x1EA0730 Offset: 0x1E9C730 VA: 0x1EA0730
	private IEnumerator sendWebAPI() { }

	// RVA: 0x1EA07C4 Offset: 0x1E9C7C4 VA: 0x1EA07C4
	private void display_result(bool _result, string _response_message, string _error_code) { }

	// RVA: 0x1EA0DF8 Offset: 0x1E9CDF8 VA: 0x1EA0DF8
	private void DisplayFailerResultPanel(string message) { }

	// RVA: 0x1EA0D1C Offset: 0x1E9CD1C VA: 0x1EA0D1C
	private void send_result_message_display(bool _send_result, UILabel _title, GameObject _element) { }

	// RVA: 0x1EA0FE8 Offset: 0x1E9CFE8 VA: 0x1EA0FE8 Slot: 4
	public void relolcation_scroll_widget() { }

	// RVA: 0x1EA13F0 Offset: 0x1E9D3F0 VA: 0x1EA13F0
	public void OpenReportPanel() { }

	// RVA: 0x1EA1AC0 Offset: 0x1E9DAC0 VA: 0x1EA1AC0
	public void OnClick_SendReport() { }

	// RVA: 0x1EA20B8 Offset: 0x1E9E0B8 VA: 0x1EA20B8
	public void OnClick_CloseButton() { }

	// RVA: 0x1EA2160 Offset: 0x1E9E160 VA: 0x1EA2160
	public void .ctor() { }
}
