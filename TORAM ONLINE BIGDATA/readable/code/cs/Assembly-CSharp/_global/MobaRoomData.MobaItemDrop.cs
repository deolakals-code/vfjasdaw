// Assembly: Assembly-CSharp.dll
// Namespace: 
private class MobaRoomData.MobaItemDrop : MobaItemDropExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 2404
{
	// Methods

	// RVA: 0x21A9E60 Offset: 0x21A5E60 VA: 0x21A9E60
	public void .ctor(byte equipNo, short itemId) { }

	// RVA: 0x21A9E68 Offset: 0x21A5E68 VA: 0x21A9E68 Slot: 12
	protected override void OnDead(MobaItemDropResponse response) { }

	// RVA: 0x21A9E6C Offset: 0x21A5E6C VA: 0x21A9E6C Slot: 11
	protected override void OnFailure(short returnCode, MobaItemDropResponse response) { }

	// RVA: 0x21A9E70 Offset: 0x21A5E70 VA: 0x21A9E70 Slot: 13
	protected override void OnWrongTarget(MobaItemDropResponse response) { }

	// RVA: 0x21A9E74 Offset: 0x21A5E74 VA: 0x21A9E74 Slot: 10
	protected override void OnSuccess(MobaItemDropResponse response) { }
}
