// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UICreateFishingRodManager : UIBasePanelConnection // TypeDefIndex: 7019
{
	// Fields
	[SerializeField]
	private GameObject mainPanel; // 0x30
	[SerializeField]
	private GameObject[] panelObjs; // 0x38
	[SerializeField]
	private GameObject titleLabel; // 0x40
	[SerializeField]
	private GameObject frameObject; // 0x48
	[SerializeField]
	[Header(" - RodSelect - ")]
	private UIImageButton discardButton; // 0x50
	[SerializeField]
	private UIImageButton inheritanceButton; // 0x58
	[SerializeField]
	private UIImageButton normalCreateButton; // 0x60
	[SerializeField]
	private UICreateFishingRodManager.FishingRodManagementButton[] rodManagementButtons; // 0x68
	[SerializeField]
	private UIFishingRodStatusDisplayManager[] rodStatuses; // 0x70
	[Header(" - Discard - ")]
	[SerializeField]
	private UIFishingRodStatusDisplayManager discardRodStatus; // 0x78
	[SerializeField]
	private UISlider discardLoadSlider; // 0x80
	[Header(" - MaterialSlect - ")]
	[SerializeField]
	private UILabel[] materialTitleTexts; // 0x88
	[SerializeField]
	private UILabel[] materialsCountTexts; // 0x90
	[SerializeField]
	private UIImageButton createButton; // 0x98
	[SerializeField]
	private UILabel totalMaterialPointTitleLabel; // 0xA0
	[SerializeField]
	private UISlider totalMaterialPointSlider; // 0xA8
	[SerializeField]
	private UILabel totalMaterilaPointText; // 0xB0
	[SerializeField]
	private GameObject materialWindowPanel; // 0xB8
	[SerializeField]
	private UIButtonScale[] buttonScales; // 0xC0
	[SerializeField]
	private UIFishingRodStatusBar[] rodStatusBars; // 0xC8
	[Header(" - Loading - ")]
	[SerializeField]
	private UISprite loadRodIcon; // 0xD0
	[SerializeField]
	private UISlider loadSlider; // 0xD8
	[Header(" - Result - ")]
	[SerializeField]
	private UIFishingRodStatusDisplayManager resultRodStatus; // 0xE0
	private PlayerDataManager playerDataManager; // 0xE8
	private UICreateFishingRodManager.ScreenType screenType; // 0xF0
	private int[] materialPoints; // 0xF8
	private byte selectSlodIndex; // 0x100
	private bool isSuccession; // 0x101
	private Coroutine loadCoroutine; // 0x108
	private UIPopWindow popWindow; // 0x110
	private bool isMaterialSelect; // 0x118
	private UIIruna2Anchor materialWindowAnchor; // 0x120
	private UILabel createButtonLabel; // 0x128
	public readonly int MaterialMaxPoint; // 0x130

	// Properties
	private bool inputLock { get; }
	private int totalMaterialPoint { get; }
	public int TotalMaterialPoint { get; }
	public MaterialManager MaterialManager { get; }

	// Methods

	// RVA: 0x1A74570 Offset: 0x1A70570 VA: 0x1A74570
	private bool get_inputLock() { }

	// RVA: 0x1A74580 Offset: 0x1A70580 VA: 0x1A74580
	private int get_totalMaterialPoint() { }

	// RVA: 0x1A7467C Offset: 0x1A7067C VA: 0x1A7467C
	public int get_TotalMaterialPoint() { }

	// RVA: 0x1A74680 Offset: 0x1A70680 VA: 0x1A74680
	public MaterialManager get_MaterialManager() { }

	// RVA: 0x1A7469C Offset: 0x1A7069C VA: 0x1A7469C
	private void Start() { }

	// RVA: 0x1A74A5C Offset: 0x1A70A5C VA: 0x1A74A5C
	private void OnDestroy() { }

	// RVA: 0x1A74820 Offset: 0x1A70820 VA: 0x1A74820
	private void ChangeScreenObjects(UICreateFishingRodManager.ScreenType type) { }

	// RVA: 0x1A7539C Offset: 0x1A7139C VA: 0x1A7539C
	private void BackMainGame() { }

	// RVA: 0x1A746B8 Offset: 0x1A706B8 VA: 0x1A746B8
	private void Initialize() { }

	// RVA: 0x1A74B04 Offset: 0x1A70B04 VA: 0x1A74B04
	private void InitializeRodSelectScreen() { }

	// RVA: 0x1A74C38 Offset: 0x1A70C38 VA: 0x1A74C38
	private void InitializeDiscardScreen() { }

	// RVA: 0x1A74D4C Offset: 0x1A70D4C VA: 0x1A74D4C
	private void InitializeMaterialSelectScreen() { }

	// RVA: 0x1A75208 Offset: 0x1A71208 VA: 0x1A75208
	private void InitializeLoadingScreen() { }

	// RVA: 0x1A75344 Offset: 0x1A71344 VA: 0x1A75344
	private void InitializeResultScreen() { }

	[IteratorStateMachine(typeof(UICreateFishingRodManager.<LoadingWait>d__56))]
	// RVA: 0x1A753F8 Offset: 0x1A713F8 VA: 0x1A753F8
	private IEnumerator LoadingWait(float waitTime, UISlider slider, Action callBack) { }

	// RVA: 0x1A75570 Offset: 0x1A71570 VA: 0x1A75570
	private void CompletedDiscard(byte rodIndex) { }

	// RVA: 0x1A75610 Offset: 0x1A71610 VA: 0x1A75610
	private void OpenMaterialWindow() { }

	// RVA: 0x1A756E8 Offset: 0x1A716E8 VA: 0x1A756E8
	private void CloseMaterialWindow() { }

	// RVA: 0x1A757A8 Offset: 0x1A717A8 VA: 0x1A757A8
	private void ApplyCreateStatusVisual() { }

	// RVA: 0x1A754AC Offset: 0x1A714AC VA: 0x1A754AC
	private void ChangeCreateButtonVisual(bool isActive) { }

	// RVA: 0x1A759C8 Offset: 0x1A719C8 VA: 0x1A759C8
	private void Create() { }

	// RVA: 0x1A75BBC Offset: 0x1A71BBC VA: 0x1A75BBC
	public void OnClickRodManagement(int index) { }

	// RVA: 0x1A75C90 Offset: 0x1A71C90 VA: 0x1A75C90
	public void OnDiscardCancelLoading() { }

	// RVA: 0x1A75D20 Offset: 0x1A71D20 VA: 0x1A75D20
	public void OnClickAddMaterial() { }

	// RVA: 0x1A75D9C Offset: 0x1A71D9C VA: 0x1A75D9C
	public void OnClickConfirmButton() { }

	// RVA: 0x1A75E20 Offset: 0x1A71E20 VA: 0x1A75E20
	public int ApplyMaterialPoint(int materialType, int point) { }

	// RVA: 0x1A75F48 Offset: 0x1A71F48 VA: 0x1A75F48
	public float GetMaterialPointRemoveOneMaterial(int materialType) { }

	// RVA: 0x1A75FB8 Offset: 0x1A71FB8 VA: 0x1A75FB8
	public void OnClickCloseMaterialWindow() { }

	// RVA: 0x1A76034 Offset: 0x1A72034 VA: 0x1A76034
	public void OnCancelLoading() { }

	// RVA: 0x1A760C4 Offset: 0x1A720C4 VA: 0x1A760C4
	public void OnClickResult() { }

	// RVA: 0x1A7612C Offset: 0x1A7212C VA: 0x1A7612C
	public void PopErrorWindow() { }

	// RVA: 0x1A763F4 Offset: 0x1A723F4 VA: 0x1A763F4
	public void SetResultRodStatus(FishingRodClientData rodData) { }

	// RVA: 0x1A76444 Offset: 0x1A72444 VA: 0x1A76444 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1A76588 Offset: 0x1A72588 VA: 0x1A76588 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1A76658 Offset: 0x1A72658 VA: 0x1A76658
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1A76750 Offset: 0x1A72750 VA: 0x1A76750
	private void <InitializeDiscardScreen>b__52_0() { }
}
