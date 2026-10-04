// Assembly: Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class BMSymbol // TypeDefIndex: 68
{
	// Fields
	public string sequence; // 0x10
	public string spriteName; // 0x18
	private UISpriteData mSprite; // 0x20
	private bool mIsValid; // 0x28
	private int mLength; // 0x2C
	private int mOffsetX; // 0x30
	private int mOffsetY; // 0x34
	private int mWidth; // 0x38
	private int mHeight; // 0x3C
	private int mAdvance; // 0x40
	private Rect mUV; // 0x44

	// Properties
	public int length { get; }
	public int offsetX { get; }
	public int offsetY { get; }
	public int width { get; }
	public int height { get; }
	public int advance { get; }
	public Rect uvRect { get; }

	// Methods

	// RVA: 0x172A030 Offset: 0x1726030 VA: 0x172A030
	public int get_length() { }

	// RVA: 0x172A05C Offset: 0x172605C VA: 0x172A05C
	public int get_offsetX() { }

	// RVA: 0x172A064 Offset: 0x1726064 VA: 0x172A064
	public int get_offsetY() { }

	// RVA: 0x172A06C Offset: 0x172606C VA: 0x172A06C
	public int get_width() { }

	// RVA: 0x172A074 Offset: 0x1726074 VA: 0x172A074
	public int get_height() { }

	// RVA: 0x172A07C Offset: 0x172607C VA: 0x172A07C
	public int get_advance() { }

	// RVA: 0x172A084 Offset: 0x1726084 VA: 0x172A084
	public Rect get_uvRect() { }

	// RVA: 0x172A090 Offset: 0x1726090 VA: 0x172A090
	public void MarkAsDirty() { }

	// RVA: 0x172A098 Offset: 0x1726098 VA: 0x172A098
	public bool Validate(UIAtlas atlas) { }

	// RVA: 0x172A2E8 Offset: 0x17262E8 VA: 0x172A2E8
	public void .ctor() { }
}
