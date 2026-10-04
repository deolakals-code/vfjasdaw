// Assembly: Assembly-CSharp.dll
// Namespace: 
private class MobaDataManager.MobaGetProfile : MobaGetProfileExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 1391
{
	// Fields
	private MobaDataManager manager; // 0x20

	// Methods

	// RVA: 0x1FE8C7C Offset: 0x1FE4C7C VA: 0x1FE8C7C
	public void .ctor(MobaDataManager manager) { }

	// RVA: 0x1FE9528 Offset: 0x1FE5528 VA: 0x1FE9528 Slot: 8
	public override void Reconnection(Game engine) { }

	// RVA: 0x1FE9534 Offset: 0x1FE5534 VA: 0x1FE9534 Slot: 12
	protected override void OnConditionsAreNotMet() { }

	// RVA: 0x1FE9538 Offset: 0x1FE5538 VA: 0x1FE9538 Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1FE9624 Offset: 0x1FE5624 VA: 0x1FE9624 Slot: 10
	protected override void OnSuccess(MobaGetProfileResponse response) { }

	// RVA: 0x1FE96FC Offset: 0x1FE56FC VA: 0x1FE96FC Slot: 13
	protected override void OnVersionDifference() { }
}
