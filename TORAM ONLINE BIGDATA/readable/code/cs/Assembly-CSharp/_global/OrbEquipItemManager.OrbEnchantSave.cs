// Assembly: Assembly-CSharp.dll
// Namespace: 
private class OrbEquipItemManager.OrbEnchantSave : OrbEnchantSaveExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 2143
{
	// Fields
	private OrbEquipItemManager manager; // 0x18

	// Methods

	// RVA: 0x214EC74 Offset: 0x214AC74 VA: 0x214EC74
	public void .ctor(OrbEquipItemManager manager, int targetItemUuid, byte targetType, byte index) { }

	// RVA: 0x214F5B0 Offset: 0x214B5B0 VA: 0x214F5B0 Slot: 13
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x214F5B4 Offset: 0x214B5B4 VA: 0x214F5B4 Slot: 11
	protected override void OnSystemLock() { }

	// RVA: 0x214F5B8 Offset: 0x214B5B8 VA: 0x214F5B8 Slot: 12
	protected override void OnWrong() { }

	// RVA: 0x214F5BC Offset: 0x214B5BC VA: 0x214F5BC Slot: 10
	protected override void OnSuccess(OrbEnchantSaveResponse response) { }
}
