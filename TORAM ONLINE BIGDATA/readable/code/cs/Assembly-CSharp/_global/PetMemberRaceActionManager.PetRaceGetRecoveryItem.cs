// Assembly: Assembly-CSharp.dll
// Namespace: 
private class PetMemberRaceActionManager.PetRaceGetRecoveryItem : PetRaceGetItemExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 1321
{
	// Fields
	private PetRaceRoomData roomData; // 0x18
	private PetMemberRaceActionManager actionManager; // 0x20
	private byte itemId; // 0x28
	private float stamina; // 0x2C

	// Methods

	// RVA: 0x1FC3AA8 Offset: 0x1FBFAA8 VA: 0x1FC3AA8
	public void .ctor(PetMemberRaceActionManager actionManager, PetRaceRoomData roomData, byte id, float stamina) { }

	// RVA: 0x1FC507C Offset: 0x1FC107C VA: 0x1FC507C Slot: 10
	protected override void OnSuccess(PetRaceGetItemResponse response) { }

	// RVA: 0x1FC537C Offset: 0x1FC137C VA: 0x1FC537C Slot: 16
	protected override void OnAlreadyGetItem(PetRaceGetItemResponse response) { }

	// RVA: 0x1FC5398 Offset: 0x1FC1398 VA: 0x1FC5398 Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1FC539C Offset: 0x1FC139C VA: 0x1FC539C Slot: 12
	protected override void OnSystemLock() { }

	// RVA: 0x1FC54DC Offset: 0x1FC14DC VA: 0x1FC54DC Slot: 13
	protected override void OnUnableJoin(short returnCode) { }

	// RVA: 0x1FC54E4 Offset: 0x1FC14E4 VA: 0x1FC54E4 Slot: 14
	protected override void OnWrongStateOrPhase(short returnCode) { }

	// RVA: 0x1FC54E8 Offset: 0x1FC14E8 VA: 0x1FC54E8 Slot: 15
	protected override void OnNotJoinedInTheCourse() { }
}
