// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIGuildJoinRequest.GuildBBSRejectRequest : GuildBBSRejectRequestExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 7111
{
	// Fields
	private UIGuildJoinRequest joinRequest; // 0x18

	// Methods

	// RVA: 0x1A9A060 Offset: 0x1A96060 VA: 0x1A9A060
	public void .ctor(UIGuildJoinRequest joinRequest, int id) { }

	// RVA: 0x1A9A430 Offset: 0x1A96430 VA: 0x1A9A430 Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1A9A4E8 Offset: 0x1A964E8 VA: 0x1A9A4E8 Slot: 14
	protected override void OnGuildNotJoined() { }

	// RVA: 0x1A9A508 Offset: 0x1A96508 VA: 0x1A9A508 Slot: 16
	protected override void OnMemberNotAllowed() { }

	// RVA: 0x1A9A528 Offset: 0x1A96528 VA: 0x1A9A528 Slot: 17
	protected override void OnNotFound() { }

	// RVA: 0x1A9A548 Offset: 0x1A96548 VA: 0x1A9A548 Slot: 15
	protected override void OnNotImplement() { }

	// RVA: 0x1A9A59C Offset: 0x1A9659C VA: 0x1A9A59C Slot: 13
	protected override void OnSqlError() { }

	// RVA: 0x1A9A5F0 Offset: 0x1A965F0 VA: 0x1A9A5F0 Slot: 10
	protected override void OnSuccess(GuildBBSRejectRequestResponse response) { }

	// RVA: 0x1A9A610 Offset: 0x1A96610 VA: 0x1A9A610 Slot: 12
	protected override void OnSystemLock() { }
}
