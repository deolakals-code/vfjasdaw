// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIColorSynthesisMainManager.StockColorConnection : StockColorExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 6726
{
	// Fields
	private readonly UIColorSynthesisMainManager manager; // 0x18
	private readonly Action onComplete; // 0x20

	// Methods

	// RVA: 0x19CCBA8 Offset: 0x19C8BA8 VA: 0x19CCBA8
	public void .ctor(UIColorSynthesisMainManager manager, int[] itemUuids, Action onComplete) { }

	// RVA: 0x19CD23C Offset: 0x19C923C VA: 0x19CD23C Slot: 10
	protected override void OnSuccess(StockColorResponse response) { }

	// RVA: 0x19CD2CC Offset: 0x19C92CC VA: 0x19CD2CC Slot: 11
	protected override void OnItemNotFound() { }

	// RVA: 0x19CD324 Offset: 0x19C9324 VA: 0x19CD324 Slot: 12
	protected override void OnItemTypeNotAllowed() { }

	// RVA: 0x19CD37C Offset: 0x19C937C VA: 0x19CD37C Slot: 13
	protected override void OnItemHasNoColor() { }

	// RVA: 0x19CD3D4 Offset: 0x19C93D4 VA: 0x19CD3D4 Slot: 14
	protected override void OnPaletteDataNull() { }

	// RVA: 0x19CD42C Offset: 0x19C942C VA: 0x19CD42C Slot: 15
	protected override void OnMaxColorStock() { }

	// RVA: 0x19CD484 Offset: 0x19C9484 VA: 0x19CD484 Slot: 16
	protected override void OnFailure(short returnCode) { }
}
