// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UICreateFishingRodManager.CreateFishingRod : CreateFishingRodExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 7015
{
	// Fields
	private UICreateFishingRodManager createRodManager; // 0x28
	private Action errorAction; // 0x30

	// Methods

	// RVA: 0x1A76AE4 Offset: 0x1A72AE4 VA: 0x1A76AE4
	public void .ctor(byte index, MaterialData[] materialList, bool isSuccession, UICreateFishingRodManager createRodManager, Action errorAction) { }

	// RVA: 0x1A76B2C Offset: 0x1A72B2C VA: 0x1A76B2C Slot: 14
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1A76B50 Offset: 0x1A72B50 VA: 0x1A76B50 Slot: 11
	protected override void OnIndexOutOfRange() { }

	// RVA: 0x1A76B74 Offset: 0x1A72B74 VA: 0x1A76B74 Slot: 13
	protected override void OnMaterialNotEnough() { }

	// RVA: 0x1A76B98 Offset: 0x1A72B98 VA: 0x1A76B98 Slot: 12
	protected override void OnMaterialWrong() { }

	// RVA: 0x1A76BBC Offset: 0x1A72BBC VA: 0x1A76BBC Slot: 10
	protected override void OnSuccess(CreateFishingRodResponse response) { }
}
