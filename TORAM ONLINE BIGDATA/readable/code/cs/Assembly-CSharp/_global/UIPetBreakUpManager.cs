// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPetBreakUpManager : UIPetManager // TypeDefIndex: 7776
{
	// Fields
	[SerializeField]
	private GameObject mainPanel; // 0x58
	private UIIruna2Anchor mainAnchor; // 0x60
	[SerializeField]
	private GameObject noPetLabelObj; // 0x68
	[SerializeField]
	private GameObject scrollWindowButton; // 0x70
	private List<GameObject> scrollButtonList; // 0x78
	private GameObject strayButton; // 0x80
	private UICamera uiCamera; // 0x88
	[SerializeField]
	private GameObject windowPanel; // 0x90
	private UIIruna2Anchor windowAnchor; // 0x98
	[SerializeField]
	private UILabel windowTitleLabel; // 0xA0
	[SerializeField]
	private GameObject beforeBreakUpPanel; // 0xA8
	[SerializeField]
	private GameObject nowBreakUpPanel; // 0xB0
	[SerializeField]
	private UILabel endLabel; // 0xB8
	[SerializeField]
	private GameObject windowButtonObj; // 0xC0
	[SerializeField]
	private UILabel[] breakUpPetNameLabel; // 0xC8
	[SerializeField]
	private UILabel[] breakUpRedMesLabel; // 0xD0
	[SerializeField]
	private UIPetProfilePanel profilePanel; // 0xD8
	private UIImageButton breakUpButton; // 0xE0
	[SerializeField]
	private UISlider loadSlider; // 0xE8
	private Coroutine loadCoroutine; // 0xF0
	[SerializeField]
	private Transform windowModelParent; // 0xF8
	private GameObject fukidashiObj; // 0x100
	private float buttonHeight; // 0x108
	private GameObject scrollWindowObject; // 0x110
	private UIScrollWindow scrollWindow; // 0x118
	private UIIruna2Anchor scrollAnchor; // 0x120
	private string nameText; // 0x128
	private int petID; // 0x130
	private MobAnimationType animeType; // 0x134
	private bool popWindowFlag; // 0x138
	private bool finishFlag; // 0x139
	private bool returnPetFlag; // 0x13A
	private float returnTimer; // 0x13C
	private bool stopPetFlag; // 0x140
	private bool comeStatusFlag; // 0x141

	// Methods

	// RVA: 0x1C0DBD0 Offset: 0x1C09BD0 VA: 0x1C0DBD0 Slot: 7
	protected override void Start() { }

	// RVA: 0x1C0DBEC Offset: 0x1C09BEC VA: 0x1C0DBEC
	private void initialize() { }

	// RVA: 0x1C0F15C Offset: 0x1C0B15C VA: 0x1C0F15C
	private void OnDestroy() { }

	// RVA: 0x1C0F1B4 Offset: 0x1C0B1B4 VA: 0x1C0F1B4
	private void Update() { }

	// RVA: 0x1C0DE5C Offset: 0x1C09E5C VA: 0x1C0DE5C
	private void initializeScrollWindow() { }

	// RVA: 0x1C0E000 Offset: 0x1C0A000 VA: 0x1C0E000
	private void initializeScrollButton() { }

	// RVA: 0x1C0F498 Offset: 0x1C0B498 VA: 0x1C0F498
	private void addPetButton(int index, string name, bool breed) { }

	// RVA: 0x1C0E6B0 Offset: 0x1C0A6B0 VA: 0x1C0E6B0
	private void onClick(int param) { }

	// RVA: 0x1C0E9F0 Offset: 0x1C0A9F0 VA: 0x1C0E9F0
	private void onOpenWindow() { }

	// RVA: 0x1C0F970 Offset: 0x1C0B970 VA: 0x1C0F970
	private void onBreakUp() { }

	// RVA: 0x1C0F730 Offset: 0x1C0B730 VA: 0x1C0F730
	private void InitEffect() { }

	[IteratorStateMachine(typeof(UIPetBreakUpManager.<TrainingLoadBar>d__46))]
	// RVA: 0x1C0FEF4 Offset: 0x1C0BEF4 VA: 0x1C0FEF4
	private IEnumerator TrainingLoadBar(float seconds) { }

	[IteratorStateMachine(typeof(UIPetBreakUpManager.<ExilePet>d__47))]
	// RVA: 0x1C0FF98 Offset: 0x1C0BF98 VA: 0x1C0FF98
	private IEnumerator ExilePet() { }

	[IteratorStateMachine(typeof(UIPetBreakUpManager.<ExileStrayPet>d__48))]
	// RVA: 0x1C1002C Offset: 0x1C0C02C VA: 0x1C1002C
	private IEnumerator ExileStrayPet() { }

	// RVA: 0x1C100C0 Offset: 0x1C0C0C0 VA: 0x1C100C0 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1C1031C Offset: 0x1C0C31C VA: 0x1C1031C Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1C103B4 Offset: 0x1C0C3B4 VA: 0x1C103B4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1C104EC Offset: 0x1C0C4EC VA: 0x1C104EC
	private void <onOpenWindow>b__43_0(bool s, GameObject fukidashi) { }

	[CompilerGenerated]
	// RVA: 0x1C10730 Offset: 0x1C0C730 VA: 0x1C10730
	private void <ExilePet>b__47_0(Game game, HouseExilePetResponse response) { }

	[CompilerGenerated]
	// RVA: 0x1C107A8 Offset: 0x1C0C7A8 VA: 0x1C107A8
	private void <ExileStrayPet>b__48_0(Game game, HouseExileStrayResponse response) { }
}
