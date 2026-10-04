// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UITextSearchScrollWindow : MonoBehaviour // TypeDefIndex: 8743
{
	// Fields
	[SerializeField]
	private UIIruna2Anchor anchor; // 0x20
	[SerializeField]
	private UILabel titleLabel; // 0x28
	[SerializeField]
	private GameObject searchElement; // 0x30
	[SerializeField]
	private UIInput searchInput; // 0x38
	private UIScrollWindow scrollWindow; // 0x40
	private Dictionary<int, string> mustShowTextList; // 0x48
	private Dictionary<int, string> searchTextList; // 0x50
	private int selectParam; // 0x58
	private string selectText; // 0x60
	private Dictionary<int, UIWidgetSelectColor> addSearchElementList; // 0x68
	private Action callBack; // 0x70
	private bool isEnable; // 0x78
	private const float elementHeight = 60;
	private const float scrollCameraPosX = 2400;

	// Properties
	public int SelectParam { get; }
	public string SelectText { get; }
	public bool IsEnable { get; }

	// Methods

	// RVA: 0x1DFCC98 Offset: 0x1DF8C98 VA: 0x1DFCC98
	public static UITextSearchScrollWindow CreatePanel(Transform parent) { }

	// RVA: 0x1DFCDE8 Offset: 0x1DF8DE8 VA: 0x1DFCDE8
	public int get_SelectParam() { }

	// RVA: 0x1DFCDF0 Offset: 0x1DF8DF0 VA: 0x1DFCDF0
	public string get_SelectText() { }

	// RVA: 0x1DFCDF8 Offset: 0x1DF8DF8 VA: 0x1DFCDF8
	public bool get_IsEnable() { }

	// RVA: 0x1DFCE00 Offset: 0x1DF8E00 VA: 0x1DFCE00
	private void Start() { }

	// RVA: 0x1DFCE60 Offset: 0x1DF8E60 VA: 0x1DFCE60
	private void Update() { }

	// RVA: 0x1DFD11C Offset: 0x1DF911C VA: 0x1DFD11C
	public void Initialize(string title, string inputDefaultText, Dictionary<int, string> mustShowTextList, Dictionary<int, string> searchTextList, Action callBack) { }

	// RVA: 0x1DFD2C0 Offset: 0x1DF92C0 VA: 0x1DFD2C0
	public void ChangeEnable(bool isEnable) { }

	// RVA: 0x1DFD38C Offset: 0x1DF938C VA: 0x1DFD38C
	public void OnSubmit() { }

	// RVA: 0x1DFD3D4 Offset: 0x1DF93D4 VA: 0x1DFD3D4
	public void OnSelectElement(int param) { }

	// RVA: 0x1DFD604 Offset: 0x1DF9604 VA: 0x1DFD604
	public void OnEnter() { }

	[IteratorStateMachine(typeof(UITextSearchScrollWindow.<UpdateScrollWindow>d__28))]
	// RVA: 0x1DFD238 Offset: 0x1DF9238 VA: 0x1DFD238
	private IEnumerator UpdateScrollWindow(string keyword) { }

	[IteratorStateMachine(typeof(UITextSearchScrollWindow.<GetContainsList>d__29))]
	// RVA: 0x1DFD648 Offset: 0x1DF9648 VA: 0x1DFD648
	private IEnumerator GetContainsList(string keyword, Action<Dictionary<int, string>> callback) { }

	// RVA: 0x1DFD70C Offset: 0x1DF970C VA: 0x1DFD70C
	private void AddSearchElement(string text, Vector3 pos, int param) { }

	// RVA: 0x1DFCE64 Offset: 0x1DF8E64 VA: 0x1DFCE64
	private void UpdateScrollElementActive() { }

	// RVA: 0x1DFD91C Offset: 0x1DF991C VA: 0x1DFD91C
	public void .ctor() { }
}
