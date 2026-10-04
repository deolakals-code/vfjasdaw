// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIRegisterMercenaryManager : UIBasePanel // TypeDefIndex: 7429
{
	// Fields
	private UIRegisterMercenaryManager.PanelState panelState; // 0x2C
	private UIRegisterMercenaryManager.Type type; // 0x30
	private StanceType stanceType; // 0x34
	[SerializeField]
	private GameObject panelObject; // 0x38
	[SerializeField]
	private GameObject beforeRegistPanel; // 0x40
	[SerializeField]
	private GameObject afterRegistPanel; // 0x48
	[SerializeField]
	private GameObject attackerObj; // 0x50
	[SerializeField]
	private GameObject defenderObj; // 0x58
	[SerializeField]
	private UILabel titleLabel; // 0x60
	[SerializeField]
	private UILabel expText; // 0x68
	[SerializeField]
	private UILabel decisionTypeLabel; // 0x70
	[SerializeField]
	private GameObject[] statusObj; // 0x78
	[SerializeField]
	private GameObject buttonObj; // 0x80
	private UILabel buttonLabel; // 0x88
	[SerializeField]
	private GameObject rootObject; // 0x90
	[SerializeField]
	private GameObject mainRootObject; // 0x98
	[SerializeField]
	private UIMercenaryIcon[] mercenaryIcons; // 0xA0
	[SerializeField]
	private UIMercenaryIcon[] conditionIcons; // 0xA8
	[SerializeField]
	private UILabel[] displaySkillNames; // 0xB0
	[SerializeField]
	private UILabel[] displayConditionNames; // 0xB8
	[SerializeField]
	private UILabel[] nonChangeLabels; // 0xC0
	private UIScrollWindow scrollWindow; // 0xC8
	[SerializeField]
	private GameObject ScrollButton; // 0xD0
	[SerializeField]
	private GameObject pageDownButton; // 0xD8
	[SerializeField]
	private GameObject pageSwitchButton; // 0xE0
	private UISprite[] selectedIcon; // 0xE8
	private UILabel[] selectedLabel; // 0xF0
	private UILabel typeExpLabel; // 0xF8
	private BoxCollider colider; // 0x100
	private const int skillSettingNum = 2;
	private UIPopBaseWindow popWindow; // 0x108
	private bool windowActiveFlg; // 0x110
	private PlayerDataManager playerDataManager; // 0x118
	private MercenaryOperationManager mercenaryOperation; // 0x120
	private MercenaryRegisterGetResponse getResponse; // 0x128
	private SkillTextManager skillTextManager; // 0x130
	private List<GameObject> scrollObjectList; // 0x138
	private List<SkillData> availableSkillList; // 0x140
	private Dictionary<SkillTreeType, int> avaiableSkillTreeDicList; // 0x148
	private int selectId; // 0x150
	private SkillId[] settingSkills; // 0x158
	private AIActionCondition[] conditions; // 0x160

	// Methods

	// RVA: 0x1B46FEC Offset: 0x1B42FEC VA: 0x1B46FEC
	private void Start() { }

	[IteratorStateMachine(typeof(UIRegisterMercenaryManager.<MercenaryRegisterGet>d__46))]
	// RVA: 0x1B47F9C Offset: 0x1B43F9C VA: 0x1B47F9C
	private IEnumerator MercenaryRegisterGet() { }

	// RVA: 0x1B48030 Offset: 0x1B44030 VA: 0x1B48030
	private void Initialize() { }

	// RVA: 0x1B47814 Offset: 0x1B43814 VA: 0x1B47814
	private void CreateAvailableSkillList() { }

	// RVA: 0x1B48250 Offset: 0x1B44250 VA: 0x1B48250
	private void SetSelectTypePanel() { }

	// RVA: 0x1B49878 Offset: 0x1B45878 VA: 0x1B49878
	private void SetSkillSelectTypePanel() { }

	// RVA: 0x1B48628 Offset: 0x1B44628 VA: 0x1B48628
	private void DesicionType(MercenaryRegisterResponse response) { }

	// RVA: 0x1B48078 Offset: 0x1B44078 VA: 0x1B48078
	private void SettingSkillPanelData(int settingNum) { }

	// RVA: 0x1B49D88 Offset: 0x1B45D88 VA: 0x1B49D88
	private void SetSkillIconActive(bool active, UIRegisterMercenaryManager.Status[] type) { }

	// RVA: 0x1B49D64 Offset: 0x1B45D64 VA: 0x1B49D64
	private AIActionCondition GetTransfarConditon(int target) { }

	// RVA: 0x1B49E18 Offset: 0x1B45E18 VA: 0x1B49E18
	private int TransfarServerValueConditions(AIActionCondition condition) { }

	// RVA: 0x1B496BC Offset: 0x1B456BC VA: 0x1B496BC
	private void SelectAttacker() { }

	// RVA: 0x1B49E6C Offset: 0x1B45E6C VA: 0x1B49E6C
	private void SelectDefender() { }

	// RVA: 0x1B4A028 Offset: 0x1B46028 VA: 0x1B4A028
	private void onOk() { }

	// RVA: 0x1B4A190 Offset: 0x1B46190 VA: 0x1B4A190
	private void OnOpenSkillSetting(int skillId, int selectId) { }

	// RVA: 0x1B4A690 Offset: 0x1B46690 VA: 0x1B4A690
	private void OnOpenConditionSetting(int conditionId, int selectedId) { }

	// RVA: 0x1B4A230 Offset: 0x1B46230 VA: 0x1B4A230
	private void OpenSkillScroll() { }

	// RVA: 0x1B4AE08 Offset: 0x1B46E08 VA: 0x1B4AE08
	private void OpenForcusedSkillScroll(int skillTreeType) { }

	// RVA: 0x1B4AA14 Offset: 0x1B46A14 VA: 0x1B4AA14
	private GameObject CreateSkillButton(bool IsSkillButton, string functionName, int skillId, int treeLevel, Vector3 scrollPosition) { }

	// RVA: 0x1B4B27C Offset: 0x1B4727C VA: 0x1B4B27C
	private GameObject CreateConditionButton(bool isConditionButton, Vector3 scrollPosition, AIActionCondition condition, string functionName, string pressFunctionName) { }

	// RVA: 0x1B4B5E4 Offset: 0x1B475E4 VA: 0x1B4B5E4
	private void OpenSkillTreeScroll() { }

	// RVA: 0x1B4B9E4 Offset: 0x1B479E4 VA: 0x1B4B9E4
	private GameObject CreateSkillTreeTypeButton(string functionName, int skillTreeId, int skillNum, Vector3 scrollPosition) { }

	// RVA: 0x1B4A998 Offset: 0x1B46998 VA: 0x1B4A998
	private bool CheckAlreadySelect(SkillId checkSkill) { }

	// RVA: 0x1B4B958 Offset: 0x1B47958 VA: 0x1B4B958
	private bool CheckAlreadySelectSkilTreeType(SkillTreeType checkSkillTreeType) { }

	// RVA: 0x1B4A6E4 Offset: 0x1B466E4 VA: 0x1B4A6E4
	private void OpenConditionScroll() { }

	// RVA: 0x1B4BD08 Offset: 0x1B47D08 VA: 0x1B4BD08
	private void OnDicideSkill(int skillId) { }

	// RVA: 0x1B4BDF8 Offset: 0x1B47DF8 VA: 0x1B4BDF8
	private void CleanSelectSkillUI(int skillId) { }

	// RVA: 0x1B4C0EC Offset: 0x1B480EC VA: 0x1B4C0EC
	private void OnReleaseSkill() { }

	// RVA: 0x1B4C160 Offset: 0x1B48160 VA: 0x1B4C160
	private void DesideCondition(int conditionId) { }

	// RVA: 0x1B4C234 Offset: 0x1B48234 VA: 0x1B4C234
	private void PressSelectCondition(int conditionId) { }

	// RVA: 0x1B4C360 Offset: 0x1B48360 VA: 0x1B4C360
	private void SkillTreeSelect(int skillTreeId) { }

	// RVA: 0x1B4C39C Offset: 0x1B4839C VA: 0x1B4C39C
	private void OnClickPageDownButton() { }

	// RVA: 0x1B4C420 Offset: 0x1B48420 VA: 0x1B4C420
	private void OnSwicthSkillPage() { }

	// RVA: 0x1B4BF1C Offset: 0x1B47F1C VA: 0x1B4BF1C
	private void ScrollButtonCleanUp() { }

	// RVA: 0x1B4B4FC Offset: 0x1B474FC VA: 0x1B4B4FC
	private string GetConditionIconName(AIActionCondition condition) { }

	// RVA: 0x1B49C1C Offset: 0x1B45C1C VA: 0x1B49C1C
	private string GetConditionName(AIActionCondition condition) { }

	[IteratorStateMachine(typeof(UIRegisterMercenaryManager.<Register>d__81))]
	// RVA: 0x1B4C498 Offset: 0x1B48498 VA: 0x1B4C498
	private IEnumerator Register() { }

	[IteratorStateMachine(typeof(UIRegisterMercenaryManager.<RegisterWaitTime>d__82))]
	// RVA: 0x1B4A124 Offset: 0x1B46124 VA: 0x1B4A124
	private IEnumerator RegisterWaitTime() { }

	[IteratorStateMachine(typeof(UIRegisterMercenaryManager.<PopUpWindow>d__83))]
	// RVA: 0x1B4C554 Offset: 0x1B48554 VA: 0x1B4C554
	private IEnumerator PopUpWindow(UIPopBaseWindow popWindow, Func<UIPopBaseWindow, bool> theradCheck, Action<int> result) { }

	// RVA: 0x1B4C634 Offset: 0x1B48634 VA: 0x1B4C634
	private bool PopUpWindowCheck(UIPopBaseWindow popWindow) { }

	// RVA: 0x1B4C680 Offset: 0x1B48680 VA: 0x1B4C680
	private void SetPanelState(UIRegisterMercenaryManager.PanelState setState) { }

	// RVA: 0x1B4C688 Offset: 0x1B48688 VA: 0x1B4C688 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1B4C798 Offset: 0x1B48798 VA: 0x1B4C798 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1B4C80C Offset: 0x1B4880C VA: 0x1B4C80C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1B4C954 Offset: 0x1B48954 VA: 0x1B4C954
	private void <MercenaryRegisterGet>b__46_0(Game game, MercenaryRegisterGetResponse response) { }
}
