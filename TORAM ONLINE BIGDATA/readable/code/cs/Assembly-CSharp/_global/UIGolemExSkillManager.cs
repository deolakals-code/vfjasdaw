// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGolemExSkillManager : UIBasePanelConnection // TypeDefIndex: 6808
{
	// Fields
	[SerializeField]
	private GameObject mainPanelObj; // 0x30
	[SerializeField]
	private GameObject backPanel; // 0x38
	[SerializeField]
	private UISprite titleIcon; // 0x40
	[SerializeField]
	private UILabel titleLabel; // 0x48
	[SerializeField]
	private GameObject switchButton; // 0x50
	[SerializeField]
	private UISprite switchButtonIcon; // 0x58
	[SerializeField]
	private UILabel switchButtonLabel; // 0x60
	[SerializeField]
	private GameObject[] panelObjs; // 0x68
	[SerializeField]
	private UISprite customBaseIcon; // 0x70
	[SerializeField]
	private GameObject[] customButtonObjs; // 0x78
	[SerializeField]
	private GameObject[] customObjs; // 0x80
	[SerializeField]
	private UIImageButton modelSettingButton; // 0x88
	[SerializeField]
	private UILabel modelSettingButtonLabel; // 0x90
	[SerializeField]
	private Transform modelTrans; // 0x98
	[SerializeField]
	private UILabel modelSettingLabel; // 0xA0
	[SerializeField]
	private UIIruna2DragPinch dragPinchPanel; // 0xA8
	private Dictionary<UIGolemExSkillManager.PointType, UIGolemExSkillManager.PointData> pointDataList; // 0xB0
	private UIGolemExSkillManager.PanelState panelState; // 0xB8
	private PlayerDataManager playerDataManager; // 0xC0
	private List<UISprite> allPointIconList; // 0xC8
	private int maxPoint; // 0xD0
	private int[] modelIdList; // 0xD8
	private List<GameObject> modelObjList; // 0xE0
	private int selectGolemId; // 0xE8
	private ExSkillCallGolem prevExSkillData; // 0xF0
	private ExSkillCallGolem nowExSkillData; // 0xF8
	private const int MAX_ALLOCATION_POINTS = 5;

	// Methods

	[IteratorStateMachine(typeof(UIGolemExSkillManager.<Start>d__30))]
	// RVA: 0x1A06B58 Offset: 0x1A02B58 VA: 0x1A06B58
	private IEnumerator Start() { }

	// RVA: 0x1A06BEC Offset: 0x1A02BEC VA: 0x1A06BEC
	private void Update() { }

	// RVA: 0x1A06D3C Offset: 0x1A02D3C VA: 0x1A06D3C
	public void OnSwitch() { }

	// RVA: 0x1A06F18 Offset: 0x1A02F18 VA: 0x1A06F18
	public void OnAttackChangeButton(int param) { }

	// RVA: 0x1A0759C Offset: 0x1A0359C VA: 0x1A0759C
	public void OnShieldChangeButton(int param) { }

	// RVA: 0x1A075BC Offset: 0x1A035BC VA: 0x1A075BC
	public void OnSpeedChangeButton(int param) { }

	// RVA: 0x1A075DC Offset: 0x1A035DC VA: 0x1A075DC
	public void OnModelChangeButton(int param) { }

	// RVA: 0x1A077E4 Offset: 0x1A037E4 VA: 0x1A077E4
	public void OnModelSelectButton() { }

	// RVA: 0x1A06DAC Offset: 0x1A02DAC VA: 0x1A06DAC
	private void ChangePanelState(UIGolemExSkillManager.PanelState panelState) { }

	// RVA: 0x1A078BC Offset: 0x1A038BC VA: 0x1A078BC
	private void SetTitle(string iconName, string text) { }

	// RVA: 0x1A078FC Offset: 0x1A038FC VA: 0x1A078FC
	private void UpdateSwitchButton() { }

	// RVA: 0x1A079E8 Offset: 0x1A039E8 VA: 0x1A079E8
	private GameObject CreatePointIcon(Transform parent, Vector3 pos) { }

	// RVA: 0x1A07150 Offset: 0x1A03150 VA: 0x1A07150
	private void UpdatePoint() { }

	// RVA: 0x1A06F38 Offset: 0x1A02F38 VA: 0x1A06F38
	private void UpdateCustomButton(UIGolemExSkillManager.PointType type, int param) { }

	// RVA: 0x1A07B7C Offset: 0x1A03B7C VA: 0x1A07B7C
	private int RemainingPoints() { }

	// RVA: 0x1A07734 Offset: 0x1A03734 VA: 0x1A07734
	private void UpdateModelSelectButton() { }

	[IteratorStateMachine(typeof(UIGolemExSkillManager.<LoadModel>d__46))]
	// RVA: 0x1A07C88 Offset: 0x1A03C88 VA: 0x1A07C88
	private IEnumerator LoadModel(int modelId) { }

	[IteratorStateMachine(typeof(UIGolemExSkillManager.<CloseSaveData>d__47))]
	// RVA: 0x1A07D2C Offset: 0x1A03D2C VA: 0x1A07D2C
	private IEnumerator CloseSaveData(UIActiveState nextActiveState) { }

	// RVA: 0x1A07DD0 Offset: 0x1A03DD0 VA: 0x1A07DD0 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1A07E68 Offset: 0x1A03E68 VA: 0x1A07E68 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1A07EE0 Offset: 0x1A03EE0 VA: 0x1A07EE0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1A08114 Offset: 0x1A04114 VA: 0x1A08114
	private bool <Start>b__30_0() { }

	[CompilerGenerated]
	// RVA: 0x1A08184 Offset: 0x1A04184 VA: 0x1A08184
	private void <Start>b__30_1() { }

	[CompilerGenerated]
	// RVA: 0x1A08208 Offset: 0x1A04208 VA: 0x1A08208
	private void <CloseSaveData>b__47_1() { }
}
