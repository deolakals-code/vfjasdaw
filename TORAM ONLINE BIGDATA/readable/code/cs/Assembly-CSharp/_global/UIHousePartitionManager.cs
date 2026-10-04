// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIHousePartitionManager : UIBasePanel // TypeDefIndex: 7317
{
	// Fields
	[SerializeField]
	private GameObject enterButton; // 0x30
	[SerializeField]
	private Transform parentTopPanel; // 0x38
	[SerializeField]
	private GameObject topButton; // 0x40
	[SerializeField]
	private GameObject addPanelButton; // 0x48
	[SerializeField]
	private GameObject orbButton; // 0x50
	[SerializeField]
	private GameObject goldButton; // 0x58
	[SerializeField]
	private GameObject errLabelObject; // 0x60
	private UILabel errLabel; // 0x68
	private TweenAlpha errLabelTween; // 0x70
	[SerializeField]
	private GameObject coinIcon; // 0x78
	[SerializeField]
	private UIInput deleteInput; // 0x80
	[SerializeField]
	private Transform deleteInputPanel; // 0x88
	private UIHouseEditPanel editPanel; // 0x90
	private Dictionary<int, GameObject> addButtonList; // 0x98
	private int selectedChipType; // 0xA0
	private bool updateHome; // 0xA4
	private Vector3 point; // 0xA8
	private Vector3 size; // 0xB4
	private Dictionary<HousePartsType, List<UIHousePartitionManager.HouseParts>> editData; // 0xC0
	private float ChipSize; // 0xC8
	private HouseManager houseManager; // 0xD0
	private HousePartitionManager housePartitionManager; // 0xD8
	private int editStartPartitionId; // 0xE0
	private GameObject startIcon; // 0xE8
	private bool cancelCheck; // 0xF0
	private int selectedBuyPartitionType; // 0xF4
	private GameObject[] categoryButton; // 0xF8
	private Collider[] categoryButtonCol; // 0x100
	private PetDataManager petDataManager; // 0x108
	private bool isInit; // 0x110

	// Methods

	[IteratorStateMachine(typeof(UIHousePartitionManager.<Start>d__34))]
	// RVA: 0x1B0374C Offset: 0x1AFF74C VA: 0x1B0374C
	public IEnumerator Start() { }

	// RVA: 0x1B037C0 Offset: 0x1AFF7C0 VA: 0x1B037C0
	private void UpdatePanel() { }

	// RVA: 0x1B0396C Offset: 0x1AFF96C VA: 0x1B0396C
	private void UpdateLand() { }

	// RVA: 0x1B03DD8 Offset: 0x1AFFDD8 VA: 0x1B03DD8
	private void CreateAddButton(int id, Vector3 pos) { }

	// RVA: 0x1B040E8 Offset: 0x1B000E8 VA: 0x1B040E8
	public void OnClickAddPanel(int area) { }

	[IteratorStateMachine(typeof(UIHousePartitionManager.<ClickAddPanelPopUpWindow>d__39))]
	// RVA: 0x1B04118 Offset: 0x1B00118 VA: 0x1B04118
	private IEnumerator ClickAddPanelPopUpWindow(int area) { }

	// RVA: 0x1B0419C Offset: 0x1B0019C VA: 0x1B0419C
	private void PartitionUpdate() { }

	// RVA: 0x1B041E0 Offset: 0x1B001E0 VA: 0x1B041E0
	private void OnClickSelectBuyPartitionType(int id) { }

	// RVA: 0x1B0425C Offset: 0x1B0025C VA: 0x1B0425C
	private void EbabledCategoryButton(bool enabled) { }

	// RVA: 0x1B04330 Offset: 0x1B00330 VA: 0x1B04330
	public void OnEditTypeClick(int id) { }

	// RVA: 0x1B04474 Offset: 0x1B00474 VA: 0x1B04474
	public void OnClickPanel(int chipId, Vector3 touchDist) { }

	// RVA: 0x1B06698 Offset: 0x1B02698 VA: 0x1B06698
	private List<UIHousePartitionManager.HouseParts> GetPartsList(HousePartsType type) { }

	// RVA: 0x1B04888 Offset: 0x1B00888 VA: 0x1B04888
	private void ChangePartitionRoomEdit(int chipId, Vector3 dist) { }

	// RVA: 0x1B06778 Offset: 0x1B02778 VA: 0x1B06778
	private bool CheckWallPanel(int panelId) { }

	// RVA: 0x1B06A14 Offset: 0x1B02A14 VA: 0x1B06A14
	private bool CheckRoomWallPanel(int panelId) { }

	// RVA: 0x1B05684 Offset: 0x1B01684 VA: 0x1B05684
	private void ChangeWindowEdit(int chipId, Vector3 touchDist) { }

	// RVA: 0x1B05044 Offset: 0x1B01044 VA: 0x1B05044
	private void ChangeDoorEdit(int chipId, Vector3 touchDist) { }

	// RVA: 0x1B05C58 Offset: 0x1B01C58 VA: 0x1B05C58
	private void ChangeRoomWallEdit(int chipId, Vector3 touchDist) { }

	// RVA: 0x1B04614 Offset: 0x1B00614 VA: 0x1B04614
	private void ChangeStartPointEdit(int chipId, Vector3 dist) { }

	// RVA: 0x1B062AC Offset: 0x1B022AC VA: 0x1B062AC
	private void ChangePetPositionEdit(int chipId, Vector3 dist) { }

	// RVA: 0x1B06CB0 Offset: 0x1B02CB0 VA: 0x1B06CB0
	private string GetPetName(int index) { }

	// RVA: 0x1B06CD4 Offset: 0x1B02CD4 VA: 0x1B06CD4
	private void OnDragOverCheck() { }

	// RVA: 0x1B06DB8 Offset: 0x1B02DB8 VA: 0x1B06DB8
	public void OnEnterMyHomeCreate() { }

	// RVA: 0x1B06DC0 Offset: 0x1B02DC0 VA: 0x1B06DC0
	private void OnEnterMyHomeCreate(bool connectWait) { }

	[IteratorStateMachine(typeof(UIHousePartitionManager.<Connection>d__58))]
	// RVA: 0x1B07840 Offset: 0x1B03840 VA: 0x1B07840
	private IEnumerator Connection(Action callback) { }

	[IteratorStateMachine(typeof(UIHousePartitionManager.<PopUpWarningWindow>d__59))]
	// RVA: 0x1B078D0 Offset: 0x1B038D0 VA: 0x1B078D0
	private IEnumerator PopUpWarningWindow(string title, string messageText, Action command, Action cancel) { }

	[IteratorStateMachine(typeof(UIHousePartitionManager.<HouseAllClearDeleteInput>d__60))]
	// RVA: 0x1B04400 Offset: 0x1B00400 VA: 0x1B04400
	private IEnumerator HouseAllClearDeleteInput() { }

	// RVA: 0x1B079A4 Offset: 0x1B039A4 VA: 0x1B079A4 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1B07C20 Offset: 0x1B03C20 VA: 0x1B07C20 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1B07E9C Offset: 0x1B03E9C VA: 0x1B07E9C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1B08074 Offset: 0x1B04074 VA: 0x1B08074
	private void <ClickAddPanelPopUpWindow>b__39_1() { }

	[CompilerGenerated]
	// RVA: 0x1B0819C Offset: 0x1B0419C VA: 0x1B0819C
	private void <OnEnterMyHomeCreate>b__57_1() { }
}
