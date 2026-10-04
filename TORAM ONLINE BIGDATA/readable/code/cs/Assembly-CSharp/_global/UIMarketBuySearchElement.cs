// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMarketBuySearchElement : MonoBehaviour // TypeDefIndex: 8384
{
	// Fields
	private readonly Color notMatchedIconColor; // 0x20
	private readonly Color matchedIconColor; // 0x30
	[SerializeField]
	private ItemIcon itemLabel; // 0x40
	[SerializeField]
	private TweenColor itemLabelTweenColor; // 0x48
	[SerializeField]
	private LocalizeText numLabel; // 0x50
	[SerializeField]
	private GameObject[] cristaSlot; // 0x58
	[SerializeField]
	private UIIcon[] cristaSprite; // 0x60
	[SerializeField]
	private UISprite[] colorSprite; // 0x68
	[SerializeField]
	private UILabel spinaLabel; // 0x70
	[SerializeField]
	private UILabel costLabel; // 0x78
	[SerializeField]
	private UILabel potentialLabel; // 0x80
	[SerializeField]
	private UISprite rPropertySprite; // 0x88
	[SerializeField]
	private GameObject MostUpFrames; // 0x90
	[SerializeField]
	private GameObject MostBottomFrames; // 0x98
	[SerializeField]
	private GameObject MiddleFrames; // 0xA0
	[SerializeField]
	private GameObject SingleFrames; // 0xA8
	private Action<int> buyCallback; // 0xB0
	private Action<int> detailCallback; // 0xB8
	private ItemTextManager itemTextManager; // 0xC0
	private int uniqueId; // 0xC8
	private UIMarketProductData productData; // 0xD0
	private EnemyTextManager enemyTextManager; // 0xD8
	private SkillTextManager skillTextManager; // 0xE0
	private SystemTextManager systemTextManager; // 0xE8

	// Properties
	public UIMarketProductData ProductData { get; }

	// Methods

	// RVA: 0x1D3BB6C Offset: 0x1D37B6C VA: 0x1D3BB6C
	public UIMarketProductData get_ProductData() { }

	// RVA: 0x1D3BB74 Offset: 0x1D37B74 VA: 0x1D3BB74
	private void Awake() { }

	// RVA: 0x1D34910 Offset: 0x1D30910 VA: 0x1D34910
	public void Initialize(UIMarketProductData product, int uniqueId, Action<int> buycallback, Action<int> detailcallback) { }

	// RVA: 0x1D358E4 Offset: 0x1D318E4 VA: 0x1D358E4
	public void InitializeStarGem(UIMarketProductData product, int uniqueId, Action<int> buycallback, Action<int> detailcallback) { }

	// RVA: 0x1D3BE38 Offset: 0x1D37E38 VA: 0x1D3BE38
	private void onClickBuy() { }

	// RVA: 0x1D3BE58 Offset: 0x1D37E58 VA: 0x1D3BE58
	private void onClickIcon() { }

	// RVA: 0x1D3BE78 Offset: 0x1D37E78 VA: 0x1D3BE78
	public void SetMostTopFrame() { }

	// RVA: 0x1D3BFB4 Offset: 0x1D37FB4 VA: 0x1D3BFB4
	public void SetMostBottomFrame() { }

	// RVA: 0x1D3C0F0 Offset: 0x1D380F0 VA: 0x1D3C0F0
	public void SetMiddleFrame() { }

	// RVA: 0x1D3C22C Offset: 0x1D3822C VA: 0x1D3C22C
	public void SetSingleFrame() { }

	// RVA: 0x1D3C368 Offset: 0x1D38368 VA: 0x1D3C368
	public void .ctor() { }
}
