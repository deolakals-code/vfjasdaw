// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMarketSell : MonoBehaviour // TypeDefIndex: 8451
{
	// Fields
	[SerializeField]
	private GameObject AddedElement; // 0x20
	[SerializeField]
	private float ElementHeight; // 0x28
	[SerializeField]
	private float ViewHeight; // 0x2C
	private int shopId; // 0x30
	private TextManagerBase itemTextManager; // 0x38
	[CompilerGenerated]
	private UIMarketControl <topButtonControl>k__BackingField; // 0x40
	[CompilerGenerated]
	private MarketServiceType <ServiceType>k__BackingField; // 0x48
	private PlayerDataManager playerDataManager; // 0x50
	[SerializeField]
	private UIScrollWindow scroll; // 0x58
	[SerializeField]
	private GameObject sellListPanel; // 0x60
	[SerializeField]
	private UIMarketSellRegister registerPanel; // 0x68
	private SystemTextManager systemTextManager; // 0x70
	private double commitionRate; // 0x78
	private byte countryRate; // 0x80
	private Dictionary<int, UIMarketProductData> productDataList; // 0x88

	// Properties
	public UIMarketControl topButtonControl { get; set; }
	public MarketServiceType ServiceType { get; set; }
	public Vector3 ScrollCameraPos { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1D644A8 Offset: 0x1D604A8 VA: 0x1D644A8
	public UIMarketControl get_topButtonControl() { }

	[CompilerGenerated]
	// RVA: 0x1D644B0 Offset: 0x1D604B0 VA: 0x1D644B0
	public void set_topButtonControl(UIMarketControl value) { }

	[CompilerGenerated]
	// RVA: 0x1D644B8 Offset: 0x1D604B8 VA: 0x1D644B8
	public MarketServiceType get_ServiceType() { }

	[CompilerGenerated]
	// RVA: 0x1D644C0 Offset: 0x1D604C0 VA: 0x1D644C0
	public void set_ServiceType(MarketServiceType value) { }

	// RVA: 0x1D644C8 Offset: 0x1D604C8 VA: 0x1D644C8
	public Vector3 get_ScrollCameraPos() { }

	// RVA: 0x1D644F8 Offset: 0x1D604F8 VA: 0x1D644F8
	private void Awake() { }

	// RVA: 0x1D646B8 Offset: 0x1D606B8 VA: 0x1D646B8
	private void Start() { }

	[IteratorStateMachine(typeof(UIMarketSell.<Show>d__25))]
	// RVA: 0x1D64728 Offset: 0x1D60728 VA: 0x1D64728
	public IEnumerator Show(Vector3 scrollCameraPos) { }

	// RVA: 0x1D647E0 Offset: 0x1D607E0 VA: 0x1D647E0
	private string getItemName(int id) { }

	[IteratorStateMachine(typeof(UIMarketSell.<loadElement>d__27))]
	// RVA: 0x1D64868 Offset: 0x1D60868 VA: 0x1D64868
	private IEnumerator loadElement(bool saveScroll) { }

	// RVA: 0x1D64910 Offset: 0x1D60910 VA: 0x1D64910
	private void closeError() { }

	// RVA: 0x1D649B8 Offset: 0x1D609B8 VA: 0x1D649B8
	public void Close() { }

	// RVA: 0x1D64A24 Offset: 0x1D60A24 VA: 0x1D64A24
	private void OnDestroy() { }

	// RVA: 0x1D64A84 Offset: 0x1D60A84 VA: 0x1D64A84
	private void onRegisterCallback(int slotId) { }

	// RVA: 0x1D64E5C Offset: 0x1D60E5C VA: 0x1D64E5C
	private void onCancelCallback(int slotId, long marketId) { }

	// RVA: 0x1D64FFC Offset: 0x1D60FFC VA: 0x1D64FFC
	private void onCollectCallback(int slotId, long marketId, int revenuePrice) { }

	[IteratorStateMachine(typeof(UIMarketSell.<askAndCollectSpina>d__34))]
	// RVA: 0x1D65180 Offset: 0x1D61180 VA: 0x1D65180
	private IEnumerator askAndCollectSpina(long spina, int slot, long marketId) { }

	// RVA: 0x1D652C0 Offset: 0x1D612C0 VA: 0x1D652C0
	private void onFinishedCallback(int slotId, long marketId) { }

	[IteratorStateMachine(typeof(UIMarketSell.<onFinishedBagErrorCoroutine>d__36))]
	// RVA: 0x1D654E4 Offset: 0x1D614E4 VA: 0x1D654E4
	private IEnumerator onFinishedBagErrorCoroutine() { }

	[IteratorStateMachine(typeof(UIMarketSell.<cancelCoroutine>d__37))]
	// RVA: 0x1D64F78 Offset: 0x1D60F78 VA: 0x1D64F78
	private IEnumerator cancelCoroutine(int slotId, long marketId) { }

	[IteratorStateMachine(typeof(UIMarketSell.<collectCoroutine>d__38))]
	// RVA: 0x1D65214 Offset: 0x1D61214 VA: 0x1D65214
	private IEnumerator collectCoroutine(int slotId, long marketId) { }

	// RVA: 0x1D655C8 Offset: 0x1D615C8 VA: 0x1D655C8
	private void setEnableSlotListScrollCamera(bool isEnable) { }

	// RVA: 0x1D6565C Offset: 0x1D6165C VA: 0x1D6565C
	private void backToSellListFromRegister() { }

	// RVA: 0x1D656C8 Offset: 0x1D616C8 VA: 0x1D656C8
	public void .ctor() { }
}
