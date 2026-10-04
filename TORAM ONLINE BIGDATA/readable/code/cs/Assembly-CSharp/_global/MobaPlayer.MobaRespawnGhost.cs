// Assembly: Assembly-CSharp.dll
// Namespace: 
private class MobaPlayer.MobaRespawnGhost : MobaRespawnGhostExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 1164
{
	// Fields
	private MobaPlayer mobaPlayer; // 0x10

	// Methods

	// RVA: 0x1F77E5C Offset: 0x1F73E5C VA: 0x1F77E5C
	public void .ctor(MobaPlayer mobaPlayer) { }

	// RVA: 0x1F78364 Offset: 0x1F74364 VA: 0x1F78364 Slot: 12
	protected override void OnAlreadyExistsGhost(MobaRespawnGhostResponse response) { }

	// RVA: 0x1F783E4 Offset: 0x1F743E4 VA: 0x1F783E4 Slot: 11
	protected override void OnAvatarNotDeath(MobaRespawnGhostResponse response) { }

	// RVA: 0x1F78478 Offset: 0x1F74478 VA: 0x1F78478 Slot: 13
	protected override void OnFailure(short returnCode, MobaRespawnGhostResponse response) { }

	// RVA: 0x1F7847C Offset: 0x1F7447C VA: 0x1F7847C Slot: 10
	protected override void OnSuccess(MobaRespawnGhostResponse response) { }
}
