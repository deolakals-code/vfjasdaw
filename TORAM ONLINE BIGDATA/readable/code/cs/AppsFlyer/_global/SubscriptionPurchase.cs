// Assembly: AppsFlyer.dll
// Namespace: 
[NullableContext(2)]
[Nullable(0)]
[Serializable]
public class SubscriptionPurchase // TypeDefIndex: 17251
{
	// Fields
	public string acknowledgementState; // 0x10
	public CanceledStateContext canceledStateContext; // 0x18
	public ExternalAccountIdentifiers externalAccountIdentifiers; // 0x20
	public string kind; // 0x28
	public string latestOrderId; // 0x30
	[Nullable(new[] { 2, 1 })]
	public List<SubscriptionPurchaseLineItem> lineItems; // 0x38
	public string linkedPurchaseToken; // 0x40
	public PausedStateContext pausedStateContext; // 0x48
	public string regionCode; // 0x50
	public string startTime; // 0x58
	public SubscribeWithGoogleInfo subscribeWithGoogleInfo; // 0x60
	public string subscriptionState; // 0x68
	public TestPurchase testPurchase; // 0x70

	// Methods

	// RVA: 0x16ECF90 Offset: 0x16E8F90 VA: 0x16ECF90
	public void .ctor() { }
}
