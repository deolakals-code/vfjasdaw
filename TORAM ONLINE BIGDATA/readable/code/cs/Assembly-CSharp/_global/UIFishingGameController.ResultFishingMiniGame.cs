// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIFishingGameController.ResultFishingMiniGame : ResultFishingMiniGameExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 4351
{
	// Fields
	private bool isSuccess; // 0x20
	private UIFishingGameController gameController; // 0x28

	// Methods

	// RVA: 0x24D7BD8 Offset: 0x24D3BD8 VA: 0x24D7BD8
	public void .ctor(bool isSuccess, int[] hitLogs, UIFishingGameController fishingGameController) { }

	// RVA: 0x24D9C08 Offset: 0x24D5C08 VA: 0x24D9C08 Slot: 13
	protected override void OnBagIsFull() { }

	// RVA: 0x24D9C4C Offset: 0x24D5C4C VA: 0x24D9C4C Slot: 15
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x24D9CF4 Offset: 0x24D5CF4 VA: 0x24D9CF4 Slot: 14
	protected override void OnFishNotFound() { }

	// RVA: 0x24D9D50 Offset: 0x24D5D50 VA: 0x24D9D50 Slot: 11
	protected override void OnNotHit() { }

	// RVA: 0x24D9DAC Offset: 0x24D5DAC VA: 0x24D9DAC Slot: 12
	protected override void OnNotStartMiniGame() { }

	// RVA: 0x24D9E08 Offset: 0x24D5E08 VA: 0x24D9E08 Slot: 10
	protected override void OnSuccess(ResultFishingMiniGameResponse response) { }
}
