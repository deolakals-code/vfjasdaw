// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UITrade : UIBasePanelControl // TypeDefIndex: 8099
{
	// Fields
	[SerializeField]
	private LocalizeText titleLocalize; // 0x58
	[SerializeField]
	private UITradeSubWindow mySubWindow; // 0x60
	[SerializeField]
	private UITradeSubWindow targetSubWindow; // 0x68
	[SerializeField]
	private UIIruna2AnchorSimple messageAnchor; // 0x70
	[SerializeField]
	private UIIruna2AnchorSimple targetAnchor; // 0x78
	[SerializeField]
	private UIIruna2AnchorSimple buttonsAnchor; // 0x80
	[SerializeField]
	private GameObject getReadyMessageObject; // 0x88
	[SerializeField]
	private GameObject descriptionObject; // 0x90
	[SerializeField]
	private Transform receiveDragPosition; // 0x98
	[SerializeField]
	private UIImageButton[] detailButton; // 0xA0
	[SerializeField]
	private GameObject[] readySwichObject; // 0xA8
	[SerializeField]
	private GameObject[] selectItemDisableObject; // 0xB0
	[SerializeField]
	private GameObject[] selectItemEnableObject; // 0xB8
	[SerializeField]
	private GameObject[] finalizeEnableButton; // 0xC0
	[SerializeField]
	private UIImageButton selectItemButton; // 0xC8
	[SerializeField]
	private UIImageButton finalizeButton; // 0xD0
	[SerializeField]
	private UITradeResult resultWindow; // 0xD8
	[SerializeField]
	private GameObject[] itemSelectSwitchButtons; // 0xE0
	private ItemSelector itemSelector; // 0xE8
	private PlayerDataManager playerDataManager; // 0xF0
	private TradeManager tradeManager; // 0xF8
	private bool isSender; // 0x100
	private UIPopWindow popWindow; // 0x108
	private const int maxUsableSpace = 4;
	private bool isInventoryEmpty; // 0x110
	private bool isStarGemInventoryEmpty; // 0x111
	private short[] inventoryEmptyNum; // 0x118
	private short starGemInventoryEmptyNum; // 0x120
	private UIIruna2Anchor mySubWindowAnchor; // 0x128
	private bool isSetFinalize; // 0x130
	private bool isDisConnect; // 0x131
	private GameManager gameManager; // 0x138
	private int inputSpina; // 0x140
	private List<ItemSelectData> selectItemList; // 0x148
	private List<long> selectStarGemIdList; // 0x150
	private UITrade.ItemSelectType itemSelectType; // 0x158
	private UILabel selectItemButtonLabel; // 0x160
	private int targetId; // 0x168
	private string cancelSaveDataKey; // 0x170
	private string cancelSaveStarGemDataKey; // 0x178
	private UITrade.TradeHistoryData historyData; // 0x180
	private UIPopBaseWindow warningPopWindow; // 0x188
	private bool cancelCheck; // 0x190
	private bool isFinalize; // 0x191

	// Properties
	public bool IsFinalize { get; }
	private bool IsOpenPopWindow { get; }

	// Methods

	// RVA: 0x1CBEB7C Offset: 0x1CBAB7C VA: 0x1CBEB7C
	public bool get_IsFinalize() { }

	// RVA: 0x1CBEB84 Offset: 0x1CBAB84 VA: 0x1CBEB84
	private bool get_IsOpenPopWindow() { }

	// RVA: 0x1CBEC1C Offset: 0x1CBAC1C VA: 0x1CBEC1C
	private void Awake() { }

	// RVA: 0x1CBEF14 Offset: 0x1CBAF14 VA: 0x1CBEF14
	private void Start() { }

	// RVA: 0x1CBEF6C Offset: 0x1CBAF6C VA: 0x1CBEF6C
	private void Update() { }

	// RVA: 0x1CBF004 Offset: 0x1CBB004 VA: 0x1CBF004
	private void OnDestroy() { }

	// RVA: 0x1CBF030 Offset: 0x1CBB030 VA: 0x1CBF030
	public void Initialize(bool isSender, string targetname, TradeStartEvent_ start, int targetId) { }

	[IteratorStateMachine(typeof(UITrade.<showUsableSpaceWarning>d__55))]
	// RVA: 0x1CBF524 Offset: 0x1CBB524 VA: 0x1CBF524
	private IEnumerator showUsableSpaceWarning(short[] emptyCount, short starGemEmptyCount) { }

	// RVA: 0x1CBFDCC Offset: 0x1CBBDCC VA: 0x1CBFDCC
	private GameObject SettingObject(GameObject obj, Vector3 pos, float scale, Transform parent) { }

	// RVA: 0x1CBFF18 Offset: 0x1CBBF18 VA: 0x1CBFF18
	private void onReady() { }

	// RVA: 0x1CC03A8 Offset: 0x1CBC3A8 VA: 0x1CC03A8
	public void OnFinalize(TradeData_ sender, TradeData_ target) { }

	// RVA: 0x1CC0A74 Offset: 0x1CBCA74 VA: 0x1CC0A74
	private void doFinalize() { }

	// RVA: 0x1CC0BA0 Offset: 0x1CBCBA0 VA: 0x1CC0BA0
	private void onSelectItem() { }

	// RVA: 0x1CC1894 Offset: 0x1CBD894 VA: 0x1CC1894
	private void onDetail() { }

	// RVA: 0x1CC2234 Offset: 0x1CBE234 VA: 0x1CC2234
	private void onCheckDetail() { }

	// RVA: 0x1CC24F0 Offset: 0x1CBE4F0 VA: 0x1CC24F0
	private void onSelectedItem(ItemData item, int count) { }

	// RVA: 0x1CC106C Offset: 0x1CBD06C VA: 0x1CC106C
	private void setSelectedItemItemSelector() { }

	// RVA: 0x1CC2648 Offset: 0x1CBE648 VA: 0x1CC2648
	private void onDetermineItem() { }

	// RVA: 0x1CC3228 Offset: 0x1CBF228 VA: 0x1CC3228
	private void onClose() { }

	[IteratorStateMachine(typeof(UITrade.<doClose>d__67))]
	// RVA: 0x1CC32CC Offset: 0x1CBF2CC VA: 0x1CC32CC
	private IEnumerator doClose() { }

	// RVA: 0x1CC3360 Offset: 0x1CBF360 VA: 0x1CC3360
	private void doCancel() { }

	// RVA: 0x1CC337C Offset: 0x1CBF37C VA: 0x1CC337C
	public void OnCancel() { }

	// RVA: 0x1CC3408 Offset: 0x1CBF408 VA: 0x1CC3408
	public void OnResult(TradeResultEvent_ result) { }

	// RVA: 0x1CC36D0 Offset: 0x1CBF6D0 VA: 0x1CC36D0
	private void onFinish() { }

	// RVA: 0x1CC2D84 Offset: 0x1CBED84 VA: 0x1CC2D84
	private void ActiveMySubWindow() { }

	// RVA: 0x1CC376C Offset: 0x1CBF76C VA: 0x1CC376C
	private void NonActiveMySubWindow() { }

	// RVA: 0x1CBEFB0 Offset: 0x1CBAFB0 VA: 0x1CBEFB0
	private void OpenDisconnectWindow() { }

	// RVA: 0x1CC380C Offset: 0x1CBF80C VA: 0x1CC380C
	private void OnSelectStarGem(StarGemData data) { }

	// RVA: 0x1CC3A70 Offset: 0x1CBFA70 VA: 0x1CC3A70 Slot: 6
	public override void OnRightTopButton() { }

	[IteratorStateMachine(typeof(UITrade.<onCancel>d__77))]
	// RVA: 0x1CC339C Offset: 0x1CBF39C VA: 0x1CC339C
	private IEnumerator onCancel() { }

	// RVA: 0x1CC3ABC Offset: 0x1CBFABC VA: 0x1CC3ABC
	public void OnSpinaSubmit() { }

	[IteratorStateMachine(typeof(UITrade.<setReady>d__79))]
	// RVA: 0x1CC033C Offset: 0x1CBC33C VA: 0x1CC033C
	private IEnumerator setReady() { }

	[IteratorStateMachine(typeof(UITrade.<setFinalize>d__80))]
	// RVA: 0x1CC0B34 Offset: 0x1CBCB34 VA: 0x1CC0B34
	private IEnumerator setFinalize() { }

	[IteratorStateMachine(typeof(UITrade.<DisconnectWindow>d__81))]
	// RVA: 0x1CC37A0 Offset: 0x1CBF7A0 VA: 0x1CC37A0
	private IEnumerator DisconnectWindow() { }

	// RVA: 0x1CC3C08 Offset: 0x1CBFC08 VA: 0x1CC3C08
	private void OnPreviewClick() { }

	// RVA: 0x1CC413C Offset: 0x1CC013C VA: 0x1CC413C
	private void OnWarningWindowClose() { }

	// RVA: 0x1CBF3AC Offset: 0x1CBB3AC VA: 0x1CBF3AC
	private void UpdateItemSelectButton() { }

	// RVA: 0x1CBF5B4 Offset: 0x1CBB5B4 VA: 0x1CBF5B4
	private void LoadTradeHistoryData() { }

	// RVA: 0x1CC4270 Offset: 0x1CC0270 VA: 0x1CC4270
	private void SaveTradeHistoryData() { }

	// RVA: 0x1CC3664 Offset: 0x1CBF664 VA: 0x1CC3664
	private void DeleteTradeHistoryData() { }

	// RVA: 0x1CC4DC4 Offset: 0x1CC0DC4 VA: 0x1CC4DC4
	public void OnSwitchItemSelect() { }

	// RVA: 0x1CC4E04 Offset: 0x1CC0E04 VA: 0x1CC4E04
	public void OnSwitchStarGemSelect() { }

	// RVA: 0x1CC4E48 Offset: 0x1CC0E48 VA: 0x1CC4E48
	public void .ctor() { }

	[CompilerGenerated]
	[DebuggerHidden]
	// RVA: 0x1CC4FAC Offset: 0x1CC0FAC VA: 0x1CC4FAC
	private void <>n__0(Action pushFunction) { }

	[DebuggerHidden]
	[CompilerGenerated]
	// RVA: 0x1CC4FB4 Offset: 0x1CC0FB4 VA: 0x1CC4FB4
	private void <>n__1() { }

	[CompilerGenerated]
	// RVA: 0x1CC4FBC Offset: 0x1CC0FBC VA: 0x1CC4FBC
	private bool <onSelectItem>b__60_0(ItemData it) { }

	[CompilerGenerated]
	[DebuggerHidden]
	// RVA: 0x1CC50BC Offset: 0x1CC10BC VA: 0x1CC50BC
	private void <>n__2(Action targetAction) { }
}
