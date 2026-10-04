// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIGuildAlliance.GuildAllianceInvite : GuildAllianceInviteExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 8072
{
	// Fields
	private UIGuildAlliance panel; // 0x18

	// Methods

	// RVA: 0x1CBB20C Offset: 0x1CB720C VA: 0x1CBB20C
	public void .ctor(UIGuildAlliance panel, int targetArchetypeId) { }

	// RVA: 0x1CBB58C Offset: 0x1CB758C VA: 0x1CBB58C Slot: 28
	protected override void OnInvitationAlreadyExists() { }

	// RVA: 0x1CBB59C Offset: 0x1CB759C VA: 0x1CBB59C Slot: 10
	protected override void OnSuccess(GuildAllianceInviteResponse response) { }

	// RVA: 0x1CBB5AC Offset: 0x1CB75AC VA: 0x1CBB5AC Slot: 23
	protected override void OnAllianceAlreadyExists() { }

	// RVA: 0x1CBB6C4 Offset: 0x1CB76C4 VA: 0x1CBB6C4 Slot: 24
	protected override void OnCoolDown() { }

	// RVA: 0x1CBB720 Offset: 0x1CB7720 VA: 0x1CBB720 Slot: 13
	protected override void OnNoAuthority() { }

	// RVA: 0x1CBB77C Offset: 0x1CB777C VA: 0x1CBB77C Slot: 21
	protected override void OnNotAllowed() { }

	// RVA: 0x1CBB7D8 Offset: 0x1CB77D8 VA: 0x1CBB7D8 Slot: 26
	protected override void OnTargetAllianceAlreadyExists() { }

	// RVA: 0x1CBB834 Offset: 0x1CB7834 VA: 0x1CBB834 Slot: 27
	protected override void OnTargetCoolDown() { }

	// RVA: 0x1CBB890 Offset: 0x1CB7890 VA: 0x1CBB890 Slot: 30
	protected override void OnInvitationLimit() { }

	// RVA: 0x1CBB8EC Offset: 0x1CB78EC VA: 0x1CBB8EC Slot: 22
	protected override void OnTargetNotAllowed() { }

	// RVA: 0x1CBB948 Offset: 0x1CB7948 VA: 0x1CBB948 Slot: 18
	protected override void OnTargetUserNoAuthority() { }

	// RVA: 0x1CBB9A4 Offset: 0x1CB79A4 VA: 0x1CBB9A4 Slot: 29
	protected override void OnAllianceNotFound() { }

	// RVA: 0x1CBBA00 Offset: 0x1CB7A00 VA: 0x1CBBA00 Slot: 31
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1CBBA60 Offset: 0x1CB7A60 VA: 0x1CBBA60 Slot: 20
	protected override void OnGuildDisposed() { }

	// RVA: 0x1CBBABC Offset: 0x1CB7ABC VA: 0x1CBBABC Slot: 15
	protected override void OnGuildNotAccess() { }

	// RVA: 0x1CBBB18 Offset: 0x1CB7B18 VA: 0x1CBBB18 Slot: 12
	protected override void OnGuildNotJoined() { }

	// RVA: 0x1CBBB74 Offset: 0x1CB7B74 VA: 0x1CBBB74 Slot: 25
	protected override void OnGuildNotFound() { }

	// RVA: 0x1CBBBD0 Offset: 0x1CB7BD0 VA: 0x1CBBBD0 Slot: 11
	protected override void OnServerDisconnect() { }

	// RVA: 0x1CBBC2C Offset: 0x1CB7C2C VA: 0x1CBBC2C Slot: 17
	protected override void OnTargetUserDisposed() { }

	// RVA: 0x1CBBC88 Offset: 0x1CB7C88 VA: 0x1CBBC88 Slot: 16
	protected override void OnTargetUserNotFound() { }

	// RVA: 0x1CBBCE4 Offset: 0x1CB7CE4 VA: 0x1CBBCE4 Slot: 14
	protected override void OnUserDisposed() { }

	// RVA: 0x1CBBD40 Offset: 0x1CB7D40 VA: 0x1CBBD40 Slot: 19
	protected override void OnWrongTarget() { }
}
