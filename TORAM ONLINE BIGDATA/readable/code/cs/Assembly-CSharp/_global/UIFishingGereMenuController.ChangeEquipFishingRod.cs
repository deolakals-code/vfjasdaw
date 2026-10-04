// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIFishingGereMenuController.ChangeEquipFishingRod : ChangeEquipFishingRodExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 7035
{
	// Fields
	private Action callBack; // 0x18

	// Methods

	// RVA: 0x1A7E544 Offset: 0x1A7A544 VA: 0x1A7E544
	public void .ctor(byte index, Action callback) { }

	// RVA: 0x1A7E574 Offset: 0x1A7A574 VA: 0x1A7E574 Slot: 15
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1A7E5FC Offset: 0x1A7A5FC VA: 0x1A7E5FC Slot: 14
	protected override void OnFishingRodCanNotUse() { }

	// RVA: 0x1A7E640 Offset: 0x1A7A640 VA: 0x1A7E640 Slot: 11
	protected override void OnIndexOutOfRange() { }

	// RVA: 0x1A7E684 Offset: 0x1A7A684 VA: 0x1A7E684 Slot: 12
	protected override void OnNoChange() { }

	// RVA: 0x1A7E6C8 Offset: 0x1A7A6C8 VA: 0x1A7E6C8 Slot: 13
	protected override void OnRodNotFound() { }

	// RVA: 0x1A7E70C Offset: 0x1A7A70C VA: 0x1A7E70C Slot: 10
	protected override void OnSuccess(ChangeEquipFishingRodResponse response) { }
}
