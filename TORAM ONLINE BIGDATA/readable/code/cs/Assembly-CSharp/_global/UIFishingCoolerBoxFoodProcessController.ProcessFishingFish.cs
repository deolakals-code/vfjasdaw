// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIFishingCoolerBoxFoodProcessController.ProcessFishingFish : ProcessFishingFishExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 7022
{
	// Fields
	private UIFishingCoolerBoxFoodProcessController foodProcessController; // 0x18

	// Methods

	// RVA: 0x1A78EFC Offset: 0x1A74EFC VA: 0x1A78EFC
	public void .ctor(short[] indexList, UIFishingCoolerBoxFoodProcessController foodProcessController) { }

	// RVA: 0x1A78F2C Offset: 0x1A74F2C VA: 0x1A78F2C Slot: 13
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1A78FFC Offset: 0x1A74FFC VA: 0x1A78FFC Slot: 12
	protected override void OnFishNotFound() { }

	// RVA: 0x1A7908C Offset: 0x1A7508C VA: 0x1A7908C Slot: 11
	protected override void OnFoodPointUpperLimit() { }

	// RVA: 0x1A7911C Offset: 0x1A7511C VA: 0x1A7911C Slot: 10
	protected override void OnSuccess(ProcessFishingFishResponse response) { }
}
