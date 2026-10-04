// Assembly: Assembly-CSharp-firstpass.dll
// Namespace: Asobimo.Plugin
public interface IPurchaseListener // TypeDefIndex: 17141
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnPurchaseEnd(ProductData product);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnFailer(PurchaseErrorCode code, string errStr);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnRetryRequestWebApi(string id);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnPurchaseReservation(string productId);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IEnumerator UpdatePaymentBonusData();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool OnCheckSubscription(string productId);
}
