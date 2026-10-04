// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIOrbShopListPanel : MonoBehaviour // TypeDefIndex: 7627
{
	// Fields
	private Stack<UIOrbShopListPanel.ShopRoot> openRoot; // 0x20
	private int openPageId; // 0x28
	private int maxIndex; // 0x2C
	[SerializeField]
	private GameObject mainScrollObject; // 0x30
	protected UIScrollWindow scrollWindow; // 0x38
	protected Dictionary<int, List<UIOrbListButtonDataBase>> pageManager; // 0x40
	protected Dictionary<int, byte> pageTypeManager; // 0x48
	private List<UIOrbBuyButton> listBuyButton; // 0x50
	private List<UIOrbBuyButton> listGachaBuyButton; // 0x58
	private List<UIOrbBuyButton> listLockBagBuyButton; // 0x60
	[SerializeField]
	private GameObject[] baseButton; // 0x68
	[SerializeField]
	private UIImageButton[] categoryButton; // 0x70
	[SerializeField]
	private GameObject seleLabelObject; // 0x78
	private UIOrbShopManager manager; // 0x80
	private bool isActiveListPanel; // 0x88

	// Properties
	public int OpenPageId { get; }
	public byte ItemRow { get; }

	// Methods

	// RVA: 0x1BC9C28 Offset: 0x1BC5C28 VA: 0x1BC9C28
	public int get_OpenPageId() { }

	// RVA: 0x1BC9C30 Offset: 0x1BC5C30 VA: 0x1BC9C30
	public byte get_ItemRow() { }

	// RVA: 0x1BC9C38 Offset: 0x1BC5C38 VA: 0x1BC9C38
	public void Initialize(UIOrbShopManager manager) { }

	// RVA: 0x1BC9D1C Offset: 0x1BC5D1C VA: 0x1BC9D1C
	public void BuyOrbItem(bool isPaidOrbOnly, bool isItemInfo, int productId, UIOrbListBuyButtonData.OrbItemTypes type, GameObject texture, bool isBuySaveKey, string saveKey) { }

	// RVA: 0x1BC9FD0 Offset: 0x1BC5FD0 VA: 0x1BC9FD0
	public void BuyCourse(string productId, string productName, string productInfo, string coursePrice, byte state, bool isCanCancellationProcedure, GameObject texture) { }

	// RVA: 0x1BCA184 Offset: 0x1BC6184 VA: 0x1BCA184
	public bool ReturnPage() { }

	// RVA: 0x1BCA688 Offset: 0x1BC6688 VA: 0x1BCA688
	private void SetPage(int pageId, byte index) { }

	// RVA: 0x1BCA750 Offset: 0x1BC6750 VA: 0x1BCA750
	public void ForwardScrollPanel() { }

	// RVA: 0x1BCA814 Offset: 0x1BC6814 VA: 0x1BCA814
	public void BackScrollPanel(bool categoryActive) { }

	// RVA: 0x1BCA8D8 Offset: 0x1BC68D8 VA: 0x1BCA8D8
	public bool LoadShopView(byte[] binary, OrbShopManager shopManager, out List<string> downLoadList) { }

	// RVA: 0x1BCC1A8 Offset: 0x1BC81A8 VA: 0x1BCC1A8
	private string GetDownLoadPath(string folder, bool localize) { }

	// RVA: 0x1BCC354 Offset: 0x1BC8354 VA: 0x1BCC354
	public void ScrollPageCreate(int pageId, byte index, byte returnIndex) { }

	// RVA: 0x1BCC3C4 Offset: 0x1BC83C4 VA: 0x1BCC3C4
	public void OnClickCategoryPage(int pageId) { }

	// RVA: 0x1BCA224 Offset: 0x1BC6224 VA: 0x1BCA224
	public void ScrollPageCreate(int pageId, byte index) { }

	// RVA: 0x1BCC46C Offset: 0x1BC846C VA: 0x1BCC46C Slot: 4
	protected virtual void AddButton(UIOrbListButtonDataBase buttonData) { }

	// RVA: 0x1BCC6E4 Offset: 0x1BC86E4 VA: 0x1BCC6E4 Slot: 5
	protected virtual bool TryGetOpenPangeData(int pageId, out List<UIOrbListButtonDataBase> list) { }

	// RVA: 0x1BCC7B4 Offset: 0x1BC87B4 VA: 0x1BCC7B4
	public void UpdateBuyButton(int productId) { }

	// RVA: 0x1BCC908 Offset: 0x1BC8908 VA: 0x1BCC908
	public void UpdateGachaBuyButton(int productId) { }

	// RVA: 0x1BCCA5C Offset: 0x1BC8A5C VA: 0x1BCCA5C
	public void UpdateLockBagBuyButton(int productId) { }

	// RVA: 0x1BCCBB0 Offset: 0x1BC8BB0 VA: 0x1BCCBB0
	public void .ctor() { }
}
