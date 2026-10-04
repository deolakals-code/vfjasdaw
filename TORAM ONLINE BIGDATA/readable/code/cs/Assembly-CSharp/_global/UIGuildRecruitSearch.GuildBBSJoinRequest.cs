// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIGuildRecruitSearch.GuildBBSJoinRequest : GuildBBSJoinRequestExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 7169
{
	// Fields
	private UIGuildRecruitSearch recruitSearch; // 0x18
	private string guildName; // 0x20
	private string guildMasterName; // 0x28

	// Methods

	// RVA: 0x1AB3DE8 Offset: 0x1AAFDE8 VA: 0x1AB3DE8
	public void .ctor(UIGuildRecruitSearch recruitSearch, int guildId, string guildName, string guildMasterName) { }

	// RVA: 0x1AB3E4C Offset: 0x1AAFE4C VA: 0x1AB3E4C Slot: 17
	protected override void OnAlreadyReserved() { }

	// RVA: 0x1AB3EA4 Offset: 0x1AAFEA4 VA: 0x1AB3EA4 Slot: 20
	protected override void OnConditionsAreNotMet() { }

	// RVA: 0x1AB3F3C Offset: 0x1AAFF3C VA: 0x1AB3F3C Slot: 18
	protected override void OnDataNull() { }

	// RVA: 0x1AB3FD4 Offset: 0x1AAFFD4 VA: 0x1AB3FD4 Slot: 19
	protected override void OnEquipTypeErr() { }

	// RVA: 0x1AB406C Offset: 0x1AB006C VA: 0x1AB406C Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1AB4128 Offset: 0x1AB0128 VA: 0x1AB4128 Slot: 14
	protected override void OnGuildAlreadyExists() { }

	// RVA: 0x1AB4180 Offset: 0x1AB0180 VA: 0x1AB4180 Slot: 16
	protected override void OnGuildNotFound() { }

	// RVA: 0x1AB4218 Offset: 0x1AB0218 VA: 0x1AB4218 Slot: 21
	protected override void OnMemberInvited() { }

	// RVA: 0x1AB4270 Offset: 0x1AB0270 VA: 0x1AB4270 Slot: 15
	protected override void OnNotImplement() { }

	// RVA: 0x1AB4288 Offset: 0x1AB0288 VA: 0x1AB4288 Slot: 13
	protected override void OnSqlError() { }

	// RVA: 0x1AB42E0 Offset: 0x1AB02E0 VA: 0x1AB42E0 Slot: 10
	protected override void OnSuccess(GuildBBSJoinRequestResponse response) { }

	// RVA: 0x1AB4300 Offset: 0x1AB0300 VA: 0x1AB4300 Slot: 12
	protected override void OnSystemLock() { }

	// RVA: 0x1AB4358 Offset: 0x1AB0358 VA: 0x1AB4358 Slot: 22
	protected override void OnWaitingOver() { }
}
