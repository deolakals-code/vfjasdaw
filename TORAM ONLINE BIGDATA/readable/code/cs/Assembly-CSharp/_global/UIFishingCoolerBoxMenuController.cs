// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIFishingCoolerBoxMenuController : MonoBehaviour // TypeDefIndex: 7033
{
	// Fields
	[SerializeField]
	private UIFishingCoolerBoxFoodProcessController foodProcessController; // 0x20
	[SerializeField]
	private UILabel descriptionLabel; // 0x28
	[SerializeField]
	private GameObject[] panels; // 0x30
	[SerializeField]
	private GameObject processingButton; // 0x38
	[SerializeField]
	private UIImageButton processingStartButton; // 0x40
	[SerializeField]
	private GameObject duplicationContent; // 0x48
	[SerializeField]
	private UIScrollWindow scrollWindow; // 0x50
	[SerializeField]
	private Transform scrollWindowTopBar; // 0x58
	[SerializeField]
	private Transform scrollWindowBottomBar; // 0x60
	[SerializeField]
	private GameObject[] bar; // 0x68
	[SerializeField]
	private GameObject barParent; // 0x70
	[SerializeField]
	private GameObject griadPanel; // 0x78
	[SerializeField]
	private BoxCollider dragCameraBoxCollider; // 0x80
	[SerializeField]
	private UILabel detailsFishNameLabel; // 0x88
	[SerializeField]
	private UILabel detailsFishSizeLabel; // 0x90
	[SerializeField]
	private GameObject detailsStarIcon; // 0x98
	[SerializeField]
	private GameObject detailsCrownIcon; // 0xA0
	[SerializeField]
	private Transform d3ViewRotParent; // 0xA8
	[SerializeField]
	private UILabel dateilsFishingDateLabel; // 0xB0
	private SystemTextManager systemTextManager; // 0xB8
	private Action rollbackAction; // 0xC0
	private UIFishingCoolerBoxMenuController.ScreenStatus currentScreenStatus; // 0xC8
	private List<short> processFishIndexList; // 0xD0
	private float topBarYPosition; // 0xD8
	private List<UIFishingCoolerBoxButtonController> buttonControllers; // 0xE0
	private short creatMaxCount; // 0xE8
	private short creatCount; // 0xEA
	private const float objectDistance = 80;
	private bool isActive; // 0xEC
	private GameObject fishDetailModel; // 0xF0
	private MobAnimation mobAnimation; // 0xF8
	private FishingFishClientData selectDetailFishData; // 0x100
	private UIPopWindow popWindow; // 0x108
	private UIFishingCoolerBoxMenuController.FishSortList fishSortList; // 0x110

	// Properties
	public UIFishingCoolerBoxMenuController.ScreenStatus CurrentScreenStatus { get; }
	public bool DragCameraBoxColliderEnabled { get; }

	// Methods

	// RVA: 0x1A79374 Offset: 0x1A75374 VA: 0x1A79374
	public UIFishingCoolerBoxMenuController.ScreenStatus get_CurrentScreenStatus() { }

	// RVA: 0x1A7937C Offset: 0x1A7537C VA: 0x1A7937C
	public bool get_DragCameraBoxColliderEnabled() { }

	// RVA: 0x1A79398 Offset: 0x1A75398 VA: 0x1A79398
	private void Awake() { }

	// RVA: 0x1A79494 Offset: 0x1A75494 VA: 0x1A79494
	private void Update() { }

	// RVA: 0x1A79504 Offset: 0x1A75504 VA: 0x1A79504
	private void OnDestroy() { }

	// RVA: 0x1A795AC Offset: 0x1A755AC VA: 0x1A795AC
	public void GenerateTiming(Action rollBackAction) { }

	// RVA: 0x1A7A158 Offset: 0x1A76158 VA: 0x1A7A158
	public void OnClickProcessingButton() { }

	// RVA: 0x1A778FC Offset: 0x1A738FC VA: 0x1A778FC
	public void UpdateProcessList(bool isAdd, short index) { }

	// RVA: 0x1A7A5A8 Offset: 0x1A765A8 VA: 0x1A7A5A8
	public void OnClickProcessingStartButton() { }

	// RVA: 0x1A77724 Offset: 0x1A73724 VA: 0x1A77724
	public bool ProcessListIndexContains(short index) { }

	// RVA: 0x1A7A610 Offset: 0x1A76610 VA: 0x1A7A610
	public void OnClickProcessResultOnOk() { }

	// RVA: 0x1A77B18 Offset: 0x1A73B18 VA: 0x1A77B18
	public void InitializeDetailsScreen(FishingFishClientData fishData) { }

	// RVA: 0x1A7A674 Offset: 0x1A76674 VA: 0x1A7A674
	public void OnClickCloseDetailsScreen() { }

	// RVA: 0x1A7A74C Offset: 0x1A7674C VA: 0x1A7A74C
	public void OnClickLeftTopButton() { }

	// RVA: 0x1A7A920 Offset: 0x1A76920 VA: 0x1A7A920
	public void OnClickRightTopButton() { }

	// RVA: 0x1A795C8 Offset: 0x1A755C8 VA: 0x1A795C8
	private void Initialize() { }

	// RVA: 0x1A7A1C0 Offset: 0x1A761C0 VA: 0x1A7A1C0
	private void ChangeScreen(UIFishingCoolerBoxMenuController.ScreenStatus screenStatus) { }

	[IteratorStateMachine(typeof(UIFishingCoolerBoxMenuController.<CreateScrollList>d__55))]
	// RVA: 0x1A7B448 Offset: 0x1A77448 VA: 0x1A7B448
	private IEnumerator CreateScrollList(Action callBack) { }

	// RVA: 0x1A7B648 Offset: 0x1A77648 VA: 0x1A7B648
	private void SetFishModel(GameObject model, float fishSizeMagnification) { }

	// RVA: 0x1A7B4D0 Offset: 0x1A774D0 VA: 0x1A7B4D0
	private void ChangeProcessingMode(bool isActive) { }

	// RVA: 0x1A7A83C Offset: 0x1A7683C VA: 0x1A7A83C
	private void LeftTopButton() { }

	// RVA: 0x1A7A9B0 Offset: 0x1A769B0 VA: 0x1A7A9B0
	private void RightTopButton() { }

	// RVA: 0x1A7B8BC Offset: 0x1A778BC VA: 0x1A7B8BC
	private void ErrorAction(string messageKey) { }

	// RVA: 0x1A7A7E0 Offset: 0x1A767E0 VA: 0x1A7A7E0
	private void ErrorCallBackAction() { }

	// RVA: 0x1A7BAB0 Offset: 0x1A77AB0 VA: 0x1A7BAB0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1A7BB20 Offset: 0x1A77B20 VA: 0x1A7BB20
	private void <ErrorAction>b__60_0() { }
}
