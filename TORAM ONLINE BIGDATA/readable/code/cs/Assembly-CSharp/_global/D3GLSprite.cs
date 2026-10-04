// Assembly: Assembly-CSharp.dll
// Namespace: 
[ExecuteInEditMode]
public class D3GLSprite : MonoBehaviour // TypeDefIndex: 8748
{
	// Fields
	[SerializeField]
	private UIAtlas mAtlas; // 0x20
	[SerializeField]
	private string mSpriteName; // 0x28
	[SerializeField]
	private D3GLSprite.Type mType; // 0x30
	[SerializeField]
	private UIWidget.Pivot mPivot; // 0x34
	[SerializeField]
	private Color mColor; // 0x38
	private Rect uv; // 0x48
	private float[] atlasVertexX; // 0x58
	private float[] atlasVertexY; // 0x60
	private float[] vertexX; // 0x68
	private float[] vertexY; // 0x70
	private float[] drawVertexX; // 0x78
	private float[] drawVertexY; // 0x80
	private float mAlpha; // 0x88
	private Vector2 size; // 0x8C
	private Vector3 offset; // 0x94
	private Vector3 scale; // 0xA0
	private float[] uvX; // 0xB0
	private float[] uvY; // 0xB8
	private float[] slicedVertexX; // 0xC0
	private float[] slicedVertexY; // 0xC8
	private float[] drawSlicedVertexX; // 0xD0
	private float[] drawSlicedVertexY; // 0xD8
	private Camera mDrawCamera; // 0xE0

	// Properties
	public virtual D3GLSprite.Type type { get; set; }
	public UIAtlas atlas { get; set; }
	public string spriteName { get; set; }
	public Color color { get; set; }
	public Camera drawCamera { get; set; }
	public int width { get; set; }
	public int height { get; set; }

	// Methods

	// RVA: 0x1DFFBC8 Offset: 0x1DFBBC8 VA: 0x1DFFBC8 Slot: 4
	public virtual D3GLSprite.Type get_type() { }

	// RVA: 0x1DFFBD0 Offset: 0x1DFBBD0 VA: 0x1DFFBD0 Slot: 5
	public virtual void set_type(D3GLSprite.Type value) { }

	// RVA: 0x1DFFBE4 Offset: 0x1DFBBE4 VA: 0x1DFFBE4
	public UIAtlas get_atlas() { }

	// RVA: 0x1DFFBEC Offset: 0x1DFBBEC VA: 0x1DFFBEC
	public void set_atlas(UIAtlas value) { }

	// RVA: 0x1DFFD64 Offset: 0x1DFBD64 VA: 0x1DFFD64
	public string get_spriteName() { }

	// RVA: 0x1DFFD6C Offset: 0x1DFBD6C VA: 0x1DFFD6C
	public void set_spriteName(string value) { }

	// RVA: 0x1E004A4 Offset: 0x1DFC4A4 VA: 0x1E004A4
	public Color get_color() { }

	// RVA: 0x1E004B0 Offset: 0x1DFC4B0 VA: 0x1E004B0
	public void set_color(Color value) { }

	// RVA: 0x1E00500 Offset: 0x1DFC500 VA: 0x1E00500
	public Camera get_drawCamera() { }

	// RVA: 0x1E00508 Offset: 0x1DFC508 VA: 0x1E00508
	public void set_drawCamera(Camera value) { }

	// RVA: 0x1E00510 Offset: 0x1DFC510 VA: 0x1E00510
	public int get_width() { }

	// RVA: 0x1E00530 Offset: 0x1DFC530 VA: 0x1E00530
	public void set_width(int value) { }

	// RVA: 0x1E0053C Offset: 0x1DFC53C VA: 0x1E0053C
	public int get_height() { }

	// RVA: 0x1E0055C Offset: 0x1DFC55C VA: 0x1E0055C
	public void set_height(int value) { }

	// RVA: 0x1E00568 Offset: 0x1DFC568 VA: 0x1E00568
	private void Start() { }

	// RVA: 0x1E0056C Offset: 0x1DFC56C VA: 0x1E0056C
	private void OnRenderObject() { }

	// RVA: 0x1DFFE24 Offset: 0x1DFBE24 VA: 0x1DFFE24
	private void CreateObject() { }

	// RVA: 0x1E007B0 Offset: 0x1DFC7B0 VA: 0x1E007B0
	private void OnDraw() { }

	// RVA: 0x1E00A50 Offset: 0x1DFCA50 VA: 0x1E00A50
	private void OnDrawSliced() { }

	// RVA: 0x1E00F60 Offset: 0x1DFCF60 VA: 0x1E00F60
	public void .ctor() { }
}
