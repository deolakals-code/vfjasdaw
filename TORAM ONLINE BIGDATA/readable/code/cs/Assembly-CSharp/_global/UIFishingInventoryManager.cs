// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIFishingInventoryManager : UIBasePanelConnection // TypeDefIndex: 7051
{
	// Fields
	[SerializeField]
	private GameObject mainPanel; // 0x30
	[SerializeField]
	private UILabel titleLabel; // 0x38
	[SerializeField]
	private UISprite titleIcon; // 0x40
	[SerializeField]
	private GameObject[] screenObjects; // 0x48
	[SerializeField]
	private UILabel currentCapacityLabel; // 0x50
	[SerializeField]
	private UIImageButton addCapacityButton; // 0x58
	[SerializeField]
	private UILabel possessionOrbLabel; // 0x60
	[SerializeField]
	private UIImageButton orbButton; // 0x68
	[SerializeField]
	private UISprite orbButtonBase; // 0x70
	[SerializeField]
	private UILabel possessionGoldLabel; // 0x78
	[SerializeField]
	private UIImageButton goldButton; // 0x80
	[SerializeField]
	private UILabel useGoldButtonLabel; // 0x88
	[SerializeField]
	private UISlider loadSlider; // 0x90
	[SerializeField]
	private UISprite[] rodIcons; // 0x98
	[SerializeField]
	private UILabel submergedItemLabel; // 0xA0
	[SerializeField]
	private UILabel coolerBoxLabel; // 0xA8
	private OrbManager orbManager; // 0xB0
	private UIFishingInventoryManager.ScreenState screenState; // 0xB8
	private UIPopBaseWindow popWindow; // 0xC0
	private const byte useOrbItemNum = 1;
	private const int useGoldConstantValue = 100000;
	private Coroutine loadCoroutine; // 0xC8
	private bool isUseOrb; // 0xD0
	private UIFishingInventoryManager.RodIconStatus[] rodIconStatuses; // 0xD8
	private UIFishingSubmergedItemMenuController submergedItemMenuController; // 0xE0
	private GameObject coolerBoxMenuObject; // 0xE8
	private UIFishingCoolerBoxMenuController coolerBoxMenuController; // 0xF0

	// Properties
	private int orbNum { get; }
	private int gold { get; }

	// Methods

	// RVA: 0x1A80288 Offset: 0x1A7C288 VA: 0x1A80288
	private int get_orbNum() { }

	// RVA: 0x1A802A4 Offset: 0x1A7C2A4 VA: 0x1A802A4
	private int get_gold() { }

	[IteratorStateMachine(typeof(UIFishingInventoryManager.<Start>d__33))]
	// RVA: 0x1A8031C Offset: 0x1A7C31C VA: 0x1A8031C
	private IEnumerator Start() { }

	// RVA: 0x1A803B0 Offset: 0x1A7C3B0 VA: 0x1A803B0
	private void OnDestroy() { }

	// RVA: 0x1A804DC Offset: 0x1A7C4DC VA: 0x1A804DC
	private void Initialize() { }

	// RVA: 0x1A809CC Offset: 0x1A7C9CC VA: 0x1A809CC
	private void ChangeScreen(UIFishingInventoryManager.ScreenState state) { }

	// RVA: 0x1A80600 Offset: 0x1A7C600 VA: 0x1A80600
	private void ResetRodGauge() { }

	// RVA: 0x1A8085C Offset: 0x1A7C85C VA: 0x1A8085C
	private void UpdateCoolerBoxMenu() { }

	// RVA: 0x1A80828 Offset: 0x1A7C828 VA: 0x1A80828
	private void UpdateSubmergedItemLabel() { }

	// RVA: 0x1A80F78 Offset: 0x1A7CF78 VA: 0x1A80F78
	private void InitializeAddBoxCapacity() { }

	// RVA: 0x1A81244 Offset: 0x1A7D244 VA: 0x1A81244
	private void InitializeLoadingScreen() { }

	[IteratorStateMachine(typeof(UIFishingInventoryManager.<AddCapacityLoadingBar>d__42))]
	// RVA: 0x1A8129C Offset: 0x1A7D29C VA: 0x1A8129C
	private IEnumerator AddCapacityLoadingBar() { }

	// RVA: 0x1A81330 Offset: 0x1A7D330 VA: 0x1A81330
	private void AddCapacity() { }

	[IteratorStateMachine(typeof(UIFishingInventoryManager.<ReleaseWaitWindow>d__44))]
	// RVA: 0x1A81474 Offset: 0x1A7D474 VA: 0x1A81474
	private IEnumerator ReleaseWaitWindow() { }

	// RVA: 0x1A811C8 Offset: 0x1A7D1C8 VA: 0x1A811C8
	private int CalculateFishBagExpansionCost() { }

	// RVA: 0x1A81538 Offset: 0x1A7D538 VA: 0x1A81538
	private void LeftTopButton() { }

	// RVA: 0x1A816E4 Offset: 0x1A7D6E4 VA: 0x1A816E4
	private void RightTopButton() { }

	// RVA: 0x1A8179C Offset: 0x1A7D79C VA: 0x1A8179C
	public void ChangeMainPanel() { }

	// RVA: 0x1A817A4 Offset: 0x1A7D7A4 VA: 0x1A817A4
	public void OnClickSubmergedItem() { }

	// RVA: 0x1A81868 Offset: 0x1A7D868 VA: 0x1A81868
	public void OnClickCoolerBox() { }

	// RVA: 0x1A81918 Offset: 0x1A7D918 VA: 0x1A81918
	public void OnClickAddCapacityButton() { }

	// RVA: 0x1A8197C Offset: 0x1A7D97C VA: 0x1A8197C
	public void OnClickCreateRodButton() { }

	// RVA: 0x1A81A08 Offset: 0x1A7DA08 VA: 0x1A81A08
	public void OnClickAddCapacity(bool isUseOrb) { }

	// RVA: 0x1A81ABC Offset: 0x1A7DABC VA: 0x1A81ABC
	public void OnClickCancelLoad() { }

	// RVA: 0x1A81B48 Offset: 0x1A7DB48 VA: 0x1A81B48 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1A81BD8 Offset: 0x1A7DBD8 VA: 0x1A81BD8 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1A81C68 Offset: 0x1A7DC68 VA: 0x1A81C68
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1A81C70 Offset: 0x1A7DC70 VA: 0x1A81C70
	private void <Start>b__33_1() { }

	[CompilerGenerated]
	// RVA: 0x1A81D08 Offset: 0x1A7DD08 VA: 0x1A81D08
	private void <AddCapacity>b__43_0() { }
}
