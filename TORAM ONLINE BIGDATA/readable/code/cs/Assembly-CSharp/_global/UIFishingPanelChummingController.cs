// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIFishingPanelChummingController : MonoBehaviour // TypeDefIndex: 7055
{
	// Fields
	[SerializeField]
	private UIFishingPanelManager panelManager; // 0x20
	[SerializeField]
	private GameObject chummingPanel; // 0x28
	[SerializeField]
	private GameObject[] chummingUIWindows; // 0x30
	[SerializeField]
	private UILabel currentSpeedLabel; // 0x38
	[SerializeField]
	private UILabel useSpinaLabel; // 0x40
	[SerializeField]
	private UIImageButton useSpinaButton; // 0x48
	[SerializeField]
	private UILabel useSpinaButtonLabel; // 0x50
	[SerializeField]
	private GameObject[] changeUseSpinaButtons; // 0x58
	[SerializeField]
	private UILabel resultSpeedLabel; // 0x60
	[SerializeField]
	private UILabel usedSpinaLabel; // 0x68
	[SerializeField]
	private UILabel effectValueLabel; // 0x70
	private SystemTextManager systemTextManager; // 0x78
	private UIFishingPanelChummingController.ChummingUIStatus chummingUIStatus; // 0x80
	private int chummingCount; // 0x84
	private Action updateChummingButtonLabelAction; // 0x88

	// Properties
	public UIFishingPanelChummingController.ChummingUIStatus _ChummingUIStatus { get; }
	public Action UpdateChummingButtonLabelAction { get; }

	// Methods

	// RVA: 0x1A830A4 Offset: 0x1A7F0A4 VA: 0x1A830A4
	public UIFishingPanelChummingController.ChummingUIStatus get__ChummingUIStatus() { }

	// RVA: 0x1A830AC Offset: 0x1A7F0AC VA: 0x1A830AC
	public Action get_UpdateChummingButtonLabelAction() { }

	// RVA: 0x1A830B4 Offset: 0x1A7F0B4 VA: 0x1A830B4
	private void Update() { }

	// RVA: 0x1A83130 Offset: 0x1A7F130 VA: 0x1A83130
	private void UpdateChummingSelectUI() { }

	// RVA: 0x1A8351C Offset: 0x1A7F51C VA: 0x1A8351C
	public void Initialize(Action updateChummingButtonLabelAction) { }

	// RVA: 0x1A83914 Offset: 0x1A7F914 VA: 0x1A83914
	public void ChangePanelActiveState(bool active) { }

	// RVA: 0x1A8353C Offset: 0x1A7F53C VA: 0x1A8353C
	public void ChangeChummingUI(UIFishingPanelChummingController.ChummingUIStatus status) { }

	// RVA: 0x1A83934 Offset: 0x1A7F934 VA: 0x1A83934
	public void ChummingResponseFailure() { }

	// RVA: 0x1A8396C Offset: 0x1A7F96C VA: 0x1A8396C
	public void OnClickChangeChummingUI(int pageIndex) { }

	// RVA: 0x1A83B00 Offset: 0x1A7FB00 VA: 0x1A83B00
	public void OnClickChangeChummingCount(bool isPlus) { }

	// RVA: 0x1A83C2C Offset: 0x1A7FC2C VA: 0x1A83C2C
	public void .ctor() { }
}
