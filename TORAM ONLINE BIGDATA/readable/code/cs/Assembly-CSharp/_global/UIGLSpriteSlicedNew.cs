// Assembly: Assembly-CSharp.dll
// Namespace: 
[ExecuteInEditMode]
public class UIGLSpriteSlicedNew : UIGLWidget, IUIGLImageButtonSprite // TypeDefIndex: 219
{
	// Fields
	[SerializeField]
	private string spriteName; // 0x30
	[SerializeField]
	private Vector3 offset; // 0x38
	[SerializeField]
	private Vector2 size; // 0x44
	[SerializeField]
	private Color mColor; // 0x4C
	[SerializeField]
	private UIWidget.Pivot pivot; // 0x5C
	[SerializeField]
	private float mAlpha; // 0x60
	protected UIAtlas setAtlas; // 0x68
	private float[] uvX; // 0x70
	private float[] uvY; // 0x78
	private float[] vertexX; // 0x80
	private float[] vertexY; // 0x88
	private float[] drawVertexX; // 0x90
	private float[] drawVertexY; // 0x98

	// Properties
	public override Color color { get; set; }
	public override float alpha { get; set; }
	public int width { get; set; }
	public int heigth { get; set; }
	public string SpriteName { get; }

	// Methods

	// RVA: 0x21C53A0 Offset: 0x21C13A0 VA: 0x21C53A0 Slot: 10
	public override Color get_color() { }

	// RVA: 0x21C53AC Offset: 0x21C13AC VA: 0x21C53AC Slot: 11
	public override void set_color(Color value) { }

	// RVA: 0x21C53FC Offset: 0x21C13FC VA: 0x21C53FC Slot: 12
	public override float get_alpha() { }

	// RVA: 0x21C5404 Offset: 0x21C1404 VA: 0x21C5404 Slot: 13
	public override void set_alpha(float value) { }

	// RVA: 0x21C541C Offset: 0x21C141C VA: 0x21C541C
	public int get_width() { }

	// RVA: 0x21C543C Offset: 0x21C143C VA: 0x21C543C
	public void set_width(int value) { }

	// RVA: 0x21C5448 Offset: 0x21C1448 VA: 0x21C5448
	public int get_heigth() { }

	// RVA: 0x21C5468 Offset: 0x21C1468 VA: 0x21C5468
	public void set_heigth(int value) { }

	// RVA: 0x21C5474 Offset: 0x21C1474 VA: 0x21C5474
	public string get_SpriteName() { }

	// RVA: 0x21C547C Offset: 0x21C147C VA: 0x21C547C Slot: 15
	public override bool OnAttlas(UIAtlas atlas) { }

	// RVA: 0x21C5664 Offset: 0x21C1664 VA: 0x21C5664 Slot: 19
	public virtual bool ChangeSprite(string spriteName) { }

	// RVA: 0x21C56E8 Offset: 0x21C16E8 VA: 0x21C56E8 Slot: 17
	public override bool OnDraw() { }

	// RVA: 0x21C5C88 Offset: 0x21C1C88 VA: 0x21C5C88
	public void .ctor() { }
}
