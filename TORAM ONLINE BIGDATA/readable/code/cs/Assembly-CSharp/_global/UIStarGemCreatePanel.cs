// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIStarGemCreatePanel : MonoBehaviour, UIStarGemBasePanel // TypeDefIndex: 8004
{
	// Fields
	[SerializeField]
	private GameObject createSelectObj; // 0x20
	[SerializeField]
	private GameObject createSkillObj; // 0x28
	[SerializeField]
	private UIImageButton[] createButtons; // 0x30
	[SerializeField]
	private UILabel pieceNumLabels; // 0x38
	[SerializeField]
	private Transform centerPanel; // 0x40
	[SerializeField]
	private UIScrollWindow listScrollWindow; // 0x48
	[SerializeField]
	private GameObject listPanel; // 0x50
	[SerializeField]
	private GameObject scrollExObj; // 0x58
	[SerializeField]
	private GameObject scrollSkillObj; // 0x60
	[SerializeField]
	private GameObject gachaElement; // 0x68
	[SerializeField]
	private GameObject gachaPanel; // 0x70
	[SerializeField]
	private UIImageButton gachaButton; // 0x78
	[SerializeField]
	private UILabel gachaButtonLabel; // 0x80
	[SerializeField]
	private UIIruna2Anchor orbAnchor; // 0x88
	[SerializeField]
	private UILabel orbNumLabel; // 0x90
	private UIStarGemMainManager manager; // 0x98
	private SystemTextManager systemTextManager; // 0xA0
	private SkillTextManager skillTextManager; // 0xA8
	private UIIruna2Anchor anchor; // 0xB0
	private GameObject listButtonObj; // 0xB8
	private UIPopBaseWindow popWindow; // 0xC0
	private bool isPopUpWindow; // 0xC8
	private bool isDelayPopWindow; // 0xC9
	private Action returnCall; // 0xD0
	private int selectSkillTreeId; // 0xD8
	private PlayerDataManager playerDataManager; // 0xE0
	private Dictionary<SkillTreeType, List<SkillMasterData>> createSkillList; // 0xE8
	private UILabel randomCreateButtonLabel; // 0xF0
	private UILabel createButtonLabel; // 0xF8
	private bool isSystemLockWindow; // 0x100

	// Methods

	// RVA: 0x1C93710 Offset: 0x1C8F710 VA: 0x1C93710 Slot: 4
	public void Initialize(UIStarGemMainManager manager, SystemTextManager systemTextManager) { }

	// RVA: 0x1C93DD0 Offset: 0x1C8FDD0 VA: 0x1C93DD0 Slot: 8
	public void FadeIn() { }

	// RVA: 0x1C942BC Offset: 0x1C902BC VA: 0x1C942BC Slot: 9
	public void FadeOut() { }

	// RVA: 0x1C94324 Offset: 0x1C90324 VA: 0x1C94324 Slot: 5
	public bool PushLeftTopButton() { }

	// RVA: 0x1C9447C Offset: 0x1C9047C VA: 0x1C9447C Slot: 6
	public bool PushRightTopButton() { }

	// RVA: 0x1C94484 Offset: 0x1C90484 VA: 0x1C94484 Slot: 7
	public GameObject Panel() { }

	// RVA: 0x1C9448C Offset: 0x1C9048C VA: 0x1C9448C
	private void TopEvnet() { }

	[IteratorStateMachine(typeof(UIStarGemCreatePanel.<OpenHelpWindow>d__37))]
	// RVA: 0x1C944E8 Offset: 0x1C904E8 VA: 0x1C944E8
	private IEnumerator OpenHelpWindow() { }

	// RVA: 0x1C9457C Offset: 0x1C9057C VA: 0x1C9457C
	private void SetSkillTreeList() { }

	[IteratorStateMachine(typeof(UIStarGemCreatePanel.<CreateStarGem>d__39))]
	// RVA: 0x1C94A80 Offset: 0x1C90A80 VA: 0x1C94A80
	private IEnumerator CreateStarGem(int skillId) { }

	// RVA: 0x1C94B24 Offset: 0x1C90B24 VA: 0x1C94B24
	private void OnClickRandomCreate() { }

	// RVA: 0x1C94B50 Offset: 0x1C90B50 VA: 0x1C94B50
	private void OnClickCreateAnySelect() { }

	// RVA: 0x1C94C10 Offset: 0x1C90C10 VA: 0x1C94C10
	private void OnClickHelpButton() { }

	// RVA: 0x1C94CB8 Offset: 0x1C90CB8 VA: 0x1C94CB8
	private void OnResetSelectSkillTree() { }

	// RVA: 0x1C94CE4 Offset: 0x1C90CE4 VA: 0x1C94CE4
	private void OnClickSkillTreeButton(int param) { }

	// RVA: 0x1C95330 Offset: 0x1C91330 VA: 0x1C95330
	private void OnClickSkillButton(int skillId) { }

	// RVA: 0x1C95644 Offset: 0x1C91644 VA: 0x1C95644
	private void OnClickListButton() { }

	// RVA: 0x1C960D8 Offset: 0x1C920D8 VA: 0x1C960D8
	private void OnClickGacha() { }

	// RVA: 0x1C963CC Offset: 0x1C923CC VA: 0x1C963CC
	private void OnClickBuyStarGem() { }

	[IteratorStateMachine(typeof(UIStarGemCreatePanel.<StarGemExchangeRandomDirect>d__49))]
	// RVA: 0x1C96520 Offset: 0x1C92520 VA: 0x1C96520
	private IEnumerator StarGemExchangeRandomDirect() { }

	// RVA: 0x1C965B4 Offset: 0x1C925B4 VA: 0x1C965B4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1C965C4 Offset: 0x1C925C4 VA: 0x1C965C4
	private void <OpenHelpWindow>b__37_0() { }
}
