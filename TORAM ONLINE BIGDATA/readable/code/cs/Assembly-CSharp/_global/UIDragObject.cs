// Assembly: Assembly-CSharp.dll
// Namespace: 
[AddComponentMenu("NGUI/Interaction/Drag Object")]
public class UIDragObject : MonoBehaviour // TypeDefIndex: 34
{
	// Fields
	public Transform target; // 0x20
	public Vector3 scale; // 0x28
	public float scrollWheelFactor; // 0x34
	public bool restrictWithinPanel; // 0x38
	public UIDragObject.DragEffect dragEffect; // 0x3C
	public float momentumAmount; // 0x40
	private Plane mPlane; // 0x44
	private Vector3 mLastPos; // 0x54
	private UIPanel mPanel; // 0x60
	private bool mPressed; // 0x68
	private Vector3 mMomentum; // 0x6C
	private float mScroll; // 0x78
	private Bounds mBounds; // 0x7C
	private int mTouchID; // 0x94
	private bool mStarted; // 0x98

	// Methods

	// RVA: 0x171C774 Offset: 0x1718774 VA: 0x171C774
	private void FindPanel() { }

	// RVA: 0x171C870 Offset: 0x1718870 VA: 0x171C870
	private void OnPress(bool pressed) { }

	// RVA: 0x171CD38 Offset: 0x1718D38 VA: 0x171CD38
	private void OnDrag(Vector2 delta) { }

	// RVA: 0x171D1E8 Offset: 0x17191E8 VA: 0x171D1E8
	private void LateUpdate() { }

	// RVA: 0x171D518 Offset: 0x1719518 VA: 0x171D518
	private void OnScroll(float delta) { }

	// RVA: 0x171D5E0 Offset: 0x17195E0 VA: 0x171D5E0
	public void .ctor() { }
}
