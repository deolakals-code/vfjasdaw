// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIGuildAllianceInvitationManager.GuildAllianceConsent : GuildAllianceConsentExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 6613
{
	// Fields
	private UIGuildAllianceInvitationManager manager; // 0x18
	private int cashAllianceId; // 0x20

	// Methods

	// RVA: 0x199CC5C Offset: 0x1998C5C VA: 0x199CC5C
	public void .ctor(UIGuildAllianceInvitationManager manager, int allianceId) { }

	// RVA: 0x199CC9C Offset: 0x1998C9C VA: 0x199CC9C Slot: 18
	protected override void OnAllianceAlreadyExists() { }

	// RVA: 0x199CCF0 Offset: 0x1998CF0 VA: 0x199CCF0 Slot: 10
	protected override void OnSuccess(GuildAllianceConsentResponse response) { }

	// RVA: 0x199CD58 Offset: 0x1998D58 VA: 0x199CD58 Slot: 13
	protected override void OnNoAuthority() { }

	// RVA: 0x199CDD0 Offset: 0x1998DD0 VA: 0x199CDD0 Slot: 19
	protected override void OnInfoNotFound() { }

	// RVA: 0x199CE5C Offset: 0x1998E5C VA: 0x199CE5C Slot: 17
	protected override void OnAllianceDisposed() { }

	// RVA: 0x199CE64 Offset: 0x1998E64 VA: 0x199CE64 Slot: 16
	protected override void OnAllianceNotFound() { }

	// RVA: 0x199CE6C Offset: 0x1998E6C VA: 0x199CE6C Slot: 20
	protected override void OnInviteNotFound() { }

	// RVA: 0x199CDD8 Offset: 0x1998DD8 VA: 0x199CDD8
	private void TargetErr(short id) { }

	// RVA: 0x199CE74 Offset: 0x1998E74 VA: 0x199CE74 Slot: 15
	protected override void OnGuildNotAccess() { }

	// RVA: 0x199CE88 Offset: 0x1998E88 VA: 0x199CE88 Slot: 12
	protected override void OnGuildNotJoined() { }

	// RVA: 0x199CE9C Offset: 0x1998E9C VA: 0x199CE9C Slot: 11
	protected override void OnServerDisconnect() { }

	// RVA: 0x199CEB0 Offset: 0x1998EB0 VA: 0x199CEB0 Slot: 14
	protected override void OnUserDisposed() { }

	// RVA: 0x199CEC4 Offset: 0x1998EC4 VA: 0x199CEC4 Slot: 21
	protected override void OnFailure(short returnCode) { }
}
