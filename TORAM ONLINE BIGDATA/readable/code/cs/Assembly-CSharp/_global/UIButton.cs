// Assembly: Assembly-CSharp.dll
// Namespace: 
[AddComponentMenu("NGUI/Interaction/Button")]
public class UIButton : UIButtonColor // TypeDefIndex: 8
{
	// Fields
	public static UIButton current; // 0x0
	public Color disabledColor; // 0x60
	public List<EventDelegate> onClick; // 0x70

	// Properties
	public bool isEnabled { get; set; }

	// Methods

	// RVA: 0x17152A4 Offset: 0x17112A4 VA: 0x17152A4 Slot: 4
	protected override void OnEnable() { }

	// RVA: 0x171558C Offset: 0x171158C VA: 0x171558C Slot: 5
	protected override void OnDisable() { }

	// RVA: 0x17155A4 Offset: 0x17115A4 VA: 0x17155A4 Slot: 7
	public override void OnHover(bool isOver) { }

	// RVA: 0x171566C Offset: 0x171166C VA: 0x171566C Slot: 6
	public override void OnPress(bool isPressed) { }

	// RVA: 0x17157BC Offset: 0x17117BC VA: 0x17157BC
	private void OnClick() { }

	// RVA: 0x17152FC Offset: 0x17112FC VA: 0x17152FC
	public bool get_isEnabled() { }

	// RVA: 0x171587C Offset: 0x171187C VA: 0x171587C
	public void set_isEnabled(bool value) { }

	// RVA: 0x1715450 Offset: 0x1711450 VA: 0x1715450
	public void UpdateColor(bool shouldBeEnabled, bool immediate) { }

	// RVA: 0x1715C34 Offset: 0x1711C34 VA: 0x1715C34
	public void .ctor() { }
}
