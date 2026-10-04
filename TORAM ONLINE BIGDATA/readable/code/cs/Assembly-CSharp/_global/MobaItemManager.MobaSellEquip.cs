// Assembly: Assembly-CSharp.dll
// Namespace: 
private class MobaItemManager.MobaSellEquip : MobaSellEquipExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 2048
{
	// Fields
	private MobaItemManager manager; // 0x18

	// Methods

	// RVA: 0x213E4A4 Offset: 0x213A4A4 VA: 0x213E4A4
	public void .ctor(MobaItemManager manager, byte equipType, byte itemType, int price) { }

	// RVA: 0x213EB0C Offset: 0x213AB0C VA: 0x213EB0C Slot: 11
	protected override void OnConditionsAreNotMet(MobaSellEquipResponse response) { }

	// RVA: 0x213EB10 Offset: 0x213AB10 VA: 0x213EB10 Slot: 13
	protected override void OnEquipNotFound(MobaSellEquipResponse response) { }

	// RVA: 0x213EB14 Offset: 0x213AB14 VA: 0x213EB14 Slot: 14
	protected override void OnFailure(short returnCode, MobaSellEquipResponse response) { }

	// RVA: 0x213EB18 Offset: 0x213AB18 VA: 0x213EB18 Slot: 12
	protected override void OnMoneyNotEnough(MobaSellEquipResponse response) { }

	// RVA: 0x213EB1C Offset: 0x213AB1C VA: 0x213EB1C Slot: 10
	protected override void OnSuccess(MobaSellEquipResponse response) { }
}
