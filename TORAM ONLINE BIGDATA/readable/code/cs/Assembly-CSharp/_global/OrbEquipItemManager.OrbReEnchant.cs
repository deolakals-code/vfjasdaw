// Assembly: Assembly-CSharp.dll
// Namespace: 
private class OrbEquipItemManager.OrbReEnchant : OrbReEnchantExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 2141
{
	// Fields
	private OrbEquipItemManager manager; // 0x18
	private byte targetType; // 0x20
	private byte enchantIndex; // 0x21

	// Methods

	// RVA: 0x214E93C Offset: 0x214A93C VA: 0x214E93C
	public void .ctor(OrbEquipItemManager manager, int targetItemUuid, byte targetType, byte enchantIndex) { }

	// RVA: 0x214F3DC Offset: 0x214B3DC VA: 0x214F3DC Slot: 13
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x214F3E0 Offset: 0x214B3E0 VA: 0x214F3E0 Slot: 11
	protected override void OnSystemLock() { }

	// RVA: 0x214F3E4 Offset: 0x214B3E4 VA: 0x214F3E4 Slot: 12
	protected override void OnWrong() { }

	// RVA: 0x214F3E8 Offset: 0x214B3E8 VA: 0x214F3E8 Slot: 10
	protected override void OnSuccess(OrbReEnchantResponse response) { }
}
