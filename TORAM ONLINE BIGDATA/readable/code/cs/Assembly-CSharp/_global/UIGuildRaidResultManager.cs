// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGuildRaidResultManager : UIBasePanelConnection // TypeDefIndex: 5764
{
	// Fields
	[SerializeField]
	private GameObject effectButton; // 0x30
	[SerializeField]
	private GameObject modelParent; // 0x38
	[SerializeField]
	private UILabel bossNameLabel; // 0x40
	[SerializeField]
	private UILabel battleTimeLabel; // 0x48
	[SerializeField]
	private UILabel sTrophyTypeLabel; // 0x50
	[SerializeField]
	private UILabel trophyTypeLabel; // 0x58
	[SerializeField]
	private UILabel trophyTypeRankingLabel; // 0x60
	[SerializeField]
	private UILabel rankingLabel; // 0x68
	[SerializeField]
	private UILabel playerNameLabel; // 0x70
	[SerializeField]
	private UILabel playerLevelLabel; // 0x78
	[SerializeField]
	private UISprite trophyIconSprite; // 0x80
	[SerializeField]
	private GameObject resultPanl; // 0x88
	[SerializeField]
	private GameObject resultBaseBar; // 0x90
	private UISprite[] resultBar; // 0x98
	[SerializeField]
	private GameObject deadPenaltyLabel; // 0xA0
	[SerializeField]
	private UISprite[] staminaIcons; // 0xA8
	[SerializeField]
	private GameObject noUser; // 0xB0
	[SerializeField]
	private GameObject popWindow; // 0xB8
	[SerializeField]
	private UILabel[] heartsLabels; // 0xC0
	[SerializeField]
	private UILabel resultHeartLabel; // 0xC8
	[SerializeField]
	private UILabel resultTextLabel; // 0xD0
	[SerializeField]
	private UISprite[] resultHeartIcon; // 0xD8
	[SerializeField]
	private UISprite[] resultHeartBar; // 0xE0
	[SerializeField]
	private GameObject nonItemPanel; // 0xE8
	[SerializeField]
	private GameObject resultItemPanel; // 0xF0
	[SerializeField]
	private GameObject[] resutlItemPanel; // 0xF8
	[SerializeField]
	private GameObject[] practicePanels; // 0x100
	[SerializeField]
	private GameObject[] playPanels; // 0x108
	private UIGuildRaidResultManager.BossTrophy selectTrophyType; // 0x110
	private PlayerDataManager playerDataManager; // 0x118
	private BossResultData bossResultData; // 0x120
	private const int TrophyNum = 5;
	[CompilerGenerated]
	private bool <IsClose>k__BackingField; // 0x128
	private Dictionary<int, GameObject> topPlayerModel; // 0x130
	private GameObject targetObject; // 0x138
	private ChatChannelType saveChatType; // 0x140
	private int vewUserNum; // 0x144
	private byte panelState; // 0x148
	private GuildRaidRoomData roomData; // 0x150
	private bool isPractice; // 0x158

	// Properties
	public bool IsClose { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x17E16B0 Offset: 0x17DD6B0 VA: 0x17E16B0
	public bool get_IsClose() { }

	[CompilerGenerated]
	// RVA: 0x17E16B8 Offset: 0x17DD6B8 VA: 0x17E16B8
	private void set_IsClose(bool value) { }

	// RVA: 0x17E16C4 Offset: 0x17DD6C4 VA: 0x17E16C4
	public void Initialize(int uid, short level) { }

	// RVA: 0x17E3090 Offset: 0x17DF090 VA: 0x17E3090
	private void OnDestroy() { }

	// RVA: 0x17E3270 Offset: 0x17DF270 VA: 0x17E3270
	public void ChnageSelect(int add) { }

	// RVA: 0x17E32DC Offset: 0x17DF2DC VA: 0x17E32DC
	private void UpdateMerge() { }

	// RVA: 0x17E25AC Offset: 0x17DE5AC VA: 0x17E25AC
	private bool UpdateResult(UIGuildRaidResultManager.BossTrophy trophyType) { }

	// RVA: 0x17E364C Offset: 0x17DF64C VA: 0x17E364C
	private void PopResultPointWindow() { }

	// RVA: 0x17E3CE0 Offset: 0x17DFCE0 VA: 0x17E3CE0
	private bool ResultItemPop(int index, int itemId, int num) { }

	// RVA: 0x17E3EF4 Offset: 0x17DFEF4 VA: 0x17E3EF4 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x17E4070 Offset: 0x17E0070 VA: 0x17E4070 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x17E412C Offset: 0x17E012C VA: 0x17E412C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x17E428C Offset: 0x17E028C VA: 0x17E428C
	private void <PopResultPointWindow>b__49_0() { }

	[CompilerGenerated]
	// RVA: 0x17E42F4 Offset: 0x17E02F4 VA: 0x17E42F4
	private bool <OnLeftTopButton>b__51_0() { }
}
