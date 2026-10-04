// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UISkillTreeManager : UIBasePanel // TypeDefIndex: 6889
{
	// Fields
	private UISkillTreeManager.SkillTreeState treeState; // 0x2C
	private UISkillTreeManager.SkillMenuAdvice adviceState; // 0x30
	private PlayerDataManager playerDataManager; // 0x38
	[SerializeField]
	private UIIruna2Anchor skillPointAnchor; // 0x40
	[SerializeField]
	private UILabel skillPointLabel; // 0x48
	[SerializeField]
	private UIIruna2Anchor shortcutButtonAnchor; // 0x50
	[SerializeField]
	private BoxCollider shortcutCollider; // 0x58
	private int selectSkillId; // 0x60
	private UIPopBaseWindow popWindow; // 0x68
	private bool inputLock; // 0x70
	private bool skillResetCancel; // 0x71
	private ItemTextManager itemTextManager; // 0x78
	[SerializeField]
	private GameObject uiSkillIcon; // 0x80
	private OrbManager orbManager; // 0x88
	[SerializeField]
	private GameObject adviceMenu; // 0x90
	[SerializeField]
	private GameObject advice; // 0x98
	[SerializeField]
	private UILabel adviceMessage; // 0xA0
	[SerializeField]
	private GameObject popUpIcon; // 0xA8
	[SerializeField]
	private GameObject freeRestWarningPanel; // 0xB0
	[SerializeField]
	private UILabel freeRestWarningLabel; // 0xB8
	private UIAdviceManager adviceManager; // 0xC0
	private byte freeResetCount; // 0xC8
	private int waitingNum; // 0xCC
	private UIPopWindow errPopWindow; // 0xD0
	private UIScrollWindow scrollWindow; // 0xD8
	private UIIruna2Anchor scrollWindowAnchor; // 0xE0
	private InactiveTimer scrollWindowTimer; // 0xE8
	[SerializeField]
	private GameObject scrollWindowButton; // 0xF0
	private UISkillTreePanel skillTreePanel; // 0xF8
	private int selectSkillTree; // 0x100

	// Methods

	// RVA: 0x1A31310 Offset: 0x1A2D310 VA: 0x1A31310
	private void Start() { }

	// RVA: 0x1A31928 Offset: 0x1A2D928 VA: 0x1A31928
	private void SkillTreeList() { }

	// RVA: 0x1A324D8 Offset: 0x1A2E4D8 VA: 0x1A324D8
	private void SelectSkillTreeMenu() { }

	// RVA: 0x1A32168 Offset: 0x1A2E168 VA: 0x1A32168
	private void SetSkillButton(float y, int type, int level) { }

	// RVA: 0x1A31EBC Offset: 0x1A2DEBC VA: 0x1A31EBC
	private void SetExSkillButton(float y) { }

	// RVA: 0x1A31FA0 Offset: 0x1A2DFA0 VA: 0x1A31FA0
	private void SetComboButton(float y) { }

	// RVA: 0x1A32084 Offset: 0x1A2E084 VA: 0x1A32084
	private void SetStarGemButton(float y) { }

	// RVA: 0x1A322EC Offset: 0x1A2E2EC VA: 0x1A322EC
	private void SetSkillTreeAllResetButton(float y) { }

	// RVA: 0x1A329E4 Offset: 0x1A2E9E4 VA: 0x1A329E4
	private GameObject CreateButton(float y, string text, string hoverFunction, string clickFunction) { }

	// RVA: 0x1A328C8 Offset: 0x1A2E8C8 VA: 0x1A328C8
	private GameObject CreateButton(float y, string text, string hoverFunction, string clickFunction, int sendParam) { }

	// RVA: 0x1A32AF4 Offset: 0x1A2EAF4 VA: 0x1A32AF4
	private GameObject CreateButton(float y, string text) { }

	// RVA: 0x1A32C74 Offset: 0x1A2EC74 VA: 0x1A32C74
	private void OnExSkillHoverButton() { }

	// RVA: 0x1A32CE0 Offset: 0x1A2ECE0 VA: 0x1A32CE0
	private void OnExSkillClickButton() { }

	// RVA: 0x1A32D6C Offset: 0x1A2ED6C VA: 0x1A32D6C
	private void OnComboHoverButton() { }

	// RVA: 0x1A32DD8 Offset: 0x1A2EDD8 VA: 0x1A32DD8
	private void OnComboClickButton() { }

	// RVA: 0x1A32E64 Offset: 0x1A2EE64 VA: 0x1A32E64
	private void OnStarGemHoverButton() { }

	// RVA: 0x1A32ED0 Offset: 0x1A2EED0 VA: 0x1A32ED0
	private void OnStarGemClickButton() { }

	// RVA: 0x1A32F5C Offset: 0x1A2EF5C VA: 0x1A32F5C
	private void OnSkillTreeAllResetHoverButton() { }

	// RVA: 0x1A32FC8 Offset: 0x1A2EFC8 VA: 0x1A32FC8
	private void OnSkillTreeAllResetClickButton() { }

	// RVA: 0x1A3312C Offset: 0x1A2F12C VA: 0x1A3312C
	public void SelectSkillTreeReset() { }

	[IteratorStateMachine(typeof(UISkillTreeManager.<SkillTreeResetPopUp>d__51))]
	// RVA: 0x1A33088 Offset: 0x1A2F088 VA: 0x1A33088
	private IEnumerator SkillTreeResetPopUp(string popMessage, int skillPt, int orbItemId, int skillTreeType) { }

	[IteratorStateMachine(typeof(UISkillTreeManager.<SkillTreeFreeResetPopUp>d__52))]
	// RVA: 0x1A3340C Offset: 0x1A2F40C VA: 0x1A3340C
	private IEnumerator SkillTreeFreeResetPopUp(string popMessage, int skillPt, int orbItemId, int skillTreeType) { }

	// RVA: 0x1A334D8 Offset: 0x1A2F4D8 VA: 0x1A334D8
	public void OnReceiveCompensationSkillResetErr(int num) { }

	// RVA: 0x1A334E0 Offset: 0x1A2F4E0 VA: 0x1A334E0
	private void OnSkillTreeClickButton(int id) { }

	// RVA: 0x1A33B00 Offset: 0x1A2FB00 VA: 0x1A33B00
	private void OnSkillTreeHoverButton(int id) { }

	// RVA: 0x1A33BA0 Offset: 0x1A2FBA0 VA: 0x1A33BA0
	private void OnSelectSkillId(int skillId) { }

	// RVA: 0x1A33C3C Offset: 0x1A2FC3C VA: 0x1A33C3C
	private void OnSkillLearnPopUp() { }

	[IteratorStateMachine(typeof(UISkillTreeManager.<SkillLearnPopUpWndow>d__60))]
	// RVA: 0x1A341FC Offset: 0x1A301FC VA: 0x1A341FC
	private IEnumerator SkillLearnPopUpWndow() { }

	// RVA: 0x1A34290 Offset: 0x1A30290 VA: 0x1A34290
	private void PopUpClose() { }

	// RVA: 0x1A34460 Offset: 0x1A30460 VA: 0x1A34460
	public void OnAdviceMessage() { }

	// RVA: 0x1A344CC Offset: 0x1A304CC VA: 0x1A344CC
	public void OnAdviceBackButton() { }

	// RVA: 0x1A317AC Offset: 0x1A2D7AC VA: 0x1A317AC
	public void ChangeAdviceState() { }

	// RVA: 0x1A31800 Offset: 0x1A2D800 VA: 0x1A31800
	public void SetAdviceData() { }

	[IteratorStateMachine(typeof(UISkillTreeManager.<ConnectWait>d__66))]
	// RVA: 0x1A34534 Offset: 0x1A30534 VA: 0x1A34534
	private IEnumerator ConnectWait(Func<bool> connectionCheck, Action resultAction) { }

	// RVA: 0x1A345F8 Offset: 0x1A305F8 VA: 0x1A345F8 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1A347E4 Offset: 0x1A307E4 VA: 0x1A347E4 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1A34888 Offset: 0x1A30888 VA: 0x1A34888
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1A34898 Offset: 0x1A30898 VA: 0x1A34898
	private bool <SkillLearnPopUpWndow>b__60_0(SkillMasterData x) { }

	[CompilerGenerated]
	// RVA: 0x1A348BC Offset: 0x1A308BC VA: 0x1A348BC
	private void <SetAdviceData>b__65_0() { }
}
