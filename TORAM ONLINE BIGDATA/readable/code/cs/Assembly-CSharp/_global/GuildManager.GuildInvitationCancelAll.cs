// Assembly: Assembly-CSharp.dll
// Namespace: 
private class GuildManager.GuildInvitationCancelAll : GuildInviteCancelAllExplain, IReconnectionData, IReconnectionReceiveResponse // TypeDefIndex: 1911
{
	// Fields
	private GuildManager manager; // 0x18

	// Methods

	// RVA: 0x20FF9DC Offset: 0x20FB9DC VA: 0x20FF9DC
	public void .ctor(GuildManager manager) { }

	// RVA: 0x21074E8 Offset: 0x21034E8 VA: 0x21074E8
	private void ResponseErr(GuildInviteCancelAllResponse response) { }

	// RVA: 0x21074EC Offset: 0x21034EC VA: 0x21074EC Slot: 12
	protected override void OnErr_ReserveLeft(GuildInviteCancelAllResponse response) { }

	// RVA: 0x21074F0 Offset: 0x21034F0 VA: 0x21074F0 Slot: 11
	protected override void OnErr_ReserveNotFound(GuildInviteCancelAllResponse response) { }

	// RVA: 0x21074F4 Offset: 0x21034F4 VA: 0x21074F4 Slot: 9
	protected override void OnSuccess(GuildInviteCancelAllResponse response) { }

	// RVA: 0x21074F8 Offset: 0x21034F8 VA: 0x21074F8 Slot: 10
	protected override void OnFailure(GuildInviteCancelAllResponse response) { }
}
