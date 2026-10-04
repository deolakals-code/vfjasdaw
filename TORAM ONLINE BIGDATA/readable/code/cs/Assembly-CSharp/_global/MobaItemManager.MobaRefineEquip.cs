// Assembly: Assembly-CSharp.dll
// Namespace: 
private class MobaItemManager.MobaRefineEquip : MobaRefineEquipExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 2049
{
	// Fields
	private MobaItemManager manager; // 0x18

	// Methods

	// RVA: 0x213E5B4 Offset: 0x213A5B4 VA: 0x213E5B4
	public void .ctor(MobaItemManager manager, byte equipType, byte itemType, byte refine, int price) { }

	// RVA: 0x213EB4C Offset: 0x213AB4C VA: 0x213EB4C Slot: 11
	protected override void OnConditionsAreNotMet(MobaRefineEquipResponse response) { }

	// RVA: 0x213EB50 Offset: 0x213AB50 VA: 0x213EB50 Slot: 13
	protected override void OnEquipNotFound(MobaRefineEquipResponse response) { }

	// RVA: 0x213EB54 Offset: 0x213AB54 VA: 0x213EB54 Slot: 15
	protected override void OnFailure(short returnCode, MobaRefineEquipResponse response) { }

	// RVA: 0x213EB58 Offset: 0x213AB58 VA: 0x213EB58 Slot: 12
	protected override void OnMoneyNotEnough(MobaRefineEquipResponse response) { }

	// RVA: 0x213EB5C Offset: 0x213AB5C VA: 0x213EB5C Slot: 14
	protected override void OnRefineOrverLevel(MobaRefineEquipResponse response) { }

	// RVA: 0x213EB60 Offset: 0x213AB60 VA: 0x213EB60 Slot: 10
	protected override void OnSuccess(MobaRefineEquipResponse response) { }
}
