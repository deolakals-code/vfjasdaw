// Assembly: UnityEngine.TextRenderingModule.dll
// Namespace: UnityEngine
[UsedByNativeCode]
public struct CharacterInfo // TypeDefIndex: 17852
{
	// Fields
	public int index; // 0x0
	[Obsolete("CharacterInfo.uv is deprecated. Use uvBottomLeft, uvBottomRight, uvTopRight or uvTopLeft instead.")]
	public Rect uv; // 0x4
	[Obsolete("CharacterInfo.vert is deprecated. Use minX, maxX, minY, maxY instead.")]
	public Rect vert; // 0x14
	[Obsolete("CharacterInfo.width is deprecated. Use advance instead.")]
	[NativeName("advance")]
	public float width; // 0x24
	public int size; // 0x28
	public FontStyle style; // 0x2C
	[Obsolete("CharacterInfo.flipped is deprecated. Use uvBottomLeft, uvBottomRight, uvTopRight or uvTopLeft instead, which will be correct regardless of orientation.")]
	public bool flipped; // 0x30

	// Properties
	public int glyphWidth { get; }
	public int glyphHeight { get; }
	public int maxY { get; }
	public int minX { get; }
	internal Vector2 uvBottomLeftUnFlipped { get; }
	internal Vector2 uvTopRightUnFlipped { get; }
	public Vector2 uvBottomLeft { get; }
	public Vector2 uvTopRight { get; }

	// Methods

	// RVA: 0x3823278 Offset: 0x381F278 VA: 0x3823278
	public int get_glyphWidth() { }

	// RVA: 0x3823298 Offset: 0x381F298 VA: 0x3823298
	public int get_glyphHeight() { }

	// RVA: 0x38232BC Offset: 0x381F2BC VA: 0x38232BC
	public int get_maxY() { }

	// RVA: 0x38232DC Offset: 0x381F2DC VA: 0x38232DC
	public int get_minX() { }

	// RVA: 0x38232FC Offset: 0x381F2FC VA: 0x38232FC
	internal Vector2 get_uvBottomLeftUnFlipped() { }

	// RVA: 0x3823304 Offset: 0x381F304 VA: 0x3823304
	internal Vector2 get_uvTopRightUnFlipped() { }

	// RVA: 0x3823318 Offset: 0x381F318 VA: 0x3823318
	public Vector2 get_uvBottomLeft() { }

	// RVA: 0x3823320 Offset: 0x381F320 VA: 0x3823320
	public Vector2 get_uvTopRight() { }
}
