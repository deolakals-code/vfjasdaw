// Assembly: Assembly-CSharp.dll
// Namespace: 
private class MobaChestActionManager.MobaChestStart : MobaChestStartExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 904
{
	// Fields
	private MobaChestActionManager mob; // 0x18

	// Methods

	// RVA: 0x1F00918 Offset: 0x1EFC918 VA: 0x1F00918
	public void .ctor(MobaChestActionManager mob) { }

	// RVA: 0x1F00ACC Offset: 0x1EFCACC VA: 0x1F00ACC Slot: 14
	protected override void OnAlreadyOpened(MobaChestStartResponse response) { }

	// RVA: 0x1F00B98 Offset: 0x1EFCB98 VA: 0x1F00B98 Slot: 12
	protected override void OnDead(MobaChestStartResponse response) { }

	// RVA: 0x1F00BD4 Offset: 0x1EFCBD4 VA: 0x1F00BD4 Slot: 11
	protected override void OnFailure(short returnCode, MobaChestStartResponse response) { }

	// RVA: 0x1F00BD8 Offset: 0x1EFCBD8 VA: 0x1F00BD8 Slot: 13
	protected override void OnNotFound(MobaChestStartResponse response) { }

	// RVA: 0x1F00C6C Offset: 0x1EFCC6C VA: 0x1F00C6C Slot: 15
	protected override void OnRangeOutSideScope(MobaChestStartResponse response) { }

	// RVA: 0x1F00CA8 Offset: 0x1EFCCA8 VA: 0x1F00CA8 Slot: 10
	protected override void OnSuccess(MobaChestStartResponse response) { }

	// RVA: 0x1F00AF8 Offset: 0x1EFCAF8 VA: 0x1F00AF8
	private bool CheckItem(MobaChestStartResponse response) { }
}
