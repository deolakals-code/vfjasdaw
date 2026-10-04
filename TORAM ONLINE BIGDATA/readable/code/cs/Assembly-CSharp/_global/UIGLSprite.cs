// Assembly: Assembly-CSharp.dll
// Namespace: 
[ExecuteInEditMode]
public class UIGLSprite : UIGLWidget, IUIGLImageButtonSprite // TypeDefIndex: 214
{
	// Fields
	[SerializeField]
	protected string spriteName; // 0x30
	[SerializeField]
	private Vector3 offset; // 0x38
	[SerializeField]
	private Color mColor; // 0x44
	[SerializeField]
	protected UIWidget.Pivot pivot; // 0x54
	protected Rect uv; // 0x58
	protected float[] vertexX; // 0x68
	protected float[] vertexY; // 0x70
	private float[] drawVertexX; // 0x78
	private float[] drawVertexY; // 0x80
	[SerializeField]
	private float mAlpha; // 0x88
	protected UIAtlas setAtlas; // 0x90

	// Properties
	public override Color color { get; set; }
	public override float alpha { get; set; }
	public override byte AtlasId { get; set; }
	public string SpriteName { get; }

	// Methods

	// RVA: 0x21C2DD4 Offset: 0x21BEDD4 VA: 0x21C2DD4 Slot: 10
	public override Color get_color() { }

	// RVA: 0x21C2DE0 Offset: 0x21BEDE0 VA: 0x21C2DE0 Slot: 11
	public override void set_color(Color value) { }

	// RVA: 0x21C2E30 Offset: 0x21BEE30 VA: 0x21C2E30 Slot: 12
	public override float get_alpha() { }

	// RVA: 0x21C2E38 Offset: 0x21BEE38 VA: 0x21C2E38 Slot: 13
	public override void set_alpha(float value) { }

	// RVA: 0x21C2E50 Offset: 0x21BEE50 VA: 0x21C2E50 Slot: 8
	public override byte get_AtlasId() { }

	// RVA: 0x21C2E58 Offset: 0x21BEE58 VA: 0x21C2E58 Slot: 9
	public override void set_AtlasId(byte value) { }

	// RVA: 0x21C2E60 Offset: 0x21BEE60 VA: 0x21C2E60
	public string get_SpriteName() { }

	// RVA: 0x21C2E68 Offset: 0x21BEE68 VA: 0x21C2E68
	public bool CheckAtlasSprite(string name) { }

	// RVA: 0x21C2F04 Offset: 0x21BEF04 VA: 0x21C2F04 Slot: 19
	public virtual bool ChangeSprite(string spriteName) { }

	// RVA: 0x21C2F88 Offset: 0x21BEF88 VA: 0x21C2F88 Slot: 15
	public override bool OnAttlas(UIAtlas atlas) { }

	// RVA: 0x21C31BC Offset: 0x21BF1BC VA: 0x21C31BC Slot: 17
	public override bool OnDraw() { }

	// RVA: 0x21C34D4 Offset: 0x21BF4D4 VA: 0x21C34D4
	public void .ctor() { }
}
