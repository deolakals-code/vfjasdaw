// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UILogOutMenuManager.EnterScoreAttackHall : EnterScoreAttackHallExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 8153
{
	// Fields
	private Action failureCallBack; // 0x10

	// Methods

	// RVA: 0x1CDE5E4 Offset: 0x1CDA5E4 VA: 0x1CDE5E4
	public void .ctor(Action failureCallBack) { }

	// RVA: 0x1CDED7C Offset: 0x1CDAD7C VA: 0x1CDED7C Slot: 12
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1CDEE20 Offset: 0x1CDAE20 VA: 0x1CDEE20 Slot: 11
	protected override void OnNotEnoughAccountProgress() { }

	// RVA: 0x1CDEE3C Offset: 0x1CDAE3C VA: 0x1CDEE3C Slot: 10
	protected override void OnSuccess() { }
}
