// Assembly: Assembly-CSharp.dll
// Namespace: 
private class SmithReconstruction.ArmorRemodeling : ArmorRemodelingExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 8538
{
	// Fields
	private SmithReconstruction manager; // 0x28

	// Methods

	// RVA: 0x1DA1508 Offset: 0x1D9D508 VA: 0x1DA1508
	public void .ctor(SmithReconstruction manager, int shopId, short[] position, int customItemUuid, byte customType) { }

	// RVA: 0x1DA155C Offset: 0x1D9D55C VA: 0x1DA155C Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1DA1560 Offset: 0x1D9D560 VA: 0x1DA1560 Slot: 10
	protected override void OnSuccess(ArmorRemodelingResponse response) { }
}
