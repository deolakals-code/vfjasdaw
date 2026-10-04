// Assembly: Assembly-CSharp.dll
// Namespace: 
private class SmithProcessing.MaterialProcessing : MaterialProcessingExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 8530
{
	// Fields
	private SmithProcessing manager; // 0x30

	// Methods

	// RVA: 0x1D9D538 Offset: 0x1D99538 VA: 0x1D9D538
	public void .ctor(SmithProcessing manager, ItemSelectData[] itemList) { }

	// RVA: 0x1D9D584 Offset: 0x1D99584 VA: 0x1D9D584
	public void .ctor(SmithProcessing manager, int shopId, byte shopType, short[] position, ItemSelectData[] itemList) { }

	// RVA: 0x1D9D5DC Offset: 0x1D995DC VA: 0x1D9D5DC Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1D9D5E0 Offset: 0x1D995E0 VA: 0x1D9D5E0 Slot: 10
	protected override void OnSuccess(MaterialProcessingResponse response) { }
}
