// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIPetRaceRulePanel.PetRaceGetRecord : PetRaceGetRecordExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 6002
{
	// Fields
	private UIPetRaceRulePanel panel; // 0x18
	private int courseId; // 0x20

	// Methods

	// RVA: 0x1864140 Offset: 0x1860140 VA: 0x1864140
	public void .ctor(UIPetRaceRulePanel panel) { }

	// RVA: 0x1864798 Offset: 0x1860798 VA: 0x1864798 Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x186479C Offset: 0x186079C VA: 0x186479C Slot: 10
	protected override void OnSuccess(PetRaceGetRecordResponse response) { }

	// RVA: 0x18647C4 Offset: 0x18607C4 VA: 0x18647C4 Slot: 12
	protected override void OnSystemLock() { }

	// RVA: 0x1864904 Offset: 0x1860904 VA: 0x1864904 Slot: 13
	protected override void OnUnableJoin(short returnCode) { }

	// RVA: 0x186490C Offset: 0x186090C VA: 0x186490C Slot: 14
	protected override void OnWrongStateOrPhase(short returnCode) { }
}
