// Assembly: Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class BMFont // TypeDefIndex: 66
{
	// Fields
	[SerializeField]
	[HideInInspector]
	private int mSize; // 0x10
	[SerializeField]
	[HideInInspector]
	private int mBase; // 0x14
	[HideInInspector]
	[SerializeField]
	private int mWidth; // 0x18
	[SerializeField]
	[HideInInspector]
	private int mHeight; // 0x1C
	[HideInInspector]
	[SerializeField]
	private string mSpriteName; // 0x20
	[SerializeField]
	[HideInInspector]
	private List<BMGlyph> mSaved; // 0x28
	public Dictionary<int, BMGlyph> mDict; // 0x30

	// Properties
	public bool isValid { get; }
	public int charSize { get; set; }
	public int baseOffset { get; set; }
	public int texWidth { get; set; }
	public int texHeight { get; set; }
	public int glyphCount { get; }
	public string spriteName { get; set; }

	// Methods

	// RVA: 0x1729778 Offset: 0x1725778 VA: 0x1729778
	public bool get_isValid() { }

	// RVA: 0x17297C8 Offset: 0x17257C8 VA: 0x17297C8
	public int get_charSize() { }

	// RVA: 0x17297D0 Offset: 0x17257D0 VA: 0x17297D0
	public void set_charSize(int value) { }

	// RVA: 0x17297D8 Offset: 0x17257D8 VA: 0x17297D8
	public int get_baseOffset() { }

	// RVA: 0x17297E0 Offset: 0x17257E0 VA: 0x17297E0
	public void set_baseOffset(int value) { }

	// RVA: 0x17297E8 Offset: 0x17257E8 VA: 0x17297E8
	public int get_texWidth() { }

	// RVA: 0x17297F0 Offset: 0x17257F0 VA: 0x17297F0
	public void set_texWidth(int value) { }

	// RVA: 0x17297F8 Offset: 0x17257F8 VA: 0x17297F8
	public int get_texHeight() { }

	// RVA: 0x1729800 Offset: 0x1725800 VA: 0x1729800
	public void set_texHeight(int value) { }

	// RVA: 0x1729808 Offset: 0x1725808 VA: 0x1729808
	public int get_glyphCount() { }

	// RVA: 0x1729864 Offset: 0x1725864 VA: 0x1729864
	public string get_spriteName() { }

	// RVA: 0x172986C Offset: 0x172586C VA: 0x172986C
	public void set_spriteName(string value) { }

	// RVA: 0x1729874 Offset: 0x1725874 VA: 0x1729874
	public BMGlyph GetGlyph(int index, bool createIfMissing) { }

	// RVA: 0x1729880 Offset: 0x1725880 VA: 0x1729880
	public BMGlyph GetGlyph(int index, bool createIfMissing, bool doSave) { }

	// RVA: 0x1729A9C Offset: 0x1725A9C VA: 0x1729A9C
	public BMGlyph GetGlyph(int index) { }

	// RVA: 0x1729AA8 Offset: 0x1725AA8 VA: 0x1729AA8
	public void Clear() { }

	// RVA: 0x1729B3C Offset: 0x1725B3C VA: 0x1729B3C
	public void Trim(int xMin, int yMin, int xMax, int yMax) { }

	// RVA: 0x1729C9C Offset: 0x1725C9C VA: 0x1729C9C
	public void .ctor() { }
}
