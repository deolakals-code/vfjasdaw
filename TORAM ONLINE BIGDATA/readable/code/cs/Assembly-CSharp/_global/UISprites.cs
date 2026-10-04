// Assembly: Assembly-CSharp.dll
// Namespace: 
[AddComponentMenu("NGUI/UI/Sprites")]
[ExecuteInEditMode]
public class UISprites : UIWidget // TypeDefIndex: 185
{
	// Fields
	[SerializeField]
	private UIAtlas mAtlas; // 0x108
	[SerializeField]
	[HideInInspector]
	private bool mFillCenter; // 0x110
	[SerializeField]
	public UISprites.UISpritesData[] spritesData; // 0x118
	protected Rect mInnerUV; // 0x120
	protected Rect mOuterUV; // 0x130
	private Vector2 mPos; // 0x140

	// Properties
	public UIAtlas atlas { get; set; }
	public override Material material { get; }
	public override int minWidth { get; }
	public override int minHeight { get; }

	// Methods

	// RVA: 0x20D796C Offset: 0x20D396C VA: 0x20D796C
	public UIAtlas get_atlas() { }

	// RVA: 0x20D7974 Offset: 0x20D3974 VA: 0x20D7974
	public void set_atlas(UIAtlas value) { }

	// RVA: 0x20D7A28 Offset: 0x20D3A28 VA: 0x20D7A28 Slot: 14
	public override Material get_material() { }

	// RVA: 0x20D7AB0 Offset: 0x20D3AB0 VA: 0x20D7AB0 Slot: 25
	public override int get_minWidth() { }

	// RVA: 0x20D7AB8 Offset: 0x20D3AB8 VA: 0x20D7AB8 Slot: 26
	public override int get_minHeight() { }

	// RVA: 0x20D7AC0 Offset: 0x20D3AC0 VA: 0x20D7AC0
	public UISpriteData GetAtlasSprite(string spriteName) { }

	// RVA: 0x20D7B6C Offset: 0x20D3B6C VA: 0x20D7B6C Slot: 24
	public override void MakePixelPerfect() { }

	// RVA: 0x20D7B8C Offset: 0x20D3B8C VA: 0x20D7B8C Slot: 22
	public override void Update() { }

	// RVA: 0x20D7B94 Offset: 0x20D3B94 VA: 0x20D7B94 Slot: 29
	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols, float valpha) { }

	// RVA: 0x20D8B00 Offset: 0x20D4B00 VA: 0x20D8B00
	private Vector4 GetDrawingDimensions(UISpriteData mSprite) { }

	// RVA: 0x20D7E58 Offset: 0x20D3E58 VA: 0x20D7E58
	protected void SimpleFill(UISpriteData mSprite, BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols) { }

	// RVA: 0x20D80BC Offset: 0x20D40BC VA: 0x20D80BC
	protected void SlicedFill(UISpriteData mSprite, BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols) { }

	// RVA: 0x20D8660 Offset: 0x20D4660 VA: 0x20D8660
	protected void TiledFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols) { }

	// RVA: 0x20D8BD4 Offset: 0x20D4BD4 VA: 0x20D8BD4
	public void .ctor() { }
}
