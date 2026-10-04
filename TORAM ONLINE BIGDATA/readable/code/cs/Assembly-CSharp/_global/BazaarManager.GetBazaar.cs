// Assembly: Assembly-CSharp.dll
// Namespace: 
private class BazaarManager.GetBazaar : GetBazaarExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 1722
{
	// Fields
	private BazaarManager manager; // 0x10

	// Methods

	// RVA: 0x20AF7F4 Offset: 0x20AB7F4 VA: 0x20AF7F4
	public void .ctor(BazaarManager manager) { }

	// RVA: 0x20AFA58 Offset: 0x20ABA58 VA: 0x20AFA58 Slot: 13
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x20AFA74 Offset: 0x20ABA74 VA: 0x20AFA74 Slot: 11
	protected override void OnNotAllowed() { }

	// RVA: 0x20AFA90 Offset: 0x20ABA90 VA: 0x20AFA90 Slot: 12
	protected override void OnPutupSignboard() { }

	// RVA: 0x20AFAC4 Offset: 0x20ABAC4 VA: 0x20AFAC4 Slot: 10
	protected override void OnSuccess(GetBazaarResponse response) { }
}
