// Assembly: Assembly-CSharp.dll
// Namespace: 
private class SmithManufacture.EquipmentProduction : EquipmentProductionExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 8502
{
	// Fields
	private SmithManufacture manager; // 0x28

	// Methods

	// RVA: 0x1D96898 Offset: 0x1D92898 VA: 0x1D96898
	public void .ctor(SmithManufacture manager, int recipeId) { }

	// RVA: 0x1D968E8 Offset: 0x1D928E8 VA: 0x1D968E8
	public void .ctor(SmithManufacture manager, int shopId, short[] position, int recipeId) { }

	// RVA: 0x1D96940 Offset: 0x1D92940 VA: 0x1D96940 Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1D96944 Offset: 0x1D92944 VA: 0x1D96944 Slot: 10
	protected override void OnSuccess(EquipmentProductionResponse response) { }
}
