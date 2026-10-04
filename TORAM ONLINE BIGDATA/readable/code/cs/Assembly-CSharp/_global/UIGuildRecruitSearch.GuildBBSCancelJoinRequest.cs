// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIGuildRecruitSearch.GuildBBSCancelJoinRequest : GuildBBSCancelJoinRequestExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 7171
{
	// Fields
	private UIGuildRecruitSearch recruitSearch; // 0x10

	// Methods

	// RVA: 0x1AB3830 Offset: 0x1AAF830 VA: 0x1AB3830
	public void .ctor(UIGuildRecruitSearch recruitSearch) { }

	// RVA: 0x1AB4C00 Offset: 0x1AB0C00 VA: 0x1AB4C00 Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1AB4CBC Offset: 0x1AB0CBC VA: 0x1AB4CBC Slot: 14
	protected override void OnGuildAlreadyExists() { }

	// RVA: 0x1AB4D14 Offset: 0x1AB0D14 VA: 0x1AB4D14 Slot: 16
	protected override void OnNotImplement() { }

	// RVA: 0x1AB4D2C Offset: 0x1AB0D2C VA: 0x1AB4D2C Slot: 15
	protected override void OnReserveNotFound() { }

	// RVA: 0x1AB4D48 Offset: 0x1AB0D48 VA: 0x1AB4D48 Slot: 13
	protected override void OnSqlError() { }

	// RVA: 0x1AB4DA0 Offset: 0x1AB0DA0 VA: 0x1AB4DA0 Slot: 10
	protected override void OnSuccess(GuildBBSCancelJoinRequestResponse response) { }

	// RVA: 0x1AB4DBC Offset: 0x1AB0DBC VA: 0x1AB4DBC Slot: 12
	protected override void OnSystemLock() { }
}
