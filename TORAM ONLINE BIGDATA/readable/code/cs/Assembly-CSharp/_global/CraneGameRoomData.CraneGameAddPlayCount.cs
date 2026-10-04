// Assembly: Assembly-CSharp.dll
// Namespace: 
private class CraneGameRoomData.CraneGameAddPlayCount : CraneGameAddPlayCountExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 2324
{
	// Fields
	private CraneGameRoomData roomData; // 0x18

	// Methods

	// RVA: 0x2186CCC Offset: 0x2182CCC VA: 0x2186CCC
	public void .ctor(byte addPlayCount, CraneGameRoomData roomData) { }

	// RVA: 0x2187244 Offset: 0x2183244 VA: 0x2187244 Slot: 11
	protected override void OnAlreadyPlaying() { }

	// RVA: 0x2187248 Offset: 0x2183248 VA: 0x2187248 Slot: 14
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x218724C Offset: 0x218324C VA: 0x218724C Slot: 13
	protected override void OnMoneyNotEnough() { }

	// RVA: 0x2187290 Offset: 0x2183290 VA: 0x2187290 Slot: 10
	protected override void OnSuccess(CraneGameAddPlayCountResponse response) { }

	// RVA: 0x21872C4 Offset: 0x21832C4 VA: 0x21872C4 Slot: 12
	protected override void OnUpperLimitPlayCount() { }
}
