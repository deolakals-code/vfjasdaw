// Assembly: Assembly-CSharp-firstpass.dll
// Namespace: Asobimo.Plugin
public abstract class PurchaseBase : MonoBehaviour // TypeDefIndex: 17150
{
	// Fields
	private const int MaxRetry = 3;
	protected bool isInit; // 0x20
	protected AsobimoAuthBase asobimoAuth; // 0x28
	protected string receiptCheckURL; // 0x30
	protected Dictionary<string, ProductData> inappProductDataList; // 0x38
	protected Dictionary<string, ProductData> subsProductDataList; // 0x40
	protected IPurchaseListener purchaseListener; // 0x48
	protected bool pcPurchaseFlag; // 0x50
	[CompilerGenerated]
	private bool <EnablePurchase>k__BackingField; // 0x51

	// Properties
	public bool IsInit { get; }
	public abstract string PlatformCode { get; }
	public abstract string DistributionCode { get; }
	public bool EnablePurchase { get; set; }
	public Dictionary<string, ProductData> InappProductDataList { get; }
	public Dictionary<string, ProductData> SubscriptionProductDataList { get; }
	public virtual bool UseProductList { get; }

	// Methods

	// RVA: 0x1710C30 Offset: 0x170CC30 VA: 0x1710C30
	public bool get_IsInit() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string get_PlatformCode();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_DistributionCode();

	[CompilerGenerated]
	// RVA: 0x1710C38 Offset: 0x170CC38 VA: 0x1710C38
	public bool get_EnablePurchase() { }

	[CompilerGenerated]
	// RVA: 0x1710C40 Offset: 0x170CC40 VA: 0x1710C40
	protected void set_EnablePurchase(bool value) { }

	// RVA: 0x1710C4C Offset: 0x170CC4C VA: 0x1710C4C
	public Dictionary<string, ProductData> get_InappProductDataList() { }

	// RVA: 0x1710C54 Offset: 0x170CC54 VA: 0x1710C54
	public Dictionary<string, ProductData> get_SubscriptionProductDataList() { }

	// RVA: 0x1710C5C Offset: 0x170CC5C VA: 0x1710C5C Slot: 6
	public virtual bool get_UseProductList() { }

	// RVA: 0x1710C64 Offset: 0x170CC64 VA: 0x1710C64
	private void OnApplicationQuit() { }

	// RVA: 0x170A754 Offset: 0x1706754 VA: 0x170A754 Slot: 7
	public virtual void Dispose() { }

	// RVA: 0x170A8E4 Offset: 0x17068E4 VA: 0x170A8E4 Slot: 8
	public virtual void Initialize(AsobimoAuthBase asobimoAuth, string url, string[] inappItems, string[] subsItems) { }

	// RVA: 0x1710C70 Offset: 0x170CC70 VA: 0x1710C70 Slot: 9
	public virtual void ProductRefresh() { }

	// RVA: 0x1710C74 Offset: 0x170CC74 VA: 0x1710C74
	public void SetListener(IPurchaseListener listener) { }

	// RVA: 0x1710C7C Offset: 0x170CC7C VA: 0x1710C7C Slot: 10
	public virtual void Request() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void Purchase(string productId, PurchaseBase.PurchaseItemType type);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void Consume(string id);

	// RVA: 0x1710C80 Offset: 0x170CC80 VA: 0x1710C80 Slot: 13
	public virtual bool RetryRequestWebApi(string id) { }

	// RVA: 0x170D1C4 Offset: 0x17091C4 VA: 0x170D1C4
	public ProductData GetPruductData(string productId) { }

	// RVA: 0x1710C88 Offset: 0x170CC88 VA: 0x1710C88 Slot: 14
	public virtual void PurchasePC(PurchaseBase.PurchaseItemType type, string productId, Action successCallback, Action<PurchaseErrorCode, string> failedCallback) { }

	// RVA: 0x1710C8C Offset: 0x170CC8C VA: 0x1710C8C Slot: 15
	public virtual void SetPurchaseFlag(bool isPurchase) { }

	[IteratorStateMachine(typeof(PurchaseBase.<HttpPost>d__40))]
	// RVA: 0x170D10C Offset: 0x170910C VA: 0x170D10C
	protected IEnumerator HttpPost(string url, WWWForm post, Action<bool, string> callback) { }

	[IteratorStateMachine(typeof(PurchaseBase.<checkTimeOut>d__41))]
	// RVA: 0x1710CB8 Offset: 0x170CCB8 VA: 0x1710CB8
	private IEnumerator checkTimeOut(WWW www, float timeout, Action<bool, string> callback) { }

	// RVA: 0x170C380 Offset: 0x1708380 VA: 0x170C380
	protected void .ctor() { }
}
