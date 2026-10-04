// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIFishingPanelManager.StartFishing : StartFishingExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 7057
{
	// Fields
	private UIFishingPanelManager panel; // 0x18

	// Methods

	// RVA: 0x1A84454 Offset: 0x1A80454 VA: 0x1A84454
	public void .ctor(int fieldId, UIFishingPanelManager panel) { }

	// RVA: 0x1A865DC Offset: 0x1A825DC VA: 0x1A865DC Slot: 18
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1A86640 Offset: 0x1A82640 VA: 0x1A86640
	private void PopMessageErr(string errText) { }

	// RVA: 0x1A86704 Offset: 0x1A82704 VA: 0x1A86704 Slot: 11
	protected override void OnAlreadyFishing() { }

	// RVA: 0x1A86768 Offset: 0x1A82768 VA: 0x1A86768 Slot: 12
	protected override void OnBagIsFull() { }

	// RVA: 0x1A867B0 Offset: 0x1A827B0 VA: 0x1A867B0 Slot: 17
	protected override void OnBagNotFreeLocation() { }

	// RVA: 0x1A867F8 Offset: 0x1A827F8 VA: 0x1A867F8 Slot: 14
	protected override void OnFishingRodCanNotUse() { }

	// RVA: 0x1A86840 Offset: 0x1A82840 VA: 0x1A86840 Slot: 15
	protected override void OnNotAllowed() { }

	// RVA: 0x1A86888 Offset: 0x1A82888 VA: 0x1A86888 Slot: 16
	protected override void OnNotGetTarget() { }

	// RVA: 0x1A868D0 Offset: 0x1A828D0 VA: 0x1A868D0 Slot: 13
	protected override void OnRodNotFound() { }

	// RVA: 0x1A86918 Offset: 0x1A82918 VA: 0x1A86918 Slot: 10
	protected override void OnSuccess() { }
}
