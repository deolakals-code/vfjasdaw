// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPetChangeNameManager : UIPetManager // TypeDefIndex: 7779
{
	// Fields
	[SerializeField]
	private GameObject mainPanel; // 0x58
	private UIIruna2Anchor mainAnchor; // 0x60
	[SerializeField]
	private GameObject scrollWindowButton; // 0x68
	private List<GameObject> scrollButtonList; // 0x70
	[SerializeField]
	private GameObject noPetLabelObj; // 0x78
	private UICamera uiCamera; // 0x80
	[SerializeField]
	private Transform windowModelParent; // 0x88
	[SerializeField]
	private GameObject windowPanel; // 0x90
	private UIIruna2Anchor windowAnchor; // 0x98
	[SerializeField]
	private GameObject changePanel; // 0xA0
	[SerializeField]
	private GameObject decidePanel; // 0xA8
	[SerializeField]
	private GameObject entryNameObj; // 0xB0
	[SerializeField]
	private UILabel nameLabel; // 0xB8
	[SerializeField]
	private UILabel pleaseNameLabel; // 0xC0
	[SerializeField]
	private UILabel noPrintNameLabel; // 0xC8
	[SerializeField]
	private UILabel nowNameLabel; // 0xD0
	[SerializeField]
	private UILabel newNameLabel; // 0xD8
	[SerializeField]
	private UIImageButton[] changeImageButton; // 0xE0
	[SerializeField]
	private UIImageButton[] decideImageButton; // 0xE8
	[SerializeField]
	private GameObject haveGoldOrbObj; // 0xF0
	[SerializeField]
	private UIPetProfilePanel profilePanel; // 0xF8
	private UIImageButton changeButton; // 0x100
	private float buttonHeight; // 0x108
	private GameObject scrollWindowObject; // 0x110
	private UIScrollWindow scrollWindow; // 0x118
	private UIIruna2Anchor scrollAnchor; // 0x120
	private string nameText; // 0x128
	private int petID; // 0x130
	private MobAnimationType animeType; // 0x134
	private bool popWindowFlag; // 0x138
	private bool decideButtonEnable; // 0x139
	private float decideButtonTimer; // 0x13C
	private int orbNum; // 0x140
	private bool orbFlg; // 0x144
	private float loadingTimer; // 0x148
	private GameObject loadingObject; // 0x150
	private int needGold; // 0x158

	// Methods

	// RVA: 0x1C110DC Offset: 0x1C0D0DC VA: 0x1C110DC
	private void DecideOrbButtonEnableToTrue() { }

	// RVA: 0x1C11110 Offset: 0x1C0D110 VA: 0x1C11110 Slot: 7
	protected override void Start() { }

	// RVA: 0x1C1112C Offset: 0x1C0D12C VA: 0x1C1112C
	private void initialize() { }

	// RVA: 0x1C11A18 Offset: 0x1C0DA18 VA: 0x1C11A18
	private void OnDestroy() { }

	// RVA: 0x1C11A70 Offset: 0x1C0DA70 VA: 0x1C11A70
	private void Update() { }

	// RVA: 0x1C11334 Offset: 0x1C0D334 VA: 0x1C11334
	private void initializeScrollWindow() { }

	// RVA: 0x1C114D8 Offset: 0x1C0D4D8 VA: 0x1C114D8
	private void initializeScrollButton() { }

	// RVA: 0x1C11B54 Offset: 0x1C0DB54 VA: 0x1C11B54
	private void addPetButton(int index, string name) { }

	// RVA: 0x1C11DC0 Offset: 0x1C0DDC0 VA: 0x1C11DC0
	private void onClick(int param) { }

	// RVA: 0x1C120C0 Offset: 0x1C0E0C0 VA: 0x1C120C0
	private void onOpenWindow() { }

	// RVA: 0x1C12848 Offset: 0x1C0E848 VA: 0x1C12848
	private void onChange(int param) { }

	// RVA: 0x1C12E58 Offset: 0x1C0EE58 VA: 0x1C12E58
	private void onDecide(int param) { }

	[IteratorStateMachine(typeof(UIPetChangeNameManager.<PetNaming>d__49))]
	// RVA: 0x1C13024 Offset: 0x1C0F024 VA: 0x1C13024
	private IEnumerator PetNaming(long id, string name) { }

	// RVA: 0x1C130DC Offset: 0x1C0F0DC VA: 0x1C130DC
	public void OnClick_SubmitActive() { }

	// RVA: 0x1C130E0 Offset: 0x1C0F0E0 VA: 0x1C130E0
	public void OnSubmitName() { }

	[IteratorStateMachine(typeof(UIPetChangeNameManager.<UpdateNameLabel>d__52))]
	// RVA: 0x1C131A8 Offset: 0x1C0F1A8 VA: 0x1C131A8
	private IEnumerator UpdateNameLabel() { }

	// RVA: 0x1C1323C Offset: 0x1C0F23C VA: 0x1C1323C Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1C134DC Offset: 0x1C0F4DC VA: 0x1C134DC Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1C13574 Offset: 0x1C0F574 VA: 0x1C13574
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1C136AC Offset: 0x1C0F6AC VA: 0x1C136AC
	private void <PetNaming>b__49_0(Game game, HousePetNamingResponse response) { }

	[CompilerGenerated]
	// RVA: 0x1C137B0 Offset: 0x1C0F7B0 VA: 0x1C137B0
	private void <PetNaming>b__49_1() { }
}
