// Assembly: Assembly-CSharp.dll
// Namespace: 
[AddComponentMenu("NGUI/UI/Image Button")]
public class UIImageButton : MonoBehaviour // TypeDefIndex: 39
{
	// Fields
	public UISprite target; // 0x20
	public string normalSprite; // 0x28
	public string hoverSprite; // 0x30
	public string pressedSprite; // 0x38
	public string disabledSprite; // 0x40

	// Properties
	public bool isEnabled { get; set; }

	// Methods

	// RVA: 0x171E748 Offset: 0x171A748 VA: 0x171E748
	public bool get_isEnabled() { }

	// RVA: 0x171E7FC Offset: 0x171A7FC VA: 0x171E7FC
	public void set_isEnabled(bool value) { }

	// RVA: 0x171E9E4 Offset: 0x171A9E4 VA: 0x171E9E4
	private void OnEnable() { }

	// RVA: 0x171E8D4 Offset: 0x171A8D4 VA: 0x171E8D4
	private void UpdateImage() { }

	// RVA: 0x171EA8C Offset: 0x171AA8C VA: 0x171EA8C
	private void OnHover(bool isOver) { }

	// RVA: 0x171EB4C Offset: 0x171AB4C VA: 0x171EB4C
	private void OnPress(bool pressed) { }

	// RVA: 0x171EB98 Offset: 0x171AB98 VA: 0x171EB98
	public void .ctor() { }
}
