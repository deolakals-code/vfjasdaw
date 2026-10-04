// Assembly: Assembly-CSharp.dll
// Namespace: 
private class MobaChestActionManager.MobaChestOpen : MobaChestOpenExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 905
{
	// Fields
	private MobaChestActionManager mob; // 0x18

	// Methods

	// RVA: 0x1F00968 Offset: 0x1EFC968 VA: 0x1F00968
	public void .ctor(MobaChestActionManager mob) { }

	// RVA: 0x1F00CF0 Offset: 0x1EFCCF0 VA: 0x1F00CF0 Slot: 14
	protected override void OnAlreadyOpened(MobaChestOpenResponse response) { }

	// RVA: 0x1F00DBC Offset: 0x1EFCDBC VA: 0x1F00DBC Slot: 12
	protected override void OnDead(MobaChestOpenResponse response) { }

	// RVA: 0x1F00DE8 Offset: 0x1EFCDE8 VA: 0x1F00DE8 Slot: 11
	protected override void OnFailure(short returnCode, MobaChestOpenResponse response) { }

	// RVA: 0x1F00DEC Offset: 0x1EFCDEC VA: 0x1F00DEC Slot: 13
	protected override void OnNotFound(MobaChestOpenResponse response) { }

	// RVA: 0x1F00E80 Offset: 0x1EFCE80 VA: 0x1F00E80 Slot: 16
	protected override void OnNotTryingOpen(MobaChestOpenResponse response) { }

	// RVA: 0x1F00EBC Offset: 0x1EFCEBC VA: 0x1F00EBC Slot: 15
	protected override void OnRangeOutSideScope(MobaChestOpenResponse response) { }

	// RVA: 0x1F00EF8 Offset: 0x1EFCEF8 VA: 0x1F00EF8 Slot: 17
	protected override void OnTimeIsNotOver(MobaChestOpenResponse response) { }

	// RVA: 0x1F00F40 Offset: 0x1EFCF40 VA: 0x1F00F40 Slot: 10
	protected override void OnSuccess(MobaChestOpenResponse response) { }

	// RVA: 0x1F00D1C Offset: 0x1EFCD1C VA: 0x1F00D1C
	private bool CheckItem(MobaChestOpenResponse response) { }
}
