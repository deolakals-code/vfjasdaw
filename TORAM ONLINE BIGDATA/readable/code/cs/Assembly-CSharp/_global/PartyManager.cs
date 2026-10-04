// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PartyManager : Singleton<PartyManager> // TypeDefIndex: 2201
{
	// Fields
	public const int MaxPartyMemberNum = 4;
	private ChatWindow _chatManager; // 0x20
	private SystemTextManager _systemTextManager; // 0x28
	private GameManager _gameManager; // 0x30
	private PlayerDataManager _playerDataManager; // 0x38
	private PartyManager.PartyData partyData; // 0x40
	private PartyLinkInviteData linkInviteData; // 0x48
	private int linkPartyMemberNum; // 0x50
	[CompilerGenerated]
	private int <linkInvitingPartyId>k__BackingField; // 0x54
	[CompilerGenerated]
	private string <linkInvitingPartyLeaderName>k__BackingField; // 0x58
	private bool isDoLinkInviteCancel; // 0x60
	private PartyManager.PartyRecruitmentRegistrationData partyRecruitmentRegistrationData; // 0x68
	public readonly int PartyMemberMax; // 0x70
	[CompilerGenerated]
	private Action ResponseCallback; // 0x78
	private Dictionary<int, int> lotteryUserList; // 0x80
	private int saveLotteryFieldId; // 0x88

	// Properties
	private ChatWindow chatManager { get; }
	private SystemTextManager systemTextManager { get; }
	private GameManager gameManager { get; }
	private PlayerDataManager playerDataManager { get; }
	public bool IsParty { get; }
	public bool IsPendingOnly { get; }
	public int GroupActiveMemberNum { get; }
	public int GroupAvatarMemberNum { get; }
	public int ActivePartyMemverNum { get; }
	public int LoginFieldUserPartyMemberNum { get; }
	public bool IsPartyMax { get; }
	public bool IsLeader { get; }
	public IList<PartyMemberData> MemberData { get; }
	public IEnumerable<PartyMemberData> LoginMemberData { get; }
	public int PartyMemberNum { get; }
	public int PartyPetNum { get; }
	public int PartyNonPetNum { get; }
	public int PartyPartnerNum { get; }
	public int PendingPartyMemverNum { get; }
	public int PartyLeaderId { get; }
	public bool IsLocalAnnihilated { get; }
	public bool IsEmployMercenary { get; }
	public bool IsWithPet { get; }
	public bool IsPartyBan { get; }
	public PartyLinkInviteData LinkInviteData { get; }
	public bool IsLink { get; }
	public int LinkPartyMemberNum { get; }
	public int linkInvitingPartyId { get; set; }
	public string linkInvitingPartyLeaderName { get; set; }
	public PartyManager.PartyRecruitmentRegistrationData RecruitmentRegistrationData { get; }

	// Methods

	// RVA: 0x215AF70 Offset: 0x2156F70 VA: 0x215AF70
	private ChatWindow get_chatManager() { }

	// RVA: 0x215B010 Offset: 0x2157010 VA: 0x215B010
	private SystemTextManager get_systemTextManager() { }

	// RVA: 0x215B108 Offset: 0x2157108 VA: 0x215B108
	private GameManager get_gameManager() { }

	// RVA: 0x215B1A0 Offset: 0x21571A0 VA: 0x215B1A0
	private PlayerDataManager get_playerDataManager() { }

	// RVA: 0x215B224 Offset: 0x2157224 VA: 0x215B224
	public bool get_IsParty() { }

	// RVA: 0x215B248 Offset: 0x2157248 VA: 0x215B248
	public bool get_IsPendingOnly() { }

	// RVA: 0x215B28C Offset: 0x215728C VA: 0x215B28C
	public int get_GroupActiveMemberNum() { }

	// RVA: 0x215B2A8 Offset: 0x21572A8 VA: 0x215B2A8
	public int get_GroupAvatarMemberNum() { }

	// RVA: 0x215B270 Offset: 0x2157270 VA: 0x215B270
	public int get_ActivePartyMemverNum() { }

	// RVA: 0x215B2C4 Offset: 0x21572C4 VA: 0x215B2C4
	public int get_LoginFieldUserPartyMemberNum() { }

	// RVA: 0x215B2E0 Offset: 0x21572E0 VA: 0x215B2E0
	public bool get_IsPartyMax() { }

	// RVA: 0x215B310 Offset: 0x2157310 VA: 0x215B310
	public bool get_IsLeader() { }

	// RVA: 0x215B380 Offset: 0x2157380 VA: 0x215B380
	public IList<PartyMemberData> get_MemberData() { }

	// RVA: 0x215B39C Offset: 0x215739C VA: 0x215B39C
	public IEnumerable<PartyMemberData> get_LoginMemberData() { }

	// RVA: 0x215B3B8 Offset: 0x21573B8 VA: 0x215B3B8
	public int get_PartyMemberNum() { }

	// RVA: 0x215B3F8 Offset: 0x21573F8 VA: 0x215B3F8
	public int get_PartyPetNum() { }

	// RVA: 0x215B414 Offset: 0x2157414 VA: 0x215B414
	public int get_PartyNonPetNum() { }

	// RVA: 0x215B430 Offset: 0x2157430 VA: 0x215B430
	public int get_PartyPartnerNum() { }

	// RVA: 0x215B520 Offset: 0x2157520 VA: 0x215B520
	public int get_PendingPartyMemverNum() { }

	// RVA: 0x215B65C Offset: 0x215765C VA: 0x215B65C
	public int get_PartyLeaderId() { }

	// RVA: 0x215B678 Offset: 0x2157678 VA: 0x215B678
	public bool get_IsLocalAnnihilated() { }

	// RVA: 0x215BADC Offset: 0x2157ADC VA: 0x215BADC
	public bool get_IsEmployMercenary() { }

	// RVA: 0x215BBF4 Offset: 0x2157BF4 VA: 0x215BBF4
	public bool get_IsWithPet() { }

	// RVA: 0x215BC1C Offset: 0x2157C1C VA: 0x215BC1C
	public bool get_IsPartyBan() { }

	// RVA: 0x215BCCC Offset: 0x2157CCC VA: 0x215BCCC
	public PartyLinkInviteData get_LinkInviteData() { }

	// RVA: 0x215BCD4 Offset: 0x2157CD4 VA: 0x215BCD4
	public bool get_IsLink() { }

	// RVA: 0x215BCF8 Offset: 0x2157CF8 VA: 0x215BCF8
	public int get_LinkPartyMemberNum() { }

	[CompilerGenerated]
	// RVA: 0x215BD00 Offset: 0x2157D00 VA: 0x215BD00
	public int get_linkInvitingPartyId() { }

	[CompilerGenerated]
	// RVA: 0x215BD08 Offset: 0x2157D08 VA: 0x215BD08
	private void set_linkInvitingPartyId(int value) { }

	[CompilerGenerated]
	// RVA: 0x215BD10 Offset: 0x2157D10 VA: 0x215BD10
	public string get_linkInvitingPartyLeaderName() { }

	[CompilerGenerated]
	// RVA: 0x215BD18 Offset: 0x2157D18 VA: 0x215BD18
	private void set_linkInvitingPartyLeaderName(string value) { }

	// RVA: 0x215BD20 Offset: 0x2157D20 VA: 0x215BD20
	public PartyManager.PartyRecruitmentRegistrationData get_RecruitmentRegistrationData() { }

	[CompilerGenerated]
	// RVA: 0x215BD28 Offset: 0x2157D28 VA: 0x215BD28
	public void add_ResponseCallback(Action value) { }

	[CompilerGenerated]
	// RVA: 0x215BDC4 Offset: 0x2157DC4 VA: 0x215BDC4
	public void remove_ResponseCallback(Action value) { }

	// RVA: 0x215BE60 Offset: 0x2157E60 VA: 0x215BE60
	public bool Invitation(int targetArchetypeId, string message) { }

	// RVA: 0x215BE68 Offset: 0x2157E68 VA: 0x215BE68
	public bool Invitation(int targetArchetypeId, string message, Action callback) { }

	// RVA: 0x215C05C Offset: 0x215805C VA: 0x215C05C
	public void Secede() { }

	// RVA: 0x215C6A0 Offset: 0x21586A0 VA: 0x215C6A0
	public void Acceptance(int senderId, byte senderType, int partyId) { }

	// RVA: 0x215C6A8 Offset: 0x21586A8 VA: 0x215C6A8
	public void Acceptance(int senderId, byte senderType, int partyId, Action callback) { }

	// RVA: 0x215C86C Offset: 0x215886C VA: 0x215C86C
	public void Rejection(int senderId, int partyId) { }

	// RVA: 0x215C928 Offset: 0x2158928 VA: 0x215C928
	public void InvitationCancel(int targetId, string targetName) { }

	// RVA: 0x215C978 Offset: 0x2158978 VA: 0x215C978
	public void Dissolution() { }

	// RVA: 0x215C9AC Offset: 0x21589AC VA: 0x215C9AC
	public void Kickout(byte targetType, int targetId) { }

	// RVA: 0x215C9FC Offset: 0x21589FC VA: 0x215C9FC
	public void ChangeLeader(int targetId) { }

	// RVA: 0x215CA44 Offset: 0x2158A44 VA: 0x215CA44
	public void LinkInvitation(int targetId) { }

	// RVA: 0x215CA80 Offset: 0x2158A80 VA: 0x215CA80
	public void LinkInvitateCancel(PartyLinkInviteData invite) { }

	// RVA: 0x215CAB0 Offset: 0x2158AB0 VA: 0x215CAB0
	public void LinkSenderInvitatedCancel() { }

	// RVA: 0x215CADC Offset: 0x2158ADC VA: 0x215CADC
	public void LinkConsent(PartyLinkInviteData invite) { }

	// RVA: 0x215CB00 Offset: 0x2158B00 VA: 0x215CB00
	public void InvitationResponse(PartyInvitationResponse response) { }

	// RVA: 0x215CCD8 Offset: 0x2158CD8 VA: 0x215CCD8
	public void SecedeResponse(short returnCode) { }

	// RVA: 0x215D858 Offset: 0x2159858 VA: 0x215D858
	public void AcceptanceResponse(PartyAcceptanceResponse response) { }

	// RVA: 0x215D8D4 Offset: 0x21598D4 VA: 0x215D8D4
	public void RejectionResponse(PartyInviteCancelResponse response) { }

	// RVA: 0x215D950 Offset: 0x2159950 VA: 0x215D950
	public void InvitationCancelResponse(PartySenderInvitedCancelResponse response) { }

	// RVA: 0x215DA4C Offset: 0x2159A4C VA: 0x215DA4C
	public void LinkInvitationResponse(PartyLinkInvitationResponse response) { }

	// RVA: 0x215DB9C Offset: 0x2159B9C VA: 0x215DB9C
	public void LinkInviteCancel(PartyLinkInviteCancelResponse response) { }

	// RVA: 0x215DC14 Offset: 0x2159C14 VA: 0x215DC14
	public void LinkSenderInvitedCancelResponse() { }

	// RVA: 0x215DCF8 Offset: 0x2159CF8 VA: 0x215DCF8
	public void LinkConsentResponse(PartyLinkConsentResponse response) { }

	// RVA: 0x215DE88 Offset: 0x2159E88 VA: 0x215DE88
	public void LinkReleaseResposnse() { }

	// RVA: 0x215DEF0 Offset: 0x2159EF0 VA: 0x215DEF0
	public void OnInvitation(PartyInvitationEvent invitation) { }

	// RVA: 0x215E04C Offset: 0x215A04C VA: 0x215E04C
	public void OnRejection(PartyInviteCancelEvent cancel) { }

	// RVA: 0x215E128 Offset: 0x215A128 VA: 0x215E128
	public void OnDissolution(PartyDissolutionEvent dissolution) { }

	// RVA: 0x215E400 Offset: 0x215A400 VA: 0x215E400
	public void OnJoin(PartyJoinEvent join) { }

	// RVA: 0x215E5E8 Offset: 0x215A5E8 VA: 0x215E5E8
	public void OnKickout(PartyKickoutEvent kickout) { }

	// RVA: 0x215EE4C Offset: 0x215AE4C VA: 0x215EE4C
	public void OnLogin(PartyLoginEvent login) { }

	// RVA: 0x215F010 Offset: 0x215B010 VA: 0x215F010
	public void OnLogout(PartyLogoutEvent logout) { }

	// RVA: 0x215F224 Offset: 0x215B224 VA: 0x215F224
	public void OnInvitationCancel(PartySenderInvitedCancelEvent cancel) { }

	// RVA: 0x215F394 Offset: 0x215B394 VA: 0x215F394
	public void OnSecede(PartySecedeEvent secede) { }

	// RVA: 0x215F640 Offset: 0x215B640 VA: 0x215F640
	public void UpdateState(IPartyStateEvent state) { }

	// RVA: 0x21604AC Offset: 0x215C4AC VA: 0x21604AC
	public void UpdateStatus(IPartyStatusEvent status) { }

	// RVA: 0x2160804 Offset: 0x215C804 VA: 0x2160804
	public void OnInvitationTimeout(PartyInviteTimeoutEvent timeout) { }

	// RVA: 0x21609B4 Offset: 0x215C9B4 VA: 0x21609B4
	public void OnChangeLeader(PartyLeaderChangeEvent change) { }

	// RVA: 0x2160BB4 Offset: 0x215CBB4 VA: 0x2160BB4
	public void OnRelated(PartyRelatedEvent related) { }

	// RVA: 0x2161190 Offset: 0x215D190 VA: 0x2161190
	public void OnPartyLinkState(PartyLinkStateEvent linkEvent) { }

	// RVA: 0x2161498 Offset: 0x215D498 VA: 0x2161498
	public void OnPartyLinkInvite(PartyLinkInviteEvent linkEvent) { }

	// RVA: 0x21615D4 Offset: 0x215D5D4 VA: 0x21615D4
	public void OnPartyLinkCancel(PartyLinkCancelEvent linkEvent) { }

	// RVA: 0x2161764 Offset: 0x215D764 VA: 0x2161764
	public void OnPartyLinkSenderCancel(PartyLinkSenderCancelEvent linkEvent) { }

	// RVA: 0x21618DC Offset: 0x215D8DC VA: 0x21618DC
	public void OnPartyLinkConsent(PartyLinkConsentEvent linkEvent) { }

	// RVA: 0x2161AEC Offset: 0x215DAEC VA: 0x2161AEC
	public void OnPartyLinkRelease() { }

	// RVA: 0x2161C34 Offset: 0x215DC34 VA: 0x2161C34
	public void OnPartyRecruitmentApplyInvite(PartyRecruitmentApplyEvent applyEvent) { }

	// RVA: 0x215C760 Offset: 0x2158760 VA: 0x215C760
	private bool existPartyInvitationAnnounce(int partyId) { }

	// RVA: 0x2161E2C Offset: 0x215DE2C VA: 0x2161E2C
	public void ClearCallback() { }

	// RVA: 0x215C040 Offset: 0x2158040 VA: 0x215C040
	public bool ContainsPartyMember(int archetypeId, byte archetypeType) { }

	// RVA: 0x2161E38 Offset: 0x215DE38 VA: 0x2161E38
	public void SetMemberObject(int archetypeId, byte archetypeType, GameObject obj) { }

	// RVA: 0x2161E54 Offset: 0x215DE54 VA: 0x2161E54
	public void RemoveMemberObject(int archetypeId, byte archetypeType) { }

	// RVA: 0x215D2F4 Offset: 0x21592F4 VA: 0x215D2F4
	public void ClearPartyMember() { }

	// RVA: 0x215DA24 Offset: 0x2159A24 VA: 0x215DA24
	private void removePartyMember(int targetId, byte targetArcheType) { }

	// RVA: 0x2160434 Offset: 0x215C434 VA: 0x2160434
	private void updatePartyUI() { }

	// RVA: 0x2161E70 Offset: 0x215DE70 VA: 0x2161E70
	public int GetArcheTypeMebmerNum(byte targetArcheType) { }

	// RVA: 0x2161F94 Offset: 0x215DF94 VA: 0x2161F94
	public int GetArcheTypeAllStateMebmerNum(byte targetArcheType) { }

	// RVA: 0x21620B8 Offset: 0x215E0B8 VA: 0x21620B8
	public bool TryGetLeaderData(out PartyMemberData leaderData) { }

	// RVA: 0x2162100 Offset: 0x215E100 VA: 0x2162100
	public PartyMemberData GetPartyMemberData(int id) { }

	// RVA: 0x216244C Offset: 0x215E44C VA: 0x216244C
	public PartyMemberData GetMobaPartyMemberData(int id) { }

	// RVA: 0x216279C Offset: 0x215E79C VA: 0x216279C
	public PartyMemberData GetPartyMemberDataUseArcheType(int archetypeId) { }

	// RVA: 0x21627A8 Offset: 0x215E7A8 VA: 0x21627A8
	public PartyMemberData GetPartyMemberDataUseArcheType(byte archetypeType, int archetypeId) { }

	// RVA: 0x2162810 Offset: 0x215E810 VA: 0x2162810
	public PartyMemberData[] GetSamePlaceMember() { }

	// RVA: 0x216298C Offset: 0x215E98C VA: 0x216298C
	public byte GetSubWeaponType(int id, byte type) { }

	// RVA: 0x21629B4 Offset: 0x215E9B4 VA: 0x21629B4
	public void JoinAutoMember(Archetype archetype, GameObject obj, PlayerStatusBase status) { }

	// RVA: 0x2162C4C Offset: 0x215EC4C VA: 0x2162C4C
	public void JoinAutoMember(GameObject obj, PlayerStatusBase status) { }

	// RVA: 0x2162D80 Offset: 0x215ED80 VA: 0x2162D80
	public void JoinAutoMemberWithPlayer(PlayerDataManager playerDataManager) { }

	// RVA: 0x2162E74 Offset: 0x215EE74 VA: 0x2162E74
	public void SecedeAutoMember(int archetypeId, byte archetypeType) { }

	// RVA: 0x2162EB4 Offset: 0x215EEB4 VA: 0x2162EB4
	public void SecedeAutoMemberAll() { }

	// RVA: 0x21631DC Offset: 0x215F1DC VA: 0x21631DC
	public void UpdateAutoMemberUI(IRoomMemberStatus[] status, bool isParty) { }

	// RVA: 0x2164204 Offset: 0x2160204 VA: 0x2164204
	public void UpdateMoveOnlyAutoMemberUI() { }

	// RVA: 0x216422C Offset: 0x216022C VA: 0x216422C
	public void LotteryUserClear() { }

	// RVA: 0x2164308 Offset: 0x2160308 VA: 0x2164308
	public void AddLotteryUser(int archetypeId, int partyId) { }

	// RVA: 0x2164398 Offset: 0x2160398 VA: 0x2164398
	public bool IsLotteryUser(int archetypeId) { }

	// RVA: 0x216440C Offset: 0x216040C VA: 0x216440C
	public bool RemoveLotteryUser(int archetypeId) { }

	// RVA: 0x2164464 Offset: 0x2160464 VA: 0x2164464
	public bool LotteryJoin(int archetypeId) { }

	// RVA: 0x216450C Offset: 0x216050C VA: 0x216450C
	public void OnEnterGetPartyRecruitmentData() { }

	// RVA: 0x216466C Offset: 0x216066C VA: 0x216466C
	private void AfterGetPartyRecruitmentData(PartyCandidateData[] candidateDatas, TimeSpan[] leftTimes) { }

	// RVA: 0x2164964 Offset: 0x2160964 VA: 0x2164964
	public bool TrySetPartyLeaderRecruitmentData() { }

	// RVA: 0x21649E4 Offset: 0x21609E4 VA: 0x21649E4
	public void OnEventRecruitmentApproveToJoinParty(int partyId, int recruitmentId) { }

	// RVA: 0x2164A84 Offset: 0x2160A84 VA: 0x2164A84
	public void PartyRecruitmentApplyCancel() { }

	// RVA: 0x216022C Offset: 0x215C22C VA: 0x216022C
	public bool CheckPartyRecruitmentDummyContains() { }

	// RVA: 0x2160368 Offset: 0x215C368 VA: 0x2160368
	public void WithdrawPartyRecruiting() { }

	// RVA: 0x2164B14 Offset: 0x2160B14 VA: 0x2164B14
	public void PartyRecruitmentReplaceMember(int kickoutId, byte kickoutType) { }

	// RVA: 0x2164B3C Offset: 0x2160B3C VA: 0x2164B3C
	public bool CheckImplementationPartyRecruitmentResponce(int targetPartyId = -100, Action interimAction) { }

	// RVA: 0x2164BDC Offset: 0x2160BDC VA: 0x2164BDC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x2164D38 Offset: 0x2160D38 VA: 0x2164D38
	private bool <UpdateAutoMemberUI>b__149_1(PartyMemberData m) { }
}
