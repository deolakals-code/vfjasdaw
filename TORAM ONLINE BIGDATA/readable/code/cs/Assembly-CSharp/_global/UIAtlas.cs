// Assembly: Assembly-CSharp.dll
// Namespace: 
[AddComponentMenu("NGUI/UI/Atlas")]
public class UIAtlas : MonoBehaviour // TypeDefIndex: 153
{
	// Fields
	[SerializeField]
	protected Material material; // 0x20
	[SerializeField]
	protected List<UISpriteData> mSprites; // 0x28
	[HideInInspector]
	[SerializeField]
	private float mPixelSize; // 0x30
	[HideInInspector]
	[SerializeField]
	protected UIAtlas mReplacement; // 0x38
	[HideInInspector]
	[SerializeField]
	private UIAtlas.Coordinates mCoordinates; // 0x40
	[HideInInspector]
	[SerializeField]
	private List<UIAtlas.Sprite> sprites; // 0x48
	private int mPMA; // 0x50

	// Properties
	public Material spriteMaterial { get; set; }
	public bool premultipliedAlpha { get; }
	public List<UISpriteData> spriteList { get; set; }
	public Texture texture { get; }
	public float pixelSize { get; set; }
	public UIAtlas replacement { get; set; }

	// Methods

	// RVA: 0x1FC54EC Offset: 0x1FC14EC VA: 0x1FC54EC
	public Material get_spriteMaterial() { }

	// RVA: 0x1FC5568 Offset: 0x1FC1568 VA: 0x1FC5568
	public void set_spriteMaterial(Material value) { }

	// RVA: 0x1FC5964 Offset: 0x1FC1964 VA: 0x1FC5964
	public bool get_premultipliedAlpha() { }

	// RVA: 0x1FC5AD0 Offset: 0x1FC1AD0 VA: 0x1FC5AD0
	public List<UISpriteData> get_spriteList() { }

	// RVA: 0x1FC6660 Offset: 0x1FC2660 VA: 0x1FC6660
	public void set_spriteList(List<UISpriteData> value) { }

	// RVA: 0x1FC66F0 Offset: 0x1FC26F0 VA: 0x1FC66F0
	public Texture get_texture() { }

	// RVA: 0x1FC67B0 Offset: 0x1FC27B0 VA: 0x1FC67B0
	public float get_pixelSize() { }

	// RVA: 0x1FC682C Offset: 0x1FC282C VA: 0x1FC682C
	public void set_pixelSize(float value) { }

	// RVA: 0x1FC68EC Offset: 0x1FC28EC VA: 0x1FC68EC
	public UIAtlas get_replacement() { }

	// RVA: 0x1FC68F4 Offset: 0x1FC28F4 VA: 0x1FC68F4
	public void set_replacement(UIAtlas value) { }

	// RVA: 0x1FC6A4C Offset: 0x1FC2A4C VA: 0x1FC6A4C
	public bool ContainsSprite(string name) { }

	// RVA: 0x1FC6B74 Offset: 0x1FC2B74 VA: 0x1FC6B74
	public UISpriteData GetSprite(string name) { }

	// RVA: 0x1FC6CC0 Offset: 0x1FC2CC0 VA: 0x1FC6CC0
	public void SortAlphabetically() { }

	// RVA: 0x1FC6DC4 Offset: 0x1FC2DC4 VA: 0x1FC6DC4
	public BetterList<string> GetListOfSprites() { }

	// RVA: 0x1FC6F3C Offset: 0x1FC2F3C VA: 0x1FC6F3C
	public BetterList<string> GetListOfSprites(string match) { }

	// RVA: 0x1FC7298 Offset: 0x1FC3298 VA: 0x1FC7298
	private bool References(UIAtlas atlas) { }

	// RVA: 0x1FC7370 Offset: 0x1FC3370 VA: 0x1FC7370
	public static bool CheckIfRelated(UIAtlas a, UIAtlas b) { }

	// RVA: 0x1FC5660 Offset: 0x1FC1660 VA: 0x1FC5660
	public void MarkAsDirty() { }

	// RVA: 0x1FC5B7C Offset: 0x1FC1B7C VA: 0x1FC5B7C
	private bool Upgrade() { }

	// RVA: 0x1FC7910 Offset: 0x1FC3910 VA: 0x1FC7910
	public void .ctor() { }
}
