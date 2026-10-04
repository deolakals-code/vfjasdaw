// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIBCollaborationRankingManager.BCollaborationGetRanking : BCollaborationGetRankingExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 5626
{
	// Fields
	private UIBCollaborationRankingManager manager; // 0x18

	// Methods

	// RVA: 0x17AF204 Offset: 0x17AB204 VA: 0x17AF204
	public void .ctor(UIBCollaborationRankingManager manager, BCRankingItemType mainWeapon, BCRankingItemType subWeapon) { }

	// RVA: 0x17AF81C Offset: 0x17AB81C VA: 0x17AF81C Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x17AF820 Offset: 0x17AB820 VA: 0x17AF820 Slot: 10
	protected override void OnSuccess(BCollaborationGetRankingResponse response) { }

	// RVA: 0x17AF844 Offset: 0x17AB844 VA: 0x17AF844 Slot: 12
	protected override void OnSystemLock() { }
}
