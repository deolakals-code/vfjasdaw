// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UICheckBoxSwitchButton : MonoBehaviour // TypeDefIndex: 8904
{
	// Fields
	[SerializeField]
	private UICheckBoxSwitchButton checkBox; // 0x20
	[SerializeField]
	private UISprite checkSprite; // 0x28
	[SerializeField]
	private UILabel label; // 0x30
	private UICheckBoxSwitchButton target; // 0x38
	[CompilerGenerated]
	private bool <IsEnabled>k__BackingField; // 0x40

	// Properties
	public UICheckBoxSwitchButton CheckBox { get; }
	public bool IsEnabled { get; set; }

	// Methods

	// RVA: 0x1E50A94 Offset: 0x1E4CA94 VA: 0x1E50A94
	public UICheckBoxSwitchButton get_CheckBox() { }

	[CompilerGenerated]
	// RVA: 0x1E50A9C Offset: 0x1E4CA9C VA: 0x1E50A9C
	public bool get_IsEnabled() { }

	[CompilerGenerated]
	// RVA: 0x1E50AA4 Offset: 0x1E4CAA4 VA: 0x1E50AA4
	private void set_IsEnabled(bool value) { }

	// RVA: 0x1E50AB0 Offset: 0x1E4CAB0 VA: 0x1E50AB0
	public void Initialize(UICheckBoxSwitchButton target, string text, bool isEnabled) { }

	// RVA: 0x1E50B24 Offset: 0x1E4CB24 VA: 0x1E50B24
	public void SpriteAlphaChange(bool isEnabled) { }

	// RVA: 0x1E50B70 Offset: 0x1E4CB70 VA: 0x1E50B70
	public void OnClick() { }

	// RVA: 0x1E50C08 Offset: 0x1E4CC08 VA: 0x1E50C08
	public void .ctor() { }
}
