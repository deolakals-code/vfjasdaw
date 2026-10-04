// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIOrbHistoryWindow : MonoBehaviour // TypeDefIndex: 7591
{
	// Fields
	private readonly float ElementHeight; // 0x20
	[SerializeField]
	private UIScrollWindow scrollWindow; // 0x28
	[SerializeField]
	private GameObject elementDate; // 0x30
	[SerializeField]
	private GameObject elementItem; // 0x38
	[SerializeField]
	private LocalizeText pageLabel; // 0x40
	[SerializeField]
	private UILabel titleLabel; // 0x48
	[SerializeField]
	private UIImageButton nextButton; // 0x50
	[SerializeField]
	private UIImageButton prevButton; // 0x58
	[SerializeField]
	private GameObject nonListObj; // 0x60
	private readonly int PageItemNum; // 0x68
	private Dictionary<int, List<UIOrbHistoryWindow.HistoryData>> historyList; // 0x70
	private int gachaLoadPage; // 0x78
	private int gachaMaxPage; // 0x7C
	private List<UIOrbHistoryWindow.HistoryData> gachaHistoryStack; // 0x80
	private int luckyBagLoadPage; // 0x88
	private int luckyBagLoadMaxPage; // 0x8C
	private List<UIOrbHistoryWindow.HistoryData> luckyBagHistoryStack; // 0x90
	private UIBasePanelControl topControl; // 0x98
	private SystemTextManager systemTextManager; // 0xA0
	private ItemTextManager itemTextManager; // 0xA8
	private int currentPage; // 0xB0
	private int maxPage; // 0xB4
	private bool isGashaMode; // 0xB8

	// Methods

	// RVA: 0x1BB3D88 Offset: 0x1BAFD88 VA: 0x1BB3D88
	private void Awake() { }

	// RVA: 0x1BB39CC Offset: 0x1BAF9CC VA: 0x1BB39CC
	public void InitializeHistory(UIBasePanelControl control) { }

	// RVA: 0x1BB3BB8 Offset: 0x1BAFBB8 VA: 0x1BB3BB8
	public void InitializeGashaHistory(UIBasePanelControl control) { }

	[IteratorStateMachine(typeof(UIOrbHistoryWindow.<initializeHistory>d__27))]
	// RVA: 0x1BB3FBC Offset: 0x1BAFFBC VA: 0x1BB3FBC
	private IEnumerator initializeHistory(IEnumerator countCoroutine) { }

	[IteratorStateMachine(typeof(UIOrbHistoryWindow.<updateHistory>d__28))]
	// RVA: 0x1BB40D8 Offset: 0x1BB00D8 VA: 0x1BB40D8
	private IEnumerator updateHistory(int page) { }

	[IteratorStateMachine(typeof(UIOrbHistoryWindow.<updateGashaHistory>d__29))]
	// RVA: 0x1BB417C Offset: 0x1BB017C VA: 0x1BB417C
	private IEnumerator updateGashaHistory(int page) { }

	// RVA: 0x1BB4220 Offset: 0x1BB0220 VA: 0x1BB4220
	private void updateList() { }

	// RVA: 0x1BB4368 Offset: 0x1BB0368 VA: 0x1BB4368
	private void initializeScroll() { }

	// RVA: 0x1BB518C Offset: 0x1BB118C VA: 0x1BB518C
	private void onNext() { }

	// RVA: 0x1BB5200 Offset: 0x1BB1200 VA: 0x1BB5200
	private void onPrev() { }

	// RVA: 0x1BB5278 Offset: 0x1BB1278 VA: 0x1BB5278
	private void onBack() { }

	// RVA: 0x1BB52AC Offset: 0x1BB12AC VA: 0x1BB52AC
	private void OnDestroy() { }

	[IteratorStateMachine(typeof(UIOrbHistoryWindow.<getHistoryCount>d__36))]
	// RVA: 0x1BB3F50 Offset: 0x1BAFF50 VA: 0x1BB3F50
	private IEnumerator getHistoryCount() { }

	[IteratorStateMachine(typeof(UIOrbHistoryWindow.<getHistory>d__37))]
	// RVA: 0x1BB5334 Offset: 0x1BB1334 VA: 0x1BB5334
	private IEnumerator getHistory(int page) { }

	[IteratorStateMachine(typeof(UIOrbHistoryWindow.<geLotteryProductHistoryCount>d__38))]
	// RVA: 0x1BB4044 Offset: 0x1BB0044 VA: 0x1BB4044
	private IEnumerator geLotteryProductHistoryCount() { }

	[IteratorStateMachine(typeof(UIOrbHistoryWindow.<getGashaHistory>d__39))]
	// RVA: 0x1BB5400 Offset: 0x1BB1400 VA: 0x1BB5400
	private IEnumerator getGashaHistory() { }

	[IteratorStateMachine(typeof(UIOrbHistoryWindow.<getLuckyBagHistory>d__40))]
	// RVA: 0x1BB5494 Offset: 0x1BB1494 VA: 0x1BB5494
	private IEnumerator getLuckyBagHistory() { }

	// RVA: 0x1BB5528 Offset: 0x1BB1528 VA: 0x1BB5528
	public void .ctor() { }
}
