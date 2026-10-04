// Assembly: Assembly-CSharp.dll
// Namespace: 
private class BazaarManager.UpdateCheckOpenBazaarDialog : UpdateCheckOpenBazaarDialogExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 1723
{
	// Fields
	private BazaarManager manager; // 0x10

	// Methods

	// RVA: 0x20AF8C8 Offset: 0x20AB8C8 VA: 0x20AF8C8
	public void .ctor(BazaarManager manager) { }

	// RVA: 0x20AFAF8 Offset: 0x20ABAF8 VA: 0x20AFAF8 Slot: 11
	protected override void OnAlreadUpdate() { }

	// RVA: 0x20AFAFC Offset: 0x20ABAFC VA: 0x20AFAFC Slot: 12
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x20AFB00 Offset: 0x20ABB00 VA: 0x20AFB00 Slot: 10
	protected override void OnSuccess(UpdateCheckOpenBazaarDialogResponse response) { }
}
