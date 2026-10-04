// Assembly: Assembly-CSharp.dll
// Namespace: 
private class MobaChestActionManager.MobaChestCancel : MobaChestCancelExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 906
{
	// Fields
	private MobaChestActionManager mob; // 0x18

	// Methods

	// RVA: 0x1F009B8 Offset: 0x1EFC9B8 VA: 0x1F009B8
	public void .ctor(MobaChestActionManager mob) { }

	// RVA: 0x1F01204 Offset: 0x1EFD204 VA: 0x1F01204 Slot: 11
	protected override void OnFailure(short returnCode, MobaChestCancelResponse response) { }

	// RVA: 0x1F01208 Offset: 0x1EFD208 VA: 0x1F01208 Slot: 12
	protected override void OnNotFound(MobaChestCancelResponse response) { }

	// RVA: 0x1F0133C Offset: 0x1EFD33C VA: 0x1F0133C Slot: 10
	protected override void OnSuccess(MobaChestCancelResponse response) { }

	// RVA: 0x1F0129C Offset: 0x1EFD29C VA: 0x1F0129C
	private bool CheckItem(MobaChestCancelResponse response) { }
}
