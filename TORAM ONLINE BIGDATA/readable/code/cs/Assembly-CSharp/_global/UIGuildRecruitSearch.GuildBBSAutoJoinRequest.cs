// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIGuildRecruitSearch.GuildBBSAutoJoinRequest : GuildBBSAutoJoinRequestExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 7170
{
	// Fields
	private UIGuildRecruitSearch recruitSearch; // 0x18

	// Methods

	// RVA: 0x1AB43F0 Offset: 0x1AB03F0 VA: 0x1AB43F0
	public void .ctor(UIGuildRecruitSearch recruitSearch, int guildId) { }

	// RVA: 0x1AB4424 Offset: 0x1AB0424 VA: 0x1AB4424 Slot: 19
	protected override void OnConditionsAreNotMet() { }

	// RVA: 0x1AB44BC Offset: 0x1AB04BC VA: 0x1AB44BC Slot: 17
	protected override void OnDataNull() { }

	// RVA: 0x1AB4554 Offset: 0x1AB0554 VA: 0x1AB4554 Slot: 18
	protected override void OnEquipTypeErr() { }

	// RVA: 0x1AB45EC Offset: 0x1AB05EC VA: 0x1AB45EC Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1AB46A8 Offset: 0x1AB06A8 VA: 0x1AB46A8 Slot: 14
	protected override void OnGuildAlreadyExists() { }

	// RVA: 0x1AB4700 Offset: 0x1AB0700 VA: 0x1AB4700 Slot: 20
	protected override void OnGuildDisposed() { }

	// RVA: 0x1AB4798 Offset: 0x1AB0798 VA: 0x1AB4798 Slot: 16
	protected override void OnGuildNotFound() { }

	// RVA: 0x1AB4830 Offset: 0x1AB0830 VA: 0x1AB4830 Slot: 22
	protected override void OnMemberInvited() { }

	// RVA: 0x1AB4888 Offset: 0x1AB0888 VA: 0x1AB4888 Slot: 15
	protected override void OnNotImplement() { }

	// RVA: 0x1AB48A0 Offset: 0x1AB08A0 VA: 0x1AB48A0 Slot: 23
	protected override void OnNoVacancies() { }

	// RVA: 0x1AB48F8 Offset: 0x1AB08F8 VA: 0x1AB48F8 Slot: 13
	protected override void OnSqlError() { }

	// RVA: 0x1AB4950 Offset: 0x1AB0950 VA: 0x1AB4950 Slot: 10
	protected override void OnSuccess(GuildBBSAutoJoinRequestResponse response) { }

	// RVA: 0x1AB4B10 Offset: 0x1AB0B10 VA: 0x1AB4B10 Slot: 12
	protected override void OnSystemLock() { }

	// RVA: 0x1AB4B68 Offset: 0x1AB0B68 VA: 0x1AB4B68 Slot: 21
	protected override void OnUserDisposed() { }
}
