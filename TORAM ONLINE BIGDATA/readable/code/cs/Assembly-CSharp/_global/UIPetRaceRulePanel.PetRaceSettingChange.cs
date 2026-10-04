// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIPetRaceRulePanel.PetRaceSettingChange : PetRaceSettingChangeExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 6000
{
	// Fields
	private PetRaceRoomData roomData; // 0x18

	// Methods

	// RVA: 0x1863F30 Offset: 0x185FF30 VA: 0x1863F30
	public void .ctor(PetRaceRoomData roomData, int courseId, short flag) { }

	// RVA: 0x1864550 Offset: 0x1860550 VA: 0x1864550 Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1864554 Offset: 0x1860554 VA: 0x1864554 Slot: 10
	protected override void OnSuccess(PetRaceSettingChangeResponse response) { }

	// RVA: 0x1864588 Offset: 0x1860588 VA: 0x1864588 Slot: 12
	protected override void OnSystemLock() { }

	// RVA: 0x18646C8 Offset: 0x18606C8 VA: 0x18646C8 Slot: 13
	protected override void OnUnableJoin(short returnCode) { }

	// RVA: 0x18646D0 Offset: 0x18606D0 VA: 0x18646D0 Slot: 14
	protected override void OnWrongStateOrPhase(short returnCode) { }
}
