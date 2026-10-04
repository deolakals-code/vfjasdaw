// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GuildManager.AllianceInvitationData // TypeDefIndex: 1918
{
	// Fields
	public readonly int AllianceId; // 0x10
	public readonly string GuildName; // 0x18
	public readonly string MasterName; // 0x20
	private DateTime inviteDate; // 0x28

	// Methods

	// RVA: 0x2104950 Offset: 0x2100950 VA: 0x2104950
	public void .ctor(int id, string guildName, string masterName, DateTime inviteDate) { }

	// RVA: 0x20FE894 Offset: 0x20FA894 VA: 0x20FE894
	public void .ctor(GuildAllianceInvitationData data) { }

	// RVA: 0x20FE8B8 Offset: 0x20FA8B8 VA: 0x20FE8B8
	public float RemainingTime() { }
}
