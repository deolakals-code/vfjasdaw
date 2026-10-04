// Assembly: Assembly-CSharp.dll
// Namespace: 
[AddComponentMenu("NGUI/UI/Iruna2/Anchor")]
[ExecuteInEditMode]
public class UIIruna2Anchor : MonoBehaviour // TypeDefIndex: 100
{
	// Fields
	public UIIruna2Anchor.Side side; // 0x20
	[SerializeField]
	private bool screenRate; // 0x24
	[SerializeField]
	private Vector2 relativeOffset; // 0x28
	[SerializeField]
	private Vector2 pixelOffset; // 0x30
	private Transform mTrans; // 0x38
	private bool initCheck; // 0x40
	[CompilerGenerated]
	private bool <IsMove>k__BackingField; // 0x41
	private Vector3 moveDistance; // 0x44
	private Vector3 movePosition; // 0x50
	private Vector3 moveStartPosition; // 0x5C
	private float moveTime; // 0x68
	private float moveTimeCnt; // 0x6C
	private float delayTime; // 0x70
	private float moveStartTime; // 0x74

	// Properties
	public bool IsMove { get; set; }
	public bool IsDelayMove { get; }
	protected virtual float sceneRate { get; }
	public float RelativeOffsetX { get; }
	public float RelativeOffsetY { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1ED3604 Offset: 0x1ECF604 VA: 0x1ED3604
	private void set_IsMove(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1ED3610 Offset: 0x1ECF610 VA: 0x1ED3610
	public bool get_IsMove() { }

	// RVA: 0x1ED3618 Offset: 0x1ECF618 VA: 0x1ED3618
	public bool get_IsDelayMove() { }

	// RVA: 0x1ED3630 Offset: 0x1ECF630 VA: 0x1ED3630 Slot: 4
	protected virtual float get_sceneRate() { }

	// RVA: 0x1ED3638 Offset: 0x1ECF638 VA: 0x1ED3638
	public float get_RelativeOffsetX() { }

	// RVA: 0x1ED3640 Offset: 0x1ECF640 VA: 0x1ED3640
	public float get_RelativeOffsetY() { }

	// RVA: 0x1ED3648 Offset: 0x1ECF648 VA: 0x1ED3648
	private void Awake() { }

	// RVA: 0x1ED366C Offset: 0x1ECF66C VA: 0x1ED366C
	public void Initialize() { }

	// RVA: 0x1ED398C Offset: 0x1ECF98C VA: 0x1ED398C
	public void SetAnchorData(UIIruna2Anchor.Side side, bool screenRate, Vector2 relativeOffset, Vector2 pixelOffset) { }

	// RVA: 0x1ED367C Offset: 0x1ECF67C VA: 0x1ED367C
	private void Update() { }

	// RVA: 0x1ED3AC8 Offset: 0x1ECFAC8 VA: 0x1ED3AC8
	private void LateUpdate() { }

	// RVA: 0x1ED39A4 Offset: 0x1ECF9A4 VA: 0x1ED39A4
	private Vector3 getAnchorPosition(UIIruna2Anchor.Side _side) { }

	// RVA: 0x1ED3AD8 Offset: 0x1ECFAD8 VA: 0x1ED3AD8
	public void TweenPosition(Vector3 pos, float time) { }

	// RVA: 0x1ED3B34 Offset: 0x1ECFB34 VA: 0x1ED3B34
	public void TweenPosition(Vector3 pos, float time, float delay) { }

	// RVA: 0x1ED3B90 Offset: 0x1ECFB90 VA: 0x1ED3B90
	public void TweenPosition(Vector3 startPos, Vector3 endPos, float time) { }

	// RVA: 0x1ED3B98 Offset: 0x1ECFB98 VA: 0x1ED3B98
	public void TweenPosition(Vector3 startPos, Vector3 endPos, float time, float delay) { }

	// RVA: 0x1ED3C00 Offset: 0x1ECFC00 VA: 0x1ED3C00
	public Vector3 ChangeScreenRatePos(Vector3 pos) { }

	// RVA: 0x1ED3C44 Offset: 0x1ECFC44 VA: 0x1ED3C44
	public void .ctor() { }
}
