// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMinstrelExSkillManager : UIBasePanelConnection // TypeDefIndex: 6747
{
	// Fields
	[SerializeField]
	private UIScrollWindow skillScrollWindow; // 0x30
	[SerializeField]
	private UIMinstrelExSkillElement skillElement; // 0x38
	[SerializeField]
	private GameObject tweenPanel; // 0x40
	[SerializeField]
	private GameObject changeSkillElement; // 0x48
	[SerializeField]
	private UICharacterModelBaseManager modelManager; // 0x50
	private List<UIMinstrelExSkillElement> skillListElements; // 0x58
	private SkillTextManager skillTextManager; // 0x60
	private PlayerDataManager pData; // 0x68
	private ExSkillSetlist dataBase; // 0x70
	private ExSkillSetlist beforeDataBase; // 0x78
	private UIScrollWindow changeSkillScrollWindow; // 0x80
	private UIIruna2Anchor changeSkillScrollWindowAnchor; // 0x88
	private UIMinstrelExSkillManager.ChangeSkillButton changeSkillButton; // 0x90
	private UIMinstrelExSkillManager.PanelState panelState; // 0x98
	private List<SkillId> playerSongActionSkill; // 0xA0

	// Properties
	public bool InputLock { get; }
	public UIMinstrelExSkillManager.PanelState ActivePanelState { get; }

	// Methods

	// RVA: 0x19D3A14 Offset: 0x19CFA14 VA: 0x19D3A14
	public bool get_InputLock() { }

	// RVA: 0x19D3B2C Offset: 0x19CFB2C VA: 0x19D3B2C
	public UIMinstrelExSkillManager.PanelState get_ActivePanelState() { }

	// RVA: 0x19D3B34 Offset: 0x19CFB34 VA: 0x19D3B34
	private void Start() { }

	[IteratorStateMachine(typeof(UIMinstrelExSkillManager.<Initialize>d__22))]
	// RVA: 0x19D3F00 Offset: 0x19CFF00 VA: 0x19D3F00
	private IEnumerator Initialize() { }

	// RVA: 0x19D3F74 Offset: 0x19CFF74 VA: 0x19D3F74
	private void CloseUI(bool isLeft) { }

	// RVA: 0x19D4B04 Offset: 0x19D0B04 VA: 0x19D4B04
	private void InitializeSelectSkillButtons() { }

	// RVA: 0x19D57FC Offset: 0x19D17FC VA: 0x19D57FC
	private void ClearElements() { }

	// RVA: 0x19D587C Offset: 0x19D187C VA: 0x19D587C
	private void InitializeChangeSkillButtons(int index) { }

	// RVA: 0x19D6204 Offset: 0x19D2204 VA: 0x19D6204
	public void ChangePanel(UIMinstrelExSkillManager.PanelState state) { }

	// RVA: 0x19D6334 Offset: 0x19D2334 VA: 0x19D6334
	public void OnClickChangeToggle(int index) { }

	// RVA: 0x19D6694 Offset: 0x19D2694 VA: 0x19D6694
	public void OnClickChangeSkill(int index) { }

	// RVA: 0x19D6724 Offset: 0x19D2724 VA: 0x19D6724
	public void OnClickChangeOrder(int index) { }

	// RVA: 0x19D6E54 Offset: 0x19D2E54 VA: 0x19D6E54
	public void OnClickChangeSkillSelect(int index, int skillId) { }

	// RVA: 0x19D6F94 Offset: 0x19D2F94 VA: 0x19D6F94
	public void OnClickRemoveSkill(int index) { }

	// RVA: 0x19D7554 Offset: 0x19D3554 VA: 0x19D7554 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x19D75F0 Offset: 0x19D35F0 VA: 0x19D75F0 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x19D7658 Offset: 0x19D3658 VA: 0x19D7658
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x19D7660 Offset: 0x19D3660 VA: 0x19D7660
	private bool <Initialize>b__22_0() { }

	[CompilerGenerated]
	// RVA: 0x19D7688 Offset: 0x19D3688 VA: 0x19D7688
	private bool <CloseUI>b__23_0() { }
}
