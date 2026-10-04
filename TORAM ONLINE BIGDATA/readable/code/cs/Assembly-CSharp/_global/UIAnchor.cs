// Assembly: Assembly-CSharp.dll
// Namespace: 
[AddComponentMenu("NGUI/UI/Anchor")]
[ExecuteInEditMode]
public class UIAnchor : MonoBehaviour // TypeDefIndex: 148
{
	// Fields
	private bool mNeedsHalfPixelOffset; // 0x20
	public Camera uiCamera; // 0x28
	public GameObject container; // 0x30
	public UIAnchor.Side side; // 0x38
	public bool halfPixelOffset; // 0x3C
	public bool runOnlyOnce; // 0x3D
	public Vector2 relativeOffset; // 0x40
	public Vector2 pixelOffset; // 0x48
	[SerializeField]
	private UIWidget widgetContainer; // 0x50
	private Transform mTrans; // 0x58
	private Animation mAnim; // 0x60
	private Rect mRect; // 0x68
	private UIRoot mRoot; // 0x78

	// Methods

	// RVA: 0x1EE1BEC Offset: 0x1EDDBEC VA: 0x1EE1BEC
	private void Awake() { }

	// RVA: 0x1EE1C60 Offset: 0x1EDDC60 VA: 0x1EE1C60
	private void Start() { }

	// RVA: 0x1EE1EA4 Offset: 0x1EDDEA4 VA: 0x1EE1EA4
	private void Update() { }

	// RVA: 0x1EE2748 Offset: 0x1EDE748 VA: 0x1EE2748
	public void .ctor() { }
}
