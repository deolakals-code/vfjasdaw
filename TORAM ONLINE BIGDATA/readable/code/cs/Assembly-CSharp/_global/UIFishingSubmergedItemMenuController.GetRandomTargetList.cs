// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIFishingSubmergedItemMenuController.GetRandomTargetList : GetRandomTargetListExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 7063
{
	// Fields
	private UIFishingSubmergedItemMenuController submergedItemMenuController; // 0x10
	private Action callBack; // 0x18

	// Methods

	// RVA: 0x1A882E0 Offset: 0x1A842E0 VA: 0x1A882E0
	public void .ctor(UIFishingSubmergedItemMenuController controller, Action callBack) { }

	// RVA: 0x1A883BC Offset: 0x1A843BC VA: 0x1A883BC Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1A88444 Offset: 0x1A84444 VA: 0x1A88444 Slot: 10
	protected override void OnSuccess(GetRandomTargetListResponse response) { }
}
