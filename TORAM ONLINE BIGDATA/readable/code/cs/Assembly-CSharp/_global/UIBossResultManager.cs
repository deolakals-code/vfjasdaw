// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIBossResultManager : UIBasePanel // TypeDefIndex: 6380
{
	// Fields
	[SerializeField]
	private GameObject modelParent; // 0x30
	[SerializeField]
	private UILabel bossNameLabel; // 0x38
	[SerializeField]
	private UILabel battleTimeLabel; // 0x40
	[SerializeField]
	private UILabel sTrophyTypeLabel; // 0x48
	[SerializeField]
	private UILabel trophyTypeLabel; // 0x50
	[SerializeField]
	private UILabel trophyTypeRankingLabel; // 0x58
	[SerializeField]
	private UILabel rankingLabel; // 0x60
	[SerializeField]
	private UILabel playerNameLabel; // 0x68
	[SerializeField]
	private UILabel playerLevelLabel; // 0x70
	[SerializeField]
	private UISprite trophyIconSprite; // 0x78
	[SerializeField]
	private GameObject resultPanl; // 0x80
	[SerializeField]
	private GameObject resultBaseBar; // 0x88
	private UISprite[] resultBar; // 0x90
	[SerializeField]
	private GameObject deadPenaltyLabel; // 0x98
	private UIBossResultManager.BossTrophy selectTrophyType; // 0xA0
	[SerializeField]
	private GameObject leftTopEffectButton; // 0xA8
	[SerializeField]
	private UILabel bossResultItemLabel; // 0xB0
	[SerializeField]
	private UIIcon bossResultItemIcon; // 0xB8
	private BossResultData bossResultData; // 0xC0
	private const int TrophyNum = 5;
	private bool isMerged; // 0xC8
	[CompilerGenerated]
	private bool <IsClose>k__BackingField; // 0xC9
	private Dictionary<int, GameObject> topPlayerModel; // 0xD0
	private GameObject targetObject; // 0xD8
	[SerializeField]
	private GameObject noUser; // 0xE0
	private ChatChannelType saveChatType; // 0xE8
	[SerializeField]
	private GameObject[] defaultPanelList; // 0xF0
	[SerializeField]
	private GameObject highRaidPanel; // 0xF8
	[SerializeField]
	private GameObject highRaidNextButton; // 0x100
	[SerializeField]
	private GameObject highRaidResultPanel; // 0x108
	[SerializeField]
	private GameObject[] highRaidPointList; // 0x110
	[SerializeField]
	private GameObject[] highRaidLevelBonusList; // 0x118
	private bool isHighRaid; // 0x120
	private const int baseDefeatPoint = 100;
	private const int basePartsPoint = 30;
	private int[] highRaidResultPoints; // 0x128
	private bool isSoro; // 0x130
	private int vewUserNum; // 0x134

	// Properties
	public bool IsClose { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x191612C Offset: 0x191212C VA: 0x191612C
	public bool get_IsClose() { }

	[CompilerGenerated]
	// RVA: 0x1916134 Offset: 0x1912134 VA: 0x1916134
	private void set_IsClose(bool value) { }

	// RVA: 0x1916140 Offset: 0x1912140 VA: 0x1916140
	public void Initialize(int uid, short level) { }

	// RVA: 0x1917FC0 Offset: 0x1913FC0 VA: 0x1917FC0
	private void OnDestroy() { }

	// RVA: 0x19181A0 Offset: 0x19141A0 VA: 0x19181A0
	public void ChnageSelect(int add) { }

	// RVA: 0x191820C Offset: 0x191420C VA: 0x191820C
	private void UpdateMerge() { }

	// RVA: 0x19174DC Offset: 0x19134DC VA: 0x19174DC
	private bool UpdateResult(UIBossResultManager.BossTrophy trophyType) { }

	// RVA: 0x19170A0 Offset: 0x19130A0 VA: 0x19170A0
	private List<Color32> GetColorList() { }

	// RVA: 0x191857C Offset: 0x191457C VA: 0x191857C
	public void OnHighRaidNextButton() { }

	// RVA: 0x19185E0 Offset: 0x19145E0 VA: 0x19185E0
	private void OpenHighRaidResult() { }

	// RVA: 0x1918CF4 Offset: 0x1914CF4 VA: 0x1918CF4
	public void OnHighRaidResultOk() { }

	// RVA: 0x1918D00 Offset: 0x1914D00 VA: 0x1918D00 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1918D98 Offset: 0x1914D98 VA: 0x1918D98 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1918E3C Offset: 0x1914E3C VA: 0x1918E3C
	public void .ctor() { }
}
