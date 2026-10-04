// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMarketBuy : MonoBehaviour // TypeDefIndex: 8367
{
	// Fields
	[SerializeField]
	private GameObject searchListOriginalObject; // 0x20
	[SerializeField]
	private UIImageButton searchButton; // 0x28
	[SerializeField]
	private UIImageButton orderRegisterButton; // 0x30
	[SerializeField]
	private UIImageButton orderPriceButton; // 0x38
	[SerializeField]
	private UISprite publicCheckButton; // 0x40
	[SerializeField]
	private UISprite guildCheckButton; // 0x48
	[SerializeField]
	private UILabel publicCheckLabel; // 0x50
	[SerializeField]
	private UILabel guildCheckLabel; // 0x58
	[SerializeField]
	private UIMarketBuyNameSearch searchByName; // 0x60
	[SerializeField]
	private UIIcon categoryIcon; // 0x68
	[SerializeField]
	private UILabel categoryLabel; // 0x70
	[SerializeField]
	private UIMarketBuySelectCategory selectCategoryWindow; // 0x78
	[SerializeField]
	private UIScrollWindow scrollWindow; // 0x80
	[SerializeField]
	private BoxCollider scrollCol; // 0x88
	[SerializeField]
	private UIIruna2Anchor mainPanelAnchor; // 0x90
	private Camera scrollCamera; // 0x98
	[SerializeField]
	private UIMarketSearchOption marketSearchOption; // 0xA0
	private ItemType currentCategory; // 0xA8
	private bool isPublic; // 0xAA
	private bool isGuild; // 0xAB
	private bool isOrderByRegister; // 0xAC
	private UIMarketControl topControl; // 0xB0
	private UIMarketBuySearchList searchList; // 0xB8
	private PlayerDataManager playerDataManager; // 0xC0

	// Properties
	private MarketOrderType currentOrderType { get; }
	private MarketType currentMarketType { get; }
	private MarketType currentStarGemMarketType { get; }
	public UIIruna2Anchor MainAnchor { get; }
	public UIMarketControl TopControl { get; }

	// Methods

	// RVA: 0x1D32BF4 Offset: 0x1D2EBF4 VA: 0x1D32BF4
	private MarketOrderType get_currentOrderType() { }

	// RVA: 0x1D32C08 Offset: 0x1D2EC08 VA: 0x1D32C08
	private MarketType get_currentMarketType() { }

	// RVA: 0x1D32C2C Offset: 0x1D2EC2C VA: 0x1D32C2C
	private MarketType get_currentStarGemMarketType() { }

	// RVA: 0x1D32C54 Offset: 0x1D2EC54 VA: 0x1D32C54
	public UIIruna2Anchor get_MainAnchor() { }

	// RVA: 0x1D32C5C Offset: 0x1D2EC5C VA: 0x1D32C5C
	public UIMarketControl get_TopControl() { }

	// RVA: 0x1D32C64 Offset: 0x1D2EC64 VA: 0x1D32C64
	private void Awake() { }

	// RVA: 0x1D31938 Offset: 0x1D2D938 VA: 0x1D31938
	public void Initialize(UIMarketControl control, MarketServiceType serviceType) { }

	// RVA: 0x1D32E38 Offset: 0x1D2EE38 VA: 0x1D32E38
	private void onSelectCategoryButton() { }

	// RVA: 0x1D32F58 Offset: 0x1D2EF58 VA: 0x1D32F58
	private void onSelectedCategory(ItemType type) { }

	// RVA: 0x1D32CC8 Offset: 0x1D2ECC8 VA: 0x1D32CC8
	private void updateSelectedCategory() { }

	// RVA: 0x1D3312C Offset: 0x1D2F12C VA: 0x1D3312C
	private void onOrderByRegister() { }

	// RVA: 0x1D33138 Offset: 0x1D2F138 VA: 0x1D33138
	private void onOrderByPrice() { }

	// RVA: 0x1D32C88 Offset: 0x1D2EC88 VA: 0x1D32C88
	private void updateOrderByButton() { }

	// RVA: 0x1D33140 Offset: 0x1D2F140 VA: 0x1D33140
	private void onSearchByName() { }

	// RVA: 0x1D33214 Offset: 0x1D2F214 VA: 0x1D33214
	private void onSwitchPublic() { }

	// RVA: 0x1D332EC Offset: 0x1D2F2EC VA: 0x1D332EC
	private void onSwitchGuild() { }

	// RVA: 0x1D32D3C Offset: 0x1D2ED3C VA: 0x1D32D3C
	private void updateToggle() { }

	// RVA: 0x1D33430 Offset: 0x1D2F430 VA: 0x1D33430
	private void onSearch() { }

	// RVA: 0x1D33D84 Offset: 0x1D2FD84 VA: 0x1D33D84
	private void closeSearch() { }

	// RVA: 0x1D32054 Offset: 0x1D2E054 VA: 0x1D32054
	public void Close() { }

	// RVA: 0x1D33DE0 Offset: 0x1D2FDE0 VA: 0x1D33DE0
	private void OnDestroy() { }

	// RVA: 0x1D33EF0 Offset: 0x1D2FEF0 VA: 0x1D33EF0
	private void backFromSearchByName() { }

	// RVA: 0x1D33F1C Offset: 0x1D2FF1C VA: 0x1D33F1C
	private void backFromSelectCategory() { }

	// RVA: 0x1D33F5C Offset: 0x1D2FF5C VA: 0x1D33F5C
	public void ChangeEnableScrollWindow(bool isEnable) { }

	// RVA: 0x1D3407C Offset: 0x1D3007C VA: 0x1D3407C
	public void .ctor() { }
}
