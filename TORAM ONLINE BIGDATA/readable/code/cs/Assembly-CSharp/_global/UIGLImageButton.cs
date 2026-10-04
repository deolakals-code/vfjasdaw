// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGLImageButton : MonoBehaviour // TypeDefIndex: 200
{
	// Fields
	[SerializeField]
	private UIGLImageButton.SpriteType spriteType; // 0x20
	[SerializeField]
	private UIGLWidget target; // 0x28
	[SerializeField]
	private string normalSprite; // 0x30
	[SerializeField]
	private string hoverSprite; // 0x38
	[SerializeField]
	private string pressedSprite; // 0x40
	[SerializeField]
	private string disabledSprite; // 0x48

	// Properties
	public bool isEnabled { get; set; }

	// Methods

	// RVA: 0x20DD124 Offset: 0x20D9124 VA: 0x20DD124
	public bool get_isEnabled() { }

	// RVA: 0x20DD1D8 Offset: 0x20D91D8 VA: 0x20DD1D8
	public void set_isEnabled(bool value) { }

	// RVA: 0x20DD394 Offset: 0x20D9394 VA: 0x20DD394
	private void OnEnable() { }

	// RVA: 0x20DD2B0 Offset: 0x20D92B0 VA: 0x20DD2B0
	private void UpdateImage() { }

	// RVA: 0x20DD43C Offset: 0x20D943C VA: 0x20DD43C
	private void ChangeSprite(string spriteName) { }

	// RVA: 0x20DD564 Offset: 0x20D9564 VA: 0x20DD564
	private void OnHover(bool isOver) { }

	// RVA: 0x20DD600 Offset: 0x20D9600 VA: 0x20DD600
	private void OnPress(bool pressed) { }

	// RVA: 0x20DD610 Offset: 0x20D9610 VA: 0x20DD610
	public void .ctor() { }
}
