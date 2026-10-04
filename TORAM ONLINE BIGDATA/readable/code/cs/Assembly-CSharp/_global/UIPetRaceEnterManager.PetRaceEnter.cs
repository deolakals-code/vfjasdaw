// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIPetRaceEnterManager.PetRaceEnter : PetRaceEnterExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 5972
{
	// Fields
	private UIPetRaceEnterManager manager; // 0x18

	// Methods

	// RVA: 0x1858914 Offset: 0x1854914 VA: 0x1858914
	public void .ctor(UIPetRaceEnterManager manager, int objId, byte petRaceType) { }

	// RVA: 0x1858BCC Offset: 0x1854BCC VA: 0x1858BCC Slot: 10
	protected override void OnSuccess(OperationResponse response) { }

	// RVA: 0x1858C1C Offset: 0x1854C1C VA: 0x1858C1C Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1858CD4 Offset: 0x1854CD4 VA: 0x1858CD4 Slot: 13
	protected override void OnNotReadyEnter() { }

	// RVA: 0x1858D94 Offset: 0x1854D94 VA: 0x1858D94 Slot: 12
	protected override void OnSystemLock() { }

	// RVA: 0x1858E30 Offset: 0x1854E30 VA: 0x1858E30 Slot: 14
	protected override void OnUnableJoin() { }

	// RVA: 0x1858EF0 Offset: 0x1854EF0 VA: 0x1858EF0 Slot: 15
	protected override void OnNotParty() { }

	// RVA: 0x1858FB0 Offset: 0x1854FB0 VA: 0x1858FB0 Slot: 16
	protected override void OnAlreadyStart() { }

	// RVA: 0x1859070 Offset: 0x1855070 VA: 0x1859070 Slot: 17
	protected override void OnRaceMemberOver() { }
}
