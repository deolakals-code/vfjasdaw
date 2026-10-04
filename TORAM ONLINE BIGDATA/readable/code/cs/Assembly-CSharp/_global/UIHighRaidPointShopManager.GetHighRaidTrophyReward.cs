// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIHighRaidPointShopManager.GetHighRaidTrophyReward : GetHighRaidTrophyRewardExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 5809
{
	// Fields
	private UIHighRaidPointShopManager manager; // 0x18

	// Methods

	// RVA: 0x17FB73C Offset: 0x17F773C VA: 0x17FB73C
	public void .ctor(UIHighRaidPointShopManager manager, byte highRaidNo, byte trophyId) { }

	// RVA: 0x17FB774 Offset: 0x17F7774 VA: 0x17FB774 Slot: 13
	protected override void OnBagItemIsFull() { }

	// RVA: 0x17FB778 Offset: 0x17F7778 VA: 0x17FB778 Slot: 12
	protected override void OnBagNotFreeLocation() { }

	// RVA: 0x17FB77C Offset: 0x17F777C VA: 0x17FB77C Slot: 18
	protected override void OnDataNull() { }

	// RVA: 0x17FB780 Offset: 0x17F7780 VA: 0x17FB780 Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x17FB784 Offset: 0x17F7784 VA: 0x17FB784 Slot: 22
	protected override void OnFailureReloadTrophyData(short returnCode, Dictionary<byte, byte> trophys) { }

	// RVA: 0x17FB788 Offset: 0x17F7788 VA: 0x17FB788 Slot: 21
	protected override void OnFatal() { }

	// RVA: 0x17FB78C Offset: 0x17F778C VA: 0x17FB78C Slot: 17
	protected override void OnInvalidOperationParameter() { }

	// RVA: 0x17FB790 Offset: 0x17F7790 VA: 0x17FB790 Slot: 19
	protected override void OnNotBeHeld() { }

	// RVA: 0x17FB794 Offset: 0x17F7794 VA: 0x17FB794 Slot: 15
	protected override void OnNotReadyToRun() { }

	// RVA: 0x17FB798 Offset: 0x17F7798 VA: 0x17FB798 Slot: 20
	protected override void OnSqlError() { }

	// RVA: 0x17FB79C Offset: 0x17F779C VA: 0x17FB79C Slot: 14
	protected override void OnValueOver() { }

	// RVA: 0x17FB7A0 Offset: 0x17F77A0 VA: 0x17FB7A0 Slot: 10
	protected override void OnSuccess(byte highRaidNo, byte trophyId, RewardResponseDatav2 reward) { }

	// RVA: 0x17FB840 Offset: 0x17F7840 VA: 0x17FB840 Slot: 16
	protected override void OnBagCapacityOver() { }
}
