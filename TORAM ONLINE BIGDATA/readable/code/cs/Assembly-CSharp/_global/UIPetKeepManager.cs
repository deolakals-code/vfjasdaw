// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPetKeepManager : UIPetManager // TypeDefIndex: 7799
{
	// Fields
	private UIPetKeepManager.PanelState panelState; // 0x58
	[SerializeField]
	private GameObject mainPanel; // 0x60
	private UIIruna2Anchor mainAnchor; // 0x68
	[SerializeField]
	private UIIruna2Anchor subAnchor; // 0x70
	[SerializeField]
	private GameObject scrollWindowButton; // 0x78
	private List<GameObject> scrollButtonList; // 0x80
	[SerializeField]
	private GameObject scrollBuyButton; // 0x88
	[SerializeField]
	private GameObject scrollSleepListButton; // 0x90
	[SerializeField]
	private GameObject scrollDummyButton; // 0x98
	[SerializeField]
	private GameObject windowPanel; // 0xA0
	[SerializeField]
	private GameObject buyPanel; // 0xA8
	[SerializeField]
	private GameObject decidePanel; // 0xB0
	[SerializeField]
	private UIImageButton[] buyImageButton; // 0xB8
	[SerializeField]
	private UIImageButton[] decideImageButton; // 0xC0
	[SerializeField]
	private GameObject haveGoldOrbObj; // 0xC8
	[SerializeField]
	private UIPetProfilePanel profilePanel; // 0xD0
	private UIImageButton sleepButton; // 0xD8
	[SerializeField]
	private UILabel staminaLabel; // 0xE0
	[SerializeField]
	private UIImageButton checkButton; // 0xE8
	[SerializeField]
	private UILabel havePetNumLabel; // 0xF0
	[SerializeField]
	private UILabel sleepPetNumLabel; // 0xF8
	[SerializeField]
	private UIPetRecoveryStamina recoveryStaminaPopWindow; // 0x100
	[SerializeField]
	private GameObject recoveryListButton; // 0x108
	[SerializeField]
	private GameObject recoveryNoPetObj; // 0x110
	private PetDataManager.PetViewData nowPetData; // 0x118
	private Dictionary<int, GameObject> petModelObjectList; // 0x120
	private PetModelLoader petModelLoader; // 0x128
	private float playerAngle; // 0x130
	private bool cameraFlag; // 0x134
	private Dictionary<int, bool> checkedPetFlag; // 0x138
	private float buttonHeight; // 0x140
	private GameObject scrollWindowObject; // 0x148
	private UIScrollWindow scrollWindow; // 0x150
	private UIIruna2Anchor scrollAnchor; // 0x158
	private int petID; // 0x160
	private bool popWindowFlag; // 0x164
	private bool decideButtonEnable; // 0x165
	private float decideButtonTimer; // 0x168
	private int orbNum; // 0x16C
	private bool orbFlg; // 0x170
	private float loadingTimer; // 0x174
	private GameObject loadingObject; // 0x178
	private int needGold; // 0x180
	private bool lifePopWindow; // 0x184
	private float iconTimer; // 0x188
	private bool staminaIconFlag; // 0x18C

	// Methods

	// RVA: 0x1C1BA94 Offset: 0x1C17A94 VA: 0x1C1BA94
	private void DecideOrbButtonEnableToTrue() { }

	// RVA: 0x1C1BAC8 Offset: 0x1C17AC8 VA: 0x1C1BAC8 Slot: 7
	protected override void Start() { }

	// RVA: 0x1C1C0B4 Offset: 0x1C180B4 VA: 0x1C1C0B4
	private void initializeScrollWindow() { }

	// RVA: 0x1C1BF34 Offset: 0x1C17F34 VA: 0x1C1BF34
	private void Initialize() { }

	// RVA: 0x1C1D1AC Offset: 0x1C191AC VA: 0x1C1D1AC
	private void Update() { }

	// RVA: 0x1C1D5D4 Offset: 0x1C195D4 VA: 0x1C1D5D4
	private void addPetButton(int index, int nowlevel, int maxlevel, string name, bool sleep, bool breed) { }

	// RVA: 0x1C1DB14 Offset: 0x1C19B14 VA: 0x1C1DB14
	private void addBuyButton(int index) { }

	// RVA: 0x1C1DC58 Offset: 0x1C19C58 VA: 0x1C1DC58
	private void addDummyButton(int index) { }

	// RVA: 0x1C1DE20 Offset: 0x1C19E20 VA: 0x1C1DE20
	private void addToKennelListButton(int index) { }

	// RVA: 0x1C1DF64 Offset: 0x1C19F64 VA: 0x1C1DF64
	private void AddRecoveryListButton(int index) { }

	// RVA: 0x1C1C258 Offset: 0x1C18258 VA: 0x1C1C258
	private void BreedScrollWindow() { }

	// RVA: 0x1C1C6E0 Offset: 0x1C186E0 VA: 0x1C1C6E0
	private void KennelScrollWindow() { }

	// RVA: 0x1C1CB7C Offset: 0x1C18B7C VA: 0x1C1CB7C
	private void RecoveryScrollWindow() { }

	// RVA: 0x1C1E0A8 Offset: 0x1C1A0A8 VA: 0x1C1E0A8
	private void ChangeSubPanel() { }

	// RVA: 0x1C1E2F0 Offset: 0x1C1A2F0 VA: 0x1C1E2F0
	private void ChangeSleepButton() { }

	// RVA: 0x1C1E530 Offset: 0x1C1A530 VA: 0x1C1E530
	private void onClick(int param) { }

	// RVA: 0x1C1FE8C Offset: 0x1C1BE8C VA: 0x1C1FE8C
	private void onOpenKennelList() { }

	// RVA: 0x1C1FFBC Offset: 0x1C1BFBC VA: 0x1C1FFBC
	private void onSleep() { }

	// RVA: 0x1C20120 Offset: 0x1C1C120 VA: 0x1C20120
	private void onCheck() { }

	// RVA: 0x1C201F8 Offset: 0x1C1C1F8 VA: 0x1C201F8
	private void onBuyWindow() { }

	// RVA: 0x1C20630 Offset: 0x1C1C630 VA: 0x1C20630
	private void onBuy(int param) { }

	// RVA: 0x1C20BB8 Offset: 0x1C1CBB8 VA: 0x1C20BB8
	private void onDecide(int param) { }

	// RVA: 0x1C20D78 Offset: 0x1C1CD78 VA: 0x1C20D78
	private void onOpenRecoveryPanel() { }

	// RVA: 0x1C20F00 Offset: 0x1C1CF00 VA: 0x1C20F00
	private void CloseRecoveryPanel() { }

	// RVA: 0x1C20FB8 Offset: 0x1C1CFB8 VA: 0x1C20FB8
	private void OnRecoveryList() { }

	[IteratorStateMachine(typeof(UIPetKeepManager.<PetStatusUp>d__72))]
	// RVA: 0x1C20098 Offset: 0x1C1C098 VA: 0x1C20098
	private IEnumerator PetStatusUp(bool flag, long id) { }

	[IteratorStateMachine(typeof(UIPetKeepManager.<BuyFrame>d__73))]
	// RVA: 0x1C20D0C Offset: 0x1C1CD0C VA: 0x1C20D0C
	private IEnumerator BuyFrame() { }

	[IteratorStateMachine(typeof(UIPetKeepManager.<RecoveryList>d__74))]
	// RVA: 0x1C20FD8 Offset: 0x1C1CFD8 VA: 0x1C20FD8
	private IEnumerator RecoveryList() { }

	[IteratorStateMachine(typeof(UIPetKeepManager.<TakeRecoveryPet>d__75))]
	// RVA: 0x1C2002C Offset: 0x1C1C02C VA: 0x1C2002C
	private IEnumerator TakeRecoveryPet(long uuid) { }

	// RVA: 0x1C210E4 Offset: 0x1C1D0E4 VA: 0x1C210E4 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1C21378 Offset: 0x1C1D378 VA: 0x1C21378 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1C2140C Offset: 0x1C1D40C VA: 0x1C2140C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1C21608 Offset: 0x1C1D608 VA: 0x1C21608
	private void <BuyFrame>b__73_0(Game game, HouseKennelPurchaseResponse response) { }

	[CompilerGenerated]
	// RVA: 0x1C21694 Offset: 0x1C1D694 VA: 0x1C21694
	private void <BuyFrame>b__73_1(Game game, HouseKennelPurchaseResponse response) { }
}
