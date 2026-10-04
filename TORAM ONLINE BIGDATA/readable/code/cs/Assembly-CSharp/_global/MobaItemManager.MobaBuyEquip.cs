// Assembly: Assembly-CSharp.dll
// Namespace: 
private class MobaItemManager.MobaBuyEquip : MobaBuyEquipExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 2047
{
	// Fields
	private MobaItemManager manager; // 0x20

	// Methods

	// RVA: 0x213E398 Offset: 0x213A398 VA: 0x213E398
	public void .ctor(MobaItemManager manager, byte equipType, byte itemType, int atk, int price, bool isUpdate) { }

	// RVA: 0x213EAA0 Offset: 0x213AAA0 VA: 0x213EAA0 Slot: 11
	protected override void OnConditionsAreNotMet(MobaBuyEquipResponse response) { }

	// RVA: 0x213EAA4 Offset: 0x213AAA4 VA: 0x213EAA4 Slot: 13
	protected override void OnEquipAlreadyExists(MobaBuyEquipResponse response) { }

	// RVA: 0x213EAA8 Offset: 0x213AAA8 VA: 0x213EAA8 Slot: 14
	protected override void OnEquipNotFound(MobaBuyEquipResponse response) { }

	// RVA: 0x213EAAC Offset: 0x213AAAC VA: 0x213EAAC Slot: 15
	protected override void OnFailure(short returnCode, MobaBuyEquipResponse response) { }

	// RVA: 0x213EAB0 Offset: 0x213AAB0 VA: 0x213EAB0 Slot: 12
	protected override void OnMoneyNotEnough(MobaBuyEquipResponse response) { }

	// RVA: 0x213EAB4 Offset: 0x213AAB4 VA: 0x213EAB4 Slot: 10
	protected override void OnSuccess(MobaBuyEquipResponse response) { }
}
