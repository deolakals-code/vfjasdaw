// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIOrbBuyButton : UIOrbListButton // TypeDefIndex: 7545
{
	// Fields
	private int productId; // 0x78
	private UIOrbListBuyButtonData.OrbItemTypes orbItemType; // 0x7C
	[SerializeField]
	private Transform moneyTrans; // 0x80
	[SerializeField]
	private GameObject sailItem; // 0x88
	[SerializeField]
	private UILabel sailItemPoint; // 0x90
	[SerializeField]
	private UILabel itemPoint; // 0x98
	[SerializeField]
	private UILabel coinItemName; // 0xA0
	[SerializeField]
	private UISprite lineSprite; // 0xA8
	[SerializeField]
	private UISprite backSprite; // 0xB0
	[SerializeField]
	private UISprite backErrSprite; // 0xB8
	[SerializeField]
	private GameObject baseBeginnerBuyPop; // 0xC0
	private GameObject beginnerBuyPop; // 0xC8
	private UILabel beginnerBuyPopTimer; // 0xD0
	private List<byte> discountPriceKey; // 0xD8
	private string saveKeyData; // 0xE0
	private bool isBeginnerItem; // 0xE8
	private bool isPaidOrbOnly; // 0xE9
	private bool isItemInfo; // 0xEA
	private DateTime enabledBuyTime; // 0xF0
	private SystemTextManager systemTextManager; // 0xF8

	// Methods

	// RVA: 0x1BA5DBC Offset: 0x1BA1DBC VA: 0x1BA5DBC Slot: 4
	public override void Initialize(UIOrbListButtonDataBase baseData) { }

	// RVA: 0x1BA6678 Offset: 0x1BA2678 VA: 0x1BA6678
	private void SetGachaPrice(OrbShopManager.GachaType type, int productId, OrbTextManager.TextTypes localizeType, bool invisibleFlag) { }

	// RVA: 0x1BA65DC Offset: 0x1BA25DC VA: 0x1BA65DC
	private OrbShopManager.ProductData SetPrice() { }

	// RVA: 0x1BA6CA8 Offset: 0x1BA2CA8 VA: 0x1BA6CA8
	private void SetProduct(int price, int discountPrice) { }

	// RVA: 0x1BA69D4 Offset: 0x1BA29D4 VA: 0x1BA69D4
	private void NotFoundId() { }

	// RVA: 0x1BA7168 Offset: 0x1BA3168 VA: 0x1BA7168
	private void UpdateGachaPrice(OrbShopManager.GachaType type, int id) { }

	// RVA: 0x1BA736C Offset: 0x1BA336C VA: 0x1BA736C
	public void UpdatePrice(int id) { }

	// RVA: 0x1BA73A4 Offset: 0x1BA33A4 VA: 0x1BA73A4
	private void Update() { }

	// RVA: 0x1BA650C Offset: 0x1BA250C VA: 0x1BA650C
	private void UpdateTime(string KeyData) { }

	// RVA: 0x1BA7714 Offset: 0x1BA3714 VA: 0x1BA7714 Slot: 5
	public override void OnClick() { }

	// RVA: 0x1BA78BC Offset: 0x1BA38BC VA: 0x1BA78BC
	public void .ctor() { }
}
