// Assembly: Assembly-CSharp.dll
// Namespace: 
[AddComponentMenu("NGUI/Interaction/Button Color")]
public class UIButtonColor : UIWidgetContainer // TypeDefIndex: 12
{
	// Fields
	public GameObject tweenTarget; // 0x20
	public Color hover; // 0x28
	public Color pressed; // 0x38
	public float duration; // 0x48
	protected Color mColor; // 0x4C
	protected bool mStarted; // 0x5C
	protected bool mHighlighted; // 0x5D

	// Properties
	public Color defaultColor { get; set; }

	// Methods

	// RVA: 0x1715C04 Offset: 0x1711C04 VA: 0x1715C04
	public Color get_defaultColor() { }

	// RVA: 0x1716180 Offset: 0x1712180 VA: 0x1716180
	public void set_defaultColor(Color value) { }

	// RVA: 0x171615C Offset: 0x171215C VA: 0x171615C
	private void Start() { }

	// RVA: 0x17153B4 Offset: 0x17113B4 VA: 0x17153B4 Slot: 4
	protected virtual void OnEnable() { }

	// RVA: 0x17161D0 Offset: 0x17121D0 VA: 0x17161D0 Slot: 5
	protected virtual void OnDisable() { }

	// RVA: 0x1715938 Offset: 0x1711938 VA: 0x1715938
	protected void Init() { }

	// RVA: 0x17156A4 Offset: 0x17116A4 VA: 0x17156A4 Slot: 6
	public virtual void OnPress(bool isPressed) { }

	// RVA: 0x17155DC Offset: 0x17115DC VA: 0x17155DC Slot: 7
	public virtual void OnHover(bool isOver) { }

	// RVA: 0x1715CF4 Offset: 0x1711CF4 VA: 0x1715CF4
	public void .ctor() { }
}
