// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPointShopManager : UIBasePanel, PointShopRewarDataBase.IGetRewardMaster // TypeDefIndex: 6172
{
	// Fields
	private int shopId; // 0x2C
	private string shopName; // 0x30
	private IGameEventExchangeData poinEventData; // 0x38
	private Dictionary<byte, List<PointShopRewarDataBase>> rewordData; // 0x40
	private UIPointShopManager.EventStateMent state; // 0x48
	private PlayerDataManager playerDataManager; // 0x50
	private byte selectedType; // 0x58
	private ExchangeType shopExchangeType; // 0x59
	private int shopExchangeItemId; // 0x5C
	private List<short> limitRewardIdList; // 0x60
	private bool isEventShop; // 0x68
	private bool isFirstStarGem; // 0x69
	private bool isFirstAvaterEquip; // 0x6A
	private bool isRepeatCancel; // 0x6B
	private bool isRepeatConnecting; // 0x6C
	[SerializeField]
	private UILabel shopNameLabel; // 0x70
	[SerializeField]
	private GameObject[] pointMenuButton; // 0x78
	[SerializeField]
	private UILabel[] pointMenuTitleLabel; // 0x80
	[SerializeField]
	private UILabel[] pointMenuTextLabel; // 0x88
	[SerializeField]
	private GameObject[] pointListButton; // 0x90
	[SerializeField]
	private UILabel[] pointListButtonNumLabel; // 0x98
	[SerializeField]
	private UIScrollWindow scrollWindow; // 0xA0
	[SerializeField]
	private GameObject pointAnchor; // 0xA8
	[SerializeField]
	private UILabel pointLabel; // 0xB0
	[SerializeField]
	private UILabel pointTextLabel; // 0xB8
	[SerializeField]
	private ExchangeDialog exchangeDialog; // 0xC0
	[SerializeField]
	private GameObject popDialog; // 0xC8
	[SerializeField]
	private UILabel popDialogTopLabel; // 0xD0
	[SerializeField]
	private UILabel popDialogBottomLabel; // 0xD8
	[SerializeField]
	private SummerRewardController rewardController; // 0xE0
	[SerializeField]
	private GameObject levelEquipWarningPanel; // 0xE8
	[SerializeField]
	private GameObject firstStarGemGetPopWindow; // 0xF0
	[SerializeField]
	private GameObject firstAvaterEquipGetPopWindow; // 0xF8
	[SerializeField]
	private GameObject titleIconObj; // 0x100
	[SerializeField]
	private GameObject rewardRepeatPanel; // 0x108
	[SerializeField]
	private UILabel rewardRepeatLabel; // 0x110
	[SerializeField]
	private UISprite rewardRepeatIcon; // 0x118
	[SerializeField]
	private UILabel rewardRepeatProcessLabel; // 0x120
	[SerializeField]
	private UISprite rewardRepeatProcessBar; // 0x128
	[CompilerGenerated]
	private byte <ChangeClosedState>k__BackingField; // 0x130

	// Properties
	public bool IsClosed { get; set; }
	public byte ChangeClosedState { get; set; }

	// Methods

	// RVA: 0x18ABA18 Offset: 0x18A7A18 VA: 0x18ABA18
	public bool get_IsClosed() { }

	// RVA: 0x18ABA28 Offset: 0x18A7A28 VA: 0x18ABA28
	public void set_IsClosed(bool value) { }

	[CompilerGenerated]
	// RVA: 0x18ABA2C Offset: 0x18A7A2C VA: 0x18ABA2C
	public byte get_ChangeClosedState() { }

	[CompilerGenerated]
	// RVA: 0x18ABA34 Offset: 0x18A7A34 VA: 0x18ABA34
	private void set_ChangeClosedState(byte value) { }

	// RVA: 0x18ABA3C Offset: 0x18A7A3C VA: 0x18ABA3C
	private void Awake() { }

	[IteratorStateMachine(typeof(UIPointShopManager.<Start>d__49))]
	// RVA: 0x18ABA44 Offset: 0x18A7A44 VA: 0x18ABA44
	private IEnumerator Start() { }

	// RVA: 0x18ABAD8 Offset: 0x18A7AD8 VA: 0x18ABAD8
	public void EneterShop(int shopId, string shopName, byte shopExchangeType) { }

	// RVA: 0x18ABB28 Offset: 0x18A7B28 VA: 0x18ABB28
	private bool LoadRewardData(byte[] binary) { }

	// RVA: 0x18AC1BC Offset: 0x18A81BC VA: 0x18AC1BC Slot: 7
	public PointShopRewarDataBase GetRewardData(short uid) { }

	// RVA: 0x18AC3F8 Offset: 0x18A83F8 VA: 0x18AC3F8
	private int GetMaxExchangeNum(PointShopRewarDataBase openData) { }

	// RVA: 0x18AC9DC Offset: 0x18A89DC VA: 0x18AC9DC
	private int GetCheckResult(short uid, Dictionary<byte, int> checkData) { }

	// RVA: 0x18ACEB0 Offset: 0x18A8EB0 VA: 0x18ACEB0
	private string getExchangeDataName() { }

	// RVA: 0x18AC8F4 Offset: 0x18A88F4 VA: 0x18AC8F4
	private int getExchangeDataPoint() { }

	[IteratorStateMachine(typeof(UIPointShopManager.<ConnectWait>d__57))]
	// RVA: 0x18AD028 Offset: 0x18A9028 VA: 0x18AD028
	private IEnumerator ConnectWait(Func<bool> wait, Action<bool> callback) { }

	// RVA: 0x18AD0EC Offset: 0x18A90EC VA: 0x18AD0EC
	private void OpenMenu() { }

	// RVA: 0x18AD6AC Offset: 0x18A96AC VA: 0x18AD6AC
	public void OnOpenList(int type) { }

	// RVA: 0x18AD6B4 Offset: 0x18A96B4 VA: 0x18AD6B4
	public void OnOpenList(int type, bool reset) { }

	// RVA: 0x18AAF14 Offset: 0x18A6F14 VA: 0x18AAF14
	public void OnOpenInfo(PointShopRewarDataBase openData) { }

	// RVA: 0x18AE448 Offset: 0x18AA448 VA: 0x18AE448
	public void OnClosePopDialog() { }

	// RVA: 0x18AA88C Offset: 0x18A688C VA: 0x18AA88C
	public void OnGetReward(int getCount, PointShopRewarDataBase rewardData) { }

	[IteratorStateMachine(typeof(UIPointShopManager.<OnGetRepeatReward>d__64))]
	// RVA: 0x18AE454 Offset: 0x18AA454 VA: 0x18AE454
	private IEnumerator OnGetRepeatReward(int getCount, PointShopRewarDataBase rewardData) { }

	// RVA: 0x18AE50C Offset: 0x18AA50C VA: 0x18AE50C
	private void CheckRewardState(PointShopRewarDataBase rewardData) { }

	// RVA: 0x18AE6E8 Offset: 0x18AA6E8 VA: 0x18AE6E8
	public void OnChangeStarGemMenu() { }

	// RVA: 0x18AE6F4 Offset: 0x18AA6F4 VA: 0x18AE6F4
	public void OnChangeAvaterEquipMenu() { }

	// RVA: 0x18AE700 Offset: 0x18AA700 VA: 0x18AE700
	public void OnClick_RepeatConnectionCancel() { }

	// RVA: 0x18AE780 Offset: 0x18AA780 VA: 0x18AE780 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x18AEA40 Offset: 0x18AAA40 VA: 0x18AEA40 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x18AEB6C Offset: 0x18AAB6C VA: 0x18AEB6C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x18AEC84 Offset: 0x18AAC84 VA: 0x18AEC84
	private bool <OnGetReward>b__63_0() { }

	[CompilerGenerated]
	// RVA: 0x18AED28 Offset: 0x18AAD28 VA: 0x18AED28
	private void <OnGetReward>b__63_1(bool x) { }

	[CompilerGenerated]
	// RVA: 0x18AF214 Offset: 0x18AB214 VA: 0x18AF214
	private void <OnGetReward>b__63_2() { }

	[CompilerGenerated]
	// RVA: 0x18AF21C Offset: 0x18AB21C VA: 0x18AF21C
	private void <OnGetRepeatReward>b__64_0() { }
}
