// Assembly: Assembly-CSharp.dll
// Namespace: 
private class MobaTreasureDropActionManager.MobaItemPickup : MobaItemPickupExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 912
{
	// Fields
	private byte equipNo; // 0x18
	private MobaTreasureDropActionManager manager; // 0x20

	// Methods

	// RVA: 0x1F03590 Offset: 0x1EFF590 VA: 0x1F03590
	public void .ctor(byte equipNo, int itemUniqueId, MobaTreasureDropActionManager manager) { }

	// RVA: 0x1F0367C Offset: 0x1EFF67C VA: 0x1F0367C Slot: 12
	protected override void OnDead(MobaItemPickupResponse response) { }

	// RVA: 0x1F03680 Offset: 0x1EFF680 VA: 0x1F03680 Slot: 13
	protected override void OnDropNotFound(MobaItemPickupResponse response) { }

	// RVA: 0x1F03704 Offset: 0x1EFF704 VA: 0x1F03704 Slot: 11
	protected override void OnFailure(short returnCode, MobaItemPickupResponse response) { }

	// RVA: 0x1F03708 Offset: 0x1EFF708 VA: 0x1F03708 Slot: 14
	protected override void OnRangeOutSideScope(MobaItemPickupResponse response) { }

	// RVA: 0x1F0370C Offset: 0x1EFF70C VA: 0x1F0370C Slot: 15
	protected override void OnWrongTarget(MobaItemPickupResponse response) { }

	// RVA: 0x1F03710 Offset: 0x1EFF710 VA: 0x1F03710 Slot: 10
	protected override void OnSuccess(MobaItemPickupResponse response) { }
}
