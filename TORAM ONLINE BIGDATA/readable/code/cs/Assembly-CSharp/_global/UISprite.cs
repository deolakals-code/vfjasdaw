// Assembly: Assembly-CSharp.dll
// Namespace: 
[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/Sprite")]
public class UISprite : UIWidget // TypeDefIndex: 180
{
	// Fields
	[HideInInspector]
	[SerializeField]
	private UIAtlas mAtlas; // 0x108
	[HideInInspector]
	[SerializeField]
	private string mSpriteName; // 0x110
	[HideInInspector]
	[SerializeField]
	private bool mFillCenter; // 0x118
	[HideInInspector]
	[SerializeField]
	private UISprite.Type mType; // 0x11C
	[HideInInspector]
	[SerializeField]
	private UISprite.FillDirection mFillDirection; // 0x120
	[HideInInspector]
	[SerializeField]
	private float mFillAmount; // 0x124
	[SerializeField]
	[HideInInspector]
	private bool mInvert; // 0x128
	protected UISpriteData mSprite; // 0x130
	protected Rect mInnerUV; // 0x138
	protected Rect mOuterUV; // 0x148
	private bool mSpriteSet; // 0x158
	public bool IsTileLoop; // 0x159
	private float loopTimer; // 0x15C
	private bool tileLoopVer2; // 0x160

	// Properties
	public virtual UISprite.Type type { get; set; }
	public override Material material { get; }
	public UIAtlas atlas { get; set; }
	public string spriteName { get; set; }
	public bool isValid { get; }
	public bool fillCenter { get; set; }
	public UISprite.FillDirection fillDirection { get; set; }
	public float fillAmount { get; set; }
	public bool invert { get; set; }
	public override Vector4 border { get; }
	public override int minWidth { get; }
	public override int minHeight { get; }
	private Vector4 drawingDimensions { get; }

	// Methods

	// RVA: 0x20D4210 Offset: 0x20D0210 VA: 0x20D4210 Slot: 30
	public virtual UISprite.Type get_type() { }

	// RVA: 0x20D4218 Offset: 0x20D0218 VA: 0x20D4218 Slot: 31
	public virtual void set_type(UISprite.Type value) { }

	// RVA: 0x20D423C Offset: 0x20D023C VA: 0x20D423C Slot: 14
	public override Material get_material() { }

	// RVA: 0x20D42C4 Offset: 0x20D02C4 VA: 0x20D42C4
	public UIAtlas get_atlas() { }

	// RVA: 0x20D42CC Offset: 0x20D02CC VA: 0x20D42CC
	public void set_atlas(UIAtlas value) { }

	// RVA: 0x20D4604 Offset: 0x20D0604 VA: 0x20D4604
	public string get_spriteName() { }

	// RVA: 0x20D454C Offset: 0x20D054C VA: 0x20D454C
	public void set_spriteName(string value) { }

	// RVA: 0x20D460C Offset: 0x20D060C VA: 0x20D460C
	public bool get_isValid() { }

	// RVA: 0x20D482C Offset: 0x20D082C VA: 0x20D482C
	public bool get_fillCenter() { }

	// RVA: 0x20D4834 Offset: 0x20D0834 VA: 0x20D4834
	public void set_fillCenter(bool value) { }

	// RVA: 0x20D485C Offset: 0x20D085C VA: 0x20D485C
	public UISprite.FillDirection get_fillDirection() { }

	// RVA: 0x20D4864 Offset: 0x20D0864 VA: 0x20D4864
	public void set_fillDirection(UISprite.FillDirection value) { }

	// RVA: 0x20D4880 Offset: 0x20D0880 VA: 0x20D4880
	public float get_fillAmount() { }

	// RVA: 0x20D4888 Offset: 0x20D0888 VA: 0x20D4888
	public void set_fillAmount(float value) { }

	// RVA: 0x20D48B8 Offset: 0x20D08B8 VA: 0x20D48B8
	public bool get_invert() { }

	// RVA: 0x20D48C0 Offset: 0x20D08C0 VA: 0x20D48C0
	public void set_invert(bool value) { }

	// RVA: 0x20D48E0 Offset: 0x20D08E0 VA: 0x20D48E0 Slot: 27
	public override Vector4 get_border() { }

	// RVA: 0x20D497C Offset: 0x20D097C VA: 0x20D497C Slot: 25
	public override int get_minWidth() { }

	// RVA: 0x20D4AA8 Offset: 0x20D0AA8 VA: 0x20D4AA8 Slot: 26
	public override int get_minHeight() { }

	// RVA: 0x20D4624 Offset: 0x20D0624 VA: 0x20D4624
	public UISpriteData GetAtlasSprite() { }

	// RVA: 0x20D449C Offset: 0x20D049C VA: 0x20D449C
	protected void SetAtlasSprite(UISpriteData sp) { }

	// RVA: 0x20D4BD4 Offset: 0x20D0BD4 VA: 0x20D4BD4 Slot: 24
	public override void MakePixelPerfect() { }

	// RVA: 0x20D4EBC Offset: 0x20D0EBC VA: 0x20D4EBC Slot: 22
	public override void Update() { }

	// RVA: 0x20D4F74 Offset: 0x20D0F74 VA: 0x20D4F74 Slot: 29
	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols, float valpha) { }

	// RVA: 0x20D6BCC Offset: 0x20D2BCC VA: 0x20D6BCC
	private Vector4 get_drawingDimensions() { }

	// RVA: 0x20D5294 Offset: 0x20D1294 VA: 0x20D5294
	protected void SimpleFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols, float valpha) { }

	// RVA: 0x20D556C Offset: 0x20D156C VA: 0x20D556C
	protected void SlicedFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols, float valpha) { }

	// RVA: 0x20D64A4 Offset: 0x20D24A4 VA: 0x20D64A4
	protected void TiledFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols, float valpha) { }

	// RVA: 0x20D5BCC Offset: 0x20D1BCC VA: 0x20D5BCC
	protected void FilledFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols, float valpha) { }

	// RVA: 0x20D6CC4 Offset: 0x20D2CC4 VA: 0x20D6CC4
	private static bool RadialCut(Vector2[] xy, Vector2[] uv, float fill, bool invert, int corner) { }

	// RVA: 0x20D6D98 Offset: 0x20D2D98 VA: 0x20D6D98
	private static void RadialCut(Vector2[] xy, float cos, float sin, bool invert, int corner) { }

	// RVA: 0x20D71A0 Offset: 0x20D31A0 VA: 0x20D71A0
	public void .ctor() { }
}
