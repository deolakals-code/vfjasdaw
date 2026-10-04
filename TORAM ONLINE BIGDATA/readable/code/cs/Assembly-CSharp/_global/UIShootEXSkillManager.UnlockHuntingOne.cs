// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIShootEXSkillManager.UnlockHuntingOne : UnlockHuntingOneExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 6818
{
	// Fields
	private UIShootEXSkillManager manager; // 0x20

	// Methods

	// RVA: 0x1A0C98C Offset: 0x1A0898C VA: 0x1A0C98C
	public void .ctor(UIShootEXSkillManager manager, byte unlockNo, int useOrb, int orbNum) { }

	// RVA: 0x1A0D1DC Offset: 0x1A091DC VA: 0x1A0D1DC Slot: 12
	protected override void OnAlreadyExists(short returnCode) { }

	// RVA: 0x1A0D1E0 Offset: 0x1A091E0 VA: 0x1A0D1E0 Slot: 13
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1A0D1E4 Offset: 0x1A091E4 VA: 0x1A0D1E4 Slot: 10
	protected override void OnSuccess(UnlockHuntingOneResponse response) { }

	// RVA: 0x1A0D274 Offset: 0x1A09274 VA: 0x1A0D274 Slot: 11
	protected override void OnValueWrong(short returnCode) { }
}
