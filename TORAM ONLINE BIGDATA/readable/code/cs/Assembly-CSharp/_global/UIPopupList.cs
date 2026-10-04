// Assembly: Assembly-CSharp.dll
// Namespace: 
[AddComponentMenu("NGUI/Interaction/Popup List")]
public class UIPopupList : UIWidgetContainer // TypeDefIndex: 48
{
	// Fields
	public static UIPopupList current; // 0x0
	private const float animSpeed = 0.15;
	public UIAtlas atlas; // 0x20
	public UIFont font; // 0x28
	public UILabel textLabel; // 0x30
	public string backgroundSprite; // 0x38
	public string highlightSprite; // 0x40
	public UIPopupList.Position position; // 0x48
	public List<string> items; // 0x50
	public Vector2 padding; // 0x58
	public float textScale; // 0x60
	public Color textColor; // 0x64
	public Color backgroundColor; // 0x74
	public Color highlightColor; // 0x84
	public bool isAnimated; // 0x94
	public bool isLocalized; // 0x95
	public List<EventDelegate> onChange; // 0x98
	[SerializeField]
	[HideInInspector]
	private string mSelectedItem; // 0xA0
	private UIPanel mPanel; // 0xA8
	private GameObject mChild; // 0xB0
	private UISprite mBackground; // 0xB8
	private UISprite mHighlight; // 0xC0
	private UILabel mHighlightedLabel; // 0xC8
	private List<UILabel> mLabelList; // 0xD0
	private float mBgBorder; // 0xD8
	[SerializeField]
	[HideInInspector]
	private GameObject eventReceiver; // 0xE0
	[SerializeField]
	[HideInInspector]
	private string functionName; // 0xE8
	private UIPopupList.LegacyEvent mLegacyEvent; // 0xF0

	// Properties
	[Obsolete("Use EventDelegate.Add(popup.onChange, YourCallback) instead, and UIPopupList.current.value to determine the state")]
	public UIPopupList.LegacyEvent onSelectionChange { get; set; }
	public bool isOpen { get; }
	public string value { get; set; }
	[Obsolete("Use 'value' instead")]
	public string selection { get; set; }
	private bool handleEvents { get; set; }

	// Methods

	// RVA: 0x172034C Offset: 0x171C34C VA: 0x172034C
	public UIPopupList.LegacyEvent get_onSelectionChange() { }

	// RVA: 0x1720354 Offset: 0x171C354 VA: 0x1720354
	public void set_onSelectionChange(UIPopupList.LegacyEvent value) { }

	// RVA: 0x172035C Offset: 0x171C35C VA: 0x172035C
	public bool get_isOpen() { }

	// RVA: 0x17203BC Offset: 0x171C3BC VA: 0x17203BC
	public string get_value() { }

	// RVA: 0x1714F9C Offset: 0x1710F9C VA: 0x1714F9C
	public void set_value(string value) { }

	// RVA: 0x17203C4 Offset: 0x171C3C4 VA: 0x17203C4
	public string get_selection() { }

	// RVA: 0x17203CC Offset: 0x171C3CC VA: 0x17203CC
	public void set_selection(string value) { }

	// RVA: 0x17203D0 Offset: 0x171C3D0 VA: 0x17203D0
	private bool get_handleEvents() { }

	// RVA: 0x1720488 Offset: 0x171C488 VA: 0x1720488
	private void set_handleEvents(bool value) { }

	// RVA: 0x1720548 Offset: 0x171C548 VA: 0x1720548
	private void Start() { }

	// RVA: 0x1720654 Offset: 0x171C654 VA: 0x1720654
	private void OnLocalize(Localization loc) { }

	// RVA: 0x1720700 Offset: 0x171C700 VA: 0x1720700
	private void Highlight(UILabel lbl, bool instant) { }

	// RVA: 0x17208F0 Offset: 0x171C8F0 VA: 0x17208F0
	private void OnItemHover(GameObject go, bool isOver) { }

	// RVA: 0x1720974 Offset: 0x171C974 VA: 0x1720974
	private void Select(UILabel lbl, bool instant) { }

	// RVA: 0x1720AE8 Offset: 0x171CAE8 VA: 0x1720AE8
	private void OnItemPress(GameObject go, bool isPressed) { }

	// RVA: 0x1720B6C Offset: 0x171CB6C VA: 0x1720B6C
	private void OnKey(KeyCode key) { }

	// RVA: 0x1720CD4 Offset: 0x171CCD4 VA: 0x1720CD4
	private void OnSelect(bool isSelected) { }

	// RVA: 0x1720F88 Offset: 0x171CF88 VA: 0x1720F88
	private void AnimateColor(UIWidget widget) { }

	// RVA: 0x172101C Offset: 0x171D01C VA: 0x172101C
	private void AnimatePosition(UIWidget widget, bool placeAbove, float bottom) { }

	// RVA: 0x17210D8 Offset: 0x171D0D8 VA: 0x17210D8
	private void AnimateScale(UIWidget widget, bool placeAbove, float bottom) { }

	// RVA: 0x1721250 Offset: 0x171D250 VA: 0x1721250
	private void Animate(UIWidget widget, bool placeAbove, float bottom) { }

	// RVA: 0x1721288 Offset: 0x171D288 VA: 0x1721288
	private void OnClick() { }

	// RVA: 0x17222A0 Offset: 0x171E2A0 VA: 0x17222A0
	public void .ctor() { }
}
