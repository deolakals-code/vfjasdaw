// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(Camera))]
[AddComponentMenu("NGUI/Interaction/Draggable Camera")]
public class UIDraggableCamera : MonoBehaviour // TypeDefIndex: 28
{
	// Fields
	public Transform rootForBounds; // 0x20
	public Vector2 scale; // 0x28
	public float scrollWheelFactor; // 0x30
	public UIDragObject.DragEffect dragEffect; // 0x34
	public bool smoothDragStart; // 0x38
	public float momentumAmount; // 0x3C
	protected Camera mCam; // 0x40
	protected Transform mTrans; // 0x48
	protected bool mPressed; // 0x50
	protected Vector2 mMomentum; // 0x54
	protected Bounds mBounds; // 0x5C
	protected Vector2 mScroll; // 0x74
	protected UIRoot mRoot; // 0x80
	protected bool mDragStarted; // 0x88

	// Properties
	public Vector2 currentMomentum { get; set; }

	// Methods

	// RVA: 0x17195C0 Offset: 0x17155C0 VA: 0x17195C0
	public Vector2 get_currentMomentum() { }

	// RVA: 0x17195C8 Offset: 0x17155C8 VA: 0x17195C8
	public void set_currentMomentum(Vector2 value) { }

	// RVA: 0x17195D0 Offset: 0x17155D0 VA: 0x17195D0
	private void Awake() { }

	// RVA: 0x1719788 Offset: 0x1715788 VA: 0x1719788
	private void Start() { }

	// RVA: 0x1719818 Offset: 0x1715818 VA: 0x1719818
	private Vector3 CalculateConstrainOffset() { }

	// RVA: 0x1719A24 Offset: 0x1715A24 VA: 0x1719A24
	public bool ConstrainToBounds(bool immediate) { }

	// RVA: 0x1719BCC Offset: 0x1715BCC VA: 0x1719BCC Slot: 4
	public virtual void Press(bool isPressed) { }

	// RVA: 0x1719074 Offset: 0x1715074 VA: 0x1719074
	public void Drag(Vector2 delta) { }

	// RVA: 0x171933C Offset: 0x171533C VA: 0x171933C
	public void Scroll(float delta) { }

	// RVA: 0x17194F0 Offset: 0x17154F0 VA: 0x17194F0
	public void ScrollWidth(float delta) { }

	// RVA: 0x1719D58 Offset: 0x1715D58 VA: 0x1719D58 Slot: 5
	protected virtual void Update() { }

	// RVA: 0x171A068 Offset: 0x1716068 VA: 0x171A068
	public void .ctor() { }
}
