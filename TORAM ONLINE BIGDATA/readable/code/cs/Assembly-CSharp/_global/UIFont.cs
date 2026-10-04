// Assembly: Assembly-CSharp.dll
// Namespace: 
[AddComponentMenu("NGUI/UI/Font")]
[ExecuteInEditMode]
public class UIFont : MonoBehaviour // TypeDefIndex: 162
{
	// Fields
	[HideInInspector]
	[SerializeField]
	private Material mMat; // 0x20
	[SerializeField]
	[HideInInspector]
	private Rect mUVRect; // 0x28
	[HideInInspector]
	[SerializeField]
	private BMFont mFont; // 0x38
	[HideInInspector]
	[SerializeField]
	private int mSpacingX; // 0x40
	[HideInInspector]
	[SerializeField]
	private int mSpacingY; // 0x44
	[HideInInspector]
	[SerializeField]
	private UIAtlas mAtlas; // 0x48
	[HideInInspector]
	[SerializeField]
	private UIFont mReplacement; // 0x50
	[SerializeField]
	[HideInInspector]
	private float mPixelSize; // 0x58
	[SerializeField]
	[HideInInspector]
	private List<BMSymbol> mSymbols; // 0x60
	[SerializeField]
	[HideInInspector]
	private Font mDynamicFont; // 0x68
	[HideInInspector]
	[SerializeField]
	private int mDynamicFontSize; // 0x70
	[SerializeField]
	[HideInInspector]
	private FontStyle mDynamicFontStyle; // 0x74
	[HideInInspector]
	[SerializeField]
	private float mDynamicFontOffset; // 0x78
	private UISpriteData mSprite; // 0x80
	private int mPMA; // 0x88
	private bool mSpriteSet; // 0x8C
	[HideInInspector]
	[SerializeField]
	private int trueTypeFontSize; // 0x90
	private List<Color> mColors; // 0x98
	private readonly float NUMSIZE; // 0xA0
	private static CharacterInfo mTemp; // 0x0
	private static CharacterInfo mChar; // 0x34

	// Properties
	public BMFont bmFont { get; }
	public int texWidth { get; }
	public int texHeight { get; }
	public bool hasSymbols { get; }
	public List<BMSymbol> symbols { get; }
	public UIAtlas atlas { get; set; }
	public Material material { get; set; }
	public float pixelSize { get; set; }
	public bool premultipliedAlpha { get; }
	public Texture2D texture { get; }
	public Rect uvRect { get; set; }
	public string spriteName { get; set; }
	public int horizontalSpacing { get; set; }
	public int verticalSpacing { get; set; }
	public bool isValid { get; }
	public int size { get; }
	public UISpriteData sprite { get; }
	public UIFont replacement { get; set; }
	public bool isDynamic { get; }
	public Font dynamicFont { get; set; }
	public int dynamicFontSize { get; set; }
	public FontStyle dynamicFontStyle { get; set; }
	private Texture dynamicTexture { get; }

	// Methods

	// RVA: 0x1FCCCF0 Offset: 0x1FC8CF0 VA: 0x1FCCCF0
	public BMFont get_bmFont() { }

	// RVA: 0x1FCCD6C Offset: 0x1FC8D6C VA: 0x1FCCD6C
	public int get_texWidth() { }

	// RVA: 0x1FCCDF8 Offset: 0x1FC8DF8 VA: 0x1FCCDF8
	public int get_texHeight() { }

	// RVA: 0x1FCCE84 Offset: 0x1FC8E84 VA: 0x1FCCE84
	public bool get_hasSymbols() { }

	// RVA: 0x1FCCF28 Offset: 0x1FC8F28 VA: 0x1FCCF28
	public List<BMSymbol> get_symbols() { }

	// RVA: 0x1FC7468 Offset: 0x1FC3468 VA: 0x1FC7468
	public UIAtlas get_atlas() { }

	// RVA: 0x1FC74E4 Offset: 0x1FC34E4 VA: 0x1FC74E4
	public void set_atlas(UIAtlas value) { }

	// RVA: 0x1FCD53C Offset: 0x1FC953C VA: 0x1FCD53C
	public Material get_material() { }

	// RVA: 0x1FCD6EC Offset: 0x1FC96EC VA: 0x1FCD6EC
	public void set_material(Material value) { }

	// RVA: 0x1FCD7CC Offset: 0x1FC97CC VA: 0x1FCD7CC
	public float get_pixelSize() { }

	// RVA: 0x1FCD888 Offset: 0x1FC9888 VA: 0x1FCD888
	public void set_pixelSize(float value) { }

	// RVA: 0x1FCD990 Offset: 0x1FC9990 VA: 0x1FCD990
	public bool get_premultipliedAlpha() { }

	// RVA: 0x1FCDB40 Offset: 0x1FC9B40 VA: 0x1FCDB40
	public Texture2D get_texture() { }

	// RVA: 0x1FCD184 Offset: 0x1FC9184 VA: 0x1FCD184
	public Rect get_uvRect() { }

	// RVA: 0x1FCE08C Offset: 0x1FCA08C VA: 0x1FCE08C
	public void set_uvRect(Rect value) { }

	// RVA: 0x1FCE184 Offset: 0x1FCA184 VA: 0x1FCE184
	public string get_spriteName() { }

	// RVA: 0x1FCE208 Offset: 0x1FCA208 VA: 0x1FCE208
	public void set_spriteName(string value) { }

	// RVA: 0x1FCE2D4 Offset: 0x1FCA2D4 VA: 0x1FCE2D4
	public int get_horizontalSpacing() { }

	// RVA: 0x1FCE350 Offset: 0x1FCA350 VA: 0x1FCE350
	public void set_horizontalSpacing(int value) { }

	// RVA: 0x1FCE3FC Offset: 0x1FCA3FC VA: 0x1FCE3FC
	public int get_verticalSpacing() { }

	// RVA: 0x1FCE478 Offset: 0x1FCA478 VA: 0x1FCE478
	public void set_verticalSpacing(int value) { }

	// RVA: 0x1FCE524 Offset: 0x1FCA524 VA: 0x1FCE524
	public bool get_isValid() { }

	// RVA: 0x1FCE5AC Offset: 0x1FCA5AC VA: 0x1FCE5AC
	public int get_size() { }

	// RVA: 0x1FCCFA4 Offset: 0x1FC8FA4 VA: 0x1FCCFA4
	public UISpriteData get_sprite() { }

	// RVA: 0x1FCE740 Offset: 0x1FCA740 VA: 0x1FCE740
	public UIFont get_replacement() { }

	// RVA: 0x1FCE748 Offset: 0x1FCA748 VA: 0x1FCE748
	public void set_replacement(UIFont value) { }

	// RVA: 0x1FCE650 Offset: 0x1FCA650 VA: 0x1FCE650
	public bool get_isDynamic() { }

	// RVA: 0x1FCE8A0 Offset: 0x1FCA8A0 VA: 0x1FCE8A0
	public Font get_dynamicFont() { }

	// RVA: 0x1FCE91C Offset: 0x1FCA91C VA: 0x1FCE91C
	public void set_dynamicFont(Font value) { }

	// RVA: 0x1FCE6B0 Offset: 0x1FCA6B0 VA: 0x1FCE6B0
	public int get_dynamicFontSize() { }

	// RVA: 0x1FCEA28 Offset: 0x1FCAA28 VA: 0x1FCEA28
	public void set_dynamicFontSize(int value) { }

	// RVA: 0x1FCEB04 Offset: 0x1FCAB04 VA: 0x1FCEB04
	public FontStyle get_dynamicFontStyle() { }

	// RVA: 0x1FCEBA0 Offset: 0x1FCABA0 VA: 0x1FCEBA0
	public void set_dynamicFontStyle(FontStyle value) { }

	// RVA: 0x1FCDC30 Offset: 0x1FC9C30 VA: 0x1FCDC30
	private void Trim() { }

	// RVA: 0x1FCEC64 Offset: 0x1FCAC64 VA: 0x1FCEC64
	private bool References(UIFont font) { }

	// RVA: 0x1FCED3C Offset: 0x1FCAD3C VA: 0x1FCED3C
	public static bool CheckIfRelated(UIFont a, UIFont b) { }

	// RVA: 0x1FCEEAC Offset: 0x1FCAEAC VA: 0x1FCEEAC
	private Texture get_dynamicTexture() { }

	// RVA: 0x1FCD348 Offset: 0x1FC9348 VA: 0x1FCD348
	public void MarkAsDirty() { }

	// RVA: 0x1FCEF58 Offset: 0x1FCAF58 VA: 0x1FCEF58
	public void Request(string text) { }

	// RVA: 0x1FCF148 Offset: 0x1FCB148 VA: 0x1FCF148 Slot: 4
	public virtual Vector2 CalculatePrintedSize(string text, bool encoding, UIFont.SymbolStyle symbolStyle) { }

	// RVA: 0x1FCF7B0 Offset: 0x1FCB7B0 VA: 0x1FCF7B0
	private static void EndLine(ref StringBuilder s) { }

	// RVA: 0x1FCF838 Offset: 0x1FCB838 VA: 0x1FCF838
	public string GetEndOfLineThatFits(string text, float maxWidth, bool encoding, UIFont.SymbolStyle symbolStyle) { }

	// RVA: 0x1FCFC34 Offset: 0x1FCBC34 VA: 0x1FCFC34 Slot: 5
	public virtual bool WrapText(string text, out string finalText, int width, int height, int maxLines, bool encoding, UIFont.SymbolStyle symbolStyle, char wordWrapSeparatorChar = '\x0') { }

	// RVA: 0x1FD05A4 Offset: 0x1FCC5A4 VA: 0x1FD05A4 Slot: 6
	public virtual bool WrapText(string text, out string finalText, int width, int height, int maxLines, bool encoding) { }

	// RVA: 0x1FD05D4 Offset: 0x1FCC5D4 VA: 0x1FD05D4 Slot: 7
	public virtual bool WrapText(string text, out string finalText, int width, int height, int maxLineCount) { }

	// RVA: 0x1FD0604 Offset: 0x1FCC604 VA: 0x1FD0604
	private void Align(BetterList<Vector3> verts, int indexOffset, UIFont.Alignment alignment, int x, int lineWidth) { }

	// RVA: 0x1FD0788 Offset: 0x1FCC788 VA: 0x1FD0788 Slot: 8
	public virtual void Print(string text, Color32 color, BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols, bool encoding, UIFont.SymbolStyle symbolStyle, UIFont.Alignment alignment, int lineWidth, bool premultiply) { }

	// RVA: 0x1FD1444 Offset: 0x1FCD444 VA: 0x1FD1444 Slot: 9
	protected virtual void PrintUVBMGlyph(BMGlyph glyph, Rect mUVRect, float invX, float invY, out Vector2 u0, out Vector2 u1) { }

	// RVA: 0x1FD153C Offset: 0x1FCD53C VA: 0x1FD153C
	private BMSymbol GetSymbol(string sequence, bool createIfMissing) { }

	// RVA: 0x1FCF65C Offset: 0x1FCB65C VA: 0x1FCF65C
	private BMSymbol MatchSymbol(string text, int offset, int textLength) { }

	// RVA: 0x1FD16C0 Offset: 0x1FCD6C0 VA: 0x1FD16C0
	public void AddSymbol(string sequence, string spriteName) { }

	// RVA: 0x1FD16FC Offset: 0x1FCD6FC VA: 0x1FD16FC
	public void RemoveSymbol(string sequence) { }

	// RVA: 0x1FD1778 Offset: 0x1FCD778 VA: 0x1FD1778
	public void RenameSymbol(string before, string after) { }

	// RVA: 0x1FD17B0 Offset: 0x1FCD7B0 VA: 0x1FD17B0
	public bool UsesSprite(string s) { }

	// RVA: 0x1FD18A8 Offset: 0x1FCD8A8 VA: 0x1FD18A8
	public bool LoadFontData(string dataName) { }

	// RVA: 0x1FD19A4 Offset: 0x1FCD9A4 VA: 0x1FD19A4 Slot: 10
	public virtual bool LoadFontData(UIFontData fontData) { }

	// RVA: 0x1FD1ABC Offset: 0x1FCDABC VA: 0x1FD1ABC
	private bool CheckHalfWidthChara(char c) { }

	// RVA: 0x1FD1AF8 Offset: 0x1FCDAF8 VA: 0x1FD1AF8
	public void .ctor() { }
}
