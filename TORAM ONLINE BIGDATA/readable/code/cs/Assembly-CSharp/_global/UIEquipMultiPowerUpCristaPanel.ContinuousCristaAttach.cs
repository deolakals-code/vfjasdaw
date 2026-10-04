// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIEquipMultiPowerUpCristaPanel.ContinuousCristaAttach : ContinuousCristaAttachExplain, IReconnectionData, IReconnectionReceiveResponse // TypeDefIndex: 6958
{
	// Fields
	private UIEquipMultiPowerUpCristaPanel panel; // 0x28

	// Methods

	// RVA: 0x1A62728 Offset: 0x1A5E728 VA: 0x1A62728
	public void .ctor(UIEquipMultiPowerUpCristaPanel panel, int targetEquipUuid, byte targetSlot, CristaAttach ca, Dictionary<byte, ReinforceCristaAttach> rcaList) { }

	// RVA: 0x1A62768 Offset: 0x1A5E768 VA: 0x1A62768 Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1A62794 Offset: 0x1A5E794 VA: 0x1A62794 Slot: 10
	protected override void OnSystemLock() { }

	// RVA: 0x1A627C4 Offset: 0x1A5E7C4 VA: 0x1A627C4 Slot: 9
	protected override void OnSuccess(ContinuousCristaAttachResponse response) { }
}
