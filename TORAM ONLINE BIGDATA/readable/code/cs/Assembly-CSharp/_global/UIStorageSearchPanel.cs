// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIStorageSearchPanel : MonoBehaviour // TypeDefIndex: 8628
{
	// Fields
	[SerializeField]
	private UIImageButton searchButton; // 0x20
	[SerializeField]
	private UIIcon categoryIcon; // 0x28
	[SerializeField]
	private UILabel categoryLabel; // 0x30
	[SerializeField]
	private UIScrollWindow scrollWindow; // 0x38
	[SerializeField]
	private BoxCollider scrollCol; // 0x40
	[SerializeField]
	private UIMarketBuyNameSearch searchByName; // 0x48
	[SerializeField]
	private UIMarketBuySelectCategory selectCategoryWindow; // 0x50
	[SerializeField]
	private UIMarketSearchOption marketSearchOption; // 0x58
	private ItemType currentCategory; // 0x60
	private Action action; // 0x68

	// Properties
	public bool IsActive { get; }
	public UIMarketBuyNameSearch SearchByName { get; }
	public UIMarketBuySelectCategory SelectCategoryWindow { get; }
	public UIMarketSearchOption SearchOption { get; }

	// Methods

	// RVA: 0x1DC2454 Offset: 0x1DBE454 VA: 0x1DC2454
	public bool get_IsActive() { }

	// RVA: 0x1DC2474 Offset: 0x1DBE474 VA: 0x1DC2474
	public UIMarketBuyNameSearch get_SearchByName() { }

	// RVA: 0x1DC247C Offset: 0x1DBE47C VA: 0x1DC247C
	public UIMarketBuySelectCategory get_SelectCategoryWindow() { }

	// RVA: 0x1DC2484 Offset: 0x1DBE484 VA: 0x1DC2484
	public UIMarketSearchOption get_SearchOption() { }

	// RVA: 0x1DC248C Offset: 0x1DBE48C VA: 0x1DC248C
	private void Start() { }

	// RVA: 0x1DC2674 Offset: 0x1DBE674 VA: 0x1DC2674
	public bool CheckReturn() { }

	// RVA: 0x1DC2748 Offset: 0x1DBE748 VA: 0x1DC2748
	public void SetCallBack(Action action) { }

	// RVA: 0x1DC2750 Offset: 0x1DBE750 VA: 0x1DC2750
	private void OnSelectedCategory(ItemType type) { }

	// RVA: 0x1DC2600 Offset: 0x1DBE600 VA: 0x1DC2600
	private void UpdateSelectedCategory() { }

	// RVA: 0x1DC2798 Offset: 0x1DBE798 VA: 0x1DC2798
	public void OnSearch() { }

	// RVA: 0x1DC280C Offset: 0x1DBE80C VA: 0x1DC280C
	public void OnSelectCategory() { }

	// RVA: 0x1DC28C4 Offset: 0x1DBE8C4 VA: 0x1DC28C4
	public void OnSearchByName() { }

	// RVA: 0x1DC29A0 Offset: 0x1DBE9A0 VA: 0x1DC29A0
	public void .ctor() { }
}
