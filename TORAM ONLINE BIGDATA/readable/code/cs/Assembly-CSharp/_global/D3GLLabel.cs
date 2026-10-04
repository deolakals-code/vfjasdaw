// Assembly: Assembly-CSharp.dll
// Namespace: 
[ExecuteInEditMode]
public class D3GLLabel : MonoBehaviour, IUILabel // TypeDefIndex: 8746
{
	// Fields
	[SerializeField]
	private UIFont mFont; // 0x20
	[SerializeField]
	private string mText; // 0x28
	[SerializeField]
	private Color mColor; // 0x30
	[SerializeField]
	private UIWidget.Pivot mPivot; // 0x40
	[SerializeField]
	private UILabel.Effect mEffectStyle; // 0x44
	[SerializeField]
	private Color mEffectColor; // 0x48
	[SerializeField]
	private Vector2 mEffectDistance; // 0x58
	[SerializeField]
	private bool mEncoding; // 0x60
	private UIGL3DSignboardLabelView textLabel; // 0x68
	private Material textMaterial; // 0x70
	private float mAlpha; // 0x78
	private Camera mDrawCamera; // 0x80

	// Properties
	public string text { get; set; }
	public float alpha { get; set; }
	public Color color { get; set; }
	public UILabel.Effect effectStyle { get; set; }
	public Color effectColor { get; set; }
	public Vector2 effectDistance { get; set; }
	public UIWidget.Pivot pivot { get; set; }
	public UIFont font { get; set; }
	public bool supportEncoding { get; set; }
	public Camera drawCamera { get; set; }
	public int width { get; }
	public Vector2 printedSize { get; }

	// Methods

	// RVA: 0x1DFEFE8 Offset: 0x1DFAFE8 VA: 0x1DFEFE8
	public static D3GLLabel CreateLabel(string text) { }

	// RVA: 0x1DFF128 Offset: 0x1DFB128 VA: 0x1DFF128 Slot: 4
	public string get_text() { }

	// RVA: 0x1DFF0D0 Offset: 0x1DFB0D0 VA: 0x1DFF0D0 Slot: 5
	public void set_text(string value) { }

	// RVA: 0x1DFF148 Offset: 0x1DFB148 VA: 0x1DFF148 Slot: 6
	public float get_alpha() { }

	// RVA: 0x1DFF150 Offset: 0x1DFB150 VA: 0x1DFF150 Slot: 7
	public void set_alpha(float value) { }

	// RVA: 0x1DFF17C Offset: 0x1DFB17C VA: 0x1DFF17C Slot: 8
	public Color get_color() { }

	// RVA: 0x1DFF188 Offset: 0x1DFB188 VA: 0x1DFF188 Slot: 9
	public void set_color(Color value) { }

	// RVA: 0x1DFF1F4 Offset: 0x1DFB1F4 VA: 0x1DFF1F4 Slot: 10
	public UILabel.Effect get_effectStyle() { }

	// RVA: 0x1DFF1FC Offset: 0x1DFB1FC VA: 0x1DFF1FC Slot: 11
	public void set_effectStyle(UILabel.Effect value) { }

	// RVA: 0x1DFF22C Offset: 0x1DFB22C VA: 0x1DFF22C Slot: 12
	public Color get_effectColor() { }

	// RVA: 0x1DFF238 Offset: 0x1DFB238 VA: 0x1DFF238 Slot: 13
	public void set_effectColor(Color value) { }

	// RVA: 0x1DFF2D8 Offset: 0x1DFB2D8 VA: 0x1DFF2D8 Slot: 14
	public Vector2 get_effectDistance() { }

	// RVA: 0x1DFF2E0 Offset: 0x1DFB2E0 VA: 0x1DFF2E0 Slot: 15
	public void set_effectDistance(Vector2 value) { }

	// RVA: 0x1DFF32C Offset: 0x1DFB32C VA: 0x1DFF32C Slot: 19
	public UIWidget.Pivot get_pivot() { }

	// RVA: 0x1DFF334 Offset: 0x1DFB334 VA: 0x1DFF334 Slot: 20
	public void set_pivot(UIWidget.Pivot value) { }

	// RVA: 0x1DFF364 Offset: 0x1DFB364 VA: 0x1DFF364
	public UIFont get_font() { }

	// RVA: 0x1DFF36C Offset: 0x1DFB36C VA: 0x1DFF36C
	public void set_font(UIFont value) { }

	// RVA: 0x1DFF410 Offset: 0x1DFB410 VA: 0x1DFF410
	public bool get_supportEncoding() { }

	// RVA: 0x1DFF418 Offset: 0x1DFB418 VA: 0x1DFF418
	public void set_supportEncoding(bool value) { }

	// RVA: 0x1DFF44C Offset: 0x1DFB44C VA: 0x1DFF44C
	public Camera get_drawCamera() { }

	// RVA: 0x1DFF454 Offset: 0x1DFB454 VA: 0x1DFF454
	public void set_drawCamera(Camera value) { }

	// RVA: 0x1DFF45C Offset: 0x1DFB45C VA: 0x1DFF45C Slot: 16
	public int get_width() { }

	// RVA: 0x1DFF494 Offset: 0x1DFB494 VA: 0x1DFF494 Slot: 21
	public Vector2 get_printedSize() { }

	// RVA: 0x1DFF4CC Offset: 0x1DFB4CC VA: 0x1DFF4CC
	private void Start() { }

	// RVA: 0x1DFF65C Offset: 0x1DFB65C VA: 0x1DFF65C
	private void OnRenderObject() { }

	// RVA: 0x1DFF8E0 Offset: 0x1DFB8E0 VA: 0x1DFF8E0
	private void OnDestroy() { }

	// RVA: 0x1DFF4D0 Offset: 0x1DFB4D0 VA: 0x1DFF4D0
	public void CreateObject() { }

	// RVA: 0x1DFF980 Offset: 0x1DFB980 VA: 0x1DFF980
	public void UpdateLabel() { }

	// RVA: 0x1DFFAD8 Offset: 0x1DFBAD8 VA: 0x1DFFAD8
	public void SetAlpha(float a) { }

	// RVA: 0x1DFF130 Offset: 0x1DFB130 VA: 0x1DFF130
	private void UpdateObject() { }

	// RVA: 0x1DFFAEC Offset: 0x1DFBAEC VA: 0x1DFFAEC
	public void .ctor() { }

	// RVA: 0x1DFFBB4 Offset: 0x1DFBBB4 VA: 0x1DFFBB4 Slot: 17
	private bool IUILabel.get_enabled() { }

	// RVA: 0x1DFFBBC Offset: 0x1DFBBBC VA: 0x1DFFBBC Slot: 18
	private void IUILabel.set_enabled(bool value) { }
}
