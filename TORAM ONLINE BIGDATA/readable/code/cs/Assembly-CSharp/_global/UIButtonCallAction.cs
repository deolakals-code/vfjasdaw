// Assembly: Assembly-CSharp.dll
// Namespace: 
[AddComponentMenu("NGUI/Interaction/Button CallAction")]
public class UIButtonCallAction : MonoBehaviour // TypeDefIndex: 11
{
	// Fields
	[SerializeField]
	private UnityEvent events; // 0x20
	public UIButtonCallAction.Trigger trigger; // 0x28
	private bool mStarted; // 0x2C
	private static bool mIsSingleTouch; // 0x0
	private bool mHighlighted; // 0x2D

	// Properties
	public static bool IsSingleTouch { get; set; }

	// Methods

	// RVA: 0x1715DE0 Offset: 0x1711DE0 VA: 0x1715DE0
	public static bool get_IsSingleTouch() { }

	// RVA: 0x1715E28 Offset: 0x1711E28 VA: 0x1715E28
	public static void set_IsSingleTouch(bool value) { }

	// RVA: 0x1715E78 Offset: 0x1711E78 VA: 0x1715E78
	public void SetEvent(UnityAction callBack) { }

	// RVA: 0x1715EB8 Offset: 0x1711EB8 VA: 0x1715EB8
	private void Start() { }

	// RVA: 0x1715EC4 Offset: 0x1711EC4 VA: 0x1715EC4
	private void OnEnable() { }

	// RVA: 0x1715F58 Offset: 0x1711F58 VA: 0x1715F58
	private void OnHover(bool isOver) { }

	// RVA: 0x1715FC8 Offset: 0x1711FC8 VA: 0x1715FC8
	private void OnPress(bool isPressed) { }

	// RVA: 0x1716024 Offset: 0x1712024 VA: 0x1716024
	private void OnClick() { }

	// RVA: 0x17160B4 Offset: 0x17120B4 VA: 0x17160B4
	private void OnDoubleClick() { }

	// RVA: 0x1715FB4 Offset: 0x1711FB4 VA: 0x1715FB4
	private void Send() { }

	// RVA: 0x17160F0 Offset: 0x17120F0 VA: 0x17160F0
	public void .ctor() { }
}
