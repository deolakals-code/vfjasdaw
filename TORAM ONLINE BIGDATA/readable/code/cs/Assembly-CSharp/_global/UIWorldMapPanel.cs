// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIWorldMapPanel : UIMapBasePanel // TypeDefIndex: 7408
{
	// Fields
	private readonly int checkAccountProgress; // 0x20
	private readonly byte AccountKey; // 0x24
	[SerializeField]
	private GameObject missionPickupButton; // 0x28
	[SerializeField]
	private GameObject missionPickupToggle; // 0x30
	[SerializeField]
	private GameObject selectButton; // 0x38
	[SerializeField]
	private GameObject searchButton; // 0x40
	[SerializeField]
	private GameObject changeWorldButton; // 0x48
	[SerializeField]
	private UISprite[] changeWorldButtonIcon; // 0x50
	[SerializeField]
	private GameObject searchStoryButton; // 0x58
	[SerializeField]
	private GameObject searchFavoriteErr; // 0x60
	[SerializeField]
	private UIScrollWindow scrollWindow; // 0x68
	[SerializeField]
	private GameObject[] selectedTabObject; // 0x70
	[SerializeField]
	private GameObject[] worldPanel; // 0x78
	[SerializeField]
	private GameObject fieldJumpButtonObject; // 0x80
	private UIIruna2Anchor fieldJumpButton; // 0x88
	private UIImageButton fieldJumpImageButton; // 0x90
	[SerializeField]
	private GameObject itemLabelPanel; // 0x98
	private UILabel itemLabel; // 0xA0
	[SerializeField]
	private Camera controlCamera; // 0xA8
	[SerializeField]
	private GameObject infoObject; // 0xB0
	private UIIruna2Anchor infoAnchor; // 0xB8
	[SerializeField]
	private GameObject popIcon; // 0xC0
	[SerializeField]
	private UIWorldMap3DView view; // 0xC8
	[SerializeField]
	private GameObject warpPopPanel; // 0xD0
	[SerializeField]
	private UILabel warpPopPanelText; // 0xD8
	[SerializeField]
	private GameObject warpSpinaPopPanel; // 0xE0
	[SerializeField]
	private GameObject buttonAreaLineObject; // 0xE8
	[SerializeField]
	private UILabel warpOrbNumLabel; // 0xF0
	[SerializeField]
	private GameObject[] warpOrbButton; // 0xF8
	[SerializeField]
	private UILabel warpSpinaNumLabel; // 0x100
	[SerializeField]
	private UILabel warpSpinaButtonLabel; // 0x108
	[SerializeField]
	private UIImageButton warpSpinaButton; // 0x110
	[SerializeField]
	private GameObject searchMapNamePanel; // 0x118
	private Vector3 touchPosision; // 0x120
	private Dictionary<byte, List<UIWorldMapPanel.WorldMapData>> worldMapDataList; // 0x130
	private Dictionary<byte, List<UIWorldMapPanel.StoryFieldData>> worldMapStoryDataList; // 0x138
	private Dictionary<int, UIWorldMapPanel.FieldSpinaWarpData> spinaWrapFieldList; // 0x140
	private Dictionary<int, byte> fieldWroldTypeList; // 0x148
	private byte activeFieldWorldId; // 0x150
	private byte saveUserFieldWorldId; // 0x151
	private bool isFavoriteErr; // 0x152
	private GameObject loadingObject; // 0x158
	private float loadingTimer; // 0x160
	private bool inputLock; // 0x164
	private bool popUpWindowActive; // 0x165
	private bool popUpJumpWindowActive; // 0x166
	private SystemTextManager systemTextManager; // 0x168
	private FieldTextManager fieldTextManager; // 0x170
	private FunctionLimitManager functionLimitManager; // 0x178
	private int warpItemNum; // 0x180
	private int selectedFieldId; // 0x184
	private UIWorldMapPanel.Page activePageId; // 0x188
	private int playerLevel; // 0x18C
	private int playerFieldId; // 0x190
	private bool isPickupFieldView; // 0x194
	private Dictionary<byte, string> popTextData; // 0x198
	private UIMapMainPanelManager manager; // 0x1A0
	private const int favoriteFieldNum = 10;
	private int[] favoriteFieldIdList; // 0x1A8
	private UIWorldMapSearchButton[] favoriteFieldButton; // 0x1B0
	private bool isUpdateFavoriteField; // 0x1B8
	private List<int> pickupFieldList; // 0x1C0
	private List<int> partyMemberFieldList; // 0x1C8
	private bool isAnotherWorld; // 0x1D0
	private bool isAnotherWorldLockSystem; // 0x1D1
	private Dictionary<int, List<GmEventData>> roomGmMobEventData; // 0x1D8
	private int warpPopWindowMessage; // 0x1E0
	private int cureentLangPanelId; // 0x1E4
	private bool isTapLock; // 0x1E8
	private Dictionary<byte, int> WorldLatestFieldList; // 0x1F0
	private UIInput searchMapNameInput; // 0x1F8
	private Dictionary<int, string> searchMapNameTextList; // 0x200
	private string searchMapNameInputText; // 0x208

	// Properties
	public override bool IsTapLock { get; }

	// Methods

	// RVA: 0x1B36EC4 Offset: 0x1B32EC4 VA: 0x1B36EC4 Slot: 4
	public override bool get_IsTapLock() { }

	// RVA: 0x1B36ECC Offset: 0x1B32ECC VA: 0x1B36ECC
	private void Awake() { }

	// RVA: 0x1B37070 Offset: 0x1B33070 VA: 0x1B37070
	private void OnDestroy() { }

	[IteratorStateMachine(typeof(UIWorldMapPanel.<Initialize>d__82))]
	// RVA: 0x1B37174 Offset: 0x1B33174 VA: 0x1B37174 Slot: 5
	public override IEnumerator Initialize(UIMapMainPanelManager manager, PlayerDataManager playerDataManager, GameObject model, int fieldId, FieldTextManager fieldTextManager) { }

	// RVA: 0x1B37278 Offset: 0x1B33278 VA: 0x1B37278
	private void AddWorldMapData(byte world, UIWorldMapPanel.WorldMapData mapData) { }

	// RVA: 0x1B37700 Offset: 0x1B33700 VA: 0x1B37700
	private List<UIWorldMapPanel.WorldMapData> ActiveWorldMapData() { }

	// RVA: 0x1B377AC Offset: 0x1B337AC VA: 0x1B377AC
	private List<UIWorldMapPanel.WorldMapData> GetAllWorldMapData() { }

	// RVA: 0x1B37978 Offset: 0x1B33978 VA: 0x1B37978
	private UIWorldMapPanel.WorldMapData GetFieldIdWorldMapData(int fieldId, short chipId = 0) { }

	// RVA: 0x1B37C0C Offset: 0x1B33C0C VA: 0x1B37C0C
	private UIWorldMapPanel.WorldMapData GetSortdIdWorldMapData(int sortId) { }

	// RVA: 0x1B37E9C Offset: 0x1B33E9C VA: 0x1B37E9C
	private void ActiveWorldButton() { }

	// RVA: 0x1B37F9C Offset: 0x1B33F9C VA: 0x1B37F9C Slot: 6
	public override void Open() { }

	// RVA: 0x1B38180 Offset: 0x1B34180 VA: 0x1B38180 Slot: 7
	public override void Close() { }

	[IteratorStateMachine(typeof(UIWorldMapPanel.<FadePanel>d__91))]
	// RVA: 0x1B381EC Offset: 0x1B341EC VA: 0x1B381EC
	private IEnumerator FadePanel(Action callback) { }

	// RVA: 0x1B3803C Offset: 0x1B3403C VA: 0x1B3803C
	private void Reset() { }

	// RVA: 0x1B3829C Offset: 0x1B3429C VA: 0x1B3829C
	private void SelectedField(int selectedFieldId) { }

	// RVA: 0x1B384F8 Offset: 0x1B344F8 VA: 0x1B384F8 Slot: 9
	public override bool PushLeftTopButton() { }

	// RVA: 0x1B38640 Offset: 0x1B34640 VA: 0x1B38640 Slot: 8
	public override Vector3 Control(Vector3 drag) { }

	// RVA: 0x1B38790 Offset: 0x1B34790 VA: 0x1B38790 Slot: 11
	public override void OnClick() { }

	// RVA: 0x1B3885C Offset: 0x1B3485C VA: 0x1B3885C Slot: 13
	public override void OnScroll(float delta) { }

	// RVA: 0x1B388E8 Offset: 0x1B348E8 VA: 0x1B388E8
	private void OnPopBonusInfo() { }

	// RVA: 0x1B38D18 Offset: 0x1B34D18 VA: 0x1B38D18
	private void OnFieldJump() { }

	[IteratorStateMachine(typeof(UIWorldMapPanel.<PopUpWrapWindow>d__100))]
	// RVA: 0x1B38DE0 Offset: 0x1B34DE0 VA: 0x1B38DE0
	private IEnumerator PopUpWrapWindow() { }

	// RVA: 0x1B38E74 Offset: 0x1B34E74 VA: 0x1B38E74
	public void OnClick_WarpCommand(int command) { }

	[IteratorStateMachine(typeof(UIWorldMapPanel.<ConnectWait>d__102))]
	// RVA: 0x1B38E7C Offset: 0x1B34E7C VA: 0x1B38E7C
	private IEnumerator ConnectWait(OrbManager.ConnectFlag connectFlag) { }

	[IteratorStateMachine(typeof(UIWorldMapPanel.<PopUpWindow>d__103))]
	// RVA: 0x1B38C7C Offset: 0x1B34C7C VA: 0x1B38C7C
	private IEnumerator PopUpWindow(UIPopBaseWindow window, Action callback) { }

	// RVA: 0x1B38638 Offset: 0x1B34638 VA: 0x1B38638
	private void CreateSearchList(UIWorldMapPanel.Page type, int param) { }

	// RVA: 0x1B38F48 Offset: 0x1B34F48 VA: 0x1B38F48
	private void CreateSearchList(UIWorldMapPanel.Page type, int param, List<int> mapList) { }

	// RVA: 0x1B3A468 Offset: 0x1B36468 VA: 0x1B3A468
	private void SetActiveTab(int id) { }

	// RVA: 0x1B3A96C Offset: 0x1B3696C VA: 0x1B3A96C
	private Vector3 CheckActiveList(Vector3 position, Func<UIWorldMapPanel.WorldMapData, bool> check) { }

	// RVA: 0x1B39F64 Offset: 0x1B35F64 VA: 0x1B39F64
	private UIWorldMapSearchButton CreateSelectButton(UIWorldMapPanel.WorldMapData mapData, Vector3 position, bool isLevelOnly) { }

	// RVA: 0x1B3AB68 Offset: 0x1B36B68 VA: 0x1B3AB68
	public bool ChangeFavoriteField(int id, bool isFavorite) { }

	// RVA: 0x1B3B148 Offset: 0x1B37148 VA: 0x1B3B148
	public void ChangeFavoriteFieldSort(int id) { }

	// RVA: 0x1B3B4EC Offset: 0x1B374EC VA: 0x1B3B4EC
	public void OnClick_ChangeWorld(int param) { }

	// RVA: 0x1B3B540 Offset: 0x1B37540 VA: 0x1B3B540
	private void ChangeWorld(int param, Action callback) { }

	// RVA: 0x1B3B5B4 Offset: 0x1B375B4 VA: 0x1B3B5B4
	public void OnClick_WorldChangePanel() { }

	// RVA: 0x1B3B704 Offset: 0x1B37704 VA: 0x1B3B704
	public void OnClick_PopSearchPanel() { }

	// RVA: 0x1B3B9C8 Offset: 0x1B379C8 VA: 0x1B3B9C8
	public void OnClick_Selected(int id) { }

	// RVA: 0x1B3BD90 Offset: 0x1B37D90 VA: 0x1B3BD90
	public void OnClick_SelectedFieldType(int type) { }

	// RVA: 0x1B3BDDC Offset: 0x1B37DDC VA: 0x1B3BDDC
	public void OnClick_ChangeMisstionPickup() { }

	// RVA: 0x1B3A6CC Offset: 0x1B366CC VA: 0x1B3A6CC
	private List<UIWorldMapPanel.StoryFieldData> GetAllStoryFieldData() { }

	// RVA: 0x1B3A4D4 Offset: 0x1B364D4 VA: 0x1B3A4D4
	private void CreateSearchMapNamePanel(Vector3 position, string defaultText) { }

	// RVA: 0x1B3BE84 Offset: 0x1B37E84 VA: 0x1B3BE84
	public void OnSearchMapNameSubmit() { }

	[IteratorStateMachine(typeof(UIWorldMapPanel.<SearchMapName>d__121))]
	// RVA: 0x1B3BECC Offset: 0x1B37ECC VA: 0x1B3BECC
	private IEnumerator SearchMapName(string mapName) { }

	[IteratorStateMachine(typeof(UIWorldMapPanel.<GetContainsMapName>d__122))]
	// RVA: 0x1B3BF5C Offset: 0x1B37F5C VA: 0x1B3BF5C
	private IEnumerator GetContainsMapName(string keyword, Action<List<int>> callback) { }

	// RVA: 0x1B3C020 Offset: 0x1B38020 VA: 0x1B3C020
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1B3C3C4 Offset: 0x1B383C4 VA: 0x1B3C3C4
	private void <ChangeFavoriteField>b__109_0() { }

	[CompilerGenerated]
	// RVA: 0x1B3C3F8 Offset: 0x1B383F8 VA: 0x1B3C3F8
	private void <ChangeFavoriteField>b__109_1() { }

	[CompilerGenerated]
	// RVA: 0x1B3C42C Offset: 0x1B3842C VA: 0x1B3C42C
	private void <OnClick_PopSearchPanel>b__114_0() { }
}
