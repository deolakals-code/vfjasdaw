// Assembly: Assembly-CSharp.dll
// Namespace: 
[AddComponentMenu("NGUI/UI/Tooltip")]
public class UITooltip : MonoBehaviour // TypeDefIndex: 193
{
	// Fields
	private static UITooltip mInstance; // 0x0
	public Camera uiCamera; // 0x20
	public UILabel text; // 0x28
	public UISprite background; // 0x30
	public float appearSpeed; // 0x38
	public bool scalingTransitions; // 0x3C
	private Transform mTrans; // 0x40
	private float mTarget; // 0x48
	private float mCurrent; // 0x4C
	private Vector3 mPos; // 0x50
	private Vector3 mSize; // 0x5C
	private UIWidget[] mWidgets; // 0x68

	// Methods

	// RVA: 0x20DBA80 Offset: 0x20D7A80 VA: 0x20DBA80
	private void Awake() { }

	// RVA: 0x20DBAD8 Offset: 0x20D7AD8 VA: 0x20DBAD8
	private void OnDestroy() { }

	// RVA: 0x20DBB2C Offset: 0x20D7B2C VA: 0x20DBB2C
	private void Start() { }

	// RVA: 0x20DBD10 Offset: 0x20D7D10 VA: 0x20DBD10
	private void Update() { }

	// RVA: 0x20DBC74 Offset: 0x20D7C74 VA: 0x20DBC74
	private void SetAlpha(float val) { }

	// RVA: 0x20DBE98 Offset: 0x20D7E98 VA: 0x20DBE98
	private void SetText(string tooltipText) { }

	// RVA: 0x20DC504 Offset: 0x20D8504 VA: 0x20DC504
	public static void ShowText(string tooltipText) { }

	// RVA: 0x20DC5B8 Offset: 0x20D85B8 VA: 0x20DC5B8
	public void .ctor() { }
}
