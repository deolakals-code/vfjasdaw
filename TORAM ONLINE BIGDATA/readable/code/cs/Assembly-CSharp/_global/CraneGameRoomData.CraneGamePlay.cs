// Assembly: Assembly-CSharp.dll
// Namespace: 
private class CraneGameRoomData.CraneGamePlay : CraneGamePlayExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 2325
{
	// Fields
	private CraneGameRoomData roomData; // 0x10

	// Methods

	// RVA: 0x2186DA0 Offset: 0x2182DA0 VA: 0x2186DA0
	public void .ctor(CraneGameRoomData roomData) { }

	// RVA: 0x2187308 Offset: 0x2183308 VA: 0x2187308 Slot: 11
	protected override void OnAlreadyPlaying() { }

	// RVA: 0x218730C Offset: 0x218330C VA: 0x218730C Slot: 13
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x2187310 Offset: 0x2183310 VA: 0x2187310 Slot: 12
	protected override void OnPlayCountNotEnough() { }

	// RVA: 0x2187314 Offset: 0x2183314 VA: 0x2187314 Slot: 10
	protected override void OnSuccess(OperationResponse response) { }
}
