// Assembly: Assembly-CSharp.dll
// Namespace: 
[AddComponentMenu("NGUI/Interaction/Slider")]
public class UISlider : UIWidgetContainer // TypeDefIndex: 54
{
	// Fields
	public static UISlider current; // 0x0
	public Transform foreground; // 0x20
	public Transform thumb; // 0x28
	public UISlider.Direction direction; // 0x30
	public int numberOfSteps; // 0x34
	public float minLimit; // 0x38
	public List<EventDelegate> onChange; // 0x40
	[HideInInspector]
	[SerializeField]
	private float rawValue; // 0x48
	[SerializeField]
	[HideInInspector]
	private GameObject eventReceiver; // 0x50
	[SerializeField]
	[HideInInspector]
	private string functionName; // 0x58
	private BoxCollider mCol; // 0x60
	private Transform mTrans; // 0x68
	private Transform mFGTrans; // 0x70
	private UIWidget mFGWidget; // 0x78
	private UISprite mFGFilled; // 0x80
	private bool mInitDone; // 0x88
	private Vector2 mSize; // 0x8C
	private Vector2 mCenter; // 0x94

	// Properties
	public float value { get; set; }
	[Obsolete("Use 'value' instead")]
	public float sliderValue { get; set; }
	public Vector2 fullSize { get; set; }

	// Methods

	// RVA: 0x1724524 Offset: 0x1720524 VA: 0x1724524
	public float get_value() { }

	// RVA: 0x17245DC Offset: 0x17205DC VA: 0x17245DC
	public void set_value(float value) { }

	// RVA: 0x1724C10 Offset: 0x1720C10 VA: 0x1724C10
	public float get_sliderValue() { }

	// RVA: 0x1724C14 Offset: 0x1720C14 VA: 0x1724C14
	public void set_sliderValue(float value) { }

	// RVA: 0x1724C1C Offset: 0x1720C1C VA: 0x1724C1C
	public Vector2 get_fullSize() { }

	// RVA: 0x1724C24 Offset: 0x1720C24 VA: 0x1724C24
	public void set_fullSize(Vector2 value) { }

	// RVA: 0x1724C70 Offset: 0x1720C70 VA: 0x1724C70
	private void Init() { }

	// RVA: 0x1725184 Offset: 0x1721184 VA: 0x1725184
	private void Awake() { }

	// RVA: 0x1725278 Offset: 0x1721278 VA: 0x1725278
	private void Start() { }

	// RVA: 0x17257E4 Offset: 0x17217E4 VA: 0x17257E4
	private void OnPress(bool pressed) { }

	// RVA: 0x1725C80 Offset: 0x1721C80 VA: 0x1725C80
	private void OnDrag(Vector2 delta) { }

	// RVA: 0x1725CA8 Offset: 0x1721CA8 VA: 0x1725CA8
	private void OnPressThumb(GameObject go, bool pressed) { }

	// RVA: 0x1725CE4 Offset: 0x1721CE4 VA: 0x1725CE4
	private void OnDragThumb(GameObject go, Vector2 delta) { }

	// RVA: 0x1725D0C Offset: 0x1721D0C VA: 0x1725D0C
	private void OnKey(KeyCode key) { }

	// RVA: 0x1725870 Offset: 0x1721870 VA: 0x1725870
	private void UpdateDrag() { }

	// RVA: 0x17245E4 Offset: 0x17205E4 VA: 0x17245E4
	private void Set(float input, bool force) { }

	// RVA: 0x1724C64 Offset: 0x1720C64 VA: 0x1724C64
	public void ForceUpdate() { }

	// RVA: 0x1725F50 Offset: 0x1721F50 VA: 0x1725F50
	public void .ctor() { }
}
