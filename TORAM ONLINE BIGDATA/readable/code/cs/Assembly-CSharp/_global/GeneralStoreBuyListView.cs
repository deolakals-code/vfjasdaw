// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GeneralStoreBuyListView : MonoBehaviour // TypeDefIndex: 8329
{
	// Fields
	[SerializeField]
	private GameObject AddedElement; // 0x20
	[SerializeField]
	private float ElementHeight; // 0x28
	[SerializeField]
	private float ViewHeight; // 0x2C
	[SerializeField]
	private UILabel PlanationLabel; // 0x30
	[SerializeField]
	private UILabel BagInfoTitleLabel; // 0x38
	[SerializeField]
	private UILabel BagInfoLabel; // 0x40
	private int shopId; // 0x48
	private TextManagerBase itemTextManager; // 0x50
	private Dictionary<int, int> ElementId; // 0x58
	private List<GeneralStoreListElement> ListElement; // 0x60
	[CompilerGenerated]
	private UIBasePanelControl <topButtonControl>k__BackingField; // 0x68
	private PlayerDataManager playerDataManager; // 0x70
	private UIScrollWindow scroll; // 0x78
	private SystemTextManager systemTextManager; // 0x80
	private bool isConnect; // 0x88
	private ShopGetCatalogResponse getCatalogResponse; // 0x90
	private ShopBuyItemResponse buyItemResponse; // 0x98

	// Properties
	public UIBasePanelControl topButtonControl { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1D1FABC Offset: 0x1D1BABC VA: 0x1D1FABC
	public UIBasePanelControl get_topButtonControl() { }

	[CompilerGenerated]
	// RVA: 0x1D1FAC4 Offset: 0x1D1BAC4 VA: 0x1D1FAC4
	public void set_topButtonControl(UIBasePanelControl value) { }

	// RVA: 0x1D1FACC Offset: 0x1D1BACC VA: 0x1D1FACC
	private void Awake() { }

	// RVA: 0x1D1FC9C Offset: 0x1D1BC9C VA: 0x1D1FC9C
	private void Start() { }

	// RVA: 0x1D1FE08 Offset: 0x1D1BE08 VA: 0x1D1FE08
	private void Update() { }

	[IteratorStateMachine(typeof(GeneralStoreBuyListView.<Show>d__25))]
	// RVA: 0x1D1F424 Offset: 0x1D1B424 VA: 0x1D1F424
	public IEnumerator Show() { }

	// RVA: 0x1D1F890 Offset: 0x1D1B890 VA: 0x1D1F890
	public void Close() { }

	// RVA: 0x1D1FF84 Offset: 0x1D1BF84 VA: 0x1D1FF84
	private void destroyParent() { }

	// RVA: 0x1D20018 Offset: 0x1D1C018 VA: 0x1D20018
	private void setUnActiveParent() { }

	// RVA: 0x1D20054 Offset: 0x1D1C054 VA: 0x1D20054
	private void setPlanation(string text) { }

	// RVA: 0x1D20070 Offset: 0x1D1C070 VA: 0x1D20070
	private string getItemName(int id) { }

	[IteratorStateMachine(typeof(GeneralStoreBuyListView.<GetCatalog>d__31))]
	// RVA: 0x1D200F8 Offset: 0x1D1C0F8 VA: 0x1D200F8
	private IEnumerator GetCatalog() { }

	[IteratorStateMachine(typeof(GeneralStoreBuyListView.<loadElement>d__32))]
	// RVA: 0x1D2018C Offset: 0x1D1C18C VA: 0x1D2018C
	private IEnumerator loadElement() { }

	// RVA: 0x1D20220 Offset: 0x1D1C220 VA: 0x1D20220
	public void ResetElementSelect(GeneralStoreListElement sender) { }

	// RVA: 0x1D20534 Offset: 0x1D1C534 VA: 0x1D20534
	public void SetEnableElement(bool enable) { }

	// RVA: 0x1D20718 Offset: 0x1D1C718 VA: 0x1D20718
	public void SetLoading(bool flg) { }

	// RVA: 0x1D2071C Offset: 0x1D1C71C VA: 0x1D2071C
	public void SetShopId(int id) { }

	// RVA: 0x1D20724 Offset: 0x1D1C724 VA: 0x1D20724
	public int GetShopId() { }

	[IteratorStateMachine(typeof(GeneralStoreBuyListView.<BuyItemWaitResponse>d__38))]
	// RVA: 0x1D2072C Offset: 0x1D1C72C VA: 0x1D2072C
	private IEnumerator BuyItemWaitResponse(int shopId, short[] position, int itemId, short itemNum, int gold) { }

	// RVA: 0x1D2080C Offset: 0x1D1C80C VA: 0x1D2080C
	public void BuyItem(int shopId, short[] position, int itemId, short itemNum, int gold) { }

	// RVA: 0x1D2082C Offset: 0x1D1C82C VA: 0x1D2082C
	private void closeError() { }

	// RVA: 0x1D208D4 Offset: 0x1D1C8D4 VA: 0x1D208D4
	private void OnDestroy() { }

	// RVA: 0x1D20934 Offset: 0x1D1C934 VA: 0x1D20934
	public void .ctor() { }
}
