// Assembly: Assembly-CSharp.dll
// Namespace: 
[AddComponentMenu("NGUI/Interaction/Scroll Bar")]
public class UIScrollBar : UIWidgetContainer // TypeDefIndex: 52
{
	// Fields
	public static UIScrollBar current; // 0x0
	public List<EventDelegate> onChange; // 0x20
	public UIScrollBar.OnDragFinished onDragFinished; // 0x28
	[HideInInspector]
	[SerializeField]
	private UISprite mBG; // 0x30
	[SerializeField]
	[HideInInspector]
	private UISprite mFG; // 0x38
	[SerializeField]
	[HideInInspector]
	private UIScrollBar.Direction mDir; // 0x40
	[SerializeField]
	[HideInInspector]
	private bool mInverted; // 0x44
	[SerializeField]
	[HideInInspector]
	private float mScroll; // 0x48
	[HideInInspector]
	[SerializeField]
	private float mSize; // 0x4C
	private Transform mTrans; // 0x50
	private bool mIsDirty; // 0x58
	private Camera mCam; // 0x60
	private Vector2 mScreenPos; // 0x68
	private Collider mFGCollider; // 0x70

	// Properties
	public Transform cachedTransform { get; }
	public Camera cachedCamera { get; }
	public UISprite background { get; set; }
	public UISprite foreground { get; set; }
	public UIScrollBar.Direction direction { get; set; }
	public bool inverted { get; set; }
	public float value { get; set; }
	[Obsolete("Use 'value' instead")]
	public float scrollValue { get; set; }
	public float barSize { get; set; }
	public float alpha { get; set; }

	// Methods

	// RVA: 0x1722C78 Offset: 0x171EC78 VA: 0x1722C78
	public Transform get_cachedTransform() { }

	// RVA: 0x1722D0C Offset: 0x171ED0C VA: 0x1722D0C
	public Camera get_cachedCamera() { }

	// RVA: 0x1722DE8 Offset: 0x171EDE8 VA: 0x1722DE8
	public UISprite get_background() { }

	// RVA: 0x1722DF0 Offset: 0x171EDF0 VA: 0x1722DF0
	public void set_background(UISprite value) { }

	// RVA: 0x1722E80 Offset: 0x171EE80 VA: 0x1722E80
	public UISprite get_foreground() { }

	// RVA: 0x1722E88 Offset: 0x171EE88 VA: 0x1722E88
	public void set_foreground(UISprite value) { }

	// RVA: 0x1722F18 Offset: 0x171EF18 VA: 0x1722F18
	public UIScrollBar.Direction get_direction() { }

	// RVA: 0x1722F20 Offset: 0x171EF20 VA: 0x1722F20
	public void set_direction(UIScrollBar.Direction value) { }

	// RVA: 0x1723814 Offset: 0x171F814 VA: 0x1723814
	public bool get_inverted() { }

	// RVA: 0x172381C Offset: 0x171F81C VA: 0x172381C
	public void set_inverted(bool value) { }

	// RVA: 0x172383C Offset: 0x171F83C VA: 0x172383C
	public float get_value() { }

	// RVA: 0x171B294 Offset: 0x1717294 VA: 0x171B294
	public void set_value(float value) { }

	// RVA: 0x1723844 Offset: 0x171F844 VA: 0x1723844
	public float get_scrollValue() { }

	// RVA: 0x172384C Offset: 0x171F84C VA: 0x172384C
	public void set_scrollValue(float value) { }

	// RVA: 0x1723850 Offset: 0x171F850 VA: 0x1723850
	public float get_barSize() { }

	// RVA: 0x171B19C Offset: 0x171719C VA: 0x171B19C
	public void set_barSize(float value) { }

	// RVA: 0x171C568 Offset: 0x1718568 VA: 0x171C568
	public float get_alpha() { }

	// RVA: 0x171AD10 Offset: 0x1716D10 VA: 0x171AD10
	public void set_alpha(float value) { }

	// RVA: 0x1723858 Offset: 0x171F858 VA: 0x1723858
	private void CenterOnPos(Vector2 localPos) { }

	// RVA: 0x17239D8 Offset: 0x171F9D8 VA: 0x17239D8
	private void Reposition(Vector2 screenPos) { }

	// RVA: 0x1723C8C Offset: 0x171FC8C VA: 0x1723C8C
	private void OnPressBackground(GameObject go, bool isPressed) { }

	// RVA: 0x1723D3C Offset: 0x171FD3C VA: 0x1723D3C
	private void OnDragBackground(GameObject go, Vector2 delta) { }

	// RVA: 0x1723DB4 Offset: 0x171FDB4 VA: 0x1723DB4
	private void OnPressForeground(GameObject go, bool isPressed) { }

	// RVA: 0x1723E94 Offset: 0x171FE94 VA: 0x1723E94
	private void OnDragForeground(GameObject go, Vector2 delta) { }

	// RVA: 0x1723F24 Offset: 0x171FF24 VA: 0x1723F24
	private void Start() { }

	// RVA: 0x172436C Offset: 0x172036C VA: 0x172436C
	private void Update() { }

	// RVA: 0x172311C Offset: 0x171F11C VA: 0x172311C
	public void ForceUpdate() { }

	// RVA: 0x172437C Offset: 0x172037C VA: 0x172437C
	public void .ctor() { }
}
