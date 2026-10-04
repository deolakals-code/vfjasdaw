// Assembly: Assembly-CSharp.dll
// Namespace: 
[ExecuteInEditMode]
public class UIGLLabel : UIGLWidget, IUILabel // TypeDefIndex: 204
{
	// Fields
	[SerializeField]
	private string mText; // 0x30
	[SerializeField]
	private Color mColor; // 0x38
	[SerializeField]
	private UIWidget.Pivot mPivot; // 0x48
	[SerializeField]
	private UILabel.Effect mEffectStyle; // 0x4C
	[SerializeField]
	private Color mEffectColor; // 0x50
	[SerializeField]
	private Vector2 mEffectDistance; // 0x60
	[SerializeField]
	private bool mEncoding; // 0x68
	protected UIFont fontAtlas; // 0x70
	protected BetterList<Vector3> verts; // 0x78
	protected BetterList<Vector2> uvs; // 0x80
	protected BetterList<Color32> cols; // 0x88
	private int mWidth; // 0x90
	private int mHeight; // 0x94
	private float mAlpha; // 0x98
	protected bool isChangeColor; // 0x9C
	private Vector2 textSize; // 0xA0
	private int fontLayerId; // 0xA8

	// Properties
	public override byte AtlasId { get; }
	public string text { get; set; }
	public override Color color { get; set; }
	public override float alpha { get; set; }
	public int width { get; }
	public int height { get; }
	public Vector2 printedSize { get; }
	public UILabel.Effect effectStyle { get; set; }
	public Color effectColor { get; set; }
	public Vector2 effectDistance { get; set; }
	public UIWidget.Pivot pivot { get; set; }
	public Material AtlasMaterial { get; }
	public UIFont Font { get; }

	// Methods

	// RVA: 0x21BDBD4 Offset: 0x21B9BD4 VA: 0x21BDBD4 Slot: 8
	public override byte get_AtlasId() { }

	// RVA: 0x21BDBE0 Offset: 0x21B9BE0 VA: 0x21BDBE0 Slot: 18
	public string get_text() { }

	// RVA: 0x21BDBE8 Offset: 0x21B9BE8 VA: 0x21BDBE8 Slot: 19
	public void set_text(string value) { }

	// RVA: 0x21BE2DC Offset: 0x21BA2DC VA: 0x21BE2DC Slot: 10
	public override Color get_color() { }

	// RVA: 0x21BE2E8 Offset: 0x21BA2E8 VA: 0x21BE2E8 Slot: 11
	public override void set_color(Color value) { }

	// RVA: 0x21BE338 Offset: 0x21BA338 VA: 0x21BE338 Slot: 12
	public override float get_alpha() { }

	// RVA: 0x21BE340 Offset: 0x21BA340 VA: 0x21BE340 Slot: 13
	public override void set_alpha(float value) { }

	// RVA: 0x21BE358 Offset: 0x21BA358 VA: 0x21BE358 Slot: 30
	public int get_width() { }

	// RVA: 0x21BE360 Offset: 0x21BA360 VA: 0x21BE360
	public int get_height() { }

	// RVA: 0x21BE368 Offset: 0x21BA368 VA: 0x21BE368 Slot: 35
	public Vector2 get_printedSize() { }

	// RVA: 0x21BE370 Offset: 0x21BA370 VA: 0x21BE370 Slot: 24
	public UILabel.Effect get_effectStyle() { }

	// RVA: 0x21BE378 Offset: 0x21BA378 VA: 0x21BE378 Slot: 25
	public void set_effectStyle(UILabel.Effect value) { }

	// RVA: 0x21BE38C Offset: 0x21BA38C VA: 0x21BE38C Slot: 26
	public Color get_effectColor() { }

	// RVA: 0x21BE398 Offset: 0x21BA398 VA: 0x21BE398 Slot: 27
	public void set_effectColor(Color value) { }

	// RVA: 0x21BE41C Offset: 0x21BA41C VA: 0x21BE41C Slot: 28
	public Vector2 get_effectDistance() { }

	// RVA: 0x21BE424 Offset: 0x21BA424 VA: 0x21BE424 Slot: 29
	public void set_effectDistance(Vector2 value) { }

	// RVA: 0x21BE454 Offset: 0x21BA454 VA: 0x21BE454 Slot: 33
	public UIWidget.Pivot get_pivot() { }

	// RVA: 0x21BE45C Offset: 0x21BA45C VA: 0x21BE45C Slot: 34
	public void set_pivot(UIWidget.Pivot value) { }

	// RVA: 0x21BE474 Offset: 0x21BA474 VA: 0x21BE474
	public Material get_AtlasMaterial() { }

	// RVA: 0x21BE490 Offset: 0x21BA490 VA: 0x21BE490
	public UIFont get_Font() { }

	// RVA: 0x21BE498 Offset: 0x21BA498 VA: 0x21BE498 Slot: 14
	protected override void Initialize() { }

	// RVA: 0x21BE5C4 Offset: 0x21BA5C4 VA: 0x21BE5C4 Slot: 16
	public override bool OnUpdataFontAtlas(UIFont fontAtlas) { }

	// RVA: 0x21BE604 Offset: 0x21BA604 VA: 0x21BE604
	public void OnEnable() { }

	// RVA: 0x21BDC5C Offset: 0x21B9C5C VA: 0x21BDC5C
	private void UpdateFontData() { }

	// RVA: 0x21BE6F4 Offset: 0x21BA6F4 VA: 0x21BE6F4 Slot: 17
	public override bool OnDraw() { }

	// RVA: 0x21BEA88 Offset: 0x21BAA88 VA: 0x21BEA88 Slot: 36
	protected virtual bool CheckViewArea() { }

	// RVA: 0x21BEB7C Offset: 0x21BAB7C VA: 0x21BEB7C Slot: 37
	protected virtual void DrawText(Vector3 pos, Vector3 matrix, bool vsColor) { }

	// RVA: 0x21BED7C Offset: 0x21BAD7C VA: 0x21BED7C
	public void .ctor() { }

	// RVA: 0x21BEF88 Offset: 0x21BAF88 VA: 0x21BEF88 Slot: 31
	private bool IUILabel.get_enabled() { }

	// RVA: 0x21BEF90 Offset: 0x21BAF90 VA: 0x21BEF90 Slot: 32
	private void IUILabel.set_enabled(bool value) { }
}
