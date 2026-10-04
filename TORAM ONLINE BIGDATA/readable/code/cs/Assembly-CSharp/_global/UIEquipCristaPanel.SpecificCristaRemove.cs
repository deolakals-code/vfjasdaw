// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIEquipCristaPanel.SpecificCristaRemove : SpecificCristaRemoveExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 6903
{
	// Fields
	private UIEquipCristaPanel panel; // 0x18

	// Methods

	// RVA: 0x1A47B44 Offset: 0x1A43B44 VA: 0x1A47B44
	public void .ctor(UIEquipCristaPanel panel, int targetItemUuid, byte slotNo) { }

	// RVA: 0x1A4963C Offset: 0x1A4563C VA: 0x1A4963C Slot: 13
	protected override void OnBagFull(short returnCode) { }

	// RVA: 0x1A496B4 Offset: 0x1A456B4 VA: 0x1A496B4 Slot: 14
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1A49774 Offset: 0x1A45774 VA: 0x1A49774 Slot: 12
	protected override void OnWrong(short returnCode) { }

	// RVA: 0x1A49834 Offset: 0x1A45834 VA: 0x1A49834 Slot: 11
	protected override void OnSystemLock() { }

	// RVA: 0x1A49888 Offset: 0x1A45888 VA: 0x1A49888 Slot: 10
	protected override void OnSuccess(SpecificCristaRemoveResponse response) { }
}
