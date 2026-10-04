// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIPlayerStatusDetailPanel.GetBonusStatus : GetBonusStatusExplain, IReconnectionData, IReconnectionReceiveResponse // TypeDefIndex: 8045
{
	// Fields
	private UIPlayerStatusDetailPanel panel; // 0x10

	// Properties
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x1CB163C Offset: 0x1CAD63C VA: 0x1CB163C
	public void .ctor(UIPlayerStatusDetailPanel panel) { }

	// RVA: 0x1CB166C Offset: 0x1CAD66C VA: 0x1CB166C Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x1CB1674 Offset: 0x1CAD674 VA: 0x1CB1674 Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1CB1678 Offset: 0x1CAD678 VA: 0x1CB1678 Slot: 10
	protected override void OnSuccess(GetBonusStatusResponse response) { }
}
