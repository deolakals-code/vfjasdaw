// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPetAdventManager : UIPetManager // TypeDefIndex: 7772
{
	// Fields
	[SerializeField]
	private GameObject mainPanel; // 0x58
	private UIIruna2Anchor mainAnchor; // 0x60
	[SerializeField]
	private GameObject scrollWindowButton; // 0x68
	private List<GameObject> scrollButtonList; // 0x70
	private UICamera uiCamera; // 0x78
	[SerializeField]
	private UIPetProfilePanel profilePanel; // 0x80
	private UIImageButton adventButton; // 0x88
	[SerializeField]
	private GameObject noPetLabelObj; // 0x90
	private List<PetDataManager.PetSummonData> petSummonDataList; // 0x98
	private GameObject scrollWindowObject; // 0xA0
	private UIScrollWindow scrollWindow; // 0xA8
	private float buttonHeight; // 0xB0
	private int petID; // 0xB4
	private bool canAdvent; // 0xB8

	// Methods

	// RVA: 0x1C0C080 Offset: 0x1C08080 VA: 0x1C0C080 Slot: 7
	protected override void Start() { }

	// RVA: 0x1C0C118 Offset: 0x1C08118 VA: 0x1C0C118
	private void initializeScrollWindow() { }

	// RVA: 0x1C0C298 Offset: 0x1C08298 VA: 0x1C0C298
	private void Initialize() { }

	// RVA: 0x1C0C8F4 Offset: 0x1C088F4 VA: 0x1C0C8F4
	private void addPetButton(int index, int nowlevel, int maxlevel, string name) { }

	// RVA: 0x1C0CD30 Offset: 0x1C08D30 VA: 0x1C0CD30
	private void onClick(int param) { }

	// RVA: 0x1C0D2F8 Offset: 0x1C092F8 VA: 0x1C0D2F8
	private void onAdvent() { }

	[IteratorStateMachine(typeof(UIPetAdventManager.<PetAdvent>d__20))]
	// RVA: 0x1C0D318 Offset: 0x1C09318 VA: 0x1C0D318
	private IEnumerator PetAdvent() { }

	[IteratorStateMachine(typeof(UIPetAdventManager.<GetPetList>d__21))]
	// RVA: 0x1C0C0AC Offset: 0x1C080AC VA: 0x1C0C0AC
	private IEnumerator GetPetList() { }

	// RVA: 0x1C0D3D4 Offset: 0x1C093D4 VA: 0x1C0D3D4 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1C0D474 Offset: 0x1C09474 VA: 0x1C0D474 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1C0D514 Offset: 0x1C09514 VA: 0x1C0D514
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1C0D5CC Offset: 0x1C095CC VA: 0x1C0D5CC
	private void <GetPetList>b__21_0(Game game, GetPetListResponse response) { }
}
