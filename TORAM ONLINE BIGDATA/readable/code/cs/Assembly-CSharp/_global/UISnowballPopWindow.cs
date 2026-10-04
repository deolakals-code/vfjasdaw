// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UISnowballPopWindow : MonoBehaviour // TypeDefIndex: 6026
{
	// Fields
	[SerializeField]
	private GameObject windowPanel; // 0x20
	[SerializeField]
	private GameObject infoPanel; // 0x28
	[SerializeField]
	private GameObject okPanel; // 0x30
	[SerializeField]
	private UILabel titleLabel; // 0x38
	[SerializeField]
	private UISprite titleIcon; // 0x40
	[SerializeField]
	private UILabel mainLabel; // 0x48
	[SerializeField]
	private GameObject[] infoPanels; // 0x50
	[SerializeField]
	private UISprite[] pageIcon; // 0x58
	[SerializeField]
	private GameObject[] arrowObjs; // 0x60
	[SerializeField]
	private Transform boxTrans; // 0x68
	[SerializeField]
	private GameObject[] arrowKeyButtonObj; // 0x70
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x78
	private Action endAction; // 0x80
	private UISnowballPopWindow.PageType page; // 0x88
	private UISnowballPopWindow.PageType maxPage; // 0x8C
	private SystemTextManager systemTextManager; // 0x90
	private GameObject boxObj; // 0x98
	private TweenPosition[] arrowTweenPos; // 0xA0
	private TweenAlpha[] arrowTweenAlpha; // 0xA8

	// Properties
	public bool IsOpen { get; set; }
	public bool IsOpenInfo { get; }
	public bool IsOpenOk { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x186D8B8 Offset: 0x18698B8 VA: 0x186D8B8
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x186D8C0 Offset: 0x18698C0 VA: 0x186D8C0
	private void set_IsOpen(bool value) { }

	// RVA: 0x186D8CC Offset: 0x18698CC VA: 0x186D8CC
	public bool get_IsOpenInfo() { }

	// RVA: 0x186D8FC Offset: 0x18698FC VA: 0x186D8FC
	public bool get_IsOpenOk() { }

	// RVA: 0x186D92C Offset: 0x186992C VA: 0x186D92C
	private void Awake() { }

	// RVA: 0x186DA18 Offset: 0x1869A18 VA: 0x186DA18
	private void Update() { }

	// RVA: 0x1867A14 Offset: 0x1863A14 VA: 0x1867A14
	public void OpenWindow(string spriteName, string title, string text, Action endAction) { }

	// RVA: 0x186AD94 Offset: 0x1866D94 VA: 0x186AD94
	public void OpenInfoWindow() { }

	// RVA: 0x1869A78 Offset: 0x1865A78 VA: 0x1869A78
	public void Close() { }

	[IteratorStateMachine(typeof(UISnowballPopWindow.<CloseWait>d__32))]
	// RVA: 0x186DF34 Offset: 0x1869F34 VA: 0x186DF34
	private IEnumerator CloseWait() { }

	// RVA: 0x186DAF8 Offset: 0x1869AF8 VA: 0x186DAF8
	private void UpdatePage() { }

	// RVA: 0x186DFA8 Offset: 0x1869FA8 VA: 0x186DFA8
	public void OnOk() { }

	// RVA: 0x186DFC4 Offset: 0x1869FC4 VA: 0x186DFC4
	public void OnNext() { }

	// RVA: 0x186E04C Offset: 0x186A04C VA: 0x186E04C
	public void OnBack() { }

	// RVA: 0x186E0D0 Offset: 0x186A0D0 VA: 0x186E0D0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x186E1AC Offset: 0x186A1AC VA: 0x186E1AC
	private void <OpenInfoWindow>b__30_0(GameObject x) { }
}
