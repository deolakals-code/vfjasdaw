// Assembly: Assembly-CSharp.dll
// Namespace: 
private class CraneGameRoomData.CraneGameResult : CraneGameResultExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 2323
{
	// Fields
	private CraneGameRoomData roomData; // 0x18
	private int score; // 0x20
	private bool isGet; // 0x24

	// Methods

	// RVA: 0x2186E98 Offset: 0x2182E98 VA: 0x2186E98
	public void .ctor(bool isGet, int score, CraneGameRoomData roomData) { }

	// RVA: 0x21870E4 Offset: 0x21830E4 VA: 0x21870E4 Slot: 12
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x21870E8 Offset: 0x21830E8 VA: 0x21870E8 Slot: 11
	protected override void OnNotPlay() { }

	// RVA: 0x21870EC Offset: 0x21830EC VA: 0x21870EC Slot: 10
	protected override void OnSuccess(OperationResponse response) { }
}
