// Assembly: Assembly-CSharp.dll
// Namespace: 
private class MobaDataManager.MobaStatus : MobaStatusExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 1397
{
	// Fields
	private MobaDataManager manager; // 0x10

	// Methods

	// RVA: 0x1FEA388 Offset: 0x1FE6388 VA: 0x1FEA388
	public void .ctor(MobaDataManager manager) { }

	// RVA: 0x1FEA3B8 Offset: 0x1FE63B8 VA: 0x1FEA3B8 Slot: 14
	protected override void OnCancelRequested(short returnCode, MobaStatusResponse response) { }

	// RVA: 0x1FEA3BC Offset: 0x1FE63BC VA: 0x1FEA3BC Slot: 12
	protected override void OnConditionsAreNotMet() { }

	// RVA: 0x1FEA3C0 Offset: 0x1FE63C0 VA: 0x1FEA3C0 Slot: 11
	protected override void OnFailure(short returnCode, MobaStatusResponse response) { }

	// RVA: 0x1FEA3C4 Offset: 0x1FE63C4 VA: 0x1FEA3C4 Slot: 13
	protected override void OnProfileNotRegistered() { }

	// RVA: 0x1FEA3C8 Offset: 0x1FE63C8 VA: 0x1FEA3C8 Slot: 10
	protected override void OnSuccess(MobaStatusResponse response) { }
}
