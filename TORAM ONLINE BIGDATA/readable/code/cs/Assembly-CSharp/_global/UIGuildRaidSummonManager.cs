// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGuildRaidSummonManager : UIBasePanelConnection // TypeDefIndex: 5777
{
	// Fields
	[SerializeField]
	private GameObject centerPanel; // 0x30
	[SerializeField]
	private GameObject mainMessagePanel; // 0x38
	[SerializeField]
	private GameObject selectMessagePanel; // 0x40
	[SerializeField]
	private GameObject summonTimerPanel; // 0x48
	[SerializeField]
	private UIImageButton selectEnterButton; // 0x50
	[SerializeField]
	private UILabel selectEnterErrLabel; // 0x58
	[SerializeField]
	private UILabel timerLabel; // 0x60
	[SerializeField]
	private UILabel medalLabel; // 0x68
	[SerializeField]
	private UILabel selectCostLabel; // 0x70
	[SerializeField]
	private UILabel[] selectTargetLabel; // 0x78
	[SerializeField]
	private UIIcon[] selectTargetIcon; // 0x80
	[SerializeField]
	private GameObject[] firstTryObject; // 0x88
	[SerializeField]
	private GameObject connectionPanel; // 0x90
	[SerializeField]
	private GameObject waitPanel; // 0x98
	[SerializeField]
	private UISlider waitSlider; // 0xA0
	[SerializeField]
	private UILabel waitLabel; // 0xA8
	[SerializeField]
	private GameObject resultPanel; // 0xB0
	[SerializeField]
	private UISprite titleIcon; // 0xB8
	[SerializeField]
	private UILabel titleLabel; // 0xC0
	[SerializeField]
	private UILabel waitingFirstLabel; // 0xC8
	[SerializeField]
	private GameObject modeChangePanel; // 0xD0
	[SerializeField]
	private GameObject[] practicePanels; // 0xD8
	[SerializeField]
	private GameObject[] playPanels; // 0xE0
	[SerializeField]
	private GameObject summonOKButton; // 0xE8
	[SerializeField]
	private GameObject practiceSummonEndButton; // 0xF0
	private PlayerDataManager playerDataManager; // 0xF8
	private GuildManager guildManager; // 0x100
	private bool isSummon; // 0x108
	private int selectedRaidId; // 0x10C
	private GuildRaidManager.RaidHeldData selectedRaidHeldData; // 0x110
	private List<int> selectRaidIds; // 0x118
	private int selectRaidIndex; // 0x120
	private bool isInit; // 0x124
	private bool isPracticeMode; // 0x125

	// Methods

	[IteratorStateMachine(typeof(UIGuildRaidSummonManager.<Start>d__36))]
	// RVA: 0x17E5DA4 Offset: 0x17E1DA4 VA: 0x17E5DA4
	private IEnumerator Start() { }

	// RVA: 0x17E5E38 Offset: 0x17E1E38 VA: 0x17E5E38
	private void ActivePanel(UIGuildRaidSummonManager.MenuType panel) { }

	// RVA: 0x17E5F00 Offset: 0x17E1F00 VA: 0x17E5F00
	private void SettingPanel() { }

	// RVA: 0x17E6100 Offset: 0x17E2100 VA: 0x17E6100
	private void SetActiveElementData(int raidId, GuildRaidManager.RaidHeldData updateData) { }

	[IteratorStateMachine(typeof(UIGuildRaidSummonManager.<WaitSummonConnectionTimer>d__40))]
	// RVA: 0x17E676C Offset: 0x17E276C VA: 0x17E676C
	private IEnumerator WaitSummonConnectionTimer() { }

	[IteratorStateMachine(typeof(UIGuildRaidSummonManager.<WaitPracticeEndConnectionTimer>d__41))]
	// RVA: 0x17E6800 Offset: 0x17E2800 VA: 0x17E6800
	private IEnumerator WaitPracticeEndConnectionTimer() { }

	// RVA: 0x17E6894 Offset: 0x17E2894 VA: 0x17E6894
	public void OnClick_PracticeMode(bool isPracticeMode) { }

	// RVA: 0x17E697C Offset: 0x17E297C VA: 0x17E697C
	public void OnClick_SelectChangeButton(int add) { }

	// RVA: 0x17E6AA4 Offset: 0x17E2AA4 VA: 0x17E6AA4
	public void OnClick_SummonEnterButton() { }

	// RVA: 0x17E6B3C Offset: 0x17E2B3C VA: 0x17E6B3C
	public void OnClick_SummonCancelButton() { }

	// RVA: 0x17E6B44 Offset: 0x17E2B44 VA: 0x17E6B44
	public void OnClick_SummonedButton() { }

	// RVA: 0x17E6BE0 Offset: 0x17E2BE0 VA: 0x17E6BE0
	public void OnClick_ClosedButton() { }

	// RVA: 0x17E6C6C Offset: 0x17E2C6C VA: 0x17E6C6C
	public void OnClick_PracticeSummonEndButton() { }

	// RVA: 0x17E6D24 Offset: 0x17E2D24 VA: 0x17E6D24 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x17E6DD4 Offset: 0x17E2DD4 VA: 0x17E6DD4 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x17E6E78 Offset: 0x17E2E78 VA: 0x17E6E78
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x17E6F00 Offset: 0x17E2F00 VA: 0x17E6F00
	private void <Start>b__36_0() { }

	[CompilerGenerated]
	// RVA: 0x17E6F0C Offset: 0x17E2F0C VA: 0x17E6F0C
	private void <Start>b__36_1() { }

	[CompilerGenerated]
	// RVA: 0x17E6F18 Offset: 0x17E2F18 VA: 0x17E6F18
	private void <Start>b__36_2() { }

	[CompilerGenerated]
	// RVA: 0x17E6F24 Offset: 0x17E2F24 VA: 0x17E6F24
	private void <Start>b__36_3() { }

	[CompilerGenerated]
	// RVA: 0x17E6F30 Offset: 0x17E2F30 VA: 0x17E6F30
	private void <WaitSummonConnectionTimer>b__40_1() { }

	[CompilerGenerated]
	// RVA: 0x17E6F3C Offset: 0x17E2F3C VA: 0x17E6F3C
	private void <WaitPracticeEndConnectionTimer>b__41_1() { }
}
