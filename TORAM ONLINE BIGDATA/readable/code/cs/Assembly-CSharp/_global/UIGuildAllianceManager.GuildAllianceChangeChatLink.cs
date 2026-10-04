// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIGuildAllianceManager.GuildAllianceChangeChatLink : GuildAllianceChangeChatLinkExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 6617
{
	// Fields
	private UIGuildAllianceManager manager; // 0x18
	private bool isChatLink; // 0x20
	private bool isClose; // 0x21

	// Methods

	// RVA: 0x199D644 Offset: 0x1999644 VA: 0x199D644
	public void .ctor(UIGuildAllianceManager manager, bool isChatLink, bool isClose = False) { }

	// RVA: 0x199DEA0 Offset: 0x1999EA0 VA: 0x199DEA0 Slot: 17
	protected override void OnAllianceNotFound() { }

	// RVA: 0x199DEB4 Offset: 0x1999EB4 VA: 0x199DEB4 Slot: 16
	protected override void OnGuildDisposed() { }

	// RVA: 0x199DEC8 Offset: 0x1999EC8 VA: 0x199DEC8 Slot: 15
	protected override void OnGuildNotAccess() { }

	// RVA: 0x199DEDC Offset: 0x1999EDC VA: 0x199DEDC Slot: 12
	protected override void OnGuildNotJoined() { }

	// RVA: 0x199DEF0 Offset: 0x1999EF0 VA: 0x199DEF0 Slot: 11
	protected override void OnServerDisconnect() { }

	// RVA: 0x199DF04 Offset: 0x1999F04 VA: 0x199DF04 Slot: 14
	protected override void OnUserDisposed() { }

	// RVA: 0x199DF18 Offset: 0x1999F18 VA: 0x199DF18 Slot: 19
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x199DF78 Offset: 0x1999F78 VA: 0x199DF78 Slot: 13
	protected override void OnNoAuthority() { }

	// RVA: 0x199DFD8 Offset: 0x1999FD8 VA: 0x199DFD8 Slot: 10
	protected override void OnSuccess(GuildAllianceChangeChatLinkResponse response) { }

	// RVA: 0x199E140 Offset: 0x199A140 VA: 0x199E140 Slot: 18
	protected override void OnNoChange() { }
}
