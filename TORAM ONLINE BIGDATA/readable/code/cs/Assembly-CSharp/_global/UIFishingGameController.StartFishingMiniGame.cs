// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIFishingGameController.StartFishingMiniGame : StartFishingMiniGameExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 4350
{
	// Fields
	private UIFishingGameController gameController; // 0x10

	// Methods

	// RVA: 0x24D8358 Offset: 0x24D4358 VA: 0x24D8358
	public void .ctor(UIFishingGameController gameController) { }

	// RVA: 0x24D9AB0 Offset: 0x24D5AB0 VA: 0x24D9AB0 Slot: 11
	protected override void OnDoNotFishing() { }

	// RVA: 0x24D9B14 Offset: 0x24D5B14 VA: 0x24D9B14 Slot: 13
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x24D9B78 Offset: 0x24D5B78 VA: 0x24D9B78 Slot: 12
	protected override void OnNotHit() { }

	// RVA: 0x24D9BDC Offset: 0x24D5BDC VA: 0x24D9BDC Slot: 10
	protected override void OnSuccess(StartFishingMiniGameResponse response) { }
}
