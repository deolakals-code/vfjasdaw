// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPetSyntheticPanel : MonoBehaviour // TypeDefIndex: 7757
{
	// Fields
	private PetSyntheticPanelState panelState; // 0x20
	[SerializeField]
	private GameObject mainPanel; // 0x28
	[SerializeField]
	private UILabel titleLabel; // 0x30
	[SerializeField]
	private GameObject costObj; // 0x38
	[SerializeField]
	private UILabel goldCostLabel; // 0x40
	[SerializeField]
	private GameObject orbCostObj; // 0x48
	private UILabel orbCostLabel; // 0x50
	[SerializeField]
	private UIIruna2Anchor orbPanel; // 0x58
	[SerializeField]
	private UILabel orbNumLabel; // 0x60
	[SerializeField]
	private UILabel attentionLabel; // 0x68
	[SerializeField]
	private UIImageButton mainButton; // 0x70
	private UIButtonMessage buttonMessage; // 0x78
	private UILabel buttonLabel; // 0x80
	[SerializeField]
	private UIPetSyntheticSelectForm selectFormPanel; // 0x88
	[SerializeField]
	private UIPetSyntheticSelectColor selectColorPanel; // 0x90
	[SerializeField]
	private UIPetSyntheticSelectSkill selectSkillPanel; // 0x98
	[SerializeField]
	private UIPetSyntheticSelectType selectTypePanel; // 0xA0
	[SerializeField]
	private UIPetSyntheticResultPanel resultPropPanel; // 0xA8
	[SerializeField]
	private GameObject cameraParentObj; // 0xB0
	[SerializeField]
	private GameObject cameraAreaParentObj; // 0xB8
	[SerializeField]
	private GameObject[] cameraObj; // 0xC0
	private Camera[] modelCamera; // 0xC8
	[SerializeField]
	private GameObject[] cameraAreaObj; // 0xD0
	[SerializeField]
	private GameObject[] cameraTopLeftObj; // 0xD8
	[SerializeField]
	private GameObject[] cameraBottomRightObj; // 0xE0
	[SerializeField]
	private MeshRenderer[] cameraFadeObj; // 0xE8
	[SerializeField]
	private Transform[] modelParent; // 0xF0
	private GameObject[] petModelObj; // 0xF8
	[SerializeField]
	private GameObject selectElementObj; // 0x100
	[SerializeField]
	private GameObject backPanel; // 0x108
	[SerializeField]
	private UIIruna2DragPinch dragPinch; // 0x110
	private float modelAngle; // 0x118
	private PetSynthesisData synthesisData; // 0x120
	private PetDataManager.SyntheticSelectData[] targetPetData; // 0x128
	private int selectedFormParam; // 0x130
	private Color[] baseModelColor; // 0x138
	private PlayerDataManager playerDataManager; // 0x140
	private SystemTextManager systemTextManager; // 0x148
	private int useGold; // 0x150
	private int useOrb; // 0x154
	private bool[] colorUseOrb; // 0x158
	private PetOperationManager petOperation; // 0x160
	private Action returnAction; // 0x168
	private UIPetSyntheticManager.PanelType panelType; // 0x170

	// Properties
	public PetSyntheticPanelState PanelState { get; }
	public UIPetSyntheticManager.PanelType PanelType { get; }

	// Methods

	// RVA: 0x1C007C4 Offset: 0x1BFC7C4 VA: 0x1C007C4
	public PetSyntheticPanelState get_PanelState() { }

	// RVA: 0x1C007CC Offset: 0x1BFC7CC VA: 0x1C007CC
	public UIPetSyntheticManager.PanelType get_PanelType() { }

	// RVA: 0x1BFFF94 Offset: 0x1BFBF94 VA: 0x1BFFF94
	public void ResetPanelState() { }

	// RVA: 0x1BFF208 Offset: 0x1BFB208 VA: 0x1BFF208
	public void CreateTargetPetModel(int param, GameObject modelObj) { }

	// RVA: 0x1C00040 Offset: 0x1BFC040 VA: 0x1C00040
	public void DestroyTargetModel() { }

	// RVA: 0x1BFF6D4 Offset: 0x1BFB6D4 VA: 0x1BFF6D4
	public void Initialize(PetDataManager.SyntheticSelectData[] targetPetData, UIPetSyntheticManager.PanelType panelType, Action returnAction) { }

	// RVA: 0x1C00BA8 Offset: 0x1BFCBA8 VA: 0x1C00BA8
	public void ResetCost() { }

	// RVA: 0x1C01ABC Offset: 0x1BFDABC VA: 0x1C01ABC
	private void Update() { }

	// RVA: 0x1C00BCC Offset: 0x1BFCBCC VA: 0x1C00BCC
	private void ChangeSelectPanel(PetSyntheticPanelState nextState) { }

	// RVA: 0x1C01554 Offset: 0x1BFD554 VA: 0x1C01554
	private void SelectFormToColor(int param) { }

	// RVA: 0x1C01F98 Offset: 0x1BFDF98 VA: 0x1C01F98
	private void SelectColorToSkill(bool[] isUseOrb, bool[] colors) { }

	// RVA: 0x1C02368 Offset: 0x1BFE368 VA: 0x1C02368
	private void SelectSkillToType(int[] skillId, int[] skillLv) { }

	// RVA: 0x1C02494 Offset: 0x1BFE494 VA: 0x1C02494
	private void SelectTypeToResult(PetSynthesisType type, int param) { }

	// RVA: 0x1C025C4 Offset: 0x1BFE5C4 VA: 0x1C025C4
	private void ReturnColorToForm() { }

	// RVA: 0x1C02B30 Offset: 0x1BFEB30 VA: 0x1C02B30
	private void ReturnSkillToColor() { }

	// RVA: 0x1C02D20 Offset: 0x1BFED20 VA: 0x1C02D20
	private void ReturnTypeToSkill() { }

	// RVA: 0x1C02DD8 Offset: 0x1BFEDD8 VA: 0x1C02DD8
	private void ReturnResultToType(PetSyntheticPanelState panelState) { }

	// RVA: 0x1C02E94 Offset: 0x1BFEE94 VA: 0x1C02E94
	private void ReturnResultToColor() { }

	// RVA: 0x1C01C08 Offset: 0x1BFDC08 VA: 0x1C01C08
	private void ChangeMainButtonEnable() { }

	// RVA: 0x1C018AC Offset: 0x1BFD8AC VA: 0x1C018AC
	private void AddGoldCost(int num) { }

	// RVA: 0x1C01990 Offset: 0x1BFD990 VA: 0x1C01990
	private void AddOrbCost(int num) { }

	// RVA: 0x1C007D4 Offset: 0x1BFC7D4 VA: 0x1C007D4
	private void ChangeModelRender(int param, bool enable, float seconds) { }

	// RVA: 0x1C01D24 Offset: 0x1BFDD24 VA: 0x1C01D24
	private Color[] GetModelBaseColor(GameObject obj) { }

	// RVA: 0x1C027A0 Offset: 0x1BFE7A0 VA: 0x1C027A0
	private void ChangeModelColor(bool[] isSet) { }

	// RVA: 0x1C008B0 Offset: 0x1BFC8B0 VA: 0x1C008B0
	private void ChangeCameraArea(bool fullSize, int param) { }

	// RVA: 0x1BFFF04 Offset: 0x1BFBF04 VA: 0x1BFFF04
	public bool onTopLeft() { }

	// RVA: 0x1C030F8 Offset: 0x1BFF0F8 VA: 0x1C030F8
	private void ReturnPetList() { }

	[IteratorStateMachine(typeof(UIPetSyntheticPanel.<DisnableMainPanel>d__74))]
	// RVA: 0x1C031EC Offset: 0x1BFF1EC VA: 0x1C031EC
	private IEnumerator DisnableMainPanel() { }

	// RVA: 0x1C03130 Offset: 0x1BFF130 VA: 0x1C03130
	private void CloseAllPanel() { }

	[IteratorStateMachine(typeof(UIPetSyntheticPanel.<onSynthesis>d__76))]
	// RVA: 0x1C03280 Offset: 0x1BFF280 VA: 0x1C03280
	private IEnumerator onSynthesis() { }

	[IteratorStateMachine(typeof(UIPetSyntheticPanel.<SyntheticEffect>d__77))]
	// RVA: 0x1C032F4 Offset: 0x1BFF2F4 VA: 0x1C032F4
	private IEnumerator SyntheticEffect() { }

	// RVA: 0x1C03388 Offset: 0x1BFF388 VA: 0x1C03388
	private void onOk() { }

	// RVA: 0x1C03040 Offset: 0x1BFF040 VA: 0x1C03040
	private int GetNeedGold() { }

	// RVA: 0x1C033AC Offset: 0x1BFF3AC VA: 0x1C033AC
	public void ChangeColoring(long baseUuid, long c1Uuid, long c2Uuid, long c3Uuid, int useOrb, int orb) { }

	// RVA: 0x1C03484 Offset: 0x1BFF484 VA: 0x1C03484
	public void .ctor() { }
}
