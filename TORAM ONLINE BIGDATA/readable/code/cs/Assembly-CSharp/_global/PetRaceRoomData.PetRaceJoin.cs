// Assembly: Assembly-CSharp.dll
// Namespace: 
private class PetRaceRoomData.PetRaceJoin : PetRaceJoinExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 2432
{
	// Fields
	private PetRaceRoomData roomData; // 0x10
	private byte checkPhase; // 0x18

	// Methods

	// RVA: 0x21B1DD0 Offset: 0x21ADDD0 VA: 0x21B1DD0
	public void .ctor(PetRaceRoomData roomData, byte phase = 0) { }

	// RVA: 0x21B484C Offset: 0x21B084C VA: 0x21B484C Slot: 13
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x21B48D8 Offset: 0x21B08D8 VA: 0x21B48D8 Slot: 15
	protected override void OnSqlError() { }

	// RVA: 0x21B48DC Offset: 0x21B08DC VA: 0x21B48DC
	private bool CommomRoomUpdate(PetRaceJoinResponse response) { }

	// RVA: 0x21B4988 Offset: 0x21B0988 VA: 0x21B4988 Slot: 10
	protected override void OnSuccessPreparation(PetRaceJoinSettingPhaseResponse response) { }

	// RVA: 0x21B4C70 Offset: 0x21B0C70 VA: 0x21B4C70 Slot: 11
	protected override void OnSuccessPlay(PetRaceJoinPlayPhaseResponse response) { }

	// RVA: 0x21B4EC0 Offset: 0x21B0EC0 VA: 0x21B4EC0 Slot: 12
	protected override void OnSuccessResult(PetRaceJoinResultPhaseResponse response) { }

	// RVA: 0x21B4F0C Offset: 0x21B0F0C VA: 0x21B4F0C Slot: 14
	protected override void OnSystemLock() { }

	// RVA: 0x21B504C Offset: 0x21B104C VA: 0x21B504C Slot: 16
	protected override void OnUnableJoin(short returnCode) { }
}
