// Assembly: Assembly-CSharp.dll
// Namespace: 
[ExecuteInEditMode]
public class UIGLSpriteSliced : UIGLWidget, IUIGLImageButtonSprite // TypeDefIndex: 218
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
	[SerializeField]
	private Vector2 scaling; // 0xA0

	// Properties
	public override Color color { get; set; }
	public override float alpha { get; set; }
	public Vector2 Scaling { get; set; }

	// Methods

	// RVA: 0x21C495C Offset: 0x21C095C VA: 0x21C495C Slot: 10
	public override Color get_color() { }

	// RVA: 0x21C4968 Offset: 0x21C0968 VA: 0x21C4968 Slot: 11
	public override void set_color(Color value) { }

	// RVA: 0x21C49B8 Offset: 0x21C09B8 VA: 0x21C49B8 Slot: 12
	public override float get_alpha() { }

	// RVA: 0x21C49C0 Offset: 0x21C09C0 VA: 0x21C49C0 Slot: 13
	public override void set_alpha(float value) { }

	// RVA: 0x21C49D8 Offset: 0x21C09D8 VA: 0x21C49D8
	public Vector2 get_Scaling() { }

	// RVA: 0x21C49E0 Offset: 0x21C09E0 VA: 0x21C49E0
	public void set_Scaling(Vector2 value) { }

	// RVA: 0x21C4A10 Offset: 0x21C0A10 VA: 0x21C4A10 Slot: 15
	public override bool OnAttlas(UIAtlas atlas) { }

	// RVA: 0x21C4C00 Offset: 0x21C0C00 VA: 0x21C4C00 Slot: 19
	public virtual bool ChangeSprite(string spriteName) { }

	// RVA: 0x21C4C84 Offset: 0x21C0C84 VA: 0x21C4C84 Slot: 17
	public override bool OnDraw() { }

	// RVA: 0x21C51DC Offset: 0x21C11DC VA: 0x21C51DC
	public void .ctor() { }
}
