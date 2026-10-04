// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AnnouncementManager : Singleton<AnnouncementManager>, ISceneChangeManager // TypeDefIndex: 1692
{
	// Fields
	private Dictionary<AnnouncementType, List<AnnouncementBase>> announcementData; // 0x20
	private SystemTextManager systemTextManager; // 0x28

	// Methods

	// RVA: 0x20A5D64 Offset: 0x20A1D64 VA: 0x20A5D64
	private void Awake() { }

	// RVA: 0x20A61EC Offset: 0x20A21EC VA: 0x20A61EC
	private void Update() { }

	// RVA: 0x20A6778 Offset: 0x20A2778 VA: 0x20A6778
	public Dictionary<AnnouncementType, int> GetEnabledAnnouncementTypeCount() { }

	// RVA: 0x20A6434 Offset: 0x20A2434 VA: 0x20A6434
	public int GetAnnouncementCountByType(AnnouncementType type) { }

	// RVA: 0x20A692C Offset: 0x20A292C VA: 0x20A692C
	public void RemoveAnnouncementByType(AnnouncementType type) { }

	// RVA: 0x20A6558 Offset: 0x20A2558 VA: 0x20A6558
	public bool RemovePartyAnnouncement(int partyId) { }

	// RVA: 0x20A69CC Offset: 0x20A29CC VA: 0x20A69CC
	public bool RemovePartyLinkAnnouncement(int partyId) { }

	// RVA: 0x20A6AE4 Offset: 0x20A2AE4 VA: 0x20A6AE4
	public bool RemoveFriendAnnouncement(int archetypeId) { }

	// RVA: 0x20A6BFC Offset: 0x20A2BFC VA: 0x20A6BFC
	public bool RemovePartyRecruitmentApply(int archetypeId) { }

	// RVA: 0x20A6D14 Offset: 0x20A2D14 VA: 0x20A6D14
	public bool RemoveTrophyAnnouncement(int trophyId) { }

	// RVA: 0x20A6E2C Offset: 0x20A2E2C VA: 0x20A6E2C
	public bool RemoveDailyTrophyAnnouncement(int dailyTrophyId) { }

	// RVA: 0x20A6F44 Offset: 0x20A2F44 VA: 0x20A6F44
	public bool RemoveWeeklyTrophyAnnouncement(int WeeklyTrophyId) { }

	// RVA: 0x20A705C Offset: 0x20A305C VA: 0x20A705C
	public bool RemoveDailyStampAnnouncement(byte rewardIndex) { }

	// RVA: 0x20A7174 Offset: 0x20A3174 VA: 0x20A7174
	public bool RemoveGuildInvitationAnnouncement(int guildId) { }

	// RVA: 0x20A6668 Offset: 0x20A2668 VA: 0x20A6668
	public bool RemoveGuildAlliancedAnnouncement(int guildId) { }

	// RVA: 0x20A7294 Offset: 0x20A3294 VA: 0x20A7294
	public bool ClearGuildInvitationAnnouncement() { }

	// RVA: 0x20A7324 Offset: 0x20A3324 VA: 0x20A7324
	public bool RemoveTellHistoryAnnouncement(int id) { }

	// RVA: 0x20A743C Offset: 0x20A343C VA: 0x20A743C
	public bool RemoveGuildJoinRequestAnnouncement(int id) { }

	// RVA: 0x20A7554 Offset: 0x20A3554 VA: 0x20A7554
	public bool ClearGuildJoinRequestAnnouncement() { }

	// RVA: 0x20A75E4 Offset: 0x20A35E4 VA: 0x20A75E4
	public void AddGuilInvitationdAnnouncement(int guildId, string guildName, bool isChatAnnounce) { }

	// RVA: 0x20A791C Offset: 0x20A391C VA: 0x20A791C
	public void AddGuildAllianceInvitationdAnnouncement(int guildId, float timer, bool isChatAnnounce) { }

	// RVA: 0x20A7B64 Offset: 0x20A3B64 VA: 0x20A7B64
	public void AddTradeAnnouncement(TradeRequestEvent_ tradeRequest) { }

	// RVA: 0x20A7EF8 Offset: 0x20A3EF8 VA: 0x20A7EF8
	public void AddPartyAnnouncement(PartyReserveData infomation) { }

	// RVA: 0x20A81F4 Offset: 0x20A41F4 VA: 0x20A81F4
	public void PartyAnnouncementClear() { }

	// RVA: 0x20A82F0 Offset: 0x20A42F0 VA: 0x20A82F0
	public void AddPartyLinkAnnouncement(int partyId, PartyLinkInviteData invite) { }

	// RVA: 0x20A856C Offset: 0x20A456C VA: 0x20A856C
	public void AddFriendAnnouncement(FriendReserveData friend) { }

	// RVA: 0x20A87E8 Offset: 0x20A47E8 VA: 0x20A87E8
	public void AddPartyRecruitmentApplyAnnouncement(int archetypeId, PartyCandidateData invite, TimeSpan leftTime) { }

	// RVA: 0x20A8AE4 Offset: 0x20A4AE4 VA: 0x20A8AE4
	public void AddTrophyAnnouncement(TrophyEvent trophy) { }

	// RVA: 0x20A8EBC Offset: 0x20A4EBC VA: 0x20A8EBC
	public void AddTrophyAnnouncement(TrophyManager.TrophyData[] trophy) { }

	// RVA: 0x20A9138 Offset: 0x20A5138 VA: 0x20A9138
	public void AddTrophyAnnouncement(AnnouncementType type, TrophyManager.TrophyData daily) { }

	// RVA: 0x20A9334 Offset: 0x20A5334 VA: 0x20A9334
	public void AddDailyStampAnnouncement(StampCardData reward) { }

	// RVA: 0x20A9598 Offset: 0x20A5598 VA: 0x20A9598
	public void AddNewMailAnnouncement(int mailId) { }

	// RVA: 0x20A97A0 Offset: 0x20A57A0 VA: 0x20A97A0
	public void AddNewDeliveryAnnouncement(int mailId) { }

	// RVA: 0x20A99A8 Offset: 0x20A59A8 VA: 0x20A99A8
	public void AddNewPresentAnnouncement(int mailId) { }

	// RVA: 0x20A9BB0 Offset: 0x20A5BB0 VA: 0x20A9BB0
	public void AddTellHistoryAnnouncement(int id) { }

	// RVA: 0x20A9DC8 Offset: 0x20A5DC8 VA: 0x20A9DC8
	public void AddGuildJoinRequestAnnouncement(int id, string name, bool isChatAnnounce) { }

	// RVA: 0x20AA100 Offset: 0x20A6100 VA: 0x20AA100
	public bool ContainsPartyInvitationAnnouncement(int partyId) { }

	// RVA: 0x20AA234 Offset: 0x20A6234 VA: 0x20AA234
	public bool ContainsPartyLinInvitationAnnouncement(int partyId) { }

	// RVA: 0x20AA368 Offset: 0x20A6368 VA: 0x20AA368
	public void UpdateQuestionnairePage(bool updateItem) { }

	[IteratorStateMachine(typeof(AnnouncementManager.<getQuestionnairePageFlag>d__41))]
	// RVA: 0x20AA410 Offset: 0x20A6410 VA: 0x20AA410
	private IEnumerator getQuestionnairePageFlag(bool updateItem) { }

	// RVA: 0x20A6500 Offset: 0x20A2500 VA: 0x20A6500
	public List<AnnouncementBase> GetAnnouncementByType(AnnouncementType type) { }

	// RVA: 0x20AA4B8 Offset: 0x20A64B8 VA: 0x20AA4B8
	public bool TryGetTradeAnnouncementData(out TradeAnnouncementData tradeAnnouncementData) { }

	// RVA: 0x20AA5DC Offset: 0x20A65DC VA: 0x20AA5DC Slot: 4
	public void OnEnter() { }

	// RVA: 0x20AA5E0 Offset: 0x20A65E0 VA: 0x20AA5E0 Slot: 5
	public void OnLeave() { }

	// RVA: 0x20AA5E4 Offset: 0x20A65E4 VA: 0x20AA5E4
	public void .ctor() { }
}
