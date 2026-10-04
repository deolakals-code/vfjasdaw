// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GuildManager.GuildAllianceRelease : GuildAllianceReleaseExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 1917
{
	// Methods

	// RVA: 0x2107C1C Offset: 0x2103C1C VA: 0x2107C1C Slot: 15
	protected override void OnGuildNotAccess() { }

	// RVA: 0x2107CCC Offset: 0x2103CCC VA: 0x2107CCC Slot: 12
	protected override void OnGuildNotJoined() { }

	// RVA: 0x2107D10 Offset: 0x2103D10 VA: 0x2107D10 Slot: 11
	protected override void OnServerDisconnect() { }

	// RVA: 0x2107D54 Offset: 0x2103D54 VA: 0x2107D54 Slot: 14
	protected override void OnUserDisposed() { }

	// RVA: 0x2107D98 Offset: 0x2103D98 VA: 0x2107D98 Slot: 18
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x2107DE0 Offset: 0x2103DE0 VA: 0x2107DE0 Slot: 13
	protected override void OnNoAuthority() { }

	// RVA: 0x2107C60 Offset: 0x2103C60 VA: 0x2107C60
	private void ErrPop(string key, short code) { }

	// RVA: 0x2107E24 Offset: 0x2103E24 VA: 0x2107E24 Slot: 17
	protected override void OnAllianceDisposed() { }

	// RVA: 0x2107E30 Offset: 0x2103E30 VA: 0x2107E30 Slot: 16
	protected override void OnAllianceNotFound() { }

	// RVA: 0x2107E3C Offset: 0x2103E3C VA: 0x2107E3C Slot: 10
	protected override void OnSuccess() { }

	// RVA: 0x2107E68 Offset: 0x2103E68 VA: 0x2107E68
	public void .ctor() { }
}
