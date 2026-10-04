// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGLLabelView // TypeDefIndex: 206
{
	// Fields
	private string mText; // 0x10
	protected Color mColor; // 0x18
	private UIWidget.Pivot mPivot; // 0x28
	private UILabel.Effect mEffectStyle; // 0x2C
	private Color mEffectColor; // 0x30
	private Vector2 mEffectDistance; // 0x40
	private bool mEncoding; // 0x48
	protected UIFont fontAtlas; // 0x50
	protected BetterList<Vector3> verts; // 0x58
	protected BetterList<Vector2> uvs; // 0x60
	protected BetterList<Color32> cols; // 0x68
	private int mWidth; // 0x70
	private int mHeight; // 0x74
	protected float mAlpha; // 0x78
	private bool isInitStack; // 0x7C

	// Properties
	public int Height { get; }
	public int Width { get; }

	// Methods

	// RVA: 0x21BF108 Offset: 0x21BB108 VA: 0x21BF108
	public int get_Height() { }

	// RVA: 0x21BF110 Offset: 0x21BB110 VA: 0x21BF110
	public int get_Width() { }

	// RVA: 0x21BF118 Offset: 0x21BB118 VA: 0x21BF118
	public void .ctor(UIFont fontAtlas, string text, UIWidget.Pivot pivot, bool encoding) { }

	// RVA: 0x21BF45C Offset: 0x21BB45C VA: 0x21BF45C
	public void .ctor(UIFont fontAtlas, string text, UIWidget.Pivot pivot, Color color, bool encoding) { }

	// RVA: 0x21BF534 Offset: 0x21BB534 VA: 0x21BF534
	public void .ctor(UIFont fontAtlas, string text, UIWidget.Pivot pivot, Color color, bool encoding, UILabel.Effect effectStyle, Color effectColor, Vector2 effectDistance) { }

	// RVA: 0x21BF1D0 Offset: 0x21BB1D0 VA: 0x21BF1D0
	public void .ctor(UIFont fontAtlas, string text, UIWidget.Pivot pivot, Color color, bool encoding, UILabel.Effect effectStyle, Color effectColor, Vector2 effectDistance, bool isInitStack) { }

	// RVA: 0x21BFAD4 Offset: 0x21BBAD4 VA: 0x21BFAD4
	public void Active() { }

	// RVA: 0x21BF548 Offset: 0x21BB548 VA: 0x21BF548
	private void UpdateFontData(bool isInit) { }

	// RVA: 0x21BFAF8 Offset: 0x21BBAF8 VA: 0x21BFAF8
	public void SetAlpha(float a) { }

	// RVA: 0x21BFB00 Offset: 0x21BBB00 VA: 0x21BFB00 Slot: 4
	public virtual bool OnDraw(Matrix4x4 localToWorldMatrix, Vector3 position) { }

	// RVA: 0x21BFE60 Offset: 0x21BBE60 VA: 0x21BFE60 Slot: 5
	protected virtual bool CheckViewArea() { }

	// RVA: 0x21BFE68 Offset: 0x21BBE68 VA: 0x21BFE68 Slot: 6
	protected virtual void DrawText(Vector3 pos, Vector3 worldPos, Vector3 matrix, bool vsColor) { }
}
