// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIParameterManager : UIBasePanel // TypeDefIndex: 6860
{
	// Fields
	[SerializeField]
	private UIIruna2Anchor changeButtonAnchor; // 0x30
	private GameObject changeButtonObject; // 0x38
	private UIImageButton changeImageButton; // 0x40
	[SerializeField]
	private UIIruna2Anchor commonAnchor; // 0x48
	private GameObject nameChangeButtonObject; // 0x50
	private UIImageButton nameChangeImageButton; // 0x58
	private GameObject deleteButtonObject; // 0x60
	private UIImageButton deleteImageButton; // 0x68
	[SerializeField]
	private UILabel commandLevelLabel; // 0x70
	[SerializeField]
	private UILabel commandNameLabel; // 0x78
	[SerializeField]
	private UILabel commandUidLabel; // 0x80
	private UIInput nameInput; // 0x88
	[SerializeField]
	private UIIruna2Anchor statusAnchor; // 0x90
	private UIParameterStatusPanel statusPanel; // 0x98
	[SerializeField]
	private GameObject listButton; // 0xA0
	[SerializeField]
	private UILabel listLevelLabel; // 0xA8
	[SerializeField]
	private UILabel listNameLabel; // 0xB0
	[SerializeField]
	private UISprite parameterIcon; // 0xB8
	[SerializeField]
	private GameObject scenarioIcon; // 0xC0
	[SerializeField]
	private GameObject scenarioProgressIcon; // 0xC8
	[SerializeField]
	private GameObject orbButton; // 0xD0
	[SerializeField]
	private GameObject styleButton; // 0xD8
	[SerializeField]
	private GameObject windowStatusPanel; // 0xE0
	[SerializeField]
	private UIInput deleteInput; // 0xE8
	[SerializeField]
	private UIIruna2Anchor sortAnchor; // 0xF0
	private GameObject sortButtonObject; // 0xF8
	[SerializeField]
	private GameObject skillSettingObj; // 0x100
	private byte[] editOrderList; // 0x108
	[SerializeField]
	private UILabel partnerTitleLabel; // 0x110
	[SerializeField]
	private GameObject accompanyButtonObj; // 0x118
	private UISprite batsuIcon; // 0x120
	[SerializeField]
	private GameObject accompanyButtonSettings; // 0x128
	[SerializeField]
	private GameObject popWinodwObj; // 0x130
	[SerializeField]
	private GameObject attackerObj; // 0x138
	[SerializeField]
	private GameObject defenderObj; // 0x140
	[SerializeField]
	private UILabel[] expText; // 0x148
	[SerializeField]
	private UILabel buttonLabel; // 0x150
	[SerializeField]
	private GameObject[] setPaenl; // 0x158
	private UISprite[] selectedIcon; // 0x160
	private UILabel[] selectedLabel; // 0x168
	private MercenaryOperationManager mercenaryOperation; // 0x170
	private UIParameterManager.SelectPanelState panelState; // 0x178
	[SerializeField]
	private GameObject skillSettingRoot; // 0x180
	[SerializeField]
	private GameObject skillResultRoot; // 0x188
	[SerializeField]
	private GameObject skillScrollButton; // 0x190
	[SerializeField]
	private UIMercenaryIcon[] skillIcons; // 0x198
	[SerializeField]
	private UILabel[] skillNames; // 0x1A0
	[SerializeField]
	private UIMercenaryIcon[] condtionIcons; // 0x1A8
	[SerializeField]
	private UILabel[] conditionName; // 0x1B0
	[SerializeField]
	private GameObject pageDownButton; // 0x1B8
	[SerializeField]
	private GameObject pageSwitchButton; // 0x1C0
	[SerializeField]
	private GameObject resultChagePanleRoot; // 0x1C8
	[SerializeField]
	private BoxCollider skillSelectButton; // 0x1D0
	private bool activePopUpWindow; // 0x1D8
	private MissionTextManager missionTextManager; // 0x1E0
	private SkillTextManager skillTextManager; // 0x1E8
	private PlayerDataManager playerDataManager; // 0x1F0
	private int selectParamId; // 0x1F8
	private bool statusOpen; // 0x1FC
	private bool createCheck; // 0x1FD
	private UIScrollWindow scrollWindow; // 0x200
	private UIIruna2Anchor scrollWindowAnchor; // 0x208
	private UIScrollWindow settingScrollWindow; // 0x210
	private UIPopWindow recreatePop; // 0x218
	private List<GameObject> paramObjList; // 0x220
	private int listTopId; // 0x228
	private int lastScenarioId; // 0x22C
	private UILabel scenarioProgressLabel; // 0x230
	private int selectId; // 0x238
	private SkillId[] prevSettingSkills; // 0x240
	private SkillId[] settingSkill; // 0x248
	private AIActionCondition[] settingConditions; // 0x250
	private List<SkillData> avaivalSkillDataList; // 0x258
	private Dictionary<SkillTreeType, int> avaivalSkillTreeDic; // 0x260
	private int skillPanelDepth; // 0x268
	private const int settingSkillMax = 2;
	private ParameterGetActionSettingResponse getResponse; // 0x270

	// Properties
	private bool stateCheck { get; }

	// Methods

	// RVA: 0x1A0F85C Offset: 0x1A0B85C VA: 0x1A0F85C
	private bool get_stateCheck() { }

	// RVA: 0x1A0F900 Offset: 0x1A0B900 VA: 0x1A0F900
	private void Start() { }

	// RVA: 0x1A105D8 Offset: 0x1A0C5D8 VA: 0x1A105D8
	private void SetSkillSelectTypePanel() { }

	[IteratorStateMachine(typeof(UIParameterManager.<UpdateParametarListData>d__82))]
	// RVA: 0x1A10770 Offset: 0x1A0C770 VA: 0x1A10770
	private IEnumerator UpdateParametarListData(Action callback) { }

	// RVA: 0x1A10800 Offset: 0x1A0C800 VA: 0x1A10800
	private void OnDestroy() { }

	// RVA: 0x1A1025C Offset: 0x1A0C25C VA: 0x1A1025C
	private void CreateScrollWindow() { }

	// RVA: 0x1A108E8 Offset: 0x1A0C8E8 VA: 0x1A108E8
	private void UpdateParametarList() { }

	[IteratorStateMachine(typeof(UIParameterManager.<LoadScenarioProgressMissionText>d__86))]
	// RVA: 0x1A11D30 Offset: 0x1A0DD30 VA: 0x1A11D30
	private IEnumerator LoadScenarioProgressMissionText() { }

	// RVA: 0x1A10F08 Offset: 0x1A0CF08 VA: 0x1A10F08
	private void SetButton(string name, string text, int scenarioId, Vector3 position, int id, bool check) { }

	// RVA: 0x1A11D88 Offset: 0x1A0DD88 VA: 0x1A11D88
	private void SelectClear() { }

	// RVA: 0x1A10EB0 Offset: 0x1A0CEB0 VA: 0x1A10EB0
	private void ScrollActive(bool active) { }

	// RVA: 0x1A11324 Offset: 0x1A0D324 VA: 0x1A11324
	private void StatusPanelOpen() { }

	// RVA: 0x1A11F40 Offset: 0x1A0DF40 VA: 0x1A11F40
	private void UpdateParametarStatus() { }

	// RVA: 0x1A116D8 Offset: 0x1A0D6D8 VA: 0x1A116D8
	private void CommnadPanelOpen() { }

	// RVA: 0x1A123E4 Offset: 0x1A0E3E4 VA: 0x1A123E4
	private void OnParameterStatusCheck() { }

	[IteratorStateMachine(typeof(UIParameterManager.<ParameterStatusCheck>d__94))]
	// RVA: 0x1A1247C Offset: 0x1A0E47C VA: 0x1A1247C
	private IEnumerator ParameterStatusCheck() { }

	// RVA: 0x1A124F0 Offset: 0x1A0E4F0 VA: 0x1A124F0
	private void OnParameterNameChange() { }

	[IteratorStateMachine(typeof(UIParameterManager.<InputCheck>d__96))]
	// RVA: 0x1A12608 Offset: 0x1A0E608 VA: 0x1A12608
	private IEnumerator InputCheck(string baseName) { }

	[IteratorStateMachine(typeof(UIParameterManager.<OpenInputErrorWindow>d__97))]
	// RVA: 0x1A12698 Offset: 0x1A0E698 VA: 0x1A12698
	private IEnumerator OpenInputErrorWindow(bool isNGError = False) { }

	// RVA: 0x1A12720 Offset: 0x1A0E720 VA: 0x1A12720
	private void OnParameterDelete() { }

	[IteratorStateMachine(typeof(UIParameterManager.<ParameterDeleteInput>d__99))]
	// RVA: 0x1A1275C Offset: 0x1A0E75C VA: 0x1A1275C
	private IEnumerator ParameterDeleteInput() { }

	// RVA: 0x1A127D0 Offset: 0x1A0E7D0 VA: 0x1A127D0
	private bool DeleteInputCheck(UIPopBaseWindow window) { }

	// RVA: 0x1A1295C Offset: 0x1A0E95C VA: 0x1A1295C
	private void DeleteWindowSet(UIPopBaseWindow window) { }

	[IteratorStateMachine(typeof(UIParameterManager.<OnRecreate>d__102))]
	// RVA: 0x1A12B68 Offset: 0x1A0EB68 VA: 0x1A12B68
	private IEnumerator OnRecreate() { }

	// RVA: 0x1A12BDC Offset: 0x1A0EBDC VA: 0x1A12BDC
	private void OnParameterChange() { }

	[IteratorStateMachine(typeof(UIParameterManager.<ParameterChangeTime>d__104))]
	// RVA: 0x1A12C18 Offset: 0x1A0EC18 VA: 0x1A12C18
	private IEnumerator ParameterChangeTime() { }

	// RVA: 0x1A12C8C Offset: 0x1A0EC8C VA: 0x1A12C8C
	public void SelectedParameter(int id) { }

	[IteratorStateMachine(typeof(UIParameterManager.<SelectParam>d__106))]
	// RVA: 0x1A12CAC Offset: 0x1A0ECAC VA: 0x1A12CAC
	private IEnumerator SelectParam(int id) { }

	// RVA: 0x1A12D30 Offset: 0x1A0ED30 VA: 0x1A12D30
	private void OnSelectParamater(int select) { }

	// RVA: 0x1A12E98 Offset: 0x1A0EE98 VA: 0x1A12E98
	private void OnCreateParamater(int select) { }

	[IteratorStateMachine(typeof(UIParameterManager.<CreateParameter>d__109))]
	// RVA: 0x1A12F04 Offset: 0x1A0EF04 VA: 0x1A12F04
	private IEnumerator CreateParameter(int select) { }

	[IteratorStateMachine(typeof(UIParameterManager.<OnBuyNewSlot>d__110))]
	// RVA: 0x1A12F88 Offset: 0x1A0EF88 VA: 0x1A12F88
	private IEnumerator OnBuyNewSlot() { }

	[IteratorStateMachine(typeof(UIParameterManager.<BuyNewSlot>d__111))]
	// RVA: 0x1A12FFC Offset: 0x1A0EFFC VA: 0x1A12FFC
	private IEnumerator BuyNewSlot() { }

	// RVA: 0x1A13070 Offset: 0x1A0F070 VA: 0x1A13070
	private void OnParameterListSort() { }

	[IteratorStateMachine(typeof(UIParameterManager.<PopUpWindow>d__113))]
	// RVA: 0x1A133A8 Offset: 0x1A0F3A8 VA: 0x1A133A8
	private IEnumerator PopUpWindow(UIPopBaseWindow popWindow, Func<UIPopBaseWindow, bool> theradCheck, Action<int> result) { }

	// RVA: 0x1A13468 Offset: 0x1A0F468 VA: 0x1A13468
	private bool PopUpWindowCheck(UIPopBaseWindow popWindow) { }

	[IteratorStateMachine(typeof(UIParameterManager.<ConnectWait>d__115))]
	// RVA: 0x1A134B4 Offset: 0x1A0F4B4 VA: 0x1A134B4
	private IEnumerator ConnectWait(Func<bool> connectCheck) { }

	[IteratorStateMachine(typeof(UIParameterManager.<SetScenarioLabelWithIcon>d__116))]
	// RVA: 0x1A12E08 Offset: 0x1A0EE08 VA: 0x1A12E08
	private IEnumerator SetScenarioLabelWithIcon(ParameterData data) { }

	// RVA: 0x1A11FC8 Offset: 0x1A0DFC8 VA: 0x1A11FC8
	private void AccompanyButton(int id) { }

	[IteratorStateMachine(typeof(UIParameterManager.<PartnerJoin>d__118))]
	// RVA: 0x1A13544 Offset: 0x1A0F544 VA: 0x1A13544
	private IEnumerator PartnerJoin(byte partnerNo, StanceType type) { }

	// RVA: 0x1A135C8 Offset: 0x1A0F5C8 VA: 0x1A135C8
	private void OnAccompany() { }

	// RVA: 0x1A14290 Offset: 0x1A10290 VA: 0x1A14290
	private void OnActionSetting() { }

	[IteratorStateMachine(typeof(UIParameterManager.<PopUpStopChangeSkillMessage>d__121))]
	// RVA: 0x1A1477C Offset: 0x1A1077C VA: 0x1A1477C
	private IEnumerator PopUpStopChangeSkillMessage() { }

	[IteratorStateMachine(typeof(UIParameterManager.<PartnerRegisterGet>d__122))]
	// RVA: 0x1A147F0 Offset: 0x1A107F0 VA: 0x1A147F0
	private IEnumerator PartnerRegisterGet(byte charaParameterId) { }

	[IteratorStateMachine(typeof(UIParameterManager.<CheckingBecomeBattleActive>d__123))]
	// RVA: 0x1A14874 Offset: 0x1A10874 VA: 0x1A14874
	private IEnumerator CheckingBecomeBattleActive() { }

	// RVA: 0x1A148E8 Offset: 0x1A108E8 VA: 0x1A148E8
	private void SettingAvaivalSkillSetting(ParameterGetActionSettingResponse response) { }

	// RVA: 0x1A14990 Offset: 0x1A10990 VA: 0x1A14990
	private void AddSettingAvaivalSkillList(Dictionary<short, byte> list) { }

	// RVA: 0x1A14E18 Offset: 0x1A10E18 VA: 0x1A14E18
	private void OnSwitchSkillPage() { }

	// RVA: 0x1A14E3C Offset: 0x1A10E3C VA: 0x1A14E3C
	private void OpenSkillTreeScrollPanel() { }

	// RVA: 0x1A15530 Offset: 0x1A11530 VA: 0x1A15530
	private GameObject CreateSkillTreeButton(string functionName, int skillTreeId, int skillNum, Vector3 scrollPosition) { }

	// RVA: 0x1A15854 Offset: 0x1A11854 VA: 0x1A15854
	private void OnClickScrollDownLast() { }

	// RVA: 0x1A158D8 Offset: 0x1A118D8 VA: 0x1A158D8
	private void OnSkillTreeSelect(int skillTree) { }

	// RVA: 0x1A16058 Offset: 0x1A12058 VA: 0x1A16058
	private void SettingPartnerActionsUI(ParameterGetActionSettingResponse response) { }

	// RVA: 0x1A1651C Offset: 0x1A1251C VA: 0x1A1651C
	private AIActionCondition GetTransfarConditon(int target) { }

	// RVA: 0x1A16688 Offset: 0x1A12688 VA: 0x1A16688
	private int TransfarServerValueConditions(AIActionCondition condition) { }

	// RVA: 0x1A166DC Offset: 0x1A126DC VA: 0x1A166DC
	private void OnRegister() { }

	[IteratorStateMachine(typeof(UIParameterManager.<RegisterWaitTime>d__135))]
	// RVA: 0x1A16718 Offset: 0x1A12718 VA: 0x1A16718
	private IEnumerator RegisterWaitTime() { }

	[IteratorStateMachine(typeof(UIParameterManager.<SetUpRegisterUI>d__136))]
	// RVA: 0x1A1678C Offset: 0x1A1278C VA: 0x1A1678C
	private IEnumerator SetUpRegisterUI() { }

	// RVA: 0x1A16800 Offset: 0x1A12800 VA: 0x1A16800
	private void OnRegisterOk() { }

	// RVA: 0x1A168F8 Offset: 0x1A128F8 VA: 0x1A168F8
	private void OnOpenSkillSetting(int skillId, int selectId) { }

	// RVA: 0x1A16988 Offset: 0x1A12988 VA: 0x1A16988
	private void OnOpenConditionSetting(int conditionId, int selectId) { }

	// RVA: 0x1A16C38 Offset: 0x1A12C38 VA: 0x1A16C38
	private void OnDicideSkill(int skillId) { }

	// RVA: 0x1A16DFC Offset: 0x1A12DFC VA: 0x1A16DFC
	private void OnReleaseSkillSetting() { }

	// RVA: 0x1A16FE8 Offset: 0x1A12FE8 VA: 0x1A16FE8
	private void OnDicideCondition(int conditionId) { }

	// RVA: 0x1A170D4 Offset: 0x1A130D4 VA: 0x1A170D4
	private void PressSelectCondition(int conditionId) { }

	// RVA: 0x1A1510C Offset: 0x1A1110C VA: 0x1A1510C
	private void OpenSkillScroll() { }

	// RVA: 0x1A169D8 Offset: 0x1A129D8 VA: 0x1A169D8
	private void OpenConditionScroll() { }

	// RVA: 0x1A15BE8 Offset: 0x1A11BE8 VA: 0x1A15BE8
	private bool CehckAlreadySelect(SkillId checkSkillId) { }

	// RVA: 0x1A154A4 Offset: 0x1A114A4 VA: 0x1A154A4
	private bool CheckAlreadySelectSkilTreeType(SkillTreeType checkSkillTreeType) { }

	// RVA: 0x1A15C64 Offset: 0x1A11C64 VA: 0x1A15C64
	private GameObject CreateSkillButton(bool isSkillButton, string functionName, int skillId, int treeLevel, Vector3 scrollPosition) { }

	// RVA: 0x1A17200 Offset: 0x1A13200 VA: 0x1A17200
	private GameObject CreateConditionButton(bool isConditionButton, Vector3 scrollPosition, AIActionCondition condition, string functionName, string pressFunctionName) { }

	// RVA: 0x1A17480 Offset: 0x1A13480 VA: 0x1A17480
	private string GetConditionIconName(AIActionCondition condition) { }

	// RVA: 0x1A16540 Offset: 0x1A12540 VA: 0x1A16540
	private string GetConditionName(AIActionCondition condition) { }

	// RVA: 0x1A17568 Offset: 0x1A13568 VA: 0x1A17568
	private void ChangeSettingPanel() { }

	// RVA: 0x1A140CC Offset: 0x1A100CC VA: 0x1A140CC
	private void OnSelectAttacker() { }

	// RVA: 0x1A17710 Offset: 0x1A13710 VA: 0x1A17710
	private void OnSelectDefender() { }

	// RVA: 0x1A178D4 Offset: 0x1A138D4 VA: 0x1A178D4
	private void OnOK() { }

	// RVA: 0x1A17A80 Offset: 0x1A13A80 VA: 0x1A17A80 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1A17C84 Offset: 0x1A13C84 VA: 0x1A17C84 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1A17D6C Offset: 0x1A13D6C VA: 0x1A17D6C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1A17FD8 Offset: 0x1A13FD8 VA: 0x1A17FD8
	private void <Start>b__80_0() { }

	[CompilerGenerated]
	// RVA: 0x1A18004 Offset: 0x1A14004 VA: 0x1A18004
	private void <OnRecreate>b__102_0() { }

	[CompilerGenerated]
	// RVA: 0x1A18010 Offset: 0x1A14010 VA: 0x1A18010
	private void <OnBuyNewSlot>b__110_0() { }

	[CompilerGenerated]
	// RVA: 0x1A1801C Offset: 0x1A1401C VA: 0x1A1801C
	private void <PartnerJoin>b__118_0() { }

	[CompilerGenerated]
	// RVA: 0x1A18068 Offset: 0x1A14068 VA: 0x1A18068
	private void <PartnerRegisterGet>b__122_0(Game game, ParameterGetActionSettingResponse respoonese) { }
}
