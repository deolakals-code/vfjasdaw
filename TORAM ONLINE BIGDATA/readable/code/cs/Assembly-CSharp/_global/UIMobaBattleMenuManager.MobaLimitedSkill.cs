// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIMobaBattleMenuManager.MobaLimitedSkill : MobaLimitedSkillExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 6032
{
	// Fields
	private UIMobaBattleMenuManager manager; // 0x10

	// Methods

	// RVA: 0x1873C84 Offset: 0x186FC84 VA: 0x1873C84
	public void .ctor(UIMobaBattleMenuManager manager) { }

	// RVA: 0x1873CB4 Offset: 0x186FCB4 VA: 0x1873CB4 Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1873CD4 Offset: 0x186FCD4 VA: 0x1873CD4 Slot: 10
	protected override void OnSuccess(MobaLimitedSkillResponse response) { }

	// RVA: 0x1873EA4 Offset: 0x186FEA4 VA: 0x1873EA4
	private bool CheckMasterData(int skillId) { }
}
