// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPetFeedManager : UIPetManager // TypeDefIndex: 7790
{
	// Fields
	[SerializeField]
	private GameObject mainPanel; // 0x58
	private UIIruna2Anchor mainAnchor; // 0x60
	[SerializeField]
	private GameObject scrollWindowButton; // 0x68
	[SerializeField]
	private GameObject noPetLabelObj; // 0x70
	[SerializeField]
	private GameObject petNameLabelObj; // 0x78
	[SerializeField]
	private UILabel hungryLabel; // 0x80
	[SerializeField]
	private UILabel petFoodMenuLabel; // 0x88
	[SerializeField]
	private GameObject selectButtonObj; // 0x90
	[SerializeField]
	private GameObject holdObj; // 0x98
	[SerializeField]
	private UILabel petHoldLabel; // 0xA0
	[SerializeField]
	private GameObject staminaOj; // 0xA8
	[SerializeField]
	private UISprite[] staminaIcon; // 0xB0
	[SerializeField]
	private UISprite arrowSprite; // 0xB8
	[SerializeField]
	private UIImageButton spinaButton; // 0xC0
	[SerializeField]
	private UIImageButton orbButton; // 0xC8
	[SerializeField]
	private GameObject highGradePanel; // 0xD0
	[SerializeField]
	private GameObject fullPetPanel; // 0xD8
	[SerializeField]
	private GameObject windowPanel; // 0xE0
	[SerializeField]
	private GameObject titleObj; // 0xE8
	[SerializeField]
	private GameObject systemIconTitleObj; // 0xF0
	[SerializeField]
	private GameObject windowBackObj; // 0xF8
	[SerializeField]
	private GameObject feedPanel; // 0x100
	[SerializeField]
	private GameObject windowNameObj; // 0x108
	[SerializeField]
	private UILabel windowPetFoodLabel; // 0x110
	[SerializeField]
	private GameObject windowHoldObj; // 0x118
	[SerializeField]
	private UILabel windowHoldLabel; // 0x120
	[SerializeField]
	private GameObject windowStaminaObj; // 0x128
	[SerializeField]
	private UISprite[] windowStaminaIcon; // 0x130
	[SerializeField]
	private UISprite windowArrowSprite; // 0x138
	[SerializeField]
	private GameObject haveGoldObj; // 0x140
	[SerializeField]
	private GameObject[] feedButtonObj; // 0x148
	[SerializeField]
	private GameObject holdStrayPanel; // 0x150
	[SerializeField]
	private Transform modelParent; // 0x158
	[SerializeField]
	private Transform cameraView; // 0x160
	[SerializeField]
	private UILabel[] holdLabel; // 0x168
	[SerializeField]
	private GameObject holdButton; // 0x170
	[SerializeField]
	private GameObject personaPanel; // 0x178
	[SerializeField]
	private UILabel expLabel; // 0x180
	[SerializeField]
	private UILabel specialOptionLabel; // 0x188
	[SerializeField]
	private GameObject specialOptionButton; // 0x190
	[SerializeField]
	private GameObject specialOptionPanel; // 0x198
	[SerializeField]
	private GameObject specialOptionName; // 0x1A0
	[SerializeField]
	private UIToggle[] specialOptionToggles; // 0x1A8
	private float buttonHeight; // 0x1B0
	private GameObject scrollWindowObject; // 0x1B8
	private UIScrollWindow scrollWindow; // 0x1C0
	private UIIruna2Anchor scrollAnchor; // 0x1C8
	private int selectPetId; // 0x1D0
	private string selectPetLv; // 0x1D8
	private string selectPetName; // 0x1E0
	private int nowAffinity; // 0x1E8
	private int nextAffinity; // 0x1EC
	private PetFoodId petFoodId; // 0x1F0
	private int needGold; // 0x1F4
	private int orbNum; // 0x1F8
	private float loadingTimer; // 0x1FC
	private GameObject loadingObject; // 0x200
	private int needOrbNum; // 0x208
	private GameObject strayPetModel; // 0x210
	private PetModelLoader petModelLoader; // 0x218
	private MobAnimation mobAnimation; // 0x220
	private float playerAngle; // 0x228
	private MobAnimationType mobAnimationType; // 0x22C
	private PetDataManager.PetViewData strayToBreedPetData; // 0x230
	private GameObject heartObj; // 0x238
	private Motion heartMotion; // 0x240
	private bool strayPopWindow; // 0x248
	private bool feedPopWindow; // 0x249
	private PetDataManager.PetViewData tapPetData; // 0x250
	private int feedButtonParam; // 0x258

	// Methods

	// RVA: 0x1C1456C Offset: 0x1C1056C VA: 0x1C1456C
	private void OrbButtonEnableToTrue() { }

	// RVA: 0x1C1458C Offset: 0x1C1058C VA: 0x1C1458C
	public void SetTapPetData(PetDataManager.PetViewData data) { }

	// RVA: 0x1C1459C Offset: 0x1C1059C VA: 0x1C1459C Slot: 7
	protected override void Start() { }

	// RVA: 0x1C1463C Offset: 0x1C1063C VA: 0x1C1463C
	private void Initialize() { }

	// RVA: 0x1C14918 Offset: 0x1C10918 VA: 0x1C14918
	private void initializeScrollWindow() { }

	// RVA: 0x1C14ABC Offset: 0x1C10ABC VA: 0x1C14ABC
	private void InitializePetList() { }

	// RVA: 0x1C15708 Offset: 0x1C11708 VA: 0x1C15708
	private void addPetButton(int index, int level, string name, PetHungerType type, bool breed) { }

	// RVA: 0x1C15AF0 Offset: 0x1C11AF0 VA: 0x1C15AF0
	private void ChangePetFoodMenu() { }

	// RVA: 0x1C15FE8 Offset: 0x1C11FE8 VA: 0x1C15FE8
	private void ChangeSpinaButton(int needGold) { }

	// RVA: 0x1C16390 Offset: 0x1C12390 VA: 0x1C16390
	private void ChangeOrbButton() { }

	// RVA: 0x1C16964 Offset: 0x1C12964 VA: 0x1C16964
	private void OpenFeedPanel(int param) { }

	// RVA: 0x1C174DC Offset: 0x1C134DC VA: 0x1C174DC
	private void UpdateSpecialOptionText() { }

	// RVA: 0x1C1760C Offset: 0x1C1360C VA: 0x1C1760C
	private void OpenHoldStrayPanel(bool success) { }

	// RVA: 0x1C17E10 Offset: 0x1C13E10 VA: 0x1C17E10
	private void OpenPersonaPanel(byte persona) { }

	// RVA: 0x1C17348 Offset: 0x1C13348 VA: 0x1C17348
	private void SetPopWindowTitle(string title, string spriteName, bool isSystemIcon = False) { }

	// RVA: 0x1C17B68 Offset: 0x1C13B68 VA: 0x1C17B68
	private void InitEffect(bool success) { }

	[IteratorStateMachine(typeof(UIPetFeedManager.<HoldEffect>d__86))]
	// RVA: 0x1C180B8 Offset: 0x1C140B8 VA: 0x1C180B8
	private IEnumerator HoldEffect(bool success) { }

	// RVA: 0x1C15150 Offset: 0x1C11150 VA: 0x1C15150
	private void onClick(int param) { }

	// RVA: 0x1C18140 Offset: 0x1C14140 VA: 0x1C18140
	private void onLeftButton() { }

	// RVA: 0x1C1815C Offset: 0x1C1415C VA: 0x1C1815C
	private void onRightButton() { }

	// RVA: 0x1C18178 Offset: 0x1C14178 VA: 0x1C18178
	private void onOpenFeedPanel(int param) { }

	// RVA: 0x1C1817C Offset: 0x1C1417C VA: 0x1C1817C
	private void onNormalFeed() { }

	// RVA: 0x1C183D4 Offset: 0x1C143D4 VA: 0x1C183D4
	private void onHighGradeFeed() { }

	// RVA: 0x1C18670 Offset: 0x1C14670 VA: 0x1C18670
	private void onStrayHold() { }

	// RVA: 0x1C18758 Offset: 0x1C14758 VA: 0x1C18758
	private void onPersona() { }

	// RVA: 0x1C187C0 Offset: 0x1C147C0 VA: 0x1C187C0
	public void OnSpecialOption() { }

	// RVA: 0x1C189AC Offset: 0x1C149AC VA: 0x1C189AC
	public void OnLimitLevel(int param) { }

	[IteratorStateMachine(typeof(UIPetFeedManager.<FeedPet>d__97))]
	// RVA: 0x1C182C4 Offset: 0x1C142C4 VA: 0x1C182C4
	private IEnumerator FeedPet(long petId, PetFoodId foodId) { }

	[IteratorStateMachine(typeof(UIPetFeedManager.<DirectFeedPet>d__98))]
	// RVA: 0x1C18570 Offset: 0x1C14570 VA: 0x1C18570
	private IEnumerator DirectFeedPet(long petId, PetFoodId foodId) { }

	// RVA: 0x1C18A98 Offset: 0x1C14A98 VA: 0x1C18A98
	private void OverLimitLevel(string name, int monsterUuid) { }

	[IteratorStateMachine(typeof(UIPetFeedManager.<FeedStrayPet>d__100))]
	// RVA: 0x1C18350 Offset: 0x1C14350 VA: 0x1C18350
	private IEnumerator FeedStrayPet(PetFoodId foodId) { }

	[IteratorStateMachine(typeof(UIPetFeedManager.<DirectFeedStrayPet>d__101))]
	// RVA: 0x1C185FC Offset: 0x1C145FC VA: 0x1C185FC
	private IEnumerator DirectFeedStrayPet() { }

	[IteratorStateMachine(typeof(UIPetFeedManager.<KeepStray>d__102))]
	// RVA: 0x1C18C00 Offset: 0x1C14C00 VA: 0x1C18C00
	private IEnumerator KeepStray() { }

	[IteratorStateMachine(typeof(UIPetFeedManager.<FeedButtonDelay>d__103))]
	// RVA: 0x1C17458 Offset: 0x1C13458 VA: 0x1C17458
	private IEnumerator FeedButtonDelay(int param) { }

	// RVA: 0x1C18228 Offset: 0x1C14228 VA: 0x1C18228
	private void FeedButtonDisable() { }

	// RVA: 0x1C17A90 Offset: 0x1C13A90 VA: 0x1C17A90
	private void LoadPetModel() { }

	// RVA: 0x1C18CE8 Offset: 0x1C14CE8 VA: 0x1C18CE8
	private void DeleteModel() { }

	[IteratorStateMachine(typeof(UIPetFeedManager.<LoadModel>d__107))]
	// RVA: 0x1C18C74 Offset: 0x1C14C74 VA: 0x1C18C74
	private IEnumerator LoadModel() { }

	// RVA: 0x1C18D54 Offset: 0x1C14D54 VA: 0x1C18D54
	private void ChangePetAnimation(MobAnimationType type) { }

	// RVA: 0x1C18E84 Offset: 0x1C14E84 VA: 0x1C18E84 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1C190A4 Offset: 0x1C150A4 VA: 0x1C190A4 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1C19134 Offset: 0x1C15134 VA: 0x1C19134
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1C19318 Offset: 0x1C15318 VA: 0x1C19318
	private void <FeedPet>b__97_0(Game game, HouseFeedPetResponse response) { }

	[CompilerGenerated]
	// RVA: 0x1C19414 Offset: 0x1C15414 VA: 0x1C19414
	private void <DirectFeedPet>b__98_0(Game game, HouseFeedPetResponse response) { }

	[CompilerGenerated]
	// RVA: 0x1C1952C Offset: 0x1C1552C VA: 0x1C1952C
	private void <FeedStrayPet>b__100_0(Game game, HouseFeedStrayResponse response) { }

	[CompilerGenerated]
	// RVA: 0x1C195B4 Offset: 0x1C155B4 VA: 0x1C195B4
	private void <DirectFeedStrayPet>b__101_0(Game game, HouseFeedStrayResponse response) { }

	[CompilerGenerated]
	// RVA: 0x1C19658 Offset: 0x1C15658 VA: 0x1C19658
	private void <KeepStray>b__102_0(Game game, HouseKeepStrayResponse response) { }
}
