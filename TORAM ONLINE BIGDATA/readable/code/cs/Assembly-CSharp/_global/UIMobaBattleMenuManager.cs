// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMobaBattleMenuManager : UIBasePanelConnection // TypeDefIndex: 6041
{
	// Fields
	[SerializeField]
	private UISprite titleIcon; // 0x30
	[SerializeField]
	private UILabel titleLabel; // 0x38
	[SerializeField]
	private GameObject titleObj; // 0x40
	[SerializeField]
	private GameObject frameObj; // 0x48
	[SerializeField]
	private GameObject[] menuPanels; // 0x50
	[SerializeField]
	private GameObject[] helpPanels; // 0x58
	[SerializeField]
	private UILabel[] helpPanelLabels; // 0x60
	[SerializeField]
	private UIScrollWindow historyScrollWindow; // 0x68
	[SerializeField]
	private GameObject historyElement; // 0x70
	[SerializeField]
	private GameObject[] historyScrollAreaTrans; // 0x78
	[SerializeField]
	private GameObject nonHistoryLabel; // 0x80
	private UIMobaBattleMenuManager.PanelState panelState; // 0x88
	private readonly Dictionary<byte, int> HelpPageNumList; // 0x90
	private int helpPageNum; // 0x98
	private byte selectHelpId; // 0x9C
	private MobaHistoryData[] battleHistoryDatas; // 0xA0
	private bool isGetBattleHistoryData; // 0xA8
	private MobaDataManager mobaDataManager; // 0xB0
	private Dictionary<int, MobaGameResultData> historyDetailList; // 0xB8
	private List<MobaSkillData> skillChangeDataList; // 0xC0
	private List<MobaSkillData> skillEnableDataList; // 0xC8
	private UIMobaBattleMenuManager.HelpType helpType; // 0xD0
	private int helpSkillMaxPage; // 0xD4
	private SkillTextManager skillTextManager; // 0xD8
	private const int HelpAbilityMaxPage = 3;
	private const int HelpVsModeMaxPage = 2;

	// Methods

	// RVA: 0x1870CA0 Offset: 0x186CCA0 VA: 0x1870CA0
	private void Start() { }

	// RVA: 0x1871104 Offset: 0x186D104 VA: 0x1871104
	private void Update() { }

	// RVA: 0x1870F40 Offset: 0x186CF40 VA: 0x1870F40
	private void ChangePanelState(UIMobaBattleMenuManager.PanelState panelState) { }

	// RVA: 0x1871184 Offset: 0x186D184 VA: 0x1871184
	private void UpdateTitle(string iconName, string text) { }

	// RVA: 0x1871368 Offset: 0x186D368 VA: 0x1871368
	private void UpdateHistoryScrollWindow() { }

	// RVA: 0x1871D80 Offset: 0x186DD80 VA: 0x1871D80
	private void UpdateHistoryRankingScrollWindow(int param) { }

	// RVA: 0x1872784 Offset: 0x186E784 VA: 0x1872784
	private GameObject CreateElement(GameObject elementObj, Vector3 pos, Vector3 scale) { }

	// RVA: 0x187128C Offset: 0x186D28C VA: 0x187128C
	private void ChangeActiveHelpPanel(bool isSelect) { }

	// RVA: 0x1872880 Offset: 0x186E880 VA: 0x1872880
	private void UpdateHelpPage(int add) { }

	// RVA: 0x187321C Offset: 0x186F21C VA: 0x187321C
	private string GetSkillText(SkillMasterData master) { }

	[IteratorStateMachine(typeof(UIMobaBattleMenuManager.<GetBattleHistoryData>d__42))]
	// RVA: 0x1871220 Offset: 0x186D220 VA: 0x1871220
	private IEnumerator GetBattleHistoryData() { }

	[IteratorStateMachine(typeof(UIMobaBattleMenuManager.<GetHistoryDetailData>d__43))]
	// RVA: 0x18733A8 Offset: 0x186F3A8 VA: 0x18733A8
	private IEnumerator GetHistoryDetailData(int param) { }

	[IteratorStateMachine(typeof(UIMobaBattleMenuManager.<GetLimitedSkillList>d__44))]
	// RVA: 0x18712FC Offset: 0x186D2FC VA: 0x18712FC
	private IEnumerator GetLimitedSkillList() { }

	// RVA: 0x18711DC Offset: 0x186D1DC VA: 0x18711DC
	private void ChangeActiveTitleFrame(bool isActive) { }

	// RVA: 0x1873474 Offset: 0x186F474 VA: 0x1873474
	public void OnTopMenu(int param) { }

	// RVA: 0x1873570 Offset: 0x186F570 VA: 0x1873570
	public void OnHistory(int param) { }

	// RVA: 0x1873620 Offset: 0x186F620 VA: 0x1873620
	public void OnHelpMenu(int param) { }

	// RVA: 0x18736B0 Offset: 0x186F6B0 VA: 0x18736B0
	public void OnHelpPage(int param) { }

	// RVA: 0x187372C Offset: 0x186F72C VA: 0x187372C Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1873854 Offset: 0x186F854 VA: 0x1873854 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x18738E0 Offset: 0x186F8E0 VA: 0x18738E0
	public void .ctor() { }
}
