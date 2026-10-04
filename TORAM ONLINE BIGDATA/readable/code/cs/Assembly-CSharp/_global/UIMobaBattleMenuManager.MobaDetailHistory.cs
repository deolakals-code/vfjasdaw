// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIMobaBattleMenuManager.MobaDetailHistory : MobaDetailHistoryExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 6031
{
	// Fields
	private UIMobaBattleMenuManager manager; // 0x18
	private int gameUniqueId; // 0x20

	// Methods

	// RVA: 0x1873B4C Offset: 0x186FB4C VA: 0x1873B4C
	public void .ctor(UIMobaBattleMenuManager manager, int gameUniqueId) { }

	// RVA: 0x1873B8C Offset: 0x186FB8C VA: 0x1873B8C Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1873C58 Offset: 0x186FC58 VA: 0x1873C58 Slot: 10
	protected override void OnSuccess(MobaDetailHistoryResponse response) { }

	// RVA: 0x1873B94 Offset: 0x186FB94 VA: 0x1873B94
	private void UpdateDetailList(MobaGameResultData data) { }
}
