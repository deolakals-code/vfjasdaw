// Assembly: Assembly-CSharp-firstpass.dll
// Namespace: 
public class WebView : MonoBehaviour // TypeDefIndex: 17096
{
	// Fields
	private WebViewPluginObject webView; // 0x20
	[SerializeField]
	private bool absoluteRect; // 0x28
	[SerializeField]
	private Vector2 position; // 0x2C
	[SerializeField]
	private Vector2 size; // 0x34
	private Vector2 viewPosition; // 0x3C
	private Vector2 viewSize; // 0x44
	private WebView.WebViewListener listener; // 0x50

	// Properties
	public bool AbsoluteRect { get; set; }
	public Vector2 Position { get; set; }
	public Vector2 Size { get; set; }
	public Vector4 Rect { get; set; }

	// Methods

	// RVA: 0x17017B0 Offset: 0x16FD7B0 VA: 0x17017B0
	public bool get_AbsoluteRect() { }

	// RVA: 0x17017B8 Offset: 0x16FD7B8 VA: 0x17017B8
	public void set_AbsoluteRect(bool value) { }

	// RVA: 0x1701A28 Offset: 0x16FDA28 VA: 0x1701A28
	public Vector2 get_Position() { }

	// RVA: 0x1701A30 Offset: 0x16FDA30 VA: 0x1701A30
	public void set_Position(Vector2 value) { }

	// RVA: 0x1701A84 Offset: 0x16FDA84 VA: 0x1701A84
	public Vector2 get_Size() { }

	// RVA: 0x1701A8C Offset: 0x16FDA8C VA: 0x1701A8C
	public void set_Size(Vector2 value) { }

	// RVA: 0x1701AE8 Offset: 0x16FDAE8 VA: 0x1701AE8
	public Vector4 get_Rect() { }

	// RVA: 0x1701AF4 Offset: 0x16FDAF4 VA: 0x1701AF4
	public void set_Rect(Vector4 value) { }

	// RVA: 0x1701B48 Offset: 0x16FDB48 VA: 0x1701B48
	private void Awake() { }

	// RVA: 0x1701EF4 Offset: 0x16FDEF4 VA: 0x1701EF4
	private void OnDestroy() { }

	// RVA: 0x170200C Offset: 0x16FE00C VA: 0x170200C
	public void SetListener(WebView.WebViewListener listener) { }

	// RVA: 0x17018F0 Offset: 0x16FD8F0 VA: 0x17018F0
	private void setRect(int x, int y, int width, int height) { }

	// RVA: 0x1701924 Offset: 0x16FD924 VA: 0x1701924
	private void setRectRate(float x, float y, float width, float height) { }

	// RVA: 0x170220C Offset: 0x16FE20C VA: 0x170220C
	public void SetVisibility(bool visibility) { }

	// RVA: 0x1702334 Offset: 0x16FE334 VA: 0x1702334
	public void LoadURL(string url) { }

	// RVA: 0x170241C Offset: 0x16FE41C VA: 0x170241C
	public void LoadData(string data, string mime, string encording) { }

	// RVA: 0x170257C Offset: 0x16FE57C VA: 0x170257C
	public void PostURL(string url, byte[] postData) { }

	// RVA: 0x170269C Offset: 0x16FE69C VA: 0x170269C
	public void GoBackPage() { }

	// RVA: 0x1702770 Offset: 0x16FE770 VA: 0x1702770
	public void GoForwardPage() { }

	// RVA: 0x1702844 Offset: 0x16FE844 VA: 0x1702844
	public void ReloadPage() { }

	// RVA: 0x1702918 Offset: 0x16FE918 VA: 0x1702918
	public void EnableNavigationBar() { }

	// RVA: 0x17029EC Offset: 0x16FE9EC VA: 0x17029EC
	public void OnShouldOverrideLoading(string url) { }

	// RVA: 0x1702AD8 Offset: 0x16FEAD8 VA: 0x1702AD8
	public void OnPageStarted(string msg) { }

	// RVA: 0x1702B84 Offset: 0x16FEB84 VA: 0x1702B84
	public void OnPageFinished(string msg) { }

	// RVA: 0x1702C44 Offset: 0x16FEC44 VA: 0x1702C44
	public void OnReceivedError(string msg) { }

	// RVA: 0x1702CF0 Offset: 0x16FECF0 VA: 0x1702CF0
	public void OnTouchEvent() { }

	// RVA: 0x1702D9C Offset: 0x16FED9C VA: 0x1702D9C
	public void .ctor() { }
}
