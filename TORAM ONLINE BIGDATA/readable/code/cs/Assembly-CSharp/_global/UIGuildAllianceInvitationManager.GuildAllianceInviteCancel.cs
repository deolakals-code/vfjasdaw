// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIGuildAllianceInvitationManager.GuildAllianceInviteCancel : GuildAllianceInviteCancelExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 6612
{
	// Fields
	private UIGuildAllianceInvitationManager manager; // 0x18
	private int cashAllianceId; // 0x20

	// Methods

	// RVA: 0x199CA4C Offset: 0x1998A4C VA: 0x199CA4C
	public void .ctor(UIGuildAllianceInvitationManager manager, int allianceId) { }

	// RVA: 0x199CA8C Offset: 0x1998A8C VA: 0x199CA8C Slot: 16
	protected override void OnInviteNotFound() { }

	// RVA: 0x199CB00 Offset: 0x1998B00 VA: 0x199CB00 Slot: 10
	protected override void OnSuccess(GuildAllianceInviteCancelResponse response) { }

	// RVA: 0x199CA94 Offset: 0x1998A94 VA: 0x199CA94
	private void ReceiveList(int id) { }

	// RVA: 0x199CB18 Offset: 0x1998B18 VA: 0x199CB18 Slot: 13
	protected override void OnNoAuthority() { }

	// RVA: 0x199CB90 Offset: 0x1998B90 VA: 0x199CB90 Slot: 15
	protected override void OnGuildNotAccess() { }

	// RVA: 0x199CBA4 Offset: 0x1998BA4 VA: 0x199CBA4 Slot: 12
	protected override void OnGuildNotJoined() { }

	// RVA: 0x199CBB8 Offset: 0x1998BB8 VA: 0x199CBB8 Slot: 11
	protected override void OnServerDisconnect() { }

	// RVA: 0x199CBCC Offset: 0x1998BCC VA: 0x199CBCC Slot: 14
	protected override void OnUserDisposed() { }

	// RVA: 0x199CBE0 Offset: 0x1998BE0 VA: 0x199CBE0 Slot: 17
	protected override void OnFailure(short returnCode) { }
}
