// Assembly: Assembly-CSharp.dll
// Namespace: 
[ExecuteInEditMode]
[RequireComponent(typeof(UIPanel))]
[AddComponentMenu("NGUI/Interaction/Draggable Panel")]
public class UIDraggablePanel : MonoBehaviour // TypeDefIndex: 32
{
	// Fields
	public UIDraggablePanel.DragEffect dragEffect; // 0x20
	public bool restrictWithinPanel; // 0x24
	public bool disableDragIfFits; // 0x25
	public bool smoothDragStart; // 0x26
	public bool repositionClipping; // 0x27
	public bool iOSDragEmulation; // 0x28
	public float scrollWheelFactor; // 0x2C
	public float momentumAmount; // 0x30
	public UIScrollBar horizontalScrollBar; // 0x38
	public UIScrollBar verticalScrollBar; // 0x40
	public UIDraggablePanel.ShowCondition showScrollBars; // 0x48
	public Vector3 scale; // 0x4C
	public Vector2 relativePositionOnReset; // 0x58
	public UIDraggablePanel.OnDragFinished onDragFinished; // 0x60
	private Transform mTrans; // 0x68
	private UIPanel mPanel; // 0x70
	private Plane mPlane; // 0x78
	private Vector3 mLastPos; // 0x88
	private bool mPressed; // 0x94
	private Vector3 mMomentum; // 0x98
	private float mScroll; // 0xA4
	private Bounds mBounds; // 0xA8
	private bool mCalculatedBounds; // 0xC0
	private bool mShouldMove; // 0xC1
	private bool mIgnoreCallbacks; // 0xC2
	private int mDragID; // 0xC4
	private Vector2 mDragStartOffset; // 0xC8
	private bool mDragStarted; // 0xD0

	// Properties
	public UIPanel panel { get; }
	public Bounds bounds { get; }
	public bool shouldMoveHorizontally { get; }
	public bool shouldMoveVertically { get; }
	private bool shouldMove { get; }
	public Vector3 currentMomentum { get; set; }

	// Methods

	// RVA: 0x171A114 Offset: 0x1716114 VA: 0x171A114
	public UIPanel get_panel() { }

	// RVA: 0x171A11C Offset: 0x171611C VA: 0x171A11C
	public Bounds get_bounds() { }

	// RVA: 0x171A18C Offset: 0x171618C VA: 0x171A18C
	public bool get_shouldMoveHorizontally() { }

	// RVA: 0x171A1E4 Offset: 0x17161E4 VA: 0x171A1E4
	public bool get_shouldMoveVertically() { }

	// RVA: 0x171A23C Offset: 0x171623C VA: 0x171A23C
	private bool get_shouldMove() { }

	// RVA: 0x171A454 Offset: 0x1716454 VA: 0x171A454
	public Vector3 get_currentMomentum() { }

	// RVA: 0x1718D8C Offset: 0x1714D8C VA: 0x1718D8C
	public void set_currentMomentum(Vector3 value) { }

	// RVA: 0x171A460 Offset: 0x1716460 VA: 0x171A460
	private void Awake() { }

	// RVA: 0x171A5C4 Offset: 0x17165C4 VA: 0x171A5C4
	private void OnDestroy() { }

	// RVA: 0x171A714 Offset: 0x1716714 VA: 0x171A714
	private void OnPanelChange() { }

	// RVA: 0x171AA18 Offset: 0x1716A18 VA: 0x171AA18
	private void Start() { }

	// RVA: 0x171AEB0 Offset: 0x1716EB0 VA: 0x171AEB0
	public bool RestrictWithinBounds(bool instant) { }

	// RVA: 0x171B0E4 Offset: 0x17170E4 VA: 0x171B0E4
	public void DisableSpring() { }

	// RVA: 0x171A71C Offset: 0x171671C VA: 0x171A71C
	public void UpdateScrollbars(bool recalculateBounds) { }

	// RVA: 0x171B38C Offset: 0x171738C VA: 0x171B38C
	public void SetDragAmount(float x, float y, bool updateScrollbars) { }

	// RVA: 0x171B548 Offset: 0x1717548 VA: 0x171B548
	public void ResetPosition() { }

	// RVA: 0x171B574 Offset: 0x1717574 VA: 0x171B574
	private void OnHorizontalBar() { }

	// RVA: 0x171B654 Offset: 0x1717654 VA: 0x171B654
	private void OnVerticalBar() { }

	// RVA: 0x171B058 Offset: 0x1717058 VA: 0x171B058
	public void MoveRelative(Vector3 relative) { }

	// RVA: 0x171B734 Offset: 0x1717734 VA: 0x171B734
	public void MoveAbsolute(Vector3 absolute) { }

	// RVA: 0x171B7D8 Offset: 0x17177D8 VA: 0x171B7D8
	public void Press(bool pressed) { }

	// RVA: 0x171BB50 Offset: 0x1717B50 VA: 0x171BB50
	public void Drag() { }

	// RVA: 0x171C01C Offset: 0x171801C VA: 0x171C01C
	public void Scroll(float delta) { }

	// RVA: 0x171C108 Offset: 0x1718108 VA: 0x171C108
	private void LateUpdate() { }

	// RVA: 0x171C620 Offset: 0x1718620 VA: 0x171C620
	public void .ctor() { }
}
