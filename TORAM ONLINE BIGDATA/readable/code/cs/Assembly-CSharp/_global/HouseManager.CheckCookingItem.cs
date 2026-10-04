// Assembly: Assembly-CSharp.dll
// Namespace: 
private class HouseManager.CheckCookingItem : CheckCookingItemExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 3948
{
	// Methods

	// RVA: 0x2423EFC Offset: 0x241FEFC VA: 0x2423EFC
	public void .ctor(List<int> mainCookingItems, List<int> subCookingItems) { }

	// RVA: 0x2423F04 Offset: 0x241FF04 VA: 0x2423F04 Slot: 12
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x2423F08 Offset: 0x241FF08 VA: 0x2423F08 Slot: 11
	protected override void OnNotAllowed() { }

	// RVA: 0x2423F0C Offset: 0x241FF0C VA: 0x2423F0C Slot: 10
	protected override void OnSuccess(HouseCheckCookingItemResponse response) { }
}
