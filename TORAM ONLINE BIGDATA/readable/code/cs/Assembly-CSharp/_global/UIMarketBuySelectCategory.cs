// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMarketBuySelectCategory : MonoBehaviour // TypeDefIndex: 8430
{
	// Fields
	private readonly int limitWidth; // 0x20
	private readonly int limitHeight; // 0x24
	private readonly int iconSize; // 0x28
	private readonly int[] itemIconParam; // 0x30
	[SerializeField]
	private UIIcon categoryIcon; // 0x38
	[SerializeField]
	private UILabel categoryLabel; // 0x40
	[SerializeField]
	private UIIcon listIconOrigin; // 0x48
	private int currentTypeIndex; // 0x50
	private Action<ItemType> callback; // 0x58
	private List<ItemType> categoryList; // 0x60
	private List<TweenScale> iconList; // 0x68
	private SystemTextManager systemTextManager; // 0x70

	// Properties
	public ItemType SelectedCategory { get; }

	// Methods

	// RVA: 0x1D61098 Offset: 0x1D5D098 VA: 0x1D61098
	public ItemType get_SelectedCategory() { }

	// RVA: 0x1D610EC Offset: 0x1D5D0EC VA: 0x1D610EC
	private void Awake() { }

	// RVA: 0x1D610F0 Offset: 0x1D5D0F0 VA: 0x1D610F0
	public void Initialize() { }

	// RVA: 0x1D61174 Offset: 0x1D5D174 VA: 0x1D61174
	public void Initialize(ItemType[] categories, bool isAutoLineUp = True) { }

	// RVA: 0x1D612D4 Offset: 0x1D5D2D4 VA: 0x1D612D4
	private void initializeIconList(bool isAutoLineUp) { }

	// RVA: 0x1D61770 Offset: 0x1D5D770 VA: 0x1D61770
	private void AddIcon(Vector3 pos) { }

	// RVA: 0x1D61B3C Offset: 0x1D5DB3C VA: 0x1D61B3C
	public void Open(ItemType defaultType, Action<ItemType> callback) { }

	// RVA: 0x1D61EF0 Offset: 0x1D5DEF0 VA: 0x1D61EF0
	public void Close() { }

	// RVA: 0x1D61F14 Offset: 0x1D5DF14 VA: 0x1D61F14
	private void onRight() { }

	// RVA: 0x1D61F7C Offset: 0x1D5DF7C VA: 0x1D61F7C
	private void onLeft() { }

	// RVA: 0x1D61E4C Offset: 0x1D5DE4C VA: 0x1D61E4C
	private void updateSelectCategory() { }

	// RVA: 0x1D61FE0 Offset: 0x1D5DFE0 VA: 0x1D61FE0
	public int GetCategoryIconParam() { }

	// RVA: 0x1D61AAC Offset: 0x1D5DAAC VA: 0x1D61AAC
	public int GetCategoryIconParam(int index) { }

	// RVA: 0x1D61FE8 Offset: 0x1D5DFE8 VA: 0x1D61FE8
	public string GetCategoryName() { }

	// RVA: 0x1D62094 Offset: 0x1D5E094 VA: 0x1D62094
	private void onConfirm() { }

	// RVA: 0x1D61BE8 Offset: 0x1D5DBE8 VA: 0x1D61BE8
	private void onSelectIcon(int param) { }

	// RVA: 0x1D62138 Offset: 0x1D5E138 VA: 0x1D62138
	public void .ctor() { }
}
