// Assembly: Assembly-CSharp.dll
// Namespace: 
private class MobaPlayer.MobaRespawn : MobaRespawnExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 1165
{
	// Fields
	private MobaPlayer mobaPlayer; // 0x10

	// Methods

	// RVA: 0x1F77FD4 Offset: 0x1F73FD4 VA: 0x1F77FD4
	public void .ctor(MobaPlayer mobaPlayer) { }

	// RVA: 0x1F78570 Offset: 0x1F74570 VA: 0x1F78570 Slot: 11
	protected override void OnAvatarNotDeath(MobaRespawnResponse response) { }

	// RVA: 0x1F78604 Offset: 0x1F74604 VA: 0x1F78604 Slot: 13
	protected override void OnNotGhostState(MobaRespawnResponse response) { }

	// RVA: 0x1F7861C Offset: 0x1F7461C VA: 0x1F7861C Slot: 14
	protected override void OnCompletedAlready(MobaRespawnResponse response) { }

	// RVA: 0x1F786C0 Offset: 0x1F746C0 VA: 0x1F786C0 Slot: 15
	protected override void OnFailure(short returnCode, MobaRespawnResponse response) { }

	// RVA: 0x1F786F8 Offset: 0x1F746F8 VA: 0x1F786F8 Slot: 10
	protected override void OnSuccess(MobaRespawnResponse response) { }

	// RVA: 0x1F78794 Offset: 0x1F74794 VA: 0x1F78794 Slot: 12
	protected override void OnTimeIsNotOver(MobaRespawnResponse response) { }
}
