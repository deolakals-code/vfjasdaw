// Assembly: Assembly-CSharp.dll
// Namespace: 
private class GuildManager.AllianceGetRaidHeldData : AllianceGetRaidHeldDataExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 1915
{
	// Methods

	// RVA: 0x20FF698 Offset: 0x20FB698 VA: 0x20FF698
	public void .ctor(int guildId) { }

	// RVA: 0x2107920 Offset: 0x2103920 VA: 0x2107920 Slot: 17
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x2107A0C Offset: 0x2103A0C VA: 0x2107A0C Slot: 14
	protected override void OnGuildNotAccess() { }

	// RVA: 0x2107A10 Offset: 0x2103A10 VA: 0x2107A10 Slot: 12
	protected override void OnGuildNotJoined() { }

	// RVA: 0x2107A14 Offset: 0x2103A14 VA: 0x2107A14 Slot: 16
	protected override void OnInfoNotFound() { }

	// RVA: 0x2107A18 Offset: 0x2103A18 VA: 0x2107A18 Slot: 11
	protected override void OnServerDisconnect() { }

	// RVA: 0x2107A1C Offset: 0x2103A1C VA: 0x2107A1C Slot: 13
	protected override void OnUserDisposed() { }

	// RVA: 0x2107A20 Offset: 0x2103A20 VA: 0x2107A20 Slot: 15
	protected override void OnAllianceNotFound() { }

	// RVA: 0x2107A60 Offset: 0x2103A60 VA: 0x2107A60 Slot: 10
	protected override void OnSuccess(GuildAllianceGetRaidHeldDataResponse response) { }
}
