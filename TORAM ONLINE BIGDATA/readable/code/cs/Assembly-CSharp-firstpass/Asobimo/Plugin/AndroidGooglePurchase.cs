// Assembly: Assembly-CSharp-firstpass.dll
// Namespace: Asobimo.Plugin
public class AndroidGooglePurchase : PurchaseBase // TypeDefIndex: 17117
{
	// Fields
	private const int MaxRetry = 3;
	private const string InAppItem = "inapp";
	private const string SubsItem = "subs";
	private AndroidJavaObject billingManager; // 0x58
	private bool sendLock; // 0x60
	private string consumingProductId; // 0x68
	private int consumeRetryCount; // 0x70
	private AndroidGooglePurchase.RefreshState refreshState; // 0x74
	private int refreshPurchaseCountMax; // 0x78
	private int refreshPurchaseCount; // 0x7C
	private readonly string initNoticePurchaseKey; // 0x80

	// Properties
	public override string PlatformCode { get; }
	public override string DistributionCode { get; }
	public AndroidGooglePurchase.RefreshState NowRefreshState { get; }

	// Methods

	// RVA: 0x170A4E0 Offset: 0x17064E0 VA: 0x170A4E0 Slot: 4
	public override string get_PlatformCode() { }

	// RVA: 0x170A520 Offset: 0x1706520 VA: 0x170A520 Slot: 5
	public override string get_DistributionCode() { }

	// RVA: 0x170A560 Offset: 0x1706560 VA: 0x170A560
	public AndroidGooglePurchase.RefreshState get_NowRefreshState() { }

	// RVA: 0x170A568 Offset: 0x1706568 VA: 0x170A568
	private void Awake() { }

	// RVA: 0x170A668 Offset: 0x1706668 VA: 0x170A668 Slot: 7
	public override void Dispose() { }

	// RVA: 0x170A75C Offset: 0x170675C VA: 0x170A75C Slot: 8
	public override void Initialize(AsobimoAuthBase asobimoAuth, string url, string[] inappItems, string[] subsItems) { }

	// RVA: 0x170AA0C Offset: 0x1706A0C VA: 0x170AA0C Slot: 9
	public override void ProductRefresh() { }

	// RVA: 0x170AB8C Offset: 0x1706B8C VA: 0x170AB8C
	public void EnableDebugLog(bool flag) { }

	// RVA: 0x170AC94 Offset: 0x1706C94 VA: 0x170AC94 Slot: 10
	public override void Request() { }

	// RVA: 0x170AD60 Offset: 0x1706D60 VA: 0x170AD60 Slot: 11
	public override void Purchase(string productId, PurchaseBase.PurchaseItemType type) { }

	// RVA: 0x170ADF8 Offset: 0x1706DF8 VA: 0x170ADF8
	private bool androidPurchase(string productId, string itemType) { }

	// RVA: 0x170AF14 Offset: 0x1706F14 VA: 0x170AF14 Slot: 12
	public override void Consume(string productId) { }

	// RVA: 0x170B02C Offset: 0x170702C VA: 0x170B02C
	private void androidConsume(AndroidJavaObject purchase, string productId) { }

	// RVA: 0x170B10C Offset: 0x170710C VA: 0x170B10C Slot: 13
	public override bool RetryRequestWebApi(string productId) { }

	// RVA: 0x170B2C0 Offset: 0x17072C0 VA: 0x170B2C0
	private bool CheckSubscription(string productId, string token) { }

	// RVA: 0x170B354 Offset: 0x1707354 VA: 0x170B354
	private void SaveSubscription(string productId, string token) { }

	[IteratorStateMachine(typeof(AndroidGooglePurchase.<requestWebApi>d__32))]
	// RVA: 0x170B224 Offset: 0x1707224 VA: 0x170B224
	private IEnumerator requestWebApi(string productId, AndroidJavaObject purchase) { }

	// RVA: 0x170B39C Offset: 0x170739C VA: 0x170B39C
	private PurchaseBase.ReceiptDeal webPurchaceResultCheck(Dictionary<string, object> json, out PurchaseBase.ResultCode result) { }

	// RVA: 0x170B4F0 Offset: 0x17074F0 VA: 0x170B4F0
	private void onInit(string arg) { }

	// RVA: 0x170B5A0 Offset: 0x17075A0 VA: 0x170B5A0
	private void GetProductDetailsList(Dictionary<string, ProductData> list) { }

	// RVA: 0x170BC60 Offset: 0x1707C60 VA: 0x170BC60
	private void onInitFailure(string errCode) { }

	// RVA: 0x170BD38 Offset: 0x1707D38 VA: 0x170BD38
	private void onRefreshFailure(string errCode) { }

	// RVA: 0x170BE40 Offset: 0x1707E40 VA: 0x170BE40
	private void onPurchase(string productId) { }

	// RVA: 0x170C0EC Offset: 0x17080EC VA: 0x170C0EC
	private void onPurchaseFailure(string errCode) { }

	// RVA: 0x170C0F8 Offset: 0x17080F8 VA: 0x170C0F8
	private void onPurchaseFailurePurchasedOtherAccount(string errCode) { }

	// RVA: 0x170C104 Offset: 0x1708104 VA: 0x170C104
	private void onPurchasePending(string errCode) { }

	// RVA: 0x170C110 Offset: 0x1708110 VA: 0x170C110
	private void onRequestFailure(string errCode) { }

	// RVA: 0x170C11C Offset: 0x170811C VA: 0x170C11C
	private void onConsume(string productId) { }

	// RVA: 0x170C194 Offset: 0x1708194 VA: 0x170C194
	private void onConsumeFailure(string errCode) { }

	// RVA: 0x170BC70 Offset: 0x1707C70 VA: 0x170BC70
	private void onFailer(PurchaseErrorCode code, string errCode) { }

	// RVA: 0x170C1C4 Offset: 0x17081C4 VA: 0x170C1C4
	private void onNothingPurchase(string code) { }

	// RVA: 0x170C2C0 Offset: 0x17082C0 VA: 0x170C2C0
	private void onRefreshPurchaseCount(string count) { }

	// RVA: 0x170C2F8 Offset: 0x17082F8 VA: 0x170C2F8
	public void .ctor() { }
}
