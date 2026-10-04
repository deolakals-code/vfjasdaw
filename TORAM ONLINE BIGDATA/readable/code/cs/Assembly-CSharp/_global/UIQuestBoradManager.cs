// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIQuestBoradManager : UIBasePanel // TypeDefIndex: 7890
{
	// Fields
	private UIScrollWindow scrollListWindow; // 0x30
	[SerializeField]
	private GameObject listButton; // 0x38
	private GameObject selectQuest; // 0x40
	private PlayerDataManager playerDataManager; // 0x48
	private QuestTextManager questTextManager; // 0x50
	private MissionTextManager missionTextManager; // 0x58
	private FieldTextManager fieldTextManager; // 0x60
	private EnemyTextManager enemyTextManager; // 0x68
	private ItemTextManager itemTextManager; // 0x70
	[SerializeField]
	private GameObject questWindowObject; // 0x78
	[SerializeField]
	private GameObject selectButtonObject; // 0x80
	[SerializeField]
	private Transform selectPosition; // 0x88
	private int selectId; // 0x90
	protected IScenario selectScenario; // 0x98
	private bool selectScenarioType; // 0xA0
	private QuestTextManagerData selectQuestText; // 0xA8
	[SerializeField]
	private UIImageButton targetSelectButton; // 0xB0
	[SerializeField]
	private UIImageButton abandonSelectButton; // 0xB8
	[SerializeField]
	private UIImageButton stroySelectButton; // 0xC0
	[SerializeField]
	private UIIruna2TextList textList; // 0xC8
	[SerializeField]
	private UIIruna2TextList paramList; // 0xD0
	private int infoTextLine; // 0xD8
	[SerializeField]
	private GameObject abandonButton; // 0xE0
	[SerializeField]
	private UILabel abandonLebel; // 0xE8
	[SerializeField]
	private GameObject questBoradWindowObject; // 0xF0
	private UIQuestBoradWindow questBoradWindow; // 0xF8
	[SerializeField]
	private GameObject scrollBar; // 0x100
	[SerializeField]
	private GameObject itemSearchButton; // 0x108
	[SerializeField]
	private GameObject changeRepeatButton; // 0x110
	[SerializeField]
	private GameObject changeRepeatLabel; // 0x118
	[SerializeField]
	private GameObject baseKeywordIconObject; // 0x120
	[SerializeField]
	private GameObject mainPanel; // 0x128
	[SerializeField]
	private GameObject skipWindow; // 0x130
	[SerializeField]
	private UIScrollWindow skipScrollWindow; // 0x138
	[SerializeField]
	private GameObject skipScrollLabelObj; // 0x140
	[SerializeField]
	private GameObject skipChapterElement; // 0x148
	[SerializeField]
	private GameObject skipEpisodeElement; // 0x150
	[SerializeField]
	private UIQuestBoardSkipWindow questBoardSkipWindow; // 0x158
	private UIQuestBoradManager.SkipPanelState skipPanelState; // 0x160
	private int selectSkipChapter; // 0x164
	private Vector3 skipChapterScrollCameraPos; // 0x168
	private List<MaterialSearchData> itemSearchData; // 0x178
	private UIPopBaseWindow popUpWindow; // 0x180
	private InactiveTimer popUpWindowInactiveTimer; // 0x188
	private bool cancelCheck; // 0x190
	private UIQuestBoradManager.SelectTypes selectType; // 0x194
	private bool isRepeatPopUp; // 0x198
	private Dictionary<int, int> keywordItemIconList; // 0x1A0
	private UIIconBase[] keywordItemIcon; // 0x1A8
	private int keywordItemIconNum; // 0x1B0
	private bool isPopUpScenario; // 0x1B4
	private int popUpId; // 0x1B8
	private byte popUpPage; // 0x1BC
	private QuestManager questManager; // 0x1C0
	private bool isSkipReEnrty; // 0x1C8

	// Methods

	[IteratorStateMachine(typeof(UIQuestBoradManager.<Start>d__57))]
	// RVA: 0x1C52C58 Offset: 0x1C4EC58 VA: 0x1C52C58
	private IEnumerator Start() { }

	// RVA: 0x1C52CCC Offset: 0x1C4ECCC VA: 0x1C52CCC
	private void OnDestroy() { }

	// RVA: 0x1C52D80 Offset: 0x1C4ED80 VA: 0x1C52D80
	private UIQuestBoradButton AddQuestList(Vector3 position) { }

	[IteratorStateMachine(typeof(UIQuestBoradManager.<CreateQuestList>d__60))]
	// RVA: 0x1C52ED0 Offset: 0x1C4EED0 VA: 0x1C52ED0
	private IEnumerator CreateQuestList() { }

	// RVA: 0x1C4F05C Offset: 0x1C4B05C VA: 0x1C4F05C
	public void SelectButton(GameObject button, int id, bool scenarioType) { }

	// RVA: 0x1C53298 Offset: 0x1C4F298 VA: 0x1C53298 Slot: 7
	protected virtual void SelectScrollBoard(int scroll, int bit) { }

	// RVA: 0x1C534EC Offset: 0x1C4F4EC VA: 0x1C534EC
	private void OnTargetBoard() { }

	// RVA: 0x1C53518 Offset: 0x1C4F518 VA: 0x1C53518 Slot: 8
	protected virtual void OnAbandonBoard() { }

	// RVA: 0x1C53A54 Offset: 0x1C4FA54 VA: 0x1C53A54
	private void OnAbandonScenario() { }

	// RVA: 0x1C53AF4 Offset: 0x1C4FAF4 VA: 0x1C53AF4
	private void OnRepeatTextBoart() { }

	// RVA: 0x1C53CD4 Offset: 0x1C4FCD4 VA: 0x1C53CD4
	private void OnStaryBoart() { }

	// RVA: 0x1C53CF0 Offset: 0x1C4FCF0 VA: 0x1C53CF0
	private void OnItemSearchButon() { }

	[IteratorStateMachine(typeof(UIQuestBoradManager.<PopUpWindow>d__69))]
	// RVA: 0x1C53EC0 Offset: 0x1C4FEC0 VA: 0x1C53EC0
	protected IEnumerator PopUpWindow() { }

	// RVA: 0x1C53F34 Offset: 0x1C4FF34 VA: 0x1C53F34
	public void OnDrag(Vector2 delta) { }

	// RVA: 0x1C53F38 Offset: 0x1C4FF38 VA: 0x1C53F38
	public void OnScroll(float delta) { }

	// RVA: 0x1C53F3C Offset: 0x1C4FF3C VA: 0x1C53F3C
	public void ActivePopQuestBorad(bool scenarioType, int id, byte pop) { }

	// RVA: 0x1C52F44 Offset: 0x1C4EF44 VA: 0x1C52F44
	private void UpdateKeywordIcon() { }

	// RVA: 0x1C525CC Offset: 0x1C4E5CC VA: 0x1C525CC
	public bool TryOpenSkipChapterSelect() { }

	// RVA: 0x1C53F50 Offset: 0x1C4FF50 VA: 0x1C53F50
	public void OnSkipChapter(int param) { }

	[IteratorStateMachine(typeof(UIQuestBoradManager.<CreateChapterList>d__76))]
	// RVA: 0x1C53F70 Offset: 0x1C4FF70 VA: 0x1C53F70
	private IEnumerator CreateChapterList(int chapter) { }

	// RVA: 0x1C53FF4 Offset: 0x1C4FFF4 VA: 0x1C53FF4
	public void OnSkipEpisode(int param) { }

	[IteratorStateMachine(typeof(UIQuestBoradManager.<OpenSkipWindow>d__78))]
	// RVA: 0x1C54014 Offset: 0x1C50014 VA: 0x1C54014
	private IEnumerator OpenSkipWindow(int skipMissionId) { }

	// RVA: 0x1C54098 Offset: 0x1C50098 VA: 0x1C54098
	private bool CheckReturnSkipPanelState() { }

	// RVA: 0x1C54210 Offset: 0x1C50210 VA: 0x1C54210
	private int GetMissionMaxProgress() { }

	// RVA: 0x1C5250C Offset: 0x1C4E50C VA: 0x1C5250C
	public void OpenSkipErrorMapWindow() { }

	// RVA: 0x1C5256C Offset: 0x1C4E56C VA: 0x1C5256C
	public void OpenSkipErrorBattleWindow() { }

	// RVA: 0x1C54274 Offset: 0x1C50274 VA: 0x1C54274
	private void OpenSkipErrorWindow(string text) { }

	// RVA: 0x1C54440 Offset: 0x1C50440 VA: 0x1C54440
	private bool TryReEntryField() { }

	[IteratorStateMachine(typeof(UIQuestBoradManager.<ReEntryFieldProcess>d__85))]
	// RVA: 0x1C544E0 Offset: 0x1C504E0 VA: 0x1C544E0
	private IEnumerator ReEntryFieldProcess() { }

	// RVA: 0x1C54554 Offset: 0x1C50554 VA: 0x1C54554
	private void ChangeActiveSelectQuest(bool isActive) { }

	// RVA: 0x1C545EC Offset: 0x1C505EC VA: 0x1C545EC Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1C54744 Offset: 0x1C50744 VA: 0x1C54744 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1C547E4 Offset: 0x1C507E4 VA: 0x1C547E4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1C54924 Offset: 0x1C50924 VA: 0x1C54924
	private void <OpenSkipWindow>b__78_0() { }

	[CompilerGenerated]
	// RVA: 0x1C549B0 Offset: 0x1C509B0 VA: 0x1C549B0
	private void <OpenSkipWindow>b__78_1() { }
}
