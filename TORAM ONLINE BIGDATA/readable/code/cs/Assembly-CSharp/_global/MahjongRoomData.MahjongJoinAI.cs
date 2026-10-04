// Assembly: Assembly-CSharp.dll
// Namespace: 
private class MahjongRoomData.MahjongJoinAI : MahjongJoinAIExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 2367
{
	// Fields
	private MahjongRoomData roomData; // 0x10

	// Methods

	// RVA: 0x219C408 Offset: 0x2198408 VA: 0x219C408
	public void .ctor(MahjongRoomData roomData) { }

	// RVA: 0x219E3B8 Offset: 0x219A3B8 VA: 0x219E3B8 Slot: 14
	protected override void OnAlreadyJoin() { }

	// RVA: 0x219E3E8 Offset: 0x219A3E8 VA: 0x219E3E8 Slot: 16
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x219E428 Offset: 0x219A428 VA: 0x219E428 Slot: 13
	protected override void OnNoAuthority() { }

	// RVA: 0x219E458 Offset: 0x219A458 VA: 0x219E458 Slot: 12
	protected override void OnNotJoined() { }

	// RVA: 0x219E488 Offset: 0x219A488 VA: 0x219E488 Slot: 15
	protected override void OnNoVacancies() { }

	// RVA: 0x219E4B8 Offset: 0x219A4B8 VA: 0x219E4B8 Slot: 10
	protected override void OnSuccess() { }

	// RVA: 0x219E4EC Offset: 0x219A4EC VA: 0x219E4EC Slot: 11
	protected override void OnSystemLock() { }
}
