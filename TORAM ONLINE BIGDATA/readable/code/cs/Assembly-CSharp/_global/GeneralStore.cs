// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GeneralStore : UIBasePanelControl, IShop // TypeDefIndex: 8321
{
	// Fields
	[SerializeField]
	private GameObject[] SelectButtons; // 0x58
	[SerializeField]
	private GameObject ParentPanel; // 0x60
	[SerializeField]
	private GameObject BuyList; // 0x68
	[SerializeField]
	private GameObject SellList; // 0x70
	[SerializeField]
	private GameObject TitleObj; // 0x78
	private GameObject ShowBuyList; // 0x80
	private GameObject ShowSellList; // 0x88
	private int shopId; // 0x90
	private bool isClosed; // 0x94

	// Properties
	public int ShopId { get; set; }
	public string ShopName { get; set; }
	public bool IsClosed { get; set; }

	// Methods

	// RVA: 0x1D1ED4C Offset: 0x1D1AD4C VA: 0x1D1ED4C
	private void Awake() { }

	// RVA: 0x1D1EE3C Offset: 0x1D1AE3C VA: 0x1D1EE3C
	private void Start() { }

	// RVA: 0x1D1EFE0 Offset: 0x1D1AFE0 VA: 0x1D1EFE0
	private void ShowButtons() { }

	// RVA: 0x1D1F078 Offset: 0x1D1B078 VA: 0x1D1F078
	private void CloseButtons() { }

	// RVA: 0x1D1F110 Offset: 0x1D1B110 VA: 0x1D1F110
	private void ToBuy() { }

	// RVA: 0x1D1F490 Offset: 0x1D1B490 VA: 0x1D1F490
	private void ToSell() { }

	// RVA: 0x1D1F7D8 Offset: 0x1D1B7D8 VA: 0x1D1F7D8
	private void ReturnFromBuy() { }

	// RVA: 0x1D1F894 Offset: 0x1D1B894 VA: 0x1D1F894
	private void ReturnFromSell() { }

	// RVA: 0x1D1F9AC Offset: 0x1D1B9AC VA: 0x1D1F9AC
	private void close() { }

	// RVA: 0x1D1F9B8 Offset: 0x1D1B9B8 VA: 0x1D1F9B8
	private void OnDestroy() { }

	// RVA: 0x1D1F9BC Offset: 0x1D1B9BC VA: 0x1D1F9BC Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1D1F9C8 Offset: 0x1D1B9C8 VA: 0x1D1F9C8 Slot: 14
	public int get_ShopId() { }

	// RVA: 0x1D1F9D0 Offset: 0x1D1B9D0 VA: 0x1D1F9D0 Slot: 15
	public void set_ShopId(int value) { }

	// RVA: 0x1D1F9D8 Offset: 0x1D1B9D8 VA: 0x1D1F9D8 Slot: 16
	public string get_ShopName() { }

	// RVA: 0x1D1FA34 Offset: 0x1D1BA34 VA: 0x1D1FA34 Slot: 17
	public void set_ShopName(string value) { }

	// RVA: 0x1D1FA98 Offset: 0x1D1BA98 VA: 0x1D1FA98 Slot: 18
	public bool get_IsClosed() { }

	// RVA: 0x1D1FAA0 Offset: 0x1D1BAA0 VA: 0x1D1FAA0 Slot: 19
	public void set_IsClosed(bool value) { }

	// RVA: 0x1D1FAAC Offset: 0x1D1BAAC VA: 0x1D1FAAC
	public void .ctor() { }
}
