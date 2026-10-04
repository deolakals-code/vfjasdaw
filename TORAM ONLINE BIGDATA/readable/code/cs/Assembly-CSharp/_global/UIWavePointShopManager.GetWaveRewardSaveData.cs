// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIWavePointShopManager.GetWaveRewardSaveData : GetWaveRewardSaveDataExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 6434
{
	// Fields
	private UIWavePointShopManager manager; // 0x18
	private int fieldId; // 0x20

	// Methods

	// RVA: 0x1933830 Offset: 0x192F830 VA: 0x1933830
	public void .ctor(UIWavePointShopManager manager, int fieldId) { }

	// RVA: 0x1933870 Offset: 0x192F870 VA: 0x1933870 Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1933924 Offset: 0x192F924 VA: 0x1933924 Slot: 10
	protected override void OnSuccess(GetWaveRewardSaveDataResponse response) { }

	// RVA: 0x19339C4 Offset: 0x192F9C4 VA: 0x19339C4 Slot: 12
	protected override void OnSystemLock() { }
}
