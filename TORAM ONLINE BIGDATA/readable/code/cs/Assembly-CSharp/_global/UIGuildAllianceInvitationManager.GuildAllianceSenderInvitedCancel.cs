// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIGuildAllianceInvitationManager.GuildAllianceSenderInvitedCancel : GuildAllianceSenderInvitedCancelExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 6611
{
	// Fields
	private UIGuildAllianceInvitationManager manager; // 0x10
	private int cashAllianceId; // 0x18

	// Methods

	// RVA: 0x199C7B4 Offset: 0x19987B4 VA: 0x199C7B4
	public void .ctor(UIGuildAllianceInvitationManager manager, int allianceId) { }

	// RVA: 0x199C7F0 Offset: 0x19987F0 VA: 0x199C7F0 Slot: 16
	protected override void OnAllianceNotFound() { }

	// RVA: 0x199C7FC Offset: 0x19987FC VA: 0x199C7FC Slot: 17
	protected override void OnAllianceDisposed() { }

	// RVA: 0x199C808 Offset: 0x1998808 VA: 0x199C808 Slot: 10
	protected override void OnSuccess() { }

	// RVA: 0x199C864 Offset: 0x1998864 VA: 0x199C864 Slot: 13
	protected override void OnNoAuthority() { }

	// RVA: 0x199C8DC Offset: 0x19988DC VA: 0x199C8DC Slot: 18
	protected override void OnAllianceAlreadyExists() { }

	// RVA: 0x199C96C Offset: 0x199896C VA: 0x199C96C Slot: 19
	protected override void OnAllianceInstanceNotMatch() { }

	// RVA: 0x199C980 Offset: 0x1998980 VA: 0x199C980 Slot: 15
	protected override void OnGuildNotAccess() { }

	// RVA: 0x199C994 Offset: 0x1998994 VA: 0x199C994 Slot: 12
	protected override void OnGuildNotJoined() { }

	// RVA: 0x199C9A8 Offset: 0x19989A8 VA: 0x199C9A8 Slot: 11
	protected override void OnServerDisconnect() { }

	// RVA: 0x199C9BC Offset: 0x19989BC VA: 0x199C9BC Slot: 14
	protected override void OnUserDisposed() { }

	// RVA: 0x199C9D0 Offset: 0x19989D0 VA: 0x199C9D0 Slot: 20
	protected override void OnFailure(short returnCode) { }
}
