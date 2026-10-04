// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPetSkillTreeManager : UIBasePanel // TypeDefIndex: 7839
{
	// Fields
	private UIPetSkillTreeManager.SkillTreeState treeState; // 0x2C
	private PlayerDataManager playerDataManager; // 0x30
	[SerializeField]
	private GameObject helpWindow; // 0x38
	private bool helpWindowFlag; // 0x40
	[SerializeField]
	private GameObject treeCamera; // 0x48
	private int selectSkillId; // 0x50
	private UIPopBaseWindow popWindow; // 0x58
	private bool inputLock; // 0x60
	private bool skillResetCancel; // 0x61
	private ItemTextManager itemTextManager; // 0x68
	[SerializeField]
	private GameObject uiSkillIcon; // 0x70
	private OrbManager orbManager; // 0x78
	private UIPetStatusManager statusManager; // 0x80
	private bool firstSkillFlag; // 0x88
	private int petSkillCount; // 0x8C
	private Dictionary<int, int> haveSkillList; // 0x90
	private int inheritSkillCount; // 0x98
	private Dictionary<int, int> inheritSkillList; // 0xA0
	private UIPetSkillTreePanel skillTreePanel; // 0xA8
	private int selectSkillTree; // 0xB0

	// Properties
	public UIPetSkillTreeManager.SkillTreeState GetTreeState { get; }
	public bool IsActiveHelpWindow { get; }
	public bool FirstSkill { get; }

	// Methods

	// RVA: 0x1C34560 Offset: 0x1C30560 VA: 0x1C34560
	public UIPetSkillTreeManager.SkillTreeState get_GetTreeState() { }

	// RVA: 0x1C34568 Offset: 0x1C30568 VA: 0x1C34568
	public bool get_IsActiveHelpWindow() { }

	// RVA: 0x1C34570 Offset: 0x1C30570 VA: 0x1C34570
	public bool get_FirstSkill() { }

	// RVA: 0x1C34578 Offset: 0x1C30578 VA: 0x1C34578
	private void Start() { }

	// RVA: 0x1C3483C Offset: 0x1C3083C VA: 0x1C3483C
	public void OnSkillTreeClickButton() { }

	// RVA: 0x1C34E94 Offset: 0x1C30E94 VA: 0x1C34E94
	private void OnHelpWindowOk() { }

	// RVA: 0x1C35A80 Offset: 0x1C31A80 VA: 0x1C35A80
	private void OnHelp() { }

	// RVA: 0x1C35B08 Offset: 0x1C31B08 VA: 0x1C35B08
	private void OnSkillTreeHoverButton(int id) { }

	// RVA: 0x1C35B0C Offset: 0x1C31B0C VA: 0x1C35B0C
	private void OnSelectSkillId(int skillId) { }

	// RVA: 0x1C35BA8 Offset: 0x1C31BA8 VA: 0x1C35BA8
	private void OnSkillLearnPopUp() { }

	[IteratorStateMachine(typeof(UIPetSkillTreeManager.<SkillLearnPopUpWndow>d__34))]
	// RVA: 0x1C35C2C Offset: 0x1C31C2C VA: 0x1C35C2C
	private IEnumerator SkillLearnPopUpWndow() { }

	// RVA: 0x1C35CC0 Offset: 0x1C31CC0 VA: 0x1C35CC0
	private void PopUpClose() { }

	// RVA: 0x1C35DCC Offset: 0x1C31DCC VA: 0x1C35DCC
	public void ReturnPopUpClose() { }

	[IteratorStateMachine(typeof(UIPetSkillTreeManager.<ConnectWait>d__37))]
	// RVA: 0x1C35DE8 Offset: 0x1C31DE8 VA: 0x1C35DE8
	private IEnumerator ConnectWait(Func<bool> connectionCheck, Action resultAction) { }

	// RVA: 0x1C35EAC Offset: 0x1C31EAC VA: 0x1C35EAC Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1C35F8C Offset: 0x1C31F8C VA: 0x1C35F8C Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1C36028 Offset: 0x1C32028 VA: 0x1C36028
	public void .ctor() { }
}
