// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GameUserDataManager : Singleton<GameUserDataManager>, ISceneChangeManager // TypeDefIndex: 4144
{
	// Fields
	private readonly int[] appsFlyerLevelUpList; // 0x20
	[SerializeField]
	private GameRecordManager gameRecordManager; // 0x28
	[SerializeField]
	private QuestManager questManager; // 0x30
	[SerializeField]
	private FriendManager friendManager; // 0x38
	[SerializeField]
	private GuildManager guildManager; // 0x40
	[SerializeField]
	private MaterialManager materialManager; // 0x48
	[SerializeField]
	private BanManager banManager; // 0x50
	[SerializeField]
	private StampManager stampManager; // 0x58
	[SerializeField]
	private MiniMailManager miniMailManager; // 0x60
	private bool getMailFlag; // 0x68
	private float getMailConnectTime; // 0x6C
	private WorldTreasureManager worldTreasureManager; // 0x70
	private Dictionary<byte, int> avatarVariable; // 0x78
	private OnceFlagManager onceFlagManager; // 0x80
	private LoginTermFlag loginTermFlag; // 0x88
	private List<EmotionPlayer.EmotionType> playEmotionList; // 0x90
	private int accountLevel; // 0x98
	[CompilerGenerated]
	private bool <IsAsobiMarket>k__BackingField; // 0x9C
	[CompilerGenerated]
	private BazaarManager <BazaarManager>k__BackingField; // 0xA0
	[CompilerGenerated]
	private bool <IsComeBackCampaignNotification>k__BackingField; // 0xA8
	[CompilerGenerated]
	private bool <IsEnableBazaar>k__BackingField; // 0xA9
	[CompilerGenerated]
	private int <UserId>k__BackingField; // 0xAC
	[CompilerGenerated]
	private string <UserName>k__BackingField; // 0xB0

	// Properties
	public bool IsAsobiMarket { get; set; }
	public GameRecordManager GameRecordManager { get; }
	public QuestManager QuestManager { get; }
	public FriendManager FriendManager { get; }
	public GuildManager GuildManager { get; }
	public MaterialManager MaterialManager { get; }
	public BanManager BanManager { get; }
	public MiniMailManager MiniMailManager { get; }
	public WorldTreasureManager WorldTreasureManager { get; }
	public StampManager StampManager { get; }
	public OnceFlagManager OnceFlagManager { get; }
	public BazaarManager BazaarManager { get; set; }
	public int AccountLevel { get; }
	public bool IsComeBackPlayer { get; }
	public int AvatarVariableInquiryCount { get; }
	public bool IsResetCompensationUser { get; }
	public int GuildRaidStamina { get; }
	public bool IsGuildFacilityFlag { get; }
	public int CollectItemSlot { get; }
	public int AvatarVariableFriendOnLineNotice { get; }
	public int AvatarVariableGuildOnLineNotice { get; }
	public int GetExpansionFriendSlot { get; }
	public bool IsBeginner { get; }
	public bool IsDailyBeginnerOrbShop { get; }
	public bool IsComeBackCampaignNotification { get; set; }
	public bool IsEnableBazaar { get; set; }
	public int UserId { get; set; }
	public string UserName { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x247A6DC Offset: 0x24766DC VA: 0x247A6DC
	public bool get_IsAsobiMarket() { }

	[CompilerGenerated]
	// RVA: 0x247A6E4 Offset: 0x24766E4 VA: 0x247A6E4
	private void set_IsAsobiMarket(bool value) { }

	// RVA: 0x247A6F0 Offset: 0x24766F0 VA: 0x247A6F0
	public GameRecordManager get_GameRecordManager() { }

	// RVA: 0x247A6F8 Offset: 0x24766F8 VA: 0x247A6F8
	public QuestManager get_QuestManager() { }

	// RVA: 0x247A700 Offset: 0x2476700 VA: 0x247A700
	public FriendManager get_FriendManager() { }

	// RVA: 0x247A708 Offset: 0x2476708 VA: 0x247A708
	public GuildManager get_GuildManager() { }

	// RVA: 0x247A710 Offset: 0x2476710 VA: 0x247A710
	public MaterialManager get_MaterialManager() { }

	// RVA: 0x247A718 Offset: 0x2476718 VA: 0x247A718
	public BanManager get_BanManager() { }

	// RVA: 0x247A720 Offset: 0x2476720 VA: 0x247A720
	public MiniMailManager get_MiniMailManager() { }

	// RVA: 0x247A728 Offset: 0x2476728 VA: 0x247A728
	public WorldTreasureManager get_WorldTreasureManager() { }

	// RVA: 0x247A730 Offset: 0x2476730 VA: 0x247A730
	public StampManager get_StampManager() { }

	// RVA: 0x247A738 Offset: 0x2476738 VA: 0x247A738
	public OnceFlagManager get_OnceFlagManager() { }

	[CompilerGenerated]
	// RVA: 0x247A740 Offset: 0x2476740 VA: 0x247A740
	public BazaarManager get_BazaarManager() { }

	[CompilerGenerated]
	// RVA: 0x247A748 Offset: 0x2476748 VA: 0x247A748
	private void set_BazaarManager(BazaarManager value) { }

	// RVA: 0x247A750 Offset: 0x2476750 VA: 0x247A750
	public int get_AccountLevel() { }

	// RVA: 0x247A758 Offset: 0x2476758 VA: 0x247A758
	public bool get_IsComeBackPlayer() { }

	// RVA: 0x247A7CC Offset: 0x24767CC VA: 0x247A7CC
	public int get_AvatarVariableInquiryCount() { }

	// RVA: 0x247A8D8 Offset: 0x24768D8 VA: 0x247A8D8
	public bool get_IsResetCompensationUser() { }

	// RVA: 0x247A98C Offset: 0x247698C VA: 0x247A98C
	public int get_GuildRaidStamina() { }

	// RVA: 0x247AA54 Offset: 0x2476A54 VA: 0x247AA54
	public bool get_IsGuildFacilityFlag() { }

	// RVA: 0x247AB24 Offset: 0x2476B24 VA: 0x247AB24
	public int get_CollectItemSlot() { }

	// RVA: 0x247ABEC Offset: 0x2476BEC VA: 0x247ABEC
	public int get_AvatarVariableFriendOnLineNotice() { }

	// RVA: 0x247AC5C Offset: 0x2476C5C VA: 0x247AC5C
	public int get_AvatarVariableGuildOnLineNotice() { }

	// RVA: 0x247ACCC Offset: 0x2476CCC VA: 0x247ACCC
	public int GetMotionFlag(byte type) { }

	// RVA: 0x247AD40 Offset: 0x2476D40 VA: 0x247AD40
	public int get_GetExpansionFriendSlot() { }

	// RVA: 0x247AE08 Offset: 0x2476E08 VA: 0x247AE08
	public void UpdateAvatarVariable(Dictionary<byte, int> update) { }

	// RVA: 0x247AF60 Offset: 0x2476F60 VA: 0x247AF60
	public void UpdateAvatarVariable(byte type, int value) { }

	// RVA: 0x247B01C Offset: 0x247701C VA: 0x247B01C
	public bool CheckAvatarVariableOption(OptionSettingCode code) { }

	// RVA: 0x247B09C Offset: 0x247709C VA: 0x247B09C
	public void UpdateAvatarVariableOption(OptionSettingCode code, bool flag) { }

	// RVA: 0x247B17C Offset: 0x247717C VA: 0x247B17C
	public void RemoveUpdateAvatarVariableInquiryCount() { }

	// RVA: 0x247B210 Offset: 0x2477210 VA: 0x247B210
	public void LockCompensationFlag() { }

	// RVA: 0x247B268 Offset: 0x2477268 VA: 0x247B268
	public void ActiveCompensationFlag() { }

	// RVA: 0x247B2C0 Offset: 0x24772C0 VA: 0x247B2C0
	public bool get_IsBeginner() { }

	// RVA: 0x247B2D4 Offset: 0x24772D4 VA: 0x247B2D4
	public bool get_IsDailyBeginnerOrbShop() { }

	[CompilerGenerated]
	// RVA: 0x247B2F0 Offset: 0x24772F0 VA: 0x247B2F0
	public bool get_IsComeBackCampaignNotification() { }

	[CompilerGenerated]
	// RVA: 0x247B2F8 Offset: 0x24772F8 VA: 0x247B2F8
	public void set_IsComeBackCampaignNotification(bool value) { }

	[CompilerGenerated]
	// RVA: 0x247B304 Offset: 0x2477304 VA: 0x247B304
	public bool get_IsEnableBazaar() { }

	[CompilerGenerated]
	// RVA: 0x247B30C Offset: 0x247730C VA: 0x247B30C
	private void set_IsEnableBazaar(bool value) { }

	[CompilerGenerated]
	// RVA: 0x247B318 Offset: 0x2477318 VA: 0x247B318
	public int get_UserId() { }

	[CompilerGenerated]
	// RVA: 0x247B320 Offset: 0x2477320 VA: 0x247B320
	private void set_UserId(int value) { }

	[CompilerGenerated]
	// RVA: 0x247B328 Offset: 0x2477328 VA: 0x247B328
	public string get_UserName() { }

	[CompilerGenerated]
	// RVA: 0x247B330 Offset: 0x2477330 VA: 0x247B330
	private void set_UserName(string value) { }

	// RVA: 0x247B338 Offset: 0x2477338 VA: 0x247B338
	private void Awake() { }

	// RVA: 0x247B618 Offset: 0x2477618 VA: 0x247B618
	private void Update() { }

	// RVA: 0x247B6C8 Offset: 0x24776C8 VA: 0x247B6C8
	public void GameJoinMain(IAccountUserData accountUserData, IAccountGameData accountGameData, IGuildGameData guildGameData) { }

	// RVA: 0x247BD08 Offset: 0x2477D08 VA: 0x247BD08 Slot: 4
	public void OnEnter() { }

	// RVA: 0x247BE70 Offset: 0x2477E70 VA: 0x247BE70 Slot: 5
	public void OnLeave() { }

	// RVA: 0x247BE8C Offset: 0x2477E8C VA: 0x247BE8C
	public List<EmotionPlayer.EmotionType> GetUserEmotionList() { }

	// RVA: 0x247BFCC Offset: 0x2477FCC VA: 0x247BFCC
	public bool CheckPlayUserEmotion(EmotionPlayer.EmotionType emotionType) { }

	// RVA: 0x247C0B0 Offset: 0x24780B0 VA: 0x247C0B0
	public void UpdateAccountLevel(int level) { }

	// RVA: 0x247C28C Offset: 0x247828C VA: 0x247C28C
	public void ReceiveAccuntLevel(int level) { }

	[IteratorStateMachine(typeof(GameUserDataManager.<LoadGuildHomeBGM>d__102))]
	// RVA: 0x247C294 Offset: 0x2478294 VA: 0x247C294
	public IEnumerator LoadGuildHomeBGM() { }

	// RVA: 0x247C308 Offset: 0x2478308 VA: 0x247C308
	public void PlayGuildHomeBGM(bool isForce = False) { }

	// RVA: 0x247C3A0 Offset: 0x24783A0 VA: 0x247C3A0
	public void .ctor() { }
}
