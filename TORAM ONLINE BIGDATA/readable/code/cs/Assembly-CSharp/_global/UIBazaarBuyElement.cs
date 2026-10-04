// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIBazaarBuyElement : MonoBehaviour // TypeDefIndex: 8248
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
	private GameObject MostUpFrames; // 0x80
	[SerializeField]
	private GameObject MostBottomFrames; // 0x88
	[SerializeField]
	private GameObject MiddleFrames; // 0x90
	[SerializeField]
	private GameObject SingleFrames; // 0x98
	[CompilerGenerated]
	private BazaarItemData <BazaarItemData>k__BackingField; // 0xA0
	[CompilerGenerated]
	private ItemData <Item>k__BackingField; // 0xA8
	[CompilerGenerated]
	private StarGemData <StarGemData>k__BackingField; // 0xB0
	private Action<int> buyCallback; // 0xB8
	private Action<int> detailCallback; // 0xC0
	private ItemTextManager itemTextManager; // 0xC8
	private int uniqueId; // 0xD0
	private EnemyTextManager enemyTextManager; // 0xD8
	private SkillTextManager skillTextManager; // 0xE0
	private SystemTextManager systemTextManager; // 0xE8

	// Properties
	public BazaarItemData BazaarItemData { get; set; }
	public ItemData Item { get; set; }
	public StarGemData StarGemData { get; set; }
	public bool IsStarGem { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1D03868 Offset: 0x1CFF868 VA: 0x1D03868
	public BazaarItemData get_BazaarItemData() { }

	[CompilerGenerated]
	// RVA: 0x1D03870 Offset: 0x1CFF870 VA: 0x1D03870
	private void set_BazaarItemData(BazaarItemData value) { }

	[CompilerGenerated]
	// RVA: 0x1D03878 Offset: 0x1CFF878 VA: 0x1D03878
	public ItemData get_Item() { }

	[CompilerGenerated]
	// RVA: 0x1D03880 Offset: 0x1CFF880 VA: 0x1D03880
	private void set_Item(ItemData value) { }

	[CompilerGenerated]
	// RVA: 0x1D03888 Offset: 0x1CFF888 VA: 0x1D03888
	public StarGemData get_StarGemData() { }

	[CompilerGenerated]
	// RVA: 0x1D03890 Offset: 0x1CFF890 VA: 0x1D03890
	private void set_StarGemData(StarGemData value) { }

	// RVA: 0x1D030D0 Offset: 0x1CFF0D0 VA: 0x1D030D0
	public bool get_IsStarGem() { }

	// RVA: 0x1D03898 Offset: 0x1CFF898 VA: 0x1D03898
	private void Awake() { }

	// RVA: 0x1D016EC Offset: 0x1CFD6EC VA: 0x1D016EC
	public void Initialize(BazaarItemData data, int uniqueId, Action<int> buycallback, Action<int> detailcallback) { }

	// RVA: 0x1D03B5C Offset: 0x1CFFB5C VA: 0x1D03B5C
	private void InitializeStarGem() { }

	// RVA: 0x1D03F54 Offset: 0x1CFFF54 VA: 0x1D03F54
	private void onClickBuy() { }

	// RVA: 0x1D03F74 Offset: 0x1CFFF74 VA: 0x1D03F74
	private void onClickIcon() { }

	// RVA: 0x1D03F94 Offset: 0x1CFFF94 VA: 0x1D03F94
	public void SetMostTopFrame() { }

	// RVA: 0x1D040D0 Offset: 0x1D000D0 VA: 0x1D040D0
	public void SetMostBottomFrame() { }

	// RVA: 0x1D0420C Offset: 0x1D0020C VA: 0x1D0420C
	public void SetMiddleFrame() { }

	// RVA: 0x1D04348 Offset: 0x1D00348 VA: 0x1D04348
	public void SetSingleFrame() { }

	// RVA: 0x1D04484 Offset: 0x1D00484 VA: 0x1D04484
	public void .ctor() { }
}
