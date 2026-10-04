// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Command
[CLSCompliant(False)]
public static class GuildOperations // TypeDefIndex: 15134
{
	// Methods

	// RVA: 0x35938C0 Offset: 0x358F8C0 VA: 0x35938C0
	public static void NameCheck(Game game, string guildName) { }

	// RVA: 0x35939CC Offset: 0x358F9CC VA: 0x35939CC
	public static void Create(Game game, string guildName) { }

	// RVA: 0x3593AD8 Offset: 0x358FAD8 VA: 0x3593AD8
	public static void Invitation(Game game, int targetId, string message, string targetName) { }

	// RVA: 0x3593C08 Offset: 0x358FC08 VA: 0x3593C08
	public static void InvitationCancel(Game game, int guildId) { }

	// RVA: 0x3593D08 Offset: 0x358FD08 VA: 0x3593D08
	public static void InvitationSenderCancel(Game game, int targetId) { }

	// RVA: 0x3593E08 Offset: 0x358FE08 VA: 0x3593E08
	public static void Acceptance(Game game, int guildId) { }

	// RVA: 0x3593F08 Offset: 0x358FF08 VA: 0x3593F08
	public static void Secede(Game game) { }

	// RVA: 0x3593FF8 Offset: 0x358FFF8 VA: 0x3593FF8
	public static void Exile(Game game, int targetId) { }

	// RVA: 0x35940F8 Offset: 0x35900F8 VA: 0x35940F8
	public static void Dissolution(Game game) { }

	// RVA: 0x35941E8 Offset: 0x35901E8 VA: 0x35941E8
	public static void GetData(Game game) { }

	// RVA: 0x35942D8 Offset: 0x35902D8 VA: 0x35942D8
	public static void GetBoard(Game game) { }

	// RVA: 0x35943C8 Offset: 0x35903C8 VA: 0x35943C8
	public static void WriteBoard(Game game, byte type, string message) { }

	// RVA: 0x35944DC Offset: 0x35904DC VA: 0x35944DC
	public static void NameChange(Game game, string guildName) { }

	// RVA: 0x35945E8 Offset: 0x35905E8 VA: 0x35945E8
	public static void PostChange(Game game, int targetId, byte postFlag) { }

	// RVA: 0x35946F0 Offset: 0x35906F0 VA: 0x35946F0
	public static void TransferMasterPost(Game game, int targetId) { }

	// RVA: 0x3594804 Offset: 0x3590804 VA: 0x3594804
	public static void CandidacyMasterPost(Game game, int targetId) { }

	// RVA: 0x3594918 Offset: 0x3590918 VA: 0x3594918
	public static void GetBooster(Game game) { }

	// RVA: 0x35949E0 Offset: 0x35909E0 VA: 0x35949E0
	public static void CheckContribution(Game game) { }

	// RVA: 0x3594AA8 Offset: 0x3590AA8 VA: 0x3594AA8
	public static void CollectContribution(Game game) { }

	// RVA: 0x3594B70 Offset: 0x3590B70 VA: 0x3594B70
	public static void RunBooster(Game game, byte boosterType) { }

	// RVA: 0x3594C84 Offset: 0x3590C84 VA: 0x3594C84
	public static void Present(Game game, byte type) { }

	// RVA: 0x3594D98 Offset: 0x3590D98 VA: 0x3594D98
	public static void UnreceivedMessage(Game game, DateTime latestGuildMsgTime) { }

	// RVA: 0x3594EAC Offset: 0x3590EAC VA: 0x3594EAC
	public static void MemberList(Game game) { }

	// RVA: 0x3594F74 Offset: 0x3590F74 VA: 0x3594F74
	public static void ChangeOnlineNotice(Game game, byte type) { }

	// RVA: 0x3595088 Offset: 0x3591088 VA: 0x3595088
	public static void ContributeGold(Game game, int value) { }

	// RVA: 0x359519C Offset: 0x359119C VA: 0x359519C
	public static void ChangeTenant(Game game, byte shopType, bool flag) { }

	// RVA: 0x35952BC Offset: 0x35912BC VA: 0x35952BC
	public static void UpdateTenant(Game game) { }

	// RVA: 0x35953C8 Offset: 0x35913C8 VA: 0x35953C8
	public static void GetStaffData(Game game) { }

	// RVA: 0x35954D4 Offset: 0x35914D4 VA: 0x35954D4
	public static void StartChangeStaffData(Game game, byte type) { }

	// RVA: 0x35955E8 Offset: 0x35915E8 VA: 0x35955E8
	public static void EndChangeStaffName(Game game, string name) { }

	// RVA: 0x359570C Offset: 0x359170C VA: 0x359570C
	public static void EndChangeStaffStyle(Game game, NewStyleData styleData) { }

	// RVA: 0x3595834 Offset: 0x3591834 VA: 0x3595834
	public static void EndChangeStaffEquip(Game game, Dictionary<byte, int> changeEquipData) { }

	// RVA: 0x359595C Offset: 0x359195C VA: 0x359595C
	public static void CancelChangeStaffData(Game game, byte type) { }

	// RVA: 0x3595A70 Offset: 0x3591A70 VA: 0x3595A70
	public static void Check(Game game) { }

	// RVA: 0x3595B38 Offset: 0x3591B38 VA: 0x3595B38
	public static void GuildHomeLeave(Game game) { }

	// RVA: 0x3595C28 Offset: 0x3591C28 VA: 0x3595C28
	public static void GuildStaffRunningErrand(Game game) { }

	// RVA: 0x3595CF0 Offset: 0x3591CF0 VA: 0x3595CF0
	public static void GuildStaffChangeFlag(Game game, byte type, bool flag) { }

	// RVA: 0x3595E10 Offset: 0x3591E10 VA: 0x3595E10
	public static void GuildStaffChangeSupport(Game game, byte support) { }

	// RVA: 0x3595F24 Offset: 0x3591F24 VA: 0x3595F24
	public static void GuildStaffRecoveryPlayer(Game game) { }

	// RVA: 0x3595FEC Offset: 0x3591FEC VA: 0x3595FEC
	public static void GuildQuestGetQuest(Game game) { }

	// RVA: 0x35960B4 Offset: 0x35920B4 VA: 0x35960B4
	public static void GuildQuestReportQuest(Game game, byte no, byte clear, int value = 0) { }

	// RVA: 0x35961E0 Offset: 0x35921E0 VA: 0x35961E0
	public static void GuildQuestDiscardQuest(Game game, byte no, byte nextType) { }

	// RVA: 0x35962FC Offset: 0x35922FC VA: 0x35962FC
	public static void GuildQuestResetQuest(Game game, byte no = 0) { }

	// RVA: 0x3596410 Offset: 0x3592410 VA: 0x3596410
	public static void GuildMedalUpdate(Game game) { }

	// RVA: 0x35964D8 Offset: 0x35924D8 VA: 0x35964D8
	public static void GuildOpenRenovation(Game game, byte renovationId) { }

	// RVA: 0x35965EC Offset: 0x35925EC VA: 0x35965EC
	public static void GuildChangeRenovation(Game game, byte renovationId) { }

	// RVA: 0x3596700 Offset: 0x3592700 VA: 0x3596700
	public static void GuildHeldRaid(Game game, int raidId, bool isPractice = False) { }

	// RVA: 0x3596820 Offset: 0x3592820 VA: 0x3596820
	public static void GuildGetHeldRaidData(Game game) { }

	// RVA: 0x35968E8 Offset: 0x35928E8 VA: 0x35968E8
	public static void GuildResetRaid(Game game) { }

	// RVA: 0x35969B0 Offset: 0x35929B0 VA: 0x35969B0
	public static void GetRaidBossData(Game game) { }

	// RVA: 0x3596A78 Offset: 0x3592A78 VA: 0x3596A78
	public static void GuildEndHeldRaid(Game game) { }

	// RVA: 0x3596B40 Offset: 0x3592B40 VA: 0x3596B40
	public static void GuildLevelUpFacility(Game game, int facilityId, short lv, byte element = 0) { }

	// RVA: 0x3596C58 Offset: 0x3592C58 VA: 0x3596C58
	public static void GuildSetFacilityFlag(Game game, bool isActive) { }
}
