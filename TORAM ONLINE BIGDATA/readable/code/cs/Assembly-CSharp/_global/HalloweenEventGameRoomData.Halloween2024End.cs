// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HalloweenEventGameRoomData.Halloween2024End : HalloweenEndExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 2348
{
	// Fields
	private HalloweenEventGameRoomData roomData; // 0x18
	private UIHalloweenGameManager panel; // 0x20
	private readonly bool redKey; // 0x28

	// Methods

	// RVA: 0x2193F98 Offset: 0x218FF98 VA: 0x2193F98
	public void .ctor(HalloweenEventGameRoomData roomData, UIHalloweenGameManager panel, bool redKey) { }

	// RVA: 0x2193FF0 Offset: 0x218FFF0 VA: 0x2193FF0 Slot: 16
	protected override void OnDistanceError() { }

	// RVA: 0x2194020 Offset: 0x2190020 VA: 0x2194020 Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x2194038 Offset: 0x2190038 VA: 0x2194038 Slot: 17
	protected override void OnKeyNothing(HalloweenEndResponse response) { }

	// RVA: 0x2194084 Offset: 0x2190084 VA: 0x2194084 Slot: 15
	protected override void OnAlreadyReceived(HalloweenEndResponse response) { }

	// RVA: 0x21942DC Offset: 0x21902DC VA: 0x21942DC Slot: 10
	protected override void OnSuccess(HalloweenEndResponse response) { }

	// RVA: 0x2194088 Offset: 0x2190088 VA: 0x2194088
	private void ReceiveResult(HalloweenEndResponse response) { }

	// RVA: 0x21942E0 Offset: 0x21902E0 VA: 0x21942E0 Slot: 12
	protected override void OnSystemLock() { }

	// RVA: 0x2194330 Offset: 0x2190330 VA: 0x2194330 Slot: 13
	protected override void OnGameEventNotHeld() { }

	// RVA: 0x2194008 Offset: 0x2190008 VA: 0x2194008
	private void AccessClear() { }

	// RVA: 0x2194380 Offset: 0x2190380 VA: 0x2194380 Slot: 14
	protected override void OnNotStart() { }
}
