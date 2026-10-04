// Assembly: Assembly-CSharp.dll
// Namespace: 
private class GuildManager.GuildAllianceGetSfaffData : GuildAllianceGetStaffDataExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 1916
{
	// Methods

	// RVA: 0x2106984 Offset: 0x2102984 VA: 0x2106984
	public void .ctor(int guildId) { }

	// RVA: 0x2107AA4 Offset: 0x2103AA4 VA: 0x2107AA4 Slot: 15
	protected override void OnAllianceNotFound() { }

	// RVA: 0x2107AA8 Offset: 0x2103AA8 VA: 0x2107AA8 Slot: 17
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x2107AAC Offset: 0x2103AAC VA: 0x2107AAC Slot: 14
	protected override void OnGuildNotAccess() { }

	// RVA: 0x2107AB0 Offset: 0x2103AB0 VA: 0x2107AB0 Slot: 12
	protected override void OnGuildNotJoined() { }

	// RVA: 0x2107AB4 Offset: 0x2103AB4 VA: 0x2107AB4 Slot: 16
	protected override void OnInfoNotFound() { }

	// RVA: 0x2107AB8 Offset: 0x2103AB8 VA: 0x2107AB8 Slot: 11
	protected override void OnServerDisconnect() { }

	// RVA: 0x2107ABC Offset: 0x2103ABC VA: 0x2107ABC Slot: 13
	protected override void OnUserDisposed() { }

	// RVA: 0x2107AC0 Offset: 0x2103AC0 VA: 0x2107AC0 Slot: 10
	protected override void OnSuccess(GuildAllianceGetStaffDataResponse response) { }
}
