// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UICardGamePopWindow : MonoBehaviour // TypeDefIndex: 5714
{
	// Fields
	[SerializeField]
	private GameObject windowPanel; // 0x20
	[SerializeField]
	private GameObject infoPanel; // 0x28
	[SerializeField]
	private GameObject[] infoPanels; // 0x30
	[SerializeField]
	private UISprite[] pageIcon; // 0x38
	[SerializeField]
	private GameObject[] arrowObjs; // 0x40
	[SerializeField]
	private UICardGameManager parentUiManager; // 0x48
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x50
	private int page; // 0x54
	private const int maxPage = 1;
	private TweenPosition[] arrowTweenPos; // 0x58
	private TweenAlpha[] arrowTweenAlpha; // 0x60

	// Properties
	public bool IsOpen { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x17CEB74 Offset: 0x17CAB74 VA: 0x17CEB74
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x17CEB7C Offset: 0x17CAB7C VA: 0x17CEB7C
	private void set_IsOpen(bool value) { }

	// RVA: 0x17CEB88 Offset: 0x17CAB88 VA: 0x17CEB88
	private void Awake() { }

	// RVA: 0x17CEB94 Offset: 0x17CAB94 VA: 0x17CEB94
	private void Update() { }

	// RVA: 0x17CEB98 Offset: 0x17CAB98 VA: 0x17CEB98
	public void OnInfoButton() { }

	// RVA: 0x17CEC34 Offset: 0x17CAC34 VA: 0x17CEC34
	private void OpenInfoWindow() { }

	// RVA: 0x17CEBA8 Offset: 0x17CABA8 VA: 0x17CEBA8
	private void Close() { }

	[IteratorStateMachine(typeof(UICardGamePopWindow.<CloseWait>d__19))]
	// RVA: 0x17CF254 Offset: 0x17CB254 VA: 0x17CF254
	private IEnumerator CloseWait() { }

	// RVA: 0x17CEE0C Offset: 0x17CAE0C VA: 0x17CEE0C
	private void UpdatePage() { }

	// RVA: 0x17CF2E8 Offset: 0x17CB2E8 VA: 0x17CF2E8
	private void OnNext() { }

	// RVA: 0x17CF374 Offset: 0x17CB374 VA: 0x17CF374
	private void OnBack() { }

	// RVA: 0x17CF3F8 Offset: 0x17CB3F8 VA: 0x17CF3F8
	public void .ctor() { }
}
