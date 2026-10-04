// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIOrbShopBuyPanel : MonoBehaviour // TypeDefIndex: 7620
{
	// Fields
	[SerializeField]
	private GameObject scrollMessageObject; // 0x20
	private UIScrollWindow scrollMessageWindow; // 0x28
	[SerializeField]
	private GameObject mainPanel; // 0x30
	[SerializeField]
	private UIIcon itemIcon; // 0x38
	[SerializeField]
	private UILabel itemNameLabel; // 0x40
	[SerializeField]
	private UILabel itemTextLabel; // 0x48
	[SerializeField]
	private Transform itemIconParent; // 0x50
	[SerializeField]
	private UIOrbShopPaidBuyPopupWindow paidBuyPopupWindow; // 0x58
	[SerializeField]
	private GameObject buyPanel; // 0x60
	private TweenPosition buyPanelTweenPosition; // 0x68
	[SerializeField]
	private GameObject buyButton; // 0x70
	[SerializeField]
	private TweenAlpha tweenAlphaButton; // 0x78
	[SerializeField]
	private TweenColor tweenColorButton; // 0x80
	[SerializeField]
	private UILabel buyButtonText; // 0x88
	[SerializeField]
	private UILabel buyButtonWarningText; // 0x90
	[SerializeField]
	private Transform buyIcon; // 0x98
	[SerializeField]
	private UILabel buyButtonLabel; // 0xA0
	[SerializeField]
	private GameObject buyBlueButton; // 0xA8
	[SerializeField]
	private GameObject buySoldOutPanel; // 0xB0
	private TweenPosition buySoldOutPanelTweenPosition; // 0xB8
	[SerializeField]
	private GameObject gachaPanel; // 0xC0
	[SerializeField]
	private GameObject gachaButton; // 0xC8
	[SerializeField]
	private GameObject gachaInfoButton; // 0xD0
	[SerializeField]
	private GameObject gachaRareRateButton; // 0xD8
	[SerializeField]
	private GameObject gachaInfoText; // 0xE0
	[SerializeField]
	private GameObject gachaInfoMessage; // 0xE8
	[SerializeField]
	private GameObject luckBagInfoText; // 0xF0
	private TweenPosition gachaPanelTweenPosition; // 0xF8
	private UIOrbGachaBuyPanel orbGachaBuyPanel; // 0x100
	[SerializeField]
	private GameObject coursePanel; // 0x108
	[SerializeField]
	private GameObject courseButton; // 0x110
	[SerializeField]
	private TweenAlpha tweenCourseAlphaButton; // 0x118
	[SerializeField]
	private TweenColor tweenCourseColorButton; // 0x120
	[SerializeField]
	private UILabel courseBuyText; // 0x128
	private UIOrbBuyCheckAge orbBuyCheckAgeWindow; // 0x130
	private TweenPosition coursePanelTweenPosition; // 0x138
	private bool productCourseEntry; // 0x140
	private string productCourseId; // 0x148
	private bool infoButton; // 0x150
	private List<UIOrbShopManager.BuyOrbItemPopData> orbItemData; // 0x158
	private UIOrbShopManager manager; // 0x160
	private OrbManager orbManager; // 0x168
	private ItemTextManager itemTextManager; // 0x170
	private SystemTextManager systemTextManager; // 0x178
	private bool openCheck; // 0x180
	private int productId; // 0x184
	private int selectPrice; // 0x188
	private UIOrbShopBuyPanel.InfoState infoState; // 0x18C
	private bool cancelCheck; // 0x190
	private GameObject itemIconObject; // 0x198
	private bool buyCheck; // 0x1A0
	private bool isInfoPopUp; // 0x1A1
	private bool isPaidOrbOnly; // 0x1A2
	private bool hasCoursePurchasing; // 0x1A3
	private bool hasCourseCancellationProcedure; // 0x1A4

	// Properties
	public bool IsOpen { get; }

	// Methods

	// RVA: 0x1BC2050 Offset: 0x1BBE050 VA: 0x1BC2050
	public bool get_IsOpen() { }

	// RVA: 0x1BC2058 Offset: 0x1BBE058 VA: 0x1BC2058
	public void Initialize(UIOrbShopManager manager) { }

	// RVA: 0x1BC2330 Offset: 0x1BBE330 VA: 0x1BC2330
	public void InitializePaidBuyPopupWindow(int price, Action callback) { }

	// RVA: 0x1BC23EC Offset: 0x1BBE3EC VA: 0x1BC23EC
	private bool BaseBuyOrbItem(bool isPaidOrb, int productId, GameObject mainTexture, out OrbShopManager.ProductData productData) { }

	// RVA: 0x1BC2AD8 Offset: 0x1BBEAD8 VA: 0x1BC2AD8
	public bool BuyOrbItem(bool isPaidOrbOnly, int productId, GameObject mainTexture) { }

	// RVA: 0x1BC2DE4 Offset: 0x1BBEDE4 VA: 0x1BC2DE4
	public bool BuyPackOrbItem(bool isPaidOrbOnly, int productId, GameObject mainTexture, OrbShopManager.OrbPackItemData orbPackItemData) { }

	// RVA: 0x1BC3298 Offset: 0x1BBF298 VA: 0x1BC3298
	public void OnPackItemList() { }

	// RVA: 0x1BC3934 Offset: 0x1BBF934 VA: 0x1BC3934
	public void OnUIBuyClick() { }

	// RVA: 0x1BC39EC Offset: 0x1BBF9EC VA: 0x1BC39EC
	public void OnBuyClick() { }

	// RVA: 0x1BC3ED8 Offset: 0x1BBFED8 VA: 0x1BC3ED8
	public bool BuyGachaItem(bool isPaidOrbOnly, bool isInfoPop, int gachaId, GameObject mainTexture) { }

	// RVA: 0x1BC429C Offset: 0x1BC029C VA: 0x1BC429C
	public void OnGachaItemList() { }

	// RVA: 0x1BC4C48 Offset: 0x1BC0C48 VA: 0x1BC4C48
	private GameObject CrieateListButton(int itemId, int num, byte rare, float rate, string buttunText, string numText, Vector3 position) { }

	// RVA: 0x1BC5114 Offset: 0x1BC1114 VA: 0x1BC5114
	public void OnGachaRareRateList() { }

	// RVA: 0x1BC4E88 Offset: 0x1BC0E88 VA: 0x1BC4E88
	private GameObject CrieateRareListButton(byte rare, float rate, Vector3 position) { }

	// RVA: 0x1BC566C Offset: 0x1BC166C VA: 0x1BC566C
	public void OnBuyGachaClick(int setId, bool ticketBuy, bool isFree) { }

	// RVA: 0x1BC5774 Offset: 0x1BC1774 VA: 0x1BC5774
	public bool BuyLuckBagItem(bool isPaidOrbOnly, int luckBagId, GameObject mainTexture) { }

	// RVA: 0x1BC5B14 Offset: 0x1BC1B14 VA: 0x1BC5B14
	public void OnLuckBagItemList() { }

	// RVA: 0x1BC75A8 Offset: 0x1BC35A8 VA: 0x1BC75A8
	public void OnLuckBagRaraRateList() { }

	// RVA: 0x1BC6A94 Offset: 0x1BC2A94 VA: 0x1BC6A94
	private Vector3 LuckBagRaraRateListView(OrbShopManager.GachaProductData luckBagProductData, Vector3 position) { }

	// RVA: 0x1BC8488 Offset: 0x1BC4488 VA: 0x1BC8488
	public void OnBuyLuckBagClick(int setId) { }

	// RVA: 0x1BC8574 Offset: 0x1BC4574 VA: 0x1BC8574
	public bool BuyCourse(string productId, string productName, string productInfo, string coursePrice, byte state, bool isCanCancellationProcedure, GameObject mainTexture) { }

	// RVA: 0x1BC889C Offset: 0x1BC489C VA: 0x1BC889C
	public void OnBuyCourseClick() { }

	// RVA: 0x1BC8B38 Offset: 0x1BC4B38 VA: 0x1BC8B38
	private void BuyCourseEnterClick() { }

	// RVA: 0x1BC8CCC Offset: 0x1BC4CCC VA: 0x1BC8CCC
	public void OnBuyCourseClose() { }

	// RVA: 0x1BC8D4C Offset: 0x1BC4D4C VA: 0x1BC8D4C
	public void OnBuySuccessCourseClose(ProductData productData) { }

	// RVA: 0x1BC8D50 Offset: 0x1BC4D50 VA: 0x1BC8D50
	public void OnCheckItemInfoCkick(int itemId) { }

	// RVA: 0x1BC8E50 Offset: 0x1BC4E50 VA: 0x1BC8E50
	private void Update() { }

	// RVA: 0x1BC8F4C Offset: 0x1BC4F4C VA: 0x1BC8F4C
	public bool ClosePanel() { }

	// RVA: 0x1BC27D8 Offset: 0x1BBE7D8 VA: 0x1BC27D8
	private void MainPanelInit(bool isPaidOrbOnly, int id, GameObject mainTexture, TweenPosition tweenPosition, bool checkInfoButton) { }

	// RVA: 0x1BC3B44 Offset: 0x1BBFB44 VA: 0x1BC3B44
	private void Close() { }

	// RVA: 0x1BC38F8 Offset: 0x1BBF8F8 VA: 0x1BC38F8
	private void UpdateTweenPosition(TweenPosition update, Vector3 from, Vector3 to, float time) { }

	// RVA: 0x1BC9010 Offset: 0x1BC5010 VA: 0x1BC9010
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1BC90BC Offset: 0x1BC50BC VA: 0x1BC90BC
	private void <BuyGachaItem>b__66_0(bool success) { }

	[CompilerGenerated]
	// RVA: 0x1BC90F0 Offset: 0x1BC50F0 VA: 0x1BC90F0
	private void <BuyLuckBagItem>b__72_0(bool success) { }

	[CompilerGenerated]
	// RVA: 0x1BC9124 Offset: 0x1BC5124 VA: 0x1BC9124
	private void <OnBuyCourseClick>b__78_0() { }

	[CompilerGenerated]
	// RVA: 0x1BC9128 Offset: 0x1BC5128 VA: 0x1BC9128
	private void <OnBuyCourseClick>b__78_1() { }

	[CompilerGenerated]
	// RVA: 0x1BC9150 Offset: 0x1BC5150 VA: 0x1BC9150
	private void <OnCheckItemInfoCkick>b__82_0() { }
}
