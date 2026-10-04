// Assembly: Assembly-CSharp.dll
// Namespace: 
public class OrbShopManager // TypeDefIndex: 2172
{
	// Fields
	private const string platformCode = "Android";
	private byte newsButtonId; // 0x10
	private List<OrbShopManager.NewsData> newsList; // 0x18
	private List<PopBannerBase> bannerData; // 0x20
	private Dictionary<string, Texture2D> bannerTexure; // 0x28
	private List<string> loadBannerTexure; // 0x30
	private Dictionary<int, string> saleOrbText; // 0x38
	private int orbShopKey; // 0x40
	private int orbShopUpdateKey; // 0x44
	private int orbCoinKey; // 0x48
	private int orbCoinUpdateKey; // 0x4C
	private Dictionary<int, OrbShopManager.OrbPackItemData> packItemList; // 0x50
	private Dictionary<int, OrbShopManager.ProductData> productList; // 0x58
	private Dictionary<OrbShopManager.GachaType, Dictionary<int, OrbShopManager.GachaProductData>> gachaDataList; // 0x60
	private string shopName; // 0x68
	private const string ShopNewFlagKey = "ShopNewFlag";
	private const string OrbNewFlagKey = "OrbNewFlag";

	// Properties
	public static int SoldOutPoint { get; }
	public static string ShopFolderPath { get; }
	public static string OrbShopNewsPath { get; }
	public OrbShopManager.NewsData[] GetNewsList { get; }
	public string ShopName { get; }

	// Methods

	// RVA: 0x2150B38 Offset: 0x214CB38 VA: 0x2150B38
	public static int get_SoldOutPoint() { }

	// RVA: 0x2150B40 Offset: 0x214CB40 VA: 0x2150B40
	public static string get_ShopFolderPath() { }

	// RVA: 0x2150B80 Offset: 0x214CB80 VA: 0x2150B80
	public static string get_OrbShopNewsPath() { }

	// RVA: 0x2150C10 Offset: 0x214CC10 VA: 0x2150C10
	public static string OrbShopNewsName(string lang) { }

	// RVA: 0x2150C7C Offset: 0x214CC7C VA: 0x2150C7C
	public static string OrbShopDataFile(string lang) { }

	// RVA: 0x2150D14 Offset: 0x214CD14 VA: 0x2150D14
	public static string GetBuyIconString(string type) { }

	// RVA: 0x2150DA0 Offset: 0x214CDA0 VA: 0x2150DA0
	public OrbShopManager.NewsData[] get_GetNewsList() { }

	// RVA: 0x2150DF0 Offset: 0x214CDF0 VA: 0x2150DF0
	public string get_ShopName() { }

	// RVA: 0x2150E5C Offset: 0x214CE5C VA: 0x2150E5C
	public void Clear() { }

	// RVA: 0x2151034 Offset: 0x214D034 VA: 0x2151034
	public void LoadNewsBinary(byte[] binary) { }

	// RVA: 0x2150F40 Offset: 0x214CF40 VA: 0x2150F40
	public void ClearNews() { }

	// RVA: 0x2151E0C Offset: 0x214DE0C VA: 0x2151E0C
	public void AddProduct(object[] outObj) { }

	// RVA: 0x21521EC Offset: 0x214E1EC VA: 0x21521EC
	public bool GetProduct(int productId, out OrbShopManager.ProductData productData) { }

	// RVA: 0x2152274 Offset: 0x214E274 VA: 0x2152274
	public void RemoveProduct(int productId) { }

	// RVA: 0x2150EF0 Offset: 0x214CEF0 VA: 0x2150EF0
	public void ClearProduct() { }

	// RVA: 0x21522CC Offset: 0x214E2CC VA: 0x21522CC
	public bool LoadPackOrbItemBinaryData(byte[] binary) { }

	// RVA: 0x2152A60 Offset: 0x214EA60 VA: 0x2152A60
	public bool TryGetPackItem(int productId, out OrbShopManager.OrbPackItemData packItem) { }

	// RVA: 0x2152AC8 Offset: 0x214EAC8 VA: 0x2152AC8
	public bool ContainsPackItem(int productId) { }

	// RVA: 0x2150FE4 Offset: 0x214CFE4 VA: 0x2150FE4
	public void ClearPackItem() { }

	// RVA: 0x2152B20 Offset: 0x214EB20 VA: 0x2152B20
	private Dictionary<int, OrbShopManager.GachaProductData> GetGachaProductDataList(OrbShopManager.GachaType type) { }

	// RVA: 0x2152C00 Offset: 0x214EC00 VA: 0x2152C00
	public void AddGachaProduct(OrbShopManager.GachaType type, int gachaId, OrbShopManager.GachaProductData data) { }

	// RVA: 0x2152CC4 Offset: 0x214ECC4 VA: 0x2152CC4
	public void AddGachaSet(OrbShopManager.GachaType type, int gachaId, int setId, int stack, int price, int disPrice, string codeId) { }

	// RVA: 0x2152F04 Offset: 0x214EF04 VA: 0x2152F04
	public void SetGachaDetail(OrbShopManager.GachaType type, int gachaId, bool avatarEquip, List<OrbShopManager.GachaRareRateData> rateList, List<OrbShopManager.GachaDetailData> itemList) { }

	// RVA: 0x2153214 Offset: 0x214F214 VA: 0x2153214
	public bool ContainsGachaProductId(OrbShopManager.GachaType type, int gachaProductId) { }

	// RVA: 0x2153320 Offset: 0x214F320 VA: 0x2153320
	public bool GetGachaProduct(OrbShopManager.GachaType type, int gachaProductId, out OrbShopManager.GachaProductData gachaProductData) { }

	// RVA: 0x21533B4 Offset: 0x214F3B4 VA: 0x21533B4
	public void RemoveGachaProduct(OrbShopManager.GachaType type, int productId) { }

	// RVA: 0x2150E94 Offset: 0x214CE94 VA: 0x2150E94
	public void ClearGachaProduct(OrbShopManager.GachaType type) { }

	// RVA: 0x2153420 Offset: 0x214F420 VA: 0x2153420
	public int[] GetGachaRareList(OrbShopManager.GachaType type, int gachaId, int[] resultItemId) { }

	// RVA: 0x21536C4 Offset: 0x214F6C4 VA: 0x21536C4
	public PopBannerBase[] GetPopBannerData() { }

	// RVA: 0x21537E4 Offset: 0x214F7E4 VA: 0x21537E4
	public bool GetBannerTexure(string file, out Texture2D tex) { }

	// RVA: 0x215384C Offset: 0x214F84C VA: 0x215384C
	public string GetSaleTextData(int saleId) { }

	// RVA: 0x2153900 Offset: 0x214F900 VA: 0x2153900
	public void OnEnter() { }

	// RVA: 0x2153B7C Offset: 0x214FB7C VA: 0x2153B7C
	private int LoadUpdateFlag(string flag) { }

	// RVA: 0x2153BB0 Offset: 0x214FBB0 VA: 0x2153BB0
	private void SaveUpdateFlagKey(string flag, int key) { }

	// RVA: 0x2153BD0 Offset: 0x214FBD0 VA: 0x2153BD0
	public void LoadFlag() { }

	// RVA: 0x2153C7C Offset: 0x214FC7C VA: 0x2153C7C
	public bool IsUpdateOrbShop() { }

	// RVA: 0x2153C8C Offset: 0x214FC8C VA: 0x2153C8C
	public void UpdateOrbShopKey() { }

	// RVA: 0x2153CF8 Offset: 0x214FCF8 VA: 0x2153CF8
	public bool IsUpdateOrbCoin() { }

	// RVA: 0x2153D08 Offset: 0x214FD08 VA: 0x2153D08
	public void UpdateOrbCoinKey() { }

	// RVA: 0x2153D74 Offset: 0x214FD74 VA: 0x2153D74
	public void UpdateKeyData() { }

	// RVA: 0x2153EC0 Offset: 0x214FEC0 VA: 0x2153EC0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x21541A0 Offset: 0x21501A0 VA: 0x21541A0
	private void <OnEnter>b__62_0(bool x, string f, Texture2D t) { }
}
