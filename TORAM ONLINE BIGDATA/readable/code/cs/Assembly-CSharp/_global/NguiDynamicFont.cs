// Assembly: Assembly-CSharp.dll
// Namespace: 
public class NguiDynamicFont : UIFont // TypeDefIndex: 94
{
	// Fields
	private Texture2D workTexture; // 0xA8
	[SerializeField]
	private Texture2D editTexture; // 0xB0
	[SerializeField]
	private Shader editExShader; // 0xB8
	public Font extendFont; // 0xC0
	public int extendImageStartY; // 0xC8
	public int halfCharaRate100; // 0xCC
	protected List<char> cacheCharaS; // 0xD0
	protected List<char> defaultCharaS; // 0xD8
	private bool externalFont; // 0xE0
	private bool initClear; // 0xE1
	private int updateCount; // 0xE4
	private static AndroidJavaClass class_java_a; // 0x0

	// Properties
	private int WritePosiiotn { get; }
	public int FontLayerId { get; }

	// Methods

	// RVA: 0x1737AB8 Offset: 0x1733AB8 VA: 0x1737AB8
	private int get_WritePosiiotn() { }

	// RVA: 0x1737B04 Offset: 0x1733B04 VA: 0x1737B04
	public int get_FontLayerId() { }

	// RVA: 0x1737B24 Offset: 0x1733B24 VA: 0x1737B24
	private void FontClaer() { }

	// RVA: 0x1737CF4 Offset: 0x1733CF4 VA: 0x1737CF4
	private void AllClear() { }

	// RVA: 0x1738C8C Offset: 0x1734C8C VA: 0x1738C8C
	private BMGlyph SetBMFont(int index, int x, int y, int w, int h, int offsetX, int offsetY, int advance) { }

	// RVA: 0x1738D20 Offset: 0x1734D20 VA: 0x1738D20
	public bool UpdateCacheWord(string text) { }

	// RVA: 0x1738E84 Offset: 0x1734E84 VA: 0x1738E84
	private void updateCache(string text) { }

	// RVA: 0x1739D04 Offset: 0x1735D04 VA: 0x1739D04 Slot: 4
	public override Vector2 CalculatePrintedSize(string text, bool encoding, UIFont.SymbolStyle symbolStyle) { }

	// RVA: 0x1739D48 Offset: 0x1735D48 VA: 0x1739D48 Slot: 5
	public override bool WrapText(string text, out string finalText, int width, int height, int maxLines, bool encoding, UIFont.SymbolStyle symbolStyle, char wordWrapSeparatorChar = '\x0') { }

	// RVA: 0x1739AFC Offset: 0x1735AFC VA: 0x1739AFC
	public static void RenderToTextureWindows(Texture2D target, int dst_x, int dst_y, int dst_w, int dst_h, Font font, int fontSize, string text) { }

	// RVA: 0x17396F0 Offset: 0x17356F0 VA: 0x17396F0
	public static void RenderToTextureAndroid(Texture2D target, int dst_x, int dst_y, int dst_w, int dst_h, Font font, int fontSize, string text) { }

	// RVA: 0x1739DC4 Offset: 0x1735DC4 VA: 0x1739DC4
	public void ExternalFont() { }

	// RVA: 0x1739E90 Offset: 0x1735E90 VA: 0x1739E90 Slot: 9
	protected override void PrintUVBMGlyph(BMGlyph glyph, Rect uvRect, float invX, float invY, out Vector2 u0, out Vector2 u1) { }

	// RVA: 0x1739FFC Offset: 0x1735FFC VA: 0x1739FFC Slot: 10
	public override bool LoadFontData(UIFontData fontData) { }

	// RVA: 0x173A014 Offset: 0x1736014 VA: 0x173A014
	public void .ctor() { }
}
