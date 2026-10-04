// Assembly: Assembly-CSharp.dll
// Namespace: 
private class QuestManager.MissionSkip : MissionSkipExplain, IReconnectionData, IReconnectionReceiveResponse // TypeDefIndex: 2207
{
	// Fields
	private QuestManager manager; // 0x18

	// Methods

	// RVA: 0x2171CEC Offset: 0x216DCEC VA: 0x2171CEC
	public void .ctor(QuestManager manager, int avatarUuid, int missionId) { }

	// RVA: 0x2172138 Offset: 0x216E138 VA: 0x2172138 Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x217213C Offset: 0x216E13C VA: 0x217213C Slot: 10
	protected override void OnSuccess(MissionSkipResponse response) { }
}
