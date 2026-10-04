// Assembly: Assembly-CSharp.dll
// Namespace: 
private class TradeManager.TradeRequest : TradeRequestExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 3791
{
	// Methods

	// RVA: 0x23E8854 Offset: 0x23E4854 VA: 0x23E8854
	public void .ctor(int targetId) { }

	// RVA: 0x23E885C Offset: 0x23E485C VA: 0x23E885C Slot: 16
	protected override void OnAlreadyExists() { }

	// RVA: 0x23E8860 Offset: 0x23E4860 VA: 0x23E8860 Slot: 19
	protected override void OnAlreadyOtherTrade() { }

	// RVA: 0x23E8864 Offset: 0x23E4864 VA: 0x23E8864 Slot: 17
	protected override void OnArchetypeNotFound() { }

	// RVA: 0x23E8868 Offset: 0x23E4868 VA: 0x23E8868 Slot: 12
	protected override void OnBanLogistics() { }

	// RVA: 0x23E886C Offset: 0x23E486C VA: 0x23E886C Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x23E8870 Offset: 0x23E4870 VA: 0x23E8870 Slot: 18
	protected override void OnNotStateReceive() { }

	// RVA: 0x23E8874 Offset: 0x23E4874 VA: 0x23E8874 Slot: 10
	protected override void OnSuccess(TradeRequestResponse_ response) { }

	// RVA: 0x23E8878 Offset: 0x23E4878 VA: 0x23E8878 Slot: 13
	protected override void OnSystemLock() { }

	// RVA: 0x23E887C Offset: 0x23E487C VA: 0x23E887C Slot: 15
	protected override void OnTradeFatalState() { }

	// RVA: 0x23E8880 Offset: 0x23E4880 VA: 0x23E8880 Slot: 14
	protected override void OnWarrantyExists() { }
}
