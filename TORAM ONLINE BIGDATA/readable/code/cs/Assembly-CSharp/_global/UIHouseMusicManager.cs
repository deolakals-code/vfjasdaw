// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIHouseMusicManager : UIBasePanel // TypeDefIndex: 7278
{
	// Fields
	[SerializeField]
	private UIScrollWindow scrollWindow; // 0x30
	[SerializeField]
	private UIIruna2Anchor listAncthor; // 0x38
	[SerializeField]
	private UIIruna2Anchor playMusicAncthor; // 0x40
	[SerializeField]
	private UILabel playMusicLabel; // 0x48
	[SerializeField]
	private UISprite listTopIcon; // 0x50
	[SerializeField]
	private UILabel listTopLabel; // 0x58
	[SerializeField]
	private GameObject selectPlayMusicButton; // 0x60
	[SerializeField]
	private UILabel selectPlayMusicLabel; // 0x68
	[SerializeField]
	private UIHouseMusicSettingPanel selectPlayMusicPanel; // 0x70
	[SerializeField]
	private UIIruna2Anchor selectPlayMusicAncthor; // 0x78
	[SerializeField]
	private UIHouseMusicRecipePanel selectMusicRecipePanel; // 0x80
	[SerializeField]
	private UIIruna2Anchor recipeAncthor; // 0x88
	[SerializeField]
	private GameObject selectBuyMusicButton; // 0x90
	[SerializeField]
	private GameObject selectBuyMusicIcon; // 0x98
	[SerializeField]
	private UILabel selectBuyMusicLabel; // 0xA0
	[SerializeField]
	private UILabel selectBuyMusicTypeLabel; // 0xA8
	[SerializeField]
	private GameObject selectCheckMusicButton; // 0xB0
	[SerializeField]
	private UISprite selectCheckMusicIcon; // 0xB8
	[SerializeField]
	private UILabel selectCheckMusicLabel; // 0xC0
	[SerializeField]
	private GameObject mainAncthor; // 0xC8
	private UIHouseMusicManager.PanelType activePanelType; // 0xD0
	private GameObject activeButton; // 0xD8
	private int activeId; // 0xE0
	private bool isDownloadFlag; // 0xE4
	private Dictionary<int, GameObject> buttonList; // 0xE8
	private Action selectedAction; // 0xF0
	private PlayerDataManager playerDataManager; // 0xF8
	private HouseItemTextManager houseTextManager; // 0x100
	private List<HouseRecipeManager.RecipeData> recipeData; // 0x108
	private bool isClose; // 0x110
	private bool cancelCheck; // 0x111

	// Methods

	[IteratorStateMachine(typeof(UIHouseMusicManager.<Start>d__32))]
	// RVA: 0x1AF8AAC Offset: 0x1AF4AAC VA: 0x1AF8AAC
	private IEnumerator Start() { }

	// RVA: 0x1AF8B40 Offset: 0x1AF4B40 VA: 0x1AF8B40
	private void OnDestroy() { }

	// RVA: 0x1AF8D78 Offset: 0x1AF4D78 VA: 0x1AF8D78
	private void selectedPlayMusic() { }

	// RVA: 0x1AF9394 Offset: 0x1AF5394 VA: 0x1AF9394
	private void UpdatePlayMusicList() { }

	// RVA: 0x1AF9924 Offset: 0x1AF5924 VA: 0x1AF9924
	public void OnSettingBGM() { }

	[IteratorStateMachine(typeof(UIHouseMusicManager.<PopUpWaitWindow>d__37))]
	// RVA: 0x1AF9944 Offset: 0x1AF5944 VA: 0x1AF9944
	private IEnumerator PopUpWaitWindow() { }

	// RVA: 0x1AF99D8 Offset: 0x1AF59D8 VA: 0x1AF99D8
	private void selectedBuyMusic() { }

	// RVA: 0x1AFA120 Offset: 0x1AF6120 VA: 0x1AFA120
	public void OnChangeCheckButton() { }

	// RVA: 0x1AFA1F0 Offset: 0x1AF61F0 VA: 0x1AFA1F0
	private void UpdateBuyMusicList(bool check) { }

	// RVA: 0x1AFAC84 Offset: 0x1AF6C84 VA: 0x1AFAC84
	public void OnBuyBGM() { }

	[IteratorStateMachine(typeof(UIHouseMusicManager.<PopUpWindow>d__42))]
	// RVA: 0x1AFAEE4 Offset: 0x1AF6EE4 VA: 0x1AFAEE4
	private IEnumerator PopUpWindow(UIPopBaseWindow popUpWindow, Action callBack) { }

	[IteratorStateMachine(typeof(UIHouseMusicManager.<ConnectWait>d__43))]
	// RVA: 0x1AFAFA8 Offset: 0x1AF6FA8 VA: 0x1AFAFA8
	private IEnumerator ConnectWait(byte subCode, Action callBack) { }

	// RVA: 0x1AFB060 Offset: 0x1AF7060 VA: 0x1AFB060
	public bool DownloadBGMData(int bgmId, Action<int> callback) { }

	[IteratorStateMachine(typeof(UIHouseMusicManager.<DownloadBGM>d__45))]
	// RVA: 0x1AFB0A4 Offset: 0x1AF70A4 VA: 0x1AFB0A4
	private IEnumerator DownloadBGM(int bgmId, Action<int> callback) { }

	// RVA: 0x1AFB15C Offset: 0x1AF715C VA: 0x1AFB15C
	public void OnTestPlayBGM() { }

	// RVA: 0x1AFB548 Offset: 0x1AF7548 VA: 0x1AFB548
	public void OnChangePanel(int panelId) { }

	// RVA: 0x1AFBD98 Offset: 0x1AF7D98 VA: 0x1AFBD98
	public void OnSelectBuyMusic(int id) { }

	// RVA: 0x1AFBF18 Offset: 0x1AF7F18 VA: 0x1AFBF18 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1AFBFE0 Offset: 0x1AF7FE0 VA: 0x1AFBFE0 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1AFC06C Offset: 0x1AF806C VA: 0x1AFC06C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1AFC0FC Offset: 0x1AF80FC VA: 0x1AFC0FC
	private bool <selectedPlayMusic>b__34_0(HouseRecipeManager.RecipeData x) { }

	[CompilerGenerated]
	// RVA: 0x1AFC110 Offset: 0x1AF8110 VA: 0x1AFC110
	private bool <selectedBuyMusic>b__38_0(HouseRecipeManager.RecipeData x) { }
}
