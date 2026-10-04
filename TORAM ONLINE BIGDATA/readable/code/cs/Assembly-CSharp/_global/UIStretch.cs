// Assembly: Assembly-CSharp.dll
// Namespace: 
[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/Stretch")]
public class UIStretch : MonoBehaviour // TypeDefIndex: 188
{
	// Fields
	public Camera uiCamera; // 0x20
	public GameObject container; // 0x28
	public UIStretch.Style style; // 0x30
	public bool runOnlyOnce; // 0x34
	public Vector2 relativeSize; // 0x38
	public Vector2 initialSize; // 0x40
	public Vector2 borderPadding; // 0x48
	[SerializeField]
	[HideInInspector]
	private UIWidget widgetContainer; // 0x50
	private Transform mTrans; // 0x58
	private UIWidget mWidget; // 0x60
	private UISprite mSprite; // 0x68
	private UIRoot mRoot; // 0x70
	private Animation mAnim; // 0x78
	private Rect mRect; // 0x80

	// Methods

	// RVA: 0x20D9434 Offset: 0x20D5434 VA: 0x20D9434
	private void OnEnable() { }

	// RVA: 0x20D9514 Offset: 0x20D5514 VA: 0x20D9514
	private void Start() { }

	// RVA: 0x20D96CC Offset: 0x20D56CC VA: 0x20D96CC
	private void Update() { }

	// RVA: 0x20DA04C Offset: 0x20D604C VA: 0x20DA04C
	public void .ctor() { }
}
