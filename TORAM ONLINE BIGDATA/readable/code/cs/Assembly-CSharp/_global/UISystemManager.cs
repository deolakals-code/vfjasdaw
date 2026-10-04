// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UISystemManager : Singleton<UISystemManager> // TypeDefIndex: 9041
{
	// Fields
	[SerializeField]
	private Transform parantUIPanel; // 0x20
	[SerializeField]
	private Camera systemCamera; // 0x28
	private UITouchEffectManager touchManager; // 0x30
	[CompilerGenerated]
	private bool <IsActiveSystemWindow>k__BackingField; // 0x38
	[CompilerGenerated]
	private bool <IsLogoutSystemWindow>k__BackingField; // 0x39
	[CompilerGenerated]
	private bool <IsReconnectionFailureSystemWindow>k__BackingField; // 0x3A
	private Action okCallBack; // 0x40
	private Action yesCallBack; // 0x48
	private Action noCallBack; // 0x50
	[SerializeField]
	private GameObject systemWindow; // 0x58
	private InactiveTimer systemWindowInactiveTimer; // 0x60
	[SerializeField]
	private GameObject backPanel; // 0x68
	private InactiveTimer backPanelInactiveTimer; // 0x70
	[SerializeField]
	private UILabel titleLabel; // 0x78
	[SerializeField]
	private UILabel messageLabel; // 0x80
	[SerializeField]
	private GameObject okButton; // 0x88
	[SerializeField]
	private GameObject noButton; // 0x90
	[SerializeField]
	private GameObject yesButton; // 0x98
	[SerializeField]
	private GameObject openUrlButton; // 0xA0
	[SerializeField]
	private UILabel openUrlLabel; // 0xA8
	private string url; // 0xB0
	[SerializeField]
	private GameObject pcWorldPanel; // 0xB8
	[SerializeField]
	private UILabel selectWorldLabel; // 0xC0
	[SerializeField]
	private GameObject newsWindow; // 0xC8
	private InactiveTimer newsWindowInactiveTimer; // 0xD0
	[SerializeField]
	private GameObject newsPanelWindow; // 0xD8
	[SerializeField]
	private GameObject newsCloseButton; // 0xE0
	[SerializeField]
	private GameObject newsLoadinfLabel; // 0xE8
	[SerializeField]
	private GameObject newsWindowLeftTop; // 0xF0
	[SerializeField]
	private GameObject newsWindowRightBottom; // 0xF8
	[SerializeField]
	private GameObject inquiryLeftTop; // 0x100
	[SerializeField]
	private GameObject inquiryRightBottom; // 0x108
	[SerializeField]
	private GameObject newsLoadWebViewButton; // 0x110
	[SerializeField]
	private GameObject blogButton; // 0x118
	[SerializeField]
	private GameObject twitterButton; // 0x120
	[CompilerGenerated]
	private bool <IsActiveNewsWindow>k__BackingField; // 0x128
	[SerializeField]
	private GameObject cacheWindow; // 0x130
	[SerializeField]
	private GameObject cacheButton; // 0x138
	[SerializeField]
	private UIIruna2AnchorSimple titleCacheButton; // 0x140
	private UITutorialDialogPanel tutorialDialogPanel; // 0x148
	[SerializeField]
	private UISeverLimitTimer severLimitTimer; // 0x150
	private UIWaitLoginPanel waitLoginPanel; // 0x158

	// Properties
	public Camera SystemCamera { get; }
	public Transform ParantUIPanel { get; }
	public bool IsActiveSystemWindow { get; set; }
	public bool IsLogoutSystemWindow { get; set; }
	public bool IsReconnectionFailureSystemWindow { get; set; }
	public Transform SystemWindowTrans { get; }
	public bool IsActiveNewsWindow { get; set; }
	public bool IsTutorialDialogOpen { get; }
	public bool IsWaitLoginPanelOpen { get; }

	// Methods

	// RVA: 0x1E9B354 Offset: 0x1E97354 VA: 0x1E9B354
	public Camera get_SystemCamera() { }

	// RVA: 0x1E9B35C Offset: 0x1E9735C VA: 0x1E9B35C
	public Transform get_ParantUIPanel() { }

	// RVA: 0x1E9B364 Offset: 0x1E97364 VA: 0x1E9B364
	private void Awake() { }

	// RVA: 0x1E9B404 Offset: 0x1E97404 VA: 0x1E9B404
	private void OnLevelWasLoaded() { }

	// RVA: 0x1E9B448 Offset: 0x1E97448 VA: 0x1E9B448
	public void OnQuit() { }

	// RVA: 0x1E896E8 Offset: 0x1E856E8 VA: 0x1E896E8
	public void AddMissTouchEffect(int touchId) { }

	// RVA: 0x1E9B4B8 Offset: 0x1E974B8 VA: 0x1E9B4B8
	public void SetHideTapEffect(bool hideFlag) { }

	[CompilerGenerated]
	// RVA: 0x1E9B4D8 Offset: 0x1E974D8 VA: 0x1E9B4D8
	private void set_IsActiveSystemWindow(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1E9B4E4 Offset: 0x1E974E4 VA: 0x1E9B4E4
	public bool get_IsActiveSystemWindow() { }

	[CompilerGenerated]
	// RVA: 0x1E9B4EC Offset: 0x1E974EC VA: 0x1E9B4EC
	private void set_IsLogoutSystemWindow(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1E9B4F8 Offset: 0x1E974F8 VA: 0x1E9B4F8
	public bool get_IsLogoutSystemWindow() { }

	[CompilerGenerated]
	// RVA: 0x1E9B500 Offset: 0x1E97500 VA: 0x1E9B500
	private void set_IsReconnectionFailureSystemWindow(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1E9B50C Offset: 0x1E9750C VA: 0x1E9B50C
	public bool get_IsReconnectionFailureSystemWindow() { }

	// RVA: 0x1E9B514 Offset: 0x1E97514 VA: 0x1E9B514
	public Transform get_SystemWindowTrans() { }

	// RVA: 0x1E9B530 Offset: 0x1E97530 VA: 0x1E9B530
	public void SystemPCWorldPop() { }

	// RVA: 0x1E9B9F8 Offset: 0x1E979F8 VA: 0x1E9B9F8
	private void systemPCWorldClose() { }

	// RVA: 0x1E9BA18 Offset: 0x1E97A18 VA: 0x1E9BA18
	public void SystemWindowNoButton(string title, string message) { }

	// RVA: 0x1E9BC80 Offset: 0x1E97C80 VA: 0x1E9BC80
	public void SystemWindow(string title, string message, Action callBack) { }

	// RVA: 0x1E9BD30 Offset: 0x1E97D30 VA: 0x1E9BD30
	public void SystemWindow(string title, string message, string buttonText, Action callBack) { }

	// RVA: 0x1E9BE78 Offset: 0x1E97E78 VA: 0x1E9BE78
	public void SystemWindow(string title, string message, Action yesCallBackAction, Action noCallBackAction) { }

	// RVA: 0x1E9BAC4 Offset: 0x1E97AC4 VA: 0x1E9BAC4
	private void SystemWindow(string title, string message) { }

	// RVA: 0x1E9BF34 Offset: 0x1E97F34 VA: 0x1E9BF34
	public void SetLayoutVersionUp(string linkMessage, string linkUrl) { }

	// RVA: 0x1E9C05C Offset: 0x1E9805C VA: 0x1E9C05C
	public void SetLayOutBanReport() { }

	// RVA: 0x1E9C0C0 Offset: 0x1E980C0 VA: 0x1E9C0C0
	public void ResetLayout() { }

	// RVA: 0x1E9C15C Offset: 0x1E9815C VA: 0x1E9C15C
	public void CloseSystemWindow() { }

	// RVA: 0x1E9C24C Offset: 0x1E9824C VA: 0x1E9C24C
	public void OnPushButton(int sendParam) { }

	// RVA: 0x1E9C418 Offset: 0x1E98418 VA: 0x1E9C418
	public void OnOpenUrl() { }

	// RVA: 0x1E9C448 Offset: 0x1E98448 VA: 0x1E9C448
	public void EndApplicationPopUp() { }

	// RVA: 0x1E9C654 Offset: 0x1E98654 VA: 0x1E9C654
	public void ReconnectionFailurePopUp() { }

	[CompilerGenerated]
	// RVA: 0x1E9C7B4 Offset: 0x1E987B4 VA: 0x1E9C7B4
	private void set_IsActiveNewsWindow(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1E9C7C0 Offset: 0x1E987C0 VA: 0x1E9C7C0
	public bool get_IsActiveNewsWindow() { }

	[IteratorStateMachine(typeof(UISystemManager.<OpenNewsWindow>d__75))]
	// RVA: 0x1E9C7C8 Offset: 0x1E987C8 VA: 0x1E9C7C8
	public IEnumerator OpenNewsWindow() { }

	// RVA: 0x1E9C83C Offset: 0x1E9883C VA: 0x1E9C83C
	public void NewsLoadingEnd(string localizeKey) { }

	// RVA: 0x1E9CA8C Offset: 0x1E98A8C VA: 0x1E9CA8C
	public void SetWebViewManualMode(bool isManual) { }

	// RVA: 0x1E9CB24 Offset: 0x1E98B24 VA: 0x1E9CB24
	public bool CheckWebViewManualMode() { }

	// RVA: 0x1E9CB90 Offset: 0x1E98B90 VA: 0x1E9CB90
	private void onLoadWebView() { }

	// RVA: 0x1E9CC40 Offset: 0x1E98C40 VA: 0x1E9CC40
	public void CloseNewsWindow() { }

	// RVA: 0x1E9CDC4 Offset: 0x1E98DC4 VA: 0x1E9CDC4
	public Vector4 GetNewsWindowWebViewRect() { }

	// RVA: 0x1E9CEC0 Offset: 0x1E98EC0 VA: 0x1E9CEC0
	public Vector4 GetInquiryWindowWebViewRect() { }

	// RVA: 0x1E9CFBC Offset: 0x1E98FBC VA: 0x1E9CFBC
	private void onTwitter() { }

	// RVA: 0x1E9D0F8 Offset: 0x1E990F8 VA: 0x1E9D0F8
	private void onBlog() { }

	// RVA: 0x1E9D234 Offset: 0x1E99234 VA: 0x1E9D234
	public void OnClickNewsWindowEscape() { }

	// RVA: 0x1E9D244 Offset: 0x1E99244 VA: 0x1E9D244
	public void AccountHoldWindow(Action<bool> callback) { }

	[IteratorStateMachine(typeof(UISystemManager.<AccountHoldWindowThread>d__87))]
	// RVA: 0x1E9D264 Offset: 0x1E99264 VA: 0x1E9D264
	private IEnumerator AccountHoldWindowThread(Action<bool> callback) { }

	// RVA: 0x1E9D2D8 Offset: 0x1E992D8 VA: 0x1E9D2D8
	public void ShowCacheButton() { }

	// RVA: 0x1E9D43C Offset: 0x1E9943C VA: 0x1E9D43C
	public void HideCacheButton() { }

	// RVA: 0x1E9D4C4 Offset: 0x1E994C4 VA: 0x1E9D4C4
	public void OpenCacheWindow() { }

	// RVA: 0x1E9D590 Offset: 0x1E99590 VA: 0x1E9D590
	public void CloseCacheWindow() { }

	// RVA: 0x1E9D654 Offset: 0x1E99654 VA: 0x1E9D654
	private void OnReboot() { }

	// RVA: 0x1E9D6B0 Offset: 0x1E996B0 VA: 0x1E9D6B0
	private void OnCacheClear() { }

	[IteratorStateMachine(typeof(UISystemManager.<OnCacheClearReboot>d__97))]
	// RVA: 0x1E9D70C Offset: 0x1E9970C VA: 0x1E9D70C
	private IEnumerator OnCacheClearReboot() { }

	// RVA: 0x1E9D780 Offset: 0x1E99780 VA: 0x1E9D780
	public void FadeTitleCacheButton(bool fadeIn) { }

	// RVA: 0x1E9D868 Offset: 0x1E99868 VA: 0x1E9D868
	public bool get_IsTutorialDialogOpen() { }

	// RVA: 0x1E9D8F0 Offset: 0x1E998F0 VA: 0x1E9D8F0
	private void CreateTutorialDialog() { }

	// RVA: 0x1E9DAF8 Offset: 0x1E99AF8 VA: 0x1E9DAF8
	public void OpenParameterTutorialDialog() { }

	// RVA: 0x1E9DB1C Offset: 0x1E99B1C VA: 0x1E9DB1C
	public void CloseTutorialDialog() { }

	// RVA: 0x1E9DBB8 Offset: 0x1E99BB8 VA: 0x1E9DBB8
	public void ViewSeverLimitTime(bool maintenance, int time) { }

	// RVA: 0x1E9DD5C Offset: 0x1E99D5C VA: 0x1E9DD5C
	public bool get_IsWaitLoginPanelOpen() { }

	// RVA: 0x1E9DDE4 Offset: 0x1E99DE4 VA: 0x1E9DDE4
	private void CreateWaitLoginPanel() { }

	// RVA: 0x1E9DFEC Offset: 0x1E99FEC VA: 0x1E9DFEC
	public void OpenWaitLoginPanel(float waitTime) { }

	// RVA: 0x1E9E020 Offset: 0x1E9A020 VA: 0x1E9E020
	public void OpenWaitLoginPanel(int num) { }

	// RVA: 0x1E9E054 Offset: 0x1E9A054 VA: 0x1E9E054
	public void UpdateWaitLoginNum(int num) { }

	// RVA: 0x1E9E0EC Offset: 0x1E9A0EC VA: 0x1E9E0EC
	public void CloseWaitLoginPanel() { }

	// RVA: 0x1E9E184 Offset: 0x1E9A184 VA: 0x1E9E184
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1E9E1F8 Offset: 0x1E9A1F8 VA: 0x1E9E1F8
	private void <EndApplicationPopUp>b__57_1() { }
}
