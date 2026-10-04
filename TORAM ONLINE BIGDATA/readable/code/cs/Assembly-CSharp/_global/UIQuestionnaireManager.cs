// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIQuestionnaireManager : UIBasePanelControl, WebView.WebViewListener // TypeDefIndex: 8210
{
	// Fields
	[SerializeField]
	private GameObject leftTopAnchor; // 0x58
	[SerializeField]
	private GameObject rightBottomAnchor; // 0x60
	private GameObject webViewObject; // 0x68
	private bool updateFlag; // 0x70
	private WebView webView; // 0x78

	// Methods

	[IteratorStateMachine(typeof(UIQuestionnaireManager.<Start>d__5))]
	// RVA: 0x1CF4B18 Offset: 0x1CF0B18 VA: 0x1CF4B18
	private IEnumerator Start() { }

	// RVA: 0x1CF4B8C Offset: 0x1CF0B8C VA: 0x1CF4B8C
	public Vector4 GetWebViewRect() { }

	// RVA: 0x1CF4D04 Offset: 0x1CF0D04 VA: 0x1CF4D04
	private void onClose() { }

	// RVA: 0x1CF55B4 Offset: 0x1CF15B4 VA: 0x1CF55B4
	private void onBack() { }

	// RVA: 0x1CF56DC Offset: 0x1CF16DC VA: 0x1CF56DC
	private void OnDestroy() { }

	// RVA: 0x1CF57D8 Offset: 0x1CF17D8 VA: 0x1CF57D8 Slot: 14
	public void OnShouldOverrideLoading(string url) { }

	// RVA: 0x1CF5848 Offset: 0x1CF1848 VA: 0x1CF5848 Slot: 15
	public void OnPageStarted() { }

	// RVA: 0x1CF58B8 Offset: 0x1CF18B8 VA: 0x1CF58B8 Slot: 16
	public void OnPageFinished() { }

	// RVA: 0x1CF5924 Offset: 0x1CF1924 VA: 0x1CF5924 Slot: 17
	public void OnReceivedError() { }

	// RVA: 0x1CF5990 Offset: 0x1CF1990 VA: 0x1CF5990 Slot: 18
	public void OnTouchEvent() { }

	// RVA: 0x1CF5A54 Offset: 0x1CF1A54 VA: 0x1CF5A54
	public void .ctor() { }

	[DebuggerHidden]
	[CompilerGenerated]
	// RVA: 0x1CF5A5C Offset: 0x1CF1A5C VA: 0x1CF5A5C
	private void <>n__0(Action pushFunction) { }
}
