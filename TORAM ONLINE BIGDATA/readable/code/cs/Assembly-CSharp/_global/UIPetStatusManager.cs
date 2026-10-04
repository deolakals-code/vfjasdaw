// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPetStatusManager : UIPetManager // TypeDefIndex: 7864
{
	// Fields
	[SerializeField]
	private GameObject mainPanel; // 0x58
	private UIIruna2Anchor mainAnchor; // 0x60
	[SerializeField]
	private GameObject allPanel; // 0x68
	[SerializeField]
	private GameObject scrollWindowButton; // 0x70
	private List<GameObject> scrollButtonList; // 0x78
	private float buttonHeight; // 0x80
	private UICamera uiCamera; // 0x88
	[SerializeField]
	private GameObject noPetLabelObj; // 0x90
	[SerializeField]
	private Transform cameraView; // 0x98
	[SerializeField]
	private Transform modelParent; // 0xA0
	[SerializeField]
	private GameObject breedObj; // 0xA8
	[SerializeField]
	private GameObject petNameLabelObj; // 0xB0
	[SerializeField]
	private UILabel[] typePersonalLabel; // 0xB8
	[SerializeField]
	private UILabel fusionLabel; // 0xC0
	[SerializeField]
	private GameObject holdObj; // 0xC8
	[SerializeField]
	private UISprite staminaIcon; // 0xD0
	[SerializeField]
	private UISprite itemStaminaIcon; // 0xD8
	[SerializeField]
	private UILabel staminaLabel; // 0xE0
	[SerializeField]
	private GameObject skillObj; // 0xE8
	[SerializeField]
	private UILabel educationLabel; // 0xF0
	[SerializeField]
	private UIImageButton leftMenuButton; // 0xF8
	[SerializeField]
	private GameObject halfFrameObj; // 0x100
	[SerializeField]
	private GameObject FullFrameObj; // 0x108
	[SerializeField]
	private GameObject[] rightPanelObj; // 0x110
	private UIImageButton[] setActionButton; // 0x118
	[SerializeField]
	private GameObject statusObject; // 0x120
	[SerializeField]
	private GameObject[] mobStatusObj; // 0x128
	[SerializeField]
	private UILabel[] potentialLabel; // 0x130
	[SerializeField]
	private UISprite[] potentialBar; // 0x138
	private TweenColor[] potentialBarColor; // 0x140
	[SerializeField]
	private UISlider[] potentialSlider; // 0x148
	[SerializeField]
	private UILabel[] nowStatusLabel; // 0x150
	[SerializeField]
	private GameObject battlePowerObject; // 0x158
	[SerializeField]
	private UIIruna2DragPinch halfDragPinch; // 0x160
	[SerializeField]
	private UIIruna2DragPinch fullDragPinch; // 0x168
	[SerializeField]
	private GameObject skillTreeObj; // 0x170
	private UIPetSkillTreeManager skillTreeManager; // 0x178
	private UIPetSkillTreePanel skillTreePanel; // 0x180
	[SerializeField]
	private BoxCollider staminaCollider; // 0x188
	[SerializeField]
	private UIPetRecoveryStamina recoveryStaminaPopWindow; // 0x190
	[SerializeField]
	private UIIruna2Anchor orbPanel; // 0x198
	private UIPetStatusEducation petStatusEducation; // 0x1A0
	private UIPetStatusConfirm petStatusConfirm; // 0x1A8
	private UIPetStatusSetAction petStatusSetAction; // 0x1B0
	private int selectedSkillId; // 0x1B8
	private UIPetStatusSkillCheck petSkillCheck; // 0x1C0
	private Dictionary<int, GameObject> petModelObjectList; // 0x1C8
	private PetModelLoader petModelLoader; // 0x1D0
	private MobAnimation mobAnimation; // 0x1D8
	private float playerAngle; // 0x1E0
	private MobAnimationType mobAnimationType; // 0x1E4
	private GameObject scrollWindowObject; // 0x1E8
	private UIScrollWindow scrollWindow; // 0x1F0
	private UIIruna2Anchor scrollAnchor; // 0x1F8
	private UIPetStatusManager.PanelState panelState; // 0x200
	private int petID; // 0x204
	private bool popWindow; // 0x208
	private float iconTimer; // 0x20C
	private bool staminaIconFlag; // 0x210

	// Properties
	public List<PetDataManager.PetViewData> PetDataList { get; }
	public PetDataManager.PetViewData SelectedPetData { get; }
	public int SetSkillId { get; set; }

	// Methods

	// RVA: 0x1C41064 Offset: 0x1C3D064 VA: 0x1C41064
	public void UpdatePetData(int id) { }

	// RVA: 0x1C3F474 Offset: 0x1C3B474 VA: 0x1C3F474
	public List<PetDataManager.PetViewData> get_PetDataList() { }

	// RVA: 0x1C3F7C4 Offset: 0x1C3B7C4 VA: 0x1C3F7C4
	public PetDataManager.PetViewData get_SelectedPetData() { }

	// RVA: 0x1C42340 Offset: 0x1C3E340 VA: 0x1C42340
	public int get_SetSkillId() { }

	// RVA: 0x1C42348 Offset: 0x1C3E348 VA: 0x1C42348
	public void set_SetSkillId(int value) { }

	// RVA: 0x1C42350 Offset: 0x1C3E350 VA: 0x1C42350
	public void EnterSkillTraining() { }

	// RVA: 0x1C4127C Offset: 0x1C3D27C VA: 0x1C4127C
	public void ChangeEducationLabel(string text) { }

	// RVA: 0x1C4244C Offset: 0x1C3E44C VA: 0x1C4244C Slot: 7
	protected override void Start() { }

	// RVA: 0x1C42F1C Offset: 0x1C3EF1C VA: 0x1C42F1C
	private void OnDestroy() { }

	// RVA: 0x1C4265C Offset: 0x1C3E65C VA: 0x1C4265C
	private void initializeScrollWindow() { }

	// RVA: 0x1C42800 Offset: 0x1C3E800 VA: 0x1C42800
	private void initializeScrollButton() { }

	// RVA: 0x1C43530 Offset: 0x1C3F530 VA: 0x1C43530
	private void Update() { }

	// RVA: 0x1C42F74 Offset: 0x1C3EF74 VA: 0x1C42F74
	private void addPetButton(int index, int nowlevel, int maxlevel, string name, int stamina, bool breed, bool groggy) { }

	// RVA: 0x1C41308 Offset: 0x1C3D308 VA: 0x1C41308
	public void ChangePetData(int param) { }

	// RVA: 0x1C438E8 Offset: 0x1C3F8E8 VA: 0x1C438E8
	private void UpdateStaminaIcon() { }

	[IteratorStateMachine(typeof(UIPetStatusManager.<SetTimeLabelPos>d__79))]
	// RVA: 0x1C43940 Offset: 0x1C3F940 VA: 0x1C43940
	private IEnumerator SetTimeLabelPos(UILabel onLabel, UILabel underLabel) { }

	// RVA: 0x1C44314 Offset: 0x1C40314 VA: 0x1C44314
	private void ChangeStrayPetData() { }

	// RVA: 0x1C41068 Offset: 0x1C3D068 VA: 0x1C41068
	public void ChangePotentialBarColor(PetTrainingType type) { }

	// RVA: 0x1C43F48 Offset: 0x1C3FF48 VA: 0x1C43F48
	private void ChangePotentialSliderValue(PetPotentialData data) { }

	// RVA: 0x1C42354 Offset: 0x1C3E354 VA: 0x1C42354
	private void StartSkillTraining() { }

	// RVA: 0x1C44948 Offset: 0x1C40948 VA: 0x1C44948
	private void onClick(int param) { }

	// RVA: 0x1C451A4 Offset: 0x1C411A4 VA: 0x1C451A4
	private void onTeach() { }

	// RVA: 0x1C46004 Offset: 0x1C42004 VA: 0x1C46004
	private void onSkillCheck() { }

	// RVA: 0x1C46188 Offset: 0x1C42188 VA: 0x1C46188
	private void onSetAction() { }

	// RVA: 0x1C46190 Offset: 0x1C42190 VA: 0x1C46190
	private void onSetNormalAction() { }

	// RVA: 0x1C46198 Offset: 0x1C42198 VA: 0x1C46198
	private void onSetSkill() { }

	// RVA: 0x1C461A0 Offset: 0x1C421A0 VA: 0x1C461A0
	public void onOpenSkillTree() { }

	// RVA: 0x1C46204 Offset: 0x1C42204 VA: 0x1C46204
	private void onOpenRecoveryPanel() { }

	// RVA: 0x1C4641C Offset: 0x1C4241C VA: 0x1C4641C
	private void CloseRecoveryPanel() { }

	// RVA: 0x1C44EC4 Offset: 0x1C40EC4 VA: 0x1C44EC4
	private void LoadPetModel() { }

	// RVA: 0x1C45420 Offset: 0x1C41420 VA: 0x1C45420
	private void DeleteModel() { }

	[IteratorStateMachine(typeof(UIPetStatusManager.<LoadModel>d__95))]
	// RVA: 0x1C46590 Offset: 0x1C42590 VA: 0x1C46590
	private IEnumerator LoadModel() { }

	// RVA: 0x1C40F04 Offset: 0x1C3CF04 VA: 0x1C40F04
	public void ChangePetAnimation(int id, MobAnimationType type) { }

	// RVA: 0x1C439C8 Offset: 0x1C3F9C8 VA: 0x1C439C8
	public void UpdatePetStatus(PetDataManager.PetViewStatus primaryStatus) { }

	// RVA: 0x1C46624 Offset: 0x1C42624 VA: 0x1C46624
	private void SetPetStatusBar(int type, int param, int maxparam) { }

	// RVA: 0x1C45594 Offset: 0x1C41594 VA: 0x1C45594
	private void ChangePanel(UIPetStatusManager.PanelState changeState) { }

	// RVA: 0x1C478C8 Offset: 0x1C438C8 VA: 0x1C478C8 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1C47C74 Offset: 0x1C43C74 VA: 0x1C47C74 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1C47D04 Offset: 0x1C43D04 VA: 0x1C47D04
	public void .ctor() { }
}
