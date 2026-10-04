// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPetSyntheticManager : UIPetManager // TypeDefIndex: 7747
{
	// Fields
	[SerializeField]
	private UIIruna2Anchor subAnchor; // 0x58
	[SerializeField]
	private GameObject scrollWindowButton; // 0x60
	private List<GameObject> scrollButtonList; // 0x68
	[SerializeField]
	private GameObject scrollSleepListButton; // 0x70
	[SerializeField]
	private GameObject scrollPetCageListButton; // 0x78
	private UIPetProfilePanel profilePanel; // 0x80
	private UIImageButton synthButton; // 0x88
	[SerializeField]
	private UILabel[] targetLabel; // 0x90
	private PetDataManager.SyntheticSelectData[] selectedPetData; // 0x98
	private int setTargetCount; // 0xA0
	[SerializeField]
	private UIPetSyntheticPanel syntheticPanel; // 0xA8
	[SerializeField]
	private GameObject noPetLabelObj; // 0xB0
	private UIPetSyntheticManager.PanelType panelType; // 0xB8
	private UIPetSyntheticManager.SelectPetList selectPetList; // 0xBC
	private GameObject scrollWindowObject; // 0xC0
	private UIScrollWindow scrollWindow; // 0xC8
	private UIIruna2Anchor scrollAnchor; // 0xD0
	private int petId; // 0xD8
	private List<PetDataManager.PetViewData> breedPetList; // 0xE0
	private List<PetDataManager.PetViewData> kennelPetList; // 0xE8
	private const float buttonHeight = 100;
	private List<ItemData> colorPetCageItemList; // 0xF0

	// Properties
	public UIPetSyntheticManager.PanelType SelectPanelType { get; }

	// Methods

	// RVA: 0x1BFB97C Offset: 0x1BF797C VA: 0x1BFB97C
	public UIPetSyntheticManager.PanelType get_SelectPanelType() { }

	// RVA: 0x1BFB984 Offset: 0x1BF7984 VA: 0x1BFB984
	public void SetPanelType(UIPetSyntheticManager.PanelType panelType) { }

	// RVA: 0x1BFB98C Offset: 0x1BF798C VA: 0x1BFB98C Slot: 7
	protected override void Start() { }

	// RVA: 0x1BFC234 Offset: 0x1BF8234 VA: 0x1BFC234
	private void InitializeScrollWindow() { }

	// RVA: 0x1BFC000 Offset: 0x1BF8000 VA: 0x1BFC000
	private void InitTargetLabel() { }

	// RVA: 0x1BFC184 Offset: 0x1BF8184 VA: 0x1BFC184
	private void Initialize() { }

	// RVA: 0x1BFC3E8 Offset: 0x1BF83E8 VA: 0x1BFC3E8
	private void OpenNowScrollWindow() { }

	// RVA: 0x1BFC410 Offset: 0x1BF8410 VA: 0x1BFC410
	private void BreedScrollWindow() { }

	// RVA: 0x1BFC9AC Offset: 0x1BF89AC VA: 0x1BFC9AC
	private void KennelScrollWindow() { }

	// RVA: 0x1BFCE9C Offset: 0x1BF8E9C VA: 0x1BFCE9C
	private void PetCageScrollWindow() { }

	// RVA: 0x1BFD908 Offset: 0x1BF9908 VA: 0x1BFD908
	private void addPetButton(int index, int nowlevel, int maxlevel, string name, int stamina, bool groggy) { }

	// RVA: 0x1BFE10C Offset: 0x1BFA10C VA: 0x1BFE10C
	private void AddCageButton(int index, string name, bool cage) { }

	// RVA: 0x1BFDFC0 Offset: 0x1BF9FC0 VA: 0x1BFDFC0
	private void addToKennelListButton(int index) { }

	// RVA: 0x1BFDE74 Offset: 0x1BF9E74 VA: 0x1BFDE74
	private void AddToPetCageListButton(int index) { }

	// RVA: 0x1BFBB74 Offset: 0x1BF7B74 VA: 0x1BFBB74
	private void UpdatePetList() { }

	// RVA: 0x1BFBBB4 Offset: 0x1BF7BB4 VA: 0x1BFBBB4
	private void UpdateColorPetCageList() { }

	// RVA: 0x1BFD318 Offset: 0x1BF9318 VA: 0x1BFD318
	private List<PetDataManager.PetViewData> GetBreedList() { }

	// RVA: 0x1BFD610 Offset: 0x1BF9610 VA: 0x1BFD610
	private List<PetDataManager.PetViewData> GetKennelList() { }

	// RVA: 0x1BFE4C8 Offset: 0x1BFA4C8 VA: 0x1BFE4C8
	private void onClick(int param) { }

	// RVA: 0x1BFEA58 Offset: 0x1BFAA58 VA: 0x1BFEA58
	private void OnClickCage(int param) { }

	// RVA: 0x1BFEC9C Offset: 0x1BFAC9C VA: 0x1BFEC9C
	private void onSelectTarget() { }

	// RVA: 0x1BFFC8C Offset: 0x1BFBC8C VA: 0x1BFFC8C
	private void onOpenKennelList() { }

	// RVA: 0x1BFFCE8 Offset: 0x1BFBCE8 VA: 0x1BFFCE8
	public void OnOpenPetCageList() { }

	// RVA: 0x1BFFD44 Offset: 0x1BFBD44 VA: 0x1BFFD44 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1BFFF9C Offset: 0x1BFBF9C VA: 0x1BFFF9C Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1C00150 Offset: 0x1BFC150 VA: 0x1C00150
	public void .ctor() { }
}
