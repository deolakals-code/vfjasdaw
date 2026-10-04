// Assembly: Assembly-CSharp.dll
// Namespace: 
[ExecuteInEditMode]
public class UIGLSpriteVertex : UIGLWidget // TypeDefIndex: 221
{
	// Fields
	[SerializeField]
	private string spriteName; // 0x30
	[SerializeField]
	private Vector3 offset; // 0x38
	[SerializeField]
	private Color mColor; // 0x44
	[SerializeField]
	private UIWidget.Pivot pivot; // 0x54
	private Rect uv; // 0x58
	private float[] vertexX; // 0x68
	private float[] vertexY; // 0x70
	private float[] drawVertexX; // 0x78
	private float[] drawVertexY; // 0x80
	[SerializeField]
	private float mAlpha; // 0x88
	private UIAtlas setAtlas; // 0x90
	public Vector2 MoveBottomLeft; // 0x98
	public Vector2 MoveBottomRight; // 0xA0
	public Vector2 MoveUpLeft; // 0xA8
	public Vector2 MoveUpRight; // 0xB0
	public bool IsFreeSize; // 0xB8

	// Properties
	public override Color color { get; set; }
	public override float alpha { get; set; }

	// Methods

	// RVA: 0x21C6A78 Offset: 0x21C2A78 VA: 0x21C6A78 Slot: 10
	public override Color get_color() { }

	// RVA: 0x21C6A84 Offset: 0x21C2A84 VA: 0x21C6A84 Slot: 11
	public override void set_color(Color value) { }

	// RVA: 0x21C6AD4 Offset: 0x21C2AD4 VA: 0x21C6AD4 Slot: 12
	public override float get_alpha() { }

	// RVA: 0x21C6ADC Offset: 0x21C2ADC VA: 0x21C6ADC Slot: 13
	public override void set_alpha(float value) { }

	// RVA: 0x21C6AF4 Offset: 0x21C2AF4 VA: 0x21C6AF4
	public bool CheckAtlasSprite(string name) { }

	// RVA: 0x21C6B90 Offset: 0x21C2B90 VA: 0x21C6B90
	public bool ChangeSprite(string spriteName) { }

	// RVA: 0x21C6C14 Offset: 0x21C2C14 VA: 0x21C6C14 Slot: 15
	public override bool OnAttlas(UIAtlas atlas) { }

	// RVA: 0x21C6E0C Offset: 0x21C2E0C VA: 0x21C6E0C Slot: 17
	public override bool OnDraw() { }

	// RVA: 0x21C718C Offset: 0x21C318C VA: 0x21C718C
	public void .ctor() { }
}
