// Assembly: Assembly-CSharp.dll
// Namespace: 
[AddComponentMenu("NGUI/Internal/Event Listener")]
public class UIEventListener : MonoBehaviour // TypeDefIndex: 89
{
	// Fields
	public object parameter; // 0x20
	public UIEventListener.VoidDelegate onSubmit; // 0x28
	public UIEventListener.VoidDelegate onClick; // 0x30
	public UIEventListener.VoidDelegate onDoubleClick; // 0x38
	public UIEventListener.BoolDelegate onHover; // 0x40
	public UIEventListener.BoolDelegate onPress; // 0x48
	public UIEventListener.BoolDelegate onSelect; // 0x50
	public UIEventListener.FloatDelegate onScroll; // 0x58
	public UIEventListener.VectorDelegate onDrag; // 0x60
	public UIEventListener.ObjectDelegate onDrop; // 0x68
	public UIEventListener.StringDelegate onInput; // 0x70
	public UIEventListener.KeyCodeDelegate onKey; // 0x78

	// Methods

	// RVA: 0x1734648 Offset: 0x1730648 VA: 0x1734648
	private void OnSubmit() { }

	// RVA: 0x1734680 Offset: 0x1730680 VA: 0x1734680
	private void OnClick() { }

	// RVA: 0x17346B8 Offset: 0x17306B8 VA: 0x17346B8
	private void OnDoubleClick() { }

	// RVA: 0x17346F0 Offset: 0x17306F0 VA: 0x17346F0
	private void OnHover(bool isOver) { }

	// RVA: 0x173473C Offset: 0x173073C VA: 0x173473C
	private void OnPress(bool isPressed) { }

	// RVA: 0x1734788 Offset: 0x1730788 VA: 0x1734788
	private void OnSelect(bool selected) { }

	// RVA: 0x17347D4 Offset: 0x17307D4 VA: 0x17347D4
	private void OnScroll(float delta) { }

	// RVA: 0x1734820 Offset: 0x1730820 VA: 0x1734820
	private void OnDrag(Vector2 delta) { }

	// RVA: 0x1734874 Offset: 0x1730874 VA: 0x1734874
	private void OnDrop(GameObject go) { }

	// RVA: 0x17348C0 Offset: 0x17308C0 VA: 0x17348C0
	private void OnInput(string text) { }

	// RVA: 0x173490C Offset: 0x173090C VA: 0x173490C
	private void OnKey(KeyCode key) { }

	// RVA: 0x17255BC Offset: 0x17215BC VA: 0x17255BC
	public static UIEventListener Get(GameObject go) { }

	// RVA: 0x1734958 Offset: 0x1730958 VA: 0x1734958
	public void .ctor() { }
}
