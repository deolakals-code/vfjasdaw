// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UINecromancerExSkillManager.UnlockSummonDemonic : UnlockSummonDemonicExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 6751
{
	// Fields
	private UINecromancerExSkillManager manager; // 0x20

	// Methods

	// RVA: 0x19EBE7C Offset: 0x19E7E7C VA: 0x19EBE7C
	public void .ctor(UINecromancerExSkillManager manager, byte unlockNo, int useOrb, int orbNum) { }

	// RVA: 0x19EDDC8 Offset: 0x19E9DC8 VA: 0x19EDDC8 Slot: 12
	protected override void OnAlreadyExists(short returnCode) { }

	// RVA: 0x19EDDCC Offset: 0x19E9DCC VA: 0x19EDDCC Slot: 13
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x19EDDD0 Offset: 0x19E9DD0 VA: 0x19EDDD0 Slot: 10
	protected override void OnSuccess(UnlockSummonDemonicResponse response) { }

	// RVA: 0x19EDE60 Offset: 0x19E9E60 VA: 0x19EDE60 Slot: 11
	protected override void OnValueWrong(short returnCode) { }
}
