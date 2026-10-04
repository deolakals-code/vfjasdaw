// Assembly: Assembly-CSharp.dll
// Namespace: 
[AddComponentMenu("NGUI/Interaction/Button SendCallAction")]
public class UIButtonSendCallAction : MonoBehaviour // TypeDefIndex: 23
{
	// Fields
	[SerializeField]
	private UIButtonSendCallActionEvent events; // 0x20
	public int SendParam; // 0x28
	public UIButtonSendCallAction.Trigger trigger; // 0x2C
	private bool mStarted; // 0x30
	private static bool mIsSingleTouch; // 0x0
	private bool mHighlighted; // 0x31

	// Properties
	public static bool IsSingleTouch { get; set; }

	// Methods

	// RVA: 0x1717F54 Offset: 0x1713F54 VA: 0x1717F54
	public static bool get_IsSingleTouch() { }

	// RVA: 0x1717F9C Offset: 0x1713F9C VA: 0x1717F9C
	public static void set_IsSingleTouch(bool value) { }

	// RVA: 0x1717FEC Offset: 0x1713FEC VA: 0x1717FEC
	public void SetEvent(UnityAction<int> callBack, int param) { }

	// RVA: 0x1718068 Offset: 0x1714068 VA: 0x1718068
	private void Start() { }

	// RVA: 0x1718074 Offset: 0x1714074 VA: 0x1718074
	private void OnEnable() { }

	// RVA: 0x171815C Offset: 0x171415C VA: 0x171815C
	private void OnDestroy() { }

	// RVA: 0x1718108 Offset: 0x1714108 VA: 0x1718108
	private void OnHover(bool isOver) { }

	// RVA: 0x17181CC Offset: 0x17141CC VA: 0x17181CC
	private void OnPress(bool isPressed) { }

	// RVA: 0x171821C Offset: 0x171421C VA: 0x171821C
	private void OnClick() { }

	// RVA: 0x17182A4 Offset: 0x17142A4 VA: 0x17182A4
	private void OnDoubleClick() { }

	// RVA: 0x1718170 Offset: 0x1714170 VA: 0x1718170
	private void Send() { }

	// RVA: 0x17182D8 Offset: 0x17142D8 VA: 0x17182D8
	public void .ctor() { }
}
