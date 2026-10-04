// Assembly: Assembly-CSharp.dll
// Namespace: 
private class SmithStrengthening.RefiningEquipment : RefiningEquipmentExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 8544
{
	// Fields
	private SmithStrengthening manager; // 0x38

	// Methods

	// RVA: 0x1DA7420 Offset: 0x1DA3420 VA: 0x1DA7420
	public void .ctor(SmithStrengthening manager, int refineItemUuid, int oreItemId, int supportItemId, bool isDirect, int orb) { }

	// RVA: 0x1DA7484 Offset: 0x1DA3484 VA: 0x1DA7484
	public void .ctor(SmithStrengthening manager, int shopId, short[] position, int refineItemUuid, int oreItemId, int supportItemId, bool isDirect, int orb) { }

	// RVA: 0x1DA74FC Offset: 0x1DA34FC VA: 0x1DA74FC Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1DA7500 Offset: 0x1DA3500 VA: 0x1DA7500 Slot: 10
	protected override void OnSuccess(RefiningEquipmentResponse response) { }
}
