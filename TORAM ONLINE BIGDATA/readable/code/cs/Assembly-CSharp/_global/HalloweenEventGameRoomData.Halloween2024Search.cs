// Assembly: Assembly-CSharp.dll
// Namespace: 
private class HalloweenEventGameRoomData.Halloween2024Search : HalloweenSearchExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 2346
{
	// Fields
	private HalloweenEventGameRoomData roomData; // 0x18
	private readonly byte id; // 0x20
	private readonly Action<int[]> callback; // 0x28
	private List<int> rewardItems; // 0x30

	// Methods

	// RVA: 0x2193790 Offset: 0x218F790 VA: 0x2193790
	public void .ctor(HalloweenEventGameRoomData roomData, byte floor, byte id, Action<int[]> callback) { }

	// RVA: 0x2193864 Offset: 0x218F864 VA: 0x2193864 Slot: 10
	protected override void OnSuccess(HalloweenSearchResponse response) { }

	// RVA: 0x2193BF4 Offset: 0x218FBF4 VA: 0x2193BF4 Slot: 16
	protected override void OnAlreadySearched(HalloweenSearchResponse response) { }

	// RVA: 0x2193894 Offset: 0x218F894 VA: 0x2193894
	private bool OnReward(HalloweenSearchResponse response) { }

	// RVA: 0x2193BF8 Offset: 0x218FBF8 VA: 0x2193BF8 Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x2193C28 Offset: 0x218FC28 VA: 0x2193C28 Slot: 18
	protected override void OnNoReward() { }

	// RVA: 0x2193C40 Offset: 0x218FC40 VA: 0x2193C40 Slot: 12
	protected override void OnSystemLock() { }

	// RVA: 0x2193CAC Offset: 0x218FCAC VA: 0x2193CAC Slot: 13
	protected override void OnGameEventNotHeld() { }

	// RVA: 0x2193CB0 Offset: 0x218FCB0 VA: 0x2193CB0 Slot: 15
	protected override void OnPointDataDiff() { }

	// RVA: 0x2193CC8 Offset: 0x218FCC8 VA: 0x2193CC8 Slot: 17
	protected override void OnDistanceError() { }

	// RVA: 0x2193C44 Offset: 0x218FC44 VA: 0x2193C44
	private void LeaveField() { }

	// RVA: 0x2193C10 Offset: 0x218FC10 VA: 0x2193C10
	private void AccessClear() { }

	// RVA: 0x2193CE0 Offset: 0x218FCE0 VA: 0x2193CE0 Slot: 14
	protected override void OnNotStart() { }
}
