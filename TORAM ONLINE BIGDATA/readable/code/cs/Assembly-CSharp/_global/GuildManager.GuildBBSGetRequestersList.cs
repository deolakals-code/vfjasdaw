// Assembly: Assembly-CSharp.dll
// Namespace: 
private class GuildManager.GuildBBSGetRequestersList : GuildBBSGetRequestersListExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 1912
{
	// Fields
	private GuildManager manager; // 0x10

	// Methods

	// RVA: 0x20FE9E0 Offset: 0x20FA9E0 VA: 0x20FE9E0
	public void .ctor(GuildManager manager) { }

	// RVA: 0x21074FC Offset: 0x21034FC VA: 0x21074FC Slot: 17
	protected override void OnDataNull() { }

	// RVA: 0x2107500 Offset: 0x2103500 VA: 0x2107500 Slot: 12
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x2107504 Offset: 0x2103504 VA: 0x2107504 Slot: 14
	protected override void OnGuildNotJoined() { }

	// RVA: 0x2107508 Offset: 0x2103508 VA: 0x2107508 Slot: 16
	protected override void OnMemberNotAllowed() { }

	// RVA: 0x210750C Offset: 0x210350C VA: 0x210750C Slot: 15
	protected override void OnNotImplement() { }

	// RVA: 0x2107510 Offset: 0x2103510 VA: 0x2107510 Slot: 13
	protected override void OnSqlError() { }

	// RVA: 0x2107514 Offset: 0x2103514 VA: 0x2107514 Slot: 10
	protected override void OnSuccess(GuildBBSGetRequestersListResponse response) { }

	// RVA: 0x2107534 Offset: 0x2103534 VA: 0x2107534 Slot: 11
	protected override void OnSystemLock() { }
}
