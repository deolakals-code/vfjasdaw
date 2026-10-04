// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMarket : UIMarketControl, IShop // TypeDefIndex: 8366
{
	// Fields
	[SerializeField]
	private GameObject[] SelectButtons; // 0x70
	[SerializeField]
	private GameObject BuyList; // 0x78
	[SerializeField]
	private GameObject SellList; // 0x80
	[SerializeField]
	private GameObject TitleObj; // 0x88
	[SerializeField]
	private LocalizeText sellMenuLocalize; // 0x90
	private GameObject ShowBuyList; // 0x98
	private GameObject ShowSellList; // 0xA0
	private int shopId; // 0xA8
	private bool isClosed; // 0xAC
	private int slotMax; // 0xB0
	private MarketServiceType serviceType; // 0xB4
	private PlayerDataManager playerDataManager; // 0xB8
	private Vector3 sellListScrollCameraPos; // 0xC0

	// Properties
	public int ShopId { get; set; }
	public string ShopName { get; set; }
	public bool IsClosed { get; set; }

	// Methods

	// RVA: 0x1D312AC Offset: 0x1D2D2AC VA: 0x1D312AC Slot: 14
	protected override void InitializeAwake() { }

	// RVA: 0x1D312D4 Offset: 0x1D2D2D4 VA: 0x1D312D4
	private void Start() { }

	// RVA: 0x1D312F4 Offset: 0x1D2D2F4 VA: 0x1D312F4
	public void Initialize() { }

	[IteratorStateMachine(typeof(UIMarket.<initialize>d__16))]
	// RVA: 0x1D31314 Offset: 0x1D2D314 VA: 0x1D31314
	private IEnumerator initialize() { }

	// RVA: 0x1D313A8 Offset: 0x1D2D3A8 VA: 0x1D313A8
	public void UpdateProductList(MarketData[] products) { }

	// RVA: 0x1D313AC Offset: 0x1D2D3AC VA: 0x1D313AC
	private void ShowButtons() { }

	// RVA: 0x1D31524 Offset: 0x1D2D524 VA: 0x1D31524
	private void CloseButtons() { }

	// RVA: 0x1D315BC Offset: 0x1D2D5BC VA: 0x1D315BC
	private void ToBuy() { }

	// RVA: 0x1D31BB4 Offset: 0x1D2DBB4 VA: 0x1D31BB4
	private void ToSell() { }

	// RVA: 0x1D31F9C Offset: 0x1D2DF9C VA: 0x1D31F9C
	private void ReturnFromBuy() { }

	// RVA: 0x1D320C0 Offset: 0x1D2E0C0 VA: 0x1D320C0
	private void ReturnFromSell() { }

	// RVA: 0x1D32194 Offset: 0x1D2E194 VA: 0x1D32194
	private void close() { }

	// RVA: 0x1D321A0 Offset: 0x1D2E1A0 VA: 0x1D321A0
	private void OnDestroy() { }

	// RVA: 0x1D321A4 Offset: 0x1D2E1A4 VA: 0x1D321A4 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1D32260 Offset: 0x1D2E260 VA: 0x1D32260 Slot: 15
	public int get_ShopId() { }

	// RVA: 0x1D32268 Offset: 0x1D2E268 VA: 0x1D32268 Slot: 16
	public void set_ShopId(int value) { }

	// RVA: 0x1D32270 Offset: 0x1D2E270 VA: 0x1D32270 Slot: 17
	public string get_ShopName() { }

	// RVA: 0x1D322CC Offset: 0x1D2E2CC VA: 0x1D322CC Slot: 18
	public void set_ShopName(string value) { }

	// RVA: 0x1D32330 Offset: 0x1D2E330 VA: 0x1D32330 Slot: 19
	public bool get_IsClosed() { }

	// RVA: 0x1D32338 Offset: 0x1D2E338 VA: 0x1D32338 Slot: 20
	public void set_IsClosed(bool value) { }

	// RVA: 0x1D32344 Offset: 0x1D2E344 VA: 0x1D32344
	public void .ctor() { }

	[DebuggerHidden]
	[CompilerGenerated]
	// RVA: 0x1D32350 Offset: 0x1D2E350 VA: 0x1D32350
	private void <>n__0() { }
}
