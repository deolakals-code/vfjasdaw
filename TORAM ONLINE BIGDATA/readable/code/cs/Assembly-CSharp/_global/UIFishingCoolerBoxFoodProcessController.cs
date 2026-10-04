// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIFishingCoolerBoxFoodProcessController : MonoBehaviour // TypeDefIndex: 7024
{
	// Fields
	[SerializeField]
	private GameObject[] panels; // 0x20
	[SerializeField]
	private UILabel titleLabel; // 0x28
	[SerializeField]
	private UISprite titleIcon; // 0x30
	[SerializeField]
	private UILabel confirmationDescriptionLabel; // 0x38
	[SerializeField]
	private UIImageButton confirmationButton; // 0x40
	[SerializeField]
	private UILabel confirmationButtonLabel; // 0x48
	[SerializeField]
	private UISlider loadSlider; // 0x50
	[SerializeField]
	private UILabel[] resultFoodPointLabels; // 0x58
	private SystemTextManager systemTextManager; // 0x60
	private PlayerDataManager playerDataManager; // 0x68
	private UIFishingCoolerBoxFoodProcessController.ScreenStatus currentScreenStatus; // 0x70
	private short[] processFishListIndexArray; // 0x78
	private Coroutine loadCoroutine; // 0x80
	private int totalFoodPoint; // 0x88
	private Action<string> errorMethod; // 0x90

	// Properties
	public UIFishingCoolerBoxFoodProcessController.ScreenStatus CurrentScreenStatus { get; }

	// Methods

	// RVA: 0x1A783C4 Offset: 0x1A743C4 VA: 0x1A783C4
	public UIFishingCoolerBoxFoodProcessController.ScreenStatus get_CurrentScreenStatus() { }

	// RVA: 0x1A783CC Offset: 0x1A743CC VA: 0x1A783CC
	private void Start() { }

	// RVA: 0x1A784B4 Offset: 0x1A744B4 VA: 0x1A784B4
	public void Initialize(short[] processFishIndexList, Action<string> errorMethod) { }

	// RVA: 0x1A78620 Offset: 0x1A74620 VA: 0x1A78620
	public void OnClickProcessDecision() { }

	// RVA: 0x1A78688 Offset: 0x1A74688 VA: 0x1A78688
	public void InitializeResult(int totalFoodPoint) { }

	// RVA: 0x1A787B4 Offset: 0x1A747B4 VA: 0x1A787B4
	public void LoadCancel() { }

	// RVA: 0x1A784F4 Offset: 0x1A744F4 VA: 0x1A784F4
	private void ChangePanel(UIFishingCoolerBoxFoodProcessController.ScreenStatus screenStatus) { }

	// RVA: 0x1A78840 Offset: 0x1A74840 VA: 0x1A78840
	private void InitializeConfirmationScreen() { }

	// RVA: 0x1A78E30 Offset: 0x1A74E30 VA: 0x1A78E30
	private void InitializeLoadingScreen() { }

	// RVA: 0x1A786A4 Offset: 0x1A746A4 VA: 0x1A786A4
	private void InitializeResultScreen(int totalFoodPoint) { }

	[IteratorStateMachine(typeof(UIFishingCoolerBoxFoodProcessController.<ProcessLoadingBar>d__27))]
	// RVA: 0x1A78E60 Offset: 0x1A74E60 VA: 0x1A78E60
	private IEnumerator ProcessLoadingBar() { }

	// RVA: 0x1A78EF4 Offset: 0x1A74EF4 VA: 0x1A78EF4
	public void .ctor() { }
}
