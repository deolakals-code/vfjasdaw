// Assembly: Assembly-CSharp.dll
// Namespace: 
[AddComponentMenu("NGUI/Interaction/Forward Events")]
public class UIForwardEvents : MonoBehaviour // TypeDefIndex: 36
{
	// Fields
	public GameObject target; // 0x20
	public bool onHover; // 0x28
	public bool onPress; // 0x29
	public bool onClick; // 0x2A
	public bool onDoubleClick; // 0x2B
	public bool onSelect; // 0x2C
	public bool onDrag; // 0x2D
	public bool onDrop; // 0x2E
	public bool onInput; // 0x2F
	public bool onSubmit; // 0x30
	public bool onScroll; // 0x31

	// Methods

	// RVA: 0x171DA14 Offset: 0x1719A14 VA: 0x171DA14
	private void OnHover(bool isOver) { }

	// RVA: 0x171DAF0 Offset: 0x1719AF0 VA: 0x171DAF0
	private void OnPress(bool pressed) { }

	// RVA: 0x171DBCC Offset: 0x1719BCC VA: 0x171DBCC
	private void OnClick() { }

	// RVA: 0x171DC74 Offset: 0x1719C74 VA: 0x171DC74
	private void OnDoubleClick() { }

	// RVA: 0x171DD1C Offset: 0x1719D1C VA: 0x171DD1C
	private void OnSelect(bool selected) { }

	// RVA: 0x171DDF8 Offset: 0x1719DF8 VA: 0x171DDF8
	private void OnDrag(Vector2 delta) { }

	// RVA: 0x171DED4 Offset: 0x1719ED4 VA: 0x171DED4
	private void OnDrop(GameObject go) { }

	// RVA: 0x171DF84 Offset: 0x1719F84 VA: 0x171DF84
	private void OnInput(string text) { }

	// RVA: 0x171E034 Offset: 0x171A034 VA: 0x171E034
	private void OnSubmit() { }

	// RVA: 0x171E0DC Offset: 0x171A0DC VA: 0x171E0DC
	private void OnScroll(float delta) { }

	// RVA: 0x171E1BC Offset: 0x171A1BC VA: 0x171E1BC
	public void .ctor() { }
}
