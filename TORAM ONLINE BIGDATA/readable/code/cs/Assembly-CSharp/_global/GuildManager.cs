// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GuildManager // TypeDefIndex: 1923
{
	// Fields
	[CompilerGenerated]
	private int <GuildId>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <GuildName>k__BackingField; // 0x18
	[CompilerGenerated]
	private int <GuildExp>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <GuildLevel>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <GuildMemberCount>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <GuildFundsPoint>k__BackingField; // 0x2C
	[CompilerGenerated]
	private int <GuildMedal>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <GuildQuestClearNum>k__BackingField; // 0x34
	[CompilerGenerated]
	private bool <IsGuildTenant>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <GuildTenant>k__BackingField; // 0x3C
	[CompilerGenerated]
	private bool <IsSelectGuildTenant>k__BackingField; // 0x40
	[CompilerGenerated]
	private int <SelectGuildTenant>k__BackingField; // 0x44
	private GuildStaffAICentral guildStaffAICentral; // 0x48
	private GuildStaffData guildStaffData; // 0x50
	private byte guildStaffHireFlag; // 0x58
	private byte guildStaffHireSupport; // 0x59
	private TimeSpan guildStaffHireLeftTime; // 0x60
	private DateTime guildStaffHireUpdateTime; // 0x68
	private TimeSpan guildStaffHireErrandLeftTime; // 0x70
	private DateTime guildStaffHireErrandUpdateTime; // 0x78
	private DateTime guildStaffRecoverySupportUpdateTime; // 0x80
	private Vector3 guildStaffDataSavePosition; // 0x88
	private float guildStaffDataSaveRot; // 0x94
	private int currentGuildStaffIndex; // 0x98
	private int requestLockUserId; // 0x9C
	private DateTime updateListTimer; // 0xA0
	private bool isEnterGuildHome; // 0xA8
	private short dungeonFloorDepth; // 0xAA
	private DateTime dungeonFloorUpdateTime; // 0xB0
	[CompilerGenerated]
	private GuildBoosterData <guildBoosterData>k__BackingField; // 0xB8
	private bool guildBoosterCallFlag; // 0xC0
	[CompilerGenerated]
	private int <GuildPoint>k__BackingField; // 0xC4
	private GuildCheckContributionResponse contributionResponseBuffer; // 0xC8
	[CompilerGenerated]
	private byte <RenovationId>k__BackingField; // 0xD0
	[CompilerGenerated]
	private long <OpenFlag>k__BackingField; // 0xD8
	[CompilerGenerated]
	private int <HomeBGMId>k__BackingField; // 0xE0
	private int allianceId; // 0xE4
	private DateTime allianceEndTimeUtc; // 0xE8
	private DateTime allianceEndCoolTimeUtc; // 0xF0
	private float alliancGuildChatLinkTimer; // 0xF8
	private byte currentChatLinkIndex; // 0xFC
	[CompilerGenerated]
	private bool <IsGuildAllianceChatLink>k__BackingField; // 0xFD
	private DateTime guildChatLink; // 0x100
	private DateTime alliancGuildChatLink; // 0x108
	private GuildStaffAICentral allianceGuildStaffAICentral; // 0x110
	private GuildStaffData allianceGuildStaffData; // 0x118
	private Vector3 guildStaffAllianceDataSavePosition; // 0x120
	private float guildStaffAllianceDataSaveRot; // 0x12C
	private List<GuildManager.AllianceInvitationData> allianceInvitationList; // 0x130
	private byte AuthorityFlag; // 0x138
	[CompilerGenerated]
	private string <AllianceGuildName>k__BackingField; // 0x140
	private Dictionary<int, GuildMemberData> guildMemberDataList; // 0x148
	private Dictionary<int, GuildMemberRequestData> guildMemberInvitationList; // 0x150
	private Dictionary<int, GuildBBSRequesterData> guildJoinRequesterList; // 0x158
	private DateTime RequesterGetTime; // 0x160
	private SystemTextManager _systemTextManager; // 0x168
	private PlayerDataManager _playerDataManager; // 0x170
	private byte prevNoticeType; // 0x178
	[CompilerGenerated]
	private Action ActionCallBack; // 0x180
	public int guildOperationFlag; // 0x188
	[CompilerGenerated]
	private string <GuildNameCheckFailureText>k__BackingField; // 0x190
	private bool isFirstMasterConnect; // 0x198
	private GuildRaidManager raidManager; // 0x1A0
	private GuildFacilityManager _facilityManager; // 0x1A8
	private bool isReenterGuildField; // 0x1B0
	private const string HOMEBGMIDSAVEKEY = "GuildBGMID";
	private const int DEFAULTHOMEBGMID = 6;
	private Dictionary<byte, int> homeBGMDataList; // 0x1B8
	[CompilerGenerated]
	private byte <EnterGuildRaidLobbyElement>k__BackingField; // 0x1C0

	// Properties
	public int GuildId { get; set; }
	public string GuildName { get; set; }
	public int GuildExp { get; set; }
	public float GuildExpRate { get; }
	public int GuildLevel { get; set; }
	public int GuildMemberCount { get; set; }
	public int GuildFundsPoint { get; set; }
	public int GuildMedal { get; set; }
	public int GuildQuestClearNum { get; set; }
	public bool IsGuildTenant { get; set; }
	public int GuildTenant { get; set; }
	public bool IsSelectGuildTenant { get; set; }
	public int SelectGuildTenant { get; set; }
	public byte GuildStaffHireSupport { get; }
	public int GuildMemberMax { get; }
	public short DungeonFloorDepth { get; }
	public GuildBoosterData guildBoosterData { get; set; }
	public int GuildPoint { get; set; }
	public int GuildHaveContribution { get; }
	public GuildCheckContributionResponse ContributionResponseBuffer { get; }
	public byte RenovationId { get; set; }
	public long OpenFlag { get; set; }
	public bool IsGuildRaidRelease { get; }
	public int HomeBGMId { get; set; }
	public bool IsGuildAllianceChatLink { get; set; }
	public bool IsGuildJoined { get; }
	public bool IsGuildMaster { get; }
	public bool IsGuildSubMaster { get; }
	public bool CanInvitation { get; }
	public bool CanWriteInformation { get; }
	public bool IsHaveAuthority { get; }
	public bool IsGuildMasterOnly { get; }
	public bool IsEnterGuildBar { get; }
	public bool IsUsableBoard { get; }
	public bool IsUsableGuildStaff { get; }
	public bool IsAlliance { get; }
	public float AllianceTimer { get; }
	public string AllianceGuildName { get; set; }
	public int AllianceInvitationNum { get; }
	public IList<GuildMemberData> GuildMemberDataList { get; }
	public IList<GuildMemberRequestData> GuildMemberInvitationList { get; }
	public IList<GuildBBSRequesterData> GuildJoinRequesterList { get; }
	private SystemTextManager systemTextManager { get; }
	private PlayerDataManager playerDataManager { get; }
	public string GuildNameCheckFailureText { get; set; }
	public bool IsFirstMasterConnect { get; }
	public GuildRaidManager RaidManager { get; }
	public GuildFacilityManager FacilityManager { get; }
	public byte EnterGuildRaidLobbyElement { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x20FBA64 Offset: 0x20F7A64 VA: 0x20FBA64
	public int get_GuildId() { }

	[CompilerGenerated]
	// RVA: 0x20FBA6C Offset: 0x20F7A6C VA: 0x20FBA6C
	private void set_GuildId(int value) { }

	[CompilerGenerated]
	// RVA: 0x20FBA74 Offset: 0x20F7A74 VA: 0x20FBA74
	public string get_GuildName() { }

	[CompilerGenerated]
	// RVA: 0x20FBA7C Offset: 0x20F7A7C VA: 0x20FBA7C
	private void set_GuildName(string value) { }

	[CompilerGenerated]
	// RVA: 0x20FBA84 Offset: 0x20F7A84 VA: 0x20FBA84
	public int get_GuildExp() { }

	[CompilerGenerated]
	// RVA: 0x20FBA8C Offset: 0x20F7A8C VA: 0x20FBA8C
	private void set_GuildExp(int value) { }

	// RVA: 0x20FBA94 Offset: 0x20F7A94 VA: 0x20FBA94
	public float get_GuildExpRate() { }

	[CompilerGenerated]
	// RVA: 0x20FBB7C Offset: 0x20F7B7C VA: 0x20FBB7C
	public int get_GuildLevel() { }

	[CompilerGenerated]
	// RVA: 0x20FBB84 Offset: 0x20F7B84 VA: 0x20FBB84
	private void set_GuildLevel(int value) { }

	[CompilerGenerated]
	// RVA: 0x20FBB8C Offset: 0x20F7B8C VA: 0x20FBB8C
	public int get_GuildMemberCount() { }

	[CompilerGenerated]
	// RVA: 0x20FBB94 Offset: 0x20F7B94 VA: 0x20FBB94
	private void set_GuildMemberCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x20FBB9C Offset: 0x20F7B9C VA: 0x20FBB9C
	public int get_GuildFundsPoint() { }

	[CompilerGenerated]
	// RVA: 0x20FBBA4 Offset: 0x20F7BA4 VA: 0x20FBBA4
	private void set_GuildFundsPoint(int value) { }

	[CompilerGenerated]
	// RVA: 0x20FBBAC Offset: 0x20F7BAC VA: 0x20FBBAC
	public int get_GuildMedal() { }

	[CompilerGenerated]
	// RVA: 0x20FBBB4 Offset: 0x20F7BB4 VA: 0x20FBBB4
	private void set_GuildMedal(int value) { }

	[CompilerGenerated]
	// RVA: 0x20FBBBC Offset: 0x20F7BBC VA: 0x20FBBBC
	public int get_GuildQuestClearNum() { }

	[CompilerGenerated]
	// RVA: 0x20FBBC4 Offset: 0x20F7BC4 VA: 0x20FBBC4
	private void set_GuildQuestClearNum(int value) { }

	[CompilerGenerated]
	// RVA: 0x20FBBCC Offset: 0x20F7BCC VA: 0x20FBBCC
	public bool get_IsGuildTenant() { }

	[CompilerGenerated]
	// RVA: 0x20FBBD4 Offset: 0x20F7BD4 VA: 0x20FBBD4
	private void set_IsGuildTenant(bool value) { }

	[CompilerGenerated]
	// RVA: 0x20FBBE0 Offset: 0x20F7BE0 VA: 0x20FBBE0
	public int get_GuildTenant() { }

	[CompilerGenerated]
	// RVA: 0x20FBBE8 Offset: 0x20F7BE8 VA: 0x20FBBE8
	private void set_GuildTenant(int value) { }

	[CompilerGenerated]
	// RVA: 0x20FBBF0 Offset: 0x20F7BF0 VA: 0x20FBBF0
	public bool get_IsSelectGuildTenant() { }

	[CompilerGenerated]
	// RVA: 0x20FBBF8 Offset: 0x20F7BF8 VA: 0x20FBBF8
	private void set_IsSelectGuildTenant(bool value) { }

	[CompilerGenerated]
	// RVA: 0x20FBC04 Offset: 0x20F7C04 VA: 0x20FBC04
	public int get_SelectGuildTenant() { }

	[CompilerGenerated]
	// RVA: 0x20FBC0C Offset: 0x20F7C0C VA: 0x20FBC0C
	private void set_SelectGuildTenant(int value) { }

	// RVA: 0x20FBC14 Offset: 0x20F7C14 VA: 0x20FBC14
	public byte get_GuildStaffHireSupport() { }

	// RVA: 0x20FBC1C Offset: 0x20F7C1C VA: 0x20FBC1C
	public int get_GuildMemberMax() { }

	// RVA: 0x20FBC28 Offset: 0x20F7C28 VA: 0x20FBC28
	public short get_DungeonFloorDepth() { }

	[CompilerGenerated]
	// RVA: 0x20FBD1C Offset: 0x20F7D1C VA: 0x20FBD1C
	public GuildBoosterData get_guildBoosterData() { }

	[CompilerGenerated]
	// RVA: 0x20FBD24 Offset: 0x20F7D24 VA: 0x20FBD24
	private void set_guildBoosterData(GuildBoosterData value) { }

	[CompilerGenerated]
	// RVA: 0x20FBD2C Offset: 0x20F7D2C VA: 0x20FBD2C
	public int get_GuildPoint() { }

	[CompilerGenerated]
	// RVA: 0x20FBD34 Offset: 0x20F7D34 VA: 0x20FBD34
	private void set_GuildPoint(int value) { }

	// RVA: 0x20FBD3C Offset: 0x20F7D3C VA: 0x20FBD3C
	public int get_GuildHaveContribution() { }

	// RVA: 0x20FBEAC Offset: 0x20F7EAC VA: 0x20FBEAC
	public GuildCheckContributionResponse get_ContributionResponseBuffer() { }

	[CompilerGenerated]
	// RVA: 0x20FBEB4 Offset: 0x20F7EB4 VA: 0x20FBEB4
	private void set_RenovationId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x20FBEBC Offset: 0x20F7EBC VA: 0x20FBEBC
	public byte get_RenovationId() { }

	[CompilerGenerated]
	// RVA: 0x20FBEC4 Offset: 0x20F7EC4 VA: 0x20FBEC4
	private void set_OpenFlag(long value) { }

	[CompilerGenerated]
	// RVA: 0x20FBECC Offset: 0x20F7ECC VA: 0x20FBECC
	public long get_OpenFlag() { }

	// RVA: 0x20FBED4 Offset: 0x20F7ED4 VA: 0x20FBED4
	public bool get_IsGuildRaidRelease() { }

	[CompilerGenerated]
	// RVA: 0x20FBEFC Offset: 0x20F7EFC VA: 0x20FBEFC
	public int get_HomeBGMId() { }

	[CompilerGenerated]
	// RVA: 0x20FBF04 Offset: 0x20F7F04 VA: 0x20FBF04
	private void set_HomeBGMId(int value) { }

	[CompilerGenerated]
	// RVA: 0x20FBF0C Offset: 0x20F7F0C VA: 0x20FBF0C
	public bool get_IsGuildAllianceChatLink() { }

	[CompilerGenerated]
	// RVA: 0x20FBF14 Offset: 0x20F7F14 VA: 0x20FBF14
	private void set_IsGuildAllianceChatLink(bool value) { }

	// RVA: 0x20FBF20 Offset: 0x20F7F20 VA: 0x20FBF20
	public bool get_IsGuildJoined() { }

	// RVA: 0x20FBF30 Offset: 0x20F7F30 VA: 0x20FBF30
	public bool get_IsGuildMaster() { }

	// RVA: 0x20FBF3C Offset: 0x20F7F3C VA: 0x20FBF3C
	public bool get_IsGuildSubMaster() { }

	// RVA: 0x20FBF48 Offset: 0x20F7F48 VA: 0x20FBF48
	public bool get_CanInvitation() { }

	// RVA: 0x20FBF54 Offset: 0x20F7F54 VA: 0x20FBF54
	public bool get_CanWriteInformation() { }

	// RVA: 0x20FBF60 Offset: 0x20F7F60 VA: 0x20FBF60
	public bool get_IsHaveAuthority() { }

	// RVA: 0x20FBF74 Offset: 0x20F7F74 VA: 0x20FBF74
	public bool get_IsGuildMasterOnly() { }

	// RVA: 0x20FBF84 Offset: 0x20F7F84 VA: 0x20FBF84
	public bool get_IsEnterGuildBar() { }

	// RVA: 0x20FBFA4 Offset: 0x20F7FA4 VA: 0x20FBFA4
	public bool get_IsUsableBoard() { }

	// RVA: 0x20FBFB4 Offset: 0x20F7FB4 VA: 0x20FBFB4
	public bool get_IsUsableGuildStaff() { }

	// RVA: 0x20FC02C Offset: 0x20F802C VA: 0x20FC02C
	public bool get_IsAlliance() { }

	// RVA: 0x20FC0D8 Offset: 0x20F80D8 VA: 0x20FC0D8
	public float get_AllianceTimer() { }

	[CompilerGenerated]
	// RVA: 0x20FC188 Offset: 0x20F8188 VA: 0x20FC188
	public string get_AllianceGuildName() { }

	[CompilerGenerated]
	// RVA: 0x20FC190 Offset: 0x20F8190 VA: 0x20FC190
	private void set_AllianceGuildName(string value) { }

	// RVA: 0x20FC1A0 Offset: 0x20F81A0 VA: 0x20FC1A0
	public int get_AllianceInvitationNum() { }

	// RVA: 0x20FC1E8 Offset: 0x20F81E8 VA: 0x20FC1E8
	public IList<GuildMemberData> get_GuildMemberDataList() { }

	// RVA: 0x20FC290 Offset: 0x20F8290 VA: 0x20FC290
	public IList<GuildMemberRequestData> get_GuildMemberInvitationList() { }

	// RVA: 0x20FC338 Offset: 0x20F8338 VA: 0x20FC338
	public IList<GuildBBSRequesterData> get_GuildJoinRequesterList() { }

	// RVA: 0x20FC4C4 Offset: 0x20F84C4 VA: 0x20FC4C4
	private SystemTextManager get_systemTextManager() { }

	// RVA: 0x20FC5C0 Offset: 0x20F85C0 VA: 0x20FC5C0
	private PlayerDataManager get_playerDataManager() { }

	[CompilerGenerated]
	// RVA: 0x20FC648 Offset: 0x20F8648 VA: 0x20FC648
	public void add_ActionCallBack(Action value) { }

	[CompilerGenerated]
	// RVA: 0x20FC6E8 Offset: 0x20F86E8 VA: 0x20FC6E8
	public void remove_ActionCallBack(Action value) { }

	[CompilerGenerated]
	// RVA: 0x20FC788 Offset: 0x20F8788 VA: 0x20FC788
	public string get_GuildNameCheckFailureText() { }

	[CompilerGenerated]
	// RVA: 0x20FC790 Offset: 0x20F8790 VA: 0x20FC790
	private void set_GuildNameCheckFailureText(string value) { }

	// RVA: 0x20FC7A0 Offset: 0x20F87A0 VA: 0x20FC7A0
	public bool get_IsFirstMasterConnect() { }

	// RVA: 0x20FC7A8 Offset: 0x20F87A8 VA: 0x20FC7A8
	public void ChangeFirstMasterConnect() { }

	// RVA: 0x20FC7B8 Offset: 0x20F87B8 VA: 0x20FC7B8
	public GuildRaidManager get_RaidManager() { }

	// RVA: 0x20FC7C0 Offset: 0x20F87C0 VA: 0x20FC7C0
	public GuildFacilityManager get_FacilityManager() { }

	// RVA: 0x20FC7C8 Offset: 0x20F87C8 VA: 0x20FC7C8
	public void InitializeMenu(GuildGetDataResponse dataResponse) { }

	// RVA: 0x20FC9A0 Offset: 0x20F89A0 VA: 0x20FC9A0
	public void ReceiveMemberListData(GuildMemberData[] list) { }

	// RVA: 0x20FCE04 Offset: 0x20F8E04 VA: 0x20FCE04
	public void ReceiveMemberListData(GuildMemberListData[] list) { }

	// RVA: 0x20FD00C Offset: 0x20F900C VA: 0x20FD00C
	public bool LoginInitialize(GuildLoginData guildLogin, GuildReserveData[] guildReserve) { }

	// RVA: 0x20FD7B8 Offset: 0x20F97B8 VA: 0x20FD7B8
	private void InitializeReserveMember(GuildReserveData[] list) { }

	// RVA: 0x20FC894 Offset: 0x20F8894 VA: 0x20FC894
	public void GetRequestersList() { }

	// RVA: 0x20FEA10 Offset: 0x20FAA10 VA: 0x20FEA10
	private void InitializeJoinRequesterList(GuildBBSRequesterData[] list) { }

	// RVA: 0x20FEB68 Offset: 0x20FAB68 VA: 0x20FEB68
	public void ErrGuildJoint() { }

	// RVA: 0x20FDA00 Offset: 0x20F9A00 VA: 0x20FDA00
	public void Reset() { }

	// RVA: 0x20FEB8C Offset: 0x20FAB8C VA: 0x20FEB8C
	public void InitializeGuildBooster(GuildBoosterData data) { }

	// RVA: 0x20FF1C4 Offset: 0x20FB1C4 VA: 0x20FF1C4
	public void LeaveField() { }

	[CompilerGenerated]
	// RVA: 0x20FF26C Offset: 0x20FB26C VA: 0x20FF26C
	public byte get_EnterGuildRaidLobbyElement() { }

	[CompilerGenerated]
	// RVA: 0x20FF274 Offset: 0x20FB274 VA: 0x20FF274
	private void set_EnterGuildRaidLobbyElement(byte value) { }

	// RVA: 0x20FF27C Offset: 0x20FB27C VA: 0x20FF27C
	public void ErrEnterGuildFieldNotRoom() { }

	// RVA: 0x20FF288 Offset: 0x20FB288 VA: 0x20FF288
	public void EnterGuildRaidLobbyActiveElement(byte element) { }

	// RVA: 0x20FF290 Offset: 0x20FB290 VA: 0x20FF290
	public void OperationGuildHomeEnter(bool isMyGuild = True) { }

	// RVA: 0x20FF3D8 Offset: 0x20FB3D8 VA: 0x20FF3D8
	public void OperationRaidLobbyEnter(bool isMyGuild = True) { }

	// RVA: 0x20FF4B8 Offset: 0x20FB4B8 VA: 0x20FF4B8
	public bool ReenterGuildField() { }

	// RVA: 0x20FF6A0 Offset: 0x20FB6A0 VA: 0x20FF6A0
	public bool Create(PlayerDataManager playerManager, string guildName) { }

	// RVA: 0x20FF818 Offset: 0x20FB818 VA: 0x20FF818
	public bool Invitation(int targetId, string message, string targetName, Action callback) { }

	// RVA: 0x20FF94C Offset: 0x20FB94C VA: 0x20FF94C
	public bool InvitationCancel(int targetId) { }

	// RVA: 0x20FE638 Offset: 0x20FA638 VA: 0x20FE638
	private void InvitationAllCancel() { }

	// RVA: 0x20FFA10 Offset: 0x20FBA10 VA: 0x20FFA10
	public void Acceptance(int guildId, Action callback) { }

	// RVA: 0x20FFAA0 Offset: 0x20FBAA0 VA: 0x20FFAA0
	public void Reject(int guildId, Action callback) { }

	// RVA: 0x20FFB18 Offset: 0x20FBB18 VA: 0x20FFB18
	public bool Secede() { }

	// RVA: 0x20FFBC4 Offset: 0x20FBBC4 VA: 0x20FFBC4
	public bool Exile(int targetId) { }

	// RVA: 0x20FFC5C Offset: 0x20FBC5C VA: 0x20FFC5C
	public bool Dissolution() { }

	// RVA: 0x20FFD38 Offset: 0x20FBD38 VA: 0x20FFD38
	public bool UpdateBoard(byte type, string message) { }

	// RVA: 0x20FFDD8 Offset: 0x20FBDD8 VA: 0x20FFDD8
	public bool ChangeAuthority(int targetId, byte authority) { }

	// RVA: 0x20FFF58 Offset: 0x20FBF58 VA: 0x20FFF58
	public bool ChangeName(string newName) { }

	// RVA: 0x20FFFE8 Offset: 0x20FBFE8 VA: 0x20FFFE8
	public bool TransferGuildMaster(int id) { }

	// RVA: 0x2100080 Offset: 0x20FC080 VA: 0x2100080
	public bool CandidacyGuildMaster(int id) { }

	// RVA: 0x210011C Offset: 0x20FC11C VA: 0x210011C
	public bool UpdateGuildMemberList(float updateTimer) { }

	// RVA: 0x2100210 Offset: 0x20FC210 VA: 0x2100210
	public bool ChangeOnlineNotice() { }

	// RVA: 0x21002B4 Offset: 0x20FC2B4 VA: 0x21002B4
	public void CreateResponse(GuildCreateResponse response) { }

	// RVA: 0x2100374 Offset: 0x20FC374 VA: 0x2100374
	public void InvitationResponse() { }

	// RVA: 0x21003B4 Offset: 0x20FC3B4 VA: 0x21003B4
	public void InvitationCancelResponse(GuildInviteSenderCancelResponse response) { }

	// RVA: 0x2100668 Offset: 0x20FC668 VA: 0x2100668
	public void RejectResponse(int guildId) { }

	// RVA: 0x21007E0 Offset: 0x20FC7E0 VA: 0x21007E0
	public void AcceptanceResponse(int guildId, string guildName, int[] memberIdList) { }

	// RVA: 0x2100BB0 Offset: 0x20FCBB0 VA: 0x2100BB0
	public void JoinResponse(int guildId, string guildName, int[] memberIdList) { }

	// RVA: 0x2100E04 Offset: 0x20FCE04 VA: 0x2100E04
	public void ExileResponse() { }

	// RVA: 0x2100E08 Offset: 0x20FCE08 VA: 0x2100E08
	public void SecedeResponse() { }

	// RVA: 0x2100F64 Offset: 0x20FCF64 VA: 0x2100F64
	public void DissolutionResponse() { }

	// RVA: 0x2101184 Offset: 0x20FD184 VA: 0x2101184
	public void UpdateAuthority(int targetId, byte authority, bool isEvent) { }

	// RVA: 0x21012C0 Offset: 0x20FD2C0 VA: 0x21012C0
	public void TransferGuildMasterResponse(int targetId, byte tagetPost, int senderId, byte senderPost) { }

	// RVA: 0x2101538 Offset: 0x20FD538 VA: 0x2101538
	public void CandidacyGuildMasterResponse(int targetId, byte tagetPost, int senderId, byte senderPost) { }

	// RVA: 0x2101700 Offset: 0x20FD700 VA: 0x2101700
	public void EventTransferGuildMasterResponse(int targetId, byte tagetPost, int senderId, byte senderPost) { }

	// RVA: 0x2101998 Offset: 0x20FD998 VA: 0x2101998
	public void EventCandidacyGuildMasterResponse(int targetId, byte tagetPost, int senderId, byte senderPost) { }

	// RVA: 0x2101C34 Offset: 0x20FDC34 VA: 0x2101C34
	public void ReturnOperationFailure() { }

	// RVA: 0x2101D18 Offset: 0x20FDD18 VA: 0x2101D18
	public void EventGuildRunBoosterResponse(GuildRunBoosterEvent boosterEvent) { }

	// RVA: 0x210229C Offset: 0x20FE29C VA: 0x210229C
	public void EventGuildPresentResponse(GuildPresentEvent presentEvent) { }

	// RVA: 0x2102360 Offset: 0x20FE360 VA: 0x2102360
	public void ChangeOnlineNoticeResponse() { }

	// RVA: 0x21023BC Offset: 0x20FE3BC VA: 0x21023BC
	public bool TryGetFieldActiveRaid(out int raidId) { }

	// RVA: 0x2102564 Offset: 0x20FE564 VA: 0x2102564
	public bool TryGetFieldActiveRaidElemet(out byte element) { }

	// RVA: 0x2102640 Offset: 0x20FE640 VA: 0x2102640
	public void AddRequest(GuildReserveData requestData) { }

	// RVA: 0x210286C Offset: 0x20FE86C VA: 0x210286C
	public void OnInvitationCancel(GuildInviteSenderCancelEvent events) { }

	// RVA: 0x21029B0 Offset: 0x20FE9B0 VA: 0x21029B0
	public void AddJoinRequest(GuildBBSJoinRequestEvent requestEvent) { }

	// RVA: 0x2102AC8 Offset: 0x20FEAC8 VA: 0x2102AC8
	public void RemoveJoinRequest(int id) { }

	// RVA: 0x2102B4C Offset: 0x20FEB4C VA: 0x2102B4C
	public void OnJoin(GuildJoinEvent join) { }

	// RVA: 0x2102F44 Offset: 0x20FEF44 VA: 0x2102F44
	public void OnJoin(GuildBBSJoinEvent join) { }

	// RVA: 0x21032A8 Offset: 0x20FF2A8 VA: 0x21032A8
	public void OnSecede(GuildSecedeEvent secede) { }

	// RVA: 0x2103480 Offset: 0x20FF480 VA: 0x2103480
	public void OnExile(GuildExileEvent exile, PlayerDataManager playerManager) { }

	// RVA: 0x21037B8 Offset: 0x20FF7B8 VA: 0x21037B8
	public void OnChangeName(GuildNameChangeEvent changeName) { }

	// RVA: 0x21037D4 Offset: 0x20FF7D4 VA: 0x21037D4
	public void OnLevelUp(GuildLevelUpEvent levelUp) { }

	// RVA: 0x2103888 Offset: 0x20FF888 VA: 0x2103888
	public void AddGuildPoint(int point) { }

	// RVA: 0x21021E4 Offset: 0x20FE1E4 VA: 0x21021E4
	public void ChangeGuildPoint(int point) { }

	// RVA: 0x2103948 Offset: 0x20FF948 VA: 0x2103948
	public bool LoginGuildMessageUpdate(bool firstLogin, GuildLoginData loginData) { }

	// RVA: 0x2103A74 Offset: 0x20FFA74 VA: 0x2103A74
	public void EventGuildUpdateVariableData(GuildVariableData[] list) { }

	// RVA: 0x2104160 Offset: 0x2100160 VA: 0x2104160
	public void UpdateGuildTenantType() { }

	// RVA: 0x21041BC Offset: 0x21001BC VA: 0x21041BC
	public void UpdateHomeRenovationId(byte renovationId) { }

	// RVA: 0x21041C4 Offset: 0x21001C4 VA: 0x21041C4
	public void UpdateHomeOpenFlag(long openFlag) { }

	// RVA: 0x21041CC Offset: 0x21001CC VA: 0x21041CC
	public void UpdateAllianceData(bool isAdd, int allianceId, GuildAllianceInvitationData data) { }

	// RVA: 0x20FE850 Offset: 0x20FA850 VA: 0x20FE850
	public void SetAlliancGuildData(GuildAllianceData allianceData) { }

	// RVA: 0x2104830 Offset: 0x2100830 VA: 0x2104830
	public void UpdateAlliancGuildData(DateTime startTime, DateTime endCoolTime, GuildInfoData alliancGuildData) { }

	// RVA: 0x21044C4 Offset: 0x21004C4 VA: 0x21044C4
	public void UpdateAlliancGuildData(GuildInfoData alliancGuildData) { }

	// RVA: 0x2103C28 Offset: 0x20FFC28 VA: 0x2103C28
	public void UpdateAlliancGuildChatLink(DateTime updateAlliancTime, DateTime updateGuildTime) { }

	// RVA: 0x2104AC0 Offset: 0x2100AC0 VA: 0x2104AC0
	public void OpenAllianceInvitationMenu() { }

	// RVA: 0x2104C14 Offset: 0x2100C14 VA: 0x2104C14
	public bool CheckEnterGuildField(int id, FieldRoomType room) { }

	// RVA: 0x2104C54 Offset: 0x2100C54 VA: 0x2104C54
	private void updateMemberState(int archetypeId, byte state) { }

	// RVA: 0x20FF8F4 Offset: 0x20FB8F4 VA: 0x20FF8F4
	public bool ContainsMember(int targetId) { }

	// RVA: 0x2104DA4 Offset: 0x2100DA4 VA: 0x2104DA4
	public void AddMember(int archetypeId) { }

	// RVA: 0x20FFEE0 Offset: 0x20FBEE0 VA: 0x20FFEE0
	public GuildMemberData GetMember(int targetId) { }

	// RVA: 0x2100610 Offset: 0x20FC610 VA: 0x2100610
	public bool RemoveMember(int targetId) { }

	// RVA: 0x2104E24 Offset: 0x2100E24 VA: 0x2104E24
	public short GetMaxMagicGauge() { }

	// RVA: 0x20FBB38 Offset: 0x20F7B38 VA: 0x20FBB38
	public int GetLevelExp(int level) { }

	// RVA: 0x2104E44 Offset: 0x2100E44 VA: 0x2104E44
	public void GuildCheckNameOperationFailure(GameReturnCode code) { }

	// RVA: 0x2105118 Offset: 0x2101118 VA: 0x2105118
	public void ResetGuildCheckNameOperationFailure() { }

	// RVA: 0x2105268 Offset: 0x2101268 VA: 0x2105268
	public void SetGuildContributionData(GuildCheckContributionResponse response) { }

	// RVA: 0x2105270 Offset: 0x2101270 VA: 0x2105270
	public void SettingTenant(bool flag, int updateTenant) { }

	// RVA: 0x2105310 Offset: 0x2101310 VA: 0x2105310
	public short ContributeGold(UIBasePanel panel, int point) { }

	// RVA: 0x21053C0 Offset: 0x21013C0 VA: 0x21053C0
	public void SetOnlineNotice(byte type) { }

	// RVA: 0x21053C8 Offset: 0x21013C8 VA: 0x21053C8
	public int GetBoosterRate(GuildBoosterType type) { }

	// RVA: 0x2105460 Offset: 0x2101460 VA: 0x2105460
	public NewArchetypeProperties GetGuildStaffArchetypeProperties(bool isMyGuild = True) { }

	// RVA: 0x210589C Offset: 0x210189C VA: 0x210589C
	public GuildStaffEquipData[] GetGuildStaffEquipData() { }

	// RVA: 0x2105904 Offset: 0x2101904 VA: 0x2105904
	public string GetGuildStaffName() { }

	// RVA: 0x21059AC Offset: 0x21019AC VA: 0x21059AC
	public bool IsGuildStaffSupport(GuildStaffSupportType supprt) { }

	// RVA: 0x2105C38 Offset: 0x2101C38 VA: 0x2105C38
	public void GuildStaffRecoverySupport() { }

	// RVA: 0x2105D70 Offset: 0x2101D70 VA: 0x2105D70
	public void ReceiveGuildStaffRecoverySupport(int hp, int exHp, int healHp) { }

	// RVA: 0x2105E28 Offset: 0x2101E28 VA: 0x2105E28
	public string GetGuildStaffUpdateUser(GuildStaffChangeType type) { }

	// RVA: 0x2105EF8 Offset: 0x2101EF8 VA: 0x2105EF8
	public string GetGuildStaffLockRequestUserName() { }

	// RVA: 0x2105F88 Offset: 0x2101F88 VA: 0x2105F88
	public void UpdateRequestLockUser(int id) { }

	// RVA: 0x2105F90 Offset: 0x2101F90 VA: 0x2105F90
	public TimeSpan GetGuildStaffHireLeftTime() { }

	// RVA: 0x2106030 Offset: 0x2102030 VA: 0x2106030
	public bool GetGuildStaffHireSummonFlag() { }

	// RVA: 0x21060BC Offset: 0x21020BC VA: 0x21060BC
	private bool IsHireFlag(GuildStaffFlag flag) { }

	// RVA: 0x21060CC Offset: 0x21020CC VA: 0x21060CC
	public bool ChangeStaffHireSummonFlag(bool flag) { }

	// RVA: 0x2105AF8 Offset: 0x2101AF8 VA: 0x2105AF8
	private bool IsGuildStaffTrace() { }

	// RVA: 0x21061A0 Offset: 0x21021A0 VA: 0x21061A0
	public void ReceiveGuildStaffHireData(GuildStaffHireData data) { }

	// RVA: 0x2106334 Offset: 0x2102334 VA: 0x2106334
	public void ReceiveGuildStaffHireData(int hireLeftTime, byte flag) { }

	// RVA: 0x2106458 Offset: 0x2102458 VA: 0x2106458
	public void GuildStaffHireErrandLeftTimeUpdate(int timer) { }

	// RVA: 0x2106524 Offset: 0x2102524 VA: 0x2106524
	public void ReceiveGuildStaffEquipData(GuildUpdateStaffDataEvent response) { }

	// RVA: 0x21068CC Offset: 0x21028CC VA: 0x21068CC
	public void ReceiveGuildStaffData(GuildGetStaffDataResponse response) { }

	// RVA: 0x21068F8 Offset: 0x21028F8 VA: 0x21068F8
	public void ReceiveGuildStaffFlag(byte flag) { }

	// RVA: 0x2106900 Offset: 0x2102900 VA: 0x2106900
	public void GuildStaffChangeSupport(byte type) { }

	// RVA: 0x2106974 Offset: 0x2102974 VA: 0x2106974
	public void ReceiveGuildSupportType(byte type) { }

	// RVA: 0x21066F0 Offset: 0x21026F0 VA: 0x21066F0
	private void CreateStaffObject(bool isMyGuild = True) { }

	// RVA: 0x20FDCF4 Offset: 0x20F9CF4 VA: 0x20FDCF4
	private void RemoveGuildStaff(float timer, bool isMyGuild = True) { }

	// RVA: 0x20FDEBC Offset: 0x20F9EBC VA: 0x20FDEBC
	public void UpdateGuildStaff(bool isEnter) { }

	// RVA: 0x210698C Offset: 0x210298C VA: 0x210698C
	public bool IsGuildStaffWaitingAction() { }

	// RVA: 0x2106A1C Offset: 0x2102A1C VA: 0x2106A1C
	public void GuildStaffChangeWaitingAction(bool isStop) { }

	// RVA: 0x20FE574 Offset: 0x20FA574 VA: 0x20FE574
	public void UpdateServerFacilityData(GuildFacilityData[] serverDatas) { }

	// RVA: 0x2106ABC Offset: 0x2102ABC VA: 0x2106ABC
	public void UpdateServerActiveFacilityData() { }

	// RVA: 0x2106BE8 Offset: 0x2102BE8 VA: 0x2106BE8
	public bool CheckOpenBgm(short recipeId) { }

	// RVA: 0x2104074 Offset: 0x2100074 VA: 0x2104074
	public void UpdateHomeBgmData(byte type, int value) { }

	// RVA: 0x2106CB4 Offset: 0x2102CB4 VA: 0x2106CB4
	public void SetHomeBgmOpenData(short recipeId) { }

	// RVA: 0x2106DC0 Offset: 0x2102DC0 VA: 0x2106DC0
	public void SetHomeBGMId(int bgmId) { }

	// RVA: 0x2106E1C Offset: 0x2102E1C VA: 0x2106E1C
	public void LoadHomeBGMId() { }

	// RVA: 0x20FEB70 Offset: 0x20FAB70 VA: 0x20FEB70
	private void SetDefaultHomeBGMIdData() { }

	// RVA: 0x2106E70 Offset: 0x2102E70 VA: 0x2106E70
	public static void DeleteHomeBGMId() { }

	// RVA: 0x2106ED0 Offset: 0x2102ED0 VA: 0x2106ED0
	public void .ctor() { }

	[IteratorStateMachine(typeof(GuildManager.<<UpdateAlliancGuildChatLink>g__ChatWait|272_0>d))]
	[CompilerGenerated]
	// RVA: 0x2104A44 Offset: 0x2100A44 VA: 0x2104A44
	private IEnumerator <UpdateAlliancGuildChatLink>g__ChatWait|272_0(byte currentIndex) { }
}
