// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UICreateFishingRodManager.DiscardFishingRod : DiscardFishingRodExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 7016
{
	// Fields
	private Action<byte> successAction; // 0x18
	private Action errorAction; // 0x20

	// Methods

	// RVA: 0x1A76D30 Offset: 0x1A72D30 VA: 0x1A76D30
	public void .ctor(byte index, Action<byte> successAction, Action errorAction) { }

	// RVA: 0x1A76D74 Offset: 0x1A72D74 VA: 0x1A76D74 Slot: 13
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1A76D98 Offset: 0x1A72D98 VA: 0x1A76D98 Slot: 11
	protected override void OnIndexOutOfRange() { }

	// RVA: 0x1A76DBC Offset: 0x1A72DBC VA: 0x1A76DBC Slot: 12
	protected override void OnRodNotFound() { }

	// RVA: 0x1A76DE0 Offset: 0x1A72DE0 VA: 0x1A76DE0 Slot: 10
	protected override void OnSuccess(DiscardFishingRodResponse response) { }
}
