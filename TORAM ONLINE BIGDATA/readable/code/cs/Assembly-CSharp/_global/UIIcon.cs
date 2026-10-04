// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIIcon : UIIconBase // TypeDefIndex: 8933
{
	// Fields
	[SerializeField]
	private UISprite colorIcon; // 0x28
	[SerializeField]
	private UISprite baseIcon; // 0x30
	[SerializeField]
	private UISprite systemIcon; // 0x38
	[SerializeField]
	private float scale; // 0x40

	// Properties
	public Vector2 SpriteSize { get; }
	public float Size { get; set; }
	public UISprite IconSprite { get; }
	public UISprite ColorIconSprite { get; }
	public UISprite SystemIconSprite { get; }

	// Methods

	// RVA: 0x1E5A990 Offset: 0x1E56990 VA: 0x1E5A990
	public Vector2 get_SpriteSize() { }

	// RVA: 0x1E5A9B4 Offset: 0x1E569B4 VA: 0x1E5A9B4
	public float get_Size() { }

	// RVA: 0x1E5A9BC Offset: 0x1E569BC VA: 0x1E5A9BC
	public void set_Size(float value) { }

	// RVA: 0x1E5ABF0 Offset: 0x1E56BF0 VA: 0x1E5ABF0
	public UISprite get_IconSprite() { }

	// RVA: 0x1E5ABF8 Offset: 0x1E56BF8 VA: 0x1E5ABF8
	public UISprite get_ColorIconSprite() { }

	// RVA: 0x1E5AC00 Offset: 0x1E56C00 VA: 0x1E5AC00
	public UISprite get_SystemIconSprite() { }

	// RVA: 0x1E5AC08 Offset: 0x1E56C08 VA: 0x1E5AC08 Slot: 4
	protected override void OnEnable() { }

	// RVA: 0x1E5AD28 Offset: 0x1E56D28 VA: 0x1E5AD28 Slot: 5
	protected override void OnDisable() { }

	// RVA: 0x1E5AE28 Offset: 0x1E56E28 VA: 0x1E5AE28 Slot: 6
	protected override bool CheckSprite(string spriteName) { }

	// RVA: 0x1E5AE4C Offset: 0x1E56E4C VA: 0x1E5AE4C Slot: 9
	public override void NonIcon() { }

	// RVA: 0x1E5AF14 Offset: 0x1E56F14 VA: 0x1E5AF14 Slot: 7
	public override void SetIcon(string spriteName, Color color) { }

	// RVA: 0x1E5B11C Offset: 0x1E5711C VA: 0x1E5B11C Slot: 8
	public override void SetSystemIcon(string spriteName, Color color) { }

	// RVA: 0x1E5B3B0 Offset: 0x1E573B0 VA: 0x1E5B3B0
	public void .ctor() { }
}
