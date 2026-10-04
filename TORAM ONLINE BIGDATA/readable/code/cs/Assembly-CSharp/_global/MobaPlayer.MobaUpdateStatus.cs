// Assembly: Assembly-CSharp.dll
// Namespace: 
private class MobaPlayer.MobaUpdateStatus : MobaUpdateStatusExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 1163
{
	// Fields
	private MobaPlayer mobaPlayer; // 0x18

	// Methods

	// RVA: 0x1F77AD8 Offset: 0x1F73AD8 VA: 0x1F77AD8
	public void .ctor(MobaPlayer mobaPlayer, PrimaryStatusData statusData) { }

	// RVA: 0x1F78294 Offset: 0x1F74294 VA: 0x1F78294 Slot: 14
	protected override void OnFailure(short returnCode, MobaUpdateStatusResponse response) { }

	// RVA: 0x1F78298 Offset: 0x1F74298 VA: 0x1F78298 Slot: 11
	protected override void OnNotStart(MobaUpdateStatusResponse response) { }

	// RVA: 0x1F7829C Offset: 0x1F7429C VA: 0x1F7829C Slot: 12
	protected override void OnProblemTime(MobaUpdateStatusResponse response) { }

	// RVA: 0x1F782A0 Offset: 0x1F742A0 VA: 0x1F782A0 Slot: 13
	protected override void OnStatusValueWrong(short returnCode) { }

	// RVA: 0x1F782A4 Offset: 0x1F742A4 VA: 0x1F782A4 Slot: 10
	protected override void OnSuccess(MobaUpdateStatusResponse response) { }
}
