// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMagicExSkillManager : UIBasePanelConnection // TypeDefIndex: 6739
{
	// Fields
	[SerializeField]
	private ItemIcon titleItemIcon; // 0x30
	[SerializeField]
	private GameObject[] panelObjs; // 0x38
	[SerializeField]
	private UILabel pointLabel; // 0x40
	[SerializeField]
	private UISprite pointIcon; // 0x48
	[SerializeField]
	private UIScrollWindow selectScrollWindow; // 0x50
	[SerializeField]
	private UIMagicExSkillElement element; // 0x58
	[SerializeField]
	private UISprite[] infoExIcons; // 0x60
	[SerializeField]
	private UILabel[] infoExLabels; // 0x68
	private UIMagicExSkillManager.PanelState panelState; // 0x70
	private PlayerDataManager playerDataManager; // 0x78
	private int selectInfoParam; // 0x80
	private List<UIMagicExSkillManager.InfoExData> infoExDataList; // 0x88
	private readonly SkillId[] skills; // 0x90
	private bool inputLock; // 0x98
	private ExSkillSpellTuning prevExSkillData; // 0xA0
	private ExSkillSpellTuning nowExSkillData; // 0xA8
	private int maxTuningPoint; // 0xB0
	private List<UISprite> tuningPointIconList; // 0xB8

	// Methods

	// RVA: 0x19D0F44 Offset: 0x19CCF44 VA: 0x19D0F44
	private void Start() { }

	// RVA: 0x19D1E3C Offset: 0x19CDE3C VA: 0x19D1E3C
	public void OnInfo() { }

	// RVA: 0x19D1FB0 Offset: 0x19CDFB0 VA: 0x19D1FB0
	public void OnInfoArrow(int add) { }

	// RVA: 0x19D11EC Offset: 0x19CD1EC VA: 0x19D11EC
	private void Initialize() { }

	// RVA: 0x19D1EAC Offset: 0x19CDEAC VA: 0x19D1EAC
	private void ChangePanelState(UIMagicExSkillManager.PanelState panelState) { }

	// RVA: 0x19D2084 Offset: 0x19CE084 VA: 0x19D2084
	private void UpadateInfo(UIMagicExSkillManager.InfoExData data) { }

	// RVA: 0x19D24DC Offset: 0x19CE4DC VA: 0x19D24DC
	private void UpdatePoint() { }

	// RVA: 0x19D26C0 Offset: 0x19CE6C0 VA: 0x19D26C0
	private void SetConfig(int skillId, ValueTuple<bool, bool> config) { }

	[IteratorStateMachine(typeof(UIMagicExSkillManager.<CloseUI>d__28))]
	// RVA: 0x19D26EC Offset: 0x19CE6EC VA: 0x19D26EC
	private IEnumerator CloseUI(bool isLeftTopButton) { }

	// RVA: 0x19D2794 Offset: 0x19CE794 VA: 0x19D2794 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x19D2840 Offset: 0x19CE840 VA: 0x19D2840 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x19D28CC Offset: 0x19CE8CC VA: 0x19D28CC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x19D2AD4 Offset: 0x19CEAD4 VA: 0x19D2AD4
	private bool <Start>b__20_0() { }

	[CompilerGenerated]
	// RVA: 0x19D2B44 Offset: 0x19CEB44 VA: 0x19D2B44
	private void <Start>b__20_1() { }

	[CompilerGenerated]
	// RVA: 0x19D2BD0 Offset: 0x19CEBD0 VA: 0x19D2BD0
	private bool <Initialize>b__23_0(int addPoint) { }

	[CompilerGenerated]
	// RVA: 0x19D2C10 Offset: 0x19CEC10 VA: 0x19D2C10
	private bool <CloseUI>b__28_0() { }
}
