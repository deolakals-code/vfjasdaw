// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIWavePointShopManager.GetWaveReward : GetWaveRewardExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 6433
{
	// Fields
	private UIWavePointShopManager manager; // 0x18
	private int fieldId; // 0x20
	private byte waveNo; // 0x24
	private byte index; // 0x25

	// Methods

	// RVA: 0x1933724 Offset: 0x192F724 VA: 0x1933724
	public void .ctor(UIWavePointShopManager manager, int fieldId, byte waveNo, byte index) { }

	// RVA: 0x1933784 Offset: 0x192F784 VA: 0x1933784 Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1933788 Offset: 0x192F788 VA: 0x1933788 Slot: 10
	protected override void OnSuccess(GetWaveRewardResponse response) { }

	// RVA: 0x193382C Offset: 0x192F82C VA: 0x193382C Slot: 12
	protected override void OnSystemLock() { }
}
