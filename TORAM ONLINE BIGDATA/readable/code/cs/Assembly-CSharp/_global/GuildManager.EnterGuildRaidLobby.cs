// Assembly: Assembly-CSharp.dll
// Namespace: 
private class GuildManager.EnterGuildRaidLobby : EnterGuildRaidLobbyExplain, IReconnectionData, IReconnectionReceiveResponse // TypeDefIndex: 1914
{
	// Methods

	// RVA: 0x2107724 Offset: 0x2103724 VA: 0x2107724
	public void .ctor(int enterId) { }

	// RVA: 0x20FF4B0 Offset: 0x20FB4B0 VA: 0x20FF4B0
	public void .ctor(int enterId, byte element) { }

	// RVA: 0x2107730 Offset: 0x2103730 VA: 0x2107730 Slot: 16
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x2107734 Offset: 0x2103734 VA: 0x2107734 Slot: 14
	protected override void OnGuildAllianceNotFound() { }

	// RVA: 0x2107738 Offset: 0x2103738 VA: 0x2107738 Slot: 13
	protected override void OnGuildNotAccess() { }

	// RVA: 0x21077E4 Offset: 0x21037E4 VA: 0x21077E4 Slot: 11
	protected override void OnGuildNotJoined() { }

	// RVA: 0x21077E8 Offset: 0x21037E8 VA: 0x21077E8 Slot: 12
	protected override void OnSystemUnavailable() { }

	// RVA: 0x21077EC Offset: 0x21037EC VA: 0x21077EC Slot: 15
	protected override void OnGuildRaidElementNotMatch() { }

	// RVA: 0x21077F0 Offset: 0x21037F0 VA: 0x21077F0 Slot: 9
	protected override void OnSuccess() { }

	// RVA: 0x2107840 Offset: 0x2103840 VA: 0x2107840 Slot: 10
	protected override void OnSystemLock() { }

	// RVA: 0x210773C Offset: 0x210373C VA: 0x210773C
	private void LeaveField() { }
}
