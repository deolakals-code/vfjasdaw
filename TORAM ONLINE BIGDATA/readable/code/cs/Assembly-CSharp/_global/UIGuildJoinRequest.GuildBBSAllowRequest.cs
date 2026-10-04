// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIGuildJoinRequest.GuildBBSAllowRequest : GuildBBSAllowRequestExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 7112
{
	// Fields
	private UIGuildJoinRequest joinRequest; // 0x18

	// Methods

	// RVA: 0x1A99ED4 Offset: 0x1A95ED4 VA: 0x1A99ED4
	public void .ctor(UIGuildJoinRequest joinRequest, int id) { }

	// RVA: 0x1A9A664 Offset: 0x1A96664 VA: 0x1A9A664 Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1A9A71C Offset: 0x1A9671C VA: 0x1A9A71C Slot: 21
	protected override void OnGuildAlreadyExists() { }

	// RVA: 0x1A9A73C Offset: 0x1A9673C VA: 0x1A9A73C Slot: 17
	protected override void OnGuildNotAccess() { }

	// RVA: 0x1A9A790 Offset: 0x1A96790 VA: 0x1A9A790 Slot: 14
	protected override void OnGuildNotJoined() { }

	// RVA: 0x1A9A7F4 Offset: 0x1A967F4 VA: 0x1A9A7F4 Slot: 20
	protected override void OnMemberInvited() { }

	// RVA: 0x1A9A848 Offset: 0x1A96848 VA: 0x1A9A848 Slot: 19
	protected override void OnMemberNotAllowed() { }

	// RVA: 0x1A9A8AC Offset: 0x1A968AC VA: 0x1A9A8AC Slot: 18
	protected override void OnMemberNotFound() { }

	// RVA: 0x1A9A910 Offset: 0x1A96910 VA: 0x1A9A910 Slot: 15
	protected override void OnNotImplement() { }

	// RVA: 0x1A9A964 Offset: 0x1A96964 VA: 0x1A9A964 Slot: 22
	protected override void OnNoVacancies() { }

	// RVA: 0x1A9A9B8 Offset: 0x1A969B8 VA: 0x1A9A9B8 Slot: 24
	protected override void OnReserveNotFound() { }

	// RVA: 0x1A9AA1C Offset: 0x1A96A1C VA: 0x1A9AA1C Slot: 13
	protected override void OnSqlError() { }

	// RVA: 0x1A9AA70 Offset: 0x1A96A70 VA: 0x1A9AA70 Slot: 10
	protected override void OnSuccess(GuildBBSAllowRequestResponse response) { }

	// RVA: 0x1A9AA90 Offset: 0x1A96A90 VA: 0x1A9AA90 Slot: 12
	protected override void OnSystemLock() { }

	// RVA: 0x1A9AAE4 Offset: 0x1A96AE4 VA: 0x1A9AAE4 Slot: 16
	protected override void OnUserDisposed() { }

	// RVA: 0x1A9AB48 Offset: 0x1A96B48 VA: 0x1A9AB48 Slot: 23
	protected override void OnUserNotFound() { }
}
