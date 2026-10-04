// Assembly: Assembly-CSharp.dll
// Namespace: 
private class SyntheticEquip.SynthesizeEquipment : SynthesizeEquipmentExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 8680
{
	// Fields
	private SyntheticEquip manager; // 0x48

	// Methods

	// RVA: 0x1DE433C Offset: 0x1DE033C VA: 0x1DE433C
	public void .ctor(SyntheticEquip manager, int[] itemUuid, int[] useItemUuid, int supportItemId) { }

	// RVA: 0x1DE4394 Offset: 0x1DE0394 VA: 0x1DE4394
	public void .ctor(SyntheticEquip manager, int shopId, short[] position, int[] itemUuid, int[] useItemUuid, int supportItemId, int orb, int useOrb) { }

	// RVA: 0x1DE4408 Offset: 0x1DE0408 VA: 0x1DE4408 Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1DE440C Offset: 0x1DE040C VA: 0x1DE440C Slot: 10
	protected override void OnSuccess(SynthesizeEquipmentResponse response) { }
}
