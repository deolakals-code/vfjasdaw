// Assembly: Assembly-CSharp.dll
// Namespace: 
[ExecuteInEditMode]
public class UIGLSpriteTransition : UIGLWidget, IUIGLImageButtonSprite // TypeDefIndex: 220
{
	// Fields
	[SerializeField]
	private Vector3 offset; // 0x2C
	[SerializeField]
	private Color mColor; // 0x38
	[SerializeField]
	protected string spriteName; // 0x48
	[SerializeField]
	protected UIWidget.Pivot pivot; // 0x50
	protected Rect uv; // 0x54
	[SerializeField]
	private float mAlpha; // 0x64
	protected UIAtlas setAtlas; // 0x68
	private float[] drawVertexX; // 0x70
	private float[] drawVertexY; // 0x78
	private Rect drawUV; // 0x80
	protected float[] vertexX; // 0x90
	protected float[] vertexY; // 0x98
	private float[] transitionTime; // 0xA0
	private float startTime; // 0xA8
	private float elapsedTime; // 0xAC
	private bool isTransition; // 0xB0

	// Properties
	public override Color color { get; set; }
	public override float alpha { get; set; }
	public string SpriteName { get; }

	// Methods

	// RVA: 0x21C5E20 Offset: 0x21C1E20 VA: 0x21C5E20 Slot: 10
	public override Color get_color() { }

	// RVA: 0x21C5E2C Offset: 0x21C1E2C VA: 0x21C5E2C Slot: 11
	public override void set_color(Color value) { }

	// RVA: 0x21C5E7C Offset: 0x21C1E7C VA: 0x21C5E7C Slot: 12
	public override float get_alpha() { }

	// RVA: 0x21C5E84 Offset: 0x21C1E84 VA: 0x21C5E84 Slot: 13
	public override void set_alpha(float value) { }

	// RVA: 0x21C5E9C Offset: 0x21C1E9C VA: 0x21C5E9C
	public string get_SpriteName() { }

	// RVA: 0x21C5EA4 Offset: 0x21C1EA4 VA: 0x21C5EA4 Slot: 15
	public override bool OnAttlas(UIAtlas atlas) { }

	// RVA: 0x21C60A8 Offset: 0x21C20A8 VA: 0x21C60A8 Slot: 17
	public override bool OnDraw() { }

	// RVA: 0x21C6418 Offset: 0x21C2418 VA: 0x21C6418 Slot: 18
	public bool ChangeSprite(string spriteName) { }

	// RVA: 0x21C649C Offset: 0x21C249C VA: 0x21C649C
	public void TransitionStart(float widthTime, float heightTime) { }

	// RVA: 0x21C64F8 Offset: 0x21C24F8 VA: 0x21C64F8
	public void TimeCorrection(float currentTime, bool isWidth) { }

	// RVA: 0x21C6574 Offset: 0x21C2574 VA: 0x21C6574
	private void DrawUpdate() { }

	// RVA: 0x21C63AC Offset: 0x21C23AC VA: 0x21C63AC
	private void TweenSpriteVertex(Vector3 pos) { }

	// RVA: 0x21C6600 Offset: 0x21C2600 VA: 0x21C6600
	private void TopToBottom() { }

	// RVA: 0x21C685C Offset: 0x21C285C VA: 0x21C685C
	private void BottomToTop() { }

	// RVA: 0x21C66D0 Offset: 0x21C26D0 VA: 0x21C66D0
	private void RightToLeft() { }

	// RVA: 0x21C679C Offset: 0x21C279C VA: 0x21C679C
	private void LeftToRight() { }

	// RVA: 0x21C6920 Offset: 0x21C2920 VA: 0x21C6920
	public void .ctor() { }
}
