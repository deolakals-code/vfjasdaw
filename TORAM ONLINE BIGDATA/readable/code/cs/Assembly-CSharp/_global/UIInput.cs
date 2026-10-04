// Assembly: Assembly-CSharp.dll
// Namespace: 
[AddComponentMenu("NGUI/UI/Input Field")]
[ExecuteInEditMode]
public class UIInput : UIWidgetContainer // TypeDefIndex: 166
{
	// Fields
	public static UIInput current; // 0x0
	public UILabel label; // 0x20
	public int maxChars; // 0x28
	public string caratChar; // 0x30
	public string playerPrefsField; // 0x38
	public UIInput.Validator validator; // 0x40
	public UIInput.KeyboardType type; // 0x48
	public bool isPassword; // 0x4C
	public bool autoCorrect; // 0x4D
	public bool multiLine; // 0x4E
	public int maxLines; // 0x50
	public bool useLabelTextAtStart; // 0x54
	public Color activeColor; // 0x58
	public GameObject selectOnTab; // 0x68
	public List<EventDelegate> onSubmit; // 0x70
	public bool IsEncodeLabelBase; // 0x78
	public UISprite dipsArea; // 0x80
	[SerializeField]
	[HideInInspector]
	private GameObject eventReceiver; // 0x88
	[SerializeField]
	[HideInInspector]
	private string functionName; // 0x90
	private string mText; // 0x98
	private string mDefaultText; // 0xA0
	private Color mDefaultColor; // 0xA8
	private UIWidget.Pivot mPivot; // 0xB8
	private float mPosition; // 0xBC
	private int mTextPos; // 0xC0
	private int mDipsPos; // 0xC4
	private float leftPushTime; // 0xC8
	private float rightPushTime; // 0xCC
	private float upPushTime; // 0xD0
	private float downPushTime; // 0xD4
	private float deletePushTime; // 0xD8
	private float leftDuring; // 0xDC
	private float rightDuring; // 0xE0
	private float upDuring; // 0xE4
	private float downDuring; // 0xE8
	private float deleteDuring; // 0xEC
	private float charTime; // 0xF0
	[CompilerGenerated]
	private Camera <ImeCamera>k__BackingField; // 0xF8
	private bool isSetCompositionCursorPos; // 0x100
	private Vector2 compositionCursorOffset; // 0x104
	private TouchScreenKeyboard mKeyboard; // 0x110
	protected bool isEnterSubmit; // 0x118
	private bool mDoInit; // 0x119

	// Properties
	public Camera ImeCamera { get; set; }
	public TouchScreenKeyboard Keyboard { get; }
	public string value { get; set; }
	public bool selected { get; set; }
	public string defaultText { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1FD1C3C Offset: 0x1FCDC3C VA: 0x1FD1C3C
	public Camera get_ImeCamera() { }

	[CompilerGenerated]
	// RVA: 0x1FD1C44 Offset: 0x1FCDC44 VA: 0x1FD1C44
	public void set_ImeCamera(Camera value) { }

	// RVA: 0x1FD1C4C Offset: 0x1FCDC4C VA: 0x1FD1C4C
	public TouchScreenKeyboard get_Keyboard() { }

	// RVA: 0x1FD1C54 Offset: 0x1FCDC54 VA: 0x1FD1C54
	public string get_value() { }

	// RVA: 0x1FD1C80 Offset: 0x1FCDC80 VA: 0x1FD1C80
	public void set_value(string value) { }

	// RVA: 0x1FD1EFC Offset: 0x1FCDEFC VA: 0x1FD1EFC
	public bool get_selected() { }

	// RVA: 0x1FD211C Offset: 0x1FCE11C VA: 0x1FD211C
	public void set_selected(bool value) { }

	// RVA: 0x1FD2250 Offset: 0x1FCE250 VA: 0x1FD2250
	public string get_defaultText() { }

	// RVA: 0x1FD2258 Offset: 0x1FCE258 VA: 0x1FD2258
	public void set_defaultText(string value) { }

	// RVA: 0x1FD22B4 Offset: 0x1FCE2B4 VA: 0x1FD22B4 Slot: 4
	protected virtual void Init() { }

	// RVA: 0x1FD1E64 Offset: 0x1FCDE64 VA: 0x1FD1E64
	private void SaveToPlayerPrefs(string val) { }

	// RVA: 0x1FD2544 Offset: 0x1FCE544 VA: 0x1FD2544
	private void Awake() { }

	// RVA: 0x1FD262C Offset: 0x1FCE62C VA: 0x1FD262C
	private void Start() { }

	// RVA: 0x1FD2764 Offset: 0x1FCE764 VA: 0x1FD2764
	private void OnEnable() { }

	// RVA: 0x1FD2CE8 Offset: 0x1FCECE8 VA: 0x1FD2CE8
	private void OnDisable() { }

	// RVA: 0x1FD2D6C Offset: 0x1FCED6C VA: 0x1FD2D6C
	private void OnDestroy() { }

	// RVA: 0x1FD27E8 Offset: 0x1FCE7E8 VA: 0x1FD27E8
	private void OnSelect(bool isSelected) { }

	// RVA: 0x1FD318C Offset: 0x1FCF18C VA: 0x1FD318C Slot: 5
	protected virtual void Update() { }

	// RVA: 0x1FD3558 Offset: 0x1FCF558 VA: 0x1FD3558
	private void OnInput(string input) { }

	// RVA: 0x1FD342C Offset: 0x1FCF42C VA: 0x1FD342C
	protected void Submit() { }

	// RVA: 0x1FD3964 Offset: 0x1FCF964 VA: 0x1FD3964 Slot: 6
	protected virtual bool CheckInputWord(char c) { }

	// RVA: 0x1FD366C Offset: 0x1FCF66C VA: 0x1FD366C
	private void Append(string input) { }

	// RVA: 0x1FD2D70 Offset: 0x1FCED70 VA: 0x1FD2D70
	private void UpdateLabel() { }

	// RVA: 0x1FD309C Offset: 0x1FCF09C VA: 0x1FD309C
	private void RestoreLabel() { }

	// RVA: 0x1FD397C Offset: 0x1FCF97C VA: 0x1FD397C
	public void Close() { }

	// RVA: 0x1FD3980 Offset: 0x1FCF980 VA: 0x1FD3980
	public void Done() { }

	// RVA: 0x1FD39BC Offset: 0x1FCF9BC VA: 0x1FD39BC
	public void SetCompositionCursorPos(Vector2 offset) { }

	// RVA: 0x1FD39D0 Offset: 0x1FCF9D0 VA: 0x1FD39D0
	private void DipsLabelText() { }

	// RVA: 0x1FD3BB0 Offset: 0x1FCFBB0 VA: 0x1FD3BB0
	private string InsertStringText(string text, int pos, string addStr) { }

	// RVA: 0x1FD3C14 Offset: 0x1FCFC14 VA: 0x1FD3C14
	private void CalcIMEPosition() { }

	// RVA: 0x1FD4044 Offset: 0x1FD0044 VA: 0x1FD4044
	private bool CheckMoveCursor(bool bPush, ref float pushTime, ref float duringTime) { }

	// RVA: 0x1FD4114 Offset: 0x1FD0114 VA: 0x1FD4114
	private int MoveLineCursor(int addLine) { }

	// RVA: 0x1FD3FFC Offset: 0x1FCFFFC VA: 0x1FD3FFC
	private string GetLastLine(string str) { }

	[IteratorStateMachine(typeof(UIInput.<SelectedCancel>d__83))]
	// RVA: 0x1FD470C Offset: 0x1FD070C VA: 0x1FD470C
	private IEnumerator SelectedCancel() { }

	// RVA: 0x1FD47A0 Offset: 0x1FD07A0 VA: 0x1FD47A0
	public void .ctor() { }
}
