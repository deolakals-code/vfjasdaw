// Assembly: Assembly-CSharp.dll
// Namespace: 
[AddComponentMenu("NGUI/Interaction/Button Message")]
public class UIButtonMessage : MonoBehaviour // TypeDefIndex: 17
{
	// Fields
	public GameObject target; // 0x20
	public string functionName; // 0x28
	public UIButtonMessage.Trigger trigger; // 0x30
	public bool includeChildren; // 0x34
	private bool mStarted; // 0x35
	private static bool mIsSingleTouch; // 0x0
	private bool mHighlighted; // 0x36

	// Properties
	public static bool IsSingleTouch { get; set; }

	// Methods

	// RVA: 0x1716C48 Offset: 0x1712C48 VA: 0x1716C48
	public static bool get_IsSingleTouch() { }

	// RVA: 0x1716C90 Offset: 0x1712C90 VA: 0x1716C90
	public static void set_IsSingleTouch(bool value) { }

	// RVA: 0x1716CE0 Offset: 0x1712CE0 VA: 0x1716CE0
	private void Start() { }

	// RVA: 0x1716CEC Offset: 0x1712CEC VA: 0x1716CEC
	private void OnEnable() { }

	// RVA: 0x1716D80 Offset: 0x1712D80 VA: 0x1716D80
	private void OnHover(bool isOver) { }

	// RVA: 0x1716F68 Offset: 0x1712F68 VA: 0x1716F68
	private void OnPress(bool isPressed) { }

	// RVA: 0x1716FB8 Offset: 0x1712FB8 VA: 0x1716FB8
	private void OnClick() { }

	// RVA: 0x1717040 Offset: 0x1713040 VA: 0x1717040
	private void OnDoubleClick() { }

	// RVA: 0x1716DD4 Offset: 0x1712DD4 VA: 0x1716DD4
	private void Send() { }

	// RVA: 0x1717074 Offset: 0x1713074 VA: 0x1717074
	public void .ctor() { }
}
